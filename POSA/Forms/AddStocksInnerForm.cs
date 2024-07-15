using Dapper;
using POSA.Helpers.Settings;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using static Dapper.SqlMapper;
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
        private void AddCustomerReportForm_Load(object sender, EventArgs e)
        {
            
        }
        private void btnSave_Click_1(object sender, EventArgs e)
        {

        }
    }
}
