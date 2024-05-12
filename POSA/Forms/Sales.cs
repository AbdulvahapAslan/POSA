using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace POSA.Forms
{
    public partial class Sales : Form
    {
        public Sales()
        {
            InitializeComponent();
        }
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
        private void Sales_Load(object sender, EventArgs e)
        {
        }
        private void NextCustomer()
        {
            bool willItSaveToRoot = true;
            foreach (Button btn in flpCustomers.Controls)
            {
                if (btn.BackColor == Color.LightGreen)
                {
                    willItSaveToRoot = false;
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
                }
            }
            if (willItSaveToRoot)
            {
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
            dgvMain.Rows.Clear();
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
        private List<Product> Customers = new List<Product>();
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
        private void btnRootCustomer_Click(object sender, EventArgs e)
        {
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
        public string addGroupLastImagePath = "";
        private void btnSelectGroupImage_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
            if (ofd.ShowDialog() != DialogResult.OK)
                return;
            addGroupLastImagePath = ofd.FileName;
        }
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
        private void btnNewGroupAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbNewGroupName.Text))
            {
                MessageBox.Show("Grup adı yazmadan devam edilemez!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                SaveButtons();
                var newButton = new Button();
                newButton.Size = btnRootGroup.Size;
                newButton.BackColor = Color.LightGreen;
                newButton.BackgroundImageLayout = ImageLayout.Stretch;
                newButton.ForeColor = Color.White;
                newButton.TextAlign = ContentAlignment.BottomCenter;
                newButton.FlatStyle = btnRootGroup.FlatStyle;
                if (!string.IsNullOrWhiteSpace(addGroupLastImagePath))
                    newButton.BackgroundImage = Image.FromFile(addGroupLastImagePath);
                newButton.Text = tbNewGroupName.Text;
                newButton.Font = btnRootGroup.Font;
                flpGroups.Controls.Add(newButton);
                ResetAllGroupButtons();
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
                                B64Image = ConvertImageToBase64(grpButton.Image),
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
                            B64Image = ConvertImageToBase64(grpButton.Image),
                            Barcode = grpButton.Name,
                            Name = grpButton.Text,
                            PageName = "ROOT"
                        });
                    }
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
        public class GroupPage
        {
            public string PageName { get; set; }
            public string PageImageBase64 { get; set; }
        }
        public class GroupButton
        {
            public string PageName { get; set; }
            public string Name { get; set; }
            public string Barcode { get; set; }
            public string B64Image { get; set; }
        }
        public List<GroupPage> GroupPages = new List<GroupPage>();
        public List<GroupButton> GroupButtons = new List<GroupButton>();
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
                btn.Image = null;
                btn.Name = "Button" + i;
                btn.Text = "";
                i++;
            }
        }
        private void GroupButtonsGeneral_Click(object sender, EventArgs e) 
        {
            var selectedButton = sender as Button;
            UndyeAllGroups();
            selectedButton.BackColor = Color.LightGreen;
            ResetAllButtons();
            var SelectedGroupButtons = (from x in GroupButtons where x.PageName == selectedButton.Text select x).ToList();
            foreach (var button in SelectedGroupButtons)
            {
                foreach (Button btn in flpGroupButtons.Controls)
                {
                    if (string.IsNullOrWhiteSpace(btn.Text))
                    {
                        btn.Text = button.Name;
                        btn.Name = button.Barcode;
                        btn.Image = Base64ToImage(button.B64Image);
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
                        btn.Image = Base64ToImage(rootButton.B64Image);
                        break;
                    }
                }
            }
        }
    }
}
