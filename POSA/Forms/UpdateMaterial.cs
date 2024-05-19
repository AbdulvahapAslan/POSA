﻿using Dapper;
using POSA.Dto;
using POSA.Helpers.Settings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Dapper.SqlMapper;
namespace POSA.Forms
{
    public partial class UpdateMaterial : Form
    {
        public string ID;
        public UpdateMaterial(string id)
        {
            InitializeComponent();
            ID = id;
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private async void UpdateCategory_Load(object sender, EventArgs e)
        {
            var settings = Setting.Get();
            var sb = new SqlBuilder();
            sb.Select("ID,NAME,DESCRIPTION");
            sb.Where("ID=@ID");
            var param = new { ID = ID };
            var builderTemp = sb.AddTemplate("SELECT /**select**/ FROM MATERIALS /**where**/");
            await using var conn = new SqlConnection(settings.Sql.ConnectionString());
            conn.Open();
            var result = await conn.QueryAsync<Category>(builderTemp.RawSql, param);
            if (result.Any())
            {
                var category = result.First();
                tbUnit.Text = category.NAME;
                tbDescription.Text = category.DESCRIPTION;
            }
        }
        public async Task<bool> Update(string id)
        {
            var settings = Setting.Get();
            var sb = new SqlBuilder();
            sb.Where("ID=@ID");
            var param = new { ID = ID };
            var builderTemp = sb.AddTemplate($"UPDATE MATERIALS  SET NAME='{tbUnit.Text ?? ""}',DESCRIPTION='{tbDescription.Text ?? ""}',CHANGEDBY='{settings.LastSuccesfullyLoggedUser}',CHANGEDATE=GETDATE() /**where**/");
            await using var conn = new SqlConnection(settings.Sql.ConnectionString());
            conn.Open();
            var result = await conn.ExecuteAsync(builderTemp.RawSql, param);
            return result > 0 ? true : false;
        }
        private async void btnSave_Click(object sender, EventArgs e)
        {
            var snc = await Update(ID);
            if (snc)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.DialogResult = DialogResult.Yes;
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateUnit_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
