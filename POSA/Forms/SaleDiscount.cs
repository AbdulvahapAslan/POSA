using System.Data;
using System.Globalization;
namespace POSA.Forms
{
    public partial class SaleDiscount : Form
    {
        DataTable dtSource = new DataTable();
        public static DataTable dtDiscountResult = new DataTable();
        public SaleDiscount(DataTable _dtSource)
        {
            InitializeComponent();
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en_GB");
            this.dtSource = _dtSource;
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
        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (tbPercentage.Text.Length < 1)
                return;
            if (dtDiscountResult.Columns.Count == 0)
            {
                dtDiscountResult.Columns.Add("RBARCODE");
                dtDiscountResult.Columns.Add("RPRICE");
            }
            dtDiscountResult.Rows.Clear();
            foreach (DataGridViewRow row in dgvMain.Rows)
            {
                dtDiscountResult.Rows.Add();
                dtDiscountResult.Rows[dtDiscountResult.Rows.Count - 1]["RBARCODE"] = row.Cells["BARCODE"].Value.ToString();
                dtDiscountResult.Rows[dtDiscountResult.Rows.Count - 1]["RPRICE"] = row.Cells["NEWPRICE"].Value.ToString();
            }
            this.DialogResult = DialogResult.OK;
        }
        private void AddCategory_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void SaleDiscount_Load(object sender, EventArgs e)
        {
            foreach (DataRow row in dtSource.Rows)
            {
                dgvMain.Rows.Add();
                dgvMain.Rows[dgvMain.Rows.Count - 1].Cells["NAME"].Value = row[1].ToString();
                dgvMain.Rows[dgvMain.Rows.Count - 1].Cells["BARCODE"].Value = row[0].ToString();
                dgvMain.Rows[dgvMain.Rows.Count - 1].Cells["OLDPRICE"].Value = row[2].ToString();
                dgvMain.Rows[dgvMain.Rows.Count - 1].Cells["NEWPRICE"].Value = row[2].ToString();
            }
        }
        private void btnNumbers_Click(object sender, EventArgs e)
        {
            var selectedButton = sender as Button;
            tbPercentage.Text = selectedButton.Text;
        }
        private void tbPercentage_TextChanged(object sender, EventArgs e)
        {
            if (!(tbPercentage.Text.Length > 0))
                return;
            bool isAnyChecked = false;
            foreach (DataGridViewRow row in dgvMain.Rows)
            {
                if (Convert.ToBoolean(row.Cells[1].Value))
                {
                    isAnyChecked = true;
                    break;
                }
            }
            if (!isAnyChecked)
                return;
            foreach (DataGridViewRow row in dgvMain.Rows)
            {
                if (Convert.ToBoolean(row.Cells[1].Value))
                {
                    row.Cells["NEWPRICE"].Value = decimal.Round((Convert.ToDecimal(row.Cells["OLDPRICE"].Value) * (100 - Convert.ToInt32(tbPercentage.Text))) / 100, 2, MidpointRounding.AwayFromZero);
                }
            }
        }
        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvMain.Rows)
            {
                row.Cells[1].Value = Convert.ToBoolean(row.Cells[1].Value) ? CheckState.Unchecked : CheckState.Checked;
            }
        }
    }
}
