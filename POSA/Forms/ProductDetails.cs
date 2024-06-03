using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using POSA.Dto;
using POSA.Helpers.Settings;
namespace POSA.Forms
{
    public partial class ProductDetails : Form
    {
        public string priceType;
        public ProductDetails(string priceType)
        {
            InitializeComponent();
            this.priceType = priceType;
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private async void tbSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var settings = Setting.Get();
                var sqlBuilder = new SqlBuilder();
                sqlBuilder.Select($"NAME,STOCKPLACE,SALEPRICE{(priceType == "1" ? "" : priceType)} AS PRICE");
                sqlBuilder.Where("BARCODE=@BARCODE");
                var param = new
                {
                    BARCODE = tbSearch.Text
                };
                await using var conn = new SqlConnection(settings.Sql.ConnectionString());
                var builderTemp = sqlBuilder.AddTemplate("SELECT /**select**/ FROM PRODUCTS /**where**/");
                conn.Open();
                var result = conn.QuerySingleOrDefaultAsync<Dto.ProductDetails>(builderTemp.RawSql, param).Result;
                if (result is not null)
                {
                    var sB = new SqlBuilder();
                    var bT = sB.AddTemplate(
                        $"""
                            SELECT ID,STOCK,BUYPRICE FROM STOCKS WHERE PRODID = (SELECT ID FROM PRODUCTS WHERE BARCODE = @BARCODE) AND STOCK>0 ORDER BY CREATEDATE
                            """
                        );
                    var stockParam = new
                    {
                        BARCODE = tbSearch.Text
                    };
                    var stocks = conn.QueryAsync<ProdStocks>(bT.RawSql, stockParam).Result.ToList();
                    if (stocks is not null)
                    {

                        lblStock.Text = stocks[0].STOCK.ToString();
                        tbBuyPrice.Text = stocks[0].BUYPRICE.ToString();
                    }
                    lblStockPlace.Text = result.STOCKPLACE;
                    lblName.Text = result.NAME;
                    lblPrice.Text = result.PRICE + "₺";
                }
            }
        }
        private void btnShowBuyingPrice_Click(object sender, EventArgs e)
        {
            if (tbBuyPrice.PasswordChar == '\0')
            {
                tbBuyPrice.PasswordChar = '*';
            }
            else
            {
                pnlPassword.Visible = !pnlPassword.Visible;
                tbPassword.Text = "";
                tbBuyPrice.PasswordChar = '*';
            }
        }
        private void btnConfirmPass_Click(object sender, EventArgs e)
        {
            if (tbPassword.Text == "1234")
            {
                tbBuyPrice.PasswordChar = '\0';
                pnlPassword.Visible = false;
            }
            else
            {
                tbBuyPrice.PasswordChar = '*';
            }
        }
        private void tbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnConfirmPass.PerformClick();
            }
        }
        private void ProductDetails_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
