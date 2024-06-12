using Dapper;
using POSA.Helpers.Settings;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using static Dapper.SqlMapper;
namespace POSA.Forms
{
    public partial class UpdatePrices : Form
    {
        public UpdatePrices()
        {
            InitializeComponent();
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en_GB");
        }
        private void pbClearSearch_Click(object sender, EventArgs e)
        {
            rtbSearch.Texts = "";
        }
        private async void AddCustomerReportForm_Load(object sender, EventArgs e)
        {
            RefreshMainDataGrid();
            dgvMain.ClearSelection();
        }
        private void dgvMain_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
        public int LastAddDepthRowIndex = 0;
        public async Task<bool> AddFicheHead(string paymentType, string ficheRef, int ficheType, decimal totalPrice, int custId, SqlTransaction trn, SqlConnection conn)
        {
            try
            {
                var settings = Setting.Get();
                var totalPriceUSD = -1 * decimal.Round((totalPrice / Mainpage.USD), 2, MidpointRounding.AwayFromZero);
                var totalPriceEURO = -1 * decimal.Round((totalPrice / Mainpage.EURO), 2, MidpointRounding.AwayFromZero);
                var sB = new SqlBuilder();//sB == sqlBuilder
                var bT = sB.AddTemplate(
                    $"""
                INSERT INTO FICHES(FICHEREF,FICHETYPE,SUPPLIERID,TOTALPRICE,USDTOTALPRICE,EUROTOTALPRICE,CREATEDBY,CREATEDATE,ISCUSTORVEND,PAYMENTTYPE)
                VALUES (@FICHEREF,@FICHETYPE,@SUPPLIERID,@TOTALPRICE,@USDTOTALPRICE,@EUROTOTALPRICE,@CREATEDBY,GETDATE(),'SUPP',@PAYMENTTYPE)
                """
                    );
                var param = new
                {
                    FICHEREF = ficheRef,
                    FICHETYPE = ficheType,
                    SUPPLIERID = custId,
                    TOTALPRICE = totalPrice,
                    USDTOTALPRICE = totalPriceUSD,
                    EUROTOTALPRICE = totalPriceEURO,
                    CREATEDBY = settings.LastSuccesfullyLoggedUser,
                    PAYMENTTYPE = paymentType
                };
                var result = conn.ExecuteAsync(bT.RawSql, param, trn).Result;
                if (result > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        public async void DeleteFromDB(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
                return;
            var settings = Setting.Get();
            var qry = $"DELETE FROM CUSTOMERS WHERE ID = {id}";
            await using var conn = new SqlConnection(settings.Sql.ConnectionString());
            conn.Open();
            var result = await conn.ExecuteAsync(qry);
        }
        public async void RefreshMainDataGrid()
        {
            dgvMain.EndEdit();
            var settings = Setting.Get();
            var qry = $"""
                SELECT TOP 300 BARCODE,NAME,SALEPRICE AS PRICE FROM PRODUCTS
                """; ;
            await using var conn = new SqlConnection(settings.Sql.ConnectionString());
            conn.Open();
            var ar = new SqlDataAdapter(qry, conn);
            var dt = new DataTable();
            ar.Fill(dt);
            dgvMain.DataSource = dt;
            dgvMain.ClearSelection();
        }
        public async Task<bool> AddFicheLine(string ficheRef, decimal lineTotalPrice, SqlTransaction trn, SqlConnection conn)
        {
            var settings = Setting.Get();
            var sB = new SqlBuilder();
            var bT = sB.AddTemplate(
                $"""
                    INSERT INTO FICHELINES(BARCODE,FICHEREF,TOTALPRICE,USDTOTALPRICE,EUROTOTALPRICE,CREATEDBY,CREATEDATE)
                    VALUES(0,@FICHEREF,@TOTALPRICE,@USDTOTALPRICE,@EUROTOTALPRICE,@CREATEDBY,GETDATE())
                """
                );
            var prmLine = new
            {
                FICHEREF = ficheRef,
                TOTALPRICE = lineTotalPrice,
                USDTOTALPRICE = lineTotalPrice / Mainpage.USD,
                EUROTOTALPRICE = lineTotalPrice / Mainpage.EURO,
                CREATEDBY = settings.LastSuccesfullyLoggedUser,
            };
            var snc = conn.ExecuteAsync(bT.RawSql, prmLine, trn).Result;
            return snc > 0;
        }
    }
}
