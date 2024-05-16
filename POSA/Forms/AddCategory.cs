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
    public partial class AddCategory : Form
    {
        public AddCategory()
        {
            InitializeComponent();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public List<Category> listOfCategories = new List<Category>();
        public List<Category> newListOfCategories = new List<Category>();
        private async void AddCategory_Load(object sender, EventArgs e)
        {
            dgvMain.Columns.Insert(dgvMain.Columns.Count, new DataGridViewImageColumn()
            {
                Image = Properties.Resources._16pxRedClose,
                Name = "DELETE",
                HeaderText = "",
                FillWeight = 5,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
            dgvMain.Columns["DELETE"].FillWeight = 5;
            RefreshDataGrid();
        }
        public async void AddCategoryToDatabase(Category c)
        {
            var settings = Setting.Get();
            var sb = new SqlBuilder();
            var builderTemp = sb.AddTemplate("INSERT INTO CATEGORIES(NAME,DESCRIPTION,CREATEDBY,CREATEDATE) VALUES(@NAME,@DESCRIPTION,@CREATEDBY,GETDATE())");
            var param = new
            {
                NAME = c.NAME,
                DESCRIPTION = c.DESCRIPTION,
                CREATEDBY = settings.LastSuccesfullyLoggedUser
            };
            await using var conn = new SqlConnection(settings.Sql.ConnectionString());
            conn.Open();
            var result = await conn.ExecuteAsync(builderTemp.RawSql, param);
        }
        public async void UpdateCategory(Category c)
        {
            var settings = Setting.Get();
            var sb = new SqlBuilder();
            var builderTemp = sb.AddTemplate("UPDATE CATEGORIES SET NAME=@NAME, DESCRIPTION = @DESCRIPTION, CHANGEDBY =@CHANGEDBY, CHANGEDATE=GETDATE() WHERE ID=@ID");
            var param = new
                {
                    NAME = c.NAME,
                    DESCRIPTION = c.DESCRIPTION,
                    CHANGEDBY = settings.LastSuccesfullyLoggedUser,
                    ID = c.ID
                };
            await using var conn = new SqlConnection(settings.Sql.ConnectionString());
            conn.Open();
            var result = await conn.ExecuteAsync(builderTemp.RawSql, param);
        }
        public async void RefreshDataGrid()
        {
            dgvMain.EndEdit();
            dgvMain.Rows.Clear();
            listOfCategories.Clear();
            deletedIDs.Clear();
            var settings = Setting.Get();
            var sb = new SqlBuilder();
            sb.Select("ID,NAME,DESCRIPTION");
            var builderTemp = sb.AddTemplate("SELECT /**select**/ FROM CATEGORIES");
            await using var conn = new SqlConnection(settings.Sql.ConnectionString());
            conn.Open();
            var result = await conn.QueryAsync<Category>(builderTemp.RawSql);
            if (result.Any())
            {
                listOfCategories = result.ToList();
                foreach (var category in listOfCategories)
                {
                    dgvMain.Rows.Add(category.ID, category.NAME, category.DESCRIPTION);
                }
            }
        }
        public void SaveListToDatabase()
        {
            foreach (var category in newListOfCategories)
            {
                if (category.ID == 0)
                    AddCategoryToDatabase(category);
                else
                    UpdateCategory(category);
                if (deletedIDs.Any())
                    DeleteFromDB(string.Join(',', (from x in deletedIDs select x)));
            }
        }
        public async void DeleteFromDB(string ids)
        {
            var settings = Setting.Get();
            var sb = new SqlBuilder();
            var builderTemp = sb.AddTemplate($"DELETE FROM CATEGORIES WHERE ID IN ({ids})");
            await using var conn = new SqlConnection(settings.Sql.ConnectionString());
            conn.Open();
            var result = await conn.ExecuteAsync(builderTemp.RawSql);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            newListOfCategories.Clear();
            for (int i = 0; i < dgvMain.Rows.Count - 1; i++)
            {
                if (string.IsNullOrWhiteSpace((dgvMain.Rows[i].Cells["NAME"].Value ?? "").ToString()))
                {
                    MessageBox.Show("Kategori ismi boş olan satır veya satırlar mevcut. Devam edilemez!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            foreach (DataGridViewRow row in dgvMain.Rows)
            {
                if (row.Index == dgvMain.Rows.Count - 1)
                    continue;
                if (Convert.ToInt32(row.Cells["ID"].Value ?? "0") == 0)
                {
                    newListOfCategories.Add(new Category
                    {
                        DESCRIPTION = (row.Cells["DESCRIPTION"].Value ?? "").ToString(),
                        NAME = row.Cells["NAME"].Value.ToString(),
                        ID = Convert.ToInt32(row.Cells["ID"].Value ?? "0")
                    });
                }
                else
                {
                    var oldRecord = (from x in listOfCategories where x.ID == Convert.ToInt32(row.Cells["ID"].Value) select x).FirstOrDefault();
                    if (oldRecord.NAME != row.Cells["NAME"].Value.ToString() || oldRecord.DESCRIPTION != (row.Cells["DESCRIPTION"].Value ?? "").ToString())
                    {
                        newListOfCategories.Add(new Category
                        {
                            DESCRIPTION = (row.Cells["DESCRIPTION"].Value ?? "").ToString(),
                            NAME = row.Cells["NAME"].Value.ToString(),
                            ID = oldRecord.ID
                        });
                    }
                }
            }
            SaveListToDatabase();
            RefreshDataGrid();
        }
        List<int> deletedIDs = new List<int>();
        private void dgvMain_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != dgvMain.Rows.Count - 1)
                if (e.ColumnIndex == dgvMain.Columns["DELETE"].Index)
                {
                    dgvMain.Rows.Remove(dgvMain.Rows[e.RowIndex]);
                    deletedIDs.Add(Convert.ToInt32(dgvMain.Rows[e.RowIndex].Cells["ID"].Value));
                }
                    
        }
    }
}
