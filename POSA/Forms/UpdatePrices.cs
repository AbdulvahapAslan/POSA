using Dapper;
using FastMember;
using POSA.Helpers.Settings;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using static Dapper.SqlMapper;
namespace POSA.Forms
{
    public partial class UpdatePrices : Form
    {
        public UpdatePrices()
        {
            InitializeComponent();
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en_GB");
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private void pbClearSearch_Click(object sender, EventArgs e)
        {
            rtbSearch.Texts = "";
        }
        private async void AddCustomerReportForm_Load(object sender, EventArgs e)
        {
            cbPriceType.SelectedIndex = 0;
            RefreshMainDataGrid();
            dgvMain.ClearSelection();
        }
        public async void RefreshMainDataGrid()
        {
            dgvMain.EndEdit();
            var settings = Setting.Get();
            var qry = $"""
                SELECT TOP 300 BARCODE,NAME,SALEPRICE{(cbPriceType.Text == "1" ? "" : cbPriceType.Text)} AS PRICE FROM PRODUCTS
                """;
            await using var conn = new SqlConnection(settings.Sql.ConnectionString());
            conn.Open();
            var ar = new SqlDataAdapter(qry, conn);
            var dt = new DataTable();
            ar.Fill(dt);
            dgvMain.DataSource = dt;
            dgvMain.ClearSelection();
        }
        private void btnApply_Click(object sender, EventArgs e)
        {
            if (btnForAllProducts.BackColor == Color.LightGreen)
            {
                MessageBox.Show("Bu buton tümüne uygula aktifken kullanılamaz.", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (tbPercentage.Text.Length > 1 && tbPercentage.Text != "0")
            {
                try
                {
                    decimal percentage = Convert.ToDecimal(tbPercentage.Text);
                    if (cbType.Text.StartsWith("AR"))
                    {
                        foreach (DataGridViewRow row in dgvSelects.Rows)
                        {
                            var old = Convert.ToDecimal(row.Cells["OLDPRICE"].Value);
                            row.Cells["NEWPRICE"].Value = decimal.Round(old + (old * (percentage / 100)), 2, MidpointRounding.AwayFromZero);
                        }
                    }
                    else
                    {
                        foreach (DataGridViewRow row in dgvSelects.Rows)
                        {
                            var old = Convert.ToDecimal(row.Cells["OLDPRICE"].Value);
                            row.Cells["NEWPRICE"].Value = decimal.Round(old - (old * (percentage / 100)), 2, MidpointRounding.AwayFromZero);
                        }
                    }
                }
                catch (Exception)
                {
                }
            }
        }
        private void dgvMain_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvMain.Rows[e.RowIndex].Cells["CHECK"].Value = true;
        }
        private void btnNumberGeneral_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            if (btn != null)
            {
                tbPercentage.Text = btn.Text;
            }
        }
        private async void rtbSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (rtbSearch.Texts.Length > 0)
                {
                    var setting = Setting.Get();
                    await using var conn = new SqlConnection(setting.Sql.ConnectionString());
                    conn.Open();
                    var sqlBuilder = new SqlBuilder();
                    sqlBuilder.Select($"""
                                        BARCODE,NAME,SALEPRICE{(cbPriceType.Text == "1" ? "" : cbPriceType.Text)} AS PRICE
                                        """);
                    sqlBuilder.Where($"""
                                        BARCODE=@BARCODE OR NAME LIKE '%'+@BARCODE+'%'
                                        """);
                    var param = new
                    {
                        BARCODE = rtbSearch.Texts
                    };
                    var builderTemp = sqlBuilder.AddTemplate("SELECT /**select**/ FROM PRODUCTS /**where**/");
                    var products = conn.QueryAsync<Dto.ProductDetails>(builderTemp.RawSql, param).Result.ToList();
                    if (products.Any())
                    {
                        if (products.Count == 1)
                        {
                            dgvSelects.Rows.Add(products[0].BARCODE, products[0].NAME, products[0].PRICE, "0");
                        }
                        else if (products.Count > 1)
                        {
                            var dt = new DataTable();
                            using (var reader = ObjectReader.Create(products, "BARCODE", "NAME", "PRICE"))
                                dt.Load(reader);
                            //dt.Columns.Remove("STOCKPLACE");
                            //dt.Columns.Remove("STOCK");
                            //dt.Columns.Remove("BUYPRICE");
                            dgvMain.DataSource = dt;
                        }
                        else
                        {
                            RefreshMainDataGrid();
                        }
                    }
                    else
                    {
                        RefreshMainDataGrid();
                    }
                }
                else
                {
                    RefreshMainDataGrid();
                }
            }
        }
        private void rtbSearch__TextChanged(object sender, EventArgs e)
        {
            (dgvMain.DataSource as DataTable).DefaultView.RowFilter = $"NAME LIKE '{rtbSearch.Texts}%' OR BARCODE LIKE '{rtbSearch.Texts}%'";
        }
        private void btnGetSelects_Click(object sender, EventArgs e)
        {
            var listOfIndexs = new List<int>();
            foreach (DataGridViewRow row in dgvMain.Rows)
            {
                if (Convert.ToBoolean(row.Cells["CHECK"].Value))
                {
                    dgvSelects.Rows.Add(row.Cells["BARCODE"].Value, row.Cells["NAME"].Value, row.Cells["PRICE"].Value, 0);
                    listOfIndexs.Add(row.Index);
                }
            }
            foreach (var index in listOfIndexs)
            {
                dgvMain.Rows.Remove(dgvMain.Rows[index]);
            }
        }
        private void btnForAllProducts_Click(object sender, EventArgs e)
        {
            if (btnForAllProducts.BackColor == Color.White)
                btnForAllProducts.BackColor = Color.LightGreen;
            else
                btnForAllProducts.BackColor = Color.White;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(tbPercentage.Text) < 1)
            {
                MessageBox.Show($"Yüzde 0'dan büyük olmalıdır.", "HATA", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            }
            if (btnForAllProducts.BackColor == Color.LightGreen)
            {
                var answer = MessageBox.Show($"Bütün ürünler için %{tbPercentage.Text} oranında 'FİYAT {cbType.Text}' işlemini onaylıyor musunuz?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (answer == DialogResult.No)
                    return;
                
            }
            else
            {
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            else
                this.WindowState = FormWindowState.Maximized;
        }
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void UpdatePrices_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void cbPriceType_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshMainDataGrid();
        }
    }
}
