using Dapper;
using POSA.Helpers.Settings;
using System.Data;
using System.Data.SqlClient;
namespace POSA.Forms
{
    public partial class AddDetails : Form
    {
        public AddDetails()
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
        private async void AddCategory_Load(object sender, EventArgs e)
        {
            RefreshDataGrid();
        }
        public async void RefreshDataGrid()
        {
            dgvMain.EndEdit();
            var settings = Setting.Get();
            var sb = new SqlBuilder();
            sb.Select("TOP 200 BARCODE,NAME,SERIALNUMBER,BRAND,EXPIREDATE,WARNEXPIREDATE,PRODUCTOR,STOCKPLACE,CURRENCY");
            var builderTemp = sb.AddTemplate("SELECT /**select**/ FROM PRODUCTS");
            await using var conn = new SqlConnection(settings.Sql.ConnectionString());
            conn.Open();
            var ar = new SqlDataAdapter(builderTemp.RawSql, conn);
            var dt = new DataTable();
            ar.Fill(dt);
            dgvMain.DataSource = dt;
            dgvMain.ClearSelection();
        }
        private void ClearScreen()
        {
            tbBrand.Text = "";
            tbProductor.Text = "";
            tbSerialNumber.Text = "";
            tbStockPlace.Text = "";
            lblBarcode.Text = "";
            dtpExpire.Value = DateTime.Now;
            cbWarnExpire.CheckState = CheckState.Unchecked;
            cbCurrency.SelectedIndex = 0;
        }
        private async void btnSave_Click(object sender, EventArgs e)
        {
            var settings = Setting.Get();
            var sb = new SqlBuilder();
            var builderTemp = sb.AddTemplate("UPDATE PRODUCTS SET SERIALNUMBER=@SERIALNUMBER,BRAND=@BRAND,EXPIREDATE=@EXPIREDATE,WARNEXPIREDATE=@WARNEXPIREDATE,PRODUCTOR=@PRODUCTOR,STOCKPLACE=@STOCKPLACE,CURRENCY=@CURRENCY WHERE BARCODE = @BARCODE");
            var param = new
            {
                SERIALNUMBER = tbSerialNumber.Text ?? "",
                BRAND = tbBrand.Text ?? "",
                EXPIREDATE = dtpExpire.Value.ToString(),
                WARNEXPIREDATE = cbWarnExpire.CheckState == CheckState.Checked ? 1 : 0,
                PRODUCTOR = tbProductor.Text ?? "",
                STOCKPLACE = tbStockPlace.Text ?? "",
                CURRENCY = cbCurrency.Text ?? "",
                BARCODE = lblBarcode.Text ?? ""
            };
            await using var conn = new SqlConnection(settings.Sql.ConnectionString());
            conn.Open();
            var result = await conn.ExecuteAsync(builderTemp.RawSql, param);
            RefreshDataGrid();
            ClearScreen();
        }
        private void rtbSearch__TextChanged(object sender, EventArgs e)
        {
            (dgvMain.DataSource as DataTable).DefaultView.RowFilter = $"BARCODE LIKE '{rtbSearch.Texts}%' OR DESCRIPTION LIKE '{rtbSearch.Texts}%'";
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
        private void dgvMain_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            var date = new DateTime();
            if (dgvMain.Rows[e.RowIndex].Cells["EXPIREDATE"].Value is null || string.IsNullOrWhiteSpace(dgvMain.Rows[e.RowIndex].Cells["EXPIREDATE"].Value.ToString()))
                date = DateTime.Now;
            else
                date = Convert.ToDateTime(dgvMain.Rows[e.RowIndex].Cells["EXPIREDATE"].Value.ToString());
            lblBarcode.Text = dgvMain.Rows[e.RowIndex].Cells["BARCODE"].Value.ToString();
            tbBrand.Text = dgvMain.Rows[e.RowIndex].Cells["BRAND"].Value.ToString();
            tbSerialNumber.Text = dgvMain.Rows[e.RowIndex].Cells["SERIALNUMBER"].Value.ToString();
            dtpExpire.Value = date;
            cbWarnExpire.CheckState = dgvMain.Rows[e.RowIndex].Cells["WARNEXPIREDATE"].Value.ToString() == "0" ? CheckState.Unchecked : CheckState.Checked;
            tbStockPlace.Text = dgvMain.Rows[e.RowIndex].Cells["STOCKPLACE"].Value.ToString();
            tbProductor.Text = dgvMain.Rows[e.RowIndex].Cells["PRODUCTOR"].Value.ToString();
            cbCurrency.Text = dgvMain.Rows[e.RowIndex].Cells["CURRENCY"].Value.ToString();
        }
        private async void rtbSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dgvMain.EndEdit();
                var settings = Setting.Get();
                var sb = new SqlBuilder();
                sb.Select("TOP 200 BARCODE,NAME,SERIALNUMBER,BRAND,EXPIREDATE,WARNEXPIREDATE,PRODUCTOR,STOCKPLACE,CURRENCY");
                var builderTemp = sb.AddTemplate($"SELECT /**select**/ FROM PRODUCTS WHERE (BARCODE = '{rtbSearch.Texts}' OR NAME LIKE '%{rtbSearch.Texts}%')");
                await using var conn = new SqlConnection(settings.Sql.ConnectionString());
                conn.Open();
                var ar = new SqlDataAdapter(builderTemp.RawSql, conn);
                var dt = new DataTable();
                ar.Fill(dt);
                dgvMain.DataSource = dt;
                dgvMain.ClearSelection();
            }
        }
    }
}
