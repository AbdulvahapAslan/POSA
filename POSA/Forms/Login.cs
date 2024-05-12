using POSA.Forms;

namespace POSA
{
    public partial class Login : Form
    {
        
        public Login()
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
            Environment.Exit(0);
        }
        private void btnOne_Click(object sender, EventArgs e)
        {
            tbPassword.Text += "1";
        }
        private void btnTwo_Click(object sender, EventArgs e)
        {
            tbPassword.Text += "2";
        }
        private void btnThree_Click(object sender, EventArgs e)
        {
            tbPassword.Text += "3";
        }
        private void btnFour_Click(object sender, EventArgs e)
        {
            tbPassword.Text += "4";
        }
        private void btnFive_Click(object sender, EventArgs e)
        {
            tbPassword.Text += "5";
        }
        private void btnSix_Click(object sender, EventArgs e)
        {
            tbPassword.Text += "6";
        }
        private void btnSeven_Click(object sender, EventArgs e)
        {
            tbPassword.Text += "7";
        }
        private void btnEight_Click(object sender, EventArgs e)
        {
            tbPassword.Text += "8";
        }
        private void btnNine_Click(object sender, EventArgs e)
        {
            tbPassword.Text += "9";
        }
        private void btnZero_Click(object sender, EventArgs e)
        {
            tbPassword.Text += "0";
        }
        private void btnClearPass_Click(object sender, EventArgs e)
        {
            tbPassword.Text = "";
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            GirisYap();
        }
        public void GirisYap()
        {
            if (tbUsername.Text == "1" && tbPassword.Text == "1")
            {
                this.Hide();
                var load = new Loading();
                load.Show();
                return;
            }
            if (tbUsername.Text.Length < 3)
            {
                MessageBox.Show("Kullanýcý adýnýz geçerli deðildir.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (tbPassword.Text.Length < 8)
            {
                MessageBox.Show("Geçerli bir þifre girdiðinizdem emin olunuz.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           
            
        }
        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
