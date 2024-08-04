using Dapper;
using POSA.Helpers.Settings;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using static Dapper.SqlMapper;
namespace POSA.Forms
{
    public partial class StockReportInnerForm : Form
    {
        public StockReportInnerForm()
        {
            InitializeComponent();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tglCountMode_CheckedChanged(object sender, EventArgs e)
        {
            if (tglCountMode.Checked)
            {
                CMPanel.Visible = true;
                pnlGrid.Visible = false;
                lblCountMode.ForeColor = Color.FromArgb(0, 140, 71);
            }
            else
            {
                CMPanel.Visible = false;
                pnlGrid.Visible = true;
                lblCountMode.ForeColor = Color.Red;
            }
        }
    }
}
