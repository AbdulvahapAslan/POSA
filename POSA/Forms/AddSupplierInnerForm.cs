using Dapper;
using POSA.Dto;
using POSA.Helpers.Settings;
using System.Data.SqlClient;
namespace POSA.Forms
{
    public partial class AddSupplierInnerForm : Form
    {
        public bool IsDialog = false;
        public int? id = 0;
        public AddSupplierInnerForm(bool isDialog, int? _id)
        {
            InitializeComponent();
            this.IsDialog = isDialog;
            this.id = _id;
        }
        private async void AddSupplierInnerForm_Load(object sender, EventArgs e)
        {
            if (IsDialog)
            {
                btnCancel.Visible = false;
                btnClose.Visible = true;
            }
            if (IsDialog && id is not null && id > 0)
            {
                var setting = Setting.Get();
                var sqlBuilder = new SqlBuilder();
                var builderTemp = sqlBuilder.AddTemplate("SELECT NAME,COMPANY,EXECUTIVE,PHONE,ADDRESS,TAXNUMBER,TAXDEPT,SECTOR,NOTES FROM SUPPLIERS WHERE ID = @ID");
                var param = new
                {
                    ID = id
                };
                await using var conn = new SqlConnection(setting.Sql.ConnectionString());
                conn.Open();
                var result = conn.QueryAsync<Supplier>(builderTemp.RawSql, param).Result.ToList();
                if (result.Count > 0)
                {
                    var supplier = result.First();
                    tbAddress.Text = supplier.ADDRESS ?? "";
                    tbExecutive.Text = supplier.EXECUTIVE ?? "";
                    tbName.Text = supplier.NAME ?? "";
                    tbNote.Text = supplier.NOTES ?? "";
                    tbTaxDept.Text = supplier.TAXDEPT ?? "";
                    tbTaxNo.Text = supplier.TAXNUMBER ?? "";
                    tbPhone.Text = supplier.PHONE ?? "";
                    tbCompany.Text = supplier.COMPANY ?? "";
                    tbSector.Text = supplier.SECTOR ?? "";
                }
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private async void btnSave_Click(object sender, EventArgs e)
        {
            var setting = Setting.Get();
            if (IsDialog && id > 0)
            {
                var sqlBuilder = new SqlBuilder();
                var builderTemp = sqlBuilder.AddTemplate("UPDATE SUPPLIERS SET NAME=@NAME , PHONE = @PHONE , ADDRESS=@ADDRESS , TAXDEPT = @TAXDEPT , TAXNUMBER = @TAXNUMBER, COMPANY = @COMPANY , EXECUTIVE = @EXECUTIVE , NOTES = @NOTES, SECTOR = @SECTOR , CHANGEDBY = @CHANGEDBY , CHANGEDATE = GETDATE()  WHERE ID = @ID");
                var param = new
                {
                    NAME = tbName.Text,
                    COMPANY = tbCompany.Text,
                    EXECUTIVE = tbExecutive.Text,
                    PHONE = tbPhone.Text,
                    ADDRESS = tbAddress.Text,
                    TAXNUMBER = tbTaxNo.Text,
                    TAXDEPT = tbTaxDept.Text,
                    SECTOR = tbSector.Text,
                    NOTES = tbNote.Text,
                    CHANGEDBY = setting.LastSuccesfullyLoggedUser,
                    ID = id
                };
                await using var conn = new SqlConnection(setting.Sql.ConnectionString());
                conn.Open();
                var result = conn.ExecuteAsync(builderTemp.RawSql, param);
                if (result != null)
                    if (result.Result > 0)
                    {
                        MessageBox.Show("Tedarikçi başarılı şekilde güncellendi!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Güncellenemedi. Bağlantınızı kontrol ederek tekrar deneyiniz!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                var sqlBuilder = new SqlBuilder();
                var builderTemp = sqlBuilder.AddTemplate("INSERT INTO SUPPLIERS(NAME,COMPANY,EXECUTIVE,PHONE,ADDRESS,TAXNUMBER,TAXDEPT,SECTOR,NOTES,CREATEDBY,CREATEDATE)  VALUES (@NAME,@COMPANY,@EXECUTIVE,@PHONE,@ADDRESS,@TAXNUMBER,@TAXDEPT,@SECTOR,@NOTES,@CREATEDBY,GETDATE())");
                var param = new
                {
                    NAME = tbName.Text,
                    COMPANY = tbCompany.Text,
                    EXECUTIVE = tbExecutive.Text,
                    PHONE = tbPhone.Text,
                    ADDRESS = tbAddress.Text,
                    TAXNUMBER = tbTaxNo.Text,
                    TAXDEPT = tbTaxDept.Text,
                    SECTOR = tbSector.Text,
                    NOTES = tbNote.Text,
                    CREATEDBY = setting.LastSuccesfullyLoggedUser
                };
                await using var conn = new SqlConnection(setting.Sql.ConnectionString());
                conn.Open();
                var result = conn.ExecuteAsync(builderTemp.RawSql, param);
                if (result != null)
                    if (result.Result > 0)
                    {
                        MessageBox.Show("Tedarikçi başarılı şekilde kaydedildi!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            tbCompany.Text = "";
            tbExecutive.Text = "";
            tbName.Text = "";
            tbNote.Text = "";
            tbSector.Text = "";
            tbTaxDept.Text = "";
            tbTaxNo.Text = "";
            tbPhone.Text = "";
        }
    }
}
