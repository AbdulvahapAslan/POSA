using Dapper;
using POSA.Helpers.Settings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace POSA.Forms
{
    public partial class AddSupplierInnerForm : Form
    {
        public bool IsDialog = false;
        public AddSupplierInnerForm(bool isDialog)
        {
            InitializeComponent();
            this.IsDialog = isDialog;
        }
        private void AddSupplierInnerForm_Load(object sender, EventArgs e)
        {
            if (IsDialog)
            {
                btnCancel.Visible = false;
                btnClose.Visible = true;
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private async void btnSave_Click(object sender, EventArgs e)
        {
            var setting = Setting.Get();
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
            if (IsDialog)
            {
                if (result != null)
                    if (result.Result > 0)
                        this.DialogResult = DialogResult.OK;
                    else
                        this.DialogResult = DialogResult.Cancel;
            }
            else
            {
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
