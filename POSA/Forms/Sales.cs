using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Dapper;
using POSA.CustomObjects;
using POSA.Dto;
using POSA.Helpers.Settings;
using static Dapper.SqlMapper;
namespace POSA.Forms
{
    public partial class Sales : Form
    {
        public Sales()
        {
            InitializeComponent();
            System.Threading.Thread.CurrentThread.CurrentUICulture = new CultureInfo("en_GB");
        }
        #region GENERAL 
        public List<GroupPage> GroupPages = new List<GroupPage>();
        public List<GroupButton> GroupButtons = new List<GroupButton>();
        private List<Product> Customers = new List<Product>();
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        #endregion
        #region CLASSES
        private class Product
        {
            public string Barcode { get; set; }
            public string ProductName { get; set; }
            public string Price { get; set; }
            public string BuyPrice { get; set; }
            public string Quantity { get; set; }
            public string ButtonNumber { get; set; }
            public string Total { get; set; }
            public DateTime RecordDate { get; set; } = DateTime.Now;
        }
        #endregion
        #region Functions & Events
        #region Customer Events
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            NextCustomer();
            foreach (Button btn in flpCustomers.Controls)
            {
                btn.BackColor = btnRootCustomer.BackColor;
            }
            var newButton = new Button()
            {
                BackColor = Color.LightGreen,
                Text = GiveLowestCustomerQueueNumber(),
                Size = new Size(btnRootCustomer.Width, btnRootCustomer.Height)
            };
            newButton.Click += new EventHandler(this.btnGetCustomer_Click);
            flpCustomers.Controls.Add(newButton);
        }
        private void btnGetCustomer_Click(object sender, EventArgs e)
        {
            NextCustomer();
            var btn = sender as Button;
            foreach (Button button in flpCustomers.Controls)
            {
                button.BackColor = btnRootCustomer.BackColor;
            }
            btn.BackColor = Color.LightGreen;
            var customerProducts = ((from x in Customers where x.ButtonNumber == btn.Text select x) ?? new List<Product>()).ToList<Product>();
            if (customerProducts.Count > 0)
            {
                foreach (var product in customerProducts)
                {
                    dgvMain.Rows.Add();
                    dgvMain.Rows[dgvMain.Rows.Count - 1].Cells["Barcode"].Value = product.Barcode;
                    dgvMain.Rows[dgvMain.Rows.Count - 1].Cells["ProductName"].Value = product.ProductName;
                    dgvMain.Rows[dgvMain.Rows.Count - 1].Cells["Price"].Value = product.Price;
                    dgvMain.Rows[dgvMain.Rows.Count - 1].Cells["Quantity"].Value = product.Quantity;
                    dgvMain.Rows[dgvMain.Rows.Count - 1].Cells["Total"].Value = product.Total;
                }
            }
        }
        public bool IsGridAlreadyCleared = false;
        private void btnRootCustomer_Click(object sender, EventArgs e)
        {
            if (!IsGridAlreadyCleared)
            {
                NextCustomer();
                dgvMain.Rows.Clear();
            }
            IsGridAlreadyCleared = false;
            foreach (Button button in flpCustomers.Controls)
            {
                button.BackColor = btnRootCustomer.BackColor;
            }
            var products = (from x in Customers where x.ButtonNumber == "ROOT" select x).ToList();
            if (products.Count > 0)
            {
                foreach (var product in products)
                {
                    dgvMain.Rows.Add();
                    dgvMain.Rows[dgvMain.Rows.Count - 1].Cells["Barcode"].Value = product.Barcode;
                    dgvMain.Rows[dgvMain.Rows.Count - 1].Cells["ProductName"].Value = product.ProductName;
                    dgvMain.Rows[dgvMain.Rows.Count - 1].Cells["Price"].Value = product.Price;
                    dgvMain.Rows[dgvMain.Rows.Count - 1].Cells["Quantity"].Value = product.Quantity;
                    dgvMain.Rows[dgvMain.Rows.Count - 1].Cells["Total"].Value = product.Total;
                }
            }
        }
        #endregion
        #region Customer Functions
        private void NextCustomer()
        {
            bool willItSaveToRoot = true;
            foreach (Button btn in flpCustomers.Controls)
            {
                if (btn.BackColor == Color.LightGreen)
                {
                    willItSaveToRoot = false;
                    Customers = (from x in Customers where x.ButtonNumber != btn.Text select x).ToList();
                    for (int i = 0; i < dgvMain.Rows.Count; i++)
                    {
                        Customers.Add(new Product()
                        {
                            Barcode = dgvMain.Rows[i].Cells["Barcode"].Value.ToString(),
                            ButtonNumber = btn.Text,
                            Price = dgvMain.Rows[i].Cells["Price"].Value.ToString(),
                            ProductName = dgvMain.Rows[i].Cells["ProductName"].Value.ToString(),
                            Quantity = dgvMain.Rows[i].Cells["Quantity"].Value.ToString(),
                            Total = dgvMain.Rows[i].Cells["Total"].Value.ToString()
                        });
                    }
                    break;
                }
            }
            if (willItSaveToRoot)
            {
                Customers = (from x in Customers where x.ButtonNumber != "ROOT" select x).ToList();
                for (int i = 0; i < dgvMain.Rows.Count; i++)
                {
                    Customers.Add(new Product()
                    {
                        Barcode = dgvMain.Rows[i].Cells["Barcode"].Value.ToString(),
                        ButtonNumber = "ROOT",
                        Price = dgvMain.Rows[i].Cells["Price"].Value.ToString(),
                        ProductName = dgvMain.Rows[i].Cells["ProductName"].Value.ToString(),
                        Quantity = dgvMain.Rows[i].Cells["Quantity"].Value.ToString(),
                        Total = dgvMain.Rows[i].Cells["Total"].Value.ToString()
                    });
                }
            }
            dgvMain.Rows.Clear();
        }
        private string GiveLowestCustomerQueueNumber()
        {
            if (flpCustomers.Controls.Count == 0)
            {
                return "1";
            }
            for (int i = 1; i <= flpCustomers.Controls.Count + 1; i++)
            {
                var btn = (from Button x in flpCustomers.Controls where x.Text == i.ToString() select x).FirstOrDefault();
                if (btn == null)
                    return i.ToString();
            }
            return "";
        }
        #endregion
        #region Group Events
        private void btnAddGroup_Click(object sender, EventArgs e)
        {
            if (pnlAddGroup.Visible)
                pnlAddGroup.Visible = false;
            else
            {
                tbNewGroupName.Text = "";
                btnDeleteGroup.Visible = false;
                pnlAddGroup.Visible = true;
            }
        }
        #endregion
        #region Group Functions
        public void UndyeAllGroups()
        {
            foreach (Button btn in flpGroups.Controls)
            {
                btn.BackColor = Color.FromArgb(210, 226, 252);
            }
        }
        public void ResetAllGroupButtons()
        {
            int i = 1;
            foreach (Button btn in flpGroupButtons.Controls)
            {
                btn.BackColor = Color.FromArgb(210, 226, 252);
                btn.BackgroundImage = null;
                btn.Name = "Button" + i;
                btn.Text = "";
                i++;
            }
        }
        private void SaveButtons()
        {
            bool willItSaveToRoot = true;
            //update the list before adding the button
            foreach (Button btn in flpGroups.Controls)
            {
                if (btn.BackColor == Color.LightGreen)
                {
                    willItSaveToRoot = false;
                    //ignore the old buttons for this group
                    GroupButtons = (from x in GroupButtons where x.PageName != btn.Text select x).ToList();
                    foreach (Button grpButton in flpGroupButtons.Controls)
                    {
                        if (!string.IsNullOrWhiteSpace(grpButton.Text))
                        {
                            GroupButtons.Add(new GroupButton
                            {
                                B64Image = ConvertImageToBase64(grpButton.BackgroundImage),
                                Barcode = grpButton.Name,
                                Name = grpButton.Text,
                                PageName = btn.Text
                            });
                        }
                    }
                }
            }
            if (willItSaveToRoot)
            {
                GroupButtons = (from x in GroupButtons where x.PageName != "ROOT" select x).ToList();
                foreach (Button grpButton in flpGroupButtons.Controls)
                {
                    if (!string.IsNullOrWhiteSpace(grpButton.Text))
                    {
                        GroupButtons.Add(new GroupButton
                        {
                            B64Image = ConvertImageToBase64(grpButton.BackgroundImage),
                            Barcode = grpButton.Name,
                            Name = grpButton.Text,
                            PageName = "ROOT"
                        });
                    }
                }
            }
        }
        #endregion
        #region  General Button Events
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private bool IsButtonExist(string buttonText)
        {
            foreach (Button btn in flpGroups.Controls)
            {
                if (btn.Text == buttonText)
                {
                    return true;
                }
            }
            GroupPages.Add(new GroupPage
            {
                PageName = buttonText
            });
            return false;
        }
        public void RefreshGroupButtons()
        {
            foreach (Button btn in flpGroups.Controls)
            {
                if (btn.Text.Length > 0)
                    flpGroups.Controls.Remove(btn);
            }
            foreach (var btn in GroupPages)
            {
                if (btn.PageName != "ROOT")
                {
                    var newButton = new Button();
                    newButton.Size = btnRootGroup.Size;
                    newButton.BackgroundImageLayout = ImageLayout.Stretch;
                    newButton.ForeColor = Color.Black;
                    newButton.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
                    newButton.TextAlign = ContentAlignment.MiddleCenter;
                    newButton.FlatStyle = btnRootGroup.FlatStyle;
                    newButton.Text = btn.PageName;
                    newButton.Font = btnRootGroup.Font;
                    newButton.MouseDown += GeneralGroup_MouseDown;
                    newButton.MouseUp += GeneralGroup_MouseUp;
                    flpGroups.Controls.Add(newButton);
                }
            }
            foreach (Button btn in flpGroups.Controls)
            {
                if (btn.Text == HoldedGroupButtonText)
                    btn.PerformClick();
            }
        }
        private void btnNewGroupAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbNewGroupName.Text))
            {
                MessageBox.Show("Grup adı yazmadan devam edilemez!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (!IsButtonExist(tbNewGroupName.Text))
                {
                    if (HoldedGroupButtonText.Length > 0)
                    {
                        foreach (var page in (from x in GroupPages where x.PageName == HoldedGroupButtonText select x))
                        {
                            page.PageName = tbNewGroupName.Text;
                        }
                        foreach (var button in (from x in GroupButtons where x.PageName == HoldedGroupButtonText select x))
                        {
                            button.PageName = tbNewGroupName.Text;
                        }
                        RefreshGroupButtons();
                        HoldedGroupButtonText = "";
                        pnlAddGroup.Visible = false;
                    }
                    else
                    {
                        SaveButtons();
                        foreach (Button btn in flpGroups.Controls)
                        {
                            btn.BackColor = btnRootGroup.BackColor;
                        }
                        var newButton = new Button();
                        newButton.Size = btnRootGroup.Size;
                        newButton.BackColor = Color.LightGreen;
                        newButton.BackgroundImageLayout = ImageLayout.Zoom;
                        newButton.ForeColor = Color.Black;
                        newButton.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
                        newButton.TextAlign = ContentAlignment.MiddleCenter;
                        newButton.FlatStyle = btnRootGroup.FlatStyle;
                        newButton.Text = tbNewGroupName.Text;
                        newButton.Font = btnRootGroup.Font;
                        newButton.MouseDown += GeneralGroup_MouseDown;
                        newButton.MouseUp += GeneralGroup_MouseUp;
                        flpGroups.Controls.Add(newButton);
                        ResetAllGroupButtons();
                        pnlAddGroup.Visible = false;
                    }
                }
                else
                {
                    MessageBox.Show("Bu isimde bir buton zaten mevcut!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }
        private void GroupButtonsGeneral_Click(object sender, EventArgs e)
        {
            var selectedButton = sender as Button;
            if (string.IsNullOrWhiteSpace(selectedButton.Text))
            {
                if (pnlAddNewGroupsButton.Visible)
                {
                    pnlAddNewGroupsButton.Visible = false;
                }
                else
                {
                    pnlAddNewGroupsButton.Visible = true;
                    tbAddNewGroupsButton.Focus();
                }
            }
            else
            {
                AddToGridWithBarcode(selectedButton.Name);
            }
        }
        private void GroupsGeneral_Click(object sender, EventArgs e)
        {
            var selectedButton = sender as Button;
            UndyeAllGroups();
            selectedButton.BackColor = Color.LightGreen;
            ResetAllGroupButtons();
            var SelectedGroupButtons = (from x in GroupButtons where x.PageName == selectedButton.Text select x).ToList();
            foreach (var button in SelectedGroupButtons)
            {
                foreach (Button btn in flpGroupButtons.Controls)
                {
                    if (string.IsNullOrWhiteSpace(btn.Text))
                    {
                        btn.Text = button.Name;
                        btn.Name = button.Barcode;
                        if (!string.IsNullOrWhiteSpace(button.B64Image))
                            btn.BackgroundImage = Base64ToImage(button.B64Image);
                        break;
                    }
                }
            }
        }
        private void ResetAllButtons()
        {
            UndyeAllGroups();
            ResetAllGroupButtons();
        }
        private void btnRootGroup_Click(object sender, EventArgs e)
        {
            ResetAllButtons();
            var RootButtons = (from x in GroupButtons where x.PageName == "ROOT" select x).ToList();
            foreach (var rootButton in RootButtons)
            {
                foreach (Button btn in flpGroupButtons.Controls)
                {
                    if (string.IsNullOrWhiteSpace(btn.Text))
                    {
                        btn.Text = rootButton.Name;
                        btn.Name = rootButton.Barcode;
                        if (!string.IsNullOrWhiteSpace(rootButton.B64Image))
                            btn.BackgroundImage = Base64ToImage(rootButton.B64Image);
                        break;
                    }
                }
            }
        }
        private void btnSaveGroups_Click(object sender, EventArgs e)
        {
            var settings = Helpers.Settings.Setting.GetGroupSettings();
            settings.GroupButtons = GroupButtons;
            settings.GroupPages = GroupPages;
            Helpers.Settings.Setting.Save(settings);
        }
        private void RefreshCurrentPageButtons()
        {
            ResetAllGroupButtons();
            var currentPage = "ROOT";
            foreach (Button btn in flpGroups.Controls)
            {
                if (btn.BackColor == Color.LightGreen)
                {
                    currentPage = btn.Text;
                    break;
                }
            }
            var SelectedGroupButtons = (from x in GroupButtons where x.PageName == currentPage select x).ToList();
            foreach (var button in SelectedGroupButtons)
            {
                foreach (Button btn in flpGroupButtons.Controls)
                {
                    if (string.IsNullOrWhiteSpace(btn.Text))
                    {
                        btn.Text = button.Name;
                        btn.Name = button.Barcode;
                        btn.BackgroundImage = string.IsNullOrWhiteSpace(button.B64Image) ? null : Base64ToImage(button.B64Image);
                        break;
                    }
                }
            }
        }
        private async void tbAddNewGroupsButton_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dgvBarcodeSearch.Rows.Clear();
                if (!string.IsNullOrWhiteSpace(tbAddNewGroupsButton.Texts))
                {
                    var setting = Setting.Get();
                    await using var conn = new SqlConnection(setting.Sql.ConnectionString());
                    conn.Open();
                    var sqlBuilder = new SqlBuilder();
                    sqlBuilder.Select($"""
                                        BARCODE,NAME,B64IMAGE
                                        """);
                    sqlBuilder.Where($"""
                                        BARCODE=@BARCODE OR NAME LIKE '%'+@BARCODE+'%'
                                        """);
                    var param = new
                    {
                        BARCODE = tbAddNewGroupsButton.Texts
                    };
                    var builderTemp = sqlBuilder.AddTemplate("SELECT /**select**/ FROM PRODUCTS /**where**/");
                    var products = conn.QueryAsync<ProductNameImageDto>(builderTemp.RawSql, param).Result.ToList();
                    if (products.Any())
                    {
                        foreach (var prod in products)
                        {
                            dgvBarcodeSearch.Rows.Add(prod.BARCODE, prod.NAME, prod.B64IMAGE);
                        }
                    }
                }
                if (dgvBarcodeSearch.Rows.Count == 1)
                {
                    var barcode = dgvBarcodeSearch.Rows[0].Cells["IBARCODE"].Value.ToString();
                    foreach (Button btn in flpGroupButtons.Controls)
                    {
                        if (btn.Name == barcode)
                        {
                            MessageBox.Show("Bu ürün sayfada zaten mevcut.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }
                    var currentPage = "ROOT";
                    foreach (Button btn in flpGroups.Controls)
                    {
                        if (btn.BackColor == Color.LightGreen)
                        {
                            currentPage = btn.Text;
                            break;
                        }
                    }
                    var b64Image = (dgvBarcodeSearch.Rows[0].Cells["IB64IMAGE"].Value ?? "").ToString();
                    var name = dgvBarcodeSearch.Rows[0].Cells["INAME"].Value.ToString();
                    if (HoldedButtonsBarcode.Length > 0)
                    {
                        foreach (var btn in (from x in GroupButtons where x.Barcode == HoldedButtonsBarcode && x.PageName == currentPage select x))
                        {
                            btn.B64Image = b64Image;
                            btn.Name = name;
                            btn.Barcode = barcode;
                            btn.PageName = currentPage;
                        }
                        HoldedButtonsBarcode = "";
                    }
                    else
                    {
                        var buttonToAdd = new GroupButton();
                        buttonToAdd.B64Image = b64Image;
                        buttonToAdd.Name = name;
                        buttonToAdd.Barcode = barcode;
                        buttonToAdd.PageName = currentPage;
                        GroupButtons.Add(buttonToAdd);
                    }
                    dgvBarcodeSearch.Rows.Clear();
                    pnlAddNewGroupsButton.Visible = false;
                    tbAddNewGroupsButton.Texts = "";
                    RefreshCurrentPageButtons();
                }
            }
        }
        #endregion
        #region Form Events
        private void Sales_Load(object sender, EventArgs e)
        {
            cbPriceType.SelectedIndex = 0;
            tbSearch.Focus();
            dgvMain.Columns.Insert(3, new DataGridViewImageColumn()
            {
                Image = Properties.Resources._24pxMinus,
                Name = "MINUS",
                HeaderText = "",
                FillWeight = 4,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
            dgvMain.Columns.Insert(5, new DataGridViewImageColumn()
            {
                Image = Properties.Resources._24pxPlus,
                Name = "PLUS",
                HeaderText = "",
                FillWeight = 4,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
            dgvMain.Columns.Insert(dgvMain.Columns.Count, new DataGridViewImageColumn()
            {
                Image = Properties.Resources._24pxClose,
                Name = "DELETE",
                HeaderText = "",
                FillWeight = 5,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
            dgvMain.Columns["DELETE"].FillWeight = 5;
            dgvMain.Columns["PLUS"].FillWeight = 4;
            dgvMain.Columns["MINUS"].FillWeight = 4;
            var groupSettings = Helpers.Settings.Setting.GetGroupSettings();
            GroupButtons = groupSettings.GroupButtons ?? new List<GroupButton>();
            GroupPages = groupSettings.GroupPages ?? new List<GroupPage>();
            foreach (var btn in GroupPages)
            {
                if (btn.PageName != "ROOT")
                {
                    var newButton = new Button();
                    newButton.Size = btnRootGroup.Size;
                    newButton.BackgroundImageLayout = ImageLayout.Stretch;
                    newButton.ForeColor = Color.Black;
                    newButton.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
                    newButton.TextAlign = ContentAlignment.MiddleCenter;
                    newButton.FlatStyle = btnRootGroup.FlatStyle;
                    newButton.Text = btn.PageName;
                    newButton.Font = btnRootGroup.Font;
                    newButton.MouseDown += GeneralGroup_MouseDown;
                    newButton.MouseUp += GeneralGroup_MouseUp;
                    flpGroups.Controls.Add(newButton);
                }
            }
            ResetAllButtons();
            var RootButtons = (from x in GroupButtons where x.PageName == "ROOT" select x).ToList();
            foreach (var rootButton in RootButtons)
            {
                foreach (Button btn in flpGroupButtons.Controls)
                {
                    if (string.IsNullOrWhiteSpace(btn.Text))
                    {
                        btn.Text = rootButton.Name;
                        btn.Name = rootButton.Barcode;
                        btn.BackgroundImage = Base64ToImage(rootButton.B64Image);
                        break;
                    }
                }
            }
            btnRootGroup.PerformClick();
        }
        private void Sales_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void dgvMain_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvMain.Columns["DELETE"].Index)
                dgvMain.Rows.Remove(dgvMain.Rows[e.RowIndex]);
            else if (e.ColumnIndex == dgvMain.Columns["MINUS"].Index)
            {
                if (Convert.ToInt32(dgvMain.Rows[e.RowIndex].Cells["Quantity"].Value.ToString()) > 1)
                {
                    dgvMain.Rows[e.RowIndex].Cells["Quantity"].Value = (Convert.ToDecimal(dgvMain.Rows[e.RowIndex].Cells["Quantity"].Value.ToString()) - 1).ToString();
                    dgvMain.Rows[e.RowIndex].Cells["Total"].Value = decimal.Round(Convert.ToDecimal(dgvMain.Rows[e.RowIndex].Cells["Price"].Value.ToString()) * Convert.ToDecimal(dgvMain.Rows[e.RowIndex].Cells["Quantity"].Value.ToString()), 2, MidpointRounding.AwayFromZero).ToString();
                    CalculateAll();
                }
            }
            else if (e.ColumnIndex == dgvMain.Columns["PLUS"].Index)
            {
                dgvMain.Rows[e.RowIndex].Cells["QUANTITY"].Value = (Convert.ToDecimal(dgvMain.Rows[e.RowIndex].Cells["QUANTITY"].Value.ToString()) + 1).ToString();
                dgvMain.Rows[e.RowIndex].Cells["Total"].Value = (Convert.ToDecimal(dgvMain.Rows[e.RowIndex].Cells["Price"].Value.ToString()) * Convert.ToDecimal(dgvMain.Rows[e.RowIndex].Cells["QUANTITY"].Value.ToString())).ToString();
                CalculateAll();
            }
        }
        #endregion
        #region Functions
        private string ConvertImageToBase64(Image? img)
        {
            if (img is null)
                return "";
            using (Image image = new Bitmap(img))
            {
                using (MemoryStream m = new MemoryStream())
                {
                    image.Save(m, ImageFormat.Png);
                    byte[] imageBytes = m.ToArray();
                    string base64String = Convert.ToBase64String(imageBytes);
                    return base64String;
                }
            }
        }
        public Image Base64ToImage(string base64String)
        {
            // Convert base 64 string to byte[]
            byte[] imageBytes = Convert.FromBase64String(base64String);
            // Convert byte[] to Image
            using (var ms = new MemoryStream(imageBytes, 0, imageBytes.Length))
            {
                Image image = Image.FromStream(ms, true);
                return image;
            }
        }
        private async void AddToGridWithBarcode(string barcode)
        {
            var indexOfExistingRow = -1;
            for (int i = 0; i < dgvMain.Rows.Count; i++)
            {
                if (dgvMain.Rows[i].Cells["Barcode"].Value.ToString() == barcode)
                {
                    indexOfExistingRow = i;
                    break;
                }
            }
            if (indexOfExistingRow > -1)
            {
                dgvMain.Rows[indexOfExistingRow].Cells["Quantity"].Value = (Convert.ToInt32(dgvMain.Rows[indexOfExistingRow].Cells["Quantity"].Value.ToString()) + 1).ToString();
                dgvMain.Rows[indexOfExistingRow].Cells["Total"].Value = decimal.Round((Convert.ToDecimal(dgvMain.Rows[indexOfExistingRow].Cells["Price"].Value.ToString()) * Convert.ToDecimal(dgvMain.Rows[indexOfExistingRow].Cells["Quantity"].Value.ToString())), 2, MidpointRounding.AwayFromZero).ToString();
                CalculateAll();
                return;
            }
            var setting = Setting.Get();
            await using var conn = new SqlConnection(setting.Sql.ConnectionString());
            var sqlBuilder = new SqlBuilder();
            sqlBuilder.Select($"ID,BARCODE,NAME,SALEPRICE{(cbPriceType.Text == "1" ? "" : cbPriceType.Text)} AS SALEPRICE");
            sqlBuilder.Where("BARCODE=@BARCODE");
            var param = new { BARCODE = barcode };
            var builderTemp = sqlBuilder.AddTemplate("SELECT /**select**/ FROM PRODUCTS /**where**/");
            conn.Open();
            var result = conn.QueryAsync<SaleProduct>(builderTemp.RawSql, param).Result.ToList();
            if (result.Any())
            {
                dgvMain.Rows.Add();
                dgvMain.Rows[dgvMain.Rows.Count - 1].Cells["Barcode"].Value = result[0].BARCODE;
                dgvMain.Rows[dgvMain.Rows.Count - 1].Cells["ProductName"].Value = result[0].NAME;
                dgvMain.Rows[dgvMain.Rows.Count - 1].Cells["Price"].Value = result[0].SALEPRICE;
                dgvMain.Rows[dgvMain.Rows.Count - 1].Cells["Quantity"].Value = "1";
                dgvMain.Rows[dgvMain.Rows.Count - 1].Cells["Total"].Value = decimal.Round((Convert.ToDecimal(dgvMain.Rows[dgvMain.Rows.Count - 1].Cells["Price"].Value.ToString()) * Convert.ToDecimal(dgvMain.Rows[dgvMain.Rows.Count - 1].Cells["Quantity"].Value.ToString())), 2, MidpointRounding.AwayFromZero).ToString();
            }
            CalculateAll();
        }
        public async void CalculateAll()
        {
            decimal totalTL = 0;
            foreach (DataGridViewRow row in dgvMain.Rows)
            {
                totalTL += Convert.ToDecimal(row.Cells["Total"].Value.ToString());
            }
            btnTotalPrice.Text = totalTL.ToString() + "₺";
            if (btnTotalPrice.Visible)
            {
                btnDolarTotalPrice.Text = decimal.Round((totalTL / Mainpage.USD), 2, MidpointRounding.AwayFromZero).ToString() + "$";
                btnEuroTotalPrice.Text = decimal.Round((totalTL / Mainpage.EURO), 2, MidpointRounding.AwayFromZero).ToString() + "€";
            }
        }
        #endregion
        #endregion
        private void btnClearGrid_Click(object sender, EventArgs e)
        {
            dgvMain.Rows.Clear();
            btnTotalPrice.Text = "";
            btnEuroTotalPrice.Text = "";
            btnDolarTotalPrice.Text = "";
            tbTakenMoney.Text = "0";
            lblChangeMoney.Text = "";
            cbFree.CheckState = CheckState.Unchecked;
            cbReturn.CheckState = CheckState.Unchecked;
            cbPriceType.SelectedIndex = 0;
        }
        private void btnShowPrices_Click(object sender, EventArgs e)
        {
            btnTotalPrice.Visible = !btnTotalPrice.Visible;
            btnEuroTotalPrice.Visible = !btnEuroTotalPrice.Visible;
            btnDolarTotalPrice.Visible = !btnDolarTotalPrice.Visible;
            if (btnTotalPrice.Visible)
            {
                CalculateAll();
            }
        }
       
        private void btnClearTakenMoney_Click(object sender, EventArgs e)
        {
            tbTakenMoney.Text = "0";
            lblChangeMoney.Text = "";
        }
        private void btnTL_Click(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            tbTakenMoney.Text = (Convert.ToInt32(tbTakenMoney.Text) + Convert.ToInt32(btn.Text.Replace("₺", ""))).ToString();
            RefreshChange();
        }
        private void RefreshChange()
        {
            lblChangeMoney.Text = decimal.Round(Convert.ToInt32(tbTakenMoney.Text) - Convert.ToDecimal(btnTotalPrice.Text.Replace("₺", "")), 2, MidpointRounding.AwayFromZero).ToString();
        }
        private async void cbPriceType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dgvMain.Rows.Count > 0)
            {
                var barcodeList = new List<string>();
                foreach (DataGridViewRow row in dgvMain.Rows)
                {
                    barcodeList.Add((row.Cells["Barcode"].Value ?? "").ToString());
                }
                barcodeList = (from x in barcodeList where x.Length > 0 select x).ToList();
                var strBarcodeList = string.Join(",", barcodeList);
                var setting = Setting.Get();
                await using var conn = new SqlConnection(setting.Sql.ConnectionString());
                var sqlBuilder = new SqlBuilder();
                sqlBuilder.Select($"BARCODE,SALEPRICE{(cbPriceType.Text == "1" ? "" : cbPriceType.Text)} AS SALEPRICE");
                sqlBuilder.Where("BARCODE IN (@BARCODE)");
                var param = new { BARCODE = strBarcodeList };
                var builderTemp = sqlBuilder.AddTemplate("SELECT /**select**/ FROM PRODUCTS /**where**/");
                conn.Open();
                var result = conn.QueryAsync<SaleProduct>(builderTemp.RawSql, param).Result.ToList();
                if (result.Any())
                {
                    foreach (DataGridViewRow row in dgvMain.Rows)
                    {
                        row.Cells["Price"].Value = (from x in result where x.BARCODE == row.Cells["Barcode"].Value.ToString() select x.SALEPRICE).First().ToString();
                        row.Cells["Total"].Value = decimal.Round(Convert.ToDecimal(row.Cells["Quantity"].Value.ToString()) * Convert.ToDecimal(row.Cells["Price"].Value.ToString()), 2, MidpointRounding.AwayFromZero);
                    }
                    CalculateAll();
                }
            }
        }
        private void dgvBarcodeSearch_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!(e.RowIndex > -1 && e.RowIndex < dgvBarcodeSearch.Rows.Count))
                return;
            var barcode = dgvBarcodeSearch.Rows[e.RowIndex].Cells["IBARCODE"].Value.ToString();
            foreach (Button btn in flpGroupButtons.Controls)
            {
                if (btn.Name == barcode)
                {
                    MessageBox.Show("Bu ürün sayfada zaten mevcut.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            var currentPage = "ROOT";
            foreach (Button btn in flpGroups.Controls)
            {
                if (btn.BackColor == Color.LightGreen)
                {
                    currentPage = btn.Text;
                    break;
                }
            }
            var b64Image = (dgvBarcodeSearch.Rows[e.RowIndex].Cells["IB64IMAGE"].Value ?? "").ToString();
            var name = dgvBarcodeSearch.Rows[e.RowIndex].Cells["INAME"].Value.ToString();
            if (HoldedButtonsBarcode.Length > 0)
            {
                foreach (var btn in (from x in GroupButtons where x.Barcode == HoldedButtonsBarcode && x.PageName == currentPage select x))
                {
                    btn.B64Image = b64Image;
                    btn.Name = name;
                    btn.Barcode = barcode;
                    btn.PageName = currentPage;
                }
                HoldedButtonsBarcode = "";
            }
            else
            {
                var buttonToAdd = new GroupButton();
                buttonToAdd.B64Image = b64Image;
                buttonToAdd.Name = name;
                buttonToAdd.Barcode = barcode;
                buttonToAdd.PageName = currentPage;
                GroupButtons.Add(buttonToAdd);
            }
            dgvBarcodeSearch.Rows.Clear();
            pnlAddNewGroupsButton.Visible = false;
            tbAddNewGroupsButton.Texts = "";
            RefreshCurrentPageButtons();
        }
        private void rtbSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrWhiteSpace(tbSearch.Text))
                {
                    AddToGridWithBarcode(tbSearch.Text);
                    tbSearch.Text = "";
                }
                tbSearch.Focus();
            }
        }
        private void btnHidepnlAddNewGroupsButton_Click(object sender, EventArgs e)
        {
            pnlAddNewGroupsButton.Visible = false;
            tbAddNewGroupsButton.Texts = "";
            dgvBarcodeSearch.Rows.Clear();
        }
        private void GroupButtonsGeneral_MouseDown(object sender, MouseEventArgs e)
        {
            tmrMouse.Enabled = true;
        }
        public string HoldedButtonsBarcode = "";
        private void GroupButtonsGeneral_MouseUp(object sender, MouseEventArgs e)
        {
            var selectedButton = sender as Button;
            tmrMouse.Enabled = false;
            if (string.IsNullOrWhiteSpace(selectedButton.Text) || isMouseHold)
            {
                if (isMouseHold)
                {
                    HoldedButtonsBarcode = selectedButton.Name;
                }
                isMouseHold = false;
                if (pnlAddNewGroupsButton.Visible)
                {
                    pnlAddNewGroupsButton.Visible = false;
                }
                else
                {
                    pnlAddNewGroupsButton.Visible = true;
                    tbAddNewGroupsButton.Focus();
                }
            }
            else
            {
                AddToGridWithBarcode(selectedButton.Name);
            }
            isMouseHold = false;
        }
        public bool isMouseHold = false;
        private void tmrMouse_Tick(object sender, EventArgs e)
        {
            isMouseHold = true;
        }
        private void tbNewGroupName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnNewGroupAdd.PerformClick();
            }
        }
        private void GeneralGroup_MouseDown(object sender, MouseEventArgs e)
        {
            UndyeAllGroups();
            var selectedButton = sender as Button;
            selectedButton.BackColor = Color.LightGreen;
            tmrMouse.Enabled = true;
        }
        public string HoldedGroupButtonText = "";
        private void GeneralGroup_MouseUp(object sender, MouseEventArgs e)
        {
            var selectedButton = sender as Button;
            tmrMouse.Enabled = false;
            if (isMouseHold)
            {
                tbNewGroupName.Text = selectedButton.Text;
                HoldedGroupButtonText = selectedButton.Text;
                pnlAddGroup.Visible = true;
                btnDeleteGroup.Visible = true;
                isMouseHold = false;
            }
            else
            {
                ResetAllGroupButtons();
                var SelectedGroupButtons = (from x in GroupButtons where x.PageName == selectedButton.Text select x).ToList();
                foreach (var button in SelectedGroupButtons)
                {
                    foreach (Button btn in flpGroupButtons.Controls)
                    {
                        if (string.IsNullOrWhiteSpace(btn.Text))
                        {
                            btn.Text = button.Name;
                            btn.Name = button.Barcode;
                            if (!string.IsNullOrWhiteSpace(button.B64Image))
                                btn.BackgroundImage = Base64ToImage(button.B64Image);
                            break;
                        }
                    }
                }
            }
        }
        private void pbClearSearch_Click(object sender, EventArgs e)
        {
            tbSearch.Text = "";
        }
        private void dgvMain_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            dgvMain.ClearSelection();
        }
        private void dgvMain_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            dgvMain.ClearSelection();
        }
        private void btnSearchProduct_Click(object sender, EventArgs e)
        {
            var forms = Application.OpenForms.Cast<Form>().Where(x => x.Name == "ProdDet");
            if (forms.Any())
            {
                MessageBox.Show("Bu pencere zaten açık!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                var pd = new ProductDetails(cbPriceType.Text);
                pd.Name = "ProdDet";
                pd.Show();
            }
        }
        private void ClearAfterPayment()
        {
            btnClearGrid.PerformClick();
            foreach (Button btn in flpCustomers.Controls)
            {
                if (btn.BackColor == Color.LightGreen)
                {
                    flpCustomers.Controls.Remove(btn);
                    IsGridAlreadyCleared = true;
                    break;
                }
            }
            btnRootCustomer.PerformClick();
        }
        public int LastSelectedCustomerID = 0;
        public async Task<bool> AddFicheHead(string paymentType, string ficheRef, int ficheType, SqlTransaction trn, SqlConnection conn, decimal totalPrice)
        {
            try
            {
                var settings = Setting.Get();
                var totalPriceUSD = decimal.Round((totalPrice / Mainpage.USD), 2, MidpointRounding.AwayFromZero);
                var totalPriceEURO = decimal.Round((totalPrice / Mainpage.EURO), 2, MidpointRounding.AwayFromZero);
                var sB = new SqlBuilder();//sB == sqlBuilder
                var bT = sB.AddTemplate(
                    $"""
                INSERT INTO FICHES(FICHEREF,FICHETYPE,CUSTOMERID,TOTALPRICE,USDTOTALPRICE,EUROTOTALPRICE,CREATEDBY,CREATEDATE,ISCUSTORVEND,PAYMENTTYPE)
                VALUES (@FICHEREF,@FICHETYPE,@CUSTOMERID,@TOTALPRICE,@USDTOTALPRICE,@EUROTOTALPRICE,@CREATEDBY,GETDATE(),'CUST',@PAYMENTTYPE)
                """
                    );
                var param = new
                {
                    FICHEREF = ficheRef,
                    FICHETYPE = ficheType,
                    CUSTOMERID = LastSelectedCustomerID,
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
        public async Task<bool> AddFicheLines(int ficheType, string ficheRef, SqlTransaction trn, SqlConnection conn)
        {
            try
            {
                var settings = Setting.Get();
                foreach (DataGridViewRow row in dgvMain.Rows)
                {
                    var barcode = row.Cells["Barcode"].Value.ToString();
                    var sB = new SqlBuilder();
                    var bT = sB.AddTemplate(
                        $"""
                            SELECT ID,STOCK,BUYPRICE FROM STOCKS WHERE PRODID = (SELECT ID FROM PRODUCTS WHERE BARCODE = @BARCODE) AND STOCK>0 ORDER BY CREATEDATE
                            """
                        );
                    var stockParam = new
                    {
                        BARCODE = barcode
                    };
                    var stocks = conn.QueryAsync<ProdStocks>(bT.RawSql, stockParam, trn).Result.ToList();
                    var quantity = Convert.ToDecimal(row.Cells["Quantity"].Value.ToString());
                    decimal totalStock = stocks.Sum(x => x.STOCK);
                    decimal totalProfit = 0;
                    decimal sellPrice = Convert.ToDecimal(row.Cells["Price"].Value.ToString());
                    if (ficheType == 2 || ficheType == 3)
                        sellPrice = 0;
                    int refundMarker = 1;
                    if (ficheType == 1)
                        refundMarker = -1;
                    if (stocks.Any())
                    {
                        if (quantity <= stocks[0].STOCK)
                        {
                            var lineProfit = decimal.Round(refundMarker * (quantity * (sellPrice - stocks[0].BUYPRICE)), 2, MidpointRounding.AwayFromZero);
                            var lineTotalPrice = decimal.Round(sellPrice * quantity, 2, MidpointRounding.AwayFromZero);
                            var lineTotalPriceUSD = decimal.Round(lineTotalPrice / Mainpage.USD, 2, MidpointRounding.AwayFromZero);
                            var lineTotalPriceEURO = decimal.Round(lineTotalPrice / Mainpage.EURO, 2, MidpointRounding.AwayFromZero);
                            //INSERT LINES
                            sB = new SqlBuilder();
                            bT = sB.AddTemplate(
                                $"""
                                               INSERT INTO FICHELINES(FICHEREF,BARCODE,QUANTITY,UNITPRICE,TOTALPRICE,USDTOTALPRICE,EUROTOTALPRICE,CURRENCY,CREATEDBY,CREATEDATE,PROFIT)
                                               VALUES(@FICHEREF,@BARCODE,@QUANTITY,@UNITPRICE,@TOTALPRICE,@USDTOTALPRICE,@EUROTOTALPRICE,@CURRENCY,@CREATEDBY,GETDATE(),@PROFIT)
                                            """
                                );
                            var prmLine = new
                            {
                                FICHEREF = ficheRef,
                                BARCODE = barcode,
                                QUANTITY = quantity,
                                UNITPRICE = sellPrice,
                                TOTALPRICE = lineTotalPrice,
                                USDTOTALPRICE = lineTotalPriceUSD,
                                EUROTOTALPRICE = lineTotalPriceEURO,
                                CURRENCY = "TL",
                                CREATEDBY = settings.LastSuccesfullyLoggedUser,
                                PROFIT = lineProfit
                            };
                            var snc = conn.ExecuteAsync(bT.RawSql, prmLine, trn).Result;
                            //UPDATE STOCK
                            if (snc > 0)
                            {
                                sB = new SqlBuilder();
                                bT = sB.AddTemplate(
                                    $"""
                                               UPDATE STOCKS SET STOCK = @STOCK WHERE ID = @ID
                                            """
                                    );
                                var prmStock = new
                                {
                                    STOCK = stocks[0].STOCK - quantity,
                                    ID = stocks[0].ID
                                };
                                snc = conn.ExecuteAsync(bT.RawSql, prmStock, trn).Result;
                                if (snc == 0)
                                    throw new Exception();
                            }
                        }
                        else if (quantity <= totalStock)
                        {
                            var remainingQuantity = quantity;
                            foreach (var stock in stocks)
                            {
                                if (remainingQuantity <= stock.STOCK)
                                {
                                    var lineProfit = decimal.Round(refundMarker * (remainingQuantity * (sellPrice - stock.BUYPRICE)), 2, MidpointRounding.AwayFromZero);
                                    var lineTotalPrice = decimal.Round(sellPrice * remainingQuantity, 2, MidpointRounding.AwayFromZero);
                                    var lineTotalPriceUSD = decimal.Round(lineTotalPrice / Mainpage.USD, 2, MidpointRounding.AwayFromZero);
                                    var lineTotalPriceEURO = decimal.Round(lineTotalPrice / Mainpage.EURO, 2, MidpointRounding.AwayFromZero);
                                    //INSERT LINES
                                    sB = new SqlBuilder();
                                    bT = sB.AddTemplate(
                                        $"""
                                               INSERT INTO FICHELINES(FICHEREF,BARCODE,QUANTITY,UNITPRICE,TOTALPRICE,USDTOTALPRICE,EUROTOTALPRICE,CURRENCY,CREATEDBY,CREATEDATE,PROFIT)
                                               VALUES(@FICHEREF,@BARCODE,@QUANTITY,@UNITPRICE,@TOTALPRICE,@USDTOTALPRICE,@EUROTOTALPRICE,@CURRENCY,@CREATEDBY,GETDATE(),@PROFIT)
                                            """
                                        );
                                    var prmLine = new
                                    {
                                        FICHEREF = ficheRef,
                                        BARCODE = barcode,
                                        QUANTITY = remainingQuantity,
                                        UNITPRICE = sellPrice,
                                        TOTALPRICE = lineTotalPrice,
                                        USDTOTALPRICE = lineTotalPriceUSD,
                                        EUROTOTALPRICE = lineTotalPriceEURO,
                                        CURRENCY = "TL",
                                        CREATEDBY = settings.LastSuccesfullyLoggedUser,
                                        PROFIT = lineProfit
                                    };
                                    var snc = conn.ExecuteAsync(bT.RawSql, prmLine, trn).Result;
                                    if (snc > 0)
                                    {
                                        //UPDATE STOCK
                                        sB = new SqlBuilder();
                                        bT = sB.AddTemplate(
                                            $"""
                                               UPDATE STOCKS SET STOCK = @STOCK WHERE ID = @ID
                                            """
                                            );
                                        var prmStock = new
                                        {
                                            STOCK = stock.STOCK - remainingQuantity,
                                            ID = stock.ID
                                        };
                                        snc = conn.ExecuteAsync(bT.RawSql, prmStock, trn).Result;
                                        if (snc == 0)
                                            throw new Exception();
                                    }
                                    else
                                        throw new Exception();
                                }
                                else
                                {
                                    remainingQuantity -= stock.STOCK;
                                    var lineProfit = decimal.Round(refundMarker * (stock.STOCK * (sellPrice - stock.BUYPRICE)), 2, MidpointRounding.AwayFromZero);
                                    var lineTotalPrice = decimal.Round(sellPrice * stock.STOCK, 2, MidpointRounding.AwayFromZero);
                                    var lineTotalPriceUSD = decimal.Round(lineTotalPrice / Mainpage.USD, 2, MidpointRounding.AwayFromZero);
                                    var lineTotalPriceEURO = decimal.Round(lineTotalPrice / Mainpage.EURO, 2, MidpointRounding.AwayFromZero);
                                    //INSERT LINES
                                    sB = new SqlBuilder();
                                    bT = sB.AddTemplate(
                                        $"""
                                               INSERT INTO FICHELINES(FICHEREF,BARCODE,QUANTITY,UNITPRICE,TOTALPRICE,USDTOTALPRICE,EUROTOTALPRICE,CURRENCY,CREATEDBY,CREATEDATE,PROFIT)
                                               VALUES(@FICHEREF,@BARCODE,@QUANTITY,@UNITPRICE,@TOTALPRICE,@USDTOTALPRICE,@EUROTOTALPRICE,@CURRENCY,@CREATEDBY,GETDATE(),@PROFIT)
                                            """
                                        );
                                    var prmLine = new
                                    {
                                        FICHEREF = ficheRef,
                                        BARCODE = barcode,
                                        QUANTITY = stock.STOCK,
                                        UNITPRICE = sellPrice,
                                        TOTALPRICE = lineTotalPrice,
                                        USDTOTALPRICE = lineTotalPriceUSD,
                                        EUROTOTALPRICE = lineTotalPriceEURO,
                                        CURRENCY = "TL",
                                        CREATEDBY = settings.LastSuccesfullyLoggedUser,
                                        PROFIT = lineProfit
                                    };
                                    var snc = conn.ExecuteAsync(bT.RawSql, prmLine, trn).Result;
                                    if (snc > 0)
                                    {
                                        //UPDATE STOCK
                                        sB = new SqlBuilder();
                                        bT = sB.AddTemplate(
                                            $"""
                                               UPDATE STOCKS SET STOCK = 0 WHERE ID = @ID
                                            """
                                            );
                                        var prmStock = new
                                        {
                                            ID = stock.ID
                                        };
                                        snc = conn.ExecuteAsync(bT.RawSql, prmStock, trn).Result;
                                        if (snc == 0)
                                            throw new Exception();
                                    }
                                    else
                                        throw new Exception();
                                }
                            }
                            throw new Exception();
                        }
                        else
                        {
                            MessageBox.Show($"{row.Cells["Barcode"].Value.ToString()} barkodlu ürün için stok yetersiz. Kontrol ederek tekrar deneyin.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Stoklara erişilemiyor yada {row.Cells["Barcode"].Value.ToString()} barkodlu ürün için stok bulunamadı. Kontrol ederek tekrar deneyin.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Fiş kaydedilemedi. Bağlantınızı kontrol ederek tekrar deneyin.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private async void btnCash_Click(object sender, EventArgs e)
        {
            // 1-2-4     1:Refund   2:Free  3:Refund-Free  4:Sale 
            SqlTransaction trn = null;
            var settings = Setting.Get();
            await using var conn = new SqlConnection(settings.Sql.ConnectionString());
            conn.Open();
            trn = conn.BeginTransaction();
            int ficheType = cbReturn.Checked ? (cbFree.Checked ? 3 : 1) : cbFree.Checked ? 2 : 4;
            CalculateAll();
            var ficheRef = DateTime.Now.ToString("ddMMyyyyHHmmssfff");
            var totalPrice = decimal.Round(Convert.ToDecimal(btnTotalPrice.Text.Replace("₺", "")), 2, MidpointRounding.AwayFromZero);
            var headRes = AddFicheHead("NAKİT", ficheRef, ficheType, trn, conn, totalPrice).Result;
            if (headRes)
            {
                var lineRes = AddFicheLines(ficheType, ficheRef, trn, conn).Result;
                if (lineRes)
                {
                    ClearAfterPayment();
                    trn.Commit();
                }
                else
                {
                    trn.Rollback();
                    return;
                }
            }
            else
            {
                MessageBox.Show("Fiş kaydedilemedi. Bağlantınızı kontrol ederek tekrar deneyin.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                trn.Rollback();
                return;
            }
        }
        private async void btnCard_Click(object sender, EventArgs e)
        {
            // 1-2-4     1:Refund   2:Free  3:Refund-Free  4:Sale 
            SqlTransaction trn = null;
            var settings = Setting.Get();
            await using var conn = new SqlConnection(settings.Sql.ConnectionString());
            conn.Open();
            trn = conn.BeginTransaction();
            int ficheType = cbReturn.Checked ? (cbFree.Checked ? 3 : 1) : cbFree.Checked ? 2 : 4;
            CalculateAll();
            var ficheRef = DateTime.Now.ToString("ddMMyyyyHHmmssfff");
            var totalPrice = decimal.Round(Convert.ToDecimal(btnTotalPrice.Text.Replace("₺", "")), 2, MidpointRounding.AwayFromZero);
            var headRes = AddFicheHead("KART", ficheRef, ficheType, trn, conn, totalPrice).Result;
            if (headRes)
            {
                var lineRes = AddFicheLines(ficheType, ficheRef, trn, conn).Result;
                if (lineRes)
                {
                    ClearAfterPayment();
                    trn.Commit();
                }
                else
                {
                    trn.Rollback();
                    return;
                }
            }
            else
            {
                MessageBox.Show("Fiş kaydedilemedi. Bağlantınızı kontrol ederek tekrar deneyin.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                trn.Rollback();
                return;
            }
        }
        private async void btnOther_Click(object sender, EventArgs e)
        {
            // 1-2-4     1:Refund   2:Free  3:Refund-Free  4:Sale 
            SqlTransaction trn = null;
            var settings = Setting.Get();
            await using var conn = new SqlConnection(settings.Sql.ConnectionString());
            conn.Open();
            trn = conn.BeginTransaction();
            int ficheType = cbReturn.Checked ? (cbFree.Checked ? 3 : 1) : cbFree.Checked ? 2 : 4;
            CalculateAll();
            var ficheRef = DateTime.Now.ToString("ddMMyyyyHHmmssfff");
            var totalPrice = decimal.Round(Convert.ToDecimal(btnTotalPrice.Text.Replace("₺", "")), 2, MidpointRounding.AwayFromZero);
            var headRes = AddFicheHead("DİĞER", ficheRef, ficheType, trn, conn, totalPrice).Result;
            if (headRes)
            {
                var lineRes = AddFicheLines(ficheType, ficheRef, trn, conn).Result;
                if (lineRes)
                {
                    ClearAfterPayment();
                    trn.Commit();
                }
                else
                {
                    trn.Rollback();
                    return;
                }
            }
            else
            {
                MessageBox.Show("Fiş kaydedilemedi. Bağlantınızı kontrol ederek tekrar deneyin.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                trn.Rollback();
                return;
            }
        }
        private async void btnMulti_Click(object sender, EventArgs e)
        {
            CalculateAll();
            var totalPrice = decimal.Round(Convert.ToDecimal(btnTotalPrice.Text.Replace("₺", "")), 2, MidpointRounding.AwayFromZero);
            using (var pm = new PayMulti(totalPrice))
            {
                var dr = pm.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    var cardAmount = pm.cardAmount;
                    var cashAmount = pm.cashAmount;
                    SqlTransaction trn = null;
                    var settings = Setting.Get();
                    await using var conn = new SqlConnection(settings.Sql.ConnectionString());
                    conn.Open();
                    trn = conn.BeginTransaction();
                    int ficheType = cbReturn.Checked ? (cbFree.Checked ? 3 : 1) : cbFree.Checked ? 2 : 4;
                    var ficheRef = DateTime.Now.ToString("ddMMyyyyHHmmssfff");
                    var headResCard = AddFicheHead("KART", ficheRef, ficheType, trn, conn, cardAmount).Result;
                    var headResCash = AddFicheHead("NAKİT", ficheRef, ficheType, trn, conn, cashAmount).Result;
                    if (headResCard && headResCash)
                    {
                        var lineRes = AddFicheLines(ficheType, ficheRef, trn, conn).Result;
                        if (lineRes)
                        {
                            ClearAfterPayment();
                            trn.Commit();
                        }
                        else
                        {
                            trn.Rollback();
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Fiş kaydedilemedi. Bağlantınızı kontrol ederek tekrar deneyin.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        trn.Rollback();
                        return;
                    }
                }
            }
        }
        private void btnParts_Click(object sender, EventArgs e)
        {
            CalculateAll();
            var totalPrice = decimal.Round(Convert.ToDecimal(btnTotalPrice.Text.Replace("₺", "")), 2, MidpointRounding.AwayFromZero);
            var dt = new DataTable();
            for (int i = 0; i < 5; i++)
            {
                dt.Columns.Add();
            }
            foreach (DataGridViewRow row in dgvMain.Rows)
            {
                dt.Rows.Add(row.Cells["Barcode"].Value.ToString(), row.Cells["ProductName"].Value.ToString(), row.Cells["Price"].Value.ToString(), row.Cells["Quantity"].Value.ToString(), "0");
            }
            using (var pp = new PayPartite(dt, totalPrice))
            {
                var dr = pp.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    MessageBox.Show("kart:" + pp.cardAmount + "₺");
                    MessageBox.Show("nakit:" + pp.cashAmount + "₺");
                    MessageBox.Show("diğer:" + pp.otherAmount + "₺");
                }
            }
        }
    }
}
