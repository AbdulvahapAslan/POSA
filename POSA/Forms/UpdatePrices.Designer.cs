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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
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
            dataGridView1 = new DataGridView();
            dataGridViewCheckBoxColumn1 = new DataGridViewCheckBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            NEWPRICE = new DataGridViewTextBoxColumn();
            label8 = new Label();
            cbPriceType = new ComboBox();
            btnSearchProduct = new Button();
            tbSearch = new TextBox();
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
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMain).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbClearSearch).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbMagGlass).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(dgvMain);
            panel1.Location = new Point(19, 65);
            panel1.Margin = new Padding(10);
            panel1.Name = "panel1";
            panel1.Size = new Size(451, 446);
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
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(1, 39, 103);
            dataGridViewCellStyle5.SelectionBackColor = Color.White;
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(1, 39, 103);
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvMain.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvMain.ColumnHeadersHeight = 50;
            dgvMain.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvMain.Columns.AddRange(new DataGridViewColumn[] { CHECK, BARCODE, NAME, PRICE });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 162);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(1, 39, 103);
            dataGridViewCellStyle6.SelectionBackColor = Color.White;
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(1, 39, 103);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvMain.DefaultCellStyle = dataGridViewCellStyle6;
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
            dgvMain.Size = new Size(431, 426);
            dgvMain.TabIndex = 76;
            dgvMain.CellClick += dgvMain_CellClick;
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
            pbClearSearch.Location = new Point(254, 21);
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
            pbMagGlass.Location = new Point(23, 21);
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
            rtbSearch.Location = new Point(19, 17);
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
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(dataGridView1);
            panel2.Location = new Point(714, 65);
            panel2.Margin = new Padding(10);
            panel2.Name = "panel2";
            panel2.Size = new Size(451, 446);
            panel2.TabIndex = 77;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = Color.White;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = Color.FromArgb(1, 39, 103);
            dataGridViewCellStyle7.SelectionBackColor = Color.White;
            dataGridViewCellStyle7.SelectionForeColor = Color.FromArgb(1, 39, 103);
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridView1.ColumnHeadersHeight = 50;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dataGridViewCheckBoxColumn1, dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, NEWPRICE });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.White;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 162);
            dataGridViewCellStyle8.ForeColor = Color.FromArgb(1, 39, 103);
            dataGridViewCellStyle8.SelectionBackColor = Color.White;
            dataGridViewCellStyle8.SelectionForeColor = Color.FromArgb(1, 39, 103);
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle8;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.White;
            dataGridView1.Location = new Point(7, 10);
            dataGridView1.Margin = new Padding(10);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 35;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(210, 226, 252);
            dataGridView1.RowTemplate.DefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridView1.RowTemplate.DefaultCellStyle.ForeColor = Color.FromArgb(1, 39, 103);
            dataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(109, 134, 176);
            dataGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView1.RowTemplate.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowTemplate.DividerHeight = 10;
            dataGridView1.RowTemplate.Height = 40;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(434, 426);
            dataGridView1.TabIndex = 76;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            dataGridViewCheckBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCheckBoxColumn1.FillWeight = 10F;
            dataGridViewCheckBoxColumn1.HeaderText = "";
            dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn1.DataPropertyName = "BARCODE";
            dataGridViewTextBoxColumn1.FillWeight = 20F;
            dataGridViewTextBoxColumn1.HeaderText = "BARKOD";
            dataGridViewTextBoxColumn1.MaxInputLength = 100;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn2.DataPropertyName = "NAME";
            dataGridViewTextBoxColumn2.FillWeight = 35F;
            dataGridViewTextBoxColumn2.HeaderText = "ÜRÜN ADI";
            dataGridViewTextBoxColumn2.MaxInputLength = 50;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn3.DataPropertyName = "PRICE";
            dataGridViewTextBoxColumn3.FillWeight = 17F;
            dataGridViewTextBoxColumn3.HeaderText = "FİYAT";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
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
            label8.Location = new Point(305, 27);
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
            cbPriceType.Location = new Point(382, 24);
            cbPriceType.Name = "cbPriceType";
            cbPriceType.Size = new Size(88, 28);
            cbPriceType.TabIndex = 91;
            // 
            // btnSearchProduct
            // 
            btnSearchProduct.BackColor = Color.White;
            btnSearchProduct.FlatAppearance.BorderSize = 0;
            btnSearchProduct.FlatStyle = FlatStyle.Flat;
            btnSearchProduct.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSearchProduct.ForeColor = Color.FromArgb(95, 95, 95);
            btnSearchProduct.Image = Properties.Resources._32pxBlueRightArrows;
            btnSearchProduct.Location = new Point(483, 127);
            btnSearchProduct.Name = "btnSearchProduct";
            btnSearchProduct.Size = new Size(63, 40);
            btnSearchProduct.TabIndex = 93;
            btnSearchProduct.TextAlign = ContentAlignment.MiddleRight;
            btnSearchProduct.UseVisualStyleBackColor = false;
            // 
            // tbSearch
            // 
            tbSearch.BackColor = Color.White;
            tbSearch.BorderStyle = BorderStyle.None;
            tbSearch.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            tbSearch.Location = new Point(483, 173);
            tbSearch.Name = "tbSearch";
            tbSearch.PlaceholderText = "%BELİRLE";
            tbSearch.Size = new Size(218, 45);
            tbSearch.TabIndex = 94;
            // 
            // btnApply
            // 
            btnApply.BackColor = Color.White;
            btnApply.FlatAppearance.BorderSize = 0;
            btnApply.FlatStyle = FlatStyle.Flat;
            btnApply.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            btnApply.ForeColor = Color.FromArgb(77, 176, 52);
            btnApply.Location = new Point(483, 319);
            btnApply.Margin = new Padding(3, 10, 3, 3);
            btnApply.Name = "btnApply";
            btnApply.Size = new Size(218, 40);
            btnApply.TabIndex = 95;
            btnApply.Text = "UYGULA";
            btnApply.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.White;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            btnSave.ForeColor = Color.FromArgb(77, 176, 52);
            btnSave.Location = new Point(483, 365);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(218, 40);
            btnSave.TabIndex = 96;
            btnSave.Text = "KAYDET";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // btn3
            // 
            btn3.BackColor = Color.White;
            btn3.FlatAppearance.BorderSize = 0;
            btn3.FlatStyle = FlatStyle.Flat;
            btn3.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            btn3.ForeColor = Color.FromArgb(77, 176, 52);
            btn3.Location = new Point(483, 226);
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
            btn5.Location = new Point(527, 226);
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
            btn10.Location = new Point(615, 226);
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
            btn8.Location = new Point(571, 226);
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
            btn12.Location = new Point(659, 226);
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
            btn50.Location = new Point(659, 270);
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
            btn35.Location = new Point(615, 270);
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
            btn25.Location = new Point(571, 270);
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
            btn20.Location = new Point(527, 270);
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
            btn15.Location = new Point(483, 270);
            btn15.Margin = new Padding(1);
            btn15.Name = "btn15";
            btn15.Size = new Size(42, 42);
            btn15.TabIndex = 102;
            btn15.Text = "15";
            btn15.UseVisualStyleBackColor = false;
            // 
            // UpdatePrices
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(0, 74, 173);
            BackgroundImage = Properties.Resources.BackgroundSmall1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1186, 530);
            Controls.Add(btn50);
            Controls.Add(btn35);
            Controls.Add(btn25);
            Controls.Add(btn20);
            Controls.Add(btn15);
            Controls.Add(btn12);
            Controls.Add(btn10);
            Controls.Add(btn8);
            Controls.Add(btn5);
            Controls.Add(btn3);
            Controls.Add(btnSave);
            Controls.Add(btnApply);
            Controls.Add(tbSearch);
            Controls.Add(btnSearchProduct);
            Controls.Add(label8);
            Controls.Add(cbPriceType);
            Controls.Add(panel2);
            Controls.Add(pbClearSearch);
            Controls.Add(pbMagGlass);
            Controls.Add(rtbSearch);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "UpdatePrices";
            Text = "AddSupplierReportForm";
            Load += AddCustomerReportForm_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMain).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbClearSearch).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbMagGlass).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private DataGridView dataGridView1;
        private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn NEWPRICE;
        private DataGridViewCheckBoxColumn CHECK;
        private DataGridViewTextBoxColumn BARCODE;
        private DataGridViewTextBoxColumn NAME;
        private DataGridViewTextBoxColumn PRICE;
        private Label label8;
        private ComboBox cbPriceType;
        private Button btnSearchProduct;
        private TextBox tbSearch;
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
    }
}