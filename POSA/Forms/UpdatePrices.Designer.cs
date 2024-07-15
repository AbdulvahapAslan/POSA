namespace POSA.Forms
{
    partial class UpdatePrices
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdatePrices));
            panel1 = new Panel();
            dgvMain = new DataGridView();
            CHECK = new DataGridViewCheckBoxColumn();
            BARCODE = new DataGridViewTextBoxColumn();
            NAME = new DataGridViewTextBoxColumn();
            PRICE = new DataGridViewTextBoxColumn();
            pbClearSearch = new PictureBox();
            pbMagGlass = new PictureBox();
            rtbSearch = new CustomObjects.RoundTextBox();
            panel2 = new Panel();
            dgvSelects = new DataGridView();
            SBARCODE = new DataGridViewTextBoxColumn();
            SNAME = new DataGridViewTextBoxColumn();
            OLDPRICE = new DataGridViewTextBoxColumn();
            NEWPRICE = new DataGridViewTextBoxColumn();
            label8 = new Label();
            cbPriceType = new ComboBox();
            btnGetSelects = new Button();
            tbPercentage = new TextBox();
            btnApply = new Button();
            btnSave = new Button();
            btn3 = new Button();
            btn5 = new Button();
            btn10 = new Button();
            btn8 = new Button();
            btn12 = new Button();
            btn50 = new Button();
            btn35 = new Button();
            btn25 = new Button();
            btn20 = new Button();
            btn15 = new Button();
            label1 = new Label();
            cbType = new ComboBox();
            btnForAllProducts = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel3 = new Panel();
            btnMinimize = new Button();
            btnMaximize = new Button();
            btnClose = new Button();
            lblPageHeaderUpdatePrice = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMain).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbClearSearch).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbMagGlass).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSelects).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(dgvMain);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(10, 10);
            panel1.Margin = new Padding(10);
            panel1.Name = "panel1";
            panel1.Size = new Size(441, 445);
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(1, 39, 103);
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(1, 39, 103);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvMain.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvMain.ColumnHeadersHeight = 50;
            dgvMain.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvMain.Columns.AddRange(new DataGridViewColumn[] { CHECK, BARCODE, NAME, PRICE });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 162);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(1, 39, 103);
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(1, 39, 103);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvMain.DefaultCellStyle = dataGridViewCellStyle2;
            dgvMain.EnableHeadersVisualStyles = false;
            dgvMain.GridColor = Color.White;
            dgvMain.Location = new Point(10, 10);
            dgvMain.Margin = new Padding(10);
            dgvMain.MultiSelect = false;
            dgvMain.Name = "dgvMain";
            dgvMain.ReadOnly = true;
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
            dgvMain.Size = new Size(421, 425);
            dgvMain.TabIndex = 76;
            dgvMain.CellDoubleClick += dgvMain_CellDoubleClick;
            // 
            // CHECK
            // 
            CHECK.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CHECK.FillWeight = 10F;
            CHECK.HeaderText = "";
            CHECK.Name = "CHECK";
            CHECK.ReadOnly = true;
            // 
            // BARCODE
            // 
            BARCODE.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            BARCODE.DataPropertyName = "BARCODE";
            BARCODE.FillWeight = 25F;
            BARCODE.HeaderText = "BARKOD";
            BARCODE.MaxInputLength = 100;
            BARCODE.Name = "BARCODE";
            BARCODE.ReadOnly = true;
            // 
            // NAME
            // 
            NAME.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NAME.DataPropertyName = "NAME";
            NAME.FillWeight = 40F;
            NAME.HeaderText = "ÜRÜN ADI";
            NAME.MaxInputLength = 50;
            NAME.Name = "NAME";
            NAME.ReadOnly = true;
            // 
            // PRICE
            // 
            PRICE.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            PRICE.DataPropertyName = "PRICE";
            PRICE.FillWeight = 25F;
            PRICE.HeaderText = "FİYAT";
            PRICE.Name = "PRICE";
            PRICE.ReadOnly = true;
            // 
            // pbClearSearch
            // 
            pbClearSearch.BackColor = Color.White;
            pbClearSearch.BackgroundImage = Properties.Resources._16pxCloseBlack;
            pbClearSearch.BackgroundImageLayout = ImageLayout.Center;
            pbClearSearch.Location = new Point(254, 67);
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
            pbMagGlass.Location = new Point(23, 67);
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
            rtbSearch.Location = new Point(19, 63);
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
            rtbSearch._TextChanged += rtbSearch__TextChanged;
            rtbSearch.KeyDown += rtbSearch_KeyDown;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(dgvSelects);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(711, 10);
            panel2.Margin = new Padding(10);
            panel2.Name = "panel2";
            panel2.Size = new Size(441, 445);
            panel2.TabIndex = 77;
            // 
            // dgvSelects
            // 
            dgvSelects.AllowUserToAddRows = false;
            dgvSelects.AllowUserToDeleteRows = false;
            dgvSelects.AllowUserToResizeColumns = false;
            dgvSelects.AllowUserToResizeRows = false;
            dgvSelects.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvSelects.BackgroundColor = Color.White;
            dgvSelects.BorderStyle = BorderStyle.None;
            dgvSelects.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvSelects.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(1, 39, 103);
            dataGridViewCellStyle3.SelectionBackColor = Color.White;
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(1, 39, 103);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvSelects.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvSelects.ColumnHeadersHeight = 50;
            dgvSelects.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvSelects.Columns.AddRange(new DataGridViewColumn[] { SBARCODE, SNAME, OLDPRICE, NEWPRICE });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 162);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(1, 39, 103);
            dataGridViewCellStyle4.SelectionBackColor = Color.White;
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(1, 39, 103);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvSelects.DefaultCellStyle = dataGridViewCellStyle4;
            dgvSelects.EnableHeadersVisualStyles = false;
            dgvSelects.GridColor = Color.White;
            dgvSelects.Location = new Point(7, 10);
            dgvSelects.Margin = new Padding(10);
            dgvSelects.MultiSelect = false;
            dgvSelects.Name = "dgvSelects";
            dgvSelects.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvSelects.RowHeadersVisible = false;
            dgvSelects.RowHeadersWidth = 35;
            dgvSelects.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvSelects.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvSelects.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(210, 226, 252);
            dgvSelects.RowTemplate.DefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvSelects.RowTemplate.DefaultCellStyle.ForeColor = Color.FromArgb(1, 39, 103);
            dgvSelects.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(109, 134, 176);
            dgvSelects.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvSelects.RowTemplate.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvSelects.RowTemplate.DividerHeight = 10;
            dgvSelects.RowTemplate.Height = 40;
            dgvSelects.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSelects.Size = new Size(424, 425);
            dgvSelects.TabIndex = 76;
            // 
            // SBARCODE
            // 
            SBARCODE.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SBARCODE.DataPropertyName = "BARCODE";
            SBARCODE.FillWeight = 20F;
            SBARCODE.HeaderText = "BARKOD";
            SBARCODE.MaxInputLength = 100;
            SBARCODE.Name = "SBARCODE";
            SBARCODE.ReadOnly = true;
            // 
            // SNAME
            // 
            SNAME.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SNAME.DataPropertyName = "NAME";
            SNAME.FillWeight = 35F;
            SNAME.HeaderText = "ÜRÜN ADI";
            SNAME.MaxInputLength = 50;
            SNAME.Name = "SNAME";
            SNAME.ReadOnly = true;
            // 
            // OLDPRICE
            // 
            OLDPRICE.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            OLDPRICE.DataPropertyName = "PRICE";
            OLDPRICE.FillWeight = 17F;
            OLDPRICE.HeaderText = "FİYAT";
            OLDPRICE.Name = "OLDPRICE";
            OLDPRICE.ReadOnly = true;
            // 
            // NEWPRICE
            // 
            NEWPRICE.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NEWPRICE.FillWeight = 18F;
            NEWPRICE.HeaderText = "YENİ FİYAT";
            NEWPRICE.Name = "NEWPRICE";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label8.ForeColor = Color.White;
            label8.Location = new Point(305, 73);
            label8.Name = "label8";
            label8.Size = new Size(71, 20);
            label8.TabIndex = 92;
            label8.Text = "Fiyat Tipi";
            // 
            // cbPriceType
            // 
            cbPriceType.BackColor = Color.White;
            cbPriceType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPriceType.FlatStyle = FlatStyle.Flat;
            cbPriceType.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            cbPriceType.FormattingEnabled = true;
            cbPriceType.Items.AddRange(new object[] { "1", "2", "3" });
            cbPriceType.Location = new Point(382, 70);
            cbPriceType.Name = "cbPriceType";
            cbPriceType.Size = new Size(88, 28);
            cbPriceType.TabIndex = 91;
            cbPriceType.SelectedIndexChanged += cbPriceType_SelectedIndexChanged;
            // 
            // btnGetSelects
            // 
            btnGetSelects.BackColor = Color.White;
            btnGetSelects.FlatAppearance.BorderSize = 0;
            btnGetSelects.FlatStyle = FlatStyle.Flat;
            btnGetSelects.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnGetSelects.ForeColor = Color.FromArgb(95, 95, 95);
            btnGetSelects.Image = Properties.Resources._32pxBlueRightArrows;
            btnGetSelects.Location = new Point(9, 7);
            btnGetSelects.Name = "btnGetSelects";
            btnGetSelects.Size = new Size(63, 40);
            btnGetSelects.TabIndex = 93;
            btnGetSelects.TextAlign = ContentAlignment.MiddleRight;
            btnGetSelects.UseVisualStyleBackColor = false;
            btnGetSelects.Click += btnGetSelects_Click;
            // 
            // tbPercentage
            // 
            tbPercentage.BackColor = Color.White;
            tbPercentage.BorderStyle = BorderStyle.None;
            tbPercentage.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            tbPercentage.Location = new Point(9, 112);
            tbPercentage.Name = "tbPercentage";
            tbPercentage.PlaceholderText = "%BELİRLE";
            tbPercentage.Size = new Size(218, 45);
            tbPercentage.TabIndex = 94;
            // 
            // btnApply
            // 
            btnApply.BackColor = Color.White;
            btnApply.FlatAppearance.BorderSize = 0;
            btnApply.FlatStyle = FlatStyle.Flat;
            btnApply.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            btnApply.ForeColor = Color.FromArgb(77, 176, 52);
            btnApply.Location = new Point(9, 258);
            btnApply.Margin = new Padding(3, 10, 3, 3);
            btnApply.Name = "btnApply";
            btnApply.Size = new Size(218, 40);
            btnApply.TabIndex = 95;
            btnApply.Text = "UYGULA";
            btnApply.UseVisualStyleBackColor = false;
            btnApply.Click += btnApply_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.White;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            btnSave.ForeColor = Color.FromArgb(77, 176, 52);
            btnSave.Location = new Point(9, 304);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(218, 40);
            btnSave.TabIndex = 96;
            btnSave.Text = "KAYDET";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btn3
            // 
            btn3.BackColor = Color.White;
            btn3.FlatAppearance.BorderSize = 0;
            btn3.FlatStyle = FlatStyle.Flat;
            btn3.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            btn3.ForeColor = Color.FromArgb(77, 176, 52);
            btn3.Location = new Point(9, 161);
            btn3.Margin = new Padding(1);
            btn3.Name = "btn3";
            btn3.Size = new Size(42, 42);
            btn3.TabIndex = 97;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            // 
            // btn5
            // 
            btn5.BackColor = Color.White;
            btn5.FlatAppearance.BorderSize = 0;
            btn5.FlatStyle = FlatStyle.Flat;
            btn5.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            btn5.ForeColor = Color.FromArgb(77, 176, 52);
            btn5.Location = new Point(53, 161);
            btn5.Margin = new Padding(1);
            btn5.Name = "btn5";
            btn5.Size = new Size(42, 42);
            btn5.TabIndex = 98;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            // 
            // btn10
            // 
            btn10.BackColor = Color.White;
            btn10.FlatAppearance.BorderSize = 0;
            btn10.FlatStyle = FlatStyle.Flat;
            btn10.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            btn10.ForeColor = Color.FromArgb(77, 176, 52);
            btn10.Location = new Point(141, 161);
            btn10.Margin = new Padding(1);
            btn10.Name = "btn10";
            btn10.Size = new Size(42, 42);
            btn10.TabIndex = 100;
            btn10.Text = "10";
            btn10.UseVisualStyleBackColor = false;
            // 
            // btn8
            // 
            btn8.BackColor = Color.White;
            btn8.FlatAppearance.BorderSize = 0;
            btn8.FlatStyle = FlatStyle.Flat;
            btn8.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            btn8.ForeColor = Color.FromArgb(77, 176, 52);
            btn8.Location = new Point(97, 161);
            btn8.Margin = new Padding(1);
            btn8.Name = "btn8";
            btn8.Size = new Size(42, 42);
            btn8.TabIndex = 99;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            // 
            // btn12
            // 
            btn12.BackColor = Color.White;
            btn12.FlatAppearance.BorderSize = 0;
            btn12.FlatStyle = FlatStyle.Flat;
            btn12.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            btn12.ForeColor = Color.FromArgb(77, 176, 52);
            btn12.Location = new Point(185, 161);
            btn12.Margin = new Padding(1);
            btn12.Name = "btn12";
            btn12.Size = new Size(42, 42);
            btn12.TabIndex = 101;
            btn12.Text = "12";
            btn12.UseVisualStyleBackColor = false;
            // 
            // btn50
            // 
            btn50.BackColor = Color.White;
            btn50.FlatAppearance.BorderSize = 0;
            btn50.FlatStyle = FlatStyle.Flat;
            btn50.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            btn50.ForeColor = Color.FromArgb(77, 176, 52);
            btn50.Location = new Point(185, 205);
            btn50.Margin = new Padding(1);
            btn50.Name = "btn50";
            btn50.Size = new Size(42, 42);
            btn50.TabIndex = 106;
            btn50.Text = "50";
            btn50.UseVisualStyleBackColor = false;
            // 
            // btn35
            // 
            btn35.BackColor = Color.White;
            btn35.FlatAppearance.BorderSize = 0;
            btn35.FlatStyle = FlatStyle.Flat;
            btn35.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            btn35.ForeColor = Color.FromArgb(77, 176, 52);
            btn35.Location = new Point(141, 205);
            btn35.Margin = new Padding(1);
            btn35.Name = "btn35";
            btn35.Size = new Size(42, 42);
            btn35.TabIndex = 105;
            btn35.Text = "35";
            btn35.UseVisualStyleBackColor = false;
            // 
            // btn25
            // 
            btn25.BackColor = Color.White;
            btn25.FlatAppearance.BorderSize = 0;
            btn25.FlatStyle = FlatStyle.Flat;
            btn25.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            btn25.ForeColor = Color.FromArgb(77, 176, 52);
            btn25.Location = new Point(97, 205);
            btn25.Margin = new Padding(1);
            btn25.Name = "btn25";
            btn25.Size = new Size(42, 42);
            btn25.TabIndex = 104;
            btn25.Text = "25";
            btn25.UseVisualStyleBackColor = false;
            // 
            // btn20
            // 
            btn20.BackColor = Color.White;
            btn20.FlatAppearance.BorderSize = 0;
            btn20.FlatStyle = FlatStyle.Flat;
            btn20.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            btn20.ForeColor = Color.FromArgb(77, 176, 52);
            btn20.Location = new Point(53, 205);
            btn20.Margin = new Padding(1);
            btn20.Name = "btn20";
            btn20.Size = new Size(42, 42);
            btn20.TabIndex = 103;
            btn20.Text = "20";
            btn20.UseVisualStyleBackColor = false;
            // 
            // btn15
            // 
            btn15.BackColor = Color.White;
            btn15.FlatAppearance.BorderSize = 0;
            btn15.FlatStyle = FlatStyle.Flat;
            btn15.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            btn15.ForeColor = Color.FromArgb(77, 176, 52);
            btn15.Location = new Point(9, 205);
            btn15.Margin = new Padding(1);
            btn15.Name = "btn15";
            btn15.Size = new Size(42, 42);
            btn15.TabIndex = 102;
            btn15.Text = "15";
            btn15.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.White;
            label1.Location = new Point(9, 50);
            label1.Name = "label1";
            label1.Size = new Size(103, 25);
            label1.TabIndex = 107;
            label1.Text = "İŞLEM TİPİ";
            // 
            // cbType
            // 
            cbType.BackColor = Color.White;
            cbType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbType.FlatStyle = FlatStyle.Flat;
            cbType.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            cbType.FormattingEnabled = true;
            cbType.Items.AddRange(new object[] { "ARTTIR", "AZALT" });
            cbType.Location = new Point(9, 78);
            cbType.Name = "cbType";
            cbType.Size = new Size(218, 28);
            cbType.TabIndex = 108;
            // 
            // btnForAllProducts
            // 
            btnForAllProducts.BackColor = Color.White;
            btnForAllProducts.FlatAppearance.BorderSize = 0;
            btnForAllProducts.FlatStyle = FlatStyle.Flat;
            btnForAllProducts.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnForAllProducts.ForeColor = Color.Black;
            btnForAllProducts.Location = new Point(78, 7);
            btnForAllProducts.Name = "btnForAllProducts";
            btnForAllProducts.Size = new Size(149, 40);
            btnForAllProducts.TabIndex = 111;
            btnForAllProducts.Text = "Tümüne Uygula";
            btnForAllProducts.UseVisualStyleBackColor = false;
            btnForAllProducts.Click += btnForAllProducts_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 240F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel3, 1, 0);
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel2, 2, 0);
            tableLayoutPanel1.Location = new Point(12, 99);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1162, 465);
            tableLayoutPanel1.TabIndex = 112;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(btnForAllProducts);
            panel3.Controls.Add(btnGetSelects);
            panel3.Controls.Add(btn50);
            panel3.Controls.Add(tbPercentage);
            panel3.Controls.Add(btn35);
            panel3.Controls.Add(btn25);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(btn20);
            panel3.Controls.Add(btn15);
            panel3.Controls.Add(cbType);
            panel3.Controls.Add(btn12);
            panel3.Controls.Add(btn3);
            panel3.Controls.Add(btn10);
            panel3.Controls.Add(btnApply);
            panel3.Controls.Add(btn8);
            panel3.Controls.Add(btnSave);
            panel3.Controls.Add(btn5);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(464, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(234, 459);
            panel3.TabIndex = 113;
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
            btnMinimize.Location = new Point(962, 12);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(70, 35);
            btnMinimize.TabIndex = 115;
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
            btnMaximize.Location = new Point(1033, 12);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(70, 35);
            btnMaximize.TabIndex = 114;
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
            btnClose.FlatAppearance.MouseDownBackColor = Color.Red;
            btnClose.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(1104, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(70, 35);
            btnClose.TabIndex = 113;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // lblPageHeaderUpdatePrice
            // 
            lblPageHeaderUpdatePrice.AutoSize = true;
            lblPageHeaderUpdatePrice.BackColor = Color.Transparent;
            lblPageHeaderUpdatePrice.Font = new Font("Segoe UI Semibold", 17F, FontStyle.Bold);
            lblPageHeaderUpdatePrice.ForeColor = Color.White;
            lblPageHeaderUpdatePrice.Location = new Point(19, 12);
            lblPageHeaderUpdatePrice.Name = "lblPageHeaderUpdatePrice";
            lblPageHeaderUpdatePrice.Size = new Size(186, 31);
            lblPageHeaderUpdatePrice.TabIndex = 116;
            lblPageHeaderUpdatePrice.Text = "FİYAT GÜNCELLE";
            // 
            // UpdatePrices
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 74, 173);
            BackgroundImage = Properties.Resources.BackgroundGeneral;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1186, 578);
            Controls.Add(lblPageHeaderUpdatePrice);
            Controls.Add(btnMinimize);
            Controls.Add(btnMaximize);
            Controls.Add(btnClose);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label8);
            Controls.Add(cbPriceType);
            Controls.Add(pbClearSearch);
            Controls.Add(pbMagGlass);
            Controls.Add(rtbSearch);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "UpdatePrices";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UpdatePrices";
            WindowState = FormWindowState.Maximized;
            Load += AddCustomerReportForm_Load;
            MouseDown += UpdatePrices_MouseDown;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMain).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbClearSearch).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbMagGlass).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSelects).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private DataGridView dgvMain;
        private PictureBox pbClearSearch;
        private PictureBox pbMagGlass;
        private CustomObjects.RoundTextBox rtbSearch;
        private Panel panel2;
        private DataGridView dgvSelects;
        private DataGridViewCheckBoxColumn CHECK;
        private DataGridViewTextBoxColumn BARCODE;
        private DataGridViewTextBoxColumn NAME;
        private DataGridViewTextBoxColumn PRICE;
        private Label label8;
        private ComboBox cbPriceType;
        private Button btnGetSelects;
        private TextBox tbPercentage;
        private Button btnApply;
        private Button btnSave;
        private Button btn3;
        private Button btn5;
        private Button btn10;
        private Button btn8;
        private Button btn12;
        private Button btn50;
        private Button btn35;
        private Button btn25;
        private Button btn20;
        private Button btn15;
        private Label label1;
        private ComboBox cbType;
        private DataGridViewTextBoxColumn SBARCODE;
        private DataGridViewTextBoxColumn SNAME;
        private DataGridViewTextBoxColumn OLDPRICE;
        private DataGridViewTextBoxColumn NEWPRICE;
        private Button btnForAllProducts;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel3;
        private Button btnMinimize;
        private Button btnMaximize;
        private Button btnClose;
        private Label lblPageHeaderUpdatePrice;
    }
}