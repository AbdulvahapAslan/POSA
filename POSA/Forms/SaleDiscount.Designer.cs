namespace POSA.Forms
{
    partial class SaleDiscount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaleDiscount));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            btnClose = new CustomObjects.RoundButton();
            lblPageHeaderAddColor = new Label();
            btnSave = new Button();
            dgvMain = new DataGridView();
            BARCODE = new DataGridViewTextBoxColumn();
            CHECK = new DataGridViewCheckBoxColumn();
            NAME = new DataGridViewTextBoxColumn();
            OLDPRICE = new DataGridViewTextBoxColumn();
            NEWPRICE = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            btnSelectAll = new Button();
            tbPercentage = new TextBox();
            btn3 = new Button();
            btn5 = new Button();
            btn10 = new Button();
            btn8 = new Button();
            btn50 = new Button();
            btn25 = new Button();
            btn20 = new Button();
            btn18 = new Button();
            btn90 = new Button();
            btn75 = new Button();
            btn15 = new Button();
            btn13 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvMain).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.BackColor = Color.Transparent;
            btnClose.BackgroundColor = Color.Transparent;
            btnClose.BackgroundImage = (Image)resources.GetObject("btnClose.BackgroundImage");
            btnClose.BackgroundImageLayout = ImageLayout.Stretch;
            btnClose.BorderColor = Color.PaleVioletRed;
            btnClose.BorderRadius = 0;
            btnClose.BorderSize = 0;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(723, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(28, 28);
            btnClose.TabIndex = 34;
            btnClose.TextColor = Color.White;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // lblPageHeaderAddColor
            // 
            lblPageHeaderAddColor.AutoSize = true;
            lblPageHeaderAddColor.BackColor = Color.Transparent;
            lblPageHeaderAddColor.Font = new Font("Segoe UI Semibold", 17F, FontStyle.Bold);
            lblPageHeaderAddColor.ForeColor = Color.White;
            lblPageHeaderAddColor.Location = new Point(12, 9);
            lblPageHeaderAddColor.Name = "lblPageHeaderAddColor";
            lblPageHeaderAddColor.Size = new Size(204, 31);
            lblPageHeaderAddColor.TabIndex = 43;
            lblPageHeaderAddColor.Text = "İSKONTO UYGULA";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.White;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 19F, FontStyle.Bold);
            btnSave.ForeColor = Color.FromArgb(66, 178, 38);
            btnSave.ImageAlign = ContentAlignment.TopCenter;
            btnSave.Location = new Point(530, 589);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(147, 91);
            btnSave.TabIndex = 74;
            btnSave.Text = "UYGULA";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
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
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(1, 39, 103);
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(1, 39, 103);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvMain.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvMain.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMain.Columns.AddRange(new DataGridViewColumn[] { BARCODE, CHECK, NAME, OLDPRICE, NEWPRICE });
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
            dgvMain.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvMain.RowHeadersVisible = false;
            dgvMain.RowHeadersWidth = 35;
            dgvMain.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvMain.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvMain.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(210, 226, 252);
            dgvMain.RowTemplate.DefaultCellStyle.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            dgvMain.RowTemplate.DefaultCellStyle.ForeColor = Color.FromArgb(1, 39, 103);
            dgvMain.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(109, 134, 176);
            dgvMain.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvMain.RowTemplate.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvMain.RowTemplate.DividerHeight = 10;
            dgvMain.RowTemplate.Height = 40;
            dgvMain.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMain.Size = new Size(580, 480);
            dgvMain.TabIndex = 75;
            // 
            // BARCODE
            // 
            BARCODE.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            BARCODE.DataPropertyName = "BARCODE";
            BARCODE.HeaderText = "BARKOD";
            BARCODE.MaxInputLength = 100;
            BARCODE.Name = "BARCODE";
            BARCODE.Visible = false;
            // 
            // CHECK
            // 
            CHECK.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CHECK.FillWeight = 5F;
            CHECK.HeaderText = "";
            CHECK.Name = "CHECK";
            CHECK.Resizable = DataGridViewTriState.True;
            CHECK.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // NAME
            // 
            NAME.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NAME.DataPropertyName = "NAME";
            NAME.FillWeight = 45F;
            NAME.HeaderText = "ÜRÜN ADI";
            NAME.MaxInputLength = 50;
            NAME.Name = "NAME";
            // 
            // OLDPRICE
            // 
            OLDPRICE.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            OLDPRICE.DataPropertyName = "OLDPRICE";
            OLDPRICE.FillWeight = 25F;
            OLDPRICE.HeaderText = "SATIR TUTARI";
            OLDPRICE.Name = "OLDPRICE";
            // 
            // NEWPRICE
            // 
            NEWPRICE.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NEWPRICE.FillWeight = 25F;
            NEWPRICE.HeaderText = "İSKONTOLU TUTAR";
            NEWPRICE.Name = "NEWPRICE";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnSelectAll);
            panel1.Controls.Add(dgvMain);
            panel1.Location = new Point(77, 83);
            panel1.Name = "panel1";
            panel1.Size = new Size(600, 500);
            panel1.TabIndex = 76;
            // 
            // btnSelectAll
            // 
            btnSelectAll.BackColor = Color.White;
            btnSelectAll.FlatStyle = FlatStyle.Flat;
            btnSelectAll.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnSelectAll.ForeColor = Color.FromArgb(66, 178, 38);
            btnSelectAll.ImageAlign = ContentAlignment.TopCenter;
            btnSelectAll.Location = new Point(10, 16);
            btnSelectAll.Name = "btnSelectAll";
            btnSelectAll.Size = new Size(56, 42);
            btnSelectAll.TabIndex = 91;
            btnSelectAll.Text = "SEÇ";
            btnSelectAll.UseVisualStyleBackColor = false;
            btnSelectAll.Click += btnSelectAll_Click;
            // 
            // tbPercentage
            // 
            tbPercentage.Font = new Font("Segoe UI", 47F, FontStyle.Bold);
            tbPercentage.Location = new Point(365, 589);
            tbPercentage.Name = "tbPercentage";
            tbPercentage.PlaceholderText = "%...";
            tbPercentage.Size = new Size(159, 91);
            tbPercentage.TabIndex = 77;
            tbPercentage.TextChanged += tbPercentage_TextChanged;
            // 
            // btn3
            // 
            btn3.BackColor = Color.White;
            btn3.FlatAppearance.BorderSize = 0;
            btn3.FlatStyle = FlatStyle.Flat;
            btn3.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btn3.ForeColor = Color.FromArgb(66, 178, 38);
            btn3.ImageAlign = ContentAlignment.TopCenter;
            btn3.Location = new Point(77, 590);
            btn3.Name = "btn3";
            btn3.Size = new Size(42, 42);
            btn3.TabIndex = 78;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += btnNumbers_Click;
            // 
            // btn5
            // 
            btn5.BackColor = Color.White;
            btn5.FlatAppearance.BorderSize = 0;
            btn5.FlatStyle = FlatStyle.Flat;
            btn5.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btn5.ForeColor = Color.FromArgb(66, 178, 38);
            btn5.ImageAlign = ContentAlignment.TopCenter;
            btn5.Location = new Point(125, 590);
            btn5.Name = "btn5";
            btn5.Size = new Size(42, 42);
            btn5.TabIndex = 79;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += btnNumbers_Click;
            // 
            // btn10
            // 
            btn10.BackColor = Color.White;
            btn10.FlatAppearance.BorderSize = 0;
            btn10.FlatStyle = FlatStyle.Flat;
            btn10.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btn10.ForeColor = Color.FromArgb(66, 178, 38);
            btn10.ImageAlign = ContentAlignment.TopCenter;
            btn10.Location = new Point(221, 590);
            btn10.Name = "btn10";
            btn10.Size = new Size(42, 42);
            btn10.TabIndex = 81;
            btn10.Text = "10";
            btn10.UseVisualStyleBackColor = false;
            btn10.Click += btnNumbers_Click;
            // 
            // btn8
            // 
            btn8.BackColor = Color.White;
            btn8.FlatAppearance.BorderSize = 0;
            btn8.FlatStyle = FlatStyle.Flat;
            btn8.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btn8.ForeColor = Color.FromArgb(66, 178, 38);
            btn8.ImageAlign = ContentAlignment.TopCenter;
            btn8.Location = new Point(173, 590);
            btn8.Name = "btn8";
            btn8.Size = new Size(42, 42);
            btn8.TabIndex = 80;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += btnNumbers_Click;
            // 
            // btn50
            // 
            btn50.BackColor = Color.White;
            btn50.FlatAppearance.BorderSize = 0;
            btn50.FlatStyle = FlatStyle.Flat;
            btn50.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btn50.ForeColor = Color.FromArgb(66, 178, 38);
            btn50.ImageAlign = ContentAlignment.TopCenter;
            btn50.Location = new Point(221, 637);
            btn50.Name = "btn50";
            btn50.Size = new Size(42, 42);
            btn50.TabIndex = 85;
            btn50.Text = "50";
            btn50.UseVisualStyleBackColor = false;
            btn50.Click += btnNumbers_Click;
            // 
            // btn25
            // 
            btn25.BackColor = Color.White;
            btn25.FlatAppearance.BorderSize = 0;
            btn25.FlatStyle = FlatStyle.Flat;
            btn25.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btn25.ForeColor = Color.FromArgb(66, 178, 38);
            btn25.ImageAlign = ContentAlignment.TopCenter;
            btn25.Location = new Point(173, 637);
            btn25.Name = "btn25";
            btn25.Size = new Size(42, 42);
            btn25.TabIndex = 84;
            btn25.Text = "25";
            btn25.UseVisualStyleBackColor = false;
            btn25.Click += btnNumbers_Click;
            // 
            // btn20
            // 
            btn20.BackColor = Color.White;
            btn20.FlatAppearance.BorderSize = 0;
            btn20.FlatStyle = FlatStyle.Flat;
            btn20.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btn20.ForeColor = Color.FromArgb(66, 178, 38);
            btn20.ImageAlign = ContentAlignment.TopCenter;
            btn20.Location = new Point(125, 637);
            btn20.Name = "btn20";
            btn20.Size = new Size(42, 42);
            btn20.TabIndex = 83;
            btn20.Text = "20";
            btn20.UseVisualStyleBackColor = false;
            btn20.Click += btnNumbers_Click;
            // 
            // btn18
            // 
            btn18.BackColor = Color.White;
            btn18.FlatAppearance.BorderSize = 0;
            btn18.FlatStyle = FlatStyle.Flat;
            btn18.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btn18.ForeColor = Color.FromArgb(66, 178, 38);
            btn18.ImageAlign = ContentAlignment.TopCenter;
            btn18.Location = new Point(77, 637);
            btn18.Name = "btn18";
            btn18.Size = new Size(42, 42);
            btn18.TabIndex = 82;
            btn18.Text = "18";
            btn18.UseVisualStyleBackColor = false;
            btn18.Click += btnNumbers_Click;
            // 
            // btn90
            // 
            btn90.BackColor = Color.White;
            btn90.FlatAppearance.BorderSize = 0;
            btn90.FlatStyle = FlatStyle.Flat;
            btn90.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btn90.ForeColor = Color.FromArgb(66, 178, 38);
            btn90.ImageAlign = ContentAlignment.TopCenter;
            btn90.Location = new Point(317, 637);
            btn90.Name = "btn90";
            btn90.Size = new Size(42, 42);
            btn90.TabIndex = 90;
            btn90.Text = "90";
            btn90.UseVisualStyleBackColor = false;
            btn90.Click += btnNumbers_Click;
            // 
            // btn75
            // 
            btn75.BackColor = Color.White;
            btn75.FlatAppearance.BorderSize = 0;
            btn75.FlatStyle = FlatStyle.Flat;
            btn75.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btn75.ForeColor = Color.FromArgb(66, 178, 38);
            btn75.ImageAlign = ContentAlignment.TopCenter;
            btn75.Location = new Point(269, 637);
            btn75.Name = "btn75";
            btn75.Size = new Size(42, 42);
            btn75.TabIndex = 89;
            btn75.Text = "75";
            btn75.UseVisualStyleBackColor = false;
            btn75.Click += btnNumbers_Click;
            // 
            // btn15
            // 
            btn15.BackColor = Color.White;
            btn15.FlatAppearance.BorderSize = 0;
            btn15.FlatStyle = FlatStyle.Flat;
            btn15.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btn15.ForeColor = Color.FromArgb(66, 178, 38);
            btn15.ImageAlign = ContentAlignment.TopCenter;
            btn15.Location = new Point(317, 590);
            btn15.Name = "btn15";
            btn15.Size = new Size(42, 42);
            btn15.TabIndex = 87;
            btn15.Text = "15";
            btn15.UseVisualStyleBackColor = false;
            btn15.Click += btnNumbers_Click;
            // 
            // btn13
            // 
            btn13.BackColor = Color.White;
            btn13.FlatAppearance.BorderSize = 0;
            btn13.FlatStyle = FlatStyle.Flat;
            btn13.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btn13.ForeColor = Color.FromArgb(66, 178, 38);
            btn13.ImageAlign = ContentAlignment.TopCenter;
            btn13.Location = new Point(269, 590);
            btn13.Name = "btn13";
            btn13.Size = new Size(42, 42);
            btn13.TabIndex = 86;
            btn13.Text = "13";
            btn13.UseVisualStyleBackColor = false;
            btn13.Click += btnNumbers_Click;
            // 
            // SaleDiscount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.BackgroundSmall1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(768, 768);
            Controls.Add(btn90);
            Controls.Add(btn75);
            Controls.Add(btn15);
            Controls.Add(btn13);
            Controls.Add(btn50);
            Controls.Add(btn25);
            Controls.Add(btn20);
            Controls.Add(btn18);
            Controls.Add(btn10);
            Controls.Add(btn8);
            Controls.Add(btn5);
            Controls.Add(btn3);
            Controls.Add(tbPercentage);
            Controls.Add(panel1);
            Controls.Add(btnSave);
            Controls.Add(lblPageHeaderAddColor);
            Controls.Add(btnClose);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "SaleDiscount";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddCategory";
            Load += SaleDiscount_Load;
            Click += btnNumbers_Click;
            MouseDown += AddCategory_MouseDown;
            ((System.ComponentModel.ISupportInitialize)dgvMain).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomObjects.RoundButton btnClose;
        private Label lblPageHeaderAddColor;
        private Button btnSave;
        private DataGridView dgvMain;
        private Panel panel1;
        private TextBox tbPercentage;
        private Button btn3;
        private Button btn5;
        private Button btn10;
        private Button btn8;
        private Button btn50;
        private Button btn25;
        private Button btn20;
        private Button btn18;
        private Button btn90;
        private Button btn75;
        private Button btn15;
        private Button btn13;
        private Button btnSelectAll;
        private DataGridViewTextBoxColumn BARCODE;
        private DataGridViewCheckBoxColumn CHECK;
        private DataGridViewTextBoxColumn NAME;
        private DataGridViewTextBoxColumn OLDPRICE;
        private DataGridViewTextBoxColumn NEWPRICE;
    }
}