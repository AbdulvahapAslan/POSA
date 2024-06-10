using Dapper;
using POSA.Helpers.Settings;
using System.Data;
using System.Data.SqlClient;
namespace POSA.Forms
{
    public partial class SaleSelectCustomer : Form
    {
        public static int CustID = 0;
        public SaleSelectCustomer()
        {
            InitializeComponent();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public async void RefreshDataGrid()
        {
            dgvMain.EndEdit();
            var settings = Setting.Get();
            var sb = new SqlBuilder();
            sb.Select("ID,NAME,PHONE");
            var builderTemp = sb.AddTemplate("SELECT /**select**/ FROM CUSTOMERS WHERE ID>0");
            await using var conn = new SqlConnection(settings.Sql.ConnectionString());
            conn.Open();
            var ar = new SqlDataAdapter(builderTemp.RawSql, conn);
            var dt = new DataTable();
            ar.Fill(dt);
            dgvMain.DataSource = dt;
            dgvMain.ClearSelection();
        }
        private void rtbSearch__TextChanged(object sender, EventArgs e)
        {
            (dgvMain.DataSource as DataTable).DefaultView.RowFilter = $"NAME LIKE '{rtbSearch.Texts}%' OR PHONE LIKE '{rtbSearch.Texts}%'";
        }

        private void SaleSelectCustomer_Load(object sender, EventArgs e)
        {
            RefreshDataGrid();
        }

        private void dgvMain_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            CustID = Convert.ToInt32(dgvMain.Rows[e.RowIndex].Cells["ID"].Value.ToString());
            this.DialogResult = DialogResult.OK;
        }
    }
}
