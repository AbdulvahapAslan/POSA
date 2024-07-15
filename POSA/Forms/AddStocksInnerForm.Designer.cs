namespace POSA.Forms
{
    partial class AddStocksInnerForm
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
            pbClearSearch = new PictureBox();
            pbMagGlass = new PictureBox();
            rtbSearch = new CustomObjects.RoundTextBox();
            lblBarcodeS = new Label();
            lblProductS = new Label();
            lblStockS = new Label();
            lblBuyS = new Label();
            lblSellS = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            lblBuy = new Label();
            lblStock = new Label();
            lblSell = new Label();
            lblBarcode = new Label();
            lblProdName = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            panel7 = new Panel();
            panel8 = new Panel();
            panel9 = new Panel();
            textBox1 = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            lblBuying = new Label();
            textBox2 = new TextBox();
            lblSelling = new Label();
            textBox3 = new TextBox();
            lblChooseSupp = new Label();
            btnCancel = new Button();
            btnSave = new Button();
            panel10 = new Panel();
            panel11 = new Panel();
            fcPaymentType = new CustomObjects.FlatCombo();
            ((System.ComponentModel.ISupportInitialize)pbClearSearch).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbMagGlass).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pbClearSearch
            // 
            pbClearSearch.BackColor = Color.White;
            pbClearSearch.BackgroundImage = Properties.Resources._16pxCloseBlack;
            pbClearSearch.BackgroundImageLayout = ImageLayout.Center;
            pbClearSearch.Location = new Point(679, 17);
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
            pbMagGlass.Location = new Point(414, 17);
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
            rtbSearch.Location = new Point(409, 13);
            rtbSearch.Margin = new Padding(4);
            rtbSearch.Multiline = false;
            rtbSearch.Name = "rtbSearch";
            rtbSearch.Padding = new Padding(35, 7, 30, 7);
            rtbSearch.PasswordChar = false;
            rtbSearch.PlaceholderColor = Color.DarkGray;
            rtbSearch.PlaceholderText = "Ara...";
            rtbSearch.Size = new Size(300, 34);
            rtbSearch.TabIndex = 85;
            rtbSearch.Texts = "";
            rtbSearch.UnderlinedStyle = false;
            // 
            // lblBarcodeS
            // 
            lblBarcodeS.Anchor = AnchorStyles.None;
            lblBarcodeS.AutoSize = true;
            lblBarcodeS.BackColor = Color.FromArgb(78, 104, 133);
            lblBarcodeS.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            lblBarcodeS.ForeColor = Color.White;
            lblBarcodeS.Location = new Point(52, 17);
            lblBarcodeS.Margin = new Padding(0);
            lblBarcodeS.Name = "lblBarcodeS";
            lblBarcodeS.Size = new Size(119, 30);
            lblBarcodeS.TabIndex = 0;
            lblBarcodeS.Text = "Barkod No";
            // 
            // lblProductS
            // 
            lblProductS.Anchor = AnchorStyles.None;
            lblProductS.AutoSize = true;
            lblProductS.BackColor = Color.FromArgb(78, 104, 133);
            lblProductS.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            lblProductS.ForeColor = Color.White;
            lblProductS.Location = new Point(252, 17);
            lblProductS.Margin = new Padding(0);
            lblProductS.Name = "lblProductS";
            lblProductS.Size = new Size(108, 30);
            lblProductS.TabIndex = 1;
            lblProductS.Text = "Ürün İsmi";
            // 
            // lblStockS
            // 
            lblStockS.Anchor = AnchorStyles.None;
            lblStockS.AutoSize = true;
            lblStockS.BackColor = Color.FromArgb(78, 104, 133);
            lblStockS.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            lblStockS.ForeColor = Color.White;
            lblStockS.Location = new Point(471, 17);
            lblStockS.Margin = new Padding(0);
            lblStockS.Name = "lblStockS";
            lblStockS.Size = new Size(57, 30);
            lblStockS.TabIndex = 2;
            lblStockS.Text = "Stok";
            // 
            // lblBuyS
            // 
            lblBuyS.Anchor = AnchorStyles.None;
            lblBuyS.AutoSize = true;
            lblBuyS.BackColor = Color.FromArgb(78, 104, 133);
            lblBuyS.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            lblBuyS.ForeColor = Color.White;
            lblBuyS.Location = new Point(618, 17);
            lblBuyS.Margin = new Padding(0);
            lblBuyS.Name = "lblBuyS";
            lblBuyS.Size = new Size(152, 30);
            lblBuyS.TabIndex = 3;
            lblBuyS.Text = "Son Alış Fiyatı";
            // 
            // lblSellS
            // 
            lblSellS.Anchor = AnchorStyles.None;
            lblSellS.AutoSize = true;
            lblSellS.BackColor = Color.FromArgb(78, 104, 133);
            lblSellS.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            lblSellS.ForeColor = Color.White;
            lblSellS.Location = new Point(831, 17);
            lblSellS.Margin = new Padding(0);
            lblSellS.Name = "lblSellS";
            lblSellS.Size = new Size(118, 30);
            lblSellS.TabIndex = 4;
            lblSellS.Text = "Satış Fiyatı";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(78, 104, 133);
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Controls.Add(lblBuyS, 3, 0);
            tableLayoutPanel1.Controls.Add(lblStockS, 2, 0);
            tableLayoutPanel1.Controls.Add(lblSellS, 4, 0);
            tableLayoutPanel1.Controls.Add(lblBarcodeS, 0, 0);
            tableLayoutPanel1.Controls.Add(lblProductS, 1, 0);
            tableLayoutPanel1.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            tableLayoutPanel1.Location = new Point(45, 13);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(15);
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1004, 64);
            tableLayoutPanel1.TabIndex = 86;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 39, 80);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Location = new Point(12, 70);
            panel1.Name = "panel1";
            panel1.Size = new Size(1094, 160);
            panel1.TabIndex = 87;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.FromArgb(78, 104, 133);
            tableLayoutPanel2.ColumnCount = 5;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.Controls.Add(lblBuy, 3, 0);
            tableLayoutPanel2.Controls.Add(lblStock, 2, 0);
            tableLayoutPanel2.Controls.Add(lblSell, 4, 0);
            tableLayoutPanel2.Controls.Add(lblBarcode, 0, 0);
            tableLayoutPanel2.Controls.Add(lblProdName, 1, 0);
            tableLayoutPanel2.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            tableLayoutPanel2.Location = new Point(45, 83);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.Padding = new Padding(15);
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1004, 64);
            tableLayoutPanel2.TabIndex = 87;
            // 
            // lblBuy
            // 
            lblBuy.Anchor = AnchorStyles.None;
            lblBuy.AutoSize = true;
            lblBuy.BackColor = Color.FromArgb(78, 104, 133);
            lblBuy.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            lblBuy.ForeColor = Color.White;
            lblBuy.Location = new Point(694, 17);
            lblBuy.Margin = new Padding(0);
            lblBuy.Name = "lblBuy";
            lblBuy.Size = new Size(0, 30);
            lblBuy.TabIndex = 3;
            // 
            // lblStock
            // 
            lblStock.Anchor = AnchorStyles.None;
            lblStock.AutoSize = true;
            lblStock.BackColor = Color.FromArgb(78, 104, 133);
            lblStock.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            lblStock.ForeColor = Color.White;
            lblStock.Location = new Point(500, 17);
            lblStock.Margin = new Padding(0);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(0, 30);
            lblStock.TabIndex = 2;
            // 
            // lblSell
            // 
            lblSell.Anchor = AnchorStyles.None;
            lblSell.AutoSize = true;
            lblSell.BackColor = Color.FromArgb(78, 104, 133);
            lblSell.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            lblSell.ForeColor = Color.White;
            lblSell.Location = new Point(890, 17);
            lblSell.Margin = new Padding(0);
            lblSell.Name = "lblSell";
            lblSell.Size = new Size(0, 30);
            lblSell.TabIndex = 4;
            // 
            // lblBarcode
            // 
            lblBarcode.Anchor = AnchorStyles.None;
            lblBarcode.AutoSize = true;
            lblBarcode.BackColor = Color.FromArgb(78, 104, 133);
            lblBarcode.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            lblBarcode.ForeColor = Color.White;
            lblBarcode.Location = new Point(112, 17);
            lblBarcode.Margin = new Padding(0);
            lblBarcode.Name = "lblBarcode";
            lblBarcode.Size = new Size(0, 30);
            lblBarcode.TabIndex = 0;
            // 
            // lblProdName
            // 
            lblProdName.Anchor = AnchorStyles.None;
            lblProdName.AutoSize = true;
            lblProdName.BackColor = Color.FromArgb(78, 104, 133);
            lblProdName.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            lblProdName.ForeColor = Color.White;
            lblProdName.Location = new Point(306, 17);
            lblProdName.Margin = new Padding(0);
            lblProdName.Name = "lblProdName";
            lblProdName.Size = new Size(0, 30);
            lblProdName.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Location = new Point(254, 30);
            panel2.Name = "panel2";
            panel2.Size = new Size(1, 30);
            panel2.TabIndex = 88;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Location = new Point(448, 30);
            panel3.Name = "panel3";
            panel3.Size = new Size(1, 30);
            panel3.TabIndex = 89;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Location = new Point(642, 30);
            panel4.Name = "panel4";
            panel4.Size = new Size(1, 30);
            panel4.TabIndex = 90;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Location = new Point(836, 30);
            panel5.Name = "panel5";
            panel5.Size = new Size(1, 30);
            panel5.TabIndex = 91;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Location = new Point(848, 170);
            panel6.Name = "panel6";
            panel6.Size = new Size(1, 30);
            panel6.TabIndex = 96;
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.Location = new Point(654, 170);
            panel7.Name = "panel7";
            panel7.Size = new Size(1, 30);
            panel7.TabIndex = 95;
            // 
            // panel8
            // 
            panel8.BackColor = Color.White;
            panel8.Location = new Point(460, 170);
            panel8.Name = "panel8";
            panel8.Size = new Size(1, 30);
            panel8.TabIndex = 94;
            // 
            // panel9
            // 
            panel9.BackColor = Color.White;
            panel9.Location = new Point(266, 170);
            panel9.Name = "panel9";
            panel9.Size = new Size(1, 30);
            panel9.TabIndex = 93;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(0, 74, 173);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(336, 271);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(152, 36);
            textBox1.TabIndex = 97;
            textBox1.Text = "0";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(49, 121, 199);
            label1.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(199, 272);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(134, 37);
            label1.TabIndex = 98;
            label1.Text = "STOK GİR";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources._32pxWhitePlus;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Location = new Point(452, 273);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(36, 36);
            pictureBox1.TabIndex = 99;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = Properties.Resources._32pxWhiteMinus;
            pictureBox2.BackgroundImageLayout = ImageLayout.Center;
            pictureBox2.Location = new Point(336, 273);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(36, 36);
            pictureBox2.TabIndex = 100;
            pictureBox2.TabStop = false;
            // 
            // lblBuying
            // 
            lblBuying.Anchor = AnchorStyles.None;
            lblBuying.AutoSize = true;
            lblBuying.BackColor = Color.FromArgb(49, 121, 199);
            lblBuying.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            lblBuying.ForeColor = Color.White;
            lblBuying.Location = new Point(605, 271);
            lblBuying.Margin = new Padding(0, 20, 0, 0);
            lblBuying.Name = "lblBuying";
            lblBuying.Size = new Size(158, 37);
            lblBuying.TabIndex = 102;
            lblBuying.Text = "Alış Rakamı";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(49, 121, 199);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            textBox2.ForeColor = Color.White;
            textBox2.Location = new Point(792, 271);
            textBox2.Margin = new Padding(15, 3, 3, 3);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(152, 36);
            textBox2.TabIndex = 101;
            textBox2.Text = "0";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // lblSelling
            // 
            lblSelling.Anchor = AnchorStyles.None;
            lblSelling.AutoSize = true;
            lblSelling.BackColor = Color.FromArgb(49, 121, 199);
            lblSelling.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            lblSelling.ForeColor = Color.White;
            lblSelling.Location = new Point(605, 328);
            lblSelling.Margin = new Padding(0, 20, 0, 0);
            lblSelling.Name = "lblSelling";
            lblSelling.Size = new Size(172, 37);
            lblSelling.TabIndex = 104;
            lblSelling.Text = "Satış Rakamı";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(49, 121, 199);
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            textBox3.ForeColor = Color.White;
            textBox3.Location = new Point(792, 328);
            textBox3.Margin = new Padding(15, 3, 3, 3);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(152, 36);
            textBox3.TabIndex = 103;
            textBox3.Text = "0";
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // lblChooseSupp
            // 
            lblChooseSupp.Anchor = AnchorStyles.None;
            lblChooseSupp.AutoSize = true;
            lblChooseSupp.BackColor = Color.FromArgb(49, 121, 199);
            lblChooseSupp.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            lblChooseSupp.ForeColor = Color.White;
            lblChooseSupp.Location = new Point(605, 385);
            lblChooseSupp.Margin = new Padding(0, 20, 0, 0);
            lblChooseSupp.Name = "lblChooseSupp";
            lblChooseSupp.Size = new Size(170, 37);
            lblChooseSupp.TabIndex = 106;
            lblChooseSupp.Text = "Toptancı Seç";
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.BackColor = Color.FromArgb(255, 59, 59);
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold);
            btnCancel.ForeColor = Color.White;
            btnCancel.Image = Properties.Resources._64pxWhiteX50Scale1;
            btnCancel.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancel.Location = new Point(199, 343);
            btnCancel.Margin = new Padding(10);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(169, 79);
            btnCancel.TabIndex = 108;
            btnCancel.Text = "  İPTAL      ";
            btnCancel.TextAlign = ContentAlignment.MiddleRight;
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.BackColor = Color.FromArgb(66, 178, 38);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSave.ForeColor = Color.White;
            btnSave.Image = Properties.Resources._64pxGreenCheck;
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(388, 343);
            btnSave.Margin = new Padding(10);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(169, 79);
            btnSave.TabIndex = 107;
            btnSave.Text = "KAYDET  ";
            btnSave.TextAlign = ContentAlignment.MiddleRight;
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click_1;
            // 
            // panel10
            // 
            panel10.BackColor = Color.FromArgb(49, 121, 199);
            panel10.Location = new Point(605, 271);
            panel10.Name = "panel10";
            panel10.Size = new Size(172, 37);
            panel10.TabIndex = 109;
            // 
            // panel11
            // 
            panel11.BackColor = Color.FromArgb(49, 121, 199);
            panel11.Location = new Point(605, 385);
            panel11.Name = "panel11";
            panel11.Size = new Size(172, 37);
            panel11.TabIndex = 110;
            // 
            // fcPaymentType
            // 
            fcPaymentType.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            fcPaymentType.BackColor = Color.FromArgb(49, 121, 199);
            fcPaymentType.BorderColor = Color.FromArgb(49, 121, 199);
            fcPaymentType.ButtonColor = Color.White;
            fcPaymentType.DrawMode = DrawMode.OwnerDrawFixed;
            fcPaymentType.DropDownStyle = ComboBoxStyle.DropDownList;
            fcPaymentType.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            fcPaymentType.ForeColor = Color.White;
            fcPaymentType.FormattingEnabled = true;
            fcPaymentType.HighlightColor = Color.FromArgb(49, 121, 199);
            fcPaymentType.Location = new Point(792, 385);
            fcPaymentType.Margin = new Padding(1);
            fcPaymentType.Name = "fcPaymentType";
            fcPaymentType.Size = new Size(155, 37);
            fcPaymentType.TabIndex = 111;
            // 
            // AddStocksInnerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 74, 173);
            ClientSize = new Size(1118, 532);
            Controls.Add(fcPaymentType);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(lblChooseSupp);
            Controls.Add(lblSelling);
            Controls.Add(textBox3);
            Controls.Add(lblBuying);
            Controls.Add(textBox2);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(panel6);
            Controls.Add(panel7);
            Controls.Add(panel8);
            Controls.Add(panel9);
            Controls.Add(panel1);
            Controls.Add(pbClearSearch);
            Controls.Add(pbMagGlass);
            Controls.Add(rtbSearch);
            Controls.Add(panel11);
            Controls.Add(panel10);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddStocksInnerForm";
            Text = "AddSupplierReportForm";
            Load += AddCustomerReportForm_Load;
            ((System.ComponentModel.ISupportInitialize)pbClearSearch).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbMagGlass).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pbClearSearch;
        private PictureBox pbMagGlass;
        private CustomObjects.RoundTextBox rtbSearch;
        private Label lblBarcodeS;
        private Label lblProductS;
        private Label lblStockS;
        private Label lblBuyS;
        private Label lblSellS;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label lblBuy;
        private Label lblStock;
        private Label lblSell;
        private Label lblBarcode;
        private Label lblProdName;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private Panel panel6;
        private Panel panel7;
        private Panel panel8;
        private Panel panel9;
        private TextBox textBox1;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label lblBuying;
        private TextBox textBox2;
        private Label lblSelling;
        private TextBox textBox3;
        private Label lblChooseSupp;
        private Button btnCancel;
        private Button btnSave;
        private Panel panel10;
        private Panel panel11;
        private CustomObjects.FlatCombo fcPaymentType;
    }
}