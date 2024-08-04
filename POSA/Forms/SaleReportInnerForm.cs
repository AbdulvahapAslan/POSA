using Dapper;
using POSA.Helpers.Settings;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using static Dapper.SqlMapper;
namespace POSA.Forms
{
    public partial class SaleReportInnerForm : Form
    {
        public SaleReportInnerForm()
        {
            InitializeComponent();
        }
        private void SaleReportInnerForm_Load(object sender, EventArgs e)
        {
            cbCategory.DisplayMember = "NAME";
            cbCategory.ValueMember = "ID";
            FillCategoryComboBox();
            fcFilter.SelectedIndex = 0;
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
        public async void RefreshMainDataGrid()
        {
            dgvMain.EndEdit();
            var settings = Setting.Get();
            var qry = $"""
                WITH T AS (SELECT FC.BARCODE,ISNULL(SUM(FC.QUANTITY),0) AS TOTALSALEQ FROM FICHELINES AS FC GROUP BY FC.BARCODE)
                SELECT T.BARCODE,ISNULL(P.NAME,'BORÇ') AS PRODUCT, FL.CREATEDATE AS 'DATE',(ISNULL(FL.QUANTITY,0)) AS QUANTITY,CAST((ISNULL(FL.UNITPRICE,1)-(ISNULL(FL.PROFIT,1)/(ISNULL(FL.QUANTITY,1)))) AS numeric (18,2)) AS BUYPRICE,
                (ISNULL(FL.UNITPRICE,0)) AS SALEPRICE,FL.TOTALPRICE,(ISNULL(FL.PROFIT,0)) AS PROFIT,F.PAYMENTTYPE,ISNULL(C.NAME,'Kayıtsız Müşteri') AS CUSTOMER,
                FL.CREATEDBY AS WORKER,F.FICHETYPE,T.TOTALSALEQ FROM T INNER JOIN
                FICHELINES AS FL ON FL.BARCODE = T.BARCODE LEFT JOIN 
                FICHES AS F ON FL.FICHEREF = F.FICHEREF LEFT JOIN
                CUSTOMERS AS C ON C.ID = F.CUSTOMERID LEFT JOIN
                PRODUCTS AS P ON P.BARCODE = FL.BARCODE
                WHERE FL.CREATEDATE BETWEEN @STARTDATE AND @ENDDATE
                """;
            if (!string.IsNullOrWhiteSpace(fcPaymentType.Text) || !string.IsNullOrWhiteSpace(cbCategory.Text) || !string.IsNullOrWhiteSpace(tbProduct.Text))
            {
                if (!string.IsNullOrWhiteSpace(fcPaymentType.Text))
                {
                    qry += $" AND F.PAYMENTTYPE = '{fcPaymentType.Text}'";
                }
                if (!string.IsNullOrWhiteSpace(cbCategory.Text))
                {
                    qry += $" AND P.CATEGORYID = {Convert.ToInt32(cbCategory.SelectedValue.ToString())}";
                }
                if (!string.IsNullOrWhiteSpace(tbProduct.Text))
                {
                    qry += $" AND (FL.BARCODE = '{tbProduct.Text}' OR P.NAME LIKE '%{tbProduct.Text}%')";
                }
            }
            if (rbSell.Checked)
            {
                qry += $" AND F.FICHETYPE = 4";
            }
            else if (rbRefund.Checked)
            {
                qry += $" AND F.FICHETYPE = 1";
            }
            else if (rbBuy.Checked)
            {
                qry += $" AND F.FICHETYPE = 5";
            }
            else if (rbPayLater.Checked)
            {
                qry += $" AND F.FICHETYPE = 2";
            }
            else if (rbGift.Checked)
            {
                qry += $" AND F.FICHETYPE = 6";
            }
            var param = new
            {
                STARTDATE = dtpBegin.Value,
                ENDDATE = dtpEnd.Value
            };
            if (fcFilter.Text == "YOK")
            {
                qry += " ORDER BY DATE ASC";
            }
            else if (fcFilter.Text == "ÇOK SATANLAR")
            {
                qry += " ORDER BY TOTALSALEQ DESC";
            }
            else if (fcFilter.Text == "ÇOK BULUNAN")
            {
                qry = qry.Replace("WITH T AS (SELECT FC.BARCODE,ISNULL(SUM(FC.QUANTITY),0) AS TOTALSALEQ FROM FICHELINES AS FC GROUP BY FC.BARCODE)", "WITH T AS (SELECT PRD.BARCODE,SUM(STK.STOCK) AS TOTALSALEQ FROM STOCKS AS STK LEFT JOIN PRODUCTS AS PRD ON PRD.ID = STK.PRODID GROUP BY PRD.BARCODE)");
                qry += " ORDER BY TOTALSALEQ DESC";
            }
            else if (fcFilter.Text == "FİYAT (ARTAN)")
            {
                qry += " ORDER BY SALEPRICE ASC";
            }
            else if (fcFilter.Text == "FİYAT (AZALAN)")
            {
                qry += " ORDER BY SALEPRICE DESC";
            }
            else if (fcFilter.Text == "BARKOD (ARTAN)")
            {
                qry += " ORDER BY BARCODE ASC";
            }
            else if (fcFilter.Text == "BARKOD (AZALAN)")
            {
                qry += " ORDER BY BARCODE DESC";
            }
            else if (fcFilter.Text == "İSİM (A - Z)")
            {
                qry += " ORDER BY PRODUCT ASC";
            }
            else if (fcFilter.Text == "İSİM (Z - A)")
            {
                qry += " ORDER BY PRODUCT DESC";
            }
            await using var conn = new SqlConnection(settings.Sql.ConnectionString());
            conn.Open();
            var ar = new SqlDataAdapter(qry, conn);
            ar.SelectCommand.Parameters.Add("@STARTDATE", SqlDbType.DateTime, 2000).Value = dtpBegin.Value;
            ar.SelectCommand.Parameters.Add("@ENDDATE", SqlDbType.DateTime, 2000).Value = dtpEnd.Value;
            var dt = new DataTable();
            ar.Fill(dt);
            dgvMain.DataSource = dt;
            dgvMain.ClearSelection();
            await Calculate();
        }
        public async Task<bool> Calculate()
        {
            decimal Cash = 0, Card = 0, Other = 0;
            decimal CashProfit = 0, CardProfit = 0, OtherProfit = 0;
            decimal payLater = 0, free = 0, cashRefund = 0, cardRefund = 0;
            decimal cashRefundProfit = 0, cardRefundProfit = 0;
            foreach (DataGridViewRow row in dgvMain.Rows)
            {
                if (row.Cells["PAYMENTTYPE"].Value.ToString() == "NAKİT" && row.Cells["PRODUCT"].Value.ToString() != "BORÇ")
                {
                    Cash += Convert.ToDecimal(row.Cells["TOTALPRICE"].Value.ToString(), new CultureInfo("tr-TR"));
                    CashProfit += Convert.ToDecimal(row.Cells["PROFIT"].Value.ToString(), new CultureInfo("tr-TR"));
                }
                if (row.Cells["PAYMENTTYPE"].Value.ToString() == "KART" && row.Cells["PRODUCT"].Value.ToString() != "BORÇ")
                {
                    Card += Convert.ToDecimal(row.Cells["TOTALPRICE"].Value.ToString(), new CultureInfo("tr-TR"));
                    CardProfit += Convert.ToDecimal(row.Cells["PROFIT"].Value.ToString(), new CultureInfo("tr-TR"));
                }
                if (row.Cells["PAYMENTTYPE"].Value.ToString() == "DİĞER" && row.Cells["PRODUCT"].Value.ToString() != "BORÇ")
                {
                    Other += Convert.ToDecimal(row.Cells["TOTALPRICE"].Value.ToString(), new CultureInfo("tr-TR"));
                    OtherProfit += Convert.ToDecimal(row.Cells["PROFIT"].Value.ToString(), new CultureInfo("tr-TR"));
                }
                if (row.Cells["FICHETYPE"].Value.ToString() == "2" && !(row.Cells["TOTALPRICE"].Value.ToString().Contains("-")))
                {
                    Other += Convert.ToDecimal(row.Cells["TOTALPRICE"].Value.ToString(), new CultureInfo("tr-TR"));
                }
                if (row.Cells["FICHETYPE"].Value.ToString() == "6")
                {
                    free += Convert.ToDecimal(row.Cells["TOTALPRICE"].Value.ToString(), new CultureInfo("tr-TR"));
                }
                if (row.Cells["FICHETYPE"].Value.ToString() == "1" && row.Cells["PAYMENTTYPE"].Value.ToString() == "NAKİT")
                {
                    cashRefund += Convert.ToDecimal(row.Cells["TOTALPRICE"].Value.ToString(), new CultureInfo("tr-TR"));
                    cashRefundProfit += Convert.ToDecimal(row.Cells["PROFIT"].Value.ToString(), new CultureInfo("tr-TR"));
                }
                if (row.Cells["FICHETYPE"].Value.ToString() == "1" && row.Cells["PAYMENTTYPE"].Value.ToString() == "KART")
                {
                    cardRefund += Convert.ToDecimal(row.Cells["TOTALPRICE"].Value.ToString(), new CultureInfo("tr-TR"));
                    cardRefundProfit += Convert.ToDecimal(row.Cells["PROFIT"].Value.ToString(), new CultureInfo("tr-TR"));
                }
            }
            tbCashSale.Text = Cash.ToString("C", new CultureInfo("tr-TR"));
            tbCardSale.Text = Card.ToString("C", new CultureInfo("tr-TR"));
            tbOtherSale.Text = Other.ToString("C", new CultureInfo("tr-TR"));
            tbCashAndCard.Text = (Cash + Card).ToString("C", new CultureInfo("tr-TR"));
            tbPayLater.Text = payLater.ToString("C", new CultureInfo("tr-TR"));
            tbFree.Text = free.ToString("C", new CultureInfo("tr-TR"));
            tbRefundCard.Text = cardRefund.ToString("C", new CultureInfo("tr-TR"));
            tbRefundCash.Text = cashRefund.ToString("C", new CultureInfo("tr-TR"));
            tbRefundTotal.Text = (cardRefund + cashRefund).ToString("C", new CultureInfo("tr-TR"));
            tbTotalSales.Text = ((Cash + Card + Other) - (cardRefund + cashRefund)).ToString("C", new CultureInfo("tr-TR"));
            tbTotalProfit.Text = ((CashProfit + CardProfit + OtherProfit) - (cardRefundProfit + cashRefundProfit)).ToString("C", new CultureInfo("tr-TR"));
            return true;
        }
        private void btnBring_Click(object sender, EventArgs e)
        {
            RefreshMainDataGrid();
        }

        private void fcFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshMainDataGrid();
        }
    }
}
