using Dapper;
using POSA.Helpers.Settings;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace POSA.Forms
{
    public partial class AddBranch : Form
    {
        public bool isInnerForm;
        public AddBranch(bool showHeader)
        {
            InitializeComponent();
            lblPageHeaderAddBranch.Visible = showHeader;
            btnClose.Visible = showHeader;
            isInnerForm = showHeader;
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
        private async void AddCategory_Load(object sender, EventArgs e)
        {


            RefreshDataGrid();
        }
        public async void RefreshDataGrid()
        {
            dgvMain.EndEdit();
            var settings = Setting.Get();
            var sb = new SqlBuilder();
            sb.Select("ID,NAME,DESCRIPTION,ADDRESS");
            var builderTemp = sb.AddTemplate($"SELECT /**select**/ FROM BRANCHES{(isInnerForm ? " WHERE ID>1" : "")}");
            await using var conn = new SqlConnection(settings.Sql.ConnectionString());
            conn.Open();
            var ar = new SqlDataAdapter(builderTemp.RawSql, conn);
            var dt = new DataTable();
            ar.Fill(dt);
            dgvMain.Rows.Clear();
            foreach (DataRow row in dt.Rows)
            {
                dgvMain.Rows.Add(row["ID"].ToString(), row["NAME"].ToString(), row["ADDRESS"].ToString(), row["DESCRIPTION"].ToString());
            }
            dgvMain.ClearSelection();
           
        }
        public async void DeleteFromDB(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
                return;
            var settings = Setting.Get();
            var sb = new SqlBuilder();
            var builderTemp = sb.AddTemplate($"DELETE FROM BRANCHES WHERE ID = {id}");
            await using var conn = new SqlConnection(settings.Sql.ConnectionString());
            conn.Open();
            var result = await conn.ExecuteAsync(builderTemp.RawSql);
        }
        private async void btnSave_Click(object sender, EventArgs e)
        {
            var settings = Setting.Get();
            var sb = new SqlBuilder();
            var builderTemp = sb.AddTemplate("INSERT INTO BRANCHES(NAME,ADDRESS,DESCRIPTION,CREATEDBY,CREATEDATE) VALUES(@NAME,@ADDRESS,@DESCRIPTION,@CREATEDBY,GETDATE())");
            var param = new
            {
                NAME = tbBranch.Text,
                DESCRIPTION = tbDescription.Text,
                ADDRESS = tbAddress.Text,
                CREATEDBY = settings.LastSuccesfullyLoggedUser
            };
            await using var conn = new SqlConnection(settings.Sql.ConnectionString());
            conn.Open();
            var result = await conn.ExecuteAsync(builderTemp.RawSql, param);
            RefreshDataGrid();
            ClearScreen();
        }
        private void ClearScreen()
        {
            tbBranch.Text = "";
            tbDescription.Text = "";
        }
        private void dgvMain_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvMain.Columns["DELETE"].Index)
            {
                DeleteFromDB((dgvMain.Rows[e.RowIndex].Cells["ID"].Value ?? "").ToString());
                RefreshDataGrid();
            }
            if (e.ColumnIndex == dgvMain.Columns["UPDATE"].Index)
            {
                var uc = new UpdateBranch(dgvMain.Rows[e.RowIndex].Cells["ID"].Value.ToString());
                DialogResult dr = uc.ShowDialog();
                if (dr == DialogResult.OK)
                    MessageBox.Show("Güncellendi.", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Güncellenemedi.", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Error);
                RefreshDataGrid();
            }
        }
        private void rtbSearch__TextChanged(object sender, EventArgs e)
        {
            (dgvMain.DataSource as DataTable).DefaultView.RowFilter = $"NAME LIKE '{rtbSearch.Texts}%' OR DESCRIPTION LIKE '{rtbSearch.Texts}%'";
        }
        private void pbClearSearch_Click(object sender, EventArgs e)
        {
            rtbSearch.Texts = "";
        }
        private void AddCategory_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
