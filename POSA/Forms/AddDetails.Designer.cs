namespace POSA.Forms
{
    partial class AddDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddDetails));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            btnClose = new CustomObjects.RoundButton();
            lblPageHeaderAddDetails = new Label();
            btnSave = new Button();
            dgvMain = new DataGridView();
            panel1 = new Panel();
            pbClearSearch = new PictureBox();
            pictureBox3 = new PictureBox();
            rtbSearch = new CustomObjects.RoundTextBox();
            tbBrand = new TextBox();
            lblBrand = new Label();
            tbSerialNumber = new TextBox();
            lblSerialNumber = new Label();
            tbProductor = new TextBox();
            lblProductor = new Label();
            dtpExpire = new DateTimePicker();
            cbWarnExpire = new CheckBox();
            tbStockPlace = new TextBox();
            lblStockPlace = new Label();
            cbCurrency = new ComboBox();
            lblCurrency = new Label();
            lblExpireDate = new Label();
            lblBarcode = new Label();
            BARCODE = new DataGridViewTextBoxColumn();
            NAME = new DataGridViewTextBoxColumn();
            SERIALNUMBER = new DataGridViewTextBoxColumn();
            BRAND = new DataGridViewTextBoxColumn();
            EXPIREDATE = new DataGridViewTextBoxColumn();
            WARNEXPIREDATE = new DataGridViewTextBoxColumn();
            PRODUCTOR = new DataGridViewTextBoxColumn();
            STOCKPLACE = new DataGridViewTextBoxColumn();
            CURRENCY = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvMain).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbClearSearch).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
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
            btnClose.Location = new Point(743, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(28, 28);
            btnClose.TabIndex = 34;
            btnClose.TextColor = Color.White;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // lblPageHeaderAddDetails
            // 
            lblPageHeaderAddDetails.AutoSize = true;
            lblPageHeaderAddDetails.BackColor = Color.Transparent;
            lblPageHeaderAddDetails.Font = new Font("Segoe UI Semibold", 17F, FontStyle.Bold);
            lblPageHeaderAddDetails.ForeColor = Color.White;
            lblPageHeaderAddDetails.Location = new Point(12, 9);
            lblPageHeaderAddDetails.Name = "lblPageHeaderAddDetails";
            lblPageHeaderAddDetails.Size = new Size(135, 31);
            lblPageHeaderAddDetails.TabIndex = 43;
            lblPageHeaderAddDetails.Text = "DETAY EKLE";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.LightGreen;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSave.ForeColor = Color.Black;
            btnSave.ImageAlign = ContentAlignment.TopCenter;
            btnSave.Location = new Point(12, 307);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(384, 33);
            btnSave.TabIndex = 74;
            btnSave.Text = "KAYDET";
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
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 162);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(1, 39, 103);
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(1, 39, 103);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvMain.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvMain.ColumnHeadersHeight = 50;
            dgvMain.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvMain.Columns.AddRange(new DataGridViewColumn[] { BARCODE, NAME, SERIALNUMBER, BRAND, EXPIREDATE, WARNEXPIREDATE, PRODUCTOR, STOCKPLACE, CURRENCY });
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
            dgvMain.Location = new Point(10, 56);
            dgvMain.Margin = new Padding(10);
            dgvMain.MultiSelect = false;
            dgvMain.Name = "dgvMain";
            dgvMain.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvMain.RowHeadersVisible = false;
            dgvMain.RowHeadersWidth = 35;
            dgvMain.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvMain.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvMain.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(238, 245, 255);
            dgvMain.RowTemplate.DefaultCellStyle.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            dgvMain.RowTemplate.DefaultCellStyle.ForeColor = Color.FromArgb(1, 39, 103);
            dgvMain.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(109, 134, 176);
            dgvMain.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvMain.RowTemplate.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvMain.RowTemplate.DividerHeight = 10;
            dgvMain.RowTemplate.Height = 40;
            dgvMain.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMain.Size = new Size(349, 224);
            dgvMain.TabIndex = 75;
            dgvMain.CellDoubleClick += dgvMain_CellDoubleClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pbClearSearch);
            panel1.Controls.Add(dgvMain);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(rtbSearch);
            panel1.Location = new Point(402, 50);
            panel1.Name = "panel1";
            panel1.Size = new Size(369, 290);
            panel1.TabIndex = 76;
            // 
            // pbClearSearch
            // 
            pbClearSearch.BackColor = Color.White;
            pbClearSearch.BackgroundImage = Properties.Resources._16pxCloseBlack;
            pbClearSearch.BackgroundImageLayout = ImageLayout.Center;
            pbClearSearch.Location = new Point(259, 12);
            pbClearSearch.Name = "pbClearSearch";
            pbClearSearch.Size = new Size(26, 26);
            pbClearSearch.TabIndex = 87;
            pbClearSearch.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.White;
            pictureBox3.BackgroundImage = Properties.Resources._16pxSearch;
            pictureBox3.BackgroundImageLayout = ImageLayout.Center;
            pictureBox3.Location = new Point(15, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(26, 26);
            pictureBox3.TabIndex = 86;
            pictureBox3.TabStop = false;
            // 
            // rtbSearch
            // 
            rtbSearch.BackColor = SystemColors.Window;
            rtbSearch.BorderColor = Color.FromArgb(1, 39, 103);
            rtbSearch.BorderFocusColor = Color.FromArgb(1, 39, 103);
            rtbSearch.BorderRadius = 5;
            rtbSearch.BorderSize = 2;
            rtbSearch.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rtbSearch.ForeColor = Color.FromArgb(64, 64, 64);
            rtbSearch.Location = new Point(10, 8);
            rtbSearch.Margin = new Padding(4);
            rtbSearch.Multiline = false;
            rtbSearch.Name = "rtbSearch";
            rtbSearch.Padding = new Padding(35, 7, 30, 7);
            rtbSearch.PasswordChar = false;
            rtbSearch.PlaceholderColor = Color.DarkGray;
            rtbSearch.PlaceholderText = "Ara...";
            rtbSearch.Size = new Size(278, 34);
            rtbSearch.TabIndex = 88;
            rtbSearch.Texts = "";
            rtbSearch.UnderlinedStyle = false;
            rtbSearch.KeyDown += rtbSearch_KeyDown;
            // 
            // tbBrand
            // 
            tbBrand.BorderStyle = BorderStyle.None;
            tbBrand.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            tbBrand.Location = new Point(149, 78);
            tbBrand.Name = "tbBrand";
            tbBrand.Size = new Size(220, 24);
            tbBrand.TabIndex = 78;
            // 
            // lblBrand
            // 
            lblBrand.AutoSize = true;
            lblBrand.BackColor = Color.Transparent;
            lblBrand.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblBrand.ForeColor = Color.White;
            lblBrand.Location = new Point(12, 78);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new Size(66, 25);
            lblBrand.TabIndex = 77;
            lblBrand.Text = "Marka";
            // 
            // tbSerialNumber
            // 
            tbSerialNumber.BorderStyle = BorderStyle.None;
            tbSerialNumber.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            tbSerialNumber.Location = new Point(149, 108);
            tbSerialNumber.Name = "tbSerialNumber";
            tbSerialNumber.Size = new Size(220, 24);
            tbSerialNumber.TabIndex = 80;
            // 
            // lblSerialNumber
            // 
            lblSerialNumber.AutoSize = true;
            lblSerialNumber.BackColor = Color.Transparent;
            lblSerialNumber.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblSerialNumber.ForeColor = Color.White;
            lblSerialNumber.Location = new Point(12, 108);
            lblSerialNumber.Name = "lblSerialNumber";
            lblSerialNumber.Size = new Size(74, 25);
            lblSerialNumber.TabIndex = 79;
            lblSerialNumber.Text = "Seri No";
            // 
            // tbProductor
            // 
            tbProductor.BorderStyle = BorderStyle.None;
            tbProductor.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            tbProductor.Location = new Point(149, 138);
            tbProductor.Name = "tbProductor";
            tbProductor.Size = new Size(220, 24);
            tbProductor.TabIndex = 82;
            // 
            // lblProductor
            // 
            lblProductor.AutoSize = true;
            lblProductor.BackColor = Color.Transparent;
            lblProductor.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblProductor.ForeColor = Color.White;
            lblProductor.Location = new Point(12, 138);
            lblProductor.Name = "lblProductor";
            lblProductor.Size = new Size(68, 25);
            lblProductor.TabIndex = 81;
            lblProductor.Text = "Üretici";
            // 
            // dtpExpire
            // 
            dtpExpire.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            dtpExpire.Format = DateTimePickerFormat.Short;
            dtpExpire.Location = new Point(149, 168);
            dtpExpire.Name = "dtpExpire";
            dtpExpire.Size = new Size(144, 31);
            dtpExpire.TabIndex = 85;
            // 
            // cbWarnExpire
            // 
            cbWarnExpire.AutoSize = true;
            cbWarnExpire.BackColor = Color.Transparent;
            cbWarnExpire.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            cbWarnExpire.ForeColor = Color.White;
            cbWarnExpire.Location = new Point(149, 205);
            cbWarnExpire.Name = "cbWarnExpire";
            cbWarnExpire.Size = new Size(116, 29);
            cbWarnExpire.TabIndex = 86;
            cbWarnExpire.Text = "Tarih uyar";
            cbWarnExpire.UseVisualStyleBackColor = false;
            // 
            // tbStockPlace
            // 
            tbStockPlace.BorderStyle = BorderStyle.None;
            tbStockPlace.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            tbStockPlace.Location = new Point(149, 277);
            tbStockPlace.Name = "tbStockPlace";
            tbStockPlace.Size = new Size(220, 24);
            tbStockPlace.TabIndex = 90;
            // 
            // lblStockPlace
            // 
            lblStockPlace.AutoSize = true;
            lblStockPlace.BackColor = Color.Transparent;
            lblStockPlace.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblStockPlace.ForeColor = Color.White;
            lblStockPlace.Location = new Point(12, 277);
            lblStockPlace.Name = "lblStockPlace";
            lblStockPlace.Size = new Size(78, 25);
            lblStockPlace.TabIndex = 89;
            lblStockPlace.Text = "Raf yeri";
            // 
            // cbCurrency
            // 
            cbCurrency.BackColor = Color.White;
            cbCurrency.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCurrency.FlatStyle = FlatStyle.Flat;
            cbCurrency.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            cbCurrency.FormattingEnabled = true;
            cbCurrency.Items.AddRange(new object[] { "TL", "USD", "EURO" });
            cbCurrency.Location = new Point(149, 240);
            cbCurrency.Name = "cbCurrency";
            cbCurrency.Size = new Size(220, 31);
            cbCurrency.TabIndex = 88;
            // 
            // lblCurrency
            // 
            lblCurrency.AutoSize = true;
            lblCurrency.BackColor = Color.Transparent;
            lblCurrency.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblCurrency.ForeColor = Color.White;
            lblCurrency.Location = new Point(12, 246);
            lblCurrency.Name = "lblCurrency";
            lblCurrency.Size = new Size(105, 25);
            lblCurrency.TabIndex = 87;
            lblCurrency.Text = "Para Birimi";
            // 
            // lblExpireDate
            // 
            lblExpireDate.AutoSize = true;
            lblExpireDate.BackColor = Color.Transparent;
            lblExpireDate.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblExpireDate.ForeColor = Color.White;
            lblExpireDate.Location = new Point(12, 171);
            lblExpireDate.Name = "lblExpireDate";
            lblExpireDate.Size = new Size(134, 25);
            lblExpireDate.TabIndex = 91;
            lblExpireDate.Text = "Son Kul. Tarihi";
            // 
            // lblBarcode
            // 
            lblBarcode.AutoSize = true;
            lblBarcode.Location = new Point(369, 26);
            lblBarcode.Name = "lblBarcode";
            lblBarcode.Size = new Size(0, 15);
            lblBarcode.TabIndex = 92;
            lblBarcode.Visible = false;
            // 
            // BARCODE
            // 
            BARCODE.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            BARCODE.DataPropertyName = "BARCODE";
            BARCODE.FillWeight = 50F;
            BARCODE.HeaderText = "BARKOD";
            BARCODE.MaxInputLength = 100;
            BARCODE.Name = "BARCODE";
            BARCODE.ReadOnly = true;
            // 
            // NAME
            // 
            NAME.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NAME.DataPropertyName = "NAME";
            NAME.FillWeight = 50F;
            NAME.HeaderText = "ÜRÜN ADI";
            NAME.MaxInputLength = 50;
            NAME.Name = "NAME";
            NAME.ReadOnly = true;
            // 
            // SERIALNUMBER
            // 
            SERIALNUMBER.DataPropertyName = "SERIALNUMBER";
            SERIALNUMBER.HeaderText = "SERIALNUMBER";
            SERIALNUMBER.Name = "SERIALNUMBER";
            SERIALNUMBER.Visible = false;
            // 
            // BRAND
            // 
            BRAND.DataPropertyName = "BRAND";
            BRAND.HeaderText = "BRAND";
            BRAND.Name = "BRAND";
            BRAND.Visible = false;
            // 
            // EXPIREDATE
            // 
            EXPIREDATE.DataPropertyName = "EXPIREDATE";
            EXPIREDATE.HeaderText = "EXPIREDATE";
            EXPIREDATE.Name = "EXPIREDATE";
            EXPIREDATE.Visible = false;
            // 
            // WARNEXPIREDATE
            // 
            WARNEXPIREDATE.DataPropertyName = "WARNEXPIREDATE";
            WARNEXPIREDATE.HeaderText = "WARNEXPIREDATE";
            WARNEXPIREDATE.Name = "WARNEXPIREDATE";
            WARNEXPIREDATE.Visible = false;
            // 
            // PRODUCTOR
            // 
            PRODUCTOR.DataPropertyName = "PRODUCTOR";
            PRODUCTOR.HeaderText = "PRODUCTOR";
            PRODUCTOR.Name = "PRODUCTOR";
            PRODUCTOR.Visible = false;
            // 
            // STOCKPLACE
            // 
            STOCKPLACE.DataPropertyName = "STOCKPLACE";
            STOCKPLACE.HeaderText = "STOCKPLACE";
            STOCKPLACE.Name = "STOCKPLACE";
            STOCKPLACE.Visible = false;
            // 
            // CURRENCY
            // 
            CURRENCY.DataPropertyName = "CURRENCY";
            CURRENCY.HeaderText = "CURRENCY";
            CURRENCY.Name = "CURRENCY";
            CURRENCY.Visible = false;
            // 
            // AddDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.BackgroundSmall1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(788, 356);
            Controls.Add(lblBarcode);
            Controls.Add(lblExpireDate);
            Controls.Add(tbStockPlace);
            Controls.Add(lblStockPlace);
            Controls.Add(cbCurrency);
            Controls.Add(lblCurrency);
            Controls.Add(cbWarnExpire);
            Controls.Add(dtpExpire);
            Controls.Add(tbProductor);
            Controls.Add(lblProductor);
            Controls.Add(tbSerialNumber);
            Controls.Add(lblSerialNumber);
            Controls.Add(tbBrand);
            Controls.Add(lblBrand);
            Controls.Add(panel1);
            Controls.Add(btnSave);
            Controls.Add(lblPageHeaderAddDetails);
            Controls.Add(btnClose);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddDetails";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddCategory";
            Load += AddCategory_Load;
            MouseDown += AddCategory_MouseDown;
            ((System.ComponentModel.ISupportInitialize)dgvMain).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbClearSearch).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomObjects.RoundButton btnClose;
        private Label lblPageHeaderAddDetails;
        private Button btnSave;
        private DataGridView dgvMain;
        private Panel panel1;
        private PictureBox pbClearSearch;
        private PictureBox pictureBox3;
        private CustomObjects.RoundTextBox rtbSearch;
        private TextBox tbBrand;
        private Label lblBrand;
        private TextBox tbSerialNumber;
        private Label lblSerialNumber;
        private TextBox tbProductor;
        private Label lblProductor;
        private DateTimePicker dtpExpire;
        private CheckBox cbWarnExpire;
        private TextBox tbStockPlace;
        private Label lblStockPlace;
        private ComboBox cbCurrency;
        private Label lblCurrency;
        private Label lblExpireDate;
        private Label lblBarcode;
        private DataGridViewTextBoxColumn BARCODE;
        private DataGridViewTextBoxColumn NAME;
        private DataGridViewTextBoxColumn SERIALNUMBER;
        private DataGridViewTextBoxColumn BRAND;
        private DataGridViewTextBoxColumn EXPIREDATE;
        private DataGridViewTextBoxColumn WARNEXPIREDATE;
        private DataGridViewTextBoxColumn PRODUCTOR;
        private DataGridViewTextBoxColumn STOCKPLACE;
        private DataGridViewTextBoxColumn CURRENCY;
    }
}