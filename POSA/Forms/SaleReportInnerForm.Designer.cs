namespace POSA.Forms
{
    partial class SaleReportInnerForm
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
            lblMovement = new Label();
            panel1 = new Panel();
            rbGift = new RadioButton();
            rbPayLater = new RadioButton();
            rbRefund = new RadioButton();
            rbBuy = new RadioButton();
            rbSell = new RadioButton();
            rbAll = new RadioButton();
            panel2 = new Panel();
            dtpEnd = new DateTimePicker();
            dtpBegin = new DateTimePicker();
            lblDash = new Label();
            lblDates = new Label();
            panel3 = new Panel();
            fcPaymentType = new CustomObjects.FlatCombo();
            lblPaymentType = new Label();
            panel4 = new Panel();
            cbCategory = new ComboBox();
            lblProductCategory = new Label();
            panel5 = new Panel();
            tbProduct = new TextBox();
            label2 = new Label();
            btnExcel = new Button();
            btnZReport = new Button();
            panel6 = new Panel();
            dgvMain = new DataGridView();
            btnCancel = new Button();
            btnBring = new Button();
            panel7 = new Panel();
            btnShowBuyingPrice = new Button();
            label11 = new Label();
            tbTotalProfit = new TextBox();
            tbTotalSales = new TextBox();
            lblTotal = new Label();
            panel8 = new Panel();
            tbOtherSale = new TextBox();
            label6 = new Label();
            tbCardSale = new TextBox();
            label5 = new Label();
            tbCashSale = new TextBox();
            label1 = new Label();
            panel9 = new Panel();
            tbFree = new TextBox();
            tbPayLater = new TextBox();
            label3 = new Label();
            label7 = new Label();
            tbCashAndCard = new TextBox();
            label4 = new Label();
            panel10 = new Panel();
            tbRefundTotal = new TextBox();
            tbRefundCash = new TextBox();
            label8 = new Label();
            label10 = new Label();
            tbRefundCard = new TextBox();
            label9 = new Label();
            fcFilter = new CustomObjects.FlatCombo();
            BARCODE = new DataGridViewTextBoxColumn();
            PRODUCT = new DataGridViewTextBoxColumn();
            DATE = new DataGridViewTextBoxColumn();
            QUANTITY = new DataGridViewTextBoxColumn();
            BUYPRICE = new DataGridViewTextBoxColumn();
            SALEPRICE = new DataGridViewTextBoxColumn();
            TOTALPRICE = new DataGridViewTextBoxColumn();
            PROFIT = new DataGridViewTextBoxColumn();
            PAYMENTTYPE = new DataGridViewTextBoxColumn();
            CUSTOMER = new DataGridViewTextBoxColumn();
            WORKER = new DataGridViewTextBoxColumn();
            FICHETYPE = new DataGridViewTextBoxColumn();
            TOTALSALEQ = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMain).BeginInit();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            panel10.SuspendLayout();
            SuspendLayout();
            // 
            // lblMovement
            // 
            lblMovement.AutoSize = true;
            lblMovement.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblMovement.ForeColor = Color.White;
            lblMovement.Location = new Point(4, 1);
            lblMovement.Name = "lblMovement";
            lblMovement.Size = new Size(118, 21);
            lblMovement.TabIndex = 0;
            lblMovement.Text = "Hareket Türleri";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(84, 116, 173);
            panel1.Controls.Add(rbGift);
            panel1.Controls.Add(rbPayLater);
            panel1.Controls.Add(rbRefund);
            panel1.Controls.Add(rbBuy);
            panel1.Controls.Add(rbSell);
            panel1.Controls.Add(rbAll);
            panel1.Controls.Add(lblMovement);
            panel1.Location = new Point(12, 13);
            panel1.Name = "panel1";
            panel1.Size = new Size(158, 193);
            panel1.TabIndex = 1;
            // 
            // rbGift
            // 
            rbGift.AutoSize = true;
            rbGift.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            rbGift.ForeColor = Color.White;
            rbGift.Location = new Point(9, 137);
            rbGift.Name = "rbGift";
            rbGift.Size = new Size(62, 23);
            rbGift.TabIndex = 7;
            rbGift.TabStop = true;
            rbGift.Text = "İkram";
            rbGift.UseVisualStyleBackColor = true;
            // 
            // rbPayLater
            // 
            rbPayLater.AutoSize = true;
            rbPayLater.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            rbPayLater.ForeColor = Color.White;
            rbPayLater.Location = new Point(9, 166);
            rbPayLater.Name = "rbPayLater";
            rbPayLater.Size = new Size(78, 23);
            rbPayLater.TabIndex = 6;
            rbPayLater.TabStop = true;
            rbPayLater.Text = "Veresiye";
            rbPayLater.UseVisualStyleBackColor = true;
            // 
            // rbRefund
            // 
            rbRefund.AutoSize = true;
            rbRefund.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            rbRefund.ForeColor = Color.White;
            rbRefund.Location = new Point(9, 108);
            rbRefund.Name = "rbRefund";
            rbRefund.Size = new Size(53, 23);
            rbRefund.TabIndex = 4;
            rbRefund.TabStop = true;
            rbRefund.Text = "İade";
            rbRefund.UseVisualStyleBackColor = true;
            // 
            // rbBuy
            // 
            rbBuy.AutoSize = true;
            rbBuy.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            rbBuy.ForeColor = Color.White;
            rbBuy.Location = new Point(9, 82);
            rbBuy.Name = "rbBuy";
            rbBuy.Size = new Size(50, 23);
            rbBuy.TabIndex = 3;
            rbBuy.TabStop = true;
            rbBuy.Text = "Alış";
            rbBuy.UseVisualStyleBackColor = true;
            // 
            // rbSell
            // 
            rbSell.AutoSize = true;
            rbSell.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            rbSell.ForeColor = Color.White;
            rbSell.Location = new Point(9, 56);
            rbSell.Name = "rbSell";
            rbSell.Size = new Size(57, 23);
            rbSell.TabIndex = 2;
            rbSell.TabStop = true;
            rbSell.Text = "Satış";
            rbSell.UseVisualStyleBackColor = true;
            // 
            // rbAll
            // 
            rbAll.AutoSize = true;
            rbAll.Checked = true;
            rbAll.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            rbAll.ForeColor = Color.White;
            rbAll.Location = new Point(9, 30);
            rbAll.Name = "rbAll";
            rbAll.Size = new Size(62, 23);
            rbAll.TabIndex = 1;
            rbAll.TabStop = true;
            rbAll.Text = "Tümü";
            rbAll.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(84, 116, 173);
            panel2.Controls.Add(dtpEnd);
            panel2.Controls.Add(dtpBegin);
            panel2.Controls.Add(lblDash);
            panel2.Controls.Add(lblDates);
            panel2.Location = new Point(176, 13);
            panel2.Name = "panel2";
            panel2.Size = new Size(268, 52);
            panel2.TabIndex = 2;
            // 
            // dtpEnd
            // 
            dtpEnd.Location = new Point(146, 22);
            dtpEnd.Name = "dtpEnd";
            dtpEnd.Size = new Size(119, 23);
            dtpEnd.TabIndex = 3;
            // 
            // dtpBegin
            // 
            dtpBegin.Location = new Point(3, 22);
            dtpBegin.Name = "dtpBegin";
            dtpBegin.Size = new Size(117, 23);
            dtpBegin.TabIndex = 2;
            // 
            // lblDash
            // 
            lblDash.AutoSize = true;
            lblDash.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblDash.ForeColor = Color.White;
            lblDash.Location = new Point(126, 22);
            lblDash.Name = "lblDash";
            lblDash.Size = new Size(16, 21);
            lblDash.TabIndex = 1;
            lblDash.Text = "-";
            // 
            // lblDates
            // 
            lblDates.AutoSize = true;
            lblDates.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblDates.ForeColor = Color.White;
            lblDates.Location = new Point(77, 1);
            lblDates.Name = "lblDates";
            lblDates.Size = new Size(121, 21);
            lblDates.TabIndex = 0;
            lblDates.Text = "TARİH ARALIĞI";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(84, 116, 173);
            panel3.Controls.Add(fcPaymentType);
            panel3.Controls.Add(lblPaymentType);
            panel3.Location = new Point(450, 13);
            panel3.Name = "panel3";
            panel3.Size = new Size(192, 52);
            panel3.TabIndex = 4;
            // 
            // fcPaymentType
            // 
            fcPaymentType.BorderColor = Color.White;
            fcPaymentType.ButtonColor = Color.Black;
            fcPaymentType.DrawMode = DrawMode.OwnerDrawFixed;
            fcPaymentType.FormattingEnabled = true;
            fcPaymentType.Items.AddRange(new object[] { "", "NAKİT", "KART", "DİĞER" });
            fcPaymentType.Location = new Point(3, 24);
            fcPaymentType.Name = "fcPaymentType";
            fcPaymentType.Size = new Size(186, 24);
            fcPaymentType.TabIndex = 1;
            // 
            // lblPaymentType
            // 
            lblPaymentType.AutoSize = true;
            lblPaymentType.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblPaymentType.ForeColor = Color.White;
            lblPaymentType.Location = new Point(3, 1);
            lblPaymentType.Name = "lblPaymentType";
            lblPaymentType.Size = new Size(96, 21);
            lblPaymentType.TabIndex = 0;
            lblPaymentType.Text = "ÖDEME TİPİ";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(84, 116, 173);
            panel4.Controls.Add(cbCategory);
            panel4.Controls.Add(lblProductCategory);
            panel4.Location = new Point(648, 13);
            panel4.Name = "panel4";
            panel4.Size = new Size(192, 52);
            panel4.TabIndex = 5;
            // 
            // cbCategory
            // 
            cbCategory.BackColor = Color.White;
            cbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCategory.FlatStyle = FlatStyle.Flat;
            cbCategory.Font = new Font("Segoe UI", 10F);
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(3, 23);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(186, 25);
            cbCategory.TabIndex = 65;
            // 
            // lblProductCategory
            // 
            lblProductCategory.AutoSize = true;
            lblProductCategory.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblProductCategory.ForeColor = Color.White;
            lblProductCategory.Location = new Point(3, 1);
            lblProductCategory.Name = "lblProductCategory";
            lblProductCategory.Size = new Size(111, 21);
            lblProductCategory.TabIndex = 0;
            lblProductCategory.Text = "ÜRÜN GRUBU";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(84, 116, 173);
            panel5.Controls.Add(tbProduct);
            panel5.Controls.Add(label2);
            panel5.Location = new Point(846, 14);
            panel5.Name = "panel5";
            panel5.Size = new Size(192, 52);
            panel5.TabIndex = 5;
            // 
            // tbProduct
            // 
            tbProduct.BorderStyle = BorderStyle.None;
            tbProduct.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            tbProduct.Location = new Point(3, 24);
            tbProduct.Name = "tbProduct";
            tbProduct.Size = new Size(186, 22);
            tbProduct.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.White;
            label2.Location = new Point(3, 1);
            label2.Name = "label2";
            label2.Size = new Size(85, 21);
            label2.TabIndex = 0;
            label2.Text = "ÜRÜN ADI";
            // 
            // btnExcel
            // 
            btnExcel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnExcel.BackColor = Color.Transparent;
            btnExcel.BackgroundImage = Properties.Resources._64pxGrayExcel;
            btnExcel.BackgroundImageLayout = ImageLayout.Stretch;
            btnExcel.FlatAppearance.BorderSize = 0;
            btnExcel.FlatStyle = FlatStyle.Flat;
            btnExcel.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold);
            btnExcel.ForeColor = Color.White;
            btnExcel.Location = new Point(1064, 14);
            btnExcel.Margin = new Padding(10);
            btnExcel.Name = "btnExcel";
            btnExcel.Size = new Size(75, 76);
            btnExcel.TabIndex = 115;
            btnExcel.UseVisualStyleBackColor = false;
            // 
            // btnZReport
            // 
            btnZReport.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnZReport.BackColor = Color.Transparent;
            btnZReport.BackgroundImage = Properties.Resources._64pxWhiteZReport;
            btnZReport.BackgroundImageLayout = ImageLayout.Stretch;
            btnZReport.FlatAppearance.BorderSize = 0;
            btnZReport.FlatStyle = FlatStyle.Flat;
            btnZReport.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold);
            btnZReport.ForeColor = Color.White;
            btnZReport.Location = new Point(1145, 24);
            btnZReport.Margin = new Padding(10);
            btnZReport.Name = "btnZReport";
            btnZReport.Size = new Size(55, 55);
            btnZReport.TabIndex = 116;
            btnZReport.UseVisualStyleBackColor = false;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(dgvMain);
            panel6.Location = new Point(12, 254);
            panel6.Margin = new Padding(3, 3, 12, 12);
            panel6.Name = "panel6";
            panel6.Size = new Size(1226, 334);
            panel6.TabIndex = 117;
            // 
            // dgvMain
            // 
            dgvMain.AllowUserToAddRows = false;
            dgvMain.AllowUserToDeleteRows = false;
            dgvMain.AllowUserToResizeColumns = false;
            dgvMain.AllowUserToResizeRows = false;
            dgvMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvMain.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
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
            dgvMain.Columns.AddRange(new DataGridViewColumn[] { BARCODE, PRODUCT, DATE, QUANTITY, BUYPRICE, SALEPRICE, TOTALPRICE, PROFIT, PAYMENTTYPE, CUSTOMER, WORKER, FICHETYPE, TOTALSALEQ });
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
            dgvMain.RowTemplate.DefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dgvMain.RowTemplate.DefaultCellStyle.ForeColor = Color.FromArgb(1, 39, 103);
            dgvMain.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(109, 134, 176);
            dgvMain.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvMain.RowTemplate.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvMain.RowTemplate.DividerHeight = 10;
            dgvMain.RowTemplate.Height = 60;
            dgvMain.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMain.Size = new Size(1206, 314);
            dgvMain.TabIndex = 76;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Red;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnCancel.ForeColor = Color.White;
            btnCancel.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancel.Location = new Point(1048, 92);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(180, 54);
            btnCancel.TabIndex = 118;
            btnCancel.Text = "İPTAL";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnBring
            // 
            btnBring.BackColor = Color.FromArgb(0, 140, 71);
            btnBring.DialogResult = DialogResult.OK;
            btnBring.FlatAppearance.BorderSize = 0;
            btnBring.FlatStyle = FlatStyle.Flat;
            btnBring.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnBring.ForeColor = Color.White;
            btnBring.ImageAlign = ContentAlignment.MiddleLeft;
            btnBring.Location = new Point(1048, 150);
            btnBring.Name = "btnBring";
            btnBring.Size = new Size(180, 54);
            btnBring.TabIndex = 77;
            btnBring.Text = "GETİR";
            btnBring.UseVisualStyleBackColor = false;
            btnBring.Click += btnBring_Click;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(54, 54, 54);
            panel7.Controls.Add(btnShowBuyingPrice);
            panel7.Controls.Add(label11);
            panel7.Controls.Add(tbTotalProfit);
            panel7.Controls.Add(tbTotalSales);
            panel7.Controls.Add(lblTotal);
            panel7.Location = new Point(176, 210);
            panel7.Name = "panel7";
            panel7.Size = new Size(782, 38);
            panel7.TabIndex = 6;
            // 
            // btnShowBuyingPrice
            // 
            btnShowBuyingPrice.FlatAppearance.BorderSize = 0;
            btnShowBuyingPrice.FlatStyle = FlatStyle.Flat;
            btnShowBuyingPrice.Image = Properties.Resources._24pxWhiteEye;
            btnShowBuyingPrice.Location = new Point(747, 5);
            btnShowBuyingPrice.Name = "btnShowBuyingPrice";
            btnShowBuyingPrice.Size = new Size(27, 27);
            btnShowBuyingPrice.TabIndex = 53;
            btnShowBuyingPrice.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            label11.ForeColor = Color.White;
            label11.Location = new Point(379, 3);
            label11.Name = "label11";
            label11.Size = new Size(162, 32);
            label11.TabIndex = 3;
            label11.Text = "TOPLAM KAR";
            // 
            // tbTotalProfit
            // 
            tbTotalProfit.BackColor = Color.FromArgb(0, 140, 71);
            tbTotalProfit.BorderStyle = BorderStyle.None;
            tbTotalProfit.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            tbTotalProfit.ForeColor = Color.White;
            tbTotalProfit.Location = new Point(556, 3);
            tbTotalProfit.Name = "tbTotalProfit";
            tbTotalProfit.ReadOnly = true;
            tbTotalProfit.Size = new Size(189, 32);
            tbTotalProfit.TabIndex = 2;
            // 
            // tbTotalSales
            // 
            tbTotalSales.BackColor = Color.FromArgb(0, 140, 71);
            tbTotalSales.BorderStyle = BorderStyle.None;
            tbTotalSales.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            tbTotalSales.ForeColor = Color.White;
            tbTotalSales.Location = new Point(184, 3);
            tbTotalSales.Name = "tbTotalSales";
            tbTotalSales.ReadOnly = true;
            tbTotalSales.Size = new Size(189, 32);
            tbTotalSales.TabIndex = 1;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            lblTotal.ForeColor = Color.White;
            lblTotal.Location = new Point(3, 3);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(171, 32);
            lblTotal.TabIndex = 0;
            lblTotal.Text = "TOPLAM CİRO";
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(54, 54, 54);
            panel8.Controls.Add(tbOtherSale);
            panel8.Controls.Add(label6);
            panel8.Controls.Add(tbCardSale);
            panel8.Controls.Add(label5);
            panel8.Controls.Add(tbCashSale);
            panel8.Controls.Add(label1);
            panel8.Location = new Point(176, 71);
            panel8.Name = "panel8";
            panel8.Size = new Size(282, 133);
            panel8.TabIndex = 119;
            // 
            // tbOtherSale
            // 
            tbOtherSale.BackColor = Color.White;
            tbOtherSale.BorderStyle = BorderStyle.None;
            tbOtherSale.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            tbOtherSale.ForeColor = Color.Black;
            tbOtherSale.Location = new Point(112, 88);
            tbOtherSale.Name = "tbOtherSale";
            tbOtherSale.ReadOnly = true;
            tbOtherSale.Size = new Size(164, 32);
            tbOtherSale.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(4, 91);
            label6.Name = "label6";
            label6.Size = new Size(102, 25);
            label6.TabIndex = 4;
            label6.Text = "Diğer Satış";
            // 
            // tbCardSale
            // 
            tbCardSale.BackColor = Color.White;
            tbCardSale.BorderStyle = BorderStyle.None;
            tbCardSale.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            tbCardSale.ForeColor = Color.Black;
            tbCardSale.Location = new Point(112, 50);
            tbCardSale.Name = "tbCardSale";
            tbCardSale.ReadOnly = true;
            tbCardSale.Size = new Size(164, 32);
            tbCardSale.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(3, 54);
            label5.Name = "label5";
            label5.Size = new Size(106, 25);
            label5.TabIndex = 2;
            label5.Text = "K.Kart Satış";
            // 
            // tbCashSale
            // 
            tbCashSale.BackColor = Color.White;
            tbCashSale.BorderStyle = BorderStyle.None;
            tbCashSale.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            tbCashSale.ForeColor = Color.Black;
            tbCashSale.Location = new Point(112, 12);
            tbCashSale.Name = "tbCashSale";
            tbCashSale.ReadOnly = true;
            tbCashSale.Size = new Size(164, 32);
            tbCashSale.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(4, 16);
            label1.Name = "label1";
            label1.Size = new Size(100, 25);
            label1.TabIndex = 0;
            label1.Text = "Nakit Satış";
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(54, 54, 54);
            panel9.Controls.Add(tbFree);
            panel9.Controls.Add(tbPayLater);
            panel9.Controls.Add(label3);
            panel9.Controls.Add(label7);
            panel9.Controls.Add(tbCashAndCard);
            panel9.Controls.Add(label4);
            panel9.Location = new Point(464, 71);
            panel9.Name = "panel9";
            panel9.Size = new Size(282, 133);
            panel9.TabIndex = 120;
            // 
            // tbFree
            // 
            tbFree.BackColor = Color.White;
            tbFree.BorderStyle = BorderStyle.None;
            tbFree.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            tbFree.ForeColor = Color.Black;
            tbFree.Location = new Point(112, 88);
            tbFree.Name = "tbFree";
            tbFree.ReadOnly = true;
            tbFree.Size = new Size(164, 32);
            tbFree.TabIndex = 11;
            // 
            // tbPayLater
            // 
            tbPayLater.BackColor = Color.White;
            tbPayLater.BorderStyle = BorderStyle.None;
            tbPayLater.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            tbPayLater.ForeColor = Color.Black;
            tbPayLater.Location = new Point(112, 12);
            tbPayLater.Name = "tbPayLater";
            tbPayLater.ReadOnly = true;
            tbPayLater.Size = new Size(164, 32);
            tbPayLater.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(3, 91);
            label3.Name = "label3";
            label3.Size = new Size(58, 25);
            label3.TabIndex = 10;
            label3.Text = "İkram";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            label7.ForeColor = Color.White;
            label7.Location = new Point(3, 16);
            label7.Name = "label7";
            label7.Size = new Size(101, 25);
            label7.TabIndex = 6;
            label7.Text = "Veresiye S.";
            // 
            // tbCashAndCard
            // 
            tbCashAndCard.BackColor = Color.White;
            tbCashAndCard.BorderStyle = BorderStyle.None;
            tbCashAndCard.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            tbCashAndCard.ForeColor = Color.Black;
            tbCashAndCard.Location = new Point(112, 50);
            tbCashAndCard.Name = "tbCashAndCard";
            tbCashAndCard.ReadOnly = true;
            tbCashAndCard.Size = new Size(164, 32);
            tbCashAndCard.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(3, 54);
            label4.Name = "label4";
            label4.Size = new Size(101, 25);
            label4.TabIndex = 8;
            label4.Text = "Nakit + KK";
            // 
            // panel10
            // 
            panel10.BackColor = Color.FromArgb(54, 54, 54);
            panel10.Controls.Add(tbRefundTotal);
            panel10.Controls.Add(tbRefundCash);
            panel10.Controls.Add(label8);
            panel10.Controls.Add(label10);
            panel10.Controls.Add(tbRefundCard);
            panel10.Controls.Add(label9);
            panel10.Location = new Point(752, 71);
            panel10.Name = "panel10";
            panel10.Size = new Size(286, 133);
            panel10.TabIndex = 120;
            // 
            // tbRefundTotal
            // 
            tbRefundTotal.BackColor = Color.White;
            tbRefundTotal.BorderStyle = BorderStyle.None;
            tbRefundTotal.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            tbRefundTotal.ForeColor = Color.Black;
            tbRefundTotal.Location = new Point(112, 88);
            tbRefundTotal.Name = "tbRefundTotal";
            tbRefundTotal.ReadOnly = true;
            tbRefundTotal.Size = new Size(164, 32);
            tbRefundTotal.TabIndex = 17;
            // 
            // tbRefundCash
            // 
            tbRefundCash.BackColor = Color.White;
            tbRefundCash.BorderStyle = BorderStyle.None;
            tbRefundCash.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            tbRefundCash.ForeColor = Color.Black;
            tbRefundCash.Location = new Point(112, 12);
            tbRefundCash.Name = "tbRefundCash";
            tbRefundCash.ReadOnly = true;
            tbRefundCash.Size = new Size(164, 32);
            tbRefundCash.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            label8.ForeColor = Color.White;
            label8.Location = new Point(3, 91);
            label8.Name = "label8";
            label8.Size = new Size(112, 25);
            label8.TabIndex = 16;
            label8.Text = "İade Toplam";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            label10.ForeColor = Color.White;
            label10.Location = new Point(3, 16);
            label10.Name = "label10";
            label10.Size = new Size(96, 25);
            label10.TabIndex = 12;
            label10.Text = "İade Nakit";
            // 
            // tbRefundCard
            // 
            tbRefundCard.BackColor = Color.White;
            tbRefundCard.BorderStyle = BorderStyle.None;
            tbRefundCard.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            tbRefundCard.ForeColor = Color.Black;
            tbRefundCard.Location = new Point(112, 50);
            tbRefundCard.Name = "tbRefundCard";
            tbRefundCard.ReadOnly = true;
            tbRefundCard.Size = new Size(164, 32);
            tbRefundCard.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            label9.ForeColor = Color.White;
            label9.Location = new Point(3, 54);
            label9.Name = "label9";
            label9.Size = new Size(87, 25);
            label9.TabIndex = 14;
            label9.Text = "İade Kart";
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
            fcFilter.Location = new Point(997, 213);
            fcFilter.Margin = new Padding(1);
            fcFilter.Name = "fcFilter";
            fcFilter.Size = new Size(240, 32);
            fcFilter.TabIndex = 121;
            fcFilter.SelectedIndexChanged += fcFilter_SelectedIndexChanged;
            // 
            // BARCODE
            // 
            BARCODE.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            BARCODE.DataPropertyName = "BARCODE";
            BARCODE.FillWeight = 10F;
            BARCODE.HeaderText = "BARKOD";
            BARCODE.MaxInputLength = 100;
            BARCODE.Name = "BARCODE";
            BARCODE.ReadOnly = true;
            // 
            // PRODUCT
            // 
            PRODUCT.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            PRODUCT.DataPropertyName = "PRODUCT";
            PRODUCT.FillWeight = 25F;
            PRODUCT.HeaderText = "ÜRÜN ADI";
            PRODUCT.MaxInputLength = 50;
            PRODUCT.Name = "PRODUCT";
            PRODUCT.ReadOnly = true;
            // 
            // DATE
            // 
            DATE.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DATE.DataPropertyName = "DATE";
            DATE.FillWeight = 10F;
            DATE.HeaderText = "TARİH";
            DATE.Name = "DATE";
            DATE.ReadOnly = true;
            // 
            // QUANTITY
            // 
            QUANTITY.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            QUANTITY.DataPropertyName = "QUANTITY";
            QUANTITY.FillWeight = 5F;
            QUANTITY.HeaderText = "ADET";
            QUANTITY.Name = "QUANTITY";
            QUANTITY.ReadOnly = true;
            // 
            // BUYPRICE
            // 
            BUYPRICE.DataPropertyName = "BUYPRICE";
            BUYPRICE.HeaderText = "ALIŞ FİYAT";
            BUYPRICE.Name = "BUYPRICE";
            BUYPRICE.ReadOnly = true;
            // 
            // SALEPRICE
            // 
            SALEPRICE.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SALEPRICE.DataPropertyName = "SALEPRICE";
            SALEPRICE.FillWeight = 10F;
            SALEPRICE.HeaderText = "SATIŞ FİYAT";
            SALEPRICE.Name = "SALEPRICE";
            SALEPRICE.ReadOnly = true;
            // 
            // TOTALPRICE
            // 
            TOTALPRICE.DataPropertyName = "TOTALPRICE";
            TOTALPRICE.HeaderText = "TOPLAM TUTAR";
            TOTALPRICE.Name = "TOTALPRICE";
            TOTALPRICE.ReadOnly = true;
            // 
            // PROFIT
            // 
            PROFIT.DataPropertyName = "PROFIT";
            PROFIT.HeaderText = "KAR";
            PROFIT.Name = "PROFIT";
            PROFIT.ReadOnly = true;
            // 
            // PAYMENTTYPE
            // 
            PAYMENTTYPE.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            PAYMENTTYPE.DataPropertyName = "PAYMENTTYPE";
            PAYMENTTYPE.FillWeight = 15F;
            PAYMENTTYPE.HeaderText = "ÖDEME";
            PAYMENTTYPE.Name = "PAYMENTTYPE";
            PAYMENTTYPE.ReadOnly = true;
            // 
            // CUSTOMER
            // 
            CUSTOMER.DataPropertyName = "CUSTOMER";
            CUSTOMER.HeaderText = "MÜŞTERİ";
            CUSTOMER.Name = "CUSTOMER";
            CUSTOMER.ReadOnly = true;
            // 
            // WORKER
            // 
            WORKER.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            WORKER.DataPropertyName = "WORKER";
            WORKER.FillWeight = 15F;
            WORKER.HeaderText = "PERSONEL";
            WORKER.Name = "WORKER";
            WORKER.ReadOnly = true;
            // 
            // FICHETYPE
            // 
            FICHETYPE.DataPropertyName = "FICHETYPE";
            FICHETYPE.HeaderText = "FICHETYPE";
            FICHETYPE.Name = "FICHETYPE";
            FICHETYPE.ReadOnly = true;
            FICHETYPE.Visible = false;
            // 
            // TOTALSALEQ
            // 
            TOTALSALEQ.DataPropertyName = "TOTALSALEQ";
            TOTALSALEQ.HeaderText = "TOTALSALEQ";
            TOTALSALEQ.Name = "TOTALSALEQ";
            TOTALSALEQ.ReadOnly = true;
            TOTALSALEQ.Visible = false;
            // 
            // SaleReportInnerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 74, 173);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1249, 600);
            Controls.Add(fcFilter);
            Controls.Add(panel10);
            Controls.Add(panel9);
            Controls.Add(panel8);
            Controls.Add(panel7);
            Controls.Add(btnBring);
            Controls.Add(btnCancel);
            Controls.Add(panel6);
            Controls.Add(btnZReport);
            Controls.Add(btnExcel);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "SaleReportInnerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Load += SaleReportInnerForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMain).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblMovement;
        private Panel panel1;
        private RadioButton radioButton5;
        private RadioButton rbRefund;
        private RadioButton rbBuy;
        private RadioButton rbSell;
        private RadioButton rbAll;
        private RadioButton rbPayLater;
        private Panel panel2;
        private Label lblDates;
        private DateTimePicker dtpEnd;
        private DateTimePicker dtpBegin;
        private Label lblDash;
        private Panel panel3;
        private Label lblPaymentType;
        private CustomObjects.FlatCombo fcPaymentType;
        private Panel panel4;
        private Label lblProductCategory;
        private Panel panel5;
        private Label label2;
        private TextBox tbProduct;
        private Button btnExcel;
        private Button btnZReport;
        private Panel panel6;
        private DataGridView dgvMain;
        private Button btnCancel;
        private Button btnBring;
        private Panel panel7;
        private TextBox tbTotalSales;
        private Label lblTotal;
        private Panel panel8;
        private TextBox tbCashSale;
        private Label label1;
        private Panel panel9;
        private Panel panel10;
        private TextBox tbOtherSale;
        private Label label6;
        private TextBox tbCardSale;
        private Label label5;
        private TextBox tbFree;
        private TextBox tbPayLater;
        private Label label3;
        private Label label7;
        private TextBox tbCashAndCard;
        private Label label4;
        private TextBox tbRefundTotal;
        private TextBox tbRefundCash;
        private Label label8;
        private Label label10;
        private TextBox tbRefundCard;
        private Label label9;
        private Label label11;
        private TextBox tbTotalProfit;
        private Button btnShowBuyingPrice;
        private CustomObjects.FlatCombo fcFilter;
        private ComboBox cbCategory;
        private RadioButton rbGift;
        private DataGridViewTextBoxColumn BARCODE;
        private DataGridViewTextBoxColumn PRODUCT;
        private DataGridViewTextBoxColumn DATE;
        private DataGridViewTextBoxColumn QUANTITY;
        private DataGridViewTextBoxColumn BUYPRICE;
        private DataGridViewTextBoxColumn SALEPRICE;
        private DataGridViewTextBoxColumn TOTALPRICE;
        private DataGridViewTextBoxColumn PROFIT;
        private DataGridViewTextBoxColumn PAYMENTTYPE;
        private DataGridViewTextBoxColumn CUSTOMER;
        private DataGridViewTextBoxColumn WORKER;
        private DataGridViewTextBoxColumn FICHETYPE;
        private DataGridViewTextBoxColumn TOTALSALEQ;
    }
}