using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POSA.CustomObjects;
using POSA.Dto;
namespace POSA.Forms
{
    public partial class Sales : Form
    {
        public Sales()
        {
            InitializeComponent();
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
                    dgvMain.Rows.Add(product.Barcode, product.ProductName, product.Price, product.Quantity, product.Total);
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
                    dgvMain.Rows.Add(product.Barcode, product.ProductName, product.Price, product.Quantity, product.Total);
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
                    for (int i = 0; i < dgvMain.Rows.Count - 1; i++)
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
                for (int i = 0; i < dgvMain.Rows.Count - 1; i++)
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
                btn.BackColor = Color.White;
            }
        }
        public void ResetAllGroupButtons()
        {
            int i = 1;
            foreach (Button btn in flpGroupButtons.Controls)
            {
                btn.BackColor = Color.White;
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
                    newButton.ForeColor = Color.White;
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
                        btn.BackgroundImage = Base64ToImage(button.B64Image);
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
                    GroupButtons.Add(GetMaterialAsButton(tbAddNewGroupsButton.Text, currentPage));
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
                HeaderText = "SİL",
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
                    newButton.ForeColor = Color.White;
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
                    dgvMain.Rows[e.RowIndex].Cells["Total"].Value = (Convert.ToDouble(dgvMain.Rows[e.RowIndex].Cells["Price"].Value.ToString()) * Convert.ToDouble(dgvMain.Rows[e.RowIndex].Cells["Quantity"].Value.ToString())).ToString();
                }
            }
            else if (e.ColumnIndex == dgvMain.Columns["PLUS"].Index)
            {
                dgvMain.Rows[e.RowIndex].Cells["Quantity"].Value = (Convert.ToInt32(dgvMain.Rows[e.RowIndex].Cells["Quantity"].Value.ToString()) + 1).ToString();
                dgvMain.Rows[e.RowIndex].Cells["Total"].Value = (Convert.ToDouble(dgvMain.Rows[e.RowIndex].Cells["Price"].Value.ToString()) * Convert.ToDouble(dgvMain.Rows[e.RowIndex].Cells["Quantity"].Value.ToString())).ToString();
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
        private void AddToGridWithBarcode(string barcode)
        {
            var indexOfExistingRow = -1;
            switch (barcode)
            {//01246
                case "1":
                    for (int i = 0; i < dgvMain.Rows.Count; i++)
                    {
                        if (dgvMain.Rows[i].Cells["Barcode"].Value.ToString() == "1")
                        {
                            indexOfExistingRow = i;
                            break;
                        }
                    }
                    if (indexOfExistingRow > -1)
                    {
                        dgvMain.Rows[indexOfExistingRow].Cells["Quantity"].Value = (Convert.ToInt32(dgvMain.Rows[indexOfExistingRow].Cells["Quantity"].Value.ToString()) + 1).ToString();
                        dgvMain.Rows[indexOfExistingRow].Cells["Total"].Value = (Convert.ToDouble(dgvMain.Rows[indexOfExistingRow].Cells["Price"].Value.ToString()) * Convert.ToDouble(dgvMain.Rows[indexOfExistingRow].Cells["Quantity"].Value.ToString())).ToString();
                    }
                    else
                    {
                        dgvMain.Rows.Add();
                        dgvMain.Rows[dgvMain.Rows.Count - 1].Cells["Barcode"].Value = "1";
                        dgvMain.Rows[dgvMain.Rows.Count - 1].Cells["ProductName"].Value = "1";
                        dgvMain.Rows[dgvMain.Rows.Count - 1].Cells["Price"].Value = "1";
                        dgvMain.Rows[dgvMain.Rows.Count - 1].Cells["Quantity"].Value = "1";
                        dgvMain.Rows[dgvMain.Rows.Count - 1].Cells["Total"].Value = (Convert.ToDouble(dgvMain.Rows[dgvMain.Rows.Count - 1].Cells["Price"].Value.ToString()) * Convert.ToDouble(dgvMain.Rows[dgvMain.Rows.Count - 1].Cells["Quantity"].Value.ToString())).ToString();
                    }
                    break;
                case "2":
                    for (int i = 0; i < dgvMain.Rows.Count; i++)
                    {
                        if (dgvMain.Rows[i].Cells["Barcode"].Value.ToString() == "2")
                        {
                            indexOfExistingRow = i;
                            break;
                        }
                    }
                    if (indexOfExistingRow > -1)
                    {
                        dgvMain.Rows[indexOfExistingRow].Cells["Quantity"].Value = (Convert.ToInt32(dgvMain.Rows[indexOfExistingRow].Cells["Quantity"].Value.ToString()) + 1).ToString();
                        dgvMain.Rows[indexOfExistingRow].Cells["Total"].Value = (Convert.ToDouble(dgvMain.Rows[indexOfExistingRow].Cells["Price"].Value.ToString()) * Convert.ToDouble(dgvMain.Rows[indexOfExistingRow].Cells["Quantity"].Value.ToString())).ToString();
                    }
                    else
                    {
                        dgvMain.Rows.Add();
                        dgvMain.Rows[dgvMain.Rows.Count - 1].Cells["Barcode"].Value = "2";
                        dgvMain.Rows[dgvMain.Rows.Count - 1].Cells["ProductName"].Value = "2";
                        dgvMain.Rows[dgvMain.Rows.Count - 1].Cells["Price"].Value = "2";
                        dgvMain.Rows[dgvMain.Rows.Count - 1].Cells["Quantity"].Value = "1";
                        dgvMain.Rows[dgvMain.Rows.Count - 1].Cells["Total"].Value = (Convert.ToDouble(dgvMain.Rows[dgvMain.Rows.Count - 1].Cells["Price"].Value.ToString()) * Convert.ToDouble(dgvMain.Rows[dgvMain.Rows.Count - 1].Cells["Quantity"].Value.ToString())).ToString();
                    }
                    break;
                case "3":
                    for (int i = 0; i < dgvMain.Rows.Count; i++)
                    {
                        if (dgvMain.Rows[i].Cells["Barcode"].Value.ToString() == "3")
                        {
                            indexOfExistingRow = i;
                            break;
                        }
                    }
                    if (indexOfExistingRow > -1)
                    {
                        dgvMain.Rows[indexOfExistingRow].Cells["Quantity"].Value = (Convert.ToInt32(dgvMain.Rows[indexOfExistingRow].Cells["Quantity"].Value.ToString()) + 1).ToString();
                        dgvMain.Rows[indexOfExistingRow].Cells["Total"].Value = (Convert.ToDouble(dgvMain.Rows[indexOfExistingRow].Cells["Price"].Value.ToString()) * Convert.ToDouble(dgvMain.Rows[indexOfExistingRow].Cells["Quantity"].Value.ToString())).ToString();
                    }
                    else
                    {
                        dgvMain.Rows.Add();
                        dgvMain.Rows[dgvMain.Rows.Count - 1].Cells["Barcode"].Value = "3";
                        dgvMain.Rows[dgvMain.Rows.Count - 1].Cells["ProductName"].Value = "3";
                        dgvMain.Rows[dgvMain.Rows.Count - 1].Cells["Price"].Value = "3";
                        dgvMain.Rows[dgvMain.Rows.Count - 1].Cells["Quantity"].Value = "1";
                        dgvMain.Rows[dgvMain.Rows.Count - 1].Cells["Total"].Value = (Convert.ToDouble(dgvMain.Rows[dgvMain.Rows.Count - 1].Cells["Price"].Value.ToString()) * Convert.ToDouble(dgvMain.Rows[dgvMain.Rows.Count - 1].Cells["Quantity"].Value.ToString())).ToString();
                    }
                    break;
                default:
                    break;
            }
        }
        private GroupButton GetMaterialAsButton(string barcode, string currentPage)
        {
            //get it from database and fill the object
            var response = new GroupButton();
            switch (barcode)
            {
                case "1":
                    response.Barcode = "1";
                    response.PageName = currentPage;
                    response.Name = "ELMA";
                    {
                        response.B64Image = "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";
                    }
                    break;
                case "2":
                    response.Barcode = "2";
                    response.PageName = currentPage;
                    response.Name = "KOLA";
                    {
                        response.B64Image = "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";
                    }
                    break;
                case "3":
                    response.Barcode = "3";
                    response.PageName = currentPage;
                    response.Name = "ŞEKER";
                    {
                        response.B64Image = "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";
                    };
                    break;
                default:
                    break;
            }
            return response;
        }
        #endregion

        #endregion
    }
}
