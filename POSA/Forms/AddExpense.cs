using Dapper;
using POSA.Helpers.Settings;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using static Dapper.SqlMapper;
namespace POSA.Forms
{
    public partial class AddExpense : Form
    {
        public AddExpense()
        {
            InitializeComponent();
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public async void RefreshDataGrid()
        {
            dgvMain.EndEdit();
            var settings = Setting.Get();
            var sb = new SqlBuilder();
            var qry = $"""
                        SELECT E.ID,E.COST,E.CREATEDATE AS DATE,E.DESCRIPTION,B.NAME AS BRANCH,B.ID AS BID FROM EXPENSES AS E LEFT JOIN
                        BRANCHES AS B ON B.ID = E.BRANCHID
                        """;
            await using var conn = new SqlConnection(settings.Sql.ConnectionString());
            conn.Open();
            var ar = new SqlDataAdapter(qry, conn);
            var dt = new DataTable();
            ar.Fill(dt);
            dgvMain.Rows.Clear();
            foreach (DataRow row in dt.Rows)
            {
                dgvMain.Rows.Add(row["ID"].ToString(), row["BID"].ToString(), row["COST"].ToString(),row["BRANCH"].ToString(), row["DATE"].ToString(), row["DESCRIPTION"].ToString());
            }
            dgvMain.ClearSelection();
        }
        public async void DeleteFromDB(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
                return;
            var settings = Setting.Get();
            var sb = new SqlBuilder();
            var builderTemp = sb.AddTemplate($"DELETE FROM EXPENSES WHERE ID = {id}");
            await using var conn = new SqlConnection(settings.Sql.ConnectionString());
            conn.Open();
            var result = await conn.ExecuteAsync(builderTemp.RawSql);
        }
        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (btnSave.Text == "EKLE")
            {
                var settings = Setting.Get();
                var sb = new SqlBuilder();
                var builderTemp = sb.AddTemplate("INSERT INTO EXPENSES(BRANCHID,COST,DESCRIPTION,CREATEDBY,CREATEDATE) VALUES(@BID,@COST,@DESCRIPTION,@CREATEDBY,GETDATE())");
                var param = new
                {
                    BID = Convert.ToInt32(cbBranch.SelectedValue.ToString()),
                    COST = Convert.ToDecimal(tbCost.Text, new CultureInfo("en-GB")),
                    DESCRIPTION = tbDescription.Text,
                    CREATEDBY = settings.LastSuccesfullyLoggedUser
                };
                await using var conn = new SqlConnection(settings.Sql.ConnectionString());
                conn.Open();
                var result = await conn.ExecuteAsync(builderTemp.RawSql, param);
                RefreshDataGrid();
                ClearScreen();
            }
            else
            {
                var settings = Setting.Get();
                var sb = new SqlBuilder();
                sb.Where("ID=@ID");
                var param = new { ID = ID };
                var builderTemp = sb.AddTemplate($"UPDATE EXPENSES SET COST={tbCost.Text ?? ""},DESCRIPTION='{tbDescription.Text ?? ""}',CREATEDBY='{settings.LastSuccesfullyLoggedUser}',BRANCHID = {Convert.ToInt32(cbBranch.SelectedValue.ToString())},CREATEDATE=GETDATE() /**where**/");
                await using var conn = new SqlConnection(settings.Sql.ConnectionString());
                conn.Open();
                var result = await conn.ExecuteAsync(builderTemp.RawSql, param);
                RefreshDataGrid();
                ClearScreen();
            }
        }
        public int BrID = -1;
        private void ClearScreen()
        {
            tbCost.Text = "";
            tbDescription.Text = "";
            cbBranch.SelectedIndex = 0;
            btnSave.Text = "EKLE";
        }
        private async void dgvMain_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvMain.Columns["DELETE"].Index)
            {
                var dr = MessageBox.Show($"{dgvMain.Rows[e.RowIndex].Cells["COST"].Value.ToString()} tutarındaki kaydı silmek istediğinize emin misiniz?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (dr == DialogResult.Yes)
                {
                    DeleteFromDB((dgvMain.Rows[e.RowIndex].Cells["ID"].Value ?? "").ToString());
                    RefreshDataGrid();
                }
            }
            if (e.ColumnIndex == dgvMain.Columns["UPDATE"].Index)
            {
                var settings = Setting.Get();
                var qry = $"""
                        SELECT * FROM EXPENSES WHERE ID={dgvMain.Rows[e.RowIndex].Cells["ID"].Value.ToString()}
                        """;
                await using var conn = new SqlConnection(settings.Sql.ConnectionString());
                conn.Open();
                var ar = new SqlDataAdapter(qry, conn);
                var dt = new DataTable();
                ar.Fill(dt);
                btnSave.Text = "GÜNCELLE";
                tbDescription.Text = dt.Rows[0]["DESCRIPTION"].ToString();
                tbCost.Text = dt.Rows[0]["COST"].ToString();
                cbBranch.SelectedValue = Convert.ToInt32(dt.Rows[0]["BRANCHID"].ToString());
            }
        }
        private void rtbSearch__TextChanged(object sender, EventArgs e)
        {
            (dgvMain.DataSource as DataTable).DefaultView.RowFilter = $"BRANCH LIKE '{rtbSearch.Texts}%' OR DESCRIPTION LIKE '{rtbSearch.Texts}%'";
        }
        private void pbClearSearch_Click(object sender, EventArgs e)
        {
            rtbSearch.Texts = "";
        }
        private void AddCategory_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void tbCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf('.') == -1))
            {
                e.Handled = true;
                (sender as TextBox).Text += ".";
                (sender as TextBox).SelectionStart = (sender as TextBox).Text.Length;
                (sender as TextBox).SelectionLength = 0;
            }
            else
            {
                if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
                {
                    e.Handled = true;
                }
                if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf('.') > -1))
                {
                    e.Handled = true;
                }
            }
        }
        private void AddExpense_Load(object sender, EventArgs e)
        {
            cbBranch.DisplayMember = "NAME";
            cbBranch.ValueMember = "ID";
            RefreshDataGrid();
            FillBranchComboBox();
            cbBranch.DisplayMember = "NAME";
            cbBranch.ValueMember = "ID";
            dgvMain.Columns.Insert(dgvMain.Columns.Count, new DataGridViewImageColumn()
            {
                Image = Properties.Resources._24pxUpdate,
                Name = "UPDATE",
                HeaderText = "",
                FillWeight = 7,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
            dgvMain.Columns.Insert(dgvMain.Columns.Count, new DataGridViewImageColumn()
            {
                Image = Properties.Resources._24pxClose,
                Name = "DELETE",
                HeaderText = "",
                FillWeight = 7,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
            dgvMain.Columns["DELETE"].FillWeight = 7;
            dgvMain.Columns["UPDATE"].FillWeight = 7;
        }
        public async void FillBranchComboBox()
        {
            var settings = Setting.Get();
            var sb = new SqlBuilder();
            sb.Select("ID,NAME");
            var builderTemp = sb.AddTemplate("SELECT /**select**/ FROM BRANCHES");
            await using var conn = new SqlConnection(settings.Sql.ConnectionString());
            var result = await conn.QueryAsync(builderTemp.RawSql);
            if (result.Any())
            {
                var categoryList = (from x in result select new { ID = x.ID, NAME = x.NAME }).ToList();
                cbBranch.DataSource = categoryList;
                cbBranch.SelectedIndex = 0;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ClearScreen();
        }
    }
}
