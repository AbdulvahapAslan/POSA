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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace POSA.Forms
{
    public partial class PayPartite : Form
    {
        public decimal totalPrice;
        public decimal cashAmount = 0;
        public decimal cardAmount = 0;
        public PayPartite(decimal _totalPrice)
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

        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PayPartite_Load(object sender, EventArgs e)
        {
            fcPaymentType.SelectedIndex = 0;
        }
    }
}
