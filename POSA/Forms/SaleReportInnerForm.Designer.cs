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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            lblMovement = new Label();
            panel1 = new Panel();
            radioButton4 = new RadioButton();
            radioButton5 = new RadioButton();
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
            fcCategory = new CustomObjects.FlatCombo();
            lblProductCategory = new Label();
            panel5 = new Panel();
            textBox1 = new TextBox();
            label2 = new Label();
            btnExcel = new Button();
            button1 = new Button();
            panel6 = new Panel();
            dgvMain = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            BARCODE = new DataGridViewTextBoxColumn();
            NAME = new DataGridViewTextBoxColumn();
            VATRATE = new DataGridViewTextBoxColumn();
            BUYPRICE = new DataGridViewTextBoxColumn();
            SALEPRICE = new DataGridViewTextBoxColumn();
            STOCK = new DataGridViewTextBoxColumn();
            UNIT = new DataGridViewTextBoxColumn();
            btnCancel = new Button();
            btnBring = new Button();
            panel7 = new Panel();
            textBox2 = new TextBox();
            lblTotal = new Label();
            panel8 = new Panel();
            textBox7 = new TextBox();
            label6 = new Label();
            textBox6 = new TextBox();
            label5 = new Label();
            textBox3 = new TextBox();
            label1 = new Label();
            panel9 = new Panel();
            textBox4 = new TextBox();
            textBox8 = new TextBox();
            label3 = new Label();
            label7 = new Label();
            textBox5 = new TextBox();
            label4 = new Label();
            panel10 = new Panel();
            textBox9 = new TextBox();
            textBox11 = new TextBox();
            label8 = new Label();
            label10 = new Label();
            textBox10 = new TextBox();
            label9 = new Label();
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
            panel1.Controls.Add(radioButton4);
            panel1.Controls.Add(radioButton5);
            panel1.Controls.Add(rbRefund);
            panel1.Controls.Add(rbBuy);
            panel1.Controls.Add(rbSell);
            panel1.Controls.Add(rbAll);
            panel1.Controls.Add(lblMovement);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(158, 193);
            panel1.TabIndex = 1;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            radioButton4.ForeColor = Color.White;
            radioButton4.Location = new Point(9, 160);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(62, 23);
            radioButton4.TabIndex = 6;
            radioButton4.TabStop = true;
            radioButton4.Text = "Tümü";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            radioButton5.ForeColor = Color.White;
            radioButton5.Location = new Point(9, 134);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(55, 23);
            radioButton5.TabIndex = 5;
            radioButton5.TabStop = true;
            radioButton5.Text = "İptal";
            radioButton5.UseVisualStyleBackColor = true;
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
            panel4.Controls.Add(fcCategory);
            panel4.Controls.Add(lblProductCategory);
            panel4.Location = new Point(648, 14);
            panel4.Name = "panel4";
            panel4.Size = new Size(192, 52);
            panel4.TabIndex = 5;
            // 
            // fcCategory
            // 
            fcCategory.BorderColor = Color.White;
            fcCategory.ButtonColor = Color.Black;
            fcCategory.DrawMode = DrawMode.OwnerDrawFixed;
            fcCategory.FormattingEnabled = true;
            fcCategory.Location = new Point(3, 24);
            fcCategory.Name = "fcCategory";
            fcCategory.Size = new Size(186, 24);
            fcCategory.TabIndex = 1;
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
            panel5.Controls.Add(textBox1);
            panel5.Controls.Add(label2);
            panel5.Location = new Point(846, 15);
            panel5.Name = "panel5";
            panel5.Size = new Size(192, 52);
            panel5.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            textBox1.Location = new Point(3, 24);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(186, 22);
            textBox1.TabIndex = 1;
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
            btnExcel.FlatAppearance.BorderSize = 0;
            btnExcel.FlatStyle = FlatStyle.Flat;
            btnExcel.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold);
            btnExcel.ForeColor = Color.White;
            btnExcel.Image = Properties.Resources._64pxGrayExcel;
            btnExcel.Location = new Point(1116, 14);
            btnExcel.Margin = new Padding(10);
            btnExcel.Name = "btnExcel";
            btnExcel.Size = new Size(52, 52);
            btnExcel.TabIndex = 115;
            btnExcel.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Image = Properties.Resources._64pxGrayExcel;
            button1.Location = new Point(1176, 15);
            button1.Margin = new Padding(10);
            button1.Name = "button1";
            button1.Size = new Size(52, 52);
            button1.TabIndex = 116;
            button1.UseVisualStyleBackColor = false;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(dgvMain);
            panel6.Location = new Point(12, 211);
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
            dgvMain.BackgroundColor = Color.White;
            dgvMain.BorderStyle = BorderStyle.None;
            dgvMain.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvMain.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(1, 39, 103);
            dataGridViewCellStyle3.SelectionBackColor = Color.White;
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(1, 39, 103);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvMain.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvMain.ColumnHeadersHeight = 50;
            dgvMain.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvMain.Columns.AddRange(new DataGridViewColumn[] { ID, BARCODE, NAME, VATRATE, BUYPRICE, SALEPRICE, STOCK, UNIT });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 162);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(1, 39, 103);
            dataGridViewCellStyle4.SelectionBackColor = Color.White;
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(1, 39, 103);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvMain.DefaultCellStyle = dataGridViewCellStyle4;
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
            dgvMain.RowTemplate.DefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvMain.RowTemplate.DefaultCellStyle.ForeColor = Color.FromArgb(1, 39, 103);
            dgvMain.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(109, 134, 176);
            dgvMain.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvMain.RowTemplate.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvMain.RowTemplate.DividerHeight = 10;
            dgvMain.RowTemplate.Height = 40;
            dgvMain.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMain.Size = new Size(1206, 314);
            dgvMain.TabIndex = 76;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.Visible = false;
            // 
            // BARCODE
            // 
            BARCODE.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            BARCODE.DataPropertyName = "BARCODE";
            BARCODE.FillWeight = 20F;
            BARCODE.HeaderText = "BARKOD";
            BARCODE.MaxInputLength = 100;
            BARCODE.Name = "BARCODE";
            BARCODE.ReadOnly = true;
            // 
            // NAME
            // 
            NAME.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NAME.DataPropertyName = "NAME";
            NAME.FillWeight = 23F;
            NAME.HeaderText = "ÜRÜN ADI";
            NAME.MaxInputLength = 50;
            NAME.Name = "NAME";
            NAME.ReadOnly = true;
            // 
            // VATRATE
            // 
            VATRATE.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            VATRATE.DataPropertyName = "VATRATE";
            VATRATE.FillWeight = 7F;
            VATRATE.HeaderText = "KDV ORANI";
            VATRATE.Name = "VATRATE";
            // 
            // BUYPRICE
            // 
            BUYPRICE.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            BUYPRICE.DataPropertyName = "BUYPRICE";
            BUYPRICE.FillWeight = 10F;
            BUYPRICE.HeaderText = "ALIŞ";
            BUYPRICE.Name = "BUYPRICE";
            // 
            // SALEPRICE
            // 
            SALEPRICE.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SALEPRICE.DataPropertyName = "SALEPRICE";
            SALEPRICE.FillWeight = 10F;
            SALEPRICE.HeaderText = "SATIŞ";
            SALEPRICE.Name = "SALEPRICE";
            // 
            // STOCK
            // 
            STOCK.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            STOCK.DataPropertyName = "STOCK";
            STOCK.FillWeight = 15F;
            STOCK.HeaderText = "STOK";
            STOCK.Name = "STOCK";
            // 
            // UNIT
            // 
            UNIT.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            UNIT.DataPropertyName = "UNIT";
            UNIT.FillWeight = 15F;
            UNIT.HeaderText = "BİRİM";
            UNIT.Name = "UNIT";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Red;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnCancel.ForeColor = Color.White;
            btnCancel.Image = Properties.Resources._64pxWhiteX50Scale1;
            btnCancel.Location = new Point(1183, 151);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(54, 54);
            btnCancel.TabIndex = 118;
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
            btnBring.Location = new Point(1048, 151);
            btnBring.Name = "btnBring";
            btnBring.Size = new Size(129, 54);
            btnBring.TabIndex = 77;
            btnBring.Text = "Getir";
            btnBring.UseVisualStyleBackColor = false;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(54, 54, 54);
            panel7.Controls.Add(textBox2);
            panel7.Controls.Add(lblTotal);
            panel7.Location = new Point(1048, 71);
            panel7.Name = "panel7";
            panel7.Size = new Size(189, 73);
            panel7.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(0, 140, 71);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            textBox2.ForeColor = Color.White;
            textBox2.Location = new Point(0, 41);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(189, 32);
            textBox2.TabIndex = 1;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            lblTotal.ForeColor = Color.White;
            lblTotal.Location = new Point(42, 1);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(109, 32);
            lblTotal.TabIndex = 0;
            lblTotal.Text = "TOPLAM";
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(54, 54, 54);
            panel8.Controls.Add(textBox7);
            panel8.Controls.Add(label6);
            panel8.Controls.Add(textBox6);
            panel8.Controls.Add(label5);
            panel8.Controls.Add(textBox3);
            panel8.Controls.Add(label1);
            panel8.Location = new Point(176, 71);
            panel8.Name = "panel8";
            panel8.Size = new Size(282, 133);
            panel8.TabIndex = 119;
            // 
            // textBox7
            // 
            textBox7.BackColor = Color.White;
            textBox7.BorderStyle = BorderStyle.None;
            textBox7.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            textBox7.ForeColor = Color.Black;
            textBox7.Location = new Point(112, 88);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(164, 32);
            textBox7.TabIndex = 5;
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
            // textBox6
            // 
            textBox6.BackColor = Color.White;
            textBox6.BorderStyle = BorderStyle.None;
            textBox6.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            textBox6.ForeColor = Color.Black;
            textBox6.Location = new Point(112, 50);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(164, 32);
            textBox6.TabIndex = 3;
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
            // textBox3
            // 
            textBox3.BackColor = Color.White;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            textBox3.ForeColor = Color.Black;
            textBox3.Location = new Point(112, 12);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(164, 32);
            textBox3.TabIndex = 1;
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
            panel9.Controls.Add(textBox4);
            panel9.Controls.Add(textBox8);
            panel9.Controls.Add(label3);
            panel9.Controls.Add(label7);
            panel9.Controls.Add(textBox5);
            panel9.Controls.Add(label4);
            panel9.Location = new Point(464, 71);
            panel9.Name = "panel9";
            panel9.Size = new Size(282, 133);
            panel9.TabIndex = 120;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.White;
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            textBox4.ForeColor = Color.Black;
            textBox4.Location = new Point(112, 88);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(164, 32);
            textBox4.TabIndex = 11;
            // 
            // textBox8
            // 
            textBox8.BackColor = Color.White;
            textBox8.BorderStyle = BorderStyle.None;
            textBox8.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            textBox8.ForeColor = Color.Black;
            textBox8.Location = new Point(112, 12);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(164, 32);
            textBox8.TabIndex = 7;
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
            // textBox5
            // 
            textBox5.BackColor = Color.White;
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            textBox5.ForeColor = Color.Black;
            textBox5.Location = new Point(112, 50);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(164, 32);
            textBox5.TabIndex = 9;
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
            panel10.Controls.Add(textBox9);
            panel10.Controls.Add(textBox11);
            panel10.Controls.Add(label8);
            panel10.Controls.Add(label10);
            panel10.Controls.Add(textBox10);
            panel10.Controls.Add(label9);
            panel10.Location = new Point(752, 71);
            panel10.Name = "panel10";
            panel10.Size = new Size(286, 133);
            panel10.TabIndex = 120;
            // 
            // textBox9
            // 
            textBox9.BackColor = Color.White;
            textBox9.BorderStyle = BorderStyle.None;
            textBox9.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            textBox9.ForeColor = Color.Black;
            textBox9.Location = new Point(112, 88);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(164, 32);
            textBox9.TabIndex = 17;
            // 
            // textBox11
            // 
            textBox11.BackColor = Color.White;
            textBox11.BorderStyle = BorderStyle.None;
            textBox11.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            textBox11.ForeColor = Color.Black;
            textBox11.Location = new Point(112, 12);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(164, 32);
            textBox11.TabIndex = 13;
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
            // textBox10
            // 
            textBox10.BackColor = Color.White;
            textBox10.BorderStyle = BorderStyle.None;
            textBox10.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            textBox10.ForeColor = Color.Black;
            textBox10.Location = new Point(112, 50);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(164, 32);
            textBox10.TabIndex = 15;
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
            // SaleReportInnerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 74, 173);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1249, 553);
            Controls.Add(panel10);
            Controls.Add(panel9);
            Controls.Add(panel8);
            Controls.Add(panel7);
            Controls.Add(btnBring);
            Controls.Add(btnCancel);
            Controls.Add(panel6);
            Controls.Add(button1);
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
        private RadioButton radioButton4;
        private Panel panel2;
        private Label lblDates;
        private DateTimePicker dtpEnd;
        private DateTimePicker dtpBegin;
        private Label lblDash;
        private Panel panel3;
        private Label lblPaymentType;
        private CustomObjects.FlatCombo fcPaymentType;
        private Panel panel4;
        private CustomObjects.FlatCombo fcCategory;
        private Label lblProductCategory;
        private Panel panel5;
        private Label label2;
        private TextBox textBox1;
        private Button btnExcel;
        private Button button1;
        private Panel panel6;
        private DataGridView dgvMain;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn BARCODE;
        private DataGridViewTextBoxColumn NAME;
        private DataGridViewTextBoxColumn VATRATE;
        private DataGridViewTextBoxColumn BUYPRICE;
        private DataGridViewTextBoxColumn SALEPRICE;
        private DataGridViewTextBoxColumn STOCK;
        private DataGridViewTextBoxColumn UNIT;
        private Button btnCancel;
        private Button btnBring;
        private Panel panel7;
        private TextBox textBox2;
        private Label lblTotal;
        private Panel panel8;
        private TextBox textBox3;
        private Label label1;
        private Panel panel9;
        private Panel panel10;
        private TextBox textBox7;
        private Label label6;
        private TextBox textBox6;
        private Label label5;
        private TextBox textBox4;
        private TextBox textBox8;
        private Label label3;
        private Label label7;
        private TextBox textBox5;
        private Label label4;
        private TextBox textBox9;
        private TextBox textBox11;
        private Label label8;
        private Label label10;
        private TextBox textBox10;
        private Label label9;
    }
}