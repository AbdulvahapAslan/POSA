namespace POSA.Forms
{
    partial class PayPartite
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PayPartite));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            btnClose = new CustomObjects.RoundButton();
            lblPageHeaderPayPartite = new Label();
            pnlShadow = new Panel();
            fcPaymentType = new CustomObjects.FlatCombo();
            tbCash = new TextBox();
            btnCancel = new Button();
            btnSave = new Button();
            btnMinimize = new Button();
            tbRemainingHeaderText = new TextBox();
            tbRemainingPrice = new TextBox();
            tbPrice = new TextBox();
            tbPriceHeader = new TextBox();
            pnlGrid = new Panel();
            dgvMain = new DataGridView();
            lblFicheList = new Label();
            Barcode = new DataGridViewTextBoxColumn();
            ProductName = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            TotalQuantity = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            pnlShadow.SuspendLayout();
            pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMain).BeginInit();
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
            btnClose.Location = new Point(1155, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(28, 28);
            btnClose.TabIndex = 34;
            btnClose.TextColor = Color.White;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // lblPageHeaderPayPartite
            // 
            lblPageHeaderPayPartite.AutoSize = true;
            lblPageHeaderPayPartite.BackColor = Color.Transparent;
            lblPageHeaderPayPartite.Font = new Font("Segoe UI Semibold", 17F, FontStyle.Bold);
            lblPageHeaderPayPartite.ForeColor = Color.White;
            lblPageHeaderPayPartite.Location = new Point(12, 9);
            lblPageHeaderPayPartite.Name = "lblPageHeaderPayPartite";
            lblPageHeaderPayPartite.Size = new Size(186, 31);
            lblPageHeaderPayPartite.TabIndex = 43;
            lblPageHeaderPayPartite.Text = "PARÇALI ÖDEME";
            // 
            // pnlShadow
            // 
            pnlShadow.BackColor = Color.FromArgb(3, 73, 169);
            pnlShadow.Controls.Add(pnlGrid);
            pnlShadow.Controls.Add(tbPrice);
            pnlShadow.Controls.Add(tbPriceHeader);
            pnlShadow.Controls.Add(tbRemainingPrice);
            pnlShadow.Controls.Add(tbRemainingHeaderText);
            pnlShadow.Controls.Add(fcPaymentType);
            pnlShadow.Controls.Add(tbCash);
            pnlShadow.Controls.Add(btnCancel);
            pnlShadow.Controls.Add(btnSave);
            pnlShadow.Location = new Point(59, 129);
            pnlShadow.Margin = new Padding(50, 41, 50, 41);
            pnlShadow.Name = "pnlShadow";
            pnlShadow.Size = new Size(1082, 338);
            pnlShadow.TabIndex = 44;
            // 
            // fcPaymentType
            // 
            fcPaymentType.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            fcPaymentType.BackColor = Color.Black;
            fcPaymentType.BorderColor = Color.Black;
            fcPaymentType.ButtonColor = Color.Black;
            fcPaymentType.DrawMode = DrawMode.OwnerDrawFixed;
            fcPaymentType.DropDownStyle = ComboBoxStyle.DropDownList;
            fcPaymentType.Font = new Font("Segoe UI", 24.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            fcPaymentType.ForeColor = Color.White;
            fcPaymentType.FormattingEnabled = true;
            fcPaymentType.HighlightColor = Color.Black;
            fcPaymentType.Items.AddRange(new object[] { "NAKİT", "KART", "DİĞER" });
            fcPaymentType.Location = new Point(874, 124);
            fcPaymentType.Margin = new Padding(1);
            fcPaymentType.Name = "fcPaymentType";
            fcPaymentType.Size = new Size(198, 52);
            fcPaymentType.TabIndex = 81;
            // 
            // tbCash
            // 
            tbCash.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            tbCash.BackColor = Color.Black;
            tbCash.BorderStyle = BorderStyle.None;
            tbCash.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            tbCash.ForeColor = Color.White;
            tbCash.Location = new Point(874, 104);
            tbCash.Margin = new Padding(1);
            tbCash.Name = "tbCash";
            tbCash.ReadOnly = true;
            tbCash.Size = new Size(198, 18);
            tbCash.TabIndex = 80;
            tbCash.Text = "ÖDEME TÜRÜ";
            tbCash.TextAlign = HorizontalAlignment.Center;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.BackColor = Color.FromArgb(255, 59, 59);
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            btnCancel.ForeColor = Color.White;
            btnCancel.Image = Properties.Resources._64pxWhiteX50Scale1;
            btnCancel.ImageAlign = ContentAlignment.TopCenter;
            btnCancel.Location = new Point(874, 190);
            btnCancel.Margin = new Padding(10);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(96, 138);
            btnCancel.TabIndex = 75;
            btnCancel.Text = "  İPTAL      ";
            btnCancel.TextAlign = ContentAlignment.BottomCenter;
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.BackColor = Color.FromArgb(66, 178, 38);
            btnSave.DialogResult = DialogResult.OK;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Image = Properties.Resources._64pxGreenCheck;
            btnSave.ImageAlign = ContentAlignment.TopCenter;
            btnSave.Location = new Point(976, 190);
            btnSave.Margin = new Padding(10);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(96, 138);
            btnSave.TabIndex = 74;
            btnSave.Text = "KAYDET      ";
            btnSave.TextAlign = ContentAlignment.BottomCenter;
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
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
            btnMinimize.Location = new Point(1121, 12);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(28, 28);
            btnMinimize.TabIndex = 45;
            btnMinimize.UseVisualStyleBackColor = false;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // tbRemainingHeaderText
            // 
            tbRemainingHeaderText.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            tbRemainingHeaderText.BackColor = Color.FromArgb(237, 28, 36);
            tbRemainingHeaderText.BorderStyle = BorderStyle.None;
            tbRemainingHeaderText.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            tbRemainingHeaderText.ForeColor = Color.White;
            tbRemainingHeaderText.Location = new Point(874, 11);
            tbRemainingHeaderText.Margin = new Padding(1);
            tbRemainingHeaderText.Name = "tbRemainingHeaderText";
            tbRemainingHeaderText.ReadOnly = true;
            tbRemainingHeaderText.Size = new Size(198, 22);
            tbRemainingHeaderText.TabIndex = 82;
            tbRemainingHeaderText.Text = "KALAN TUTAR";
            tbRemainingHeaderText.TextAlign = HorizontalAlignment.Center;
            // 
            // tbRemainingPrice
            // 
            tbRemainingPrice.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            tbRemainingPrice.BackColor = Color.FromArgb(237, 28, 36);
            tbRemainingPrice.BorderStyle = BorderStyle.None;
            tbRemainingPrice.Font = new Font("Segoe UI Semibold", 35F, FontStyle.Bold);
            tbRemainingPrice.ForeColor = Color.White;
            tbRemainingPrice.Location = new Point(874, 35);
            tbRemainingPrice.Margin = new Padding(1, 1, 1, 5);
            tbRemainingPrice.Name = "tbRemainingPrice";
            tbRemainingPrice.Size = new Size(198, 63);
            tbRemainingPrice.TabIndex = 83;
            tbRemainingPrice.TextAlign = HorizontalAlignment.Center;
            // 
            // tbPrice
            // 
            tbPrice.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            tbPrice.BackColor = Color.FromArgb(66, 178, 38);
            tbPrice.BorderStyle = BorderStyle.None;
            tbPrice.Font = new Font("Segoe UI Semibold", 35F, FontStyle.Bold);
            tbPrice.ForeColor = Color.White;
            tbPrice.Location = new Point(660, 35);
            tbPrice.Margin = new Padding(15, 1, 15, 15);
            tbPrice.Name = "tbPrice";
            tbPrice.Size = new Size(198, 63);
            tbPrice.TabIndex = 85;
            tbPrice.TextAlign = HorizontalAlignment.Center;
            // 
            // tbPriceHeader
            // 
            tbPriceHeader.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            tbPriceHeader.BackColor = Color.FromArgb(66, 178, 38);
            tbPriceHeader.BorderStyle = BorderStyle.None;
            tbPriceHeader.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            tbPriceHeader.ForeColor = Color.White;
            tbPriceHeader.Location = new Point(660, 11);
            tbPriceHeader.Margin = new Padding(1);
            tbPriceHeader.Name = "tbPriceHeader";
            tbPriceHeader.ReadOnly = true;
            tbPriceHeader.Size = new Size(198, 22);
            tbPriceHeader.TabIndex = 84;
            tbPriceHeader.Text = "ÖDENECEK TUTAR";
            tbPriceHeader.TextAlign = HorizontalAlignment.Center;
            // 
            // pnlGrid
            // 
            pnlGrid.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pnlGrid.BackColor = Color.White;
            pnlGrid.Controls.Add(lblFicheList);
            pnlGrid.Controls.Add(dgvMain);
            pnlGrid.Location = new Point(15, 11);
            pnlGrid.Margin = new Padding(15, 3, 3, 3);
            pnlGrid.Name = "pnlGrid";
            pnlGrid.Size = new Size(627, 317);
            pnlGrid.TabIndex = 86;
            // 
            // dgvMain
            // 
            dgvMain.AllowUserToAddRows = false;
            dgvMain.AllowUserToDeleteRows = false;
            dgvMain.AllowUserToResizeColumns = false;
            dgvMain.AllowUserToResizeRows = false;
            dgvMain.BackgroundColor = Color.White;
            dgvMain.BorderStyle = BorderStyle.None;
            dgvMain.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvMain.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(1, 39, 103);
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(1, 39, 103);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvMain.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvMain.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMain.Columns.AddRange(new DataGridViewColumn[] { Barcode, ProductName, Price, TotalQuantity, Quantity, Total });
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.White;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 162);
            dataGridViewCellStyle7.ForeColor = Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.InactiveCaption;
            dataGridViewCellStyle7.SelectionForeColor = Color.Black;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            dgvMain.DefaultCellStyle = dataGridViewCellStyle7;
            dgvMain.EnableHeadersVisualStyles = false;
            dgvMain.GridColor = Color.White;
            dgvMain.Location = new Point(7, 36);
            dgvMain.Margin = new Padding(7);
            dgvMain.Name = "dgvMain";
            dgvMain.RowHeadersVisible = false;
            dgvMain.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(210, 226, 252);
            dgvMain.RowTemplate.DefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvMain.RowTemplate.DefaultCellStyle.ForeColor = Color.FromArgb(1, 39, 103);
            dgvMain.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(210, 226, 252);
            dgvMain.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.FromArgb(1, 39, 103);
            dgvMain.RowTemplate.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvMain.RowTemplate.DividerHeight = 10;
            dgvMain.RowTemplate.Height = 40;
            dgvMain.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMain.Size = new Size(613, 274);
            dgvMain.TabIndex = 91;
            // 
            // lblFicheList
            // 
            lblFicheList.AutoSize = true;
            lblFicheList.BackColor = Color.Transparent;
            lblFicheList.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            lblFicheList.ForeColor = Color.Black;
            lblFicheList.Location = new Point(289, 8);
            lblFicheList.Name = "lblFicheList";
            lblFicheList.Size = new Size(104, 25);
            lblFicheList.TabIndex = 46;
            lblFicheList.Text = "FİŞ LİSTESİ";
            // 
            // Barcode
            // 
            Barcode.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Barcode.DefaultCellStyle = dataGridViewCellStyle2;
            Barcode.FillWeight = 18F;
            Barcode.HeaderText = "BARKOD";
            Barcode.Name = "Barcode";
            Barcode.ReadOnly = true;
            Barcode.Visible = false;
            // 
            // ProductName
            // 
            ProductName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ProductName.DefaultCellStyle = dataGridViewCellStyle3;
            ProductName.FillWeight = 24F;
            ProductName.HeaderText = "ÜRÜN ADI";
            ProductName.Name = "ProductName";
            ProductName.ReadOnly = true;
            // 
            // Price
            // 
            Price.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Price.DefaultCellStyle = dataGridViewCellStyle4;
            Price.FillWeight = 14F;
            Price.HeaderText = "FİYAT";
            Price.Name = "Price";
            Price.ReadOnly = true;
            // 
            // TotalQuantity
            // 
            TotalQuantity.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            TotalQuantity.DefaultCellStyle = dataGridViewCellStyle5;
            TotalQuantity.FillWeight = 11F;
            TotalQuantity.HeaderText = "FİŞ ADEDİ";
            TotalQuantity.Name = "TotalQuantity";
            TotalQuantity.ReadOnly = true;
            // 
            // Quantity
            // 
            Quantity.HeaderText = "ALINAN ADET";
            Quantity.Name = "Quantity";
            // 
            // Total
            // 
            Total.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Total.DefaultCellStyle = dataGridViewCellStyle6;
            Total.FillWeight = 20F;
            Total.HeaderText = "TOPLAM";
            Total.Name = "Total";
            Total.ReadOnly = true;
            // 
            // PayPartite
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.BackgroundSmall1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1200, 600);
            Controls.Add(btnMinimize);
            Controls.Add(pnlShadow);
            Controls.Add(lblPageHeaderPayPartite);
            Controls.Add(btnClose);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "PayPartite";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddCategory";
            Load += PayPartite_Load;
            MouseDown += ProductDetails_MouseDown;
            pnlShadow.ResumeLayout(false);
            pnlShadow.PerformLayout();
            pnlGrid.ResumeLayout(false);
            pnlGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMain).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomObjects.RoundButton btnClose;
        private Label lblPageHeaderPayPartite;
        private Panel pnlShadow;
        private Button btnMinimize;
        private Button btnSave;
        private Button btnCancel;
        private TextBox tbCash;
        private CustomObjects.FlatCombo fcPaymentType;
        private TextBox tbRemainingHeaderText;
        private TextBox tbRemainingPrice;
        private TextBox tbPrice;
        private TextBox tbPriceHeader;
        private Panel pnlGrid;
        private Label lblFicheList;
        private DataGridView dgvMain;
        private DataGridViewTextBoxColumn Barcode;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn TotalQuantity;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Total;
    }
}