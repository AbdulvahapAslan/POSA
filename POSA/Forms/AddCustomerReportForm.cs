using Dapper;
using POSA.Helpers.Settings;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using static Dapper.SqlMapper;
namespace POSA.Forms
{
    public partial class AddCustomerReportForm : Form
    {
        public AddCustomerReportForm()
        {
            InitializeComponent();
            System.Threading.Thread.CurrentThread.CurrentUICulture = new CultureInfo("en_GB");
        }
        private void pbClearSearch_Click(object sender, EventArgs e)
        {
            rtbSearch.Texts = "";
        }
        private async void AddCustomerReportForm_Load(object sender, EventArgs e)
        {
            dgvMain.Columns.Insert(0, new DataGridViewImageColumn()
            {
                Image = Properties.Resources._24pxRedTrash,
                Name = "DELETE",
                HeaderText = "",
                FillWeight = 5,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
            dgvMain.Columns.Insert(dgvMain.ColumnCount - 1, new DataGridViewImageColumn()
            {
                Image = Properties.Resources._24pxBlueRefresh,
                Name = "UPDATE",
                HeaderText = "GÜNCELLE",
                FillWeight = 5,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
            dgvMain.Columns.Insert(dgvMain.ColumnCount - 1, new DataGridViewImageColumn()
            {
                Image = Properties.Resources._24pxBlueChart,
                Name = "REPORT",
                HeaderText = "RAPOR",
                FillWeight = 5,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
            dgvMain.Columns.Insert(dgvMain.ColumnCount - 1, new DataGridViewImageColumn()
            {
                Image = Properties.Resources._24pxBluePlus,
                Name = "ADD",
                HeaderText = "BORÇ EKLE",
                FillWeight = 5,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
            dgvMain.Columns.Insert(dgvMain.ColumnCount - 1, new DataGridViewImageColumn()
            {
                Image = Properties.Resources._24pxBlueBox,
                Name = "TAKE",
                HeaderText = "TAHSİLAT",
                FillWeight = 5,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
            dgvMain.Columns["DELETE"].FillWeight = 5;
            dgvMain.Columns["UPDATE"].FillWeight = 10;
            dgvMain.Columns["REPORT"].FillWeight = 10;
            dgvMain.Columns["ADD"].FillWeight = 20;
            dgvMain.Columns["TAKE"].FillWeight = 15;
            dgvMain.EndEdit();
            var settings = Setting.Get();
            var qry = $"""
                WITH TABLO AS(SELECT TOP 200 CST.ID,CST.NAME,CST.PHONE FROM CUSTOMERS AS CST ORDER BY ID)
                SELECT T.*,ISNULL((SELECT SUM(FL.TOTALPRICE) FROM FICHES AS F LEFT JOIN 
                FICHELINES AS FL ON FL.FICHEREF = F.FICHEREF
                WHERE F.FICHETYPE = 2 AND F.CUSTOMERID = T.ID),0) AS DEPTH 
                FROM TABLO AS T ORDER BY T.ID
                """;
            await using var conn = new SqlConnection(settings.Sql.ConnectionString());
            conn.Open();
            var ar = new SqlDataAdapter(qry, conn);
            var dt = new DataTable();
            ar.Fill(dt);
            dgvMain.DataSource = dt;
            dgvMain.ClearSelection();
        }
        private void dgvMain_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvMain.Columns["DELETE"].Index)
            {
                var dr = MessageBox.Show("Silmek istediğinize emin misiniz?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (dr == DialogResult.Yes)
                {
                    DeleteFromDB((dgvMain.Rows[e.RowIndex].Cells["ID"].Value ?? "").ToString());
                    RefreshMainDataGrid();
                }
            }
            else if (e.ColumnIndex == dgvMain.Columns["ADD"].Index)
            {
                pnlDepthAmount.Visible = true;
                LastAddDepthRowIndex = e.RowIndex;
            }
            else if (e.ColumnIndex == dgvMain.Columns["TAKE"].Index)
            {
                pnlDepthAmount.Visible = true;
                isTakeMoney = true;
                LastAddDepthRowIndex = e.RowIndex;
            }
            else if (e.ColumnIndex == dgvMain.Columns["UPDATE"].Index)
            {
                var addC = new AddCustomerInnerForm(true,Convert.ToInt32(dgvMain.Rows[e.RowIndex].Cells["ID"].Value.ToString()));
                DialogResult dr = addC.ShowDialog();
                if (dr == DialogResult.OK)
                    RefreshMainDataGrid();

            }
            else if (e.ColumnIndex == dgvMain.Columns["REPORT"].Index)
            {
                //TODO: SHOW REPORT 
            }
        }
        public int LastAddDepthRowIndex = -1;
        public async Task<bool> AddFicheHead(string paymentType, string ficheRef, int ficheType, decimal totalPrice, int custId, SqlTransaction trn, SqlConnection conn)
        {
            try
            {
                var settings = Setting.Get();
                var totalPriceUSD = -1 * decimal.Round((totalPrice / Mainpage.USD), 2, MidpointRounding.AwayFromZero);
                var totalPriceEURO = -1 * decimal.Round((totalPrice / Mainpage.EURO), 2, MidpointRounding.AwayFromZero);
                var sB = new SqlBuilder();//sB == sqlBuilder
                var bT = sB.AddTemplate(
                    $"""
                INSERT INTO FICHES(FICHEREF,FICHETYPE,CUSTOMERID,TOTALPRICE,USDTOTALPRICE,EUROTOTALPRICE,CREATEDBY,CREATEDATE,ISCUSTORVEND,PAYMENTTYPE)
                VALUES (@FICHEREF,@FICHETYPE,@CUSTOMERID,@TOTALPRICE,@USDTOTALPRICE,@EUROTOTALPRICE,@CREATEDBY,GETDATE(),'CUST',@PAYMENTTYPE)
                """
                    );
                var param = new
                {
                    FICHEREF = ficheRef,
                    FICHETYPE = ficheType,
                    CUSTOMERID = custId,
                    TOTALPRICE = totalPrice,
                    USDTOTALPRICE = totalPriceUSD,
                    EUROTOTALPRICE = totalPriceEURO,
                    CREATEDBY = settings.LastSuccesfullyLoggedUser,
                    PAYMENTTYPE = paymentType
                };
                var result = conn.ExecuteAsync(bT.RawSql, param, trn).Result;
                if (result > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        public async void DeleteFromDB(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
                return;
            var settings = Setting.Get();
            var qry = $"DELETE FROM CUSTOMERS WHERE ID = {id}";
            await using var conn = new SqlConnection(settings.Sql.ConnectionString());
            conn.Open();
            var result = await conn.ExecuteAsync(qry);
        }
        public async void RefreshMainDataGrid()
        {
            if (cbShowAll.Checked)
            {
                dgvMain.EndEdit();
                var settings = Setting.Get();
                var qry = $"""
                WITH TABLO AS(SELECT TOP 200 CST.ID,CST.NAME,CST.PHONE FROM CUSTOMERS AS CST ORDER BY ID)
                SELECT T.*,ISNULL((SELECT SUM(FL.TOTALPRICE) FROM FICHES AS F LEFT JOIN 
                FICHELINES AS FL ON FL.FICHEREF = F.FICHEREF
                WHERE F.FICHETYPE = 2 AND F.CUSTOMERID = T.ID),0) AS DEPTH 
                FROM TABLO AS T ORDER BY T.ID
                """; ;
                await using var conn = new SqlConnection(settings.Sql.ConnectionString());
                conn.Open();
                var ar = new SqlDataAdapter(qry, conn);
                var dt = new DataTable();
                ar.Fill(dt);
                dgvMain.DataSource = dt;
                dgvMain.ClearSelection();
            }
            else
            {
                dgvMain.EndEdit();
                var settings = Setting.Get();
                var qry = $"""
                WITH TABLO AS(SELECT TOP 200 CST.ID,CST.NAME,CST.PHONE,ISNULL((SELECT SUM(FL.TOTALPRICE) AS DEPTH FROM FICHES AS F LEFT JOIN 
                FICHELINES AS FL ON FL.FICHEREF = F.FICHEREF
                WHERE F.FICHETYPE = 2 AND F.CUSTOMERID = CST.ID),0) AS DEPTH  FROM CUSTOMERS AS CST ORDER BY ID)
                SELECT T.*
                FROM TABLO AS T GROUP BY T.DEPTH,T.ID,T.NAME,T.PHONE HAVING T.DEPTH>0 ORDER BY T.ID  
                """; ;
                await using var conn = new SqlConnection(settings.Sql.ConnectionString());
                conn.Open();
                var ar = new SqlDataAdapter(qry, conn);
                var dt = new DataTable();
                ar.Fill(dt);
                dgvMain.DataSource = dt;
                dgvMain.ClearSelection();

            }
            
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlDepthAmount.Visible = false;
            tbDepth.Text = "";
        }
        public async Task<bool> AddFicheLine(string ficheRef, decimal lineTotalPrice, SqlTransaction trn, SqlConnection conn)
        {
            var settings = Setting.Get();
            var sB = new SqlBuilder();
            var bT = sB.AddTemplate(
                $"""
                    INSERT INTO FICHELINES(BARCODE,FICHEREF,TOTALPRICE,USDTOTALPRICE,EUROTOTALPRICE,CREATEDBY,CREATEDATE)
                    VALUES(0,@FICHEREF,@TOTALPRICE,@USDTOTALPRICE,@EUROTOTALPRICE,@CREATEDBY,GETDATE())
                """
                );
            var prmLine = new
            {
                FICHEREF = ficheRef,
                TOTALPRICE = lineTotalPrice,
                USDTOTALPRICE = lineTotalPrice / Mainpage.USD,
                EUROTOTALPRICE = lineTotalPrice / Mainpage.EURO,
                CREATEDBY = settings.LastSuccesfullyLoggedUser,
            };
            var snc = conn.ExecuteAsync(bT.RawSql, prmLine, trn).Result;
            return snc > 0;
        }
        public bool isTakeMoney = false;
        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (LastAddDepthRowIndex < 0)
            {
                return;
            }
            var settings = Setting.Get();
            if (isTakeMoney)
            {
                isTakeMoney = false;
                await using var conn = new SqlConnection(settings.Sql.ConnectionString());
                var ficheRef = DateTime.Now.ToString("ddMMyyyyHHmmssfff");
                SqlTransaction trn = null;
                conn.Open();
                trn = conn.BeginTransaction();
                var headRes = await AddFicheHead("NAKİT", ficheRef, 2, -1 * decimal.Round(Convert.ToDecimal(tbDepth.Text), 2, MidpointRounding.AwayFromZero), Convert.ToInt32(dgvMain.Rows[LastAddDepthRowIndex].Cells["ID"].Value.ToString()), trn, conn);
                if (headRes)
                {
                    var lineRes = await AddFicheLine(ficheRef, -1 * decimal.Round(Convert.ToDecimal(tbDepth.Text), 2, MidpointRounding.AwayFromZero), trn, conn);
                    if (lineRes)
                    {
                        trn.Commit();
                        tbDepth.Text = "";
                        pnlDepthAmount.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Fiş kaydedilemedi. Bağlantınızı kontrol ederek tekrar deneyin.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        trn.Rollback();
                    }
                }
                else
                {
                    MessageBox.Show("Fiş kaydedilemedi. Bağlantınızı kontrol ederek tekrar deneyin.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    trn.Rollback();
                }
            }
            else
            {
                await using var conn = new SqlConnection(settings.Sql.ConnectionString());
                var ficheRef = DateTime.Now.ToString("ddMMyyyyHHmmssfff");
                SqlTransaction trn = null;
                conn.Open();
                trn = conn.BeginTransaction();
                var headRes = await AddFicheHead("NAKİT", ficheRef, 2, decimal.Round(Convert.ToDecimal(tbDepth.Text), 2, MidpointRounding.AwayFromZero), Convert.ToInt32(dgvMain.Rows[LastAddDepthRowIndex].Cells["ID"].Value.ToString()), trn, conn);
                if (headRes)
                {
                    var lineRes = await AddFicheLine(ficheRef, decimal.Round(Convert.ToDecimal(tbDepth.Text), 2, MidpointRounding.AwayFromZero), trn, conn);
                    if (lineRes)
                    {
                        trn.Commit();
                        tbDepth.Text = "";
                        pnlDepthAmount.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Fiş kaydedilemedi. Bağlantınızı kontrol ederek tekrar deneyin.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        trn.Rollback();
                    }
                }
                else
                {
                    MessageBox.Show("Fiş kaydedilemedi. Bağlantınızı kontrol ederek tekrar deneyin.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    trn.Rollback();
                }
            }
            LastAddDepthRowIndex = -1;
            RefreshMainDataGrid();
        }

        private void tbDepth_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSave.PerformClick();
            }
        }

        private void tbDepth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void cbShowAll_CheckedChanged(object sender, EventArgs e)
        {
            cbShowDepths.Checked = !cbShowAll.Checked;
            RefreshMainDataGrid();
        }

        private void cbShowDepths_CheckedChanged(object sender, EventArgs e)
        {
            cbShowAll.Checked = !cbShowDepths.Checked;
            RefreshMainDataGrid();
        }
    }
}
