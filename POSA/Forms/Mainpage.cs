using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POSA.Helpers.Settings;
using System.Data.SqlClient;
using POSA.Dto;
namespace POSA.Forms
{
    public partial class Mainpage : Form
    {
        public Mainpage()
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
        private async void Mainpage_Load(object sender, EventArgs e)
        {
            var settings = Setting.Get();
            var sqlBuilder = new SqlBuilder();
            sqlBuilder.Where("USERS.USERNAME = @USERNAME",
                new
                {
                    USERNAME = settings.LastSuccesfullyLoggedUser
                });
            var builderTemplate = sqlBuilder.AddTemplate($"""
                    SELECT LICENCEENDDATE,COMPANY FROM USERS LEFT JOIN 
                    CUSTOMERS ON USERS.CUSTOMERID = CUSTOMERS.ID /**where**/
                """);
            await using var conn = new SqlConnection(settings.MainCS);
            conn.Open();
            var result = conn.QuerySingleOrDefaultAsync<MainPageInfos>(builderTemplate.RawSql, builderTemplate.Parameters);
            if (result is not null)
                if (result.Result is not null)
                {
                    var dto = result.Result;
                    lblBusiness.Text = dto.COMPANY ?? "";
                    if (DateTime.Now < dto.LICENCEENDDATE)
                        lblLicence.Text = "AKTİF";
                    else
                        lblLicence.Text = "PASİF";
                }
            lblUser.Text = settings.LastSuccesfullyLoggedUser;
        }
        private void Mainpage_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void btnSales_Click(object sender, EventArgs e)
        {
            if (lblLicence.Text == "AKTİF")
            {
                var sp = new Sales();
                sp.Show();
            }
            else
            {
                MessageBox.Show("Lisansiniz pasif durumdadır. Lütfen lisans yenileme işlemi yapınız.","UYARI",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }
        private void btnStocks_Click(object sender, EventArgs e)
        {
        }
    }
}
