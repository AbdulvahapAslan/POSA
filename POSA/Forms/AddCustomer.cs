﻿namespace POSA.Forms
{
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            foreach (Form form in scMain.Panel2.Controls)
            {
                form.Close();
            }
            var cf = new AddCustomerInnerForm(false,null) { TopLevel = false, TopMost = true, Name = "AddCust" };
            scMain.Panel2.Controls.Add(cf);
            cf.Show();
        }
        private void AddCustomer_Load(object sender, EventArgs e)
        {
            btnAddCustomer.PerformClick();
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
        private void AddSupplier_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void btnSupplierReport_Click(object sender, EventArgs e)
        {
            foreach (Form form in scMain.Panel2.Controls)
            {
                form.Close();
            }
            var cf = new AddCustomerReportForm() { TopLevel = false, TopMost = true, Name = "CustRep" };
            scMain.Panel2.Controls.Add(cf);
            cf.Show();
        }
    }
}
