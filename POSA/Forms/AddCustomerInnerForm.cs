using Dapper;
using POSA.Dto;
using POSA.Helpers.Settings;
using System.Data.SqlClient;
namespace POSA.Forms
{
    public partial class AddCustomerInnerForm : Form
    {
        public bool IsDialog = false;
        public int? CustomerID = 0;
        public AddCustomerInnerForm(bool isDialog, int? _id)
        {
            InitializeComponent();
            this.IsDialog = isDialog;
            this.CustomerID = _id;
        }
        private async void btnSave_Click(object sender, EventArgs e)
        {
            var setting = Setting.Get();
            if (IsDialog)
            {
                var sqlBuilder = new SqlBuilder();
                var builderTemp = sqlBuilder.AddTemplate("UPDATE CUSTOMERS SET NAME=@NAME , PHONE = @PHONE , ADDRESS=@ADDRESS , TAXDEPT = @TAXDEPT , TAXNUMBER = @TAXNUMBER , EMAIL = @EMAIL , NOTE = @NOTE , CHANGEDBY = @CHANGEDBY , CHANGEDATE = GETDATE()  WHERE ID = @ID");
                var param = new
                {
                    NAME = tbName.Text,
                    PHONE = tbPhone.Text ?? "",
                    ADDRESS = tbAddress.Text ?? "",
                    TAXNUMBER = tbTaxNo.Text ?? "",
                    TAXDEPT = tbTaxDept.Text ?? "",
                    EMAIL = tbEmail.Text ?? "",
                    NOTE = tbNote.Text ?? "",
                    CHANGEDBY = setting.LastSuccesfullyLoggedUser,
                    ID = CustomerID
                };
                await using var conn = new SqlConnection(setting.Sql.ConnectionString());
                conn.Open();
                var result = conn.ExecuteAsync(builderTemp.RawSql, param);
                if (result != null)
                    if (result.Result > 0)
                    {
                        MessageBox.Show("Müşteri başarılı şekilde güncellendi!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Güncellenemedi. Bağlantınızı kontrol ederek tekrar deneyiniz!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
            }
            else
            {
                var sqlBuilder = new SqlBuilder();
                var builderTemp = sqlBuilder.AddTemplate("INSERT INTO CUSTOMERS(NAME,PHONE,ADDRESS,TAXNUMBER,TAXDEPT,EMAIL,NOTE,CREATEDBY,CREATEDATE)  VALUES (@NAME,@PHONE,@ADDRESS,@TAXNUMBER,@TAXDEPT,@EMAIL,@NOTE,@CREATEDBY,GETDATE())");
                var param = new
                {
                    NAME = tbName.Text,
                    PHONE = tbPhone.Text,
                    ADDRESS = tbAddress.Text ?? "",
                    TAXNUMBER = tbTaxNo.Text ?? "",
                    TAXDEPT = tbTaxDept.Text ?? "",
                    EMAIL = tbEmail.Text ?? "",
                    NOTE = tbNote.Text ?? "",
                    CREATEDBY = setting.LastSuccesfullyLoggedUser
                };
                await using var conn = new SqlConnection(setting.Sql.ConnectionString());
                conn.Open();
                var result = conn.ExecuteAsync(builderTemp.RawSql, param);
                if (result != null)
                    if (result.Result > 0)
                    {
                        MessageBox.Show("Müşteri başarılı şekilde kaydedildi!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Kayıt gerçekleştirilemedi. Bağlantınızı kontrol ederek tekrar deneyiniz!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            tbAddress.Text = "";
            tbEmail.Text = "";
            tbName.Text = "";
            tbNote.Text = "";
            tbTaxDept.Text = "";
            tbTaxNo.Text = "";
            tbPhone.Text = "";
        }
        private async void AddCustomerInnerForm_Load(object sender, EventArgs e)
        {
            if (IsDialog)
            {
                btnCancel.Visible = false;
                btnClose.Visible = true;
                this.BackgroundImage = Properties.Resources.BackgroundSmall1;
                this.BackgroundImageLayout = ImageLayout.Stretch;
            }
            if (IsDialog && CustomerID is not null && CustomerID > 0)
            {
                var setting = Setting.Get();
                var sqlBuilder = new SqlBuilder();
                var builderTemp = sqlBuilder.AddTemplate("SELECT NAME,PHONE,ADDRESS,EMAIL,NOTE,TAXDEPT,TAXNUMBER FROM CUSTOMERS WHERE ID = @ID");
                var param = new
                {
                    ID = CustomerID
                };
                await using var conn = new SqlConnection(setting.Sql.ConnectionString());
                conn.Open();
                var result = conn.QueryAsync<Customer>(builderTemp.RawSql, param).Result.ToList();
                if (result.Count > 0)
                {
                    var customer = result.First();
                    tbAddress.Text = customer.ADDRESS ?? "";
                    tbEmail.Text = customer.EMAIL ?? "";
                    tbName.Text = customer.NAME ?? "";
                    tbNote.Text = customer.NOTE ?? "";
                    tbTaxDept.Text = customer.TAXDEPT ?? "";
                    tbTaxNo.Text = customer.TAXNUMBER ?? "";
                    tbPhone.Text = customer.PHONE ?? "";
                }
            }
        }
        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
