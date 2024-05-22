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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;
namespace POSA.Forms
{
    public partial class AddColor : Form
    {
        public AddColor()
        {
            InitializeComponent();
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
            dgvMain.Columns.Insert(dgvMain.Columns.Count, new DataGridViewImageColumn()
            {
                Image = Properties.Resources._24pxUpdate,
                Name = "UPDATE",
                HeaderText = "",
                FillWeight = 7,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
            dgvMain.Columns.Insert(dgvMain.Columns.Count, new DataGridViewImageColumn()
            {
                Image = Properties.Resources._24pxClose,
                Name = "DELETE",
                HeaderText = "",
                FillWeight = 7,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
            dgvMain.Columns["DELETE"].FillWeight = 7;
            dgvMain.Columns["UPDATE"].FillWeight = 7;
            RefreshDataGrid();
        }
        public async void RefreshDataGrid()
        {
            dgvMain.EndEdit();
            var settings = Setting.Get();
            var sb = new SqlBuilder();
            sb.Select("ID,NAME,DESCRIPTION");
            var builderTemp = sb.AddTemplate("SELECT /**select**/ FROM COLORS WHERE ID>1");
            await using var conn = new SqlConnection(settings.Sql.ConnectionString());
            conn.Open();
            var ar = new SqlDataAdapter(builderTemp.RawSql, conn);
            var dt = new DataTable();
            ar.Fill(dt);
            dgvMain.DataSource = dt;
            dgvMain.ClearSelection();
        }
        public async void DeleteFromDB(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
                return;
            var settings = Setting.Get();
            var sb = new SqlBuilder();
            var builderTemp = sb.AddTemplate($"DELETE FROM COLORS WHERE ID = {id}");
            await using var conn = new SqlConnection(settings.Sql.ConnectionString());
            conn.Open();
            var result = await conn.ExecuteAsync(builderTemp.RawSql);
        }
        private void ClearScreen()
        {
            tbColor.Text = "";
            tbDescription.Text = "";
        }
        private async void btnSave_Click(object sender, EventArgs e)
        {
            var settings = Setting.Get();
            var sb = new SqlBuilder();
            var builderTemp = sb.AddTemplate("INSERT INTO COLORS(NAME,DESCRIPTION,CREATEDBY,CREATEDATE) VALUES(@NAME,@DESCRIPTION,@CREATEDBY,GETDATE())");
            var param = new
            {
                NAME = tbColor.Text,
                DESCRIPTION = tbDescription.Text,
                CREATEDBY = settings.LastSuccesfullyLoggedUser
            };
            await using var conn = new SqlConnection(settings.Sql.ConnectionString());
            conn.Open();
            var result = await conn.ExecuteAsync(builderTemp.RawSql, param);
            RefreshDataGrid();
            ClearScreen();
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
                var uc = new UpdateColor(dgvMain.Rows[e.RowIndex].Cells["ID"].Value.ToString());
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
