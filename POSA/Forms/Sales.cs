using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
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
        public string addGroupLastImagePath = "";
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
        private void btnRootCustomer_Click(object sender, EventArgs e)
        {
            NextCustomer();
            dgvMain.Rows.Clear();
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
                addGroupLastImagePath = "";
                pnlAddGroup.Visible = true;
            }
        }
        private void btnSelectGroupImage_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
            if (ofd.ShowDialog() != DialogResult.OK)
                return;
            addGroupLastImagePath = ofd.FileName;
        }
        #endregion

        #region Group Functions
        public void UndyeAllGroups()
        {
            foreach (Button btn in flpGroups.Controls)
            {
                btn.BackColor = Color.Gainsboro;
            }
        }
        public void ResetAllGroupButtons()
        {
            int i = 1;
            foreach (Button btn in flpGroupButtons.Controls)
            {
                btn.BackColor = Color.Gainsboro;
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
                PageName = buttonText,
                PageImageBase64 = !string.IsNullOrWhiteSpace(addGroupLastImagePath) ? ConvertImageToBase64(Image.FromFile(addGroupLastImagePath)) : ""
            });
            return false;
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
                    SaveButtons();
                    var newButton = new Button();
                    newButton.Size = btnRootGroup.Size;
                    newButton.BackColor = Color.LightGreen;
                    newButton.BackgroundImageLayout = ImageLayout.Zoom;
                    newButton.ForeColor = Color.Black;
                    newButton.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
                    newButton.TextAlign = ContentAlignment.BottomCenter;
                    newButton.FlatStyle = btnRootGroup.FlatStyle;
                    if (!string.IsNullOrWhiteSpace(addGroupLastImagePath))
                        newButton.BackgroundImage = Image.FromFile(addGroupLastImagePath);
                    newButton.Text = tbNewGroupName.Text;
                    newButton.Font = btnRootGroup.Font;
                    newButton.Click += GroupsGeneral_Click;
                    flpGroups.Controls.Add(newButton);
                    addGroupLastImagePath = "";
                    ResetAllGroupButtons();
                    pnlAddGroup.Visible = false;
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
                    pnlAddNewGroupsButton.Visible = true;
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
        private void tbAddNewGroupsButton_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrWhiteSpace(tbAddNewGroupsButton.Text))
                {
                    foreach (Button btn in flpGroupButtons.Controls)
                    {
                        if (btn.Name == tbAddNewGroupsButton.Text)
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
                    GroupButtons.Add(GetMaterialAsButton(tbAddNewGroupsButton.Text, currentPage).Result);
                    pnlAddNewGroupsButton.Visible = false;
                    tbAddNewGroupsButton.Text = "";
                    RefreshCurrentPageButtons();
                }
                else
                {
                    MessageBox.Show("Barkod okutulmadan devam edilemez.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion

        #region Form Events
        private void Sales_Load(object sender, EventArgs e)
        {
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
                    newButton.TextAlign = ContentAlignment.BottomCenter;
                    newButton.FlatStyle = btnRootGroup.FlatStyle;
                    if (!string.IsNullOrWhiteSpace(btn.PageImageBase64))
                        newButton.BackgroundImage = Base64ToImage(btn.PageImageBase64);
                    newButton.Text = btn.PageName;
                    newButton.Font = btnRootGroup.Font;
                    newButton.Click += GroupsGeneral_Click;
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

                    dgvMain.Rows[e.RowIndex].Cells["Quantity"].Value = (Convert.ToInt32(dgvMain.Rows[e.RowIndex].Cells["Quantity"].Value.ToString()) - 1).ToString();
                    dgvMain.Rows[e.RowIndex].Cells["Total"].Value = decimal.Round(Convert.ToDecimal(dgvMain.Rows[e.RowIndex].Cells["Price"].Value.ToString()) * Convert.ToDecimal(dgvMain.Rows[e.RowIndex].Cells["Quantity"].Value.ToString()), 2, MidpointRounding.AwayFromZero).ToString();
                    CalculateAll();
                }
            }
            else if (e.ColumnIndex == dgvMain.Columns["PLUS"].Index)
            {
                dgvMain.Rows[e.RowIndex].Cells["Quantity"].Value = (Convert.ToInt32(dgvMain.Rows[e.RowIndex].Cells["Quantity"].Value.ToString()) + 1).ToString();
                dgvMain.Rows[e.RowIndex].Cells["Total"].Value = (Convert.ToDouble(dgvMain.Rows[e.RowIndex].Cells["Price"].Value.ToString()) * Convert.ToDouble(dgvMain.Rows[e.RowIndex].Cells["Quantity"].Value.ToString())).ToString();
                CalculateAll();
            }
        }
        #endregion

        #region Functions
        private string ConvertImageToBase64(Image? img)
        {
            if (img is null)
                return "";
            using (Image image = img)
            {
                using (MemoryStream m = new MemoryStream())
                {
                    image.Save(m, image.RawFormat);
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
            sqlBuilder.Select("BARCODE,NAME,SALEPRICE");
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
            var currencies = GetCurrencies();
            btnTotalPrice.Text = totalTL.ToString() + "₺";
            btnDolarTotalPrice.Text = decimal.Round((totalTL / currencies.Item1), 2, MidpointRounding.AwayFromZero).ToString() + "$";
            btnEuroTotalPrice.Text = decimal.Round((totalTL / currencies.Item2), 2, MidpointRounding.AwayFromZero).ToString() + "€";
        }
        private async Task<GroupButton> GetMaterialAsButton(string barcode, string currentPage)
        {
            //get it from database and fill the object
            var setting = Setting.Get();
            var response = new GroupButton();
            var cstr = setting.Sql.ConnectionString();
            await using var conn = new SqlConnection(setting.Sql.ConnectionString());
            conn.Open();
            var sqlBuilder = new SqlBuilder();
            sqlBuilder.Select($"""
                NAME,B64IMAGE
                """);
            sqlBuilder.Where($"""
                BARCODE=@BARCODE
                """);
            var param = new
            {
                BARCODE = barcode
            };
            var builderTemp = sqlBuilder.AddTemplate("SELECT /**select**/ FROM PRODUCTS /**where**/");
            var result = conn.QueryAsync<ProductNameImageDto>(builderTemp.RawSql, param).Result;
            if (result.Any())
            {
                var snc = result.First();
                response.B64Image = snc.B64IMAGE;
                response.Name = snc.NAME;
                response.Barcode = barcode;
                response.PageName = currentPage;

            }
            return response;
        }
        #endregion

        #endregion

        private void btnClearGrid_Click(object sender, EventArgs e)
        {
            dgvMain.Rows.Clear();
        }

        private void btnShowPrices_Click(object sender, EventArgs e)
        {
            btnTotalPrice.Visible = !btnTotalPrice.Visible;
            btnEuroTotalPrice.Visible = !btnEuroTotalPrice.Visible;
            btnDolarTotalPrice.Visible = !btnDolarTotalPrice.Visible;
        }
        public Tuple<decimal, decimal> GetCurrencies()
        {
            XmlDocument xmlVerisi = new XmlDocument();
            xmlVerisi.Load("http://www.tcmb.gov.tr/kurlar/today.xml");
            decimal dolar = Convert.ToDecimal(xmlVerisi.SelectSingleNode(string.Format("Tarih_Date/Currency[@Kod='{0}']/ForexSelling", "USD")).InnerText, new CultureInfo("en-gb"));
            decimal euro = Convert.ToDecimal(xmlVerisi.SelectSingleNode(string.Format("Tarih_Date/Currency[@Kod='{0}']/ForexSelling", "EUR")).InnerText, new CultureInfo("en-gb"));
            return new Tuple<decimal, decimal>(dolar, euro);
        }

        private void btnClearTakenMoney_Click(object sender, EventArgs e)
        {
            tbTakenMoney.Text = "0";
        }
        private void btnTL_Click(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            tbTakenMoney.Text = (Convert.ToInt32(tbTakenMoney.Text) + Convert.ToInt32(btn.Text.Replace("₺",""))).ToString();
            RefreshChange();
        }
        private void RefreshChange()
        {
            lblChangeMoney.Text = decimal.Round(Convert.ToInt32(tbTakenMoney.Text) - Convert.ToDecimal(btnTotalPrice.Text.Replace("₺","")),2,MidpointRounding.AwayFromZero).ToString();
        }
    }
}
