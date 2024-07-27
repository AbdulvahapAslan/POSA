namespace POSA.Forms
{
    partial class ShowStockInnerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel1 = new Panel();
            dgvMain = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            BARCODE = new DataGridViewTextBoxColumn();
            NAME = new DataGridViewTextBoxColumn();
            VATRATE = new DataGridViewTextBoxColumn();
            BUYPRICE = new DataGridViewTextBoxColumn();
            SALEPRICE = new DataGridViewTextBoxColumn();
            STOCK = new DataGridViewTextBoxColumn();
            UNIT = new DataGridViewTextBoxColumn();
            pbClearSearch = new PictureBox();
            pbMagGlass = new PictureBox();
            rtbSearch = new CustomObjects.RoundTextBox();
            lblCategories = new Label();
            panel10 = new Panel();
            fcCategories = new CustomObjects.FlatCombo();
            label1 = new Label();
            panel2 = new Panel();
            fcFilter = new CustomObjects.FlatCombo();
            panel3 = new Panel();
            lblTotalSale = new Label();
            lblTotalSellAmount = new Label();
            lblTotalBuying = new Label();
            lblTotalBuyingAmout = new Label();
            lblTotalProducts = new Label();
            lblSTotalProducts = new Label();
            flatCombo2 = new CustomObjects.FlatCombo();
            label2 = new Label();
            btnCancel = new Button();
            panel4 = new Panel();
            lblSellPriceType = new Label();
            fcPriceType = new CustomObjects.FlatCombo();
            flatCombo1 = new CustomObjects.FlatCombo();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMain).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbClearSearch).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbMagGlass).BeginInit();
            panel10.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(dgvMain);
            panel1.Location = new Point(12, 68);
            panel1.Margin = new Padding(3, 3, 12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1085, 410);
            panel1.TabIndex = 0;
            // 
            // dgvMain
            // 
            dgvMain.AllowUserToAddRows = false;
            dgvMain.AllowUserToDeleteRows = false;
            dgvMain.AllowUserToResizeColumns = false;
            dgvMain.AllowUserToResizeRows = false;
            dgvMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvMain.BackgroundColor = Color.White;
            dgvMain.BorderStyle = BorderStyle.None;
            dgvMain.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvMain.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(1, 39, 103);
            dataGridViewCellStyle3.SelectionBackColor = Color.White;
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(1, 39, 103);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvMain.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvMain.ColumnHeadersHeight = 50;
            dgvMain.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvMain.Columns.AddRange(new DataGridViewColumn[] { ID, BARCODE, NAME, VATRATE, BUYPRICE, SALEPRICE, STOCK, UNIT });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 162);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(1, 39, 103);
            dataGridViewCellStyle4.SelectionBackColor = Color.White;
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(1, 39, 103);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvMain.DefaultCellStyle = dataGridViewCellStyle4;
            dgvMain.EnableHeadersVisualStyles = false;
            dgvMain.GridColor = Color.White;
            dgvMain.Location = new Point(10, 10);
            dgvMain.Margin = new Padding(10);
            dgvMain.MultiSelect = false;
            dgvMain.Name = "dgvMain";
            dgvMain.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvMain.RowHeadersVisible = false;
            dgvMain.RowHeadersWidth = 35;
            dgvMain.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvMain.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvMain.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(210, 226, 252);
            dgvMain.RowTemplate.DefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvMain.RowTemplate.DefaultCellStyle.ForeColor = Color.FromArgb(1, 39, 103);
            dgvMain.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(109, 134, 176);
            dgvMain.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvMain.RowTemplate.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvMain.RowTemplate.DividerHeight = 10;
            dgvMain.RowTemplate.Height = 40;
            dgvMain.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMain.Size = new Size(1065, 390);
            dgvMain.TabIndex = 76;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.Visible = false;
            // 
            // BARCODE
            // 
            BARCODE.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            BARCODE.DataPropertyName = "BARCODE";
            BARCODE.FillWeight = 20F;
            BARCODE.HeaderText = "BARKOD";
            BARCODE.MaxInputLength = 100;
            BARCODE.Name = "BARCODE";
            BARCODE.ReadOnly = true;
            // 
            // NAME
            // 
            NAME.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NAME.DataPropertyName = "NAME";
            NAME.FillWeight = 23F;
            NAME.HeaderText = "ÜRÜN ADI";
            NAME.MaxInputLength = 50;
            NAME.Name = "NAME";
            NAME.ReadOnly = true;
            // 
            // VATRATE
            // 
            VATRATE.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            VATRATE.DataPropertyName = "VATRATE";
            VATRATE.FillWeight = 7F;
            VATRATE.HeaderText = "KDV ORANI";
            VATRATE.Name = "VATRATE";
            // 
            // BUYPRICE
            // 
            BUYPRICE.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            BUYPRICE.DataPropertyName = "BUYPRICE";
            BUYPRICE.FillWeight = 10F;
            BUYPRICE.HeaderText = "ALIŞ";
            BUYPRICE.Name = "BUYPRICE";
            // 
            // SALEPRICE
            // 
            SALEPRICE.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SALEPRICE.DataPropertyName = "SALEPRICE";
            SALEPRICE.FillWeight = 10F;
            SALEPRICE.HeaderText = "SATIŞ";
            SALEPRICE.Name = "SALEPRICE";
            // 
            // STOCK
            // 
            STOCK.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            STOCK.DataPropertyName = "STOCK";
            STOCK.FillWeight = 15F;
            STOCK.HeaderText = "STOK";
            STOCK.Name = "STOCK";
            // 
            // UNIT
            // 
            UNIT.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            UNIT.DataPropertyName = "UNIT";
            UNIT.FillWeight = 15F;
            UNIT.HeaderText = "BİRİM";
            UNIT.Name = "UNIT";
            // 
            // pbClearSearch
            // 
            pbClearSearch.BackColor = Color.White;
            pbClearSearch.BackgroundImage = Properties.Resources._16pxCloseBlack;
            pbClearSearch.BackgroundImageLayout = ImageLayout.Center;
            pbClearSearch.Location = new Point(248, 29);
            pbClearSearch.Name = "pbClearSearch";
            pbClearSearch.Size = new Size(26, 26);
            pbClearSearch.TabIndex = 84;
            pbClearSearch.TabStop = false;
            pbClearSearch.Click += pbClearSearch_Click;
            // 
            // pbMagGlass
            // 
            pbMagGlass.BackColor = Color.White;
            pbMagGlass.BackgroundImage = Properties.Resources._16pxSearch;
            pbMagGlass.BackgroundImageLayout = ImageLayout.Center;
            pbMagGlass.Location = new Point(17, 29);
            pbMagGlass.Name = "pbMagGlass";
            pbMagGlass.Size = new Size(26, 26);
            pbMagGlass.TabIndex = 83;
            pbMagGlass.TabStop = false;
            // 
            // rtbSearch
            // 
            rtbSearch.BackColor = SystemColors.Window;
            rtbSearch.BorderColor = Color.White;
            rtbSearch.BorderFocusColor = Color.White;
            rtbSearch.BorderRadius = 4;
            rtbSearch.BorderSize = 1;
            rtbSearch.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rtbSearch.ForeColor = Color.FromArgb(64, 64, 64);
            rtbSearch.Location = new Point(13, 25);
            rtbSearch.Margin = new Padding(4);
            rtbSearch.Multiline = false;
            rtbSearch.Name = "rtbSearch";
            rtbSearch.Padding = new Padding(35, 7, 30, 7);
            rtbSearch.PasswordChar = false;
            rtbSearch.PlaceholderColor = Color.DarkGray;
            rtbSearch.PlaceholderText = "Ara...";
            rtbSearch.Size = new Size(264, 34);
            rtbSearch.TabIndex = 85;
            rtbSearch.Texts = "";
            rtbSearch.UnderlinedStyle = false;
            rtbSearch.KeyDown += rtbSearch_KeyDown;
            // 
            // lblCategories
            // 
            lblCategories.Anchor = AnchorStyles.None;
            lblCategories.AutoSize = true;
            lblCategories.BackColor = Color.FromArgb(49, 121, 199);
            lblCategories.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            lblCategories.ForeColor = Color.White;
            lblCategories.Location = new Point(0, 3);
            lblCategories.Margin = new Padding(0, 0, 10, 0);
            lblCategories.Name = "lblCategories";
            lblCategories.Size = new Size(83, 25);
            lblCategories.TabIndex = 105;
            lblCategories.Text = "Kategori";
            // 
            // panel10
            // 
            panel10.BackColor = Color.FromArgb(49, 121, 199);
            panel10.Controls.Add(fcCategories);
            panel10.Controls.Add(lblCategories);
            panel10.Location = new Point(309, 24);
            panel10.Name = "panel10";
            panel10.Size = new Size(295, 32);
            panel10.TabIndex = 110;
            // 
            // fcCategories
            // 
            fcCategories.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            fcCategories.BackColor = Color.FromArgb(49, 121, 199);
            fcCategories.BorderColor = Color.White;
            fcCategories.ButtonColor = Color.FromArgb(49, 121, 199);
            fcCategories.DrawMode = DrawMode.OwnerDrawFixed;
            fcCategories.DropDownStyle = ComboBoxStyle.DropDownList;
            fcCategories.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            fcCategories.ForeColor = Color.White;
            fcCategories.FormattingEnabled = true;
            fcCategories.HighlightColor = Color.FromArgb(49, 121, 199);
            fcCategories.Location = new Point(94, 0);
            fcCategories.Margin = new Padding(1);
            fcCategories.Name = "fcCategories";
            fcCategories.Size = new Size(200, 32);
            fcCategories.TabIndex = 113;
            fcCategories.SelectedIndexChanged += fcCategories_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(49, 121, 199);
            label1.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 3);
            label1.Margin = new Padding(0, 0, 10, 0);
            label1.Name = "label1";
            label1.Size = new Size(55, 25);
            label1.TabIndex = 111;
            label1.Text = "Filtre";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(49, 121, 199);
            panel2.Controls.Add(fcFilter);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(611, 24);
            panel2.Name = "panel2";
            panel2.Size = new Size(259, 32);
            panel2.TabIndex = 112;
            // 
            // fcFilter
            // 
            fcFilter.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            fcFilter.BackColor = Color.FromArgb(49, 121, 199);
            fcFilter.BorderColor = Color.White;
            fcFilter.ButtonColor = Color.FromArgb(49, 121, 199);
            fcFilter.DrawMode = DrawMode.OwnerDrawFixed;
            fcFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            fcFilter.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            fcFilter.ForeColor = Color.White;
            fcFilter.FormattingEnabled = true;
            fcFilter.HighlightColor = Color.FromArgb(49, 121, 199);
            fcFilter.Items.AddRange(new object[] { "YOK", "ÇOK SATANLAR", "ÇOK BULUNAN", "FİYAT (ARTAN)", "FİYAT (AZALAN)", "BARKOD (ARTAN)", "BARKOD (AZALAN)", "İSİM (A - Z)", "İSİM (Z - A)" });
            fcFilter.Location = new Point(58, 0);
            fcFilter.Margin = new Padding(1);
            fcFilter.Name = "fcFilter";
            fcFilter.Size = new Size(200, 32);
            fcFilter.TabIndex = 114;
            fcFilter.SelectedIndexChanged += fcFilter_SelectedIndexChanged;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(49, 121, 199);
            panel3.Controls.Add(lblTotalSale);
            panel3.Controls.Add(lblTotalSellAmount);
            panel3.Controls.Add(lblTotalBuying);
            panel3.Controls.Add(lblTotalBuyingAmout);
            panel3.Controls.Add(lblTotalProducts);
            panel3.Controls.Add(lblSTotalProducts);
            panel3.Controls.Add(flatCombo2);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(13, 483);
            panel3.Name = "panel3";
            panel3.Size = new Size(1084, 37);
            panel3.TabIndex = 113;
            // 
            // lblTotalSale
            // 
            lblTotalSale.Anchor = AnchorStyles.None;
            lblTotalSale.AutoSize = true;
            lblTotalSale.BackColor = Color.FromArgb(49, 121, 199);
            lblTotalSale.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            lblTotalSale.ForeColor = Color.White;
            lblTotalSale.Location = new Point(801, 4);
            lblTotalSale.Margin = new Padding(0, 20, 0, 0);
            lblTotalSale.Name = "lblTotalSale";
            lblTotalSale.Size = new Size(23, 28);
            lblTotalSale.TabIndex = 120;
            lblTotalSale.Text = "0";
            // 
            // lblTotalSellAmount
            // 
            lblTotalSellAmount.Anchor = AnchorStyles.None;
            lblTotalSellAmount.AutoSize = true;
            lblTotalSellAmount.BackColor = Color.FromArgb(49, 121, 199);
            lblTotalSellAmount.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            lblTotalSellAmount.ForeColor = Color.White;
            lblTotalSellAmount.Location = new Point(598, 4);
            lblTotalSellAmount.Margin = new Padding(0, 20, 0, 0);
            lblTotalSellAmount.Name = "lblTotalSellAmount";
            lblTotalSellAmount.Size = new Size(203, 28);
            lblTotalSellAmount.TabIndex = 119;
            lblTotalSellAmount.Text = "Toplam Satış Değeri :";
            // 
            // lblTotalBuying
            // 
            lblTotalBuying.Anchor = AnchorStyles.None;
            lblTotalBuying.AutoSize = true;
            lblTotalBuying.BackColor = Color.FromArgb(49, 121, 199);
            lblTotalBuying.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            lblTotalBuying.ForeColor = Color.White;
            lblTotalBuying.Location = new Point(482, 4);
            lblTotalBuying.Margin = new Padding(0, 20, 0, 0);
            lblTotalBuying.Name = "lblTotalBuying";
            lblTotalBuying.Size = new Size(23, 28);
            lblTotalBuying.TabIndex = 118;
            lblTotalBuying.Text = "0";
            // 
            // lblTotalBuyingAmout
            // 
            lblTotalBuyingAmout.Anchor = AnchorStyles.None;
            lblTotalBuyingAmout.AutoSize = true;
            lblTotalBuyingAmout.BackColor = Color.FromArgb(49, 121, 199);
            lblTotalBuyingAmout.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            lblTotalBuyingAmout.ForeColor = Color.White;
            lblTotalBuyingAmout.Location = new Point(284, 4);
            lblTotalBuyingAmout.Margin = new Padding(0, 20, 0, 0);
            lblTotalBuyingAmout.Name = "lblTotalBuyingAmout";
            lblTotalBuyingAmout.Size = new Size(193, 28);
            lblTotalBuyingAmout.TabIndex = 117;
            lblTotalBuyingAmout.Text = "Toplam Alış Değeri :";
            // 
            // lblTotalProducts
            // 
            lblTotalProducts.Anchor = AnchorStyles.None;
            lblTotalProducts.AutoSize = true;
            lblTotalProducts.BackColor = Color.FromArgb(49, 121, 199);
            lblTotalProducts.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            lblTotalProducts.ForeColor = Color.White;
            lblTotalProducts.Location = new Point(202, 4);
            lblTotalProducts.Margin = new Padding(0, 20, 0, 0);
            lblTotalProducts.Name = "lblTotalProducts";
            lblTotalProducts.Size = new Size(23, 28);
            lblTotalProducts.TabIndex = 116;
            lblTotalProducts.Text = "0";
            // 
            // lblSTotalProducts
            // 
            lblSTotalProducts.Anchor = AnchorStyles.None;
            lblSTotalProducts.AutoSize = true;
            lblSTotalProducts.BackColor = Color.FromArgb(49, 121, 199);
            lblSTotalProducts.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            lblSTotalProducts.ForeColor = Color.White;
            lblSTotalProducts.Location = new Point(4, 4);
            lblSTotalProducts.Margin = new Padding(0, 20, 0, 0);
            lblSTotalProducts.Name = "lblSTotalProducts";
            lblSTotalProducts.Size = new Size(198, 28);
            lblSTotalProducts.TabIndex = 115;
            lblSTotalProducts.Text = "Toplam ürün sayısı : ";
            // 
            // flatCombo2
            // 
            flatCombo2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            flatCombo2.BackColor = Color.FromArgb(49, 121, 199);
            flatCombo2.BorderColor = Color.White;
            flatCombo2.ButtonColor = Color.FromArgb(49, 121, 199);
            flatCombo2.DrawMode = DrawMode.OwnerDrawFixed;
            flatCombo2.DropDownStyle = ComboBoxStyle.DropDownList;
            flatCombo2.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            flatCombo2.ForeColor = Color.White;
            flatCombo2.FormattingEnabled = true;
            flatCombo2.HighlightColor = Color.FromArgb(49, 121, 199);
            flatCombo2.Items.AddRange(new object[] { "YOK", "ÇOK SATANLAR", "ÇOK BULUNAN", "FİYAT (ARTAN)", "FİYAT (AZALAN)", "BARKOD (ARTAN)", "BARKOD (AZALAN)", "İSİM (A - Z)", "İSİM (Z - A)" });
            flatCombo2.Location = new Point(983, -63);
            flatCombo2.Margin = new Padding(1);
            flatCombo2.Name = "flatCombo2";
            flatCombo2.Size = new Size(238, 37);
            flatCombo2.TabIndex = 114;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(49, 121, 199);
            label2.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(442, -29);
            label2.Margin = new Padding(0, 20, 0, 0);
            label2.Name = "label2";
            label2.Size = new Size(64, 30);
            label2.TabIndex = 111;
            label2.Text = "Filtre";
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.BackColor = Color.Transparent;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold);
            btnCancel.ForeColor = Color.White;
            btnCancel.Image = Properties.Resources._64pxGrayExcel;
            btnCancel.Location = new Point(1042, 6);
            btnCancel.Margin = new Padding(10);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(55, 55);
            btnCancel.TabIndex = 114;
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(49, 121, 199);
            panel4.Controls.Add(lblSellPriceType);
            panel4.Controls.Add(fcPriceType);
            panel4.Controls.Add(flatCombo1);
            panel4.Controls.Add(label3);
            panel4.Location = new Point(876, 24);
            panel4.Name = "panel4";
            panel4.Size = new Size(164, 32);
            panel4.TabIndex = 115;
            // 
            // lblSellPriceType
            // 
            lblSellPriceType.Anchor = AnchorStyles.None;
            lblSellPriceType.AutoSize = true;
            lblSellPriceType.BackColor = Color.FromArgb(49, 121, 199);
            lblSellPriceType.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            lblSellPriceType.ForeColor = Color.White;
            lblSellPriceType.Location = new Point(0, 3);
            lblSellPriceType.Margin = new Padding(0, 0, 10, 0);
            lblSellPriceType.Name = "lblSellPriceType";
            lblSellPriceType.Size = new Size(87, 25);
            lblSellPriceType.TabIndex = 116;
            lblSellPriceType.Text = "Fiyat Tipi";
            // 
            // fcPriceType
            // 
            fcPriceType.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            fcPriceType.BackColor = Color.FromArgb(49, 121, 199);
            fcPriceType.BorderColor = Color.White;
            fcPriceType.ButtonColor = Color.FromArgb(49, 121, 199);
            fcPriceType.DrawMode = DrawMode.OwnerDrawFixed;
            fcPriceType.DropDownStyle = ComboBoxStyle.DropDownList;
            fcPriceType.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            fcPriceType.ForeColor = Color.White;
            fcPriceType.FormattingEnabled = true;
            fcPriceType.HighlightColor = Color.FromArgb(49, 121, 199);
            fcPriceType.Items.AddRange(new object[] { "1", "2", "3" });
            fcPriceType.Location = new Point(97, 0);
            fcPriceType.Margin = new Padding(1);
            fcPriceType.Name = "fcPriceType";
            fcPriceType.Size = new Size(66, 32);
            fcPriceType.TabIndex = 115;
            fcPriceType.SelectedIndexChanged += fcPriceType_SelectedIndexChanged;
            // 
            // flatCombo1
            // 
            flatCombo1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            flatCombo1.BackColor = Color.FromArgb(49, 121, 199);
            flatCombo1.BorderColor = Color.White;
            flatCombo1.ButtonColor = Color.FromArgb(49, 121, 199);
            flatCombo1.DrawMode = DrawMode.OwnerDrawFixed;
            flatCombo1.DropDownStyle = ComboBoxStyle.DropDownList;
            flatCombo1.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            flatCombo1.ForeColor = Color.White;
            flatCombo1.FormattingEnabled = true;
            flatCombo1.HighlightColor = Color.FromArgb(49, 121, 199);
            flatCombo1.Items.AddRange(new object[] { "YOK", "ÇOK SATANLAR", "ÇOK BULUNAN", "FİYAT (ARTAN)", "FİYAT (AZALAN)", "BARKOD (ARTAN)", "BARKOD (AZALAN)", "İSİM (A - Z)", "İSİM (Z - A)" });
            flatCombo1.Location = new Point(22, -68);
            flatCombo1.Margin = new Padding(1);
            flatCombo1.Name = "flatCombo1";
            flatCombo1.Size = new Size(200, 32);
            flatCombo1.TabIndex = 114;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(49, 121, 199);
            label3.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(-18, -31);
            label3.Margin = new Padding(0, 0, 10, 0);
            label3.Name = "label3";
            label3.Size = new Size(55, 25);
            label3.TabIndex = 111;
            label3.Text = "Filtre";
            // 
            // ShowStockInnerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(0, 74, 173);
            ClientSize = new Size(1118, 532);
            Controls.Add(panel4);
            Controls.Add(btnCancel);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(pbClearSearch);
            Controls.Add(pbMagGlass);
            Controls.Add(rtbSearch);
            Controls.Add(panel1);
            Controls.Add(panel10);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ShowStockInnerForm";
            Text = "AddSupplierReportForm";
            Load += AddCustomerReportForm_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMain).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbClearSearch).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbMagGlass).EndInit();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dgvMain;
        private PictureBox pbClearSearch;
        private PictureBox pbMagGlass;
        private CustomObjects.RoundTextBox rtbSearch;
        private Label lblCategories;
        private Panel panel10;
        private Label label1;
        private Panel panel2;
        private CustomObjects.FlatCombo fcCategories;
        private CustomObjects.FlatCombo fcFilter;
        private Panel panel3;
        private Label lblTotalProducts;
        private Label lblSTotalProducts;
        private CustomObjects.FlatCombo flatCombo2;
        private Label label2;
        private Label lblTotalBuying;
        private Label lblTotalBuyingAmout;
        private Label lblTotalSale;
        private Label lblTotalSellAmount;
        private Button btnCancel;
        private Panel panel4;
        private Label lblSellPriceType;
        private CustomObjects.FlatCombo fcPriceType;
        private CustomObjects.FlatCombo flatCombo1;
        private Label label3;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn BARCODE;
        private DataGridViewTextBoxColumn NAME;
        private DataGridViewTextBoxColumn VATRATE;
        private DataGridViewTextBoxColumn BUYPRICE;
        private DataGridViewTextBoxColumn SALEPRICE;
        private DataGridViewTextBoxColumn STOCK;
        private DataGridViewTextBoxColumn UNIT;
    }
}