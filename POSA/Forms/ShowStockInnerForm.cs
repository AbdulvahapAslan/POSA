using Dapper;
using POSA.Helpers.Settings;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Security.Cryptography;
using static Dapper.SqlMapper;
namespace POSA.Forms
{
    public partial class ShowStockInnerForm : Form
    {
        public ShowStockInnerForm()
        { 
            InitializeComponent();
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en_GB");
        }
        private void pbClearSearch_Click(object sender, EventArgs e)
        {
            rtbSearch.Texts = "";
            RefreshMainDataGrid();
        }
        private async void AddCustomerReportForm_Load(object sender, EventArgs e)
        {
            await FillCategories();
            fcFilter.SelectedIndex = 0;
            fcPriceType.SelectedIndex = 0;
            fcCategories.SelectedIndex = 0;
            RefreshMainDataGrid();
            dgvMain.ClearSelection();
        }
        private class Cat
        {
            public int ID { get; set; }
            public string NAME { get; set; }
        }
        List<Cat> cats = new List<Cat>();
        public async Task<bool> FillCategories()
        {
            var settings = Setting.Get();
            var sb = new SqlBuilder();
            sb.Select("ID,NAME");
            var builderTemp = sb.AddTemplate("SELECT /**select**/ FROM CATEGORIES WHERE ID <> 1");
            await using var conn = new SqlConnection(settings.Sql.ConnectionString());
            var result = await conn.QueryAsync(builderTemp.RawSql);
            if (result.Any())
            {
                cats = (from x in result select new Cat { ID = x.ID, NAME = x.NAME }).ToList();
                cats.Add(new Cat { ID = cats[0].ID, NAME = cats[0].NAME });
                cats[0].ID = 0;
                cats[0].NAME = "TÜMÜ";
                fcCategories.DataSource = (from x in cats select x.NAME).ToList();
                return true;
            }
            return false;
        }
        public int LastAddDepthRowIndex = 0;
        public async void RefreshMainDataGrid()
        {
            dgvMain.EndEdit();
            var settings = Setting.Get();
            var qry = "";
            var filter = fcFilter.Text;
            if (fcCategories.Text == "TÜMÜ")
            {

                switch (filter)
                {
                    case "YOK":
                        qry = $"""
                                WITH TABLO AS(SELECT TOP 500 ID,BARCODE,NAME,VATRATE,SALEPRICE{((fcPriceType.Text ?? "1") == "1" ? "" : fcPriceType.Text)} AS SALEPRICE,UNITID FROM PRODUCTS)
                                SELECT T.*,ISNULL((SELECT SUM(STOCK) FROM STOCKS WHERE PRODID = T.ID),0) AS STOCK, 
                                ISNULL((SELECT TOP 1 BUYPRICE FROM STOCKS WHERE PRODID = T.ID ORDER BY BUYPRICE DESC),0) AS BUYPRICE,
                                ISNULL((SELECT TOP 1 U.NAME FROM UNITS AS U WHERE ID = T.UNITID),'ADET') AS UNIT
                                FROM TABLO AS T ORDER BY T.ID
                                """;
                        break;
                    case "ÇOK SATANLAR":
                        qry = $"""
                                WITH TABLO AS(SELECT TOP 500 ID,BARCODE,NAME,VATRATE,SALEPRICE{(fcPriceType.Text == "1" ? "" : fcPriceType.Text)} AS SALEPRICE,UNITID FROM PRODUCTS 
                                WHERE BARCODE IN (SELECT TOP 500 FC.BARCODE FROM FICHELINES AS FC WHERE BARCODE <> '0' 
                                GROUP BY FC.BARCODE ORDER BY SUM(FC.QUANTITY) DESC))
                                SELECT T.*,ISNULL((SELECT SUM(STOCK) FROM STOCKS WHERE PRODID = T.ID),0) AS STOCK, 
                                ISNULL((SELECT TOP 1 BUYPRICE FROM STOCKS WHERE PRODID = T.ID ORDER BY BUYPRICE DESC),0) AS BUYPRICE,
                                ISNULL((SELECT TOP 1 U.NAME FROM UNITS AS U WHERE ID = T.UNITID),'ADET') AS UNIT
                                FROM TABLO AS T ORDER BY T.ID
                                """;
                        break;
                    case "ÇOK BULUNAN":
                        qry = $"""
                                WITH TABLO AS(SELECT TOP 500 ID,BARCODE,NAME,VATRATE,SALEPRICE{(fcPriceType.Text == "1" ? "" : fcPriceType.Text)} AS SALEPRICE,UNITID FROM PRODUCTS 
                                WHERE ID IN (SELECT TOP 500 S.PRODID FROM STOCKS AS S GROUP BY S.PRODID ORDER BY SUM(S.STOCK) DESC) )
                                SELECT T.*,ISNULL((SELECT SUM(STOCK) FROM STOCKS WHERE PRODID = T.ID),0) AS STOCK, 
                                ISNULL((SELECT TOP 1 BUYPRICE FROM STOCKS WHERE PRODID = T.ID ORDER BY BUYPRICE DESC),0) AS BUYPRICE,
                                ISNULL((SELECT TOP 1 U.NAME FROM UNITS AS U WHERE ID = T.UNITID),'ADET') AS UNIT
                                FROM TABLO AS T ORDER BY STOCK DESC
                                """;
                        break;
                    case "FİYAT (ARTAN)":
                        qry = $"""
                                WITH TABLO AS(SELECT TOP 500 ID,BARCODE,NAME,VATRATE,SALEPRICE{(fcPriceType.Text == "1" ? "" : fcPriceType.Text)} AS SALEPRICE,UNITID FROM PRODUCTS ORDER BY SALEPRICE ASC)
                                SELECT T.*,ISNULL((SELECT SUM(STOCK) FROM STOCKS WHERE PRODID = T.ID),0) AS STOCK, 
                                ISNULL((SELECT TOP 1 BUYPRICE FROM STOCKS WHERE PRODID = T.ID ORDER BY BUYPRICE DESC),0) AS BUYPRICE,
                                ISNULL((SELECT TOP 1 U.NAME FROM UNITS AS U WHERE ID = T.UNITID),'ADET') AS UNIT
                                FROM TABLO AS T ORDER BY SALEPRICE
                                """;
                        break;
                    case "FİYAT (AZALAN)":
                        qry = $"""
                                WITH TABLO AS(SELECT TOP 500 ID,BARCODE,NAME,VATRATE,SALEPRICE{(fcPriceType.Text == "1" ? "" : fcPriceType.Text)} AS SALEPRICE,UNITID FROM PRODUCTS ORDER BY SALEPRICE DESC)
                                SELECT T.*,ISNULL((SELECT SUM(STOCK) FROM STOCKS WHERE PRODID = T.ID),0) AS STOCK, 
                                ISNULL((SELECT TOP 1 BUYPRICE FROM STOCKS WHERE PRODID = T.ID ORDER BY BUYPRICE DESC),0) AS BUYPRICE,
                                ISNULL((SELECT TOP 1 U.NAME FROM UNITS AS U WHERE ID = T.UNITID),'ADET') AS UNIT
                                FROM TABLO AS T ORDER BY SALEPRICE DESC
                                """;
                        break;
                    case "BARKOD (ARTAN)":
                        qry = $"""
                                WITH TABLO AS(SELECT TOP 500 ID,BARCODE,NAME,VATRATE,SALEPRICE{(fcPriceType.Text == "1" ? "" : fcPriceType.Text)} AS SALEPRICE,UNITID FROM PRODUCTS ORDER BY BARCODE ASC)
                                SELECT T.*,ISNULL((SELECT SUM(STOCK) FROM STOCKS WHERE PRODID = T.ID),0) AS STOCK, 
                                ISNULL((SELECT TOP 1 BUYPRICE FROM STOCKS WHERE PRODID = T.ID ORDER BY BUYPRICE DESC),0) AS BUYPRICE,
                                ISNULL((SELECT TOP 1 U.NAME FROM UNITS AS U WHERE ID = T.UNITID),'ADET') AS UNIT
                                FROM TABLO AS T ORDER BY BARCODE ASC
                                """;
                        break;
                    case "BARKOD (AZALAN)":
                        qry = $"""
                                WITH TABLO AS(SELECT TOP 500 ID,BARCODE,NAME,VATRATE,SALEPRICE{(fcPriceType.Text == "1" ? "" : fcPriceType.Text)} AS SALEPRICE,UNITID FROM PRODUCTS ORDER BY BARCODE DESC)
                                SELECT T.*,ISNULL((SELECT SUM(STOCK) FROM STOCKS WHERE PRODID = T.ID),0) AS STOCK, 
                                ISNULL((SELECT TOP 1 BUYPRICE FROM STOCKS WHERE PRODID = T.ID ORDER BY BUYPRICE DESC),0) AS BUYPRICE,
                                ISNULL((SELECT TOP 1 U.NAME FROM UNITS AS U WHERE ID = T.UNITID),'ADET') AS UNIT
                                FROM TABLO AS T ORDER BY BARCODE DESC
                                """;
                        break;
                    case "İSİM (A - Z)":
                        qry = $"""
                                WITH TABLO AS(SELECT TOP 500 ID,BARCODE,NAME,VATRATE,SALEPRICE{(fcPriceType.Text == "1" ? "" : fcPriceType.Text)} AS SALEPRICE,UNITID FROM PRODUCTS ORDER BY NAME ASC)
                                SELECT T.*,ISNULL((SELECT SUM(STOCK) FROM STOCKS WHERE PRODID = T.ID),0) AS STOCK, 
                                ISNULL((SELECT TOP 1 BUYPRICE FROM STOCKS WHERE PRODID = T.ID ORDER BY BUYPRICE DESC),0) AS BUYPRICE,
                                ISNULL((SELECT TOP 1 U.NAME FROM UNITS AS U WHERE ID = T.UNITID),'ADET') AS UNIT
                                FROM TABLO AS T ORDER BY NAME ASC
                                """;
                        break;
                    case "İSİM (Z - A)":
                        qry = $"""
                                WITH TABLO AS(SELECT TOP 500 ID,BARCODE,NAME,VATRATE,SALEPRICE{(fcPriceType.Text == "1" ? "" : fcPriceType.Text)} AS SALEPRICE,UNITID FROM PRODUCTS ORDER BY NAME DESC)
                                SELECT T.*,ISNULL((SELECT SUM(STOCK) FROM STOCKS WHERE PRODID = T.ID),0) AS STOCK, 
                                ISNULL((SELECT TOP 1 BUYPRICE FROM STOCKS WHERE PRODID = T.ID ORDER BY BUYPRICE DESC),0) AS BUYPRICE,
                                ISNULL((SELECT TOP 1 U.NAME FROM UNITS AS U WHERE ID = T.UNITID),'ADET') AS UNIT
                                FROM TABLO AS T ORDER BY NAME DESC
                                """;
                        break;
                    default:
                        break;
                }
            }
            else
            {
                switch (filter)
                {
                    case "YOK":
                        qry = $"""
                                WITH TABLO AS(SELECT TOP 500 ID,BARCODE,NAME,VATRATE,SALEPRICE{(fcPriceType.Text == "1" ? "" : fcPriceType.Text)} AS SALEPRICE,UNITID FROM PRODUCTS WHERE CATEGORYID = {(from x in cats where x.NAME == fcCategories.Text select x.ID).First()})
                                SELECT T.*,ISNULL((SELECT SUM(STOCK) FROM STOCKS WHERE PRODID = T.ID),0) AS STOCK, 
                                ISNULL((SELECT TOP 1 BUYPRICE FROM STOCKS WHERE PRODID = T.ID ORDER BY BUYPRICE DESC),0) AS BUYPRICE,
                                ISNULL((SELECT TOP 1 U.NAME FROM UNITS AS U WHERE ID = T.UNITID),'ADET') AS UNIT
                                FROM TABLO AS T ORDER BY T.ID
                                """;
                        break;
                    case "ÇOK SATANLAR":
                        qry = $"""
                                WITH TABLO AS(SELECT TOP 500 ID,BARCODE,NAME,VATRATE,SALEPRICE{(fcPriceType.Text == "1" ? "" : fcPriceType.Text)} AS SALEPRICE,UNITID FROM PRODUCTS 
                                WHERE BARCODE IN (SELECT TOP 500 FC.BARCODE FROM FICHELINES AS FC WHERE BARCODE <> '0' AND CATEGORYID = {(from x in cats where x.NAME == fcCategories.Text select x.ID).First()}
                                GROUP BY FC.BARCODE ORDER BY SUM(FC.QUANTITY) DESC))
                                SELECT T.*,ISNULL((SELECT SUM(STOCK) FROM STOCKS WHERE PRODID = T.ID),0) AS STOCK, 
                                ISNULL((SELECT TOP 1 BUYPRICE FROM STOCKS WHERE PRODID = T.ID ORDER BY BUYPRICE DESC),0) AS BUYPRICE,
                                ISNULL((SELECT TOP 1 U.NAME FROM UNITS AS U WHERE ID = T.UNITID),'ADET') AS UNIT
                                FROM TABLO AS T ORDER BY T.ID
                                """;
                        break;
                    case "ÇOK BULUNAN":
                        qry = $"""
                                WITH TABLO AS(SELECT TOP 500 ID,BARCODE,NAME,VATRATE,SALEPRICE{(fcPriceType.Text == "1" ? "" : fcPriceType.Text)} AS SALEPRICE,UNITID FROM PRODUCTS 
                                WHERE ID IN (SELECT TOP 500 S.PRODID FROM STOCKS AS S GROUP BY S.PRODID ORDER BY SUM(S.STOCK) DESC) AND CATEGORYID = {(from x in cats where x.NAME == fcCategories.Text select x.ID).First()})
                                SELECT T.*,ISNULL((SELECT SUM(STOCK) FROM STOCKS WHERE PRODID = T.ID),0) AS STOCK, 
                                ISNULL((SELECT TOP 1 BUYPRICE FROM STOCKS WHERE PRODID = T.ID ORDER BY BUYPRICE DESC),0) AS BUYPRICE,
                                ISNULL((SELECT TOP 1 U.NAME FROM UNITS AS U WHERE ID = T.UNITID),'ADET') AS UNIT
                                FROM TABLO AS T ORDER BY STOCK DESC
                                """;
                        break;
                    case "FİYAT (ARTAN)":
                        qry = $"""
                                WITH TABLO AS(SELECT TOP 500 ID,BARCODE,NAME,VATRATE,SALEPRICE{(fcPriceType.Text == "1" ? "" : fcPriceType.Text)} AS SALEPRICE,UNITID FROM PRODUCTS WHERE CATEGORYID = {(from x in cats where x.NAME == fcCategories.Text select x.ID).First()} ORDER BY SALEPRICE ASC)
                                SELECT T.*,ISNULL((SELECT SUM(STOCK) FROM STOCKS WHERE PRODID = T.ID),0) AS STOCK, 
                                ISNULL((SELECT TOP 1 BUYPRICE FROM STOCKS WHERE PRODID = T.ID ORDER BY BUYPRICE DESC),0) AS BUYPRICE,
                                ISNULL((SELECT TOP 1 U.NAME FROM UNITS AS U WHERE ID = T.UNITID),'ADET') AS UNIT
                                FROM TABLO AS T ORDER BY SALEPRICE
                                """;
                        break;
                    case "FİYAT (AZALAN)":
                        qry = $"""
                                WITH TABLO AS(SELECT TOP 500 ID,BARCODE,NAME,VATRATE,SALEPRICE{(fcPriceType.Text == "1" ? "" : fcPriceType.Text)} AS SALEPRICE,UNITID FROM PRODUCTS WHERE CATEGORYID = {(from x in cats where x.NAME == fcCategories.Text select x.ID).First()} ORDER BY SALEPRICE DESC)
                                SELECT T.*,ISNULL((SELECT SUM(STOCK) FROM STOCKS WHERE PRODID = T.ID),0) AS STOCK, 
                                ISNULL((SELECT TOP 1 BUYPRICE FROM STOCKS WHERE PRODID = T.ID ORDER BY BUYPRICE DESC),0) AS BUYPRICE,
                                ISNULL((SELECT TOP 1 U.NAME FROM UNITS AS U WHERE ID = T.UNITID),'ADET') AS UNIT
                                FROM TABLO AS T ORDER BY SALEPRICE DESC
                                """;
                        break;
                    case "BARKOD (ARTAN)":
                        qry = $"""
                                WITH TABLO AS(SELECT TOP 500 ID,BARCODE,NAME,VATRATE,SALEPRICE{(fcPriceType.Text == "1" ? "" : fcPriceType.Text)} AS SALEPRICE,UNITID FROM PRODUCTS WHERE CATEGORYID = {(from x in cats where x.NAME == fcCategories.Text select x.ID).First()} ORDER BY BARCODE ASC)
                                SELECT T.*,ISNULL((SELECT SUM(STOCK) FROM STOCKS WHERE PRODID = T.ID),0) AS STOCK, 
                                ISNULL((SELECT TOP 1 BUYPRICE FROM STOCKS WHERE PRODID = T.ID ORDER BY BUYPRICE DESC),0) AS BUYPRICE,
                                ISNULL((SELECT TOP 1 U.NAME FROM UNITS AS U WHERE ID = T.UNITID),'ADET') AS UNIT
                                FROM TABLO AS T ORDER BY BARCODE ASC
                                """;
                        break;
                    case "BARKOD (AZALAN)":
                        qry = $"""
                                WITH TABLO AS(SELECT TOP 500 ID,BARCODE,NAME,VATRATE,SALEPRICE{(fcPriceType.Text == "1" ? "" : fcPriceType.Text)} AS SALEPRICE,UNITID FROM PRODUCTS WHERE CATEGORYID = {(from x in cats where x.NAME == fcCategories.Text select x.ID).First()} ORDER BY BARCODE DESC)
                                SELECT T.*,ISNULL((SELECT SUM(STOCK) FROM STOCKS WHERE PRODID = T.ID),0) AS STOCK, 
                                ISNULL((SELECT TOP 1 BUYPRICE FROM STOCKS WHERE PRODID = T.ID ORDER BY BUYPRICE DESC),0) AS BUYPRICE,
                                ISNULL((SELECT TOP 1 U.NAME FROM UNITS AS U WHERE ID = T.UNITID),'ADET') AS UNIT
                                FROM TABLO AS T ORDER BY BARCODE DESC
                                """;
                        break;
                    case "İSİM (A - Z)":
                        qry = $"""
                                WITH TABLO AS(SELECT TOP 500 ID,BARCODE,NAME,VATRATE,SALEPRICE{(fcPriceType.Text == "1" ? "" : fcPriceType.Text)} AS SALEPRICE,UNITID FROM PRODUCTS WHERE CATEGORYID = {(from x in cats where x.NAME == fcCategories.Text select x.ID).First()} ORDER BY NAME ASC)
                                SELECT T.*,ISNULL((SELECT SUM(STOCK) FROM STOCKS WHERE PRODID = T.ID),0) AS STOCK, 
                                ISNULL((SELECT TOP 1 BUYPRICE FROM STOCKS WHERE PRODID = T.ID ORDER BY BUYPRICE DESC),0) AS BUYPRICE,
                                ISNULL((SELECT TOP 1 U.NAME FROM UNITS AS U WHERE ID = T.UNITID),'ADET') AS UNIT
                                FROM TABLO AS T ORDER BY NAME ASC
                                """;
                        break;
                    case "İSİM (Z - A)":
                        qry = $"""
                                WITH TABLO AS(SELECT TOP 500 ID,BARCODE,NAME,VATRATE,SALEPRICE{(fcPriceType.Text == "1" ? "" : fcPriceType.Text)} AS SALEPRICE,UNITID FROM PRODUCTS WHERE CATEGORYID = {(from x in cats where x.NAME == fcCategories.Text select x.ID).First()} ORDER BY NAME DESC)
                                SELECT T.*,ISNULL((SELECT SUM(STOCK) FROM STOCKS WHERE PRODID = T.ID),0) AS STOCK, 
                                ISNULL((SELECT TOP 1 BUYPRICE FROM STOCKS WHERE PRODID = T.ID ORDER BY BUYPRICE DESC),0) AS BUYPRICE,
                                ISNULL((SELECT TOP 1 U.NAME FROM UNITS AS U WHERE ID = T.UNITID),'ADET') AS UNIT
                                FROM TABLO AS T ORDER BY NAME DESC
                                """;
                        break;
                    default:
                        break;
                }
            }
            if (qry != "")
            {
                await using var conn = new SqlConnection(settings.Sql.ConnectionString());
                conn.Open();
                var ar = new SqlDataAdapter(qry, conn);
                var dt = new DataTable();
                ar.Fill(dt);
                dgvMain.DataSource = dt;
                dgvMain.ClearSelection();
            }
        }
        public async void RefreshMainDataGridWithSearch(string search)
        {
            dgvMain.EndEdit();
            var settings = Setting.Get();
            var qry = "";
            var filter = fcFilter.Text;
            if (fcCategories.Text == "TÜMÜ")
            {

                switch (filter)
                {
                    case "YOK":
                        qry = $"""
                                WITH TABLO AS(SELECT TOP 500 ID,BARCODE,NAME,VATRATE,SALEPRICE{((fcPriceType.Text ?? "1") == "1" ? "" : fcPriceType.Text)} AS SALEPRICE,UNITID FROM PRODUCTS WHERE (NAME LIKE '%{search}%' OR BARCODE LIKE '%{search}%')
                                SELECT T.*,ISNULL((SELECT SUM(STOCK) FROM STOCKS WHERE PRODID = T.ID),0) AS STOCK, 
                                ISNULL((SELECT TOP 1 BUYPRICE FROM STOCKS WHERE PRODID = T.ID ORDER BY BUYPRICE DESC),0) AS BUYPRICE,
                                ISNULL((SELECT TOP 1 U.NAME FROM UNITS AS U WHERE ID = T.UNITID),'ADET') AS UNIT
                                FROM TABLO AS T ORDER BY T.ID
                                """;
                        break;
                    case "ÇOK SATANLAR":
                        qry = $"""
                                WITH TABLO AS(SELECT TOP 500 ID,BARCODE,NAME,VATRATE,SALEPRICE{(fcPriceType.Text == "1" ? "" : fcPriceType.Text)} AS SALEPRICE,UNITID FROM PRODUCTS 
                                WHERE (NAME LIKE '%{search}%' OR BARCODE LIKE '%{search}%') AND BARCODE IN (SELECT TOP 500 FC.BARCODE FROM FICHELINES AS FC WHERE BARCODE <> '0' 
                                GROUP BY FC.BARCODE ORDER BY SUM(FC.QUANTITY) DESC))
                                SELECT T.*,ISNULL((SELECT SUM(STOCK) FROM STOCKS WHERE PRODID = T.ID),0) AS STOCK, 
                                ISNULL((SELECT TOP 1 BUYPRICE FROM STOCKS WHERE PRODID = T.ID ORDER BY BUYPRICE DESC),0) AS BUYPRICE,
                                ISNULL((SELECT TOP 1 U.NAME FROM UNITS AS U WHERE ID = T.UNITID),'ADET') AS UNIT
                                FROM TABLO AS T ORDER BY T.ID
                                """;
                        break;
                    case "ÇOK BULUNAN":
                        qry = $"""
                                WITH TABLO AS(SELECT TOP 500 ID,BARCODE,NAME,VATRATE,SALEPRICE{(fcPriceType.Text == "1" ? "" : fcPriceType.Text)} AS SALEPRICE,UNITID FROM PRODUCTS 
                                WHERE (NAME LIKE '%{search}%' OR BARCODE LIKE '%{search}%') AND ID IN (SELECT TOP 500 S.PRODID FROM STOCKS AS S GROUP BY S.PRODID ORDER BY SUM(S.STOCK) DESC) )
                                SELECT T.*,ISNULL((SELECT SUM(STOCK) FROM STOCKS WHERE PRODID = T.ID),0) AS STOCK, 
                                ISNULL((SELECT TOP 1 BUYPRICE FROM STOCKS WHERE PRODID = T.ID ORDER BY BUYPRICE DESC),0) AS BUYPRICE,
                                ISNULL((SELECT TOP 1 U.NAME FROM UNITS AS U WHERE ID = T.UNITID),'ADET') AS UNIT
                                FROM TABLO AS T ORDER BY STOCK DESC
                                """;
                        break;
                    case "FİYAT (ARTAN)":
                        qry = $"""
                                WITH TABLO AS(SELECT TOP 500 ID,BARCODE,NAME,VATRATE,SALEPRICE{(fcPriceType.Text == "1" ? "" : fcPriceType.Text)} AS SALEPRICE,UNITID FROM PRODUCTS WHERE (NAME LIKE '%{search}%' OR BARCODE LIKE '%{search}%') ORDER BY SALEPRICE ASC)
                                SELECT T.*,ISNULL((SELECT SUM(STOCK) FROM STOCKS WHERE PRODID = T.ID),0) AS STOCK, 
                                ISNULL((SELECT TOP 1 BUYPRICE FROM STOCKS WHERE PRODID = T.ID ORDER BY BUYPRICE DESC),0) AS BUYPRICE,
                                ISNULL((SELECT TOP 1 U.NAME FROM UNITS AS U WHERE ID = T.UNITID),'ADET') AS UNIT
                                FROM TABLO AS T ORDER BY SALEPRICE
                                """;
                        break;
                    case "FİYAT (AZALAN)":
                        qry = $"""
                                WITH TABLO AS(SELECT TOP 500 ID,BARCODE,NAME,VATRATE,SALEPRICE{(fcPriceType.Text == "1" ? "" : fcPriceType.Text)} AS SALEPRICE,UNITID FROM PRODUCTS WHERE (NAME LIKE '%{search}%' OR BARCODE LIKE '%{search}%')  ORDER BY SALEPRICE DESC)
                                SELECT T.*,ISNULL((SELECT SUM(STOCK) FROM STOCKS WHERE PRODID = T.ID),0) AS STOCK, 
                                ISNULL((SELECT TOP 1 BUYPRICE FROM STOCKS WHERE PRODID = T.ID ORDER BY BUYPRICE DESC),0) AS BUYPRICE,
                                ISNULL((SELECT TOP 1 U.NAME FROM UNITS AS U WHERE ID = T.UNITID),'ADET') AS UNIT
                                FROM TABLO AS T ORDER BY SALEPRICE DESC
                                """;
                        break;
                    case "BARKOD (ARTAN)":
                        qry = $"""
                                WITH TABLO AS(SELECT TOP 500 ID,BARCODE,NAME,VATRATE,SALEPRICE{(fcPriceType.Text == "1" ? "" : fcPriceType.Text)} AS SALEPRICE,UNITID FROM PRODUCTS WHERE (NAME LIKE '%{search}%' OR BARCODE LIKE '%{search}%')  ORDER BY BARCODE ASC)
                                SELECT T.*,ISNULL((SELECT SUM(STOCK) FROM STOCKS WHERE PRODID = T.ID),0) AS STOCK, 
                                ISNULL((SELECT TOP 1 BUYPRICE FROM STOCKS WHERE PRODID = T.ID ORDER BY BUYPRICE DESC),0) AS BUYPRICE,
                                ISNULL((SELECT TOP 1 U.NAME FROM UNITS AS U WHERE ID = T.UNITID),'ADET') AS UNIT
                                FROM TABLO AS T ORDER BY BARCODE ASC
                                """;
                        break;
                    case "BARKOD (AZALAN)":
                        qry = $"""
                                WITH TABLO AS(SELECT TOP 500 ID,BARCODE,NAME,VATRATE,SALEPRICE{(fcPriceType.Text == "1" ? "" : fcPriceType.Text)} AS SALEPRICE,UNITID FROM PRODUCTS WHERE (NAME LIKE '%{search}%' OR BARCODE LIKE '%{search}%')  ORDER BY BARCODE DESC)
                                SELECT T.*,ISNULL((SELECT SUM(STOCK) FROM STOCKS WHERE PRODID = T.ID),0) AS STOCK, 
                                ISNULL((SELECT TOP 1 BUYPRICE FROM STOCKS WHERE PRODID = T.ID ORDER BY BUYPRICE DESC),0) AS BUYPRICE,
                                ISNULL((SELECT TOP 1 U.NAME FROM UNITS AS U WHERE ID = T.UNITID),'ADET') AS UNIT
                                FROM TABLO AS T ORDER BY BARCODE DESC
                                """;
                        break;
                    case "İSİM (A - Z)":
                        qry = $"""
                                WITH TABLO AS(SELECT TOP 500 ID,BARCODE,NAME,VATRATE,SALEPRICE{(fcPriceType.Text == "1" ? "" : fcPriceType.Text)} AS SALEPRICE,UNITID FROM PRODUCTS WHERE (NAME LIKE '%{search}%' OR BARCODE LIKE '%{search}%')  ORDER BY NAME ASC)
                                SELECT T.*,ISNULL((SELECT SUM(STOCK) FROM STOCKS WHERE PRODID = T.ID),0) AS STOCK, 
                                ISNULL((SELECT TOP 1 BUYPRICE FROM STOCKS WHERE PRODID = T.ID ORDER BY BUYPRICE DESC),0) AS BUYPRICE,
                                ISNULL((SELECT TOP 1 U.NAME FROM UNITS AS U WHERE ID = T.UNITID),'ADET') AS UNIT
                                FROM TABLO AS T ORDER BY NAME ASC
                                """;
                        break;
                    case "İSİM (Z - A)":
                        qry = $"""
                                WITH TABLO AS(SELECT TOP 500 ID,BARCODE,NAME,VATRATE,SALEPRICE{(fcPriceType.Text == "1" ? "" : fcPriceType.Text)} AS SALEPRICE,UNITID FROM PRODUCTS WHERE (NAME LIKE '%{search}%' OR BARCODE LIKE '%{search}%')  ORDER BY NAME DESC)
                                SELECT T.*,ISNULL((SELECT SUM(STOCK) FROM STOCKS WHERE PRODID = T.ID),0) AS STOCK, 
                                ISNULL((SELECT TOP 1 BUYPRICE FROM STOCKS WHERE PRODID = T.ID ORDER BY BUYPRICE DESC),0) AS BUYPRICE,
                                ISNULL((SELECT TOP 1 U.NAME FROM UNITS AS U WHERE ID = T.UNITID),'ADET') AS UNIT
                                FROM TABLO AS T ORDER BY NAME DESC
                                """;
                        break;
                    default:
                        break;
                }
            }
            else
            {
                switch (filter)
                {
                    case "YOK":
                        qry = $"""
                                WITH TABLO AS(SELECT TOP 500 ID,BARCODE,NAME,VATRATE,SALEPRICE{(fcPriceType.Text == "1" ? "" : fcPriceType.Text)} AS SALEPRICE,UNITID FROM PRODUCTS WHERE (NAME LIKE '%{search}%' OR BARCODE LIKE '%{search}%') AND CATEGORYID = {(from x in cats where x.NAME == fcCategories.Text select x.ID).First()})
                                SELECT T.*,ISNULL((SELECT SUM(STOCK) FROM STOCKS WHERE PRODID = T.ID),0) AS STOCK, 
                                ISNULL((SELECT TOP 1 BUYPRICE FROM STOCKS WHERE PRODID = T.ID ORDER BY BUYPRICE DESC),0) AS BUYPRICE,
                                ISNULL((SELECT TOP 1 U.NAME FROM UNITS AS U WHERE ID = T.UNITID),'ADET') AS UNIT
                                FROM TABLO AS T ORDER BY T.ID
                                """;
                        break;
                    case "ÇOK SATANLAR":
                        qry = $"""
                                WITH TABLO AS(SELECT TOP 500 ID,BARCODE,NAME,VATRATE,SALEPRICE{(fcPriceType.Text == "1" ? "" : fcPriceType.Text)} AS SALEPRICE,UNITID FROM PRODUCTS 
                                WHERE (NAME LIKE '%{search}%' OR BARCODE LIKE '%{search}%') AND  BARCODE IN (SELECT TOP 500 FC.BARCODE FROM FICHELINES AS FC WHERE BARCODE <> '0' AND CATEGORYID = {(from x in cats where x.NAME == fcCategories.Text select x.ID).First()}
                                GROUP BY FC.BARCODE ORDER BY SUM(FC.QUANTITY) DESC))
                                SELECT T.*,ISNULL((SELECT SUM(STOCK) FROM STOCKS WHERE PRODID = T.ID),0) AS STOCK, 
                                ISNULL((SELECT TOP 1 BUYPRICE FROM STOCKS WHERE PRODID = T.ID ORDER BY BUYPRICE DESC),0) AS BUYPRICE,
                                ISNULL((SELECT TOP 1 U.NAME FROM UNITS AS U WHERE ID = T.UNITID),'ADET') AS UNIT
                                FROM TABLO AS T ORDER BY T.ID
                                """;
                        break;
                    case "ÇOK BULUNAN":
                        qry = $"""
                                WITH TABLO AS(SELECT TOP 500 ID,BARCODE,NAME,VATRATE,SALEPRICE{(fcPriceType.Text == "1" ? "" : fcPriceType.Text)} AS SALEPRICE,UNITID FROM PRODUCTS 
                                WHERE (NAME LIKE '%{search}%' OR BARCODE LIKE '%{search}%') AND  ID IN (SELECT TOP 500 S.PRODID FROM STOCKS AS S GROUP BY S.PRODID ORDER BY SUM(S.STOCK) DESC) AND CATEGORYID = {(from x in cats where x.NAME == fcCategories.Text select x.ID).First()})
                                SELECT T.*,ISNULL((SELECT SUM(STOCK) FROM STOCKS WHERE PRODID = T.ID),0) AS STOCK, 
                                ISNULL((SELECT TOP 1 BUYPRICE FROM STOCKS WHERE PRODID = T.ID ORDER BY BUYPRICE DESC),0) AS BUYPRICE,
                                ISNULL((SELECT TOP 1 U.NAME FROM UNITS AS U WHERE ID = T.UNITID),'ADET') AS UNIT
                                FROM TABLO AS T ORDER BY STOCK DESC
                                """;
                        break;
                    case "FİYAT (ARTAN)":
                        qry = $"""
                                WITH TABLO AS(SELECT TOP 500 ID,BARCODE,NAME,VATRATE,SALEPRICE{(fcPriceType.Text == "1" ? "" : fcPriceType.Text)} AS SALEPRICE,UNITID FROM PRODUCTS WHERE (NAME LIKE '%{search}%' OR BARCODE LIKE '%{search}%') AND  CATEGORYID = {(from x in cats where x.NAME == fcCategories.Text select x.ID).First()} ORDER BY SALEPRICE ASC)
                                SELECT T.*,ISNULL((SELECT SUM(STOCK) FROM STOCKS WHERE PRODID = T.ID),0) AS STOCK, 
                                ISNULL((SELECT TOP 1 BUYPRICE FROM STOCKS WHERE PRODID = T.ID ORDER BY BUYPRICE DESC),0) AS BUYPRICE,
                                ISNULL((SELECT TOP 1 U.NAME FROM UNITS AS U WHERE ID = T.UNITID),'ADET') AS UNIT
                                FROM TABLO AS T ORDER BY SALEPRICE
                                """;
                        break;
                    case "FİYAT (AZALAN)":
                        qry = $"""
                                WITH TABLO AS(SELECT TOP 500 ID,BARCODE,NAME,VATRATE,SALEPRICE{(fcPriceType.Text == "1" ? "" : fcPriceType.Text)} AS SALEPRICE,UNITID FROM PRODUCTS WHERE (NAME LIKE '%{search}%' OR BARCODE LIKE '%{search}%') AND  CATEGORYID = {(from x in cats where x.NAME == fcCategories.Text select x.ID).First()} ORDER BY SALEPRICE DESC)
                                SELECT T.*,ISNULL((SELECT SUM(STOCK) FROM STOCKS WHERE PRODID = T.ID),0) AS STOCK, 
                                ISNULL((SELECT TOP 1 BUYPRICE FROM STOCKS WHERE PRODID = T.ID ORDER BY BUYPRICE DESC),0) AS BUYPRICE,
                                ISNULL((SELECT TOP 1 U.NAME FROM UNITS AS U WHERE ID = T.UNITID),'ADET') AS UNIT
                                FROM TABLO AS T ORDER BY SALEPRICE DESC
                                """;
                        break;
                    case "BARKOD (ARTAN)":
                        qry = $"""
                                WITH TABLO AS(SELECT TOP 500 ID,BARCODE,NAME,VATRATE,SALEPRICE{(fcPriceType.Text == "1" ? "" : fcPriceType.Text)} AS SALEPRICE,UNITID FROM PRODUCTS WHERE (NAME LIKE '%{search}%' OR BARCODE LIKE '%{search}%') AND  CATEGORYID = {(from x in cats where x.NAME == fcCategories.Text select x.ID).First()} ORDER BY BARCODE ASC)
                                SELECT T.*,ISNULL((SELECT SUM(STOCK) FROM STOCKS WHERE PRODID = T.ID),0) AS STOCK, 
                                ISNULL((SELECT TOP 1 BUYPRICE FROM STOCKS WHERE PRODID = T.ID ORDER BY BUYPRICE DESC),0) AS BUYPRICE,
                                ISNULL((SELECT TOP 1 U.NAME FROM UNITS AS U WHERE ID = T.UNITID),'ADET') AS UNIT
                                FROM TABLO AS T ORDER BY BARCODE ASC
                                """;
                        break;
                    case "BARKOD (AZALAN)":
                        qry = $"""
                                WITH TABLO AS(SELECT TOP 500 ID,BARCODE,NAME,VATRATE,SALEPRICE{(fcPriceType.Text == "1" ? "" : fcPriceType.Text)} AS SALEPRICE,UNITID FROM PRODUCTS WHERE (NAME LIKE '%{search}%' OR BARCODE LIKE '%{search}%') AND  CATEGORYID = {(from x in cats where x.NAME == fcCategories.Text select x.ID).First()} ORDER BY BARCODE DESC)
                                SELECT T.*,ISNULL((SELECT SUM(STOCK) FROM STOCKS WHERE PRODID = T.ID),0) AS STOCK, 
                                ISNULL((SELECT TOP 1 BUYPRICE FROM STOCKS WHERE PRODID = T.ID ORDER BY BUYPRICE DESC),0) AS BUYPRICE,
                                ISNULL((SELECT TOP 1 U.NAME FROM UNITS AS U WHERE ID = T.UNITID),'ADET') AS UNIT
                                FROM TABLO AS T ORDER BY BARCODE DESC
                                """;
                        break;
                    case "İSİM (A - Z)":
                        qry = $"""
                                WITH TABLO AS(SELECT TOP 500 ID,BARCODE,NAME,VATRATE,SALEPRICE{(fcPriceType.Text == "1" ? "" : fcPriceType.Text)} AS SALEPRICE,UNITID FROM PRODUCTS WHERE (NAME LIKE '%{search}%' OR BARCODE LIKE '%{search}%') AND  CATEGORYID = {(from x in cats where x.NAME == fcCategories.Text select x.ID).First()} ORDER BY NAME ASC)
                                SELECT T.*,ISNULL((SELECT SUM(STOCK) FROM STOCKS WHERE PRODID = T.ID),0) AS STOCK, 
                                ISNULL((SELECT TOP 1 BUYPRICE FROM STOCKS WHERE PRODID = T.ID ORDER BY BUYPRICE DESC),0) AS BUYPRICE,
                                ISNULL((SELECT TOP 1 U.NAME FROM UNITS AS U WHERE ID = T.UNITID),'ADET') AS UNIT
                                FROM TABLO AS T ORDER BY NAME ASC
                                """;
                        break;
                    case "İSİM (Z - A)":
                        qry = $"""
                                WITH TABLO AS(SELECT TOP 500 ID,BARCODE,NAME,VATRATE,SALEPRICE{(fcPriceType.Text == "1" ? "" : fcPriceType.Text)} AS SALEPRICE,UNITID FROM PRODUCTS WHERE (NAME LIKE '%{search}%' OR BARCODE LIKE '%{search}%') AND  CATEGORYID = {(from x in cats where x.NAME == fcCategories.Text select x.ID).First()} ORDER BY NAME DESC)
                                SELECT T.*,ISNULL((SELECT SUM(STOCK) FROM STOCKS WHERE PRODID = T.ID),0) AS STOCK, 
                                ISNULL((SELECT TOP 1 BUYPRICE FROM STOCKS WHERE PRODID = T.ID ORDER BY BUYPRICE DESC),0) AS BUYPRICE,
                                ISNULL((SELECT TOP 1 U.NAME FROM UNITS AS U WHERE ID = T.UNITID),'ADET') AS UNIT
                                FROM TABLO AS T ORDER BY NAME DESC
                                """;
                        break;
                    default:
                        break;
                }
            }
            if (qry != "")
            {
                await using var conn = new SqlConnection(settings.Sql.ConnectionString());
                conn.Open();
                var ar = new SqlDataAdapter(qry, conn);
                var dt = new DataTable();
                ar.Fill(dt);
                dgvMain.DataSource = dt;
                dgvMain.ClearSelection();
            }
        }
        private void fcFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rtbSearch.Texts.Length > 0)
            {
                RefreshMainDataGridWithSearch(rtbSearch.Texts);
            }
            else
            {
                RefreshMainDataGrid();
            }
        }

        private void fcPriceType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rtbSearch.Texts.Length > 0)
            {
                RefreshMainDataGridWithSearch(rtbSearch.Texts);
            }
            else
            {
                RefreshMainDataGrid();
            }
        }

        private void fcCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rtbSearch.Texts.Length > 0)
            {
                RefreshMainDataGridWithSearch(rtbSearch.Texts);
            }
            else
            {
                RefreshMainDataGrid();
            }
        }

        private void rtbSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (rtbSearch.Texts.Length > 0)
                {
                    RefreshMainDataGridWithSearch(rtbSearch.Texts);
                }
                else
                {
                    RefreshMainDataGrid();
                }
            }
        }
    }
}
