using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSA.Forms
{
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private void Workplace_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnExpenses_Click(object sender, EventArgs e)
        {
            foreach (Form form in scMain.Panel2.Controls)
            {
                form.Close();
            }
            var addExpense = new AddExpense() { TopLevel = false, TopMost = true, Name = "AddExpense" };
            scMain.Panel2.Controls.Add(addExpense);
            addExpense.Show();
        }

        private void Reports_Load(object sender, EventArgs e)
        {

        }

        private void btnSaleReport_Click(object sender, EventArgs e)
        {
            foreach (Form form in scMain.Panel2.Controls)
            {
                form.Close();
            }
            var srif = new SaleReportInnerForm() { TopLevel = false, TopMost = true, Name = "Satış Raporu" };
            scMain.Panel2.Controls.Add(srif);
            srif.Show();
        }
    }
}
