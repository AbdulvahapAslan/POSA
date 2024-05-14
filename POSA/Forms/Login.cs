using Dapper;
using POSA.Forms;
using POSA.Helpers;
using System.Data.SqlClient;

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
        private async void btnLogin_Click(object sender, EventArgs e)
        {
            if (await GirisYap())
            {
                var settings = Helpers.Settings.Setting.Get();
                settings.LastSuccesfullyLoggedUser = tbUsername.Text;
                if (chkRememberMe.Checked)
                {
                    settings.Password = tbPassword.Text;
                    settings.RememberMe = true;
                }
                Helpers.Settings.Setting.Save(settings);
                this.Hide();
                var load = new Loading();
                load.Show();
                return;
            }
            else
            {
                lblWrongPassword.Visible = true;
            }
        }
        public async Task<bool> GirisYap()
        {
            if (tbUsername.Text.Length < 3)
            {
                MessageBox.Show("Kullanýcý adýnýz geçerli deðildir.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (tbPassword.Text.Length < 8)
            {
                MessageBox.Show("Geçerli bir þifre girdiðinizdem emin olunuz.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            var settings = Helpers.Settings.Setting.Get();
            await using var connection = new SqlConnection(settings.MainCS);
            connection.Open();
            var sqlBuilder = new SqlBuilder();
            sqlBuilder.Where(
                $"""
                 USERNAME = @USERNAME
                 AND PASSWORD = @PASSWORD
                 AND ACTIVE = @ACTIVE
                """,
                new
                {
                    USERNAME = tbUsername.Text,
                    PASSWORD = tbPassword.Text.MD5(),
                    ACTIVE = 1
                });
            sqlBuilder.Select("DB");
            var builderTemplate = sqlBuilder.AddTemplate("SELECT /**select**/ FROM USERS (NOLOCK) /**where**/");
            var result = await connection.QuerySingleOrDefaultAsync<Dto.Login>(builderTemplate.RawSql, builderTemplate.Parameters);
            if (result == null && string.IsNullOrWhiteSpace((result ?? new Dto.Login()).DB))
                return false;
            else
            {
                settings.Sql.Database = result.DB;
                Helpers.Settings.Setting.Save(settings);
            }
            return true;

        }
        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            var settings = Helpers.Settings.Setting.Get();
            if(settings is not null)
            {
                if (!string.IsNullOrWhiteSpace(settings.LastSuccesfullyLoggedUser))
                    tbUsername.Text = settings.LastSuccesfullyLoggedUser;
                if (settings.RememberMe)
                {
                    chkRememberMe.CheckState = CheckState.Checked;
                    tbPassword.Text = settings.Password;
                }
            }
        }
    }
}
