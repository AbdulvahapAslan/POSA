using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using POSA.CustomObjects;
using POSA.Dto;
using POSA.Helpers.Settings;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace POSA.Forms
{
    public partial class PayPartite : Form
    {
        public DataTable products;
        public decimal totalPrice = 0;
        public decimal cashAmount = 0;
        public decimal cardAmount = 0;
        public decimal otherAmount = 0;
        public PayPartite(DataTable _products, decimal _totalPrice)
        {
            InitializeComponent();
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en_GB");
            this.products = _products;
            this.totalPrice = _totalPrice;
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
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void ProductDetails_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            var payed = Convert.ToDecimal(tbPrice.Text);
            var remaining = Convert.ToDecimal(tbRemainingPrice.Text);
            var diff = remaining - payed;
            if (diff < 0)
            {
                MessageBox.Show("Kalan tutardan daha fazla ödeme alınamaz.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (fcPaymentType.Text == "NAKİT")
                {
                    cashAmount += Convert.ToDecimal(tbPrice.Text);
                }
                else if (fcPaymentType.Text == "KART")
                {
                    cardAmount += Convert.ToDecimal(tbPrice.Text);
                }
                else
                {
                    otherAmount += Convert.ToDecimal(tbPrice.Text);
                }
            }
            foreach (DataGridViewRow row in dgvMain.Rows)
            {
                row.Cells["TOTALQUANTITY"].Value = (Convert.ToDecimal(row.Cells["TOTALQUANTITY"].Value.ToString()) - Convert.ToDecimal(row.Cells["QUANTITY"].Value.ToString())).ToString();
                row.Cells["QUANTITY"].Value = "0";
            }
            if (payed == remaining)
            {
                tbRemainingPrice.Text = "0";
            }
            else
            {
                tbRemainingPrice.Text = (remaining - payed).ToString();
            }
            tbPrice.Text = "0";
            if (tbRemainingPrice.Text == "0")
            {
                this.DialogResult = DialogResult.OK;
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void PayPartite_Load(object sender, EventArgs e)
        {
            fcPaymentType.SelectedIndex = 0;
            tbPrice.Text = "0";
            tbRemainingPrice.Text = totalPrice.ToString();
            dgvMain.Columns.Insert(4, new DataGridViewImageColumn()
            {
                Image = Properties.Resources._24pxMinus,
                Name = "MINUS",
                HeaderText = "",
                FillWeight = 5,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
            dgvMain.Columns.Insert(6, new DataGridViewImageColumn()
            {
                Image = Properties.Resources._24pxPlus,
                Name = "PLUS",
                HeaderText = "",
                FillWeight = 5,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
            dgvMain.Columns["PLUS"].FillWeight = 5;
            dgvMain.Columns["MINUS"].FillWeight = 5;
            foreach (DataRow row in products.Rows)
            {
                dgvMain.Rows.Add();
                dgvMain.Rows[dgvMain.Rows.Count - 1].Cells["BARCODE"].Value = row[0].ToString();
                dgvMain.Rows[dgvMain.Rows.Count - 1].Cells["NAME"].Value = row[1].ToString();
                dgvMain.Rows[dgvMain.Rows.Count - 1].Cells["PRICE"].Value = row[2].ToString();
                dgvMain.Rows[dgvMain.Rows.Count - 1].Cells["TOTALQUANTITY"].Value = row[3].ToString();
                dgvMain.Rows[dgvMain.Rows.Count - 1].Cells["QUANTITY"].Value = "0";
                dgvMain.Rows[dgvMain.Rows.Count - 1].Cells["TOTAL"].Value = row[4].ToString();
            }
        }
        private void btnGeneralNumber_Click(object sender, EventArgs e)
        {
            var btn = sender as RoundButton;
            tbPrice.Text += string.IsNullOrWhiteSpace(btn.Text) ? "" : btn.Text;
        }

        //private void tbPrice_TextChanged(object sender, EventArgs e)
        //{
        //    var old = tbRemainingPrice.Text;
        //    if (!string.IsNullOrWhiteSpace(tbPrice.Text) && !tbPrice.Text.EndsWith(".") && !string.IsNullOrWhiteSpace(tbRemainingPrice.Text))
        //    {
        //        tbRemainingPrice.Text = (Convert.ToDecimal(tbRemainingPrice.Text) - Convert.ToDecimal(tbPrice.Text)).ToString();
        //    }
        //    else
        //    {
        //        tbRemainingPrice.Text = old;
        //    }
        //}

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbPrice.Text))
            {
                tbPrice.Text = tbPrice.Text.Substring(0, tbPrice.Text.Length - 1);
            }
        }

        private void dgvMain_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvMain.Columns["MINUS"].Index && Convert.ToDecimal(dgvMain.Rows[e.RowIndex].Cells["QUANTITY"].Value.ToString()) >= 0)
            {
                if (Convert.ToInt32(dgvMain.Rows[e.RowIndex].Cells["QUANTITY"].Value.ToString()) > 0)
                {
                    dgvMain.Rows[e.RowIndex].Cells["QUANTITY"].Value = (Convert.ToDecimal(dgvMain.Rows[e.RowIndex].Cells["QUANTITY"].Value.ToString()) - 1).ToString();
                    dgvMain.Rows[e.RowIndex].Cells["TOTAL"].Value = decimal.Round(Convert.ToDecimal(dgvMain.Rows[e.RowIndex].Cells["PRICE"].Value.ToString()) * Convert.ToDecimal(dgvMain.Rows[e.RowIndex].Cells["QUANTITY"].Value.ToString()), 2, MidpointRounding.AwayFromZero).ToString();
                    tbPrice.Text = (Convert.ToDecimal(tbPrice.Text) - Convert.ToDecimal(dgvMain.Rows[e.RowIndex].Cells["PRICE"].Value.ToString())).ToString();
                }
            }
            else if (e.ColumnIndex == dgvMain.Columns["PLUS"].Index && Convert.ToDecimal(dgvMain.Rows[e.RowIndex].Cells["QUANTITY"].Value.ToString()) < Convert.ToDecimal(dgvMain.Rows[e.RowIndex].Cells["TOTALQUANTITY"].Value.ToString()))
            {
                dgvMain.Rows[e.RowIndex].Cells["QUANTITY"].Value = (Convert.ToDecimal(dgvMain.Rows[e.RowIndex].Cells["QUANTITY"].Value.ToString()) + 1).ToString();
                dgvMain.Rows[e.RowIndex].Cells["TOTAL"].Value = (Convert.ToDecimal(dgvMain.Rows[e.RowIndex].Cells["PRICE"].Value.ToString()) * Convert.ToDecimal(dgvMain.Rows[e.RowIndex].Cells["QUANTITY"].Value.ToString())).ToString();
                tbPrice.Text = (Convert.ToDecimal(tbPrice.Text) + Convert.ToDecimal(dgvMain.Rows[e.RowIndex].Cells["PRICE"].Value.ToString())).ToString();
            }
        }

        private void dgvMain_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvMain.Columns["MINUS"].Index || e.ColumnIndex == dgvMain.Columns["PLUS"].Index)
                return;
            var remaininQ = Convert.ToDecimal(dgvMain.Rows[e.RowIndex].Cells["TOTALQUANTITY"].Value.ToString()) - Convert.ToDecimal(dgvMain.Rows[e.RowIndex].Cells["QUANTITY"].Value.ToString());
            if (remaininQ > 0)
            {
                var price = Convert.ToDecimal(dgvMain.Rows[e.RowIndex].Cells["PRICE"].Value.ToString());
                var total = Convert.ToDecimal(dgvMain.Rows[e.RowIndex].Cells["TOTAL"].Value.ToString());
                dgvMain.Rows[e.RowIndex].Cells["QUANTITY"].Value = Convert.ToDecimal(dgvMain.Rows[e.RowIndex].Cells["TOTALQUANTITY"].Value.ToString()).ToString();
                dgvMain.Rows[e.RowIndex].Cells["TOTAL"].Value = (total + (price * remaininQ)).ToString();
                tbPrice.Text = (Convert.ToDecimal(tbPrice.Text) + (price * remaininQ)).ToString();
            }
            else
            {
                var total = Convert.ToDecimal(dgvMain.Rows[e.RowIndex].Cells["TOTAL"].Value.ToString());
                tbPrice.Text = (Convert.ToDecimal(tbPrice.Text) - total).ToString();
                dgvMain.Rows[e.RowIndex].Cells["TOTAL"].Value = "0";
                dgvMain.Rows[e.RowIndex].Cells["QUANTITY"].Value = "0";
            }
        }

        private void tbPrice_Enter(object sender, EventArgs e)
        {
            tbPrice.Text = "";
        }

        private void tbPrice_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbPrice.Text))
                tbPrice.Text = "0";
        }

        private void tbPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as RoundTextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
