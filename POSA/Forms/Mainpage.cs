using Dapper;
using POSA.Dto;
using POSA.Helpers.Settings;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Xml;
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
        public static decimal USD = 0;
        public static decimal EURO = 0;
        public void GetCurrencies()
        {
            try
            {
                XmlDocument xmlVerisi = new XmlDocument();
                xmlVerisi.Load("https://www.tcmb.gov.tr/kurlar/today.xml");
                USD = Convert.ToDecimal(xmlVerisi.SelectSingleNode(string.Format("Tarih_Date/Currency[@Kod='{0}']/ForexSelling", "USD")).InnerText, new CultureInfo("en-gb"));
                EURO = Convert.ToDecimal(xmlVerisi.SelectSingleNode(string.Format("Tarih_Date/Currency[@Kod='{0}']/ForexSelling", "EUR")).InnerText, new CultureInfo("en-gb"));
            }
            catch (Exception)
            {
            }

        }
        private async void Mainpage_Load(object sender, EventArgs e)
        {
            GetCurrencies();
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
            var forms = Application.OpenForms.Cast<Form>().Where(x => x.Name == "Satış İşlemleri");
            if (forms.Any())
            {
                MessageBox.Show("Bu pencere zaten açık!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (lblLicence.Text == "AKTİF")
            {
                var sp = new Sales();
                sp.Name = "Satış İşlemleri";
                sp.Show();
            }
            else
            {
                MessageBox.Show("Lisansiniz pasif durumdadır. Lütfen lisans yenileme işlemi yapınız.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnStocks_Click(object sender, EventArgs e)
        {
            var forms = Application.OpenForms.Cast<Form>().Where(x => x.Name == "Stoklar");
            if (forms.Any())
            {
                MessageBox.Show("Bu pencere zaten açık!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (lblLicence.Text == "AKTİF")
            {
                var sp = new AddStock();
                sp.Name = "Stoklar";
                sp.Show();
            }
            else
            {
                MessageBox.Show("Lisansiniz pasif durumdadır. Lütfen lisans yenileme işlemi yapınız.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnBuying_Click(object sender, EventArgs e)
        {
            var forms = Application.OpenForms.Cast<Form>().Where(x => x.Name == "Ürün Giriş");
            if (forms.Any())
            {
                MessageBox.Show("Bu pencere zaten açık!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (lblLicence.Text == "AKTİF")
            {
                var load = new Loading("NewProduct", 750);
                load.Show();
            }
            else
            {
                MessageBox.Show("Lisansiniz pasif durumdadır. Lütfen lisans yenileme işlemi yapınız.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnWholesaler_Click(object sender, EventArgs e)
        {
            var forms = Application.OpenForms.Cast<Form>().Where(x => x.Name == "Tedarikçi Ekle");
            if (forms.Any())
            {
                MessageBox.Show("Bu pencere zaten açık!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                if (lblLicence.Text == "AKTİF")
                {
                    var addS = new AddSupplier();
                    addS.Name = "Tedarikçi Ekle";
                    addS.Show();
                }
                else
                {
                    MessageBox.Show("Lisansiniz pasif durumdadır. Lütfen lisans yenileme işlemi yapınız.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void trmCurrency_Tick(object sender, EventArgs e)
        {
            GetCurrencies();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            var forms = Application.OpenForms.Cast<Form>().Where(x => x.Name == "Müşteri Ekle");
            if (forms.Any())
            {
                MessageBox.Show("Bu pencere zaten açık!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                if (lblLicence.Text == "AKTİF")
                {
                    var addC = new AddCustomer();
                    addC.Name = "Müşteri Ekle";
                    addC.Show();
                }
                else
                {
                    MessageBox.Show("Lisansiniz pasif durumdadır. Lütfen lisans yenileme işlemi yapınız.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnPricing_Click(object sender, EventArgs e)
        {
            var forms = Application.OpenForms.Cast<Form>().Where(x => x.Name == "Fiyat Güncelle");
            if (forms.Any())
            {
                MessageBox.Show("Bu pencere zaten açık!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                if (lblLicence.Text == "AKTİF")
                {
                    var up = new UpdatePrices();
                    up.Name = "Fiyat Güncelle";
                    up.Show();
                }
                else
                {
                    MessageBox.Show("Lisansiniz pasif durumdadır. Lütfen lisans yenileme işlemi yapınız.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            var forms = Application.OpenForms.Cast<Form>().Where(x => x.Name == "Personeller");
            if (forms.Any())
            {
                MessageBox.Show("Bu pencere zaten açık!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                if (lblLicence.Text == "AKTİF")
                {
                    var wr = new Workers();
                    wr.Name = "Personeller";
                    wr.Show();
                }
                else
                {
                    MessageBox.Show("Lisansiniz pasif durumdadır. Lütfen lisans yenileme işlemi yapınız.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnBusiness_Click(object sender, EventArgs e)
        {
            var forms = Application.OpenForms.Cast<Form>().Where(x => x.Name == "İşletme");
            if (forms.Any())
            {
                MessageBox.Show("Bu pencere zaten açık!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                if (lblLicence.Text == "AKTİF")
                {
                    var wp = new Workplace();
                    wp.Name = "İşletme";
                    wp.Show();
                }
                else
                {
                    MessageBox.Show("Lisansiniz pasif durumdadır. Lütfen lisans yenileme işlemi yapınız.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            var forms = Application.OpenForms.Cast<Form>().Where(x => x.Name == "Raporlar");
            if (forms.Any())
            {
                MessageBox.Show("Bu pencere zaten açık!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                if (lblLicence.Text == "AKTİF")
                {
                    var rp = new Reports();
                    rp.Name = "Raporlar";
                    rp.Show();
                }
                else
                {
                    MessageBox.Show("Lisansiniz pasif durumdadır. Lütfen lisans yenileme işlemi yapınız.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
