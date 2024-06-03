using Dapper;
using POSA.Dto;
using POSA.Helpers.Settings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace POSA.Forms
{
    public partial class NewProduct : Form
    {
        public NewProduct()
        {
            InitializeComponent();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
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
        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            var ac = new AddCategory();
            DialogResult dr = ac.ShowDialog();
            FillCategoryComboBox();
        }
        public async void FillCategoryComboBox()
        {
            var settings = Setting.Get();
            var sb = new SqlBuilder();
            sb.Select("ID,NAME");
            var builderTemp = sb.AddTemplate("SELECT /**select**/ FROM CATEGORIES");
            await using var conn = new SqlConnection(settings.Sql.ConnectionString());
            var result = await conn.QueryAsync(builderTemp.RawSql);
            if (result.Any())
            {
                var categoryList = (from x in result select new { ID = x.ID, NAME = x.NAME }).ToList();
                cbCategory.DataSource = categoryList;
                cbCategory.SelectedIndex = 0;
            }
        }
        public async void FillUnitComboBox()
        {
            var settings = Setting.Get();
            var sb = new SqlBuilder();
            sb.Select("ID,NAME");
            var builderTemp = sb.AddTemplate("SELECT /**select**/ FROM UNITS");
            await using var conn = new SqlConnection(settings.Sql.ConnectionString());
            var result = await conn.QueryAsync(builderTemp.RawSql);
            if (result.Any())
            {
                var categoryList = (from x in result select new { ID = x.ID, NAME = x.NAME }).ToList();
                cbUnit.DataSource = categoryList;
                cbUnit.SelectedIndex = 0;
            }
        }
        private async void NewProduct_Load(object sender, EventArgs e)
        {
            cbCategory.DisplayMember = "NAME";
            cbCategory.ValueMember = "ID";
            cbUnit.DisplayMember = "NAME";
            cbUnit.ValueMember = "ID";
            cbBranch.DisplayMember = "NAME";
            cbBranch.ValueMember = "ID";
            cbColor.DisplayMember = "NAME";
            cbColor.ValueMember = "ID";
            cbSize.DisplayMember = "NAME";
            cbSize.ValueMember = "ID";
            cbListingBranch.DisplayMember = "NAME";
            cbListingBranch.ValueMember = "ID";
            cbSupplier.DisplayMember = "NAME";
            cbSupplier.ValueMember = "ID";
            cbMaterial.DisplayMember = "NAME";
            cbMaterial.ValueMember = "ID";
            FillCategoryComboBox();
            FillUnitComboBox();
            FillBranchComboBox();
            FillColorComboBox();
            FillSizeComboBox();
            FillSupplierComboBox();
            FillMaterialComboBox();
        }
        public void ClearAfterAddingToDB()
        {
            pbProduct.BackgroundImage = Properties.Resources._256pxNoImage;
            if (tbBarcode.Enabled == false)
                tbBarcode.Enabled = true;
            tbBarcode.Text = "";
            tbBarcode.BackColor = Color.White;
            tbBuyPrice.Text = "0";
            tbCriticalStock.Text = "0";
            tbVatRate.Text = "0";
            tbStock.Text = "0";
            tbSalePrice.Text = "0";
            tbSalePrice2.Text = "0";
            tbSalePrice3.Text = "0";
            tbProductName.Text = "";
            cbBranch.SelectedIndex = 0;
            cbCategory.SelectedIndex = 0;
            cbColor.SelectedIndex = 0;
            cbListingBranch.SelectedIndex = 0;
            cbMaterial.SelectedIndex = 0;
            cbSupplier.SelectedIndex = 0;
            cbUnit.SelectedIndex = 0;
            LastAddedImagePath = "";
            VariantImages.Clear();
            dgvVariant.Rows.Clear();
        }
        private string ConvertImageToBase64(Image? img)
        {
            if (img is null)
                return "";
            using (Image image = img)
            {
                using (MemoryStream m = new MemoryStream())
                {
                    image.Save(m, image.RawFormat);
                    byte[] imageBytes = m.ToArray();
                    string base64String = Convert.ToBase64String(imageBytes);
                    return base64String;
                }
            }
        }
        public Image Base64ToImage(string base64String)
        {
            // Convert base 64 string to byte[]
            byte[] imageBytes = Convert.FromBase64String(base64String);
            // Convert byte[] to Image
            using (var ms = new MemoryStream(imageBytes, 0, imageBytes.Length))
            {
                Image image = Image.FromStream(ms, true);
                return image;
            }
        }
        public class VariantImage
        {
            public string ImagePath { get; set; } = "";
            public string Barcode { get; set; }
        }
        public List<VariantImage> VariantImages = new List<VariantImage>();
        public void ClearAfterAddVariant()
        {
            tbBarcode.Text = "";
            tbBarcode.BackColor = Color.White;
            LastAddedImagePath = "";
            pbProduct.BackgroundImage = Properties.Resources._256pxNoImage;
            cbColor.SelectedIndex = 0;
            cbMaterial.SelectedIndex = 0;
            cbSize.SelectedIndex = 0;
            tbCriticalStock.Text = "0";
            tbStock.Text = "0";
            btnGiveNextBarcode.PerformClick();
        }
        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbBarcode.Text) || string.IsNullOrWhiteSpace(tbProductName.Text))
            {
                MessageBox.Show("Barkod veya ürün adı boş olan bir ürün kaydedilemez.", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (tbSalePrice.Text == "0" || tbBuyPrice.Text == "0")
            {
                MessageBox.Show("Satış yada alış fiyatı 0 olan bir ürün kaydedilemez.", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (tbStock.Text == "0")
            {
                MessageBox.Show("Stoksuz ürün kaydedilemez.", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var barcode = tbBarcode.Text;
            var setting = Setting.Get();
            await using var conn = new SqlConnection(setting.Sql.ConnectionString());
            conn.Open();
            if (tbBarcode.Enabled == false)
            {//update
                var sqlBuilder = new SqlBuilder();
                var builderTemp = sqlBuilder.AddTemplate("UPDATE PRODUCTS SET CATEGORYID=@CATEGORYID AND SUPPLIERID=@SUPPLIERID AND MATERIALID=@MATERIALID AND SIZEID=@SIZEID AND UNITID=@UNITID AND COLORID=@COLORID AND BRANCHID=@BRANCHID AND NAME=@NAME AND SALEPRICE=@SALEPRICE AND SALEPRICE2=@SALEPRICE2 AND SALEPRICE3=@SALEPRICE3 AND VATRATE=@VATRATE AND CRITICALSTOCK=@CRITICALSTOCK AND B64IMAGE=@B64IMAGE AND CHANGEDBY = @CHANGEDBY AND CHANGEDATE=GETDATE() WHERE BARCODE = @BARCODE");
                var param = new
                {
                    CATEGORYID = Convert.ToInt32(cbCategory.SelectedValue.ToString()),
                    SUPPLIERID = Convert.ToInt32(cbSupplier.SelectedValue.ToString()),
                    MATERIALID = Convert.ToInt32(cbMaterial.SelectedValue.ToString()),
                    SIZEID = Convert.ToInt32(cbSize.SelectedValue.ToString()),
                    UNITID = Convert.ToInt32(cbUnit.SelectedValue.ToString()),
                    COLORID = Convert.ToInt32(cbColor.SelectedValue.ToString()),
                    BRANCHID = Convert.ToInt32(cbBranch.SelectedValue.ToString()),
                    NAME = tbProductName.Text,
                    BARCODE = tbBarcode.Text,
                    SALEPRICE = Convert.ToDecimal(tbSalePrice.Text, new CultureInfo("en-GB")),
                    SALEPRICE2 = Convert.ToDecimal(tbSalePrice2.Text, new CultureInfo("en-GB")),
                    SALEPRICE3 = Convert.ToDecimal(tbSalePrice3.Text, new CultureInfo("en-GB")),
                    BUYPRICE = Convert.ToDecimal(tbBuyPrice.Text, new CultureInfo("en-GB")),
                    VATRATE = Convert.ToDecimal(tbVatRate.Text, new CultureInfo("en-GB")),
                    CRITICALSTOCK = Convert.ToDecimal(tbCriticalStock.Text, new CultureInfo("en-GB")),
                    B64IMAGE = pbProduct.Image == Properties.Resources._256pxNoImage ? "" : ConvertImageToBase64(pbProduct.Image),
                    CREATEDBY = setting.LastSuccesfullyLoggedUser
                };
                var result = await conn.ExecuteAsync(builderTemp.RawSql, param);
                if (result > 0)
                {
                    sqlBuilder = new SqlBuilder();
                    builderTemp = sqlBuilder.AddTemplate($"""
                    UPDATE STOCKS SET BUYPRICE=@BUYPRICE WHERE ID = (SELECT ID FROM STOCKS WHERE PRODID = (SELECT TOP 1 ID FROM PRODUCTS WITH (NOLOCK) WHERE BARCODE = @BARCODE) ORDER BY CREATEDATE DESC)
                    """);
                    var param2 = new
                    {
                        BARCODE = tbBarcode.Text,
                        BUYPRICE = tbBuyPrice.Text
                    };
                    result = await conn.ExecuteAsync(builderTemp.RawSql, param2);
                    ClearAfterAddingToDB();
                }
                else
                {
                    MessageBox.Show("Güncellenemedi! Kayıtlar veri tabanına aktarılamadı.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                if (btnSave.Text.StartsWith("LİST"))
                {
                    foreach (DataGridViewRow row in dgvVariant.Rows)
                    {
                        if (row.Cells["VBARCODE"].Value.ToString() == barcode)
                        {
                            MessageBox.Show("Bu barkodla bir ürün listede mevcut.", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    //add to variant grid and picture to string list
                    dgvVariant.Rows.Add(tbBarcode.Text, tbProductName.Text, cbCategory.Text, cbUnit.Text, cbColor.Text, cbSize.Text, cbMaterial.Text, tbBuyPrice.Text, tbSalePrice.Text, tbSalePrice2.Text, tbSalePrice3.Text, tbVatRate.Text, tbStock.Text, tbCriticalStock.Text, cbSupplier.Text, cbBranch.Text);
                    VariantImages.Add(new VariantImage
                    {
                        ImagePath = LastAddedImagePath,
                        Barcode = tbBarcode.Text
                    });
                    ClearAfterAddVariant();
                }
                else
                {
                    foreach (DataGridViewRow row in dgvMain.Rows)
                    {
                        if (row.Cells["BARCODE"].Value.ToString() == barcode)
                        {
                            MessageBox.Show("Bu barkodla bir ürün listede mevcut.", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    var sqlBuilder = new SqlBuilder();
                    var builderTemp = sqlBuilder.AddTemplate("INSERT INTO PRODUCTS(CATEGORYID,SUPPLIERID,MATERIALID,SIZEID,UNITID,COLORID,BRANCHID,NAME,BARCODE,SALEPRICE,SALEPRICE2,SALEPRICE3,VATRATE,CRITICALSTOCK,B64IMAGE,CREATEDBY,CREATEDATE) VALUES(@CATEGORYID,@SUPPLIERID,@MATERIALID,@SIZEID,@UNITID,@COLORID,@BRANCHID,@NAME,@BARCODE,@SALEPRICE,@SALEPRICE2,@SALEPRICE3,@VATRATE,@CRITICALSTOCK,@B64IMAGE,@CREATEDBY,GETDATE())");
                    var param = new
                    {
                        CATEGORYID = Convert.ToInt32(cbCategory.SelectedValue.ToString()),
                        SUPPLIERID = Convert.ToInt32(cbSupplier.SelectedValue.ToString()),
                        MATERIALID = Convert.ToInt32(cbMaterial.SelectedValue.ToString()),
                        SIZEID = Convert.ToInt32(cbSize.SelectedValue.ToString()),
                        UNITID = Convert.ToInt32(cbUnit.SelectedValue.ToString()),
                        COLORID = Convert.ToInt32(cbColor.SelectedValue.ToString()),
                        BRANCHID = Convert.ToInt32(cbBranch.SelectedValue.ToString()),
                        NAME = tbProductName.Text,
                        BARCODE = tbBarcode.Text,
                        SALEPRICE = Convert.ToDecimal(tbSalePrice.Text, new CultureInfo("en-GB")),
                        SALEPRICE2 = Convert.ToDecimal(tbSalePrice2.Text, new CultureInfo("en-GB")),
                        SALEPRICE3 = Convert.ToDecimal(tbSalePrice3.Text, new CultureInfo("en-GB")),
                        VATRATE = Convert.ToDecimal(tbVatRate.Text, new CultureInfo("en-GB")),
                        CRITICALSTOCK = Convert.ToDecimal(tbCriticalStock.Text, new CultureInfo("en-GB")),
                        B64IMAGE = string.IsNullOrWhiteSpace(LastAddedImagePath) ? "" : ConvertImageToBase64(Image.FromFile(LastAddedImagePath)),
                        CREATEDBY = setting.LastSuccesfullyLoggedUser
                    };
                    var result = await conn.ExecuteAsync(builderTemp.RawSql, param);
                    if (result > 0)
                    {
                        sqlBuilder = new SqlBuilder();
                        builderTemp = sqlBuilder.AddTemplate(
                            $"""
                                INSERT INTO STOCKS(PRODID,STOCK,BUYPRICE,CREATEDATE,CREATEDBY) VALUES((SELECT TOP 1 ID FROM PRODUCTS WITH (NOLOCK) WHERE BARCODE = @BARCODE),@STOCK,@BUYPRICE,GETDATE(),@CREATEDBY)
                            """);
                        var param2 = new
                        {
                            BARCODE = tbBarcode.Text,
                            BUYPRICE = tbBuyPrice.Text,
                            CREATEDBY = setting.LastSuccesfullyLoggedUser,
                            STOCK = tbStock.Text
                        };
                        result = await conn.ExecuteAsync(builderTemp.RawSql, param2);
                        ClearAfterAddingToDB();
                    }
                    else
                    {
                        MessageBox.Show("Güncellenemedi! Kayıtlar veri tabanına aktarılamadı.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            RefreshMainDataGrid();
        }
        private void GeneralOnlyDecimalNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        private void btnAddUnit_Click(object sender, EventArgs e)
        {
            var au = new AddUnit();
            DialogResult dr = au.ShowDialog();
            FillUnitComboBox();
        }
        private void NewProduct_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void labelBorderPainter_Paint(object sender, PaintEventArgs e)
        {
            var lbl = (System.Windows.Forms.Label)sender;
            ControlPaint.DrawBorder(e.Graphics, lbl.DisplayRectangle, Color.White, ButtonBorderStyle.Solid);
        }
        private void btnNewVariant_Click(object sender, EventArgs e)
        {
            if (dgvVariant.Visible == false)
            {
                dgvMain.Visible = false;
                dgvVariant.Visible = true;
                btnSaveVariants.Visible = true;
                btnSave.Text = "LİSTEYE EKLE";
                rtbSearch.Visible = false;
                pbClearSearch.Visible = false;
                pbMagGlass.Visible = false;
                lblListingBranch.Visible = false;
                cbListingBranch.Visible = false;
            }
            else
            {
                rtbSearch.Visible = true;
                lblListingBranch.Visible = true;
                cbListingBranch.Visible = true;
                pbClearSearch.Visible = true;
                pbMagGlass.Visible = true;
                dgvMain.Visible = true;
                btnSaveVariants.Visible = false;
                dgvVariant.Visible = false;
                btnSave.Text = "KAYDET";
            }
        }
        private void btnClearPage_Click(object sender, EventArgs e)
        {
            dgvMain.Visible = true;
            dgvVariant.Visible = false;
            btnSaveVariants.Visible = false;
            btnSave.Text = "KAYDET";
            ClearAfterAddingToDB();
        }
        private void dgvVariant_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        public async void DeleteFromDB(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
                return;
            var settings = Setting.Get();
            var qry = $"DELETE FROM PRODUCTS WHERE BARCODE = '{id}'";
            await using var conn = new SqlConnection(settings.Sql.ConnectionString());
            conn.Open();
            var result = await conn.ExecuteAsync(qry);
            qry = $"DELETE FROM STOCKS WHERE PRODID = '{id}'";
            result = await conn.ExecuteAsync(qry);
        }
        public async void RefreshMainDataGrid()
        {
            dgvMain.EndEdit();
            var settings = Setting.Get();
            var qry = $"""
                WITH TABLO AS(SELECT TOP 200 PROD.ID,PROD.BARCODE,PROD.NAME,PROD.SALEPRICE AS SELLPRICE,PROD.SALEPRICE2 AS SELLPRICE2,
                PROD.SALEPRICE3 AS SELLPRICE3,
                PROD.CRITICALSTOCK,PROD.VATRATE,CAT.NAME AS CATEGORY,COL.NAME AS COLOR,
                UN.NAME AS UNIT,MAT.NAME AS  MATERIAL,SUP.NAME AS SUPPLIER,S.NAME AS SIZE, PROD.B64IMAGE
                FROM PRODUCTS AS PROD LEFT JOIN 
                CATEGORIES AS CAT ON CAT.ID=PROD.CATEGORYID LEFT JOIN
                COLORS AS COL ON COL.ID = PROD.COLORID LEFT JOIN 
                UNITS AS UN ON UN.ID = PROD.UNITID LEFT JOIN 
                MATERIALS AS MAT ON MAT.ID = PROD.MATERIALID LEFT JOIN 
                SUPPLIERS AS SUP ON SUP.ID = PROD.SUPPLIERID LEFT JOIN 
                SIZES AS S ON S.ID = PROD.SIZEID WHERE PROD.BRANCHID={Convert.ToInt32(cbListingBranch.SelectedValue.ToString())})
                SELECT T.*,(SELECT SUM(STOCK) FROM STOCKS AS ST WHERE ST.PRODID = T.ID) AS STOCK ,
                (SELECT TOP 1 ST.BUYPRICE FROM STOCKS AS ST WHERE ST.PRODID = T.ID ORDER BY ST.CREATEDATE DESC) AS BUYINGPRICE
                FROM TABLO AS T ORDER BY T.ID
                """; ;
            await using var conn = new SqlConnection(settings.Sql.ConnectionString());
            conn.Open();
            var ar = new SqlDataAdapter(qry, conn);
            var dt = new DataTable();
            ar.Fill(dt);
            dgvMain.DataSource = dt;
            dgvMain.ClearSelection();
        }
        private void dgvMain_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvMain.Columns["DELETE"].Index)
            {
                var dr = MessageBox.Show("Silmek istediğinize emin misiniz?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (dr == DialogResult.Yes)
                {
                    DeleteFromDB((dgvMain.Rows[e.RowIndex].Cells["BARCODE"].Value ?? "").ToString());
                    RefreshMainDataGrid();
                }
            }
            if (e.ColumnIndex == dgvMain.Columns["UPDATE"].Index)
            {
                tbStock.Enabled = false;
                tbBarcode.Text = dgvMain.Rows[e.RowIndex].Cells["BARCODE"].Value.ToString();
                tbBarcode.Enabled = false;
                tbProductName.Text = dgvMain.Rows[e.RowIndex].Cells["NAME"].Value.ToString();
                cbCategory.Text = dgvMain.Rows[e.RowIndex].Cells["CATEGORY"].Value.ToString();
                cbUnit.Text = dgvMain.Rows[e.RowIndex].Cells["UNIT"].Value.ToString();
                cbColor.Text = dgvMain.Rows[e.RowIndex].Cells["COLOR"].Value.ToString();
                cbSize.Text = dgvMain.Rows[e.RowIndex].Cells["SIZE"].Value.ToString();
                cbMaterial.Text = dgvMain.Rows[e.RowIndex].Cells["MATERIAL"].Value.ToString();
                tbVatRate.Text = dgvMain.Rows[e.RowIndex].Cells["VATRATE"].Value.ToString();
                tbBuyPrice.Text = dgvMain.Rows[e.RowIndex].Cells["BUYINGPRICE"].Value.ToString();
                tbSalePrice.Text = dgvMain.Rows[e.RowIndex].Cells["SELLPRICE"].Value.ToString();
                tbSalePrice2.Text = dgvMain.Rows[e.RowIndex].Cells["SELLPRICE2"].Value.ToString();
                tbSalePrice3.Text = dgvMain.Rows[e.RowIndex].Cells["SELLPRICE3"].Value.ToString();
                tbStock.Text = dgvMain.Rows[e.RowIndex].Cells["STOCK"].Value.ToString();
                tbCriticalStock.Text = dgvMain.Rows[e.RowIndex].Cells["CRITICALSTOCK"].Value.ToString();
                cbSupplier.Text = dgvMain.Rows[e.RowIndex].Cells["SUPPLIER"].Value.ToString();
                pbProduct.BackgroundImage = string.IsNullOrWhiteSpace(dgvMain.Rows[e.RowIndex].Cells["B64IMAGE"].Value.ToString()) ? Properties.Resources._256pxNoImage : Base64ToImage(dgvMain.Rows[e.RowIndex].Cells["B64IMAGE"].Value.ToString());
                cbBranch.Text = cbListingBranch.SelectedText;
            }
        }
        private async void btnGiveNextBarcode_Click(object sender, EventArgs e)
        {
            if (tbBarcode.Enabled == false)
                return;
            tbBarcode.Text = DateTime.Now.ToString("yyMMddHHmmssfff").Substring(0, 13);
            tbBarcode.BackColor = Color.White;
            var setting = Setting.Get();
            await using var conn = new SqlConnection(setting.Sql.ConnectionString());
            conn.Open();
            var sqlBuilder = new SqlBuilder();
            sqlBuilder.Select("*");
            sqlBuilder.Where("BARCODE=@BARCODE");
            var buildTemp = sqlBuilder.AddTemplate("SELECT /**select**/ FROM PRODUCTS /**where**/");
            var param = new
            {
                BARCODE = tbBarcode.Text
            };
            var result = conn.QueryAsync(buildTemp.RawSql, param).Result;
            if (result.Any())
                btnGiveNextBarcode.PerformClick();
        }
        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            var forms = Application.OpenForms.Cast<Form>().Where(x => x.Name == "AddSupp");
            if (forms.Any())
            {
                MessageBox.Show("Bu pencere zaten açık!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                var addS = new AddSupplierInnerForm(true);
                addS.Name = "AddSupp";
                var dr = addS.ShowDialog();
                FillSupplierComboBox();
            }
        }
        public async void FillColorComboBox()
        {
            var settings = Setting.Get();
            var sb = new SqlBuilder();
            sb.Select("ID,NAME");
            var builderTemp = sb.AddTemplate("SELECT /**select**/ FROM COLORS");
            await using var conn = new SqlConnection(settings.Sql.ConnectionString());
            var result = await conn.QueryAsync(builderTemp.RawSql);
            if (result.Any())
            {
                var categoryList = (from x in result select new { ID = x.ID, NAME = x.NAME }).ToList();
                cbColor.DataSource = categoryList;
                cbColor.SelectedIndex = 0;
            }
        }
        private void btnAddColor_Click(object sender, EventArgs e)
        {
            var ac = new AddColor();
            DialogResult dr = ac.ShowDialog();
            FillColorComboBox();
        }
        public async void FillSizeComboBox()
        {
            var settings = Setting.Get();
            var sb = new SqlBuilder();
            sb.Select("ID,NAME");
            var builderTemp = sb.AddTemplate("SELECT /**select**/ FROM SIZES");
            await using var conn = new SqlConnection(settings.Sql.ConnectionString());
            var result = await conn.QueryAsync(builderTemp.RawSql);
            if (result.Any())
            {
                var categoryList = (from x in result select new { ID = x.ID, NAME = x.NAME }).ToList();
                cbSize.DataSource = categoryList;
                cbSize.SelectedIndex = 0;
            }
        }
        private void btnAddSize_Click(object sender, EventArgs e)
        {
            var addS = new AddSize();
            DialogResult dr = addS.ShowDialog();
            FillSizeComboBox();
        }
        public async void FillMaterialComboBox()
        {
            var settings = Setting.Get();
            var sb = new SqlBuilder();
            sb.Select("ID,NAME");
            var builderTemp = sb.AddTemplate("SELECT /**select**/ FROM MATERIALS");
            await using var conn = new SqlConnection(settings.Sql.ConnectionString());
            var result = await conn.QueryAsync(builderTemp.RawSql);
            if (result.Any())
            {
                var categoryList = (from x in result select new { ID = x.ID, NAME = x.NAME }).ToList();
                cbMaterial.DataSource = categoryList;
                cbMaterial.SelectedIndex = 0;
            }
        }
        public async void FillSupplierComboBox()
        {
            var settings = Setting.Get();
            var sb = new SqlBuilder();
            sb.Select("ID,NAME");
            var builderTemp = sb.AddTemplate("SELECT /**select**/ FROM SUPPLIERS");
            await using var conn = new SqlConnection(settings.Sql.ConnectionString());
            var result = await conn.QueryAsync(builderTemp.RawSql);
            if (result.Any())
            {
                var categoryList = (from x in result select new { ID = x.ID, NAME = x.NAME }).ToList();
                cbSupplier.DataSource = categoryList;
                cbSupplier.SelectedIndex = 0;
            }
        }
        private void btnAddMaterial_Click(object sender, EventArgs e)
        {
            var am = new AddMaterial();
            DialogResult dr = am.ShowDialog();
            FillMaterialComboBox();
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
                var categoryList = (from x in result select new { ID = x.ID, NAME = x.NAME }).ToList();
                cbBranch.DataSource = categoryList;
                cbBranch.SelectedIndex = 0;
                cbListingBranch.DataSource = categoryList;
                cbListingBranch.SelectedIndex = 0;
            }
        }
        private void btnAddBranch_Click(object sender, EventArgs e)
        {
            var ab = new AddBranch();
            DialogResult dr = ab.ShowDialog();
            FillBranchComboBox();
        }
        public string LastAddedImagePath = "";
        private void btnAddPicture_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
            if (ofd.ShowDialog() != DialogResult.OK)
                return;
            LastAddedImagePath = ofd.FileName;
            pbProduct.BackgroundImage = Image.FromFile(LastAddedImagePath);//Properties.Resources._256pxNoImage;
        }
        private void cbListingBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshMainDataGrid();
        }
        private void tmrNewProduct_Tick(object sender, EventArgs e)
        {
            dgvMain.Columns.Insert(dgvMain.Columns.Count, new DataGridViewImageColumn()
            {
                Image = Properties.Resources._24pxUpdate,
                Name = "UPDATE",
                HeaderText = "",
                FillWeight = 20,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
            dgvMain.Columns.Insert(dgvMain.Columns.Count, new DataGridViewImageColumn()
            {
                Image = Properties.Resources._24pxClose,
                Name = "DELETE",
                HeaderText = "",
                FillWeight = 20,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
            dgvMain.Columns["DELETE"].FillWeight = 20;
            dgvMain.Columns["UPDATE"].FillWeight = 20;
            dgvVariant.Columns.Insert(dgvVariant.Columns.Count, new DataGridViewImageColumn()
            {
                Image = Properties.Resources._24pxClose,
                Name = "VDELETE",
                HeaderText = "",
                FillWeight = 20,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
            dgvVariant.Columns["VDELETE"].FillWeight = 20;
            tmrNewProduct.Enabled = false;
        }
        private async void btnSaveVariants_Click(object sender, EventArgs e)
        {
            var setting = Setting.Get();
            await using var conn = new SqlConnection(setting.Sql.ConnectionString());
            conn.Open();
            foreach (DataGridViewRow row in dgvVariant.Rows)
            {
                var imagePath = ((from x in VariantImages where x.Barcode == row.Cells["VBARCODE"].Value.ToString() select x).First() ?? new VariantImage()).ImagePath;
                var sqlBuilder = new SqlBuilder();
                var builderTemp = sqlBuilder.AddTemplate("INSERT INTO PRODUCTS(CATEGORYID,SUPPLIERID,MATERIALID,SIZEID,UNITID,COLORID,BRANCHID,NAME,BARCODE,SALEPRICE,SALEPRICE2,SALEPRICE3,BUYPRICE,VATRATE,STOCK,CRITICALSTOCK,B64IMAGE,CREATEDBY,CREATEDATE) VALUES((SELECT TOP 1 ID FROM CATEGORIES WHERE NAME=@CATEGORYID),(SELECT TOP 1 ID FROM SUPPLIERS WHERE NAME=@SUPPLIERID),(SELECT TOP 1 ID FROM MATERIALS WHERE NAME=@MATERIALID),(SELECT TOP 1 ID FROM SIZES WHERE NAME=@SIZEID),(SELECT TOP 1 ID FROM UNITS WHERE NAME=@UNITID),(SELECT TOP 1 ID FROM COLORS WHERE NAME=@COLORID),(SELECT TOP 1 ID FROM BRANCHES WHERE NAME=@BRANCHID),@NAME,@BARCODE,@SALEPRICE,@SALEPRICE2,@SALEPRICE3,@BUYPRICE,@VATRATE,@STOCK,@CRITICALSTOCK,@B64IMAGE,@CREATEDBY,GETDATE())");
                var param = new
                {
                    CATEGORYID = row.Cells["VCATEGORY"].Value.ToString(),
                    SUPPLIERID = row.Cells["VSUPPLIER"].Value.ToString(),
                    MATERIALID = row.Cells["VMATERIAL"].Value.ToString(),
                    SIZEID = row.Cells["VSIZE"].Value.ToString(),
                    UNITID = row.Cells["VUNIT"].Value.ToString(),
                    COLORID = row.Cells["VCOLOR"].Value.ToString(),
                    BRANCHID = row.Cells["VBRANCH"].Value.ToString(),
                    NAME = row.Cells["VNAME"].Value.ToString(),
                    BARCODE = row.Cells["VBARCODE"].Value.ToString(),
                    SALEPRICE = Convert.ToDecimal(row.Cells["VSELLPRICE"].Value.ToString(), new CultureInfo("en-GB")),
                    SALEPRICE2 = Convert.ToDecimal(row.Cells["VSELLPRICE2"].Value.ToString(), new CultureInfo("en-GB")),
                    SALEPRICE3 = Convert.ToDecimal(row.Cells["VSELLPRICE3"].Value.ToString(), new CultureInfo("en-GB")),
                    BUYPRICE = Convert.ToDecimal(row.Cells["VBUYPRICE"].Value.ToString(), new CultureInfo("en-GB")),
                    VATRATE = Convert.ToDecimal(row.Cells["VVATRATE"].Value.ToString(), new CultureInfo("en-GB")),
                    STOCK = Convert.ToDecimal(row.Cells["VSTOCK"].Value.ToString(), new CultureInfo("en-GB")),
                    CRITICALSTOCK = Convert.ToDecimal(row.Cells["VCRITICALSTOCK"].Value.ToString(), new CultureInfo("en-GB")),
                    B64IMAGE = string.IsNullOrWhiteSpace(imagePath) ? "" : ConvertImageToBase64(Image.FromFile(imagePath)),
                    CREATEDBY = setting.LastSuccesfullyLoggedUser
                };
                var result = await conn.ExecuteAsync(builderTemp.RawSql, param);
            }
            ClearAfterAddingToDB();
        }
        private void rtbSearch__TextChanged(object sender, EventArgs e)
        {
            (dgvMain.DataSource as DataTable).DefaultView.RowFilter = $"NAME LIKE '{rtbSearch.Texts}%' OR BARCODE LIKE '{rtbSearch.Texts}%'";
        }
        private async void btnCheckBarcode_Click(object sender, EventArgs e)
        {
            if (tbBarcode.Text.Length > 0)
            {
                var setting = Setting.Get();
                await using var conn = new SqlConnection(setting.Sql.ConnectionString());
                conn.Open();
                var sqlBuilder = new SqlBuilder();
                sqlBuilder.Select("*");
                sqlBuilder.Where("BARCODE=@BARCODE");
                var buildTemp = sqlBuilder.AddTemplate("SELECT /**select**/ FROM PRODUCTS /**where**/");
                var param = new
                {
                    BARCODE = tbBarcode.Text
                };
                var result = conn.QueryAsync(buildTemp.RawSql, param).Result;
                if (result.Any())
                    tbBarcode.BackColor = Color.Tomato;
                else
                    tbBarcode.BackColor = Color.LightGreen;
            }
        }
        private async void rtbSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (rtbSearch.Texts.Length == 0)
                    return;
                dgvMain.EndEdit();
                var settings = Setting.Get();
                var qry = $"""
                WITH TABLO AS(SELECT TOP 200 PROD.ID,PROD.BARCODE,PROD.NAME,PROD.SALEPRICE AS SELLPRICE,PROD.SALEPRICE2 AS SELLPRICE2,
                PROD.SALEPRICE3 AS SELLPRICE3,
                PROD.CRITICALSTOCK,PROD.VATRATE,CAT.NAME AS CATEGORY,COL.NAME AS COLOR,
                UN.NAME AS UNIT,MAT.NAME AS  MATERIAL,SUP.NAME AS SUPPLIER,S.NAME AS SIZE, PROD.B64IMAGE
                FROM PRODUCTS AS PROD LEFT JOIN 
                CATEGORIES AS CAT ON CAT.ID=PROD.CATEGORYID LEFT JOIN
                COLORS AS COL ON COL.ID = PROD.COLORID LEFT JOIN 
                UNITS AS UN ON UN.ID = PROD.UNITID LEFT JOIN 
                MATERIALS AS MAT ON MAT.ID = PROD.MATERIALID LEFT JOIN 
                SUPPLIERS AS SUP ON SUP.ID = PROD.SUPPLIERID LEFT JOIN 
                SIZES AS S ON S.ID = PROD.SIZEID WHERE PROD.BRANCHID={Convert.ToInt32(cbListingBranch.SelectedValue.ToString())} AND (PROD.BARCODE='{rtbSearch.Texts}' OR PROD.NAME LIKE '%{rtbSearch.Texts}%'))
                SELECT T.*,(SELECT SUM(STOCK) FROM STOCKS AS ST WHERE ST.PRODID = T.ID) AS STOCK ,
                (SELECT TOP 1 ST.BUYPRICE FROM STOCKS AS ST WHERE ST.PRODID = T.ID ORDER BY ST.CREATEDATE DESC) AS BUYINGPRICE
                FROM TABLO AS T ORDER BY T.ID
                """; ;
                await using var conn = new SqlConnection(settings.Sql.ConnectionString());
                conn.Open();
                var ar = new SqlDataAdapter(qry, conn);
                var dt = new DataTable();
                ar.Fill(dt);
                dgvMain.DataSource = dt;
                dgvMain.ClearSelection();
            }
        }
        private void btnAddDetail_Click(object sender, EventArgs e)
        {
            var forms = Application.OpenForms.Cast<Form>().Where(x => x.Name == "Detay giriş");
            if (forms.Any())
            {
                MessageBox.Show("Bu pencere zaten açık!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var sp = new AddDetails();
            sp.Name = "Detay giriş";
            sp.Show();
        }
    }
}
