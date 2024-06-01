using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using POSA.Dto;
using POSA.Helpers.Settings;
namespace POSA.Forms
{
    public partial class PayMulti : Form
    {
        public decimal totalPrice;
        public decimal cashAmount;
        public decimal cardAmount;
        public PayMulti(decimal _totalPrice)
        {
            InitializeComponent();
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
            this.cashAmount = decimal.Round(Convert.ToDecimal(tbCash.Text), 2, MidpointRounding.AwayFromZero);
            this.cardAmount = decimal.Round(Convert.ToDecimal(tbCard.Text), 2, MidpointRounding.AwayFromZero);

        }
        private void tbCash_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        private void tbCard_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        private void tbCash_TextChanged(object sender, EventArgs e)
        {
            if (!tbCash.Text.EndsWith('.'))
            {
                tbCard.Text = (totalPrice - Convert.ToDecimal(tbCash.Text)).ToString();
            }
        }
        private void tbCard_TextChanged(object sender, EventArgs e)
        {
            if (!tbCard.Text.EndsWith('.'))
            {
                tbCash.Text = (totalPrice - Convert.ToDecimal(tbCard.Text)).ToString();
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PayMulti_Load(object sender, EventArgs e)
        {
            lblTotalPrice.Text = totalPrice + "₺";
        }
    }
}
