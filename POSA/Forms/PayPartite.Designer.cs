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
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            btnClose = new CustomObjects.RoundButton();
            lblPageHeaderPayPartite = new Label();
            pnlShadow = new Panel();
            btnBackspace = new CustomObjects.RoundButton();
            btnZero = new CustomObjects.RoundButton();
            btnDot = new CustomObjects.RoundButton();
            btnThree = new CustomObjects.RoundButton();
            btnTwo = new CustomObjects.RoundButton();
            btnOne = new CustomObjects.RoundButton();
            btnSix = new CustomObjects.RoundButton();
            btnFive = new CustomObjects.RoundButton();
            btnFour = new CustomObjects.RoundButton();
            btnNine = new CustomObjects.RoundButton();
            btnEight = new CustomObjects.RoundButton();
            btnSeven = new CustomObjects.RoundButton();
            pnlGrid = new Panel();
            lblFicheList = new Label();
            dgvMain = new DataGridView();
            BARCODE = new DataGridViewTextBoxColumn();
            NAME = new DataGridViewTextBoxColumn();
            PRICE = new DataGridViewTextBoxColumn();
            TOTALQUANTITY = new DataGridViewTextBoxColumn();
            QUANTITY = new DataGridViewTextBoxColumn();
            TOTAL = new DataGridViewTextBoxColumn();
            tbPrice = new TextBox();
            tbPriceHeader = new TextBox();
            tbRemainingPrice = new TextBox();
            tbRemainingHeaderText = new TextBox();
            fcPaymentType = new CustomObjects.FlatCombo();
            tbPaymentTypeHeader = new TextBox();
            btnCancel = new Button();
            btnSave = new Button();
            btnMinimize = new Button();
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
            pnlShadow.Controls.Add(btnBackspace);
            pnlShadow.Controls.Add(btnZero);
            pnlShadow.Controls.Add(btnDot);
            pnlShadow.Controls.Add(btnThree);
            pnlShadow.Controls.Add(btnTwo);
            pnlShadow.Controls.Add(btnOne);
            pnlShadow.Controls.Add(btnSix);
            pnlShadow.Controls.Add(btnFive);
            pnlShadow.Controls.Add(btnFour);
            pnlShadow.Controls.Add(btnNine);
            pnlShadow.Controls.Add(btnEight);
            pnlShadow.Controls.Add(btnSeven);
            pnlShadow.Controls.Add(pnlGrid);
            pnlShadow.Controls.Add(tbPrice);
            pnlShadow.Controls.Add(tbPriceHeader);
            pnlShadow.Controls.Add(tbRemainingPrice);
            pnlShadow.Controls.Add(tbRemainingHeaderText);
            pnlShadow.Controls.Add(fcPaymentType);
            pnlShadow.Controls.Add(tbPaymentTypeHeader);
            pnlShadow.Controls.Add(btnCancel);
            pnlShadow.Controls.Add(btnSave);
            pnlShadow.Location = new Point(60, 129);
            pnlShadow.Margin = new Padding(50, 41, 50, 41);
            pnlShadow.Name = "pnlShadow";
            pnlShadow.Size = new Size(1082, 338);
            pnlShadow.TabIndex = 44;
            // 
            // btnBackspace
            // 
            btnBackspace.BackColor = Color.White;
            btnBackspace.BackgroundColor = Color.White;
            btnBackspace.BorderColor = Color.PaleVioletRed;
            btnBackspace.BorderRadius = 3;
            btnBackspace.BorderSize = 0;
            btnBackspace.FlatAppearance.BorderSize = 0;
            btnBackspace.FlatStyle = FlatStyle.Flat;
            btnBackspace.Font = new Font("MS Reference Sans Serif", 20F);
            btnBackspace.ForeColor = Color.FromArgb(2, 69, 171);
            btnBackspace.Image = Properties.Resources._32pxBackSpace;
            btnBackspace.Location = new Point(836, 278);
            btnBackspace.Name = "btnBackspace";
            btnBackspace.Size = new Size(51, 51);
            btnBackspace.TabIndex = 99;
            btnBackspace.TextColor = Color.FromArgb(2, 69, 171);
            btnBackspace.UseVisualStyleBackColor = false;
            btnBackspace.Click += btnBackspace_Click;
            // 
            // btnZero
            // 
            btnZero.BackColor = Color.White;
            btnZero.BackgroundColor = Color.White;
            btnZero.BorderColor = Color.PaleVioletRed;
            btnZero.BorderRadius = 3;
            btnZero.BorderSize = 0;
            btnZero.FlatAppearance.BorderSize = 0;
            btnZero.FlatStyle = FlatStyle.Flat;
            btnZero.Font = new Font("MS Reference Sans Serif", 20F);
            btnZero.ForeColor = Color.FromArgb(2, 69, 171);
            btnZero.Location = new Point(775, 278);
            btnZero.Name = "btnZero";
            btnZero.Size = new Size(51, 51);
            btnZero.TabIndex = 98;
            btnZero.Text = "0";
            btnZero.TextColor = Color.FromArgb(2, 69, 171);
            btnZero.UseVisualStyleBackColor = false;
            btnZero.Click += btnGeneralNumber_Click;
            // 
            // btnDot
            // 
            btnDot.BackColor = Color.White;
            btnDot.BackgroundColor = Color.White;
            btnDot.BorderColor = Color.PaleVioletRed;
            btnDot.BorderRadius = 3;
            btnDot.BorderSize = 0;
            btnDot.FlatAppearance.BorderSize = 0;
            btnDot.FlatStyle = FlatStyle.Flat;
            btnDot.Font = new Font("MS Reference Sans Serif", 20F);
            btnDot.ForeColor = Color.FromArgb(2, 69, 171);
            btnDot.Location = new Point(714, 278);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(51, 51);
            btnDot.TabIndex = 97;
            btnDot.Text = ".";
            btnDot.TextColor = Color.FromArgb(2, 69, 171);
            btnDot.UseVisualStyleBackColor = false;
            btnDot.Click += btnGeneralNumber_Click;
            // 
            // btnThree
            // 
            btnThree.BackColor = Color.White;
            btnThree.BackgroundColor = Color.White;
            btnThree.BorderColor = Color.PaleVioletRed;
            btnThree.BorderRadius = 3;
            btnThree.BorderSize = 0;
            btnThree.FlatAppearance.BorderSize = 0;
            btnThree.FlatStyle = FlatStyle.Flat;
            btnThree.Font = new Font("MS Reference Sans Serif", 20F);
            btnThree.ForeColor = Color.FromArgb(2, 69, 171);
            btnThree.Location = new Point(836, 221);
            btnThree.Name = "btnThree";
            btnThree.Size = new Size(51, 51);
            btnThree.TabIndex = 96;
            btnThree.Text = "3";
            btnThree.TextColor = Color.FromArgb(2, 69, 171);
            btnThree.UseVisualStyleBackColor = false;
            btnThree.Click += btnGeneralNumber_Click;
            // 
            // btnTwo
            // 
            btnTwo.BackColor = Color.White;
            btnTwo.BackgroundColor = Color.White;
            btnTwo.BorderColor = Color.PaleVioletRed;
            btnTwo.BorderRadius = 3;
            btnTwo.BorderSize = 0;
            btnTwo.FlatAppearance.BorderSize = 0;
            btnTwo.FlatStyle = FlatStyle.Flat;
            btnTwo.Font = new Font("MS Reference Sans Serif", 20F);
            btnTwo.ForeColor = Color.FromArgb(2, 69, 171);
            btnTwo.Location = new Point(773, 221);
            btnTwo.Name = "btnTwo";
            btnTwo.Size = new Size(51, 51);
            btnTwo.TabIndex = 95;
            btnTwo.Text = "2";
            btnTwo.TextColor = Color.FromArgb(2, 69, 171);
            btnTwo.UseVisualStyleBackColor = false;
            btnTwo.Click += btnGeneralNumber_Click;
            // 
            // btnOne
            // 
            btnOne.BackColor = Color.White;
            btnOne.BackgroundColor = Color.White;
            btnOne.BorderColor = Color.PaleVioletRed;
            btnOne.BorderRadius = 3;
            btnOne.BorderSize = 0;
            btnOne.FlatAppearance.BorderSize = 0;
            btnOne.FlatStyle = FlatStyle.Flat;
            btnOne.Font = new Font("MS Reference Sans Serif", 20F);
            btnOne.ForeColor = Color.FromArgb(2, 69, 171);
            btnOne.Location = new Point(712, 221);
            btnOne.Name = "btnOne";
            btnOne.Size = new Size(51, 51);
            btnOne.TabIndex = 94;
            btnOne.Text = "1";
            btnOne.TextColor = Color.FromArgb(2, 69, 171);
            btnOne.UseVisualStyleBackColor = false;
            btnOne.Click += btnGeneralNumber_Click;
            // 
            // btnSix
            // 
            btnSix.BackColor = Color.White;
            btnSix.BackgroundColor = Color.White;
            btnSix.BorderColor = Color.PaleVioletRed;
            btnSix.BorderRadius = 3;
            btnSix.BorderSize = 0;
            btnSix.FlatAppearance.BorderSize = 0;
            btnSix.FlatStyle = FlatStyle.Flat;
            btnSix.Font = new Font("MS Reference Sans Serif", 20F);
            btnSix.ForeColor = Color.FromArgb(2, 69, 171);
            btnSix.Location = new Point(835, 164);
            btnSix.Name = "btnSix";
            btnSix.Size = new Size(51, 51);
            btnSix.TabIndex = 93;
            btnSix.Text = "6";
            btnSix.TextColor = Color.FromArgb(2, 69, 171);
            btnSix.UseVisualStyleBackColor = false;
            btnSix.Click += btnGeneralNumber_Click;
            // 
            // btnFive
            // 
            btnFive.BackColor = Color.White;
            btnFive.BackgroundColor = Color.White;
            btnFive.BorderColor = Color.PaleVioletRed;
            btnFive.BorderRadius = 3;
            btnFive.BorderSize = 0;
            btnFive.FlatAppearance.BorderSize = 0;
            btnFive.FlatStyle = FlatStyle.Flat;
            btnFive.Font = new Font("MS Reference Sans Serif", 20F);
            btnFive.ForeColor = Color.FromArgb(2, 69, 171);
            btnFive.Location = new Point(772, 164);
            btnFive.Name = "btnFive";
            btnFive.Size = new Size(51, 51);
            btnFive.TabIndex = 92;
            btnFive.Text = "5";
            btnFive.TextColor = Color.FromArgb(2, 69, 171);
            btnFive.UseVisualStyleBackColor = false;
            btnFive.Click += btnGeneralNumber_Click;
            // 
            // btnFour
            // 
            btnFour.BackColor = Color.White;
            btnFour.BackgroundColor = Color.White;
            btnFour.BorderColor = Color.PaleVioletRed;
            btnFour.BorderRadius = 3;
            btnFour.BorderSize = 0;
            btnFour.FlatAppearance.BorderSize = 0;
            btnFour.FlatStyle = FlatStyle.Flat;
            btnFour.Font = new Font("MS Reference Sans Serif", 20F);
            btnFour.ForeColor = Color.FromArgb(2, 69, 171);
            btnFour.Location = new Point(711, 164);
            btnFour.Name = "btnFour";
            btnFour.Size = new Size(51, 51);
            btnFour.TabIndex = 91;
            btnFour.Text = "4";
            btnFour.TextColor = Color.FromArgb(2, 69, 171);
            btnFour.UseVisualStyleBackColor = false;
            btnFour.Click += btnGeneralNumber_Click;
            // 
            // btnNine
            // 
            btnNine.BackColor = Color.White;
            btnNine.BackgroundColor = Color.White;
            btnNine.BorderColor = Color.PaleVioletRed;
            btnNine.BorderRadius = 3;
            btnNine.BorderSize = 0;
            btnNine.FlatAppearance.BorderSize = 0;
            btnNine.FlatStyle = FlatStyle.Flat;
            btnNine.Font = new Font("MS Reference Sans Serif", 20F);
            btnNine.ForeColor = Color.FromArgb(2, 69, 171);
            btnNine.Location = new Point(833, 107);
            btnNine.Name = "btnNine";
            btnNine.Size = new Size(51, 51);
            btnNine.TabIndex = 90;
            btnNine.Text = "9";
            btnNine.TextColor = Color.FromArgb(2, 69, 171);
            btnNine.UseVisualStyleBackColor = false;
            btnNine.Click += btnGeneralNumber_Click;
            // 
            // btnEight
            // 
            btnEight.BackColor = Color.White;
            btnEight.BackgroundColor = Color.White;
            btnEight.BorderColor = Color.PaleVioletRed;
            btnEight.BorderRadius = 3;
            btnEight.BorderSize = 0;
            btnEight.FlatAppearance.BorderSize = 0;
            btnEight.FlatStyle = FlatStyle.Flat;
            btnEight.Font = new Font("MS Reference Sans Serif", 20F);
            btnEight.ForeColor = Color.FromArgb(2, 69, 171);
            btnEight.Location = new Point(772, 107);
            btnEight.Name = "btnEight";
            btnEight.Size = new Size(51, 51);
            btnEight.TabIndex = 89;
            btnEight.Text = "8";
            btnEight.TextColor = Color.FromArgb(2, 69, 171);
            btnEight.UseVisualStyleBackColor = false;
            btnEight.Click += btnGeneralNumber_Click;
            // 
            // btnSeven
            // 
            btnSeven.BackColor = Color.White;
            btnSeven.BackgroundColor = Color.White;
            btnSeven.BorderColor = Color.PaleVioletRed;
            btnSeven.BorderRadius = 3;
            btnSeven.BorderSize = 0;
            btnSeven.FlatAppearance.BorderSize = 0;
            btnSeven.FlatStyle = FlatStyle.Flat;
            btnSeven.Font = new Font("MS Reference Sans Serif", 20F);
            btnSeven.ForeColor = Color.FromArgb(2, 69, 171);
            btnSeven.Location = new Point(711, 107);
            btnSeven.Name = "btnSeven";
            btnSeven.Size = new Size(51, 51);
            btnSeven.TabIndex = 88;
            btnSeven.Text = "7";
            btnSeven.TextColor = Color.FromArgb(2, 69, 171);
            btnSeven.UseVisualStyleBackColor = false;
            btnSeven.Click += btnGeneralNumber_Click;
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
            pnlGrid.Size = new Size(679, 317);
            pnlGrid.TabIndex = 86;
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
            // dgvMain
            // 
            dgvMain.AllowUserToAddRows = false;
            dgvMain.AllowUserToDeleteRows = false;
            dgvMain.AllowUserToResizeColumns = false;
            dgvMain.AllowUserToResizeRows = false;
            dgvMain.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
            dgvMain.Columns.AddRange(new DataGridViewColumn[] { BARCODE, NAME, PRICE, TOTALQUANTITY, QUANTITY, TOTAL });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.White;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 162);
            dataGridViewCellStyle8.ForeColor = Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.InactiveCaption;
            dataGridViewCellStyle8.SelectionForeColor = Color.Black;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dgvMain.DefaultCellStyle = dataGridViewCellStyle8;
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
            dgvMain.Size = new Size(665, 274);
            dgvMain.TabIndex = 91;
            dgvMain.CellClick += dgvMain_CellClick;
            dgvMain.CellDoubleClick += dgvMain_CellDoubleClick;
            // 
            // BARCODE
            // 
            BARCODE.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            BARCODE.DefaultCellStyle = dataGridViewCellStyle2;
            BARCODE.FillWeight = 18F;
            BARCODE.HeaderText = "BARKOD";
            BARCODE.Name = "BARCODE";
            BARCODE.ReadOnly = true;
            BARCODE.Visible = false;
            // 
            // NAME
            // 
            NAME.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            NAME.DefaultCellStyle = dataGridViewCellStyle3;
            NAME.FillWeight = 35F;
            NAME.HeaderText = "ÜRÜN ADI";
            NAME.Name = "NAME";
            NAME.ReadOnly = true;
            // 
            // PRICE
            // 
            PRICE.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            PRICE.DefaultCellStyle = dataGridViewCellStyle4;
            PRICE.FillWeight = 15F;
            PRICE.HeaderText = "FİYAT";
            PRICE.Name = "PRICE";
            PRICE.ReadOnly = true;
            // 
            // TOTALQUANTITY
            // 
            TOTALQUANTITY.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            TOTALQUANTITY.DefaultCellStyle = dataGridViewCellStyle5;
            TOTALQUANTITY.FillWeight = 10F;
            TOTALQUANTITY.HeaderText = "FİŞ ADEDİ";
            TOTALQUANTITY.Name = "TOTALQUANTITY";
            TOTALQUANTITY.ReadOnly = true;
            // 
            // QUANTITY
            // 
            QUANTITY.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            QUANTITY.DefaultCellStyle = dataGridViewCellStyle6;
            QUANTITY.FillWeight = 10F;
            QUANTITY.HeaderText = "ALINAN ADET";
            QUANTITY.Name = "QUANTITY";
            QUANTITY.ReadOnly = true;
            // 
            // TOTAL
            // 
            TOTAL.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            TOTAL.DefaultCellStyle = dataGridViewCellStyle7;
            TOTAL.FillWeight = 10F;
            TOTAL.HeaderText = "TOPLAM";
            TOTAL.Name = "TOTAL";
            TOTAL.ReadOnly = true;
            // 
            // tbPrice
            // 
            tbPrice.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            tbPrice.BackColor = Color.FromArgb(66, 178, 38);
            tbPrice.BorderStyle = BorderStyle.None;
            tbPrice.Font = new Font("Segoe UI Semibold", 35F, FontStyle.Bold);
            tbPrice.ForeColor = Color.White;
            tbPrice.Location = new Point(712, 38);
            tbPrice.Margin = new Padding(15, 1, 15, 15);
            tbPrice.Name = "tbPrice";
            tbPrice.Size = new Size(172, 63);
            tbPrice.TabIndex = 85;
            tbPrice.TextAlign = HorizontalAlignment.Center;
            tbPrice.TextChanged += tbPrice_TextChanged;
            tbPrice.Enter += tbPrice_Enter;
            tbPrice.KeyPress += tbPrice_KeyPress;
            // 
            // tbPriceHeader
            // 
            tbPriceHeader.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            tbPriceHeader.BackColor = Color.FromArgb(66, 178, 38);
            tbPriceHeader.BorderStyle = BorderStyle.None;
            tbPriceHeader.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            tbPriceHeader.ForeColor = Color.White;
            tbPriceHeader.Location = new Point(712, 14);
            tbPriceHeader.Margin = new Padding(1);
            tbPriceHeader.Name = "tbPriceHeader";
            tbPriceHeader.ReadOnly = true;
            tbPriceHeader.Size = new Size(172, 22);
            tbPriceHeader.TabIndex = 84;
            tbPriceHeader.Text = "ÖDENECEK TUTAR";
            tbPriceHeader.TextAlign = HorizontalAlignment.Center;
            // 
            // tbRemainingPrice
            // 
            tbRemainingPrice.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            tbRemainingPrice.BackColor = Color.FromArgb(237, 28, 36);
            tbRemainingPrice.BorderStyle = BorderStyle.None;
            tbRemainingPrice.Font = new Font("Segoe UI Semibold", 35F, FontStyle.Bold);
            tbRemainingPrice.ForeColor = Color.White;
            tbRemainingPrice.Location = new Point(900, 38);
            tbRemainingPrice.Margin = new Padding(1, 1, 1, 5);
            tbRemainingPrice.Name = "tbRemainingPrice";
            tbRemainingPrice.ReadOnly = true;
            tbRemainingPrice.Size = new Size(172, 63);
            tbRemainingPrice.TabIndex = 83;
            tbRemainingPrice.TextAlign = HorizontalAlignment.Center;
            // 
            // tbRemainingHeaderText
            // 
            tbRemainingHeaderText.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            tbRemainingHeaderText.BackColor = Color.FromArgb(237, 28, 36);
            tbRemainingHeaderText.BorderStyle = BorderStyle.None;
            tbRemainingHeaderText.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            tbRemainingHeaderText.ForeColor = Color.White;
            tbRemainingHeaderText.Location = new Point(900, 14);
            tbRemainingHeaderText.Margin = new Padding(1);
            tbRemainingHeaderText.Name = "tbRemainingHeaderText";
            tbRemainingHeaderText.ReadOnly = true;
            tbRemainingHeaderText.Size = new Size(172, 22);
            tbRemainingHeaderText.TabIndex = 82;
            tbRemainingHeaderText.Text = "KALAN TUTAR";
            tbRemainingHeaderText.TextAlign = HorizontalAlignment.Center;
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
            fcPaymentType.Location = new Point(900, 127);
            fcPaymentType.Margin = new Padding(1);
            fcPaymentType.Name = "fcPaymentType";
            fcPaymentType.Size = new Size(172, 52);
            fcPaymentType.TabIndex = 81;
            // 
            // tbPaymentTypeHeader
            // 
            tbPaymentTypeHeader.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            tbPaymentTypeHeader.BackColor = Color.Black;
            tbPaymentTypeHeader.BorderStyle = BorderStyle.None;
            tbPaymentTypeHeader.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            tbPaymentTypeHeader.ForeColor = Color.White;
            tbPaymentTypeHeader.Location = new Point(900, 107);
            tbPaymentTypeHeader.Margin = new Padding(1);
            tbPaymentTypeHeader.Name = "tbPaymentTypeHeader";
            tbPaymentTypeHeader.ReadOnly = true;
            tbPaymentTypeHeader.Size = new Size(172, 18);
            tbPaymentTypeHeader.TabIndex = 80;
            tbPaymentTypeHeader.Text = "ÖDEME TÜRÜ";
            tbPaymentTypeHeader.TextAlign = HorizontalAlignment.Center;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.BackColor = Color.FromArgb(255, 59, 59);
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            btnCancel.ForeColor = Color.White;
            btnCancel.Image = Properties.Resources._64pxWhiteX50Scale1;
            btnCancel.ImageAlign = ContentAlignment.TopCenter;
            btnCancel.Location = new Point(900, 190);
            btnCancel.Margin = new Padding(10);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(84, 138);
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
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Image = Properties.Resources._64pxGreenCheck;
            btnSave.ImageAlign = ContentAlignment.TopCenter;
            btnSave.Location = new Point(988, 190);
            btnSave.Margin = new Padding(10);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(84, 138);
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
        private TextBox tbPaymentTypeHeader;
        private CustomObjects.FlatCombo fcPaymentType;
        private TextBox tbRemainingHeaderText;
        private TextBox tbRemainingPrice;
        private TextBox tbPrice;
        private TextBox tbPriceHeader;
        private Panel pnlGrid;
        private Label lblFicheList;
        private DataGridView dgvMain;
        private CustomObjects.RoundButton btnNine;
        private CustomObjects.RoundButton btnEight;
        private CustomObjects.RoundButton btnSeven;
        private CustomObjects.RoundButton btnBackspace;
        private CustomObjects.RoundButton btnZero;
        private CustomObjects.RoundButton btnDot;
        private CustomObjects.RoundButton btnThree;
        private CustomObjects.RoundButton btnTwo;
        private CustomObjects.RoundButton btnOne;
        private CustomObjects.RoundButton btnSix;
        private CustomObjects.RoundButton btnFive;
        private CustomObjects.RoundButton btnFour;
        private DataGridViewTextBoxColumn BARCODE;
        private DataGridViewTextBoxColumn NAME;
        private DataGridViewTextBoxColumn PRICE;
        private DataGridViewTextBoxColumn TOTALQUANTITY;
        private DataGridViewTextBoxColumn QUANTITY;
        private DataGridViewTextBoxColumn TOTAL;
    }
}