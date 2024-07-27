using Dapper;
using POSA.Helpers.Settings;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
namespace POSA.Forms
{
    public partial class Workers : Form
    {
        public Workers()
        {
            InitializeComponent();
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private void Workers_Load(object sender, EventArgs e)
        {
            cbReportWorker.DisplayMember = "NAME";
            cbReportWorker.ValueMember = "ID";
            FillBranchComboBox();
            FillWorkersCombo();
            fcDrivingLicense.SelectedIndex = 0;
            fcGender.SelectedIndex = 0;
        }
        public async void FillBranchComboBox()
        {
            var settings = Setting.Get();
            var sb = new SqlBuilder();
            sb.Select("ID,NAME");
            var builderTemp = sb.AddTemplate("SELECT /**select**/ FROM BRANCHES");
            await using var conn = new SqlConnection(settings.Sql.ConnectionString());
            var result = await conn.QueryAsync(builderTemp.RawSql);
            if (result.Any())
            {
                var categoryList = (from x in result select x.NAME).ToList();
                fcBranch.DataSource = categoryList;
                fcBranch.SelectedIndex = 0;
            }
        }
        public async void FillReportWorkerCombo()
        {
            var settings = Setting.Get();
            var sb = new SqlBuilder();
            sb.Select("ID,NAME");
            var builderTemp = sb.AddTemplate("SELECT /**select**/ FROM WORKERS");
            await using var conn = new SqlConnection(settings.Sql.ConnectionString());
            var result = await conn.QueryAsync(builderTemp.RawSql);
            if (result.Any())
            {
                var workerList = (from x in result select new { ID = x.ID, NAME = x.NAME }).ToList();
                cbReportWorker.DataSource = workerList;
                cbReportWorker.SelectedIndex = 0;
            }
            dgvVacation.Rows.Clear();
            dgvPayment.Rows.Clear();
        }
        public async void FillWorkersCombo()
        {
            var settings = Setting.Get();
            var sb = new SqlBuilder();
            sb.Select("ID,NAME,PHONE");
            var builderTemp = sb.AddTemplate("SELECT /**select**/ FROM WORKERS");
            await using var conn = new SqlConnection(settings.Sql.ConnectionString());
            var result = await conn.QueryAsync(builderTemp.RawSql);
            if (result.Any())
            {
                var workerList = (from x in result select (x.NAME + @"/" + x.PHONE.Substring(x.PHONE.Length - 4, 4))).ToList();
                fcWorkers.DataSource = workerList;
                fcVacationWorkers.DataSource = workerList;
                fcWorkers.SelectedIndex = 0;
            }
        }
        private void Workers_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void tbSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf('.') == -1))
            {
                e.Handled = true;
                (sender as TextBox).Text += ".";
                (sender as TextBox).SelectionStart = (sender as TextBox).Text.Length;
                (sender as TextBox).SelectionLength = 0;
            }
            else
            {
                if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
                {
                    e.Handled = true;
                }
                if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf('.') > -1))
                {
                    e.Handled = true;
                }
            }
        }
        private void tbIban_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbPhone.Text) && !string.IsNullOrWhiteSpace(tbNameSurname.Text))
            {
                var setting = Setting.Get();
                var sqlBuilder = new SqlBuilder();
                await using var conn = new SqlConnection(setting.Sql.ConnectionString());
                conn.Open();
                var builderTemp = sqlBuilder.AddTemplate("INSERT INTO WORKERS(NAME,PHONE,DUTY,BIRTHDAY,GENDER,STARTINGDATE,DRIVINGLICENSE,IBAN,SALARY,BRANCHID,ISWORKING,CREATEDATE,CREATEDBY) VALUES (@NAME,@PHONE,@DUTY,@BIRTHDAY,@GENDER,@STARTINGDATE,@DRIVINGLICENSE,@IBAN,@SALARY,(SELECT TOP 1 ID FROM BRANCHES WHERE NAME = @BRANCHID),1,GETDATE(),@CREATEDBY)");
                var param = new
                {
                    NAME = tbNameSurname.Text,
                    PHONE = tbPhone.Text,
                    DUTY = tbDuty.Text,
                    BIRTHDAY = tbBirthDay.Text,
                    GENDER = fcGender.Text,
                    STARTINGDATE = Convert.ToDateTime(dtpStartingDate.Text),
                    DRIVINGLICENSE = fcDrivingLicense.Text,
                    IBAN = tbIban.Text,
                    SALARY = tbSalary.Text,
                    BRANCHID = fcBranch.Text,
                    CREATEDBY = setting.LastSuccesfullyLoggedUser
                };
                var result = await conn.ExecuteAsync(builderTemp.RawSql, param);
                if (!(result > 0))
                {
                    MessageBox.Show("Kayıt başarısız! Lütfen tekrar deneyin!", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                FillWorkersCombo();
                conn.Close();
            }
            else
            {
                MessageBox.Show("Adı Soyadı ve/veya Telefon alanı boş bırakılarak kaydedilemez!", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void tbPayedAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf('.') == -1))
            {
                e.Handled = true;
                (sender as TextBox).Text += ".";
                (sender as TextBox).SelectionStart = (sender as TextBox).Text.Length;
                (sender as TextBox).SelectionLength = 0;
            }
            else
            {
                if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
                {
                    e.Handled = true;
                }
                if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf('.') > -1))
                {
                    e.Handled = true;
                }
            }
        }
        private void btnPay_Click(object sender, EventArgs e)
        {
            pnlPayment.Visible = true;
            pnlVacation.Visible = false;
        }
        private void btnVacation_Click(object sender, EventArgs e)
        {
            pnlPayment.Visible = false;
            pnlVacation.Visible = true;
        }
        private void btnCancelVacation_Click(object sender, EventArgs e)
        {
            fcVacationWorkers.SelectedIndex = 0;
        }
        private void btnCancelPayment_Click(object sender, EventArgs e)
        {
            fcWorkers.SelectedIndex = 0;
        }
        private async void btnSavePayment_Click(object sender, EventArgs e)
        {
            var workerName = fcWorkers.Text.Split("/")[0];
            var workerNumEnds = fcWorkers.Text.Split("/")[1];
            var setting = Setting.Get();
            var sqlBuilder = new SqlBuilder();
            await using var conn = new SqlConnection(setting.Sql.ConnectionString());
            conn.Open();
            var builderTemp = sqlBuilder.AddTemplate($"INSERT INTO WORKERPAYMENTS(WORKERID,NOTES,PAYMENT,PAYMENTDATE,CREATEDATE,CREATEDBY) VALUES ((SELECT TOP 1 ID FROM WORKERS WHERE NAME=@NAME AND PHONE LIKE ('%{workerNumEnds}')),@NOTES,@PAYMENT,GETDATE(),GETDATE(),@CREATEDBY)");
            var param = new
            {
                NAME = workerName,
                PAYMENT = Convert.ToDecimal(tbPayedAmount.Text, new CultureInfo("en-GB")),
                NOTES = tbPaymentNote.Text,
                CREATEDBY = setting.LastSuccesfullyLoggedUser
            };
            var result = await conn.ExecuteAsync(builderTemp.RawSql, param);
            if (!(result > 0))
            {
                MessageBox.Show("Kayıt başarısız! Lütfen tekrar deneyin!", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            FillWorkersCombo();
            ClearPayment();
            conn.Close();
        }
        public void ClearPayment()
        {
            fcWorkers.SelectedIndex = 0;
            tbPaymentNote.Text = "";
            tbPayedAmount.Text = "";
        }
        private async void btnSaveVacation_Click(object sender, EventArgs e)
        {
            var workerName = fcVacationWorkers.Text.Split("/")[0];
            var workerNumEnds = fcVacationWorkers.Text.Split("/")[1];
            var setting = Setting.Get();
            var sqlBuilder = new SqlBuilder();
            await using var conn = new SqlConnection(setting.Sql.ConnectionString());
            conn.Open();
            var builderTemp = sqlBuilder.AddTemplate("INSERT INTO WORKERVACATIONS ((SELECT TOP 1 ID FROM WORKERS WHERE NAME=@NAME AND PHONE LIKE ('%{workerNumEnds}')),@NOTES,GETDATE(),@VACATIONENDS,GETDATE(),@CREATEDBY)");
            var param = new
            {
                NAME = workerName,
                PHONE = workerNumEnds,
                NOTES = tbPaymentNote.Text,
                VACATIONENDS = Convert.ToDateTime(dtpVacationEnds.Text),
                CREATEDBY = setting.LastSuccesfullyLoggedUser
            };
            var result = await conn.ExecuteAsync(builderTemp.RawSql, param);
            if (!(result > 0))
            {
                MessageBox.Show("Kayıt başarısız! Lütfen tekrar deneyin!", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            FillWorkersCombo();
            ClearVacation();
            conn.Close();
        }
        public void ClearVacation()
        {
            fcVacationWorkers.SelectedIndex = 0;
            tbVacationNotes.Text = "";
        }
        private void btnShowReports_Click(object sender, EventArgs e)
        {
            FillReportWorkerCombo();
            pnlReport.Visible = !pnlReport.Visible;
            if (pnlReport.Visible)
            {
                pnlPayment.Visible = false;
                pnlVacation.Visible = false;
            }
            else
            {
                btnPay.PerformClick();
            }
        }
        private async void btnShowPayment_Click(object sender, EventArgs e)
        {
            dgvPayment.Visible = true;
            dgvVacation.Visible = false;
            dgvPayment.Rows.Clear();
            if (fcWorkers.Items.Count > 0)
            {
                var setting = Setting.Get();
                var sqlBuilder = new SqlBuilder();
                await using var conn = new SqlConnection(setting.Sql.ConnectionString());
                conn.Open();
                var builderTemp = sqlBuilder.AddTemplate("SELECT ID,PAYMENT,PAYMENTDATE,NOTES FROM WORKERPAYMENTS WHERE WORKERID=@ID ORDER BY PAYMENTDATE DESC");
                var param = new
                {
                    ID = Convert.ToInt32(cbReportWorker.SelectedValue.ToString())
                };
                var result = await conn.QueryAsync(builderTemp.RawSql, param);
                if (result.Any())
                {
                    foreach (var payment in result.ToList())
                    {
                        dgvPayment.Rows.Add(payment.ID, payment.PAYMENTDATE, payment.PAYMENT, payment.NOTES);
                    }
                }
            }
            
        }
        private async void btnShowVacation_Click(object sender, EventArgs e)
        {
            dgvVacation.Visible = true;
            dgvPayment.Visible = false;
            dgvVacation.Rows.Clear();
            if (fcVacationWorkers.Items.Count>0)
            {
                var setting = Setting.Get();
                var sqlBuilder = new SqlBuilder();
                await using var conn = new SqlConnection(setting.Sql.ConnectionString());
                conn.Open();
                var builderTemp = sqlBuilder.AddTemplate("SELECT ID,VACATIONSTARTS,VACATIONENDS,NOTES FROM WORKERVACATION WHERE WORKERID=@ID ORDER BY CREATEDATE DESC");
                var param = new
                {
                    ID = Convert.ToInt32(cbReportWorker.SelectedValue.ToString())
                };
                var result = await conn.QueryAsync(builderTemp.RawSql, param);
                if (result.Any())
                {
                    foreach (var payment in result.ToList())
                    {
                        dgvVacation.Rows.Add(payment.ID, payment.VACATIONSTARTS, payment.VACATIONENDS, payment.NOTES);
                    }
                }
            }
            
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
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
