using Dapper;
using POSA.Helpers.Settings;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
namespace POSA.Forms
{
    public partial class AddStocksInnerForm : Form
    {
        public AddStocksInnerForm()
        {
            InitializeComponent();
            System.Threading.Thread.CurrentThread.CurrentUICulture = new CultureInfo("en_GB");
        }
        private void pbClearSearch_Click(object sender, EventArgs e)
        {
            rtbSearch.Texts = "";
        }
        public async void FillSupplierComboBox()
        {
            var settings = Setting.Get();
            var sb = new SqlBuilder();
            sb.Select("ID,NAME");
            SqlBuilder.Template builderTemp;
            builderTemp = sb.AddTemplate("SELECT /**select**/ FROM SUPPLIERS");
            await using var conn = new SqlConnection(settings.Sql.ConnectionString());
            IEnumerable<dynamic>? result;
            result = await conn.QueryAsync(builderTemp.RawSql);
            if (result.Any())
            {
                var categoryList = (from x in result select x.NAME).ToList();
                fcSupplier.DataSource = categoryList;
                fcSupplier.SelectedIndex = 0;
            }
        }
        private void AddCustomerReportForm_Load(object sender, EventArgs e)
        {
            fcPriceType.SelectedIndex = 0;
            FillSupplierComboBox();
        }
        private void ClearScreen()
        {
            fcPriceType.SelectedIndex = 0;
            tbQuantity.Text = "0";
            lblBarcode.Text = "";
            lblStock.Text = "";
            lblProdName.Text = "";
            lblBuy.Text = "";
            lblSell.Text = "";
            tbSell.Text = "0";
            tbBuy.Text = "0";
            rtbSearch.Texts = "";
        }
        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(string.IsNullOrWhiteSpace(tbBuy.Text) ? 0 : tbBuy.Text, new CultureInfo("en-GB")) > 0 && Convert.ToDecimal(string.IsNullOrWhiteSpace(tbSell.Text) ? 0 : tbSell.Text, new CultureInfo("en-GB")) > 0)
            {
                var setting = Setting.Get();
                await using var conn = new SqlConnection(setting.Sql.ConnectionString());
                conn.Open();
                var sqlBuilder = new SqlBuilder();
                var builderTemp = sqlBuilder.AddTemplate(
                    $"""
                         INSERT INTO STOCKS(PRODID,STOCK,BUYPRICE,CREATEDATE,CREATEDBY,SUPPLIERID) VALUES((SELECT TOP 1 ID FROM PRODUCTS WITH (NOLOCK) WHERE BARCODE = @BARCODE),@STOCK,@BUYPRICE,GETDATE(),@CREATEDBY,(SELECT TOP 1 ID FROM SUPPLIERS WHERE NAME = @SUPPLIER))
                     """);
                var param = new
                {
                    BARCODE = lblBarcode.Text,
                    BUYPRICE = tbBuy.Text,
                    CREATEDBY = setting.LastSuccesfullyLoggedUser,
                    STOCK = tbQuantity.Text,
                    SUPPLIER = fcSupplier.Text
                };
                var result = await conn.ExecuteAsync(builderTemp.RawSql, param);
                if (result > 0)
                {
                    sqlBuilder = new SqlBuilder();
                    builderTemp = sqlBuilder.AddTemplate(
                        $"""
                            UPDATE PRODUCTS SET SALEPRICE{((fcPriceType.Text ?? "1") == "1" ? "" : fcPriceType.Text)} = @PRICE WHERE ID = (SELECT TOP 1 ID FROM PRODUCTS WITH (NOLOCK) WHERE BARCODE = @BARCODE)
                        """);
                    var param2 = new
                    {
                        BARCODE = lblBarcode.Text,
                        PRICE = tbSell.Text
                    };
                    result = await conn.ExecuteAsync(builderTemp.RawSql, param2);
                }
                conn.Close();
                ClearScreen();
            }
        }
        public async void BringProduct(string barcode)
        {
            var settings = Setting.Get();
            var qry = $"""
                                WITH TABLO AS(SELECT TOP 500 ID,BARCODE,NAME,VATRATE,SALEPRICE{((fcPriceType.Text ?? "1") == "1" ? "" : fcPriceType.Text)} AS SALEPRICE,UNITID FROM PRODUCTS WHERE BARCODE='{rtbSearch.Texts}')
                                SELECT T.*,ISNULL((SELECT SUM(STOCK) FROM STOCKS WHERE PRODID = T.ID),0) AS STOCK, 
                                ISNULL((SELECT TOP 1 BUYPRICE FROM STOCKS WHERE PRODID = T.ID ORDER BY BUYPRICE DESC),0) AS BUYPRICE,
                                ISNULL((SELECT TOP 1 U.NAME FROM UNITS AS U WHERE ID = T.UNITID),'ADET') AS UNIT
                                FROM TABLO AS T ORDER BY T.ID
                                """;
            await using var conn = new SqlConnection(settings.Sql.ConnectionString());
            conn.Open();
            var ar = new SqlDataAdapter(qry, conn);
            var dt = new DataTable();
            ar.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                decimal stock = 0;
                foreach (DataRow row in dt.Rows)
                {
                    stock += Convert.ToDecimal(row["STOCK"].ToString());
                }
                lblStock.Text = stock.ToString();
                lblBarcode.Text = barcode;
                lblBuy.Text = dt.Rows[dt.Rows.Count - 1]["BUYPRICE"].ToString();
                lblSell.Text = dt.Rows[0]["SALEPRICE"].ToString();
                lblProdName.Text = dt.Rows[0]["NAME"].ToString();
            }
        }
        private void rtbSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (rtbSearch.Texts.Length > 0 && e.KeyCode == Keys.Enter)
            {
                BringProduct(rtbSearch.Texts);
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            tbQuantity.Text = (Convert.ToDecimal(string.IsNullOrWhiteSpace(tbQuantity.Text) ? 0 : tbQuantity.Text) + 1).ToString();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if ((Convert.ToDecimal(string.IsNullOrWhiteSpace(tbQuantity.Text) ? 0 : tbQuantity.Text) - 1) > 0)
            {
                tbQuantity.Text = (Convert.ToDecimal(string.IsNullOrWhiteSpace(tbQuantity.Text) ? 0 : tbQuantity.Text) - 1).ToString();
            }
        }
        private void tbQuantity_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearScreen();
        }
    }
}
