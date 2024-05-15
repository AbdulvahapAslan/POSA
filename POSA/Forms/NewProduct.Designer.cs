namespace POSA.Forms
{
    partial class NewProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewProduct));
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            btnMinimize = new Button();
            btnMaximize = new Button();
            btnClose = new Button();
            lblPageHeader = new Label();
            pnlMain = new Panel();
            scMainContainer = new SplitContainer();
            btnAddBranch = new Button();
            btnAddSupplier = new Button();
            btnAddMaterial = new Button();
            btnAddSize = new Button();
            btnAddColor = new Button();
            btnAddUnit = new Button();
            btnAddCategory = new Button();
            btnSave = new Button();
            cbSize = new ComboBox();
            lblSize = new Label();
            cbBranch = new ComboBox();
            cbSupplier = new ComboBox();
            cbMaterial = new ComboBox();
            cbColor = new ComboBox();
            cbUnit = new ComboBox();
            btnClearPage = new Button();
            cbCategory = new ComboBox();
            lblBranch = new Label();
            tbSalePrice3 = new TextBox();
            label15 = new Label();
            tbSalePrice2 = new TextBox();
            label14 = new Label();
            tbCriticalStock = new TextBox();
            lblCriticalStock = new Label();
            lblSupplier = new Label();
            tbStock = new TextBox();
            lblStock = new Label();
            lblMaterial = new Label();
            lblColor = new Label();
            lblUnit = new Label();
            tbSalePrice = new TextBox();
            lblSalePrice = new Label();
            tbBuyPrice = new TextBox();
            lblBuyPrice = new Label();
            tbVatRate = new TextBox();
            lblVatRate = new Label();
            lblCategory = new Label();
            tbProductName = new TextBox();
            lblProductName = new Label();
            btnCheckBarcode = new Button();
            tbBarcode = new TextBox();
            lblBarcode = new Label();
            pictureBox1 = new PictureBox();
            btnAddPicture = new Button();
            btnNewVariant = new Button();
            btnGiveNextBarcode = new Button();
            scRightSide = new SplitContainer();
            pbClearSearch = new PictureBox();
            pictureBox3 = new PictureBox();
            rtbSearch = new CustomObjects.RoundTextBox();
            btnUpdate = new Button();
            dgvMain = new DataGridView();
            Barcode = new DataGridViewTextBoxColumn();
            ProductName = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)scMainContainer).BeginInit();
            scMainContainer.Panel1.SuspendLayout();
            scMainContainer.Panel2.SuspendLayout();
            scMainContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)scRightSide).BeginInit();
            scRightSide.Panel1.SuspendLayout();
            scRightSide.Panel2.SuspendLayout();
            scRightSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbClearSearch).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvMain).BeginInit();
            SuspendLayout();
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimize.BackColor = Color.Transparent;
            btnMinimize.BackgroundImage = (Image)resources.GetObject("btnMinimize.BackgroundImage");
            btnMinimize.BackgroundImageLayout = ImageLayout.Center;
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.ForeColor = Color.White;
            btnMinimize.Location = new Point(1136, 12);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(70, 35);
            btnMinimize.TabIndex = 5;
            btnMinimize.UseVisualStyleBackColor = false;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // btnMaximize
            // 
            btnMaximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximize.BackColor = Color.Transparent;
            btnMaximize.BackgroundImage = (Image)resources.GetObject("btnMaximize.BackgroundImage");
            btnMaximize.BackgroundImageLayout = ImageLayout.Center;
            btnMaximize.FlatAppearance.BorderSize = 0;
            btnMaximize.FlatStyle = FlatStyle.Flat;
            btnMaximize.ForeColor = Color.White;
            btnMaximize.Location = new Point(1207, 12);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(70, 35);
            btnMaximize.TabIndex = 4;
            btnMaximize.UseVisualStyleBackColor = false;
            btnMaximize.Click += btnMaximize_Click;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.BackColor = Color.Transparent;
            btnClose.BackgroundImage = (Image)resources.GetObject("btnClose.BackgroundImage");
            btnClose.BackgroundImageLayout = ImageLayout.Center;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(1278, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(70, 35);
            btnClose.TabIndex = 3;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // lblPageHeader
            // 
            lblPageHeader.AutoSize = true;
            lblPageHeader.BackColor = Color.Transparent;
            lblPageHeader.Font = new Font("Segoe UI Semibold", 17F, FontStyle.Bold);
            lblPageHeader.ForeColor = Color.White;
            lblPageHeader.Location = new Point(12, 9);
            lblPageHeader.Name = "lblPageHeader";
            lblPageHeader.Size = new Size(141, 31);
            lblPageHeader.TabIndex = 8;
            lblPageHeader.Text = "ÜRÜN GİRİŞ";
            // 
            // pnlMain
            // 
            pnlMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlMain.BackColor = Color.Transparent;
            pnlMain.Controls.Add(scMainContainer);
            pnlMain.Location = new Point(12, 53);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(1336, 703);
            pnlMain.TabIndex = 9;
            // 
            // scMainContainer
            // 
            scMainContainer.Dock = DockStyle.Fill;
            scMainContainer.FixedPanel = FixedPanel.Panel1;
            scMainContainer.Location = new Point(0, 0);
            scMainContainer.Name = "scMainContainer";
            // 
            // scMainContainer.Panel1
            // 
            scMainContainer.Panel1.BackColor = Color.Transparent;
            scMainContainer.Panel1.Controls.Add(btnAddBranch);
            scMainContainer.Panel1.Controls.Add(btnAddSupplier);
            scMainContainer.Panel1.Controls.Add(btnAddMaterial);
            scMainContainer.Panel1.Controls.Add(btnAddSize);
            scMainContainer.Panel1.Controls.Add(btnAddColor);
            scMainContainer.Panel1.Controls.Add(btnAddUnit);
            scMainContainer.Panel1.Controls.Add(btnAddCategory);
            scMainContainer.Panel1.Controls.Add(btnSave);
            scMainContainer.Panel1.Controls.Add(cbSize);
            scMainContainer.Panel1.Controls.Add(lblSize);
            scMainContainer.Panel1.Controls.Add(cbBranch);
            scMainContainer.Panel1.Controls.Add(cbSupplier);
            scMainContainer.Panel1.Controls.Add(cbMaterial);
            scMainContainer.Panel1.Controls.Add(cbColor);
            scMainContainer.Panel1.Controls.Add(cbUnit);
            scMainContainer.Panel1.Controls.Add(btnClearPage);
            scMainContainer.Panel1.Controls.Add(cbCategory);
            scMainContainer.Panel1.Controls.Add(lblBranch);
            scMainContainer.Panel1.Controls.Add(tbSalePrice3);
            scMainContainer.Panel1.Controls.Add(label15);
            scMainContainer.Panel1.Controls.Add(tbSalePrice2);
            scMainContainer.Panel1.Controls.Add(label14);
            scMainContainer.Panel1.Controls.Add(tbCriticalStock);
            scMainContainer.Panel1.Controls.Add(lblCriticalStock);
            scMainContainer.Panel1.Controls.Add(lblSupplier);
            scMainContainer.Panel1.Controls.Add(tbStock);
            scMainContainer.Panel1.Controls.Add(lblStock);
            scMainContainer.Panel1.Controls.Add(lblMaterial);
            scMainContainer.Panel1.Controls.Add(lblColor);
            scMainContainer.Panel1.Controls.Add(lblUnit);
            scMainContainer.Panel1.Controls.Add(tbSalePrice);
            scMainContainer.Panel1.Controls.Add(lblSalePrice);
            scMainContainer.Panel1.Controls.Add(tbBuyPrice);
            scMainContainer.Panel1.Controls.Add(lblBuyPrice);
            scMainContainer.Panel1.Controls.Add(tbVatRate);
            scMainContainer.Panel1.Controls.Add(lblVatRate);
            scMainContainer.Panel1.Controls.Add(lblCategory);
            scMainContainer.Panel1.Controls.Add(tbProductName);
            scMainContainer.Panel1.Controls.Add(lblProductName);
            scMainContainer.Panel1.Controls.Add(btnCheckBarcode);
            scMainContainer.Panel1.Controls.Add(tbBarcode);
            scMainContainer.Panel1.Controls.Add(lblBarcode);
            scMainContainer.Panel1.Controls.Add(pictureBox1);
            scMainContainer.Panel1.Controls.Add(btnAddPicture);
            scMainContainer.Panel1.Controls.Add(btnNewVariant);
            scMainContainer.Panel1.Controls.Add(btnGiveNextBarcode);
            // 
            // scMainContainer.Panel2
            // 
            scMainContainer.Panel2.Controls.Add(scRightSide);
            scMainContainer.Size = new Size(1336, 703);
            scMainContainer.SplitterDistance = 431;
            scMainContainer.TabIndex = 0;
            // 
            // btnAddBranch
            // 
            btnAddBranch.FlatAppearance.BorderSize = 0;
            btnAddBranch.FlatStyle = FlatStyle.Flat;
            btnAddBranch.Image = Properties.Resources._32pxAdd;
            btnAddBranch.Location = new Point(391, 631);
            btnAddBranch.Name = "btnAddBranch";
            btnAddBranch.Size = new Size(35, 35);
            btnAddBranch.TabIndex = 80;
            btnAddBranch.UseVisualStyleBackColor = true;
            // 
            // btnAddSupplier
            // 
            btnAddSupplier.FlatAppearance.BorderSize = 0;
            btnAddSupplier.FlatStyle = FlatStyle.Flat;
            btnAddSupplier.Image = Properties.Resources._32pxAdd;
            btnAddSupplier.Location = new Point(391, 589);
            btnAddSupplier.Name = "btnAddSupplier";
            btnAddSupplier.Size = new Size(35, 35);
            btnAddSupplier.TabIndex = 79;
            btnAddSupplier.UseVisualStyleBackColor = true;
            // 
            // btnAddMaterial
            // 
            btnAddMaterial.FlatAppearance.BorderSize = 0;
            btnAddMaterial.FlatStyle = FlatStyle.Flat;
            btnAddMaterial.Image = Properties.Resources._32pxAdd;
            btnAddMaterial.Location = new Point(391, 417);
            btnAddMaterial.Name = "btnAddMaterial";
            btnAddMaterial.Size = new Size(35, 35);
            btnAddMaterial.TabIndex = 78;
            btnAddMaterial.UseVisualStyleBackColor = true;
            // 
            // btnAddSize
            // 
            btnAddSize.FlatAppearance.BorderSize = 0;
            btnAddSize.FlatStyle = FlatStyle.Flat;
            btnAddSize.Image = Properties.Resources._32pxAdd;
            btnAddSize.Location = new Point(391, 373);
            btnAddSize.Name = "btnAddSize";
            btnAddSize.Size = new Size(35, 35);
            btnAddSize.TabIndex = 77;
            btnAddSize.UseVisualStyleBackColor = true;
            // 
            // btnAddColor
            // 
            btnAddColor.FlatAppearance.BorderSize = 0;
            btnAddColor.FlatStyle = FlatStyle.Flat;
            btnAddColor.Image = Properties.Resources._32pxAdd;
            btnAddColor.Location = new Point(391, 331);
            btnAddColor.Name = "btnAddColor";
            btnAddColor.Size = new Size(35, 35);
            btnAddColor.TabIndex = 76;
            btnAddColor.UseVisualStyleBackColor = true;
            // 
            // btnAddUnit
            // 
            btnAddUnit.FlatAppearance.BorderSize = 0;
            btnAddUnit.FlatStyle = FlatStyle.Flat;
            btnAddUnit.Image = Properties.Resources._32pxAdd;
            btnAddUnit.Location = new Point(391, 289);
            btnAddUnit.Name = "btnAddUnit";
            btnAddUnit.Size = new Size(35, 35);
            btnAddUnit.TabIndex = 75;
            btnAddUnit.UseVisualStyleBackColor = true;
            // 
            // btnAddCategory
            // 
            btnAddCategory.FlatAppearance.BorderSize = 0;
            btnAddCategory.FlatStyle = FlatStyle.Flat;
            btnAddCategory.Image = Properties.Resources._32pxAdd;
            btnAddCategory.Location = new Point(391, 248);
            btnAddCategory.Name = "btnAddCategory";
            btnAddCategory.Size = new Size(35, 35);
            btnAddCategory.TabIndex = 74;
            btnAddCategory.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.LightGreen;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSave.ForeColor = Color.Black;
            btnSave.ImageAlign = ContentAlignment.TopCenter;
            btnSave.Location = new Point(0, 670);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(428, 33);
            btnSave.TabIndex = 73;
            btnSave.Text = "KAYDET";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // cbSize
            // 
            cbSize.BackColor = Color.White;
            cbSize.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSize.FlatStyle = FlatStyle.Flat;
            cbSize.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            cbSize.FormattingEnabled = true;
            cbSize.Location = new Point(127, 372);
            cbSize.Name = "cbSize";
            cbSize.Size = new Size(260, 36);
            cbSize.TabIndex = 72;
            // 
            // lblSize
            // 
            lblSize.AutoSize = true;
            lblSize.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            lblSize.ForeColor = Color.White;
            lblSize.Location = new Point(3, 375);
            lblSize.Name = "lblSize";
            lblSize.Size = new Size(119, 28);
            lblSize.TabIndex = 71;
            lblSize.Text = "Ölçü/Beden";
            // 
            // cbBranch
            // 
            cbBranch.BackColor = Color.White;
            cbBranch.DropDownStyle = ComboBoxStyle.DropDownList;
            cbBranch.FlatStyle = FlatStyle.Flat;
            cbBranch.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            cbBranch.FormattingEnabled = true;
            cbBranch.Location = new Point(127, 630);
            cbBranch.Name = "cbBranch";
            cbBranch.Size = new Size(260, 36);
            cbBranch.TabIndex = 70;
            // 
            // cbSupplier
            // 
            cbSupplier.BackColor = Color.White;
            cbSupplier.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSupplier.FlatStyle = FlatStyle.Flat;
            cbSupplier.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            cbSupplier.FormattingEnabled = true;
            cbSupplier.Location = new Point(127, 588);
            cbSupplier.Name = "cbSupplier";
            cbSupplier.Size = new Size(260, 36);
            cbSupplier.TabIndex = 69;
            // 
            // cbMaterial
            // 
            cbMaterial.BackColor = Color.White;
            cbMaterial.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMaterial.FlatStyle = FlatStyle.Flat;
            cbMaterial.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            cbMaterial.FormattingEnabled = true;
            cbMaterial.Location = new Point(127, 414);
            cbMaterial.Name = "cbMaterial";
            cbMaterial.Size = new Size(260, 36);
            cbMaterial.TabIndex = 68;
            // 
            // cbColor
            // 
            cbColor.BackColor = Color.White;
            cbColor.DropDownStyle = ComboBoxStyle.DropDownList;
            cbColor.FlatStyle = FlatStyle.Flat;
            cbColor.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            cbColor.FormattingEnabled = true;
            cbColor.Location = new Point(127, 330);
            cbColor.Name = "cbColor";
            cbColor.Size = new Size(260, 36);
            cbColor.TabIndex = 67;
            // 
            // cbUnit
            // 
            cbUnit.BackColor = Color.White;
            cbUnit.DropDownStyle = ComboBoxStyle.DropDownList;
            cbUnit.FlatStyle = FlatStyle.Flat;
            cbUnit.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            cbUnit.FormattingEnabled = true;
            cbUnit.Location = new Point(127, 288);
            cbUnit.Name = "cbUnit";
            cbUnit.Size = new Size(260, 36);
            cbUnit.TabIndex = 66;
            // 
            // btnClearPage
            // 
            btnClearPage.BackColor = Color.FromArgb(83, 98, 123);
            btnClearPage.FlatAppearance.BorderSize = 0;
            btnClearPage.FlatStyle = FlatStyle.Flat;
            btnClearPage.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnClearPage.ForeColor = Color.White;
            btnClearPage.Image = Properties.Resources._64pxWhiteTrashcan;
            btnClearPage.ImageAlign = ContentAlignment.TopCenter;
            btnClearPage.Location = new Point(310, 91);
            btnClearPage.Name = "btnClearPage";
            btnClearPage.Size = new Size(118, 82);
            btnClearPage.TabIndex = 65;
            btnClearPage.Text = "Temizle";
            btnClearPage.TextAlign = ContentAlignment.BottomCenter;
            btnClearPage.UseVisualStyleBackColor = false;
            // 
            // cbCategory
            // 
            cbCategory.BackColor = Color.White;
            cbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCategory.FlatStyle = FlatStyle.Flat;
            cbCategory.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(127, 246);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(260, 36);
            cbCategory.TabIndex = 64;
            // 
            // lblBranch
            // 
            lblBranch.AutoSize = true;
            lblBranch.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            lblBranch.ForeColor = Color.White;
            lblBranch.Location = new Point(3, 633);
            lblBranch.Name = "lblBranch";
            lblBranch.Size = new Size(58, 28);
            lblBranch.TabIndex = 62;
            lblBranch.Text = "Şube";
            // 
            // tbSalePrice3
            // 
            tbSalePrice3.BorderStyle = BorderStyle.None;
            tbSalePrice3.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            tbSalePrice3.Location = new Point(314, 522);
            tbSalePrice3.Name = "tbSalePrice3";
            tbSalePrice3.Size = new Size(73, 27);
            tbSalePrice3.TabIndex = 61;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            label15.ForeColor = Color.White;
            label15.Location = new Point(293, 521);
            label15.Name = "label15";
            label15.Size = new Size(23, 28);
            label15.TabIndex = 60;
            label15.Text = "3";
            // 
            // tbSalePrice2
            // 
            tbSalePrice2.BorderStyle = BorderStyle.None;
            tbSalePrice2.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            tbSalePrice2.Location = new Point(225, 522);
            tbSalePrice2.Name = "tbSalePrice2";
            tbSalePrice2.Size = new Size(73, 27);
            tbSalePrice2.TabIndex = 59;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            label14.ForeColor = Color.White;
            label14.Location = new Point(203, 520);
            label14.Name = "label14";
            label14.Size = new Size(23, 28);
            label14.TabIndex = 58;
            label14.Text = "2";
            // 
            // tbCriticalStock
            // 
            tbCriticalStock.BorderStyle = BorderStyle.None;
            tbCriticalStock.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            tbCriticalStock.Location = new Point(314, 555);
            tbCriticalStock.Name = "tbCriticalStock";
            tbCriticalStock.Size = new Size(73, 27);
            tbCriticalStock.TabIndex = 57;
            // 
            // lblCriticalStock
            // 
            lblCriticalStock.AutoSize = true;
            lblCriticalStock.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            lblCriticalStock.ForeColor = Color.White;
            lblCriticalStock.Location = new Point(203, 554);
            lblCriticalStock.Name = "lblCriticalStock";
            lblCriticalStock.Size = new Size(105, 28);
            lblCriticalStock.TabIndex = 56;
            lblCriticalStock.Text = "Kritik Stok";
            // 
            // lblSupplier
            // 
            lblSupplier.AutoSize = true;
            lblSupplier.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            lblSupplier.ForeColor = Color.White;
            lblSupplier.Location = new Point(4, 591);
            lblSupplier.Name = "lblSupplier";
            lblSupplier.Size = new Size(91, 28);
            lblSupplier.TabIndex = 54;
            lblSupplier.Text = "Tedarikçi";
            // 
            // tbStock
            // 
            tbStock.BorderStyle = BorderStyle.None;
            tbStock.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            tbStock.Location = new Point(127, 555);
            tbStock.Name = "tbStock";
            tbStock.Size = new Size(73, 27);
            tbStock.TabIndex = 53;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            lblStock.ForeColor = Color.White;
            lblStock.Location = new Point(3, 554);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(52, 28);
            lblStock.TabIndex = 52;
            lblStock.Text = "Stok";
            // 
            // lblMaterial
            // 
            lblMaterial.AutoSize = true;
            lblMaterial.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            lblMaterial.ForeColor = Color.White;
            lblMaterial.Location = new Point(3, 417);
            lblMaterial.Name = "lblMaterial";
            lblMaterial.Size = new Size(91, 28);
            lblMaterial.TabIndex = 50;
            lblMaterial.Text = "Materyal";
            // 
            // lblColor
            // 
            lblColor.AutoSize = true;
            lblColor.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            lblColor.ForeColor = Color.White;
            lblColor.Location = new Point(3, 333);
            lblColor.Name = "lblColor";
            lblColor.Size = new Size(57, 28);
            lblColor.TabIndex = 48;
            lblColor.Text = "Renk";
            // 
            // lblUnit
            // 
            lblUnit.AutoSize = true;
            lblUnit.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            lblUnit.ForeColor = Color.White;
            lblUnit.Location = new Point(4, 291);
            lblUnit.Name = "lblUnit";
            lblUnit.Size = new Size(59, 28);
            lblUnit.TabIndex = 46;
            lblUnit.Text = "Birim";
            // 
            // tbSalePrice
            // 
            tbSalePrice.BorderStyle = BorderStyle.None;
            tbSalePrice.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            tbSalePrice.Location = new Point(127, 522);
            tbSalePrice.Name = "tbSalePrice";
            tbSalePrice.Size = new Size(73, 27);
            tbSalePrice.TabIndex = 45;
            // 
            // lblSalePrice
            // 
            lblSalePrice.AutoSize = true;
            lblSalePrice.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            lblSalePrice.ForeColor = Color.White;
            lblSalePrice.Location = new Point(3, 520);
            lblSalePrice.Name = "lblSalePrice";
            lblSalePrice.Size = new Size(107, 28);
            lblSalePrice.TabIndex = 44;
            lblSalePrice.Text = "Satış Fiyatı";
            // 
            // tbBuyPrice
            // 
            tbBuyPrice.BorderStyle = BorderStyle.None;
            tbBuyPrice.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            tbBuyPrice.Location = new Point(127, 489);
            tbBuyPrice.Name = "tbBuyPrice";
            tbBuyPrice.Size = new Size(260, 27);
            tbBuyPrice.TabIndex = 43;
            // 
            // lblBuyPrice
            // 
            lblBuyPrice.AutoSize = true;
            lblBuyPrice.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            lblBuyPrice.ForeColor = Color.White;
            lblBuyPrice.Location = new Point(3, 487);
            lblBuyPrice.Name = "lblBuyPrice";
            lblBuyPrice.Size = new Size(97, 28);
            lblBuyPrice.TabIndex = 42;
            lblBuyPrice.Text = "Alış Fiyatı";
            // 
            // tbVatRate
            // 
            tbVatRate.BorderStyle = BorderStyle.None;
            tbVatRate.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            tbVatRate.Location = new Point(127, 456);
            tbVatRate.Name = "tbVatRate";
            tbVatRate.Size = new Size(260, 27);
            tbVatRate.TabIndex = 41;
            // 
            // lblVatRate
            // 
            lblVatRate.AutoSize = true;
            lblVatRate.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            lblVatRate.ForeColor = Color.White;
            lblVatRate.Location = new Point(3, 454);
            lblVatRate.Name = "lblVatRate";
            lblVatRate.Size = new Size(106, 28);
            lblVatRate.TabIndex = 40;
            lblVatRate.Text = "KDV Oranı";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            lblCategory.ForeColor = Color.White;
            lblCategory.Location = new Point(4, 249);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(88, 28);
            lblCategory.TabIndex = 38;
            lblCategory.Text = "Kategori";
            // 
            // tbProductName
            // 
            tbProductName.BorderStyle = BorderStyle.None;
            tbProductName.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            tbProductName.Location = new Point(127, 213);
            tbProductName.Name = "tbProductName";
            tbProductName.Size = new Size(260, 27);
            tbProductName.TabIndex = 37;
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            lblProductName.ForeColor = Color.White;
            lblProductName.Location = new Point(3, 211);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(93, 28);
            lblProductName.TabIndex = 36;
            lblProductName.Text = "Ürün Adı";
            // 
            // btnCheckBarcode
            // 
            btnCheckBarcode.BackgroundImage = Properties.Resources._32pxTick;
            btnCheckBarcode.FlatAppearance.BorderSize = 0;
            btnCheckBarcode.FlatStyle = FlatStyle.Flat;
            btnCheckBarcode.Location = new Point(391, 176);
            btnCheckBarcode.Name = "btnCheckBarcode";
            btnCheckBarcode.Size = new Size(35, 35);
            btnCheckBarcode.TabIndex = 35;
            btnCheckBarcode.UseVisualStyleBackColor = true;
            // 
            // tbBarcode
            // 
            tbBarcode.BorderStyle = BorderStyle.None;
            tbBarcode.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            tbBarcode.Location = new Point(127, 180);
            tbBarcode.Name = "tbBarcode";
            tbBarcode.Size = new Size(260, 27);
            tbBarcode.TabIndex = 34;
            // 
            // lblBarcode
            // 
            lblBarcode.AutoSize = true;
            lblBarcode.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            lblBarcode.ForeColor = Color.White;
            lblBarcode.Location = new Point(3, 178);
            lblBarcode.Name = "lblBarcode";
            lblBarcode.Size = new Size(109, 28);
            lblBarcode.TabIndex = 33;
            lblBarcode.Text = "Barkod No";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(109, 134, 176);
            pictureBox1.BackgroundImage = Properties.Resources._256pxNoImage;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(133, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(171, 171);
            pictureBox1.TabIndex = 32;
            pictureBox1.TabStop = false;
            // 
            // btnAddPicture
            // 
            btnAddPicture.BackColor = Color.FromArgb(83, 98, 123);
            btnAddPicture.FlatAppearance.BorderSize = 0;
            btnAddPicture.FlatStyle = FlatStyle.Flat;
            btnAddPicture.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnAddPicture.ForeColor = Color.White;
            btnAddPicture.Image = Properties.Resources._64pxImage1;
            btnAddPicture.ImageAlign = ContentAlignment.TopCenter;
            btnAddPicture.Location = new Point(310, 4);
            btnAddPicture.Name = "btnAddPicture";
            btnAddPicture.Size = new Size(118, 82);
            btnAddPicture.TabIndex = 31;
            btnAddPicture.Text = "Resim Ekle";
            btnAddPicture.TextAlign = ContentAlignment.BottomCenter;
            btnAddPicture.UseVisualStyleBackColor = false;
            // 
            // btnNewVariant
            // 
            btnNewVariant.BackColor = Color.FromArgb(83, 98, 123);
            btnNewVariant.FlatAppearance.BorderSize = 0;
            btnNewVariant.FlatStyle = FlatStyle.Flat;
            btnNewVariant.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnNewVariant.ForeColor = Color.White;
            btnNewVariant.Image = Properties.Resources._64pxVariant;
            btnNewVariant.ImageAlign = ContentAlignment.TopCenter;
            btnNewVariant.Location = new Point(9, 91);
            btnNewVariant.Name = "btnNewVariant";
            btnNewVariant.Size = new Size(118, 82);
            btnNewVariant.TabIndex = 30;
            btnNewVariant.Text = "Yeni Variyant";
            btnNewVariant.TextAlign = ContentAlignment.BottomCenter;
            btnNewVariant.UseVisualStyleBackColor = false;
            // 
            // btnGiveNextBarcode
            // 
            btnGiveNextBarcode.BackColor = Color.FromArgb(83, 98, 123);
            btnGiveNextBarcode.FlatAppearance.BorderSize = 0;
            btnGiveNextBarcode.FlatStyle = FlatStyle.Flat;
            btnGiveNextBarcode.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnGiveNextBarcode.ForeColor = Color.White;
            btnGiveNextBarcode.Image = Properties.Resources._64pxWhiteBarcode;
            btnGiveNextBarcode.ImageAlign = ContentAlignment.TopCenter;
            btnGiveNextBarcode.Location = new Point(9, 4);
            btnGiveNextBarcode.Name = "btnGiveNextBarcode";
            btnGiveNextBarcode.Size = new Size(118, 82);
            btnGiveNextBarcode.TabIndex = 29;
            btnGiveNextBarcode.Text = "Oto Barkod";
            btnGiveNextBarcode.TextAlign = ContentAlignment.BottomCenter;
            btnGiveNextBarcode.UseVisualStyleBackColor = false;
            // 
            // scRightSide
            // 
            scRightSide.Dock = DockStyle.Fill;
            scRightSide.FixedPanel = FixedPanel.Panel1;
            scRightSide.Location = new Point(0, 0);
            scRightSide.Name = "scRightSide";
            scRightSide.Orientation = Orientation.Horizontal;
            // 
            // scRightSide.Panel1
            // 
            scRightSide.Panel1.Controls.Add(btnUpdate);
            scRightSide.Panel1.Controls.Add(pbClearSearch);
            scRightSide.Panel1.Controls.Add(pictureBox3);
            scRightSide.Panel1.Controls.Add(rtbSearch);
            // 
            // scRightSide.Panel2
            // 
            scRightSide.Panel2.Controls.Add(dgvMain);
            scRightSide.Size = new Size(901, 703);
            scRightSide.SplitterDistance = 49;
            scRightSide.TabIndex = 0;
            // 
            // pbClearSearch
            // 
            pbClearSearch.BackColor = Color.White;
            pbClearSearch.BackgroundImage = Properties.Resources._16pxCloseBlack;
            pbClearSearch.BackgroundImageLayout = ImageLayout.Center;
            pbClearSearch.Location = new Point(254, 11);
            pbClearSearch.Name = "pbClearSearch";
            pbClearSearch.Size = new Size(26, 26);
            pbClearSearch.TabIndex = 5;
            pbClearSearch.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.White;
            pictureBox3.BackgroundImage = Properties.Resources._16pxSearch;
            pictureBox3.BackgroundImageLayout = ImageLayout.Center;
            pictureBox3.Location = new Point(9, 11);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(26, 26);
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // rtbSearch
            // 
            rtbSearch.BackColor = SystemColors.Window;
            rtbSearch.BorderColor = Color.FromArgb(64, 64, 64);
            rtbSearch.BorderFocusColor = Color.DarkGreen;
            rtbSearch.BorderRadius = 0;
            rtbSearch.BorderSize = 2;
            rtbSearch.Font = new Font("Segoe UI", 13F);
            rtbSearch.ForeColor = Color.Black;
            rtbSearch.Location = new Point(4, 4);
            rtbSearch.Margin = new Padding(4);
            rtbSearch.Multiline = false;
            rtbSearch.Name = "rtbSearch";
            rtbSearch.Padding = new Padding(10, 7, 10, 7);
            rtbSearch.PasswordChar = false;
            rtbSearch.PlaceholderColor = Color.DarkGray;
            rtbSearch.PlaceholderText = "Ara...";
            rtbSearch.Size = new Size(282, 40);
            rtbSearch.TabIndex = 3;
            rtbSearch.Texts = "";
            rtbSearch.UnderlinedStyle = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(83, 98, 123);
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Image = Properties.Resources._24pxWhiteRefresh;
            btnUpdate.ImageAlign = ContentAlignment.MiddleLeft;
            btnUpdate.Location = new Point(778, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(120, 40);
            btnUpdate.TabIndex = 81;
            btnUpdate.Text = "Güncelle";
            btnUpdate.TextAlign = ContentAlignment.MiddleRight;
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // dgvMain
            // 
            dgvMain.AllowUserToAddRows = false;
            dgvMain.AllowUserToDeleteRows = false;
            dgvMain.AllowUserToResizeColumns = false;
            dgvMain.AllowUserToResizeRows = false;
            dgvMain.BackgroundColor = Color.FromArgb(215, 215, 215);
            dgvMain.BorderStyle = BorderStyle.None;
            dgvMain.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvMain.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 162);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvMain.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvMain.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMain.Columns.AddRange(new DataGridViewColumn[] { Barcode, ProductName, Price, Quantity, Total });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.White;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 162);
            dataGridViewCellStyle8.ForeColor = Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.InactiveCaption;
            dataGridViewCellStyle8.SelectionForeColor = Color.Black;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dgvMain.DefaultCellStyle = dataGridViewCellStyle8;
            dgvMain.Dock = DockStyle.Fill;
            dgvMain.EnableHeadersVisualStyles = false;
            dgvMain.GridColor = Color.FromArgb(215, 215, 215);
            dgvMain.Location = new Point(0, 0);
            dgvMain.Name = "dgvMain";
            dgvMain.RowHeadersVisible = false;
            dgvMain.RowTemplate.DividerHeight = 10;
            dgvMain.RowTemplate.Height = 40;
            dgvMain.Size = new Size(901, 650);
            dgvMain.TabIndex = 1;
            // 
            // Barcode
            // 
            Barcode.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Barcode.FillWeight = 18F;
            Barcode.HeaderText = "BARKOD";
            Barcode.Name = "Barcode";
            // 
            // ProductName
            // 
            ProductName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ProductName.FillWeight = 24F;
            ProductName.HeaderText = "ÜRÜN ADI";
            ProductName.Name = "ProductName";
            // 
            // Price
            // 
            Price.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Price.FillWeight = 14F;
            Price.HeaderText = "FİYAT";
            Price.Name = "Price";
            // 
            // Quantity
            // 
            Quantity.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Quantity.DefaultCellStyle = dataGridViewCellStyle6;
            Quantity.FillWeight = 11F;
            Quantity.HeaderText = "ADET";
            Quantity.Name = "Quantity";
            // 
            // Total
            // 
            Total.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Total.DefaultCellStyle = dataGridViewCellStyle7;
            Total.FillWeight = 20F;
            Total.HeaderText = "TOPLAM";
            Total.Name = "Total";
            // 
            // NewProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(1, 40, 100);
            BackgroundImage = Properties.Resources.BackgroundGeneral;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1360, 768);
            Controls.Add(pnlMain);
            Controls.Add(lblPageHeader);
            Controls.Add(btnMinimize);
            Controls.Add(btnMaximize);
            Controls.Add(btnClose);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "NewProduct";
            Opacity = 0D;
            Text = "NewProduct";
            pnlMain.ResumeLayout(false);
            scMainContainer.Panel1.ResumeLayout(false);
            scMainContainer.Panel1.PerformLayout();
            scMainContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)scMainContainer).EndInit();
            scMainContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            scRightSide.Panel1.ResumeLayout(false);
            scRightSide.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)scRightSide).EndInit();
            scRightSide.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbClearSearch).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvMain).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMinimize;
        private Button btnMaximize;
        private Button btnClose;
        private Label lblPageHeader;
        private Panel pnlMain;
        private SplitContainer scMainContainer;
        private Label lblMaterial;
        private Label lblColor;
        private Label lblUnit;
        private TextBox tbSalePrice;
        private Label lblSalePrice;
        private TextBox tbBuyPrice;
        private Label lblBuyPrice;
        private TextBox tbVatRate;
        private Label lblVatRate;
        private Label lblCategory;
        private TextBox tbProductName;
        private Label lblProductName;
        private Button btnCheckBarcode;
        private TextBox tbBarcode;
        private Label lblBarcode;
        private PictureBox pictureBox1;
        private Button btnClearPage;
        private Button btnAddPicture;
        private Button btnNewVariant;
        private Button btnGiveNextBarcode;
        private TextBox tbStock;
        private Label lblStock;
        private TextBox tbCriticalStock;
        private Label lblCriticalStock;
        private Label lblSupplier;
        private TextBox tbSalePrice3;
        private Label label15;
        private TextBox tbSalePrice2;
        private Label label14;
        private Label lblBranch;
        private ComboBox cbCategory;
        private ComboBox cbBranch;
        private ComboBox cbSupplier;
        private ComboBox cbMaterial;
        private ComboBox cbColor;
        private ComboBox cbUnit;
        private ComboBox cbSize;
        private Label lblSize;
        private Button btnSave;
        private Button btnAddBranch;
        private Button btnAddSupplier;
        private Button btnAddMaterial;
        private Button btnAddSize;
        private Button btnAddColor;
        private Button btnAddUnit;
        private Button btnAddCategory;
        private SplitContainer scRightSide;
        private PictureBox pbClearSearch;
        private PictureBox pictureBox3;
        private CustomObjects.RoundTextBox rtbSearch;
        private Button btnUpdate;
        private DataGridView dgvMain;
        private DataGridViewTextBoxColumn Barcode;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Total;
    }
}