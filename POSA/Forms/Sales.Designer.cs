using System.Windows.Forms;

namespace POSA.Forms
{
    partial class Sales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sales));
            btnMinimize = new Button();
            btnMaximize = new Button();
            btnClose = new Button();
            SaleMainPanel = new Panel();
            MainSplitContainer = new SplitContainer();
            scLeftContainer = new SplitContainer();
            scLeftInnerContainer = new SplitContainer();
            scLeftInnerTopContainer = new SplitContainer();
            cbFree = new CheckBox();
            cbReturn = new CheckBox();
            pnlAddCustomer = new Panel();
            scAddCustomerContainer = new SplitContainer();
            btnAddCustomer = new Button();
            flpCustomers = new FlowLayoutPanel();
            btnRootCustomer = new Button();
            scLeftBottomMain = new SplitContainer();
            scLeftBottomMainsTop = new SplitContainer();
            dgvMain = new DataGridView();
            Barcode = new DataGridViewTextBoxColumn();
            ProductName = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            Delete = new DataGridViewButtonColumn();
            flpGroupButtons = new FlowLayoutPanel();
            btnGroup1 = new Button();
            btnGroup2 = new Button();
            btnGroup4 = new Button();
            btnGroup3 = new Button();
            btnGroup5 = new Button();
            btnGroup6 = new Button();
            btnGroup7 = new Button();
            btnGroup8 = new Button();
            btnGroup9 = new Button();
            btnGroup10 = new Button();
            btnGroup11 = new Button();
            btnGroup12 = new Button();
            btnGroup13 = new Button();
            btnGroup14 = new Button();
            btnGroup15 = new Button();
            btnGroup16 = new Button();
            btnGroup17 = new Button();
            btnGroup18 = new Button();
            btnGroup19 = new Button();
            btnGroup20 = new Button();
            btnGroup21 = new Button();
            btnGroup22 = new Button();
            btnGroup23 = new Button();
            btnGroup24 = new Button();
            btnGroup25 = new Button();
            btnGroup26 = new Button();
            btnGroup27 = new Button();
            btnGroup28 = new Button();
            btnGroup29 = new Button();
            btnGroup30 = new Button();
            btnGroup31 = new Button();
            btnGroup32 = new Button();
            btnGroup33 = new Button();
            btnGroup34 = new Button();
            btnGroup35 = new Button();
            btnGroup36 = new Button();
            btnGroup37 = new Button();
            btnGroup38 = new Button();
            btnGroup39 = new Button();
            btnGroup40 = new Button();
            pnlGroups = new Panel();
            scRightContainer = new SplitContainer();
            btnAddGroup = new Button();
            flpGroups = new FlowLayoutPanel();
            btnRootGroup = new Button();
            panel1 = new Panel();
            btnDeleteGroup = new Button();
            btnSaveGroups = new Button();
            label1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            pnlAddGroup = new Panel();
            btnSelectGroupImage = new Button();
            tbNewGroupName = new TextBox();
            btnNewGroupAdd = new Button();
            label3 = new Label();
            label2 = new Label();
            SaleMainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MainSplitContainer).BeginInit();
            MainSplitContainer.Panel1.SuspendLayout();
            MainSplitContainer.Panel2.SuspendLayout();
            MainSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)scLeftContainer).BeginInit();
            scLeftContainer.Panel1.SuspendLayout();
            scLeftContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)scLeftInnerContainer).BeginInit();
            scLeftInnerContainer.Panel1.SuspendLayout();
            scLeftInnerContainer.Panel2.SuspendLayout();
            scLeftInnerContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)scLeftInnerTopContainer).BeginInit();
            scLeftInnerTopContainer.Panel1.SuspendLayout();
            scLeftInnerTopContainer.Panel2.SuspendLayout();
            scLeftInnerTopContainer.SuspendLayout();
            pnlAddCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)scAddCustomerContainer).BeginInit();
            scAddCustomerContainer.Panel1.SuspendLayout();
            scAddCustomerContainer.Panel2.SuspendLayout();
            scAddCustomerContainer.SuspendLayout();
            flpCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)scLeftBottomMain).BeginInit();
            scLeftBottomMain.Panel1.SuspendLayout();
            scLeftBottomMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)scLeftBottomMainsTop).BeginInit();
            scLeftBottomMainsTop.Panel2.SuspendLayout();
            scLeftBottomMainsTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMain).BeginInit();
            flpGroupButtons.SuspendLayout();
            pnlGroups.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)scRightContainer).BeginInit();
            scRightContainer.Panel1.SuspendLayout();
            scRightContainer.Panel2.SuspendLayout();
            scRightContainer.SuspendLayout();
            flpGroups.SuspendLayout();
            panel1.SuspendLayout();
            pnlAddGroup.SuspendLayout();
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
            btnMinimize.Location = new Point(1153, 2);
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
            btnMaximize.Location = new Point(1224, 2);
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
            btnClose.Location = new Point(1295, 2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(70, 35);
            btnClose.TabIndex = 3;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // SaleMainPanel
            // 
            SaleMainPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SaleMainPanel.BackColor = Color.Gray;
            SaleMainPanel.Controls.Add(MainSplitContainer);
            SaleMainPanel.Location = new Point(12, 43);
            SaleMainPanel.Name = "SaleMainPanel";
            SaleMainPanel.Size = new Size(1342, 713);
            SaleMainPanel.TabIndex = 6;
            // 
            // MainSplitContainer
            // 
            MainSplitContainer.BackColor = Color.White;
            MainSplitContainer.Dock = DockStyle.Fill;
            MainSplitContainer.FixedPanel = FixedPanel.Panel2;
            MainSplitContainer.Location = new Point(0, 0);
            MainSplitContainer.Name = "MainSplitContainer";
            // 
            // MainSplitContainer.Panel1
            // 
            MainSplitContainer.Panel1.BackColor = Color.White;
            MainSplitContainer.Panel1.Controls.Add(scLeftContainer);
            // 
            // MainSplitContainer.Panel2
            // 
            MainSplitContainer.Panel2.BackColor = Color.White;
            MainSplitContainer.Panel2.Controls.Add(flpGroupButtons);
            MainSplitContainer.Panel2.Controls.Add(pnlGroups);
            MainSplitContainer.Panel2.Controls.Add(panel1);
            MainSplitContainer.Size = new Size(1342, 713);
            MainSplitContainer.SplitterDistance = 827;
            MainSplitContainer.TabIndex = 0;
            // 
            // scLeftContainer
            // 
            scLeftContainer.Dock = DockStyle.Fill;
            scLeftContainer.FixedPanel = FixedPanel.Panel2;
            scLeftContainer.Location = new Point(0, 0);
            scLeftContainer.Name = "scLeftContainer";
            // 
            // scLeftContainer.Panel1
            // 
            scLeftContainer.Panel1.Controls.Add(scLeftInnerContainer);
            scLeftContainer.Size = new Size(827, 713);
            scLeftContainer.SplitterDistance = 733;
            scLeftContainer.TabIndex = 0;
            // 
            // scLeftInnerContainer
            // 
            scLeftInnerContainer.Dock = DockStyle.Fill;
            scLeftInnerContainer.FixedPanel = FixedPanel.Panel1;
            scLeftInnerContainer.Location = new Point(0, 0);
            scLeftInnerContainer.Name = "scLeftInnerContainer";
            scLeftInnerContainer.Orientation = Orientation.Horizontal;
            // 
            // scLeftInnerContainer.Panel1
            // 
            scLeftInnerContainer.Panel1.Controls.Add(scLeftInnerTopContainer);
            // 
            // scLeftInnerContainer.Panel2
            // 
            scLeftInnerContainer.Panel2.Controls.Add(scLeftBottomMain);
            scLeftInnerContainer.Size = new Size(733, 713);
            scLeftInnerContainer.SplitterDistance = 67;
            scLeftInnerContainer.TabIndex = 0;
            // 
            // scLeftInnerTopContainer
            // 
            scLeftInnerTopContainer.Dock = DockStyle.Fill;
            scLeftInnerTopContainer.Location = new Point(0, 0);
            scLeftInnerTopContainer.Name = "scLeftInnerTopContainer";
            // 
            // scLeftInnerTopContainer.Panel1
            // 
            scLeftInnerTopContainer.Panel1.Controls.Add(cbFree);
            scLeftInnerTopContainer.Panel1.Controls.Add(cbReturn);
            // 
            // scLeftInnerTopContainer.Panel2
            // 
            scLeftInnerTopContainer.Panel2.Controls.Add(pnlAddCustomer);
            scLeftInnerTopContainer.Size = new Size(733, 67);
            scLeftInnerTopContainer.SplitterDistance = 125;
            scLeftInnerTopContainer.TabIndex = 0;
            // 
            // cbFree
            // 
            cbFree.AutoSize = true;
            cbFree.Font = new Font("Segoe UI", 15F);
            cbFree.Location = new Point(3, 34);
            cbFree.Name = "cbFree";
            cbFree.Size = new Size(100, 32);
            cbFree.TabIndex = 3;
            cbFree.Text = "Ücretsiz";
            cbFree.UseVisualStyleBackColor = true;
            // 
            // cbReturn
            // 
            cbReturn.AutoSize = true;
            cbReturn.Font = new Font("Segoe UI", 15F);
            cbReturn.Location = new Point(3, 3);
            cbReturn.Name = "cbReturn";
            cbReturn.Size = new Size(73, 32);
            cbReturn.TabIndex = 2;
            cbReturn.Text = "İADE";
            cbReturn.UseVisualStyleBackColor = true;
            // 
            // pnlAddCustomer
            // 
            pnlAddCustomer.BorderStyle = BorderStyle.FixedSingle;
            pnlAddCustomer.Controls.Add(scAddCustomerContainer);
            pnlAddCustomer.Dock = DockStyle.Fill;
            pnlAddCustomer.Location = new Point(0, 0);
            pnlAddCustomer.Name = "pnlAddCustomer";
            pnlAddCustomer.Size = new Size(604, 67);
            pnlAddCustomer.TabIndex = 0;
            // 
            // scAddCustomerContainer
            // 
            scAddCustomerContainer.Dock = DockStyle.Fill;
            scAddCustomerContainer.FixedPanel = FixedPanel.Panel1;
            scAddCustomerContainer.Location = new Point(0, 0);
            scAddCustomerContainer.Name = "scAddCustomerContainer";
            // 
            // scAddCustomerContainer.Panel1
            // 
            scAddCustomerContainer.Panel1.Controls.Add(btnAddCustomer);
            // 
            // scAddCustomerContainer.Panel2
            // 
            scAddCustomerContainer.Panel2.Controls.Add(flpCustomers);
            scAddCustomerContainer.Size = new Size(602, 65);
            scAddCustomerContainer.SplitterDistance = 55;
            scAddCustomerContainer.TabIndex = 1;
            // 
            // btnAddCustomer
            // 
            btnAddCustomer.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddCustomer.BackColor = Color.Gainsboro;
            btnAddCustomer.BackgroundImage = (Image)resources.GetObject("btnAddCustomer.BackgroundImage");
            btnAddCustomer.BackgroundImageLayout = ImageLayout.Center;
            btnAddCustomer.FlatAppearance.BorderSize = 0;
            btnAddCustomer.FlatStyle = FlatStyle.Flat;
            btnAddCustomer.Location = new Point(3, 2);
            btnAddCustomer.Name = "btnAddCustomer";
            btnAddCustomer.Size = new Size(49, 61);
            btnAddCustomer.TabIndex = 6;
            btnAddCustomer.UseVisualStyleBackColor = false;
            btnAddCustomer.Click += btnAddCustomer_Click;
            // 
            // flpCustomers
            // 
            flpCustomers.AutoScroll = true;
            flpCustomers.Controls.Add(btnRootCustomer);
            flpCustomers.Dock = DockStyle.Fill;
            flpCustomers.Location = new Point(0, 0);
            flpCustomers.Name = "flpCustomers";
            flpCustomers.Size = new Size(543, 65);
            flpCustomers.TabIndex = 2;
            flpCustomers.WrapContents = false;
            // 
            // btnRootCustomer
            // 
            btnRootCustomer.BackgroundImage = Properties.Resources.user__1_;
            btnRootCustomer.BackgroundImageLayout = ImageLayout.Center;
            btnRootCustomer.FlatStyle = FlatStyle.Flat;
            btnRootCustomer.Location = new Point(3, 3);
            btnRootCustomer.Name = "btnRootCustomer";
            btnRootCustomer.Size = new Size(46, 46);
            btnRootCustomer.TabIndex = 0;
            btnRootCustomer.UseVisualStyleBackColor = true;
            // 
            // scLeftBottomMain
            // 
            scLeftBottomMain.Dock = DockStyle.Fill;
            scLeftBottomMain.Location = new Point(0, 0);
            scLeftBottomMain.Name = "scLeftBottomMain";
            scLeftBottomMain.Orientation = Orientation.Horizontal;
            // 
            // scLeftBottomMain.Panel1
            // 
            scLeftBottomMain.Panel1.Controls.Add(scLeftBottomMainsTop);
            scLeftBottomMain.Size = new Size(733, 642);
            scLeftBottomMain.SplitterDistance = 532;
            scLeftBottomMain.TabIndex = 0;
            // 
            // scLeftBottomMainsTop
            // 
            scLeftBottomMainsTop.Dock = DockStyle.Fill;
            scLeftBottomMainsTop.Location = new Point(0, 0);
            scLeftBottomMainsTop.Name = "scLeftBottomMainsTop";
            scLeftBottomMainsTop.Orientation = Orientation.Horizontal;
            // 
            // scLeftBottomMainsTop.Panel2
            // 
            scLeftBottomMainsTop.Panel2.Controls.Add(dgvMain);
            scLeftBottomMainsTop.Size = new Size(733, 532);
            scLeftBottomMainsTop.SplitterDistance = 88;
            scLeftBottomMainsTop.TabIndex = 0;
            // 
            // dgvMain
            // 
            dgvMain.AllowUserToDeleteRows = false;
            dgvMain.AllowUserToResizeColumns = false;
            dgvMain.AllowUserToResizeRows = false;
            dgvMain.BackgroundColor = Color.White;
            dgvMain.BorderStyle = BorderStyle.None;
            dgvMain.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMain.Columns.AddRange(new DataGridViewColumn[] { Barcode, ProductName, Price, Quantity, Total, Delete });
            dgvMain.Dock = DockStyle.Fill;
            dgvMain.Location = new Point(0, 0);
            dgvMain.Name = "dgvMain";
            dgvMain.RowHeadersVisible = false;
            dgvMain.Size = new Size(733, 440);
            dgvMain.TabIndex = 0;
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
            ProductName.FillWeight = 18F;
            ProductName.HeaderText = "ÜRÜN ADI";
            ProductName.Name = "ProductName";
            // 
            // Price
            // 
            Price.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Price.FillWeight = 18F;
            Price.HeaderText = "FİYAT";
            Price.Name = "Price";
            // 
            // Quantity
            // 
            Quantity.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Quantity.FillWeight = 18F;
            Quantity.HeaderText = "ADET";
            Quantity.Name = "Quantity";
            // 
            // Total
            // 
            Total.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Total.FillWeight = 18F;
            Total.HeaderText = "TOPLAM";
            Total.Name = "Total";
            // 
            // Delete
            // 
            Delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Delete.FillWeight = 10F;
            Delete.HeaderText = "SİL";
            Delete.Name = "Delete";
            // 
            // flpGroupButtons
            // 
            flpGroupButtons.AutoScroll = true;
            flpGroupButtons.BackColor = Color.White;
            flpGroupButtons.Controls.Add(btnGroup1);
            flpGroupButtons.Controls.Add(btnGroup2);
            flpGroupButtons.Controls.Add(btnGroup4);
            flpGroupButtons.Controls.Add(btnGroup3);
            flpGroupButtons.Controls.Add(btnGroup5);
            flpGroupButtons.Controls.Add(btnGroup6);
            flpGroupButtons.Controls.Add(btnGroup7);
            flpGroupButtons.Controls.Add(btnGroup8);
            flpGroupButtons.Controls.Add(btnGroup9);
            flpGroupButtons.Controls.Add(btnGroup10);
            flpGroupButtons.Controls.Add(btnGroup11);
            flpGroupButtons.Controls.Add(btnGroup12);
            flpGroupButtons.Controls.Add(btnGroup13);
            flpGroupButtons.Controls.Add(btnGroup14);
            flpGroupButtons.Controls.Add(btnGroup15);
            flpGroupButtons.Controls.Add(btnGroup16);
            flpGroupButtons.Controls.Add(btnGroup17);
            flpGroupButtons.Controls.Add(btnGroup18);
            flpGroupButtons.Controls.Add(btnGroup19);
            flpGroupButtons.Controls.Add(btnGroup20);
            flpGroupButtons.Controls.Add(btnGroup21);
            flpGroupButtons.Controls.Add(btnGroup22);
            flpGroupButtons.Controls.Add(btnGroup23);
            flpGroupButtons.Controls.Add(btnGroup24);
            flpGroupButtons.Controls.Add(btnGroup25);
            flpGroupButtons.Controls.Add(btnGroup26);
            flpGroupButtons.Controls.Add(btnGroup27);
            flpGroupButtons.Controls.Add(btnGroup28);
            flpGroupButtons.Controls.Add(btnGroup29);
            flpGroupButtons.Controls.Add(btnGroup30);
            flpGroupButtons.Controls.Add(btnGroup31);
            flpGroupButtons.Controls.Add(btnGroup32);
            flpGroupButtons.Controls.Add(btnGroup33);
            flpGroupButtons.Controls.Add(btnGroup34);
            flpGroupButtons.Controls.Add(btnGroup35);
            flpGroupButtons.Controls.Add(btnGroup36);
            flpGroupButtons.Controls.Add(btnGroup37);
            flpGroupButtons.Controls.Add(btnGroup38);
            flpGroupButtons.Controls.Add(btnGroup39);
            flpGroupButtons.Controls.Add(btnGroup40);
            flpGroupButtons.Dock = DockStyle.Fill;
            flpGroupButtons.Location = new Point(0, 97);
            flpGroupButtons.Name = "flpGroupButtons";
            flpGroupButtons.Size = new Size(511, 561);
            flpGroupButtons.TabIndex = 6;
            // 
            // btnGroup1
            // 
            btnGroup1.BackgroundImageLayout = ImageLayout.Center;
            btnGroup1.FlatStyle = FlatStyle.Flat;
            btnGroup1.ImageAlign = ContentAlignment.TopCenter;
            btnGroup1.Location = new Point(3, 3);
            btnGroup1.Name = "btnGroup1";
            btnGroup1.Size = new Size(117, 117);
            btnGroup1.TabIndex = 0;
            btnGroup1.TextAlign = ContentAlignment.BottomCenter;
            btnGroup1.UseVisualStyleBackColor = true;
            btnGroup1.Click += GroupButtonsGeneral_Click;
            // 
            // btnGroup2
            // 
            btnGroup2.BackgroundImageLayout = ImageLayout.Center;
            btnGroup2.FlatStyle = FlatStyle.Flat;
            btnGroup2.ImageAlign = ContentAlignment.TopCenter;
            btnGroup2.Location = new Point(126, 3);
            btnGroup2.Name = "btnGroup2";
            btnGroup2.Size = new Size(117, 117);
            btnGroup2.TabIndex = 1;
            btnGroup2.TextAlign = ContentAlignment.BottomCenter;
            btnGroup2.UseVisualStyleBackColor = true;
            btnGroup2.Click += GroupButtonsGeneral_Click;
            // 
            // btnGroup4
            // 
            btnGroup4.BackgroundImageLayout = ImageLayout.Center;
            btnGroup4.FlatStyle = FlatStyle.Flat;
            btnGroup4.ImageAlign = ContentAlignment.TopCenter;
            btnGroup4.Location = new Point(249, 3);
            btnGroup4.Name = "btnGroup4";
            btnGroup4.Size = new Size(117, 117);
            btnGroup4.TabIndex = 3;
            btnGroup4.TextAlign = ContentAlignment.BottomCenter;
            btnGroup4.UseVisualStyleBackColor = true;
            btnGroup4.Click += GroupButtonsGeneral_Click;
            // 
            // btnGroup3
            // 
            btnGroup3.BackgroundImageLayout = ImageLayout.Center;
            btnGroup3.FlatStyle = FlatStyle.Flat;
            btnGroup3.ImageAlign = ContentAlignment.TopCenter;
            btnGroup3.Location = new Point(372, 3);
            btnGroup3.Name = "btnGroup3";
            btnGroup3.Size = new Size(117, 117);
            btnGroup3.TabIndex = 2;
            btnGroup3.TextAlign = ContentAlignment.BottomCenter;
            btnGroup3.UseVisualStyleBackColor = true;
            btnGroup3.Click += GroupButtonsGeneral_Click;
            // 
            // btnGroup5
            // 
            btnGroup5.BackgroundImageLayout = ImageLayout.Center;
            btnGroup5.FlatStyle = FlatStyle.Flat;
            btnGroup5.ImageAlign = ContentAlignment.TopCenter;
            btnGroup5.Location = new Point(3, 126);
            btnGroup5.Name = "btnGroup5";
            btnGroup5.Size = new Size(117, 117);
            btnGroup5.TabIndex = 4;
            btnGroup5.TextAlign = ContentAlignment.BottomCenter;
            btnGroup5.UseVisualStyleBackColor = true;
            btnGroup5.Click += GroupButtonsGeneral_Click;
            // 
            // btnGroup6
            // 
            btnGroup6.BackgroundImageLayout = ImageLayout.Center;
            btnGroup6.FlatStyle = FlatStyle.Flat;
            btnGroup6.ImageAlign = ContentAlignment.TopCenter;
            btnGroup6.Location = new Point(126, 126);
            btnGroup6.Name = "btnGroup6";
            btnGroup6.Size = new Size(117, 117);
            btnGroup6.TabIndex = 5;
            btnGroup6.TextAlign = ContentAlignment.BottomCenter;
            btnGroup6.UseVisualStyleBackColor = true;
            btnGroup6.Click += GroupButtonsGeneral_Click;
            // 
            // btnGroup7
            // 
            btnGroup7.BackgroundImageLayout = ImageLayout.Center;
            btnGroup7.FlatStyle = FlatStyle.Flat;
            btnGroup7.ImageAlign = ContentAlignment.TopCenter;
            btnGroup7.Location = new Point(249, 126);
            btnGroup7.Name = "btnGroup7";
            btnGroup7.Size = new Size(117, 117);
            btnGroup7.TabIndex = 6;
            btnGroup7.TextAlign = ContentAlignment.BottomCenter;
            btnGroup7.UseVisualStyleBackColor = true;
            btnGroup7.Click += GroupButtonsGeneral_Click;
            // 
            // btnGroup8
            // 
            btnGroup8.BackgroundImageLayout = ImageLayout.Center;
            btnGroup8.FlatStyle = FlatStyle.Flat;
            btnGroup8.ImageAlign = ContentAlignment.TopCenter;
            btnGroup8.Location = new Point(372, 126);
            btnGroup8.Name = "btnGroup8";
            btnGroup8.Size = new Size(117, 117);
            btnGroup8.TabIndex = 7;
            btnGroup8.TextAlign = ContentAlignment.BottomCenter;
            btnGroup8.UseVisualStyleBackColor = true;
            btnGroup8.Click += GroupButtonsGeneral_Click;
            // 
            // btnGroup9
            // 
            btnGroup9.BackgroundImageLayout = ImageLayout.Center;
            btnGroup9.FlatStyle = FlatStyle.Flat;
            btnGroup9.ImageAlign = ContentAlignment.TopCenter;
            btnGroup9.Location = new Point(3, 249);
            btnGroup9.Name = "btnGroup9";
            btnGroup9.Size = new Size(117, 117);
            btnGroup9.TabIndex = 8;
            btnGroup9.TextAlign = ContentAlignment.BottomCenter;
            btnGroup9.UseVisualStyleBackColor = true;
            btnGroup9.Click += GroupButtonsGeneral_Click;
            // 
            // btnGroup10
            // 
            btnGroup10.BackgroundImageLayout = ImageLayout.Center;
            btnGroup10.FlatStyle = FlatStyle.Flat;
            btnGroup10.ImageAlign = ContentAlignment.TopCenter;
            btnGroup10.Location = new Point(126, 249);
            btnGroup10.Name = "btnGroup10";
            btnGroup10.Size = new Size(117, 117);
            btnGroup10.TabIndex = 9;
            btnGroup10.TextAlign = ContentAlignment.BottomCenter;
            btnGroup10.UseVisualStyleBackColor = true;
            btnGroup10.Click += GroupButtonsGeneral_Click;
            // 
            // btnGroup11
            // 
            btnGroup11.BackgroundImageLayout = ImageLayout.Center;
            btnGroup11.FlatStyle = FlatStyle.Flat;
            btnGroup11.ImageAlign = ContentAlignment.TopCenter;
            btnGroup11.Location = new Point(249, 249);
            btnGroup11.Name = "btnGroup11";
            btnGroup11.Size = new Size(117, 117);
            btnGroup11.TabIndex = 10;
            btnGroup11.TextAlign = ContentAlignment.BottomCenter;
            btnGroup11.UseVisualStyleBackColor = true;
            btnGroup11.Click += GroupButtonsGeneral_Click;
            // 
            // btnGroup12
            // 
            btnGroup12.BackgroundImageLayout = ImageLayout.Center;
            btnGroup12.FlatStyle = FlatStyle.Flat;
            btnGroup12.ImageAlign = ContentAlignment.TopCenter;
            btnGroup12.Location = new Point(372, 249);
            btnGroup12.Name = "btnGroup12";
            btnGroup12.Size = new Size(117, 117);
            btnGroup12.TabIndex = 11;
            btnGroup12.TextAlign = ContentAlignment.BottomCenter;
            btnGroup12.UseVisualStyleBackColor = true;
            btnGroup12.Click += GroupButtonsGeneral_Click;
            // 
            // btnGroup13
            // 
            btnGroup13.BackgroundImageLayout = ImageLayout.Center;
            btnGroup13.FlatStyle = FlatStyle.Flat;
            btnGroup13.ImageAlign = ContentAlignment.TopCenter;
            btnGroup13.Location = new Point(3, 372);
            btnGroup13.Name = "btnGroup13";
            btnGroup13.Size = new Size(117, 117);
            btnGroup13.TabIndex = 12;
            btnGroup13.TextAlign = ContentAlignment.BottomCenter;
            btnGroup13.UseVisualStyleBackColor = true;
            btnGroup13.Click += GroupButtonsGeneral_Click;
            // 
            // btnGroup14
            // 
            btnGroup14.BackgroundImageLayout = ImageLayout.Center;
            btnGroup14.FlatStyle = FlatStyle.Flat;
            btnGroup14.ImageAlign = ContentAlignment.TopCenter;
            btnGroup14.Location = new Point(126, 372);
            btnGroup14.Name = "btnGroup14";
            btnGroup14.Size = new Size(117, 117);
            btnGroup14.TabIndex = 13;
            btnGroup14.TextAlign = ContentAlignment.BottomCenter;
            btnGroup14.UseVisualStyleBackColor = true;
            btnGroup14.Click += GroupButtonsGeneral_Click;
            // 
            // btnGroup15
            // 
            btnGroup15.BackgroundImageLayout = ImageLayout.Center;
            btnGroup15.FlatStyle = FlatStyle.Flat;
            btnGroup15.ImageAlign = ContentAlignment.TopCenter;
            btnGroup15.Location = new Point(249, 372);
            btnGroup15.Name = "btnGroup15";
            btnGroup15.Size = new Size(117, 117);
            btnGroup15.TabIndex = 14;
            btnGroup15.TextAlign = ContentAlignment.BottomCenter;
            btnGroup15.UseVisualStyleBackColor = true;
            btnGroup15.Click += GroupButtonsGeneral_Click;
            // 
            // btnGroup16
            // 
            btnGroup16.BackgroundImageLayout = ImageLayout.Center;
            btnGroup16.FlatStyle = FlatStyle.Flat;
            btnGroup16.ImageAlign = ContentAlignment.TopCenter;
            btnGroup16.Location = new Point(372, 372);
            btnGroup16.Name = "btnGroup16";
            btnGroup16.Size = new Size(117, 117);
            btnGroup16.TabIndex = 15;
            btnGroup16.TextAlign = ContentAlignment.BottomCenter;
            btnGroup16.UseVisualStyleBackColor = true;
            btnGroup16.Click += GroupButtonsGeneral_Click;
            // 
            // btnGroup17
            // 
            btnGroup17.BackgroundImageLayout = ImageLayout.Center;
            btnGroup17.FlatStyle = FlatStyle.Flat;
            btnGroup17.ImageAlign = ContentAlignment.TopCenter;
            btnGroup17.Location = new Point(3, 495);
            btnGroup17.Name = "btnGroup17";
            btnGroup17.Size = new Size(117, 117);
            btnGroup17.TabIndex = 16;
            btnGroup17.TextAlign = ContentAlignment.BottomCenter;
            btnGroup17.UseVisualStyleBackColor = true;
            btnGroup17.Click += GroupButtonsGeneral_Click;
            // 
            // btnGroup18
            // 
            btnGroup18.BackgroundImageLayout = ImageLayout.Center;
            btnGroup18.FlatStyle = FlatStyle.Flat;
            btnGroup18.ImageAlign = ContentAlignment.TopCenter;
            btnGroup18.Location = new Point(126, 495);
            btnGroup18.Name = "btnGroup18";
            btnGroup18.Size = new Size(117, 117);
            btnGroup18.TabIndex = 17;
            btnGroup18.TextAlign = ContentAlignment.BottomCenter;
            btnGroup18.UseVisualStyleBackColor = true;
            btnGroup18.Click += GroupButtonsGeneral_Click;
            // 
            // btnGroup19
            // 
            btnGroup19.BackgroundImageLayout = ImageLayout.Center;
            btnGroup19.FlatStyle = FlatStyle.Flat;
            btnGroup19.ImageAlign = ContentAlignment.TopCenter;
            btnGroup19.Location = new Point(249, 495);
            btnGroup19.Name = "btnGroup19";
            btnGroup19.Size = new Size(117, 117);
            btnGroup19.TabIndex = 18;
            btnGroup19.TextAlign = ContentAlignment.BottomCenter;
            btnGroup19.UseVisualStyleBackColor = true;
            btnGroup19.Click += GroupButtonsGeneral_Click;
            // 
            // btnGroup20
            // 
            btnGroup20.BackgroundImageLayout = ImageLayout.Center;
            btnGroup20.FlatStyle = FlatStyle.Flat;
            btnGroup20.ImageAlign = ContentAlignment.TopCenter;
            btnGroup20.Location = new Point(372, 495);
            btnGroup20.Name = "btnGroup20";
            btnGroup20.Size = new Size(117, 117);
            btnGroup20.TabIndex = 19;
            btnGroup20.TextAlign = ContentAlignment.BottomCenter;
            btnGroup20.UseVisualStyleBackColor = true;
            btnGroup20.Click += GroupButtonsGeneral_Click;
            // 
            // btnGroup21
            // 
            btnGroup21.BackgroundImageLayout = ImageLayout.Center;
            btnGroup21.FlatStyle = FlatStyle.Flat;
            btnGroup21.ImageAlign = ContentAlignment.TopCenter;
            btnGroup21.Location = new Point(3, 618);
            btnGroup21.Name = "btnGroup21";
            btnGroup21.Size = new Size(117, 117);
            btnGroup21.TabIndex = 20;
            btnGroup21.TextAlign = ContentAlignment.BottomCenter;
            btnGroup21.UseVisualStyleBackColor = true;
            btnGroup21.Click += GroupButtonsGeneral_Click;
            // 
            // btnGroup22
            // 
            btnGroup22.BackgroundImageLayout = ImageLayout.Center;
            btnGroup22.FlatStyle = FlatStyle.Flat;
            btnGroup22.ImageAlign = ContentAlignment.TopCenter;
            btnGroup22.Location = new Point(126, 618);
            btnGroup22.Name = "btnGroup22";
            btnGroup22.Size = new Size(117, 117);
            btnGroup22.TabIndex = 21;
            btnGroup22.TextAlign = ContentAlignment.BottomCenter;
            btnGroup22.UseVisualStyleBackColor = true;
            btnGroup22.Click += GroupButtonsGeneral_Click;
            // 
            // btnGroup23
            // 
            btnGroup23.BackgroundImageLayout = ImageLayout.Center;
            btnGroup23.FlatStyle = FlatStyle.Flat;
            btnGroup23.ImageAlign = ContentAlignment.TopCenter;
            btnGroup23.Location = new Point(249, 618);
            btnGroup23.Name = "btnGroup23";
            btnGroup23.Size = new Size(117, 117);
            btnGroup23.TabIndex = 22;
            btnGroup23.TextAlign = ContentAlignment.BottomCenter;
            btnGroup23.UseVisualStyleBackColor = true;
            btnGroup23.Click += GroupButtonsGeneral_Click;
            // 
            // btnGroup24
            // 
            btnGroup24.BackgroundImageLayout = ImageLayout.Center;
            btnGroup24.FlatStyle = FlatStyle.Flat;
            btnGroup24.ImageAlign = ContentAlignment.TopCenter;
            btnGroup24.Location = new Point(372, 618);
            btnGroup24.Name = "btnGroup24";
            btnGroup24.Size = new Size(117, 117);
            btnGroup24.TabIndex = 23;
            btnGroup24.TextAlign = ContentAlignment.BottomCenter;
            btnGroup24.UseVisualStyleBackColor = true;
            btnGroup24.Click += GroupButtonsGeneral_Click;
            // 
            // btnGroup25
            // 
            btnGroup25.BackgroundImageLayout = ImageLayout.Center;
            btnGroup25.FlatStyle = FlatStyle.Flat;
            btnGroup25.ImageAlign = ContentAlignment.TopCenter;
            btnGroup25.Location = new Point(3, 741);
            btnGroup25.Name = "btnGroup25";
            btnGroup25.Size = new Size(117, 117);
            btnGroup25.TabIndex = 24;
            btnGroup25.TextAlign = ContentAlignment.BottomCenter;
            btnGroup25.UseVisualStyleBackColor = true;
            btnGroup25.Click += GroupButtonsGeneral_Click;
            // 
            // btnGroup26
            // 
            btnGroup26.BackgroundImageLayout = ImageLayout.Center;
            btnGroup26.FlatStyle = FlatStyle.Flat;
            btnGroup26.ImageAlign = ContentAlignment.TopCenter;
            btnGroup26.Location = new Point(126, 741);
            btnGroup26.Name = "btnGroup26";
            btnGroup26.Size = new Size(117, 117);
            btnGroup26.TabIndex = 25;
            btnGroup26.TextAlign = ContentAlignment.BottomCenter;
            btnGroup26.UseVisualStyleBackColor = true;
            btnGroup26.Click += GroupButtonsGeneral_Click;
            // 
            // btnGroup27
            // 
            btnGroup27.BackgroundImageLayout = ImageLayout.Center;
            btnGroup27.FlatStyle = FlatStyle.Flat;
            btnGroup27.ImageAlign = ContentAlignment.TopCenter;
            btnGroup27.Location = new Point(249, 741);
            btnGroup27.Name = "btnGroup27";
            btnGroup27.Size = new Size(117, 117);
            btnGroup27.TabIndex = 26;
            btnGroup27.TextAlign = ContentAlignment.BottomCenter;
            btnGroup27.UseVisualStyleBackColor = true;
            btnGroup27.Click += GroupButtonsGeneral_Click;
            // 
            // btnGroup28
            // 
            btnGroup28.BackgroundImageLayout = ImageLayout.Center;
            btnGroup28.FlatStyle = FlatStyle.Flat;
            btnGroup28.ImageAlign = ContentAlignment.TopCenter;
            btnGroup28.Location = new Point(372, 741);
            btnGroup28.Name = "btnGroup28";
            btnGroup28.Size = new Size(117, 117);
            btnGroup28.TabIndex = 27;
            btnGroup28.TextAlign = ContentAlignment.BottomCenter;
            btnGroup28.UseVisualStyleBackColor = true;
            btnGroup28.Click += GroupButtonsGeneral_Click;
            // 
            // btnGroup29
            // 
            btnGroup29.BackgroundImageLayout = ImageLayout.Center;
            btnGroup29.FlatStyle = FlatStyle.Flat;
            btnGroup29.ImageAlign = ContentAlignment.TopCenter;
            btnGroup29.Location = new Point(3, 864);
            btnGroup29.Name = "btnGroup29";
            btnGroup29.Size = new Size(117, 117);
            btnGroup29.TabIndex = 28;
            btnGroup29.TextAlign = ContentAlignment.BottomCenter;
            btnGroup29.UseVisualStyleBackColor = true;
            btnGroup29.Click += GroupButtonsGeneral_Click;
            // 
            // btnGroup30
            // 
            btnGroup30.BackgroundImageLayout = ImageLayout.Center;
            btnGroup30.FlatStyle = FlatStyle.Flat;
            btnGroup30.ImageAlign = ContentAlignment.TopCenter;
            btnGroup30.Location = new Point(126, 864);
            btnGroup30.Name = "btnGroup30";
            btnGroup30.Size = new Size(117, 117);
            btnGroup30.TabIndex = 29;
            btnGroup30.TextAlign = ContentAlignment.BottomCenter;
            btnGroup30.UseVisualStyleBackColor = true;
            btnGroup30.Click += GroupButtonsGeneral_Click;
            // 
            // btnGroup31
            // 
            btnGroup31.BackgroundImageLayout = ImageLayout.Center;
            btnGroup31.FlatStyle = FlatStyle.Flat;
            btnGroup31.ImageAlign = ContentAlignment.TopCenter;
            btnGroup31.Location = new Point(249, 864);
            btnGroup31.Name = "btnGroup31";
            btnGroup31.Size = new Size(117, 117);
            btnGroup31.TabIndex = 30;
            btnGroup31.TextAlign = ContentAlignment.BottomCenter;
            btnGroup31.UseVisualStyleBackColor = true;
            btnGroup31.Click += GroupButtonsGeneral_Click;
            // 
            // btnGroup32
            // 
            btnGroup32.BackgroundImageLayout = ImageLayout.Center;
            btnGroup32.FlatStyle = FlatStyle.Flat;
            btnGroup32.ImageAlign = ContentAlignment.TopCenter;
            btnGroup32.Location = new Point(372, 864);
            btnGroup32.Name = "btnGroup32";
            btnGroup32.Size = new Size(117, 117);
            btnGroup32.TabIndex = 31;
            btnGroup32.TextAlign = ContentAlignment.BottomCenter;
            btnGroup32.UseVisualStyleBackColor = true;
            btnGroup32.Click += GroupButtonsGeneral_Click;
            // 
            // btnGroup33
            // 
            btnGroup33.BackgroundImageLayout = ImageLayout.Center;
            btnGroup33.FlatStyle = FlatStyle.Flat;
            btnGroup33.ImageAlign = ContentAlignment.TopCenter;
            btnGroup33.Location = new Point(3, 987);
            btnGroup33.Name = "btnGroup33";
            btnGroup33.Size = new Size(117, 117);
            btnGroup33.TabIndex = 32;
            btnGroup33.TextAlign = ContentAlignment.BottomCenter;
            btnGroup33.UseVisualStyleBackColor = true;
            btnGroup33.Click += GroupButtonsGeneral_Click;
            // 
            // btnGroup34
            // 
            btnGroup34.BackgroundImageLayout = ImageLayout.Center;
            btnGroup34.FlatStyle = FlatStyle.Flat;
            btnGroup34.ImageAlign = ContentAlignment.TopCenter;
            btnGroup34.Location = new Point(126, 987);
            btnGroup34.Name = "btnGroup34";
            btnGroup34.Size = new Size(117, 117);
            btnGroup34.TabIndex = 33;
            btnGroup34.TextAlign = ContentAlignment.BottomCenter;
            btnGroup34.UseVisualStyleBackColor = true;
            btnGroup34.Click += GroupButtonsGeneral_Click;
            // 
            // btnGroup35
            // 
            btnGroup35.BackgroundImageLayout = ImageLayout.Center;
            btnGroup35.FlatStyle = FlatStyle.Flat;
            btnGroup35.ImageAlign = ContentAlignment.TopCenter;
            btnGroup35.Location = new Point(249, 987);
            btnGroup35.Name = "btnGroup35";
            btnGroup35.Size = new Size(117, 117);
            btnGroup35.TabIndex = 34;
            btnGroup35.TextAlign = ContentAlignment.BottomCenter;
            btnGroup35.UseVisualStyleBackColor = true;
            btnGroup35.Click += GroupButtonsGeneral_Click;
            // 
            // btnGroup36
            // 
            btnGroup36.BackgroundImageLayout = ImageLayout.Center;
            btnGroup36.FlatStyle = FlatStyle.Flat;
            btnGroup36.ImageAlign = ContentAlignment.TopCenter;
            btnGroup36.Location = new Point(372, 987);
            btnGroup36.Name = "btnGroup36";
            btnGroup36.Size = new Size(117, 117);
            btnGroup36.TabIndex = 35;
            btnGroup36.TextAlign = ContentAlignment.BottomCenter;
            btnGroup36.UseVisualStyleBackColor = true;
            btnGroup36.Click += GroupButtonsGeneral_Click;
            // 
            // btnGroup37
            // 
            btnGroup37.BackgroundImageLayout = ImageLayout.Center;
            btnGroup37.FlatStyle = FlatStyle.Flat;
            btnGroup37.ImageAlign = ContentAlignment.TopCenter;
            btnGroup37.Location = new Point(3, 1110);
            btnGroup37.Name = "btnGroup37";
            btnGroup37.Size = new Size(117, 117);
            btnGroup37.TabIndex = 36;
            btnGroup37.TextAlign = ContentAlignment.BottomCenter;
            btnGroup37.UseVisualStyleBackColor = true;
            btnGroup37.Click += GroupButtonsGeneral_Click;
            // 
            // btnGroup38
            // 
            btnGroup38.BackgroundImageLayout = ImageLayout.Center;
            btnGroup38.FlatStyle = FlatStyle.Flat;
            btnGroup38.ImageAlign = ContentAlignment.TopCenter;
            btnGroup38.Location = new Point(126, 1110);
            btnGroup38.Name = "btnGroup38";
            btnGroup38.Size = new Size(117, 117);
            btnGroup38.TabIndex = 37;
            btnGroup38.TextAlign = ContentAlignment.BottomCenter;
            btnGroup38.UseVisualStyleBackColor = true;
            btnGroup38.Click += GroupButtonsGeneral_Click;
            // 
            // btnGroup39
            // 
            btnGroup39.BackgroundImageLayout = ImageLayout.Center;
            btnGroup39.FlatStyle = FlatStyle.Flat;
            btnGroup39.ImageAlign = ContentAlignment.TopCenter;
            btnGroup39.Location = new Point(249, 1110);
            btnGroup39.Name = "btnGroup39";
            btnGroup39.Size = new Size(117, 117);
            btnGroup39.TabIndex = 38;
            btnGroup39.TextAlign = ContentAlignment.BottomCenter;
            btnGroup39.UseVisualStyleBackColor = true;
            btnGroup39.Click += GroupButtonsGeneral_Click;
            // 
            // btnGroup40
            // 
            btnGroup40.BackgroundImageLayout = ImageLayout.Center;
            btnGroup40.FlatStyle = FlatStyle.Flat;
            btnGroup40.ImageAlign = ContentAlignment.TopCenter;
            btnGroup40.Location = new Point(372, 1110);
            btnGroup40.Name = "btnGroup40";
            btnGroup40.Size = new Size(117, 117);
            btnGroup40.TabIndex = 39;
            btnGroup40.TextAlign = ContentAlignment.BottomCenter;
            btnGroup40.UseVisualStyleBackColor = true;
            btnGroup40.Click += GroupButtonsGeneral_Click;
            // 
            // pnlGroups
            // 
            pnlGroups.BorderStyle = BorderStyle.FixedSingle;
            pnlGroups.Controls.Add(scRightContainer);
            pnlGroups.Dock = DockStyle.Top;
            pnlGroups.Location = new Point(0, 0);
            pnlGroups.Name = "pnlGroups";
            pnlGroups.Size = new Size(511, 97);
            pnlGroups.TabIndex = 7;
            // 
            // scRightContainer
            // 
            scRightContainer.BackColor = Color.White;
            scRightContainer.Dock = DockStyle.Top;
            scRightContainer.FixedPanel = FixedPanel.Panel1;
            scRightContainer.Location = new Point(0, 0);
            scRightContainer.Name = "scRightContainer";
            // 
            // scRightContainer.Panel1
            // 
            scRightContainer.Panel1.Controls.Add(btnAddGroup);
            // 
            // scRightContainer.Panel2
            // 
            scRightContainer.Panel2.Controls.Add(flpGroups);
            scRightContainer.Size = new Size(509, 95);
            scRightContainer.SplitterDistance = 64;
            scRightContainer.TabIndex = 1;
            // 
            // btnAddGroup
            // 
            btnAddGroup.BackColor = Color.Gainsboro;
            btnAddGroup.BackgroundImage = (Image)resources.GetObject("btnAddGroup.BackgroundImage");
            btnAddGroup.BackgroundImageLayout = ImageLayout.Center;
            btnAddGroup.FlatAppearance.BorderSize = 0;
            btnAddGroup.FlatStyle = FlatStyle.Flat;
            btnAddGroup.Location = new Point(3, 1);
            btnAddGroup.Name = "btnAddGroup";
            btnAddGroup.Size = new Size(60, 95);
            btnAddGroup.TabIndex = 5;
            btnAddGroup.UseVisualStyleBackColor = false;
            btnAddGroup.Click += btnAddGroup_Click;
            // 
            // flpGroups
            // 
            flpGroups.AutoScroll = true;
            flpGroups.BackColor = Color.White;
            flpGroups.Controls.Add(btnRootGroup);
            flpGroups.Dock = DockStyle.Fill;
            flpGroups.Location = new Point(0, 0);
            flpGroups.Name = "flpGroups";
            flpGroups.Size = new Size(441, 95);
            flpGroups.TabIndex = 5;
            flpGroups.WrapContents = false;
            // 
            // btnRootGroup
            // 
            btnRootGroup.BackgroundImage = Properties.Resources.cosmetic;
            btnRootGroup.BackgroundImageLayout = ImageLayout.Center;
            btnRootGroup.FlatStyle = FlatStyle.Flat;
            btnRootGroup.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnRootGroup.Location = new Point(3, 3);
            btnRootGroup.Name = "btnRootGroup";
            btnRootGroup.Size = new Size(79, 79);
            btnRootGroup.TabIndex = 1;
            btnRootGroup.TextAlign = ContentAlignment.BottomCenter;
            btnRootGroup.UseVisualStyleBackColor = true;
            btnRootGroup.Click += btnRootGroup_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnDeleteGroup);
            panel1.Controls.Add(btnSaveGroups);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 658);
            panel1.Name = "panel1";
            panel1.Size = new Size(511, 55);
            panel1.TabIndex = 1;
            // 
            // btnDeleteGroup
            // 
            btnDeleteGroup.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDeleteGroup.FlatStyle = FlatStyle.Flat;
            btnDeleteGroup.Font = new Font("Segoe UI", 15F);
            btnDeleteGroup.Location = new Point(5, 6);
            btnDeleteGroup.Name = "btnDeleteGroup";
            btnDeleteGroup.Size = new Size(115, 45);
            btnDeleteGroup.TabIndex = 8;
            btnDeleteGroup.Text = "Sil";
            btnDeleteGroup.UseVisualStyleBackColor = true;
            // 
            // btnSaveGroups
            // 
            btnSaveGroups.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSaveGroups.FlatStyle = FlatStyle.Flat;
            btnSaveGroups.Font = new Font("Segoe UI", 15F);
            btnSaveGroups.Location = new Point(393, 6);
            btnSaveGroups.Name = "btnSaveGroups";
            btnSaveGroups.Size = new Size(115, 45);
            btnSaveGroups.TabIndex = 7;
            btnSaveGroups.Text = "Kaydet";
            btnSaveGroups.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(130, 28);
            label1.TabIndex = 7;
            label1.Text = "SATIŞ İŞLEMİ";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(551, 67);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.WrapContents = false;
            // 
            // pnlAddGroup
            // 
            pnlAddGroup.BackColor = Color.Gainsboro;
            pnlAddGroup.Controls.Add(btnSelectGroupImage);
            pnlAddGroup.Controls.Add(tbNewGroupName);
            pnlAddGroup.Controls.Add(btnNewGroupAdd);
            pnlAddGroup.Controls.Add(label3);
            pnlAddGroup.Controls.Add(label2);
            pnlAddGroup.Location = new Point(558, 47);
            pnlAddGroup.Name = "pnlAddGroup";
            pnlAddGroup.Size = new Size(282, 115);
            pnlAddGroup.TabIndex = 8;
            pnlAddGroup.Visible = false;
            // 
            // btnSelectGroupImage
            // 
            btnSelectGroupImage.FlatStyle = FlatStyle.Flat;
            btnSelectGroupImage.Font = new Font("Segoe UI", 13F);
            btnSelectGroupImage.Location = new Point(129, 41);
            btnSelectGroupImage.Name = "btnSelectGroupImage";
            btnSelectGroupImage.Size = new Size(149, 34);
            btnSelectGroupImage.TabIndex = 4;
            btnSelectGroupImage.Text = "Resim seç";
            btnSelectGroupImage.UseVisualStyleBackColor = true;
            btnSelectGroupImage.Click += btnSelectGroupImage_Click;
            // 
            // tbNewGroupName
            // 
            tbNewGroupName.BorderStyle = BorderStyle.None;
            tbNewGroupName.Font = new Font("Segoe UI", 15F);
            tbNewGroupName.Location = new Point(108, 7);
            tbNewGroupName.Name = "tbNewGroupName";
            tbNewGroupName.Size = new Size(170, 27);
            tbNewGroupName.TabIndex = 3;
            // 
            // btnNewGroupAdd
            // 
            btnNewGroupAdd.FlatStyle = FlatStyle.Flat;
            btnNewGroupAdd.Font = new Font("Segoe UI", 13F);
            btnNewGroupAdd.Location = new Point(187, 78);
            btnNewGroupAdd.Name = "btnNewGroupAdd";
            btnNewGroupAdd.Size = new Size(91, 34);
            btnNewGroupAdd.TabIndex = 2;
            btnNewGroupAdd.Text = "Tamam";
            btnNewGroupAdd.UseVisualStyleBackColor = true;
            btnNewGroupAdd.Click += btnNewGroupAdd_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(7, 42);
            label3.Name = "label3";
            label3.Size = new Size(116, 28);
            label3.TabIndex = 1;
            label3.Text = "Grup Resmi:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(7, 5);
            label2.Name = "label2";
            label2.Size = new Size(95, 28);
            label2.TabIndex = 0;
            label2.Text = "Grup Adı:";
            // 
            // Sales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1366, 768);
            Controls.Add(pnlAddGroup);
            Controls.Add(label1);
            Controls.Add(SaleMainPanel);
            Controls.Add(btnMinimize);
            Controls.Add(btnMaximize);
            Controls.Add(btnClose);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Sales";
            Text = "Sales";
            Load += Sales_Load;
            SaleMainPanel.ResumeLayout(false);
            MainSplitContainer.Panel1.ResumeLayout(false);
            MainSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)MainSplitContainer).EndInit();
            MainSplitContainer.ResumeLayout(false);
            scLeftContainer.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)scLeftContainer).EndInit();
            scLeftContainer.ResumeLayout(false);
            scLeftInnerContainer.Panel1.ResumeLayout(false);
            scLeftInnerContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)scLeftInnerContainer).EndInit();
            scLeftInnerContainer.ResumeLayout(false);
            scLeftInnerTopContainer.Panel1.ResumeLayout(false);
            scLeftInnerTopContainer.Panel1.PerformLayout();
            scLeftInnerTopContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)scLeftInnerTopContainer).EndInit();
            scLeftInnerTopContainer.ResumeLayout(false);
            pnlAddCustomer.ResumeLayout(false);
            scAddCustomerContainer.Panel1.ResumeLayout(false);
            scAddCustomerContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)scAddCustomerContainer).EndInit();
            scAddCustomerContainer.ResumeLayout(false);
            flpCustomers.ResumeLayout(false);
            scLeftBottomMain.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)scLeftBottomMain).EndInit();
            scLeftBottomMain.ResumeLayout(false);
            scLeftBottomMainsTop.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)scLeftBottomMainsTop).EndInit();
            scLeftBottomMainsTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMain).EndInit();
            flpGroupButtons.ResumeLayout(false);
            pnlGroups.ResumeLayout(false);
            scRightContainer.Panel1.ResumeLayout(false);
            scRightContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)scRightContainer).EndInit();
            scRightContainer.ResumeLayout(false);
            flpGroups.ResumeLayout(false);
            panel1.ResumeLayout(false);
            pnlAddGroup.ResumeLayout(false);
            pnlAddGroup.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMinimize;
        private Button btnMaximize;
        private Button btnClose;
        private Panel SaleMainPanel;
        private Label label1;
        private SplitContainer MainSplitContainer;
        private Button btnSaveGroups;
        private FlowLayoutPanel flpGroupButtons;
        private Button btnGroup1;
        private Button btnGroup2;
        private Button btnGroup3;
        private Button btnGroup4;
        private Button btnGroup5;
        private Button btnGroup6;
        private Button btnGroup7;
        private Button btnGroup8;
        private Button btnGroup9;
        private Button btnGroup10;
        private Button btnGroup11;
        private Button btnGroup12;
        private Button btnGroup13;
        private Button btnGroup14;
        private Button btnGroup15;
        private Button btnGroup16;
        private Panel panel1;
        private Button btnGroup17;
        private Button btnGroup18;
        private Button btnGroup19;
        private Button btnGroup20;
        private Button btnGroup21;
        private Button btnGroup22;
        private Button btnGroup23;
        private Button btnGroup24;
        private Button btnGroup25;
        private Button btnGroup26;
        private Button btnGroup27;
        private Button btnGroup28;
        private Button btnGroup29;
        private Button btnGroup30;
        private Button btnGroup31;
        private Button btnGroup32;
        private Button btnGroup33;
        private Button btnGroup34;
        private Button btnGroup35;
        private Button btnGroup36;
        private Button btnGroup37;
        private Button btnGroup38;
        private Button btnGroup39;
        private Button btnGroup40;
        private Button btnDeleteGroup;
        private SplitContainer scLeftContainer;
        private SplitContainer scLeftInnerContainer;
        private SplitContainer scLeftInnerTopContainer;
        private CheckBox cbFree;
        private CheckBox cbReturn;
        private SplitContainer sc1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel pnlGroups;
        private SplitContainer scRightContainer;
        private Button btnAddGroup;
        private Panel pnlAddCustomer;
        private SplitContainer scAddCustomerContainer;
        private Button btnAddCustomer;
        private SplitContainer scLeftBottomMain;
        private SplitContainer scLeftBottomMainsTop;
        private DataGridView dgvMain;
        private DataGridViewTextBoxColumn Barcode;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Total;
        private DataGridViewButtonColumn Delete;
        private FlowLayoutPanel flpCustomers;
        private Button btnRootCustomer;
        private FlowLayoutPanel flpGroups;
        private Button btnRootGroup;
        private Panel pnlAddGroup;
        private Label label2;
        private Button btnSelectGroupImage;
        private TextBox tbNewGroupName;
        private Button btnNewGroupAdd;
        private Label label3;
    }
}