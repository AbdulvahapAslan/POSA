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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewProduct));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
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
            tbStockPlace = new TextBox();
            label1 = new Label();
            btnCheckBarcode = new Button();
            cbCurrency = new ComboBox();
            lblCurrency = new Label();
            btnAddBranch = new Button();
            btnAddSupplier = new Button();
            btnAddMaterial = new Button();
            btnAddSize = new Button();
            btnAddColor = new Button();
            btnAddUnit = new Button();
            btnAddCategory = new Button();
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
            tbBarcode = new TextBox();
            lblBarcode = new Label();
            pbProduct = new PictureBox();
            btnAddPicture = new Button();
            btnNewVariant = new Button();
            btnGiveNextBarcode = new Button();
            scRightSide = new SplitContainer();
            lblListingBranch = new Label();
            cbListingBranch = new ComboBox();
            pbClearSearch = new PictureBox();
            pbMagGlass = new PictureBox();
            rtbSearch = new CustomObjects.RoundTextBox();
            btnSaveVariants = new Button();
            dgvMain = new DataGridView();
            BARCODE = new DataGridViewTextBoxColumn();
            VATRATE = new DataGridViewTextBoxColumn();
            NAME = new DataGridViewTextBoxColumn();
            CATEGORY = new DataGridViewTextBoxColumn();
            UNIT = new DataGridViewTextBoxColumn();
            COLOR = new DataGridViewTextBoxColumn();
            SIZE = new DataGridViewTextBoxColumn();
            MATERIAL = new DataGridViewTextBoxColumn();
            BUYINGPRICE = new DataGridViewTextBoxColumn();
            SELLPRICE = new DataGridViewTextBoxColumn();
            SELLPRICE2 = new DataGridViewTextBoxColumn();
            SELLPRICE3 = new DataGridViewTextBoxColumn();
            CURRENCY = new DataGridViewTextBoxColumn();
            STOCK = new DataGridViewTextBoxColumn();
            CRITICALSTOCK = new DataGridViewTextBoxColumn();
            SUPPLIER = new DataGridViewTextBoxColumn();
            BRANCH = new DataGridViewTextBoxColumn();
            B64IMAGE = new DataGridViewTextBoxColumn();
            STOCKPLACE = new DataGridViewTextBoxColumn();
            dgvVariant = new DataGridView();
            VBARCODE = new DataGridViewTextBoxColumn();
            VNAME = new DataGridViewTextBoxColumn();
            VCATEGORY = new DataGridViewTextBoxColumn();
            VUNIT = new DataGridViewTextBoxColumn();
            VCOLOR = new DataGridViewTextBoxColumn();
            VSIZE = new DataGridViewTextBoxColumn();
            VMATERIAL = new DataGridViewTextBoxColumn();
            VBUYPRICE = new DataGridViewTextBoxColumn();
            VSELLPRICE = new DataGridViewTextBoxColumn();
            VSELLPRICE2 = new DataGridViewTextBoxColumn();
            VSELLPRICE3 = new DataGridViewTextBoxColumn();
            VVATRATE = new DataGridViewTextBoxColumn();
            VCURRENCY = new DataGridViewTextBoxColumn();
            VSTOCK = new DataGridViewTextBoxColumn();
            VCRITICALSTOCK = new DataGridViewTextBoxColumn();
            VSUPPLIER = new DataGridViewTextBoxColumn();
            VBRANCH = new DataGridViewTextBoxColumn();
            btnSave = new Button();
            tmrNewProduct = new System.Windows.Forms.Timer(components);
            pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)scMainContainer).BeginInit();
            scMainContainer.Panel1.SuspendLayout();
            scMainContainer.Panel2.SuspendLayout();
            scMainContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbProduct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)scRightSide).BeginInit();
            scRightSide.Panel1.SuspendLayout();
            scRightSide.Panel2.SuspendLayout();
            scRightSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbClearSearch).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbMagGlass).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvMain).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvVariant).BeginInit();
            SuspendLayout();
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimize.BackColor = Color.Transparent;
            btnMinimize.BackgroundImage = (Image)resources.GetObject("btnMinimize.BackgroundImage");
            btnMinimize.BackgroundImageLayout = ImageLayout.Center;
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.ForeColor = Color.White;
            btnMinimize.Location = new Point(1132, 12);
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
            btnMaximize.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnMaximize.FlatStyle = FlatStyle.Flat;
            btnMaximize.ForeColor = Color.White;
            btnMaximize.Location = new Point(1205, 12);
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
            btnClose.FlatAppearance.MouseOverBackColor = Color.Red;
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
            scMainContainer.Panel1.Controls.Add(tbStockPlace);
            scMainContainer.Panel1.Controls.Add(label1);
            scMainContainer.Panel1.Controls.Add(btnCheckBarcode);
            scMainContainer.Panel1.Controls.Add(cbCurrency);
            scMainContainer.Panel1.Controls.Add(lblCurrency);
            scMainContainer.Panel1.Controls.Add(btnAddBranch);
            scMainContainer.Panel1.Controls.Add(btnAddSupplier);
            scMainContainer.Panel1.Controls.Add(btnAddMaterial);
            scMainContainer.Panel1.Controls.Add(btnAddSize);
            scMainContainer.Panel1.Controls.Add(btnAddColor);
            scMainContainer.Panel1.Controls.Add(btnAddUnit);
            scMainContainer.Panel1.Controls.Add(btnAddCategory);
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
            scMainContainer.Panel1.Controls.Add(tbBarcode);
            scMainContainer.Panel1.Controls.Add(lblBarcode);
            scMainContainer.Panel1.Controls.Add(pbProduct);
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
            // tbStockPlace
            // 
            tbStockPlace.BorderStyle = BorderStyle.None;
            tbStockPlace.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold);
            tbStockPlace.Location = new Point(127, 647);
            tbStockPlace.Name = "tbStockPlace";
            tbStockPlace.Size = new Size(260, 23);
            tbStockPlace.TabIndex = 85;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 645);
            label1.Name = "label1";
            label1.Size = new Size(36, 23);
            label1.TabIndex = 84;
            label1.Text = "Raf";
            // 
            // btnCheckBarcode
            // 
            btnCheckBarcode.FlatAppearance.BorderSize = 0;
            btnCheckBarcode.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnCheckBarcode.FlatStyle = FlatStyle.Flat;
            btnCheckBarcode.Image = Properties.Resources._32pxTick;
            btnCheckBarcode.Location = new Point(391, 171);
            btnCheckBarcode.Name = "btnCheckBarcode";
            btnCheckBarcode.Size = new Size(35, 35);
            btnCheckBarcode.TabIndex = 83;
            btnCheckBarcode.UseVisualStyleBackColor = true;
            btnCheckBarcode.Click += btnCheckBarcode_Click;
            // 
            // cbCurrency
            // 
            cbCurrency.BackColor = Color.White;
            cbCurrency.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCurrency.FlatStyle = FlatStyle.Flat;
            cbCurrency.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold);
            cbCurrency.FormattingEnabled = true;
            cbCurrency.Items.AddRange(new object[] { "TL", "USD", "EURO" });
            cbCurrency.Location = new Point(127, 536);
            cbCurrency.Name = "cbCurrency";
            cbCurrency.Size = new Size(260, 31);
            cbCurrency.TabIndex = 82;
            // 
            // lblCurrency
            // 
            lblCurrency.AutoSize = true;
            lblCurrency.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold);
            lblCurrency.ForeColor = Color.White;
            lblCurrency.Location = new Point(3, 539);
            lblCurrency.Name = "lblCurrency";
            lblCurrency.Size = new Size(94, 23);
            lblCurrency.TabIndex = 81;
            lblCurrency.Text = "Döviz Cinsi";
            // 
            // btnAddBranch
            // 
            btnAddBranch.FlatAppearance.BorderSize = 0;
            btnAddBranch.FlatStyle = FlatStyle.Flat;
            btnAddBranch.Image = Properties.Resources._32pxAdd;
            btnAddBranch.Location = new Point(391, 608);
            btnAddBranch.Name = "btnAddBranch";
            btnAddBranch.Size = new Size(35, 35);
            btnAddBranch.TabIndex = 80;
            btnAddBranch.UseVisualStyleBackColor = true;
            btnAddBranch.Click += btnAddBranch_Click;
            // 
            // btnAddSupplier
            // 
            btnAddSupplier.FlatAppearance.BorderSize = 0;
            btnAddSupplier.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnAddSupplier.FlatStyle = FlatStyle.Flat;
            btnAddSupplier.Image = Properties.Resources._32pxAdd;
            btnAddSupplier.Location = new Point(391, 571);
            btnAddSupplier.Name = "btnAddSupplier";
            btnAddSupplier.Size = new Size(35, 35);
            btnAddSupplier.TabIndex = 79;
            btnAddSupplier.UseVisualStyleBackColor = true;
            btnAddSupplier.Click += btnAddSupplier_Click;
            // 
            // btnAddMaterial
            // 
            btnAddMaterial.FlatAppearance.BorderSize = 0;
            btnAddMaterial.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnAddMaterial.FlatStyle = FlatStyle.Flat;
            btnAddMaterial.Image = Properties.Resources._32pxAdd;
            btnAddMaterial.Location = new Point(391, 381);
            btnAddMaterial.Name = "btnAddMaterial";
            btnAddMaterial.Size = new Size(35, 35);
            btnAddMaterial.TabIndex = 78;
            btnAddMaterial.UseVisualStyleBackColor = true;
            btnAddMaterial.Click += btnAddMaterial_Click;
            // 
            // btnAddSize
            // 
            btnAddSize.FlatAppearance.BorderSize = 0;
            btnAddSize.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnAddSize.FlatStyle = FlatStyle.Flat;
            btnAddSize.Image = Properties.Resources._32pxAdd;
            btnAddSize.Location = new Point(391, 344);
            btnAddSize.Name = "btnAddSize";
            btnAddSize.Size = new Size(35, 35);
            btnAddSize.TabIndex = 77;
            btnAddSize.UseVisualStyleBackColor = true;
            btnAddSize.Click += btnAddSize_Click;
            // 
            // btnAddColor
            // 
            btnAddColor.FlatAppearance.BorderSize = 0;
            btnAddColor.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnAddColor.FlatStyle = FlatStyle.Flat;
            btnAddColor.Image = Properties.Resources._32pxAdd;
            btnAddColor.Location = new Point(391, 307);
            btnAddColor.Name = "btnAddColor";
            btnAddColor.Size = new Size(35, 35);
            btnAddColor.TabIndex = 76;
            btnAddColor.UseVisualStyleBackColor = true;
            btnAddColor.Click += btnAddColor_Click;
            // 
            // btnAddUnit
            // 
            btnAddUnit.FlatAppearance.BorderSize = 0;
            btnAddUnit.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnAddUnit.FlatStyle = FlatStyle.Flat;
            btnAddUnit.Image = Properties.Resources._32pxAdd;
            btnAddUnit.Location = new Point(391, 270);
            btnAddUnit.Name = "btnAddUnit";
            btnAddUnit.Size = new Size(35, 35);
            btnAddUnit.TabIndex = 75;
            btnAddUnit.UseVisualStyleBackColor = true;
            btnAddUnit.Click += btnAddUnit_Click;
            // 
            // btnAddCategory
            // 
            btnAddCategory.FlatAppearance.BorderSize = 0;
            btnAddCategory.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnAddCategory.FlatStyle = FlatStyle.Flat;
            btnAddCategory.Image = Properties.Resources._32pxAdd;
            btnAddCategory.Location = new Point(391, 232);
            btnAddCategory.Name = "btnAddCategory";
            btnAddCategory.Size = new Size(35, 35);
            btnAddCategory.TabIndex = 74;
            btnAddCategory.UseVisualStyleBackColor = true;
            btnAddCategory.Click += btnAddCategory_Click;
            // 
            // cbSize
            // 
            cbSize.BackColor = Color.White;
            cbSize.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSize.FlatStyle = FlatStyle.Flat;
            cbSize.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold);
            cbSize.FormattingEnabled = true;
            cbSize.Location = new Point(127, 346);
            cbSize.Name = "cbSize";
            cbSize.Size = new Size(260, 31);
            cbSize.TabIndex = 72;
            // 
            // lblSize
            // 
            lblSize.AutoSize = true;
            lblSize.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold);
            lblSize.ForeColor = Color.White;
            lblSize.Location = new Point(3, 349);
            lblSize.Name = "lblSize";
            lblSize.Size = new Size(100, 23);
            lblSize.TabIndex = 71;
            lblSize.Text = "Ölçü/Beden";
            // 
            // cbBranch
            // 
            cbBranch.BackColor = Color.White;
            cbBranch.DropDownStyle = ComboBoxStyle.DropDownList;
            cbBranch.FlatStyle = FlatStyle.Flat;
            cbBranch.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold);
            cbBranch.FormattingEnabled = true;
            cbBranch.Location = new Point(127, 610);
            cbBranch.Name = "cbBranch";
            cbBranch.Size = new Size(260, 31);
            cbBranch.TabIndex = 70;
            // 
            // cbSupplier
            // 
            cbSupplier.BackColor = Color.White;
            cbSupplier.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSupplier.FlatStyle = FlatStyle.Flat;
            cbSupplier.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold);
            cbSupplier.FormattingEnabled = true;
            cbSupplier.Location = new Point(127, 573);
            cbSupplier.Name = "cbSupplier";
            cbSupplier.Size = new Size(260, 31);
            cbSupplier.TabIndex = 69;
            // 
            // cbMaterial
            // 
            cbMaterial.BackColor = Color.White;
            cbMaterial.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMaterial.FlatStyle = FlatStyle.Flat;
            cbMaterial.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold);
            cbMaterial.FormattingEnabled = true;
            cbMaterial.Location = new Point(127, 383);
            cbMaterial.Name = "cbMaterial";
            cbMaterial.Size = new Size(260, 31);
            cbMaterial.TabIndex = 68;
            // 
            // cbColor
            // 
            cbColor.BackColor = Color.White;
            cbColor.DropDownStyle = ComboBoxStyle.DropDownList;
            cbColor.FlatStyle = FlatStyle.Flat;
            cbColor.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold);
            cbColor.FormattingEnabled = true;
            cbColor.Location = new Point(127, 309);
            cbColor.Name = "cbColor";
            cbColor.Size = new Size(260, 31);
            cbColor.TabIndex = 67;
            // 
            // cbUnit
            // 
            cbUnit.BackColor = Color.White;
            cbUnit.DropDownStyle = ComboBoxStyle.DropDownList;
            cbUnit.FlatStyle = FlatStyle.Flat;
            cbUnit.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold);
            cbUnit.FormattingEnabled = true;
            cbUnit.Location = new Point(127, 272);
            cbUnit.Name = "cbUnit";
            cbUnit.Size = new Size(260, 31);
            cbUnit.TabIndex = 66;
            // 
            // btnClearPage
            // 
            btnClearPage.BackColor = Color.FromArgb(83, 98, 123);
            btnClearPage.FlatAppearance.BorderSize = 0;
            btnClearPage.FlatAppearance.MouseOverBackColor = Color.FromArgb(108, 128, 161);
            btnClearPage.FlatStyle = FlatStyle.Flat;
            btnClearPage.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnClearPage.ForeColor = Color.White;
            btnClearPage.Image = Properties.Resources._64pxSmallWhiteTrash;
            btnClearPage.ImageAlign = ContentAlignment.TopCenter;
            btnClearPage.Location = new Point(310, 88);
            btnClearPage.Name = "btnClearPage";
            btnClearPage.Size = new Size(118, 82);
            btnClearPage.TabIndex = 65;
            btnClearPage.Text = "Temizle";
            btnClearPage.TextAlign = ContentAlignment.BottomCenter;
            btnClearPage.UseVisualStyleBackColor = false;
            btnClearPage.Click += btnClearPage_Click;
            // 
            // cbCategory
            // 
            cbCategory.BackColor = Color.White;
            cbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCategory.FlatStyle = FlatStyle.Flat;
            cbCategory.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold);
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(127, 235);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(260, 31);
            cbCategory.TabIndex = 64;
            // 
            // lblBranch
            // 
            lblBranch.AutoSize = true;
            lblBranch.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold);
            lblBranch.ForeColor = Color.White;
            lblBranch.Location = new Point(3, 613);
            lblBranch.Name = "lblBranch";
            lblBranch.Size = new Size(48, 23);
            lblBranch.TabIndex = 62;
            lblBranch.Text = "Şube";
            // 
            // tbSalePrice3
            // 
            tbSalePrice3.BorderStyle = BorderStyle.None;
            tbSalePrice3.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold);
            tbSalePrice3.Location = new Point(320, 478);
            tbSalePrice3.Name = "tbSalePrice3";
            tbSalePrice3.Size = new Size(67, 23);
            tbSalePrice3.TabIndex = 61;
            tbSalePrice3.Text = "0";
            tbSalePrice3.KeyPress += GeneralOnlyDecimalNumberTextBox_KeyPress;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BorderStyle = BorderStyle.FixedSingle;
            label15.Font = new Font("Segoe UI Semibold", 12.5F, FontStyle.Bold);
            label15.ForeColor = Color.White;
            label15.Location = new Point(297, 477);
            label15.Name = "label15";
            label15.Size = new Size(76, 25);
            label15.TabIndex = 60;
            label15.Text = "3           ";
            label15.TextAlign = ContentAlignment.MiddleLeft;
            label15.Paint += labelBorderPainter_Paint;
            // 
            // tbSalePrice2
            // 
            tbSalePrice2.BorderStyle = BorderStyle.None;
            tbSalePrice2.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold);
            tbSalePrice2.Location = new Point(224, 478);
            tbSalePrice2.Name = "tbSalePrice2";
            tbSalePrice2.Size = new Size(70, 23);
            tbSalePrice2.TabIndex = 59;
            tbSalePrice2.Text = "0";
            tbSalePrice2.KeyPress += GeneralOnlyDecimalNumberTextBox_KeyPress;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BorderStyle = BorderStyle.FixedSingle;
            label14.Font = new Font("Segoe UI Semibold", 12.5F, FontStyle.Bold);
            label14.ForeColor = Color.White;
            label14.Location = new Point(204, 477);
            label14.Name = "label14";
            label14.Size = new Size(76, 25);
            label14.TabIndex = 58;
            label14.Text = "2           ";
            label14.Paint += labelBorderPainter_Paint;
            // 
            // tbCriticalStock
            // 
            tbCriticalStock.BorderStyle = BorderStyle.None;
            tbCriticalStock.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold);
            tbCriticalStock.Location = new Point(310, 507);
            tbCriticalStock.Name = "tbCriticalStock";
            tbCriticalStock.Size = new Size(77, 23);
            tbCriticalStock.TabIndex = 57;
            tbCriticalStock.Text = "0";
            tbCriticalStock.KeyPress += GeneralOnlyDecimalNumberTextBox_KeyPress;
            // 
            // lblCriticalStock
            // 
            lblCriticalStock.AutoSize = true;
            lblCriticalStock.BorderStyle = BorderStyle.FixedSingle;
            lblCriticalStock.Font = new Font("Segoe UI Semibold", 12.5F, FontStyle.Bold);
            lblCriticalStock.ForeColor = Color.White;
            lblCriticalStock.Location = new Point(203, 506);
            lblCriticalStock.Name = "lblCriticalStock";
            lblCriticalStock.Size = new Size(155, 25);
            lblCriticalStock.TabIndex = 56;
            lblCriticalStock.Text = "Kritik Stok             ";
            lblCriticalStock.Paint += labelBorderPainter_Paint;
            // 
            // lblSupplier
            // 
            lblSupplier.AutoSize = true;
            lblSupplier.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold);
            lblSupplier.ForeColor = Color.White;
            lblSupplier.Location = new Point(4, 576);
            lblSupplier.Name = "lblSupplier";
            lblSupplier.Size = new Size(76, 23);
            lblSupplier.TabIndex = 54;
            lblSupplier.Text = "Tedarikçi";
            // 
            // tbStock
            // 
            tbStock.BorderStyle = BorderStyle.None;
            tbStock.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold);
            tbStock.Location = new Point(127, 507);
            tbStock.Name = "tbStock";
            tbStock.Size = new Size(73, 23);
            tbStock.TabIndex = 53;
            tbStock.Text = "0";
            tbStock.KeyPress += GeneralOnlyDecimalNumberTextBox_KeyPress;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold);
            lblStock.ForeColor = Color.White;
            lblStock.Location = new Point(3, 506);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(44, 23);
            lblStock.TabIndex = 52;
            lblStock.Text = "Stok";
            // 
            // lblMaterial
            // 
            lblMaterial.AutoSize = true;
            lblMaterial.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold);
            lblMaterial.ForeColor = Color.White;
            lblMaterial.Location = new Point(3, 386);
            lblMaterial.Name = "lblMaterial";
            lblMaterial.Size = new Size(79, 23);
            lblMaterial.TabIndex = 50;
            lblMaterial.Text = "Materyal";
            // 
            // lblColor
            // 
            lblColor.AutoSize = true;
            lblColor.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold);
            lblColor.ForeColor = Color.White;
            lblColor.Location = new Point(3, 312);
            lblColor.Name = "lblColor";
            lblColor.Size = new Size(49, 23);
            lblColor.TabIndex = 48;
            lblColor.Text = "Renk";
            // 
            // lblUnit
            // 
            lblUnit.AutoSize = true;
            lblUnit.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold);
            lblUnit.ForeColor = Color.White;
            lblUnit.Location = new Point(4, 275);
            lblUnit.Name = "lblUnit";
            lblUnit.Size = new Size(49, 23);
            lblUnit.TabIndex = 46;
            lblUnit.Text = "Birim";
            // 
            // tbSalePrice
            // 
            tbSalePrice.BorderStyle = BorderStyle.None;
            tbSalePrice.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold);
            tbSalePrice.Location = new Point(127, 478);
            tbSalePrice.Name = "tbSalePrice";
            tbSalePrice.Size = new Size(73, 23);
            tbSalePrice.TabIndex = 45;
            tbSalePrice.Text = "0";
            tbSalePrice.KeyPress += GeneralOnlyDecimalNumberTextBox_KeyPress;
            // 
            // lblSalePrice
            // 
            lblSalePrice.AutoSize = true;
            lblSalePrice.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold);
            lblSalePrice.ForeColor = Color.White;
            lblSalePrice.Location = new Point(3, 476);
            lblSalePrice.Name = "lblSalePrice";
            lblSalePrice.Size = new Size(91, 23);
            lblSalePrice.TabIndex = 44;
            lblSalePrice.Text = "Satış Fiyatı";
            // 
            // tbBuyPrice
            // 
            tbBuyPrice.BorderStyle = BorderStyle.None;
            tbBuyPrice.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold);
            tbBuyPrice.Location = new Point(127, 449);
            tbBuyPrice.Name = "tbBuyPrice";
            tbBuyPrice.Size = new Size(260, 23);
            tbBuyPrice.TabIndex = 43;
            tbBuyPrice.Text = "0";
            tbBuyPrice.KeyPress += GeneralOnlyDecimalNumberTextBox_KeyPress;
            // 
            // lblBuyPrice
            // 
            lblBuyPrice.AutoSize = true;
            lblBuyPrice.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold);
            lblBuyPrice.ForeColor = Color.White;
            lblBuyPrice.Location = new Point(3, 447);
            lblBuyPrice.Name = "lblBuyPrice";
            lblBuyPrice.Size = new Size(82, 23);
            lblBuyPrice.TabIndex = 42;
            lblBuyPrice.Text = "Alış Fiyatı";
            // 
            // tbVatRate
            // 
            tbVatRate.BorderStyle = BorderStyle.None;
            tbVatRate.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold);
            tbVatRate.Location = new Point(127, 420);
            tbVatRate.Name = "tbVatRate";
            tbVatRate.Size = new Size(260, 23);
            tbVatRate.TabIndex = 41;
            tbVatRate.Text = "0";
            tbVatRate.KeyPress += GeneralOnlyDecimalNumberTextBox_KeyPress;
            // 
            // lblVatRate
            // 
            lblVatRate.AutoSize = true;
            lblVatRate.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold);
            lblVatRate.ForeColor = Color.White;
            lblVatRate.Location = new Point(3, 418);
            lblVatRate.Name = "lblVatRate";
            lblVatRate.Size = new Size(90, 23);
            lblVatRate.TabIndex = 40;
            lblVatRate.Text = "KDV Oranı";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold);
            lblCategory.ForeColor = Color.White;
            lblCategory.Location = new Point(4, 238);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(74, 23);
            lblCategory.TabIndex = 38;
            lblCategory.Text = "Kategori";
            // 
            // tbProductName
            // 
            tbProductName.BorderStyle = BorderStyle.None;
            tbProductName.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold);
            tbProductName.Location = new Point(127, 206);
            tbProductName.Name = "tbProductName";
            tbProductName.Size = new Size(260, 23);
            tbProductName.TabIndex = 37;
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold);
            lblProductName.ForeColor = Color.White;
            lblProductName.Location = new Point(3, 204);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(78, 23);
            lblProductName.TabIndex = 36;
            lblProductName.Text = "Ürün Adı";
            // 
            // tbBarcode
            // 
            tbBarcode.BorderStyle = BorderStyle.None;
            tbBarcode.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold);
            tbBarcode.Location = new Point(127, 177);
            tbBarcode.Name = "tbBarcode";
            tbBarcode.Size = new Size(260, 23);
            tbBarcode.TabIndex = 34;
            // 
            // lblBarcode
            // 
            lblBarcode.AutoSize = true;
            lblBarcode.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold);
            lblBarcode.ForeColor = Color.White;
            lblBarcode.Location = new Point(3, 175);
            lblBarcode.Name = "lblBarcode";
            lblBarcode.Size = new Size(92, 23);
            lblBarcode.TabIndex = 33;
            lblBarcode.Text = "Barkod No";
            // 
            // pbProduct
            // 
            pbProduct.BackColor = Color.FromArgb(109, 134, 176);
            pbProduct.BackgroundImage = Properties.Resources._256pxNoImage;
            pbProduct.BackgroundImageLayout = ImageLayout.Zoom;
            pbProduct.Location = new Point(133, 0);
            pbProduct.Name = "pbProduct";
            pbProduct.Size = new Size(171, 171);
            pbProduct.TabIndex = 32;
            pbProduct.TabStop = false;
            // 
            // btnAddPicture
            // 
            btnAddPicture.BackColor = Color.FromArgb(83, 98, 123);
            btnAddPicture.FlatAppearance.BorderSize = 0;
            btnAddPicture.FlatAppearance.MouseOverBackColor = Color.FromArgb(108, 128, 161);
            btnAddPicture.FlatStyle = FlatStyle.Flat;
            btnAddPicture.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnAddPicture.ForeColor = Color.White;
            btnAddPicture.Image = Properties.Resources._64pxPicture;
            btnAddPicture.ImageAlign = ContentAlignment.TopCenter;
            btnAddPicture.Location = new Point(310, 1);
            btnAddPicture.Name = "btnAddPicture";
            btnAddPicture.Size = new Size(118, 82);
            btnAddPicture.TabIndex = 31;
            btnAddPicture.Text = "Resim Ekle";
            btnAddPicture.TextAlign = ContentAlignment.BottomCenter;
            btnAddPicture.UseVisualStyleBackColor = false;
            btnAddPicture.Click += btnAddPicture_Click;
            // 
            // btnNewVariant
            // 
            btnNewVariant.BackColor = Color.FromArgb(83, 98, 123);
            btnNewVariant.FlatAppearance.BorderSize = 0;
            btnNewVariant.FlatAppearance.MouseOverBackColor = Color.FromArgb(108, 128, 161);
            btnNewVariant.FlatStyle = FlatStyle.Flat;
            btnNewVariant.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnNewVariant.ForeColor = Color.White;
            btnNewVariant.Image = Properties.Resources._64pxVariant1;
            btnNewVariant.ImageAlign = ContentAlignment.TopCenter;
            btnNewVariant.Location = new Point(9, 88);
            btnNewVariant.Name = "btnNewVariant";
            btnNewVariant.Size = new Size(118, 82);
            btnNewVariant.TabIndex = 30;
            btnNewVariant.Text = "Varyantlı Ekle";
            btnNewVariant.TextAlign = ContentAlignment.BottomCenter;
            btnNewVariant.UseVisualStyleBackColor = false;
            btnNewVariant.Click += btnNewVariant_Click;
            // 
            // btnGiveNextBarcode
            // 
            btnGiveNextBarcode.BackColor = Color.FromArgb(83, 98, 123);
            btnGiveNextBarcode.FlatAppearance.BorderSize = 0;
            btnGiveNextBarcode.FlatAppearance.MouseOverBackColor = Color.FromArgb(108, 128, 161);
            btnGiveNextBarcode.FlatStyle = FlatStyle.Flat;
            btnGiveNextBarcode.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnGiveNextBarcode.ForeColor = Color.White;
            btnGiveNextBarcode.Image = Properties.Resources._64pxWhiteBarcode1;
            btnGiveNextBarcode.Location = new Point(9, 1);
            btnGiveNextBarcode.Name = "btnGiveNextBarcode";
            btnGiveNextBarcode.Size = new Size(118, 82);
            btnGiveNextBarcode.TabIndex = 29;
            btnGiveNextBarcode.Text = "Oto Barkod";
            btnGiveNextBarcode.TextAlign = ContentAlignment.BottomCenter;
            btnGiveNextBarcode.UseVisualStyleBackColor = false;
            btnGiveNextBarcode.Click += btnGiveNextBarcode_Click;
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
            scRightSide.Panel1.Controls.Add(lblListingBranch);
            scRightSide.Panel1.Controls.Add(cbListingBranch);
            scRightSide.Panel1.Controls.Add(pbClearSearch);
            scRightSide.Panel1.Controls.Add(pbMagGlass);
            scRightSide.Panel1.Controls.Add(rtbSearch);
            scRightSide.Panel1.Controls.Add(btnSaveVariants);
            // 
            // scRightSide.Panel2
            // 
            scRightSide.Panel2.BackColor = Color.White;
            scRightSide.Panel2.Controls.Add(dgvMain);
            scRightSide.Panel2.Controls.Add(dgvVariant);
            scRightSide.Size = new Size(901, 703);
            scRightSide.SplitterDistance = 49;
            scRightSide.TabIndex = 0;
            // 
            // lblListingBranch
            // 
            lblListingBranch.AutoSize = true;
            lblListingBranch.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold);
            lblListingBranch.ForeColor = Color.White;
            lblListingBranch.Location = new Point(329, 13);
            lblListingBranch.Name = "lblListingBranch";
            lblListingBranch.Size = new Size(129, 23);
            lblListingBranch.TabIndex = 83;
            lblListingBranch.Text = "Listelenen Şube";
            // 
            // cbListingBranch
            // 
            cbListingBranch.BackColor = Color.White;
            cbListingBranch.DropDownStyle = ComboBoxStyle.DropDownList;
            cbListingBranch.FlatStyle = FlatStyle.Flat;
            cbListingBranch.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold);
            cbListingBranch.FormattingEnabled = true;
            cbListingBranch.Location = new Point(464, 10);
            cbListingBranch.Name = "cbListingBranch";
            cbListingBranch.Size = new Size(206, 31);
            cbListingBranch.TabIndex = 83;
            cbListingBranch.SelectedIndexChanged += cbListingBranch_SelectedIndexChanged;
            // 
            // pbClearSearch
            // 
            pbClearSearch.BackColor = Color.White;
            pbClearSearch.BackgroundImage = Properties.Resources._16pxCloseBlack;
            pbClearSearch.BackgroundImageLayout = ImageLayout.Center;
            pbClearSearch.Location = new Point(259, 14);
            pbClearSearch.Name = "pbClearSearch";
            pbClearSearch.Size = new Size(26, 26);
            pbClearSearch.TabIndex = 5;
            pbClearSearch.TabStop = false;
            // 
            // pbMagGlass
            // 
            pbMagGlass.BackColor = Color.White;
            pbMagGlass.BackgroundImage = Properties.Resources._16pxSearch;
            pbMagGlass.BackgroundImageLayout = ImageLayout.Center;
            pbMagGlass.Location = new Point(15, 14);
            pbMagGlass.Name = "pbMagGlass";
            pbMagGlass.Size = new Size(26, 26);
            pbMagGlass.TabIndex = 4;
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
            rtbSearch.Location = new Point(10, 10);
            rtbSearch.Margin = new Padding(4);
            rtbSearch.Multiline = false;
            rtbSearch.Name = "rtbSearch";
            rtbSearch.Padding = new Padding(35, 7, 30, 7);
            rtbSearch.PasswordChar = false;
            rtbSearch.PlaceholderColor = Color.DarkGray;
            rtbSearch.PlaceholderText = "Ara...";
            rtbSearch.Size = new Size(278, 34);
            rtbSearch.TabIndex = 82;
            rtbSearch.Texts = "";
            rtbSearch.UnderlinedStyle = false;
            rtbSearch._TextChanged += rtbSearch__TextChanged;
            rtbSearch.KeyDown += rtbSearch_KeyDown;
            // 
            // btnSaveVariants
            // 
            btnSaveVariants.BackColor = Color.LightGreen;
            btnSaveVariants.FlatAppearance.BorderSize = 0;
            btnSaveVariants.FlatStyle = FlatStyle.Flat;
            btnSaveVariants.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSaveVariants.ForeColor = Color.Black;
            btnSaveVariants.ImageAlign = ContentAlignment.MiddleLeft;
            btnSaveVariants.Location = new Point(741, 10);
            btnSaveVariants.Name = "btnSaveVariants";
            btnSaveVariants.Size = new Size(157, 34);
            btnSaveVariants.TabIndex = 81;
            btnSaveVariants.Text = "Varyantları Kaydet";
            btnSaveVariants.TextAlign = ContentAlignment.MiddleRight;
            btnSaveVariants.UseVisualStyleBackColor = false;
            btnSaveVariants.Visible = false;
            btnSaveVariants.Click += btnSaveVariants_Click;
            // 
            // dgvMain
            // 
            dgvMain.AllowUserToAddRows = false;
            dgvMain.AllowUserToDeleteRows = false;
            dgvMain.AllowUserToResizeColumns = false;
            dgvMain.AllowUserToResizeRows = false;
            dgvMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvMain.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dgvMain.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvMain.BackgroundColor = Color.White;
            dgvMain.BorderStyle = BorderStyle.None;
            dgvMain.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvMain.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(1, 39, 103);
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(1, 39, 103);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvMain.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvMain.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMain.Columns.AddRange(new DataGridViewColumn[] { BARCODE, VATRATE, NAME, CATEGORY, UNIT, COLOR, SIZE, MATERIAL, BUYINGPRICE, SELLPRICE, SELLPRICE2, SELLPRICE3, CURRENCY, STOCK, CRITICALSTOCK, SUPPLIER, BRANCH, B64IMAGE, STOCKPLACE });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 162);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.InactiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvMain.DefaultCellStyle = dataGridViewCellStyle4;
            dgvMain.EnableHeadersVisualStyles = false;
            dgvMain.GridColor = Color.White;
            dgvMain.Location = new Point(7, 7);
            dgvMain.Margin = new Padding(7);
            dgvMain.Name = "dgvMain";
            dgvMain.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvMain.RowHeadersVisible = false;
            dgvMain.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvMain.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(210, 226, 252);
            dgvMain.RowTemplate.DefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvMain.RowTemplate.DefaultCellStyle.ForeColor = Color.FromArgb(1, 39, 103);
            dgvMain.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(109, 134, 176);
            dgvMain.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvMain.RowTemplate.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvMain.RowTemplate.DividerHeight = 10;
            dgvMain.RowTemplate.Height = 50;
            dgvMain.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMain.Size = new Size(887, 636);
            dgvMain.TabIndex = 5;
            dgvMain.CellClick += dgvMain_CellClick;
            // 
            // BARCODE
            // 
            BARCODE.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            BARCODE.DataPropertyName = "BARCODE";
            BARCODE.FillWeight = 60F;
            BARCODE.HeaderText = "BARKOD";
            BARCODE.Name = "BARCODE";
            // 
            // VATRATE
            // 
            VATRATE.DataPropertyName = "VATRATE";
            VATRATE.HeaderText = "KDV";
            VATRATE.Name = "VATRATE";
            VATRATE.Visible = false;
            VATRATE.Width = 60;
            // 
            // NAME
            // 
            NAME.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NAME.DataPropertyName = "NAME";
            NAME.FillWeight = 70F;
            NAME.HeaderText = "ÜRÜN ADI";
            NAME.Name = "NAME";
            // 
            // CATEGORY
            // 
            CATEGORY.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CATEGORY.DataPropertyName = "CATEGORY";
            CATEGORY.FillWeight = 80F;
            CATEGORY.HeaderText = "KATEGORİ";
            CATEGORY.Name = "CATEGORY";
            // 
            // UNIT
            // 
            UNIT.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            UNIT.DataPropertyName = "UNIT";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            UNIT.DefaultCellStyle = dataGridViewCellStyle2;
            UNIT.FillWeight = 40F;
            UNIT.HeaderText = "BİRİM";
            UNIT.Name = "UNIT";
            // 
            // COLOR
            // 
            COLOR.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            COLOR.DataPropertyName = "COLOR";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            COLOR.DefaultCellStyle = dataGridViewCellStyle3;
            COLOR.FillWeight = 40F;
            COLOR.HeaderText = "RENK";
            COLOR.Name = "COLOR";
            // 
            // SIZE
            // 
            SIZE.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SIZE.DataPropertyName = "SIZE";
            SIZE.FillWeight = 40F;
            SIZE.HeaderText = "BEDEN";
            SIZE.Name = "SIZE";
            // 
            // MATERIAL
            // 
            MATERIAL.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MATERIAL.DataPropertyName = "MATERIAL";
            MATERIAL.FillWeight = 80F;
            MATERIAL.HeaderText = "MATERYAL";
            MATERIAL.Name = "MATERIAL";
            // 
            // BUYINGPRICE
            // 
            BUYINGPRICE.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            BUYINGPRICE.DataPropertyName = "BUYINGPRICE";
            BUYINGPRICE.FillWeight = 40F;
            BUYINGPRICE.HeaderText = "ALIŞ";
            BUYINGPRICE.Name = "BUYINGPRICE";
            // 
            // SELLPRICE
            // 
            SELLPRICE.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SELLPRICE.DataPropertyName = "SELLPRICE";
            SELLPRICE.FillWeight = 55F;
            SELLPRICE.HeaderText = "SATIŞ";
            SELLPRICE.Name = "SELLPRICE";
            // 
            // SELLPRICE2
            // 
            SELLPRICE2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SELLPRICE2.DataPropertyName = "SELLPRICE2";
            SELLPRICE2.FillWeight = 55F;
            SELLPRICE2.HeaderText = "SATIŞ2";
            SELLPRICE2.Name = "SELLPRICE2";
            SELLPRICE2.Visible = false;
            // 
            // SELLPRICE3
            // 
            SELLPRICE3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SELLPRICE3.DataPropertyName = "SELLPRICE3";
            SELLPRICE3.FillWeight = 55F;
            SELLPRICE3.HeaderText = "SATIŞ3";
            SELLPRICE3.Name = "SELLPRICE3";
            SELLPRICE3.Visible = false;
            // 
            // CURRENCY
            // 
            CURRENCY.DataPropertyName = "CURRENCY";
            CURRENCY.HeaderText = "D.CİNSİ";
            CURRENCY.Name = "CURRENCY";
            CURRENCY.Visible = false;
            CURRENCY.Width = 81;
            // 
            // STOCK
            // 
            STOCK.DataPropertyName = "STOCK";
            STOCK.FillWeight = 30F;
            STOCK.HeaderText = "STOK";
            STOCK.Name = "STOCK";
            STOCK.Width = 67;
            // 
            // CRITICALSTOCK
            // 
            CRITICALSTOCK.DataPropertyName = "CRITICALSTOCK";
            CRITICALSTOCK.FillWeight = 40F;
            CRITICALSTOCK.HeaderText = "K.STOK";
            CRITICALSTOCK.Name = "CRITICALSTOCK";
            CRITICALSTOCK.Visible = false;
            CRITICALSTOCK.Width = 80;
            // 
            // SUPPLIER
            // 
            SUPPLIER.DataPropertyName = "SUPPLIER";
            SUPPLIER.FillWeight = 60F;
            SUPPLIER.HeaderText = "TEDARİKÇİ";
            SUPPLIER.Name = "SUPPLIER";
            SUPPLIER.Visible = false;
            SUPPLIER.Width = 102;
            // 
            // BRANCH
            // 
            BRANCH.DataPropertyName = "BRANCH";
            BRANCH.HeaderText = "ŞUBE";
            BRANCH.Name = "BRANCH";
            BRANCH.Visible = false;
            BRANCH.Width = 66;
            // 
            // B64IMAGE
            // 
            B64IMAGE.DataPropertyName = "B64IMAGE";
            B64IMAGE.HeaderText = "B64IMAGE";
            B64IMAGE.Name = "B64IMAGE";
            B64IMAGE.Visible = false;
            B64IMAGE.Width = 101;
            // 
            // STOCKPLACE
            // 
            STOCKPLACE.DataPropertyName = "STOCKPLACE";
            STOCKPLACE.HeaderText = "STOCKPLACE";
            STOCKPLACE.Name = "STOCKPLACE";
            STOCKPLACE.Visible = false;
            STOCKPLACE.Width = 118;
            // 
            // dgvVariant
            // 
            dgvVariant.AllowUserToAddRows = false;
            dgvVariant.AllowUserToDeleteRows = false;
            dgvVariant.AllowUserToResizeColumns = false;
            dgvVariant.AllowUserToResizeRows = false;
            dgvVariant.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvVariant.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dgvVariant.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvVariant.BackgroundColor = Color.White;
            dgvVariant.BorderStyle = BorderStyle.None;
            dgvVariant.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvVariant.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(1, 39, 103);
            dataGridViewCellStyle5.SelectionBackColor = Color.White;
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(1, 39, 103);
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvVariant.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvVariant.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVariant.Columns.AddRange(new DataGridViewColumn[] { VBARCODE, VNAME, VCATEGORY, VUNIT, VCOLOR, VSIZE, VMATERIAL, VBUYPRICE, VSELLPRICE, VSELLPRICE2, VSELLPRICE3, VVATRATE, VCURRENCY, VSTOCK, VCRITICALSTOCK, VSUPPLIER, VBRANCH });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.White;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 162);
            dataGridViewCellStyle8.ForeColor = Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.InactiveCaption;
            dataGridViewCellStyle8.SelectionForeColor = Color.Black;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dgvVariant.DefaultCellStyle = dataGridViewCellStyle8;
            dgvVariant.EnableHeadersVisualStyles = false;
            dgvVariant.GridColor = Color.White;
            dgvVariant.Location = new Point(7, 7);
            dgvVariant.Margin = new Padding(7);
            dgvVariant.Name = "dgvVariant";
            dgvVariant.RowHeadersVisible = false;
            dgvVariant.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvVariant.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(210, 226, 252);
            dgvVariant.RowTemplate.DefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvVariant.RowTemplate.DefaultCellStyle.ForeColor = Color.FromArgb(1, 39, 103);
            dgvVariant.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(109, 134, 176);
            dgvVariant.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvVariant.RowTemplate.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvVariant.RowTemplate.DividerHeight = 10;
            dgvVariant.RowTemplate.Height = 40;
            dgvVariant.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVariant.Size = new Size(887, 636);
            dgvVariant.TabIndex = 4;
            dgvVariant.Visible = false;
            dgvVariant.CellClick += dgvVariant_CellClick;
            // 
            // VBARCODE
            // 
            VBARCODE.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            VBARCODE.FillWeight = 50.8869553F;
            VBARCODE.HeaderText = "BARKOD";
            VBARCODE.Name = "VBARCODE";
            // 
            // VNAME
            // 
            VNAME.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            VNAME.FillWeight = 59.36811F;
            VNAME.HeaderText = "ÜRÜN ADI";
            VNAME.Name = "VNAME";
            // 
            // VCATEGORY
            // 
            VCATEGORY.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            VCATEGORY.FillWeight = 67.84927F;
            VCATEGORY.HeaderText = "KATEGORİ";
            VCATEGORY.Name = "VCATEGORY";
            // 
            // VUNIT
            // 
            VUNIT.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            VUNIT.DefaultCellStyle = dataGridViewCellStyle6;
            VUNIT.FillWeight = 33.9246368F;
            VUNIT.HeaderText = "BİRİM";
            VUNIT.Name = "VUNIT";
            // 
            // VCOLOR
            // 
            VCOLOR.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            VCOLOR.DefaultCellStyle = dataGridViewCellStyle7;
            VCOLOR.FillWeight = 33.9246368F;
            VCOLOR.HeaderText = "RENK";
            VCOLOR.Name = "VCOLOR";
            // 
            // VSIZE
            // 
            VSIZE.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            VSIZE.FillWeight = 40F;
            VSIZE.HeaderText = "BEDEN";
            VSIZE.MinimumWidth = 47;
            VSIZE.Name = "VSIZE";
            // 
            // VMATERIAL
            // 
            VMATERIAL.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            VMATERIAL.FillWeight = 67.84927F;
            VMATERIAL.HeaderText = "MATERYAL";
            VMATERIAL.Name = "VMATERIAL";
            // 
            // VBUYPRICE
            // 
            VBUYPRICE.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            VBUYPRICE.FillWeight = 33.9246368F;
            VBUYPRICE.HeaderText = "ALIŞ";
            VBUYPRICE.Name = "VBUYPRICE";
            // 
            // VSELLPRICE
            // 
            VSELLPRICE.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            VSELLPRICE.FillWeight = 46.6463737F;
            VSELLPRICE.HeaderText = "SATIŞ";
            VSELLPRICE.Name = "VSELLPRICE";
            // 
            // VSELLPRICE2
            // 
            VSELLPRICE2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            VSELLPRICE2.FillWeight = 46.6463737F;
            VSELLPRICE2.HeaderText = "SATIŞ2";
            VSELLPRICE2.Name = "VSELLPRICE2";
            // 
            // VSELLPRICE3
            // 
            VSELLPRICE3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            VSELLPRICE3.FillWeight = 46.6463737F;
            VSELLPRICE3.HeaderText = "SATIŞ3";
            VSELLPRICE3.Name = "VSELLPRICE3";
            // 
            // VVATRATE
            // 
            VVATRATE.HeaderText = "KDV";
            VVATRATE.Name = "VVATRATE";
            VVATRATE.Visible = false;
            VVATRATE.Width = 60;
            // 
            // VCURRENCY
            // 
            VCURRENCY.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            VCURRENCY.FillWeight = 42.4057961F;
            VCURRENCY.HeaderText = "D.CİNSİ";
            VCURRENCY.Name = "VCURRENCY";
            // 
            // VSTOCK
            // 
            VSTOCK.FillWeight = 30F;
            VSTOCK.HeaderText = "STOK";
            VSTOCK.Name = "VSTOCK";
            VSTOCK.Width = 67;
            // 
            // VCRITICALSTOCK
            // 
            VCRITICALSTOCK.FillWeight = 30F;
            VCRITICALSTOCK.HeaderText = "K.STOK";
            VCRITICALSTOCK.Name = "VCRITICALSTOCK";
            VCRITICALSTOCK.Width = 80;
            // 
            // VSUPPLIER
            // 
            VSUPPLIER.FillWeight = 60F;
            VSUPPLIER.HeaderText = "TEDARİKÇİ";
            VSUPPLIER.Name = "VSUPPLIER";
            VSUPPLIER.Visible = false;
            VSUPPLIER.Width = 102;
            // 
            // VBRANCH
            // 
            VBRANCH.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            VBRANCH.FillWeight = 40F;
            VBRANCH.HeaderText = "ŞUBE";
            VBRANCH.Name = "VBRANCH";
            VBRANCH.Visible = false;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.LightGreen;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSave.ForeColor = Color.Black;
            btnSave.ImageAlign = ContentAlignment.TopCenter;
            btnSave.Location = new Point(10, 726);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(428, 38);
            btnSave.TabIndex = 73;
            btnSave.Text = "KAYDET";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // tmrNewProduct
            // 
            tmrNewProduct.Enabled = true;
            tmrNewProduct.Interval = 600;
            tmrNewProduct.Tick += tmrNewProduct_Tick;
            // 
            // NewProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(1, 40, 100);
            BackgroundImage = Properties.Resources.BackgroundGeneral;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1360, 768);
            Controls.Add(btnSave);
            Controls.Add(pnlMain);
            Controls.Add(lblPageHeader);
            Controls.Add(btnMinimize);
            Controls.Add(btnMaximize);
            Controls.Add(btnClose);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "NewProduct";
            Opacity = 0D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NewProduct";
            Load += NewProduct_Load;
            MouseDown += NewProduct_MouseDown;
            pnlMain.ResumeLayout(false);
            scMainContainer.Panel1.ResumeLayout(false);
            scMainContainer.Panel1.PerformLayout();
            scMainContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)scMainContainer).EndInit();
            scMainContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbProduct).EndInit();
            scRightSide.Panel1.ResumeLayout(false);
            scRightSide.Panel1.PerformLayout();
            scRightSide.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)scRightSide).EndInit();
            scRightSide.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbClearSearch).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbMagGlass).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvMain).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvVariant).EndInit();
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
        private TextBox tbBarcode;
        private Label lblBarcode;
        private PictureBox pbProduct;
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
        private PictureBox pbMagGlass;
        private CustomObjects.RoundTextBox rtbSearch;
        private Button btnSaveVariants;
        private DataGridView dgvVariant;
        private DataGridView dgvMain;
        private Label lblCurrency;
        private Label lblListingBranch;
        private ComboBox cbListingBranch;
        private System.Windows.Forms.Timer tmrNewProduct;
        private ComboBox cbCurrency;
        private DataGridViewTextBoxColumn VBARCODE;
        private DataGridViewTextBoxColumn VNAME;
        private DataGridViewTextBoxColumn VCATEGORY;
        private DataGridViewTextBoxColumn VUNIT;
        private DataGridViewTextBoxColumn VCOLOR;
        private DataGridViewTextBoxColumn VSIZE;
        private DataGridViewTextBoxColumn VMATERIAL;
        private DataGridViewTextBoxColumn VBUYPRICE;
        private DataGridViewTextBoxColumn VSELLPRICE;
        private DataGridViewTextBoxColumn VSELLPRICE2;
        private DataGridViewTextBoxColumn VSELLPRICE3;
        private DataGridViewTextBoxColumn VVATRATE;
        private DataGridViewTextBoxColumn VCURRENCY;
        private DataGridViewTextBoxColumn VSTOCK;
        private DataGridViewTextBoxColumn VCRITICALSTOCK;
        private DataGridViewTextBoxColumn VSUPPLIER;
        private DataGridViewTextBoxColumn VBRANCH;
        private Button btnCheckBarcode;
        private TextBox tbStockPlace;
        private Label label1;
        private DataGridViewTextBoxColumn BARCODE;
        private DataGridViewTextBoxColumn VATRATE;
        private DataGridViewTextBoxColumn NAME;
        private DataGridViewTextBoxColumn CATEGORY;
        private DataGridViewTextBoxColumn UNIT;
        private DataGridViewTextBoxColumn COLOR;
        private DataGridViewTextBoxColumn SIZE;
        private DataGridViewTextBoxColumn MATERIAL;
        private DataGridViewTextBoxColumn BUYINGPRICE;
        private DataGridViewTextBoxColumn SELLPRICE;
        private DataGridViewTextBoxColumn SELLPRICE2;
        private DataGridViewTextBoxColumn SELLPRICE3;
        private DataGridViewTextBoxColumn CURRENCY;
        private DataGridViewTextBoxColumn STOCK;
        private DataGridViewTextBoxColumn CRITICALSTOCK;
        private DataGridViewTextBoxColumn SUPPLIER;
        private DataGridViewTextBoxColumn BRANCH;
        private DataGridViewTextBoxColumn B64IMAGE;
        private DataGridViewTextBoxColumn STOCKPLACE;
    }
}