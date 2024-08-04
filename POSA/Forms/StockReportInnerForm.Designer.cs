namespace POSA.Forms
{
    partial class StockReportInnerForm
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
            panel4 = new Panel();
            fcCategory = new CustomObjects.FlatCombo();
            lblProductCategory = new Label();
            panel5 = new Panel();
            textBox1 = new TextBox();
            label2 = new Label();
            btnExcel = new Button();
            pnlGrid = new Panel();
            dgvMain = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            BARCODE = new DataGridViewTextBoxColumn();
            NAME = new DataGridViewTextBoxColumn();
            QUANTITY = new DataGridViewTextBoxColumn();
            BUYPRICE = new DataGridViewTextBoxColumn();
            SALEPRICE = new DataGridViewTextBoxColumn();
            TOTAL = new DataGridViewTextBoxColumn();
            SUPPLIER = new DataGridViewTextBoxColumn();
            BRANCH = new DataGridViewTextBoxColumn();
            label9 = new Label();
            textBox10 = new TextBox();
            label10 = new Label();
            label8 = new Label();
            textBox11 = new TextBox();
            textBox9 = new TextBox();
            panel10 = new Panel();
            panel1 = new Panel();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            flatCombo1 = new CustomObjects.FlatCombo();
            label6 = new Label();
            fcFilter = new CustomObjects.FlatCombo();
            label5 = new Label();
            tglCountMode = new CustomObjects.AvpToggle();
            panel3 = new Panel();
            lblCountMode = new Label();
            CMPanel = new Panel();
            checkBox1 = new CheckBox();
            btnApply = new Button();
            btnClear = new Button();
            dataGridView1 = new DataGridView();
            CMBARCODE = new DataGridViewTextBoxColumn();
            CMCheckBox = new DataGridViewCheckBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn10 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn11 = new DataGridViewTextBoxColumn();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMain).BeginInit();
            panel10.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            CMPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(84, 116, 173);
            panel4.Controls.Add(fcCategory);
            panel4.Controls.Add(lblProductCategory);
            panel4.Location = new Point(12, 12);
            panel4.Name = "panel4";
            panel4.Size = new Size(230, 52);
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
            fcCategory.Size = new Size(224, 24);
            fcCategory.TabIndex = 1;
            // 
            // lblProductCategory
            // 
            lblProductCategory.AutoSize = true;
            lblProductCategory.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblProductCategory.ForeColor = Color.White;
            lblProductCategory.Location = new Point(62, 1);
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
            panel5.Location = new Point(250, 12);
            panel5.Name = "panel5";
            panel5.Size = new Size(244, 52);
            panel5.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            textBox1.Location = new Point(3, 23);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(238, 22);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.White;
            label2.Location = new Point(82, 1);
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
            btnExcel.Location = new Point(17, 128);
            btnExcel.Margin = new Padding(10);
            btnExcel.Name = "btnExcel";
            btnExcel.Size = new Size(52, 52);
            btnExcel.TabIndex = 115;
            btnExcel.UseVisualStyleBackColor = false;
            // 
            // pnlGrid
            // 
            pnlGrid.BackColor = Color.White;
            pnlGrid.Controls.Add(dgvMain);
            pnlGrid.Location = new Point(12, 229);
            pnlGrid.Margin = new Padding(3, 3, 12, 12);
            pnlGrid.Name = "pnlGrid";
            pnlGrid.Size = new Size(1226, 358);
            pnlGrid.TabIndex = 117;
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
            dgvMain.Columns.AddRange(new DataGridViewColumn[] { ID, BARCODE, NAME, QUANTITY, BUYPRICE, SALEPRICE, TOTAL, SUPPLIER, BRANCH });
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
            dgvMain.RowTemplate.DefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvMain.RowTemplate.DefaultCellStyle.ForeColor = Color.FromArgb(1, 39, 103);
            dgvMain.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(109, 134, 176);
            dgvMain.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvMain.RowTemplate.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvMain.RowTemplate.DividerHeight = 10;
            dgvMain.RowTemplate.Height = 40;
            dgvMain.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMain.Size = new Size(1206, 338);
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
            // QUANTITY
            // 
            QUANTITY.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            QUANTITY.DataPropertyName = "QUANTITY";
            QUANTITY.FillWeight = 10F;
            QUANTITY.HeaderText = "ADET";
            QUANTITY.Name = "QUANTITY";
            // 
            // BUYPRICE
            // 
            BUYPRICE.DataPropertyName = "BUYPRICE";
            BUYPRICE.HeaderText = "ALIŞ FİYAT";
            BUYPRICE.Name = "BUYPRICE";
            // 
            // SALEPRICE
            // 
            SALEPRICE.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SALEPRICE.DataPropertyName = "SALEPRICE";
            SALEPRICE.FillWeight = 10F;
            SALEPRICE.HeaderText = "SATIŞ FİYAT";
            SALEPRICE.Name = "SALEPRICE";
            // 
            // TOTAL
            // 
            TOTAL.DataPropertyName = "TOTAL";
            TOTAL.HeaderText = "TOPLAM TUTAR";
            TOTAL.Name = "TOTAL";
            // 
            // SUPPLIER
            // 
            SUPPLIER.DataPropertyName = "SUPPLIER";
            SUPPLIER.HeaderText = "TOPTANCI";
            SUPPLIER.Name = "SUPPLIER";
            // 
            // BRANCH
            // 
            BRANCH.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            BRANCH.DataPropertyName = "BRANCH";
            BRANCH.FillWeight = 15F;
            BRANCH.HeaderText = "ŞUBE";
            BRANCH.Name = "BRANCH";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label9.ForeColor = Color.White;
            label9.Location = new Point(3, 46);
            label9.Name = "label9";
            label9.Size = new Size(257, 21);
            label9.TabIndex = 14;
            label9.Text = "ALIŞ FİYATINDAN TOPLAM DEĞER";
            // 
            // textBox10
            // 
            textBox10.BackColor = Color.White;
            textBox10.BorderStyle = BorderStyle.None;
            textBox10.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            textBox10.ForeColor = Color.Black;
            textBox10.Location = new Point(266, 41);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(211, 32);
            textBox10.TabIndex = 15;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label10.ForeColor = Color.White;
            label10.Location = new Point(3, 8);
            label10.Name = "label10";
            label10.Size = new Size(114, 21);
            label10.TabIndex = 12;
            label10.Text = "KAYITLI ÜRÜN";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label8.ForeColor = Color.White;
            label8.Location = new Point(3, 85);
            label8.Name = "label8";
            label8.Size = new Size(266, 21);
            label8.TabIndex = 16;
            label8.Text = "SATIŞ FİYATINDAN TOPLAM DEĞER";
            // 
            // textBox11
            // 
            textBox11.BackColor = Color.White;
            textBox11.BorderStyle = BorderStyle.None;
            textBox11.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            textBox11.ForeColor = Color.Black;
            textBox11.Location = new Point(266, 3);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(211, 32);
            textBox11.TabIndex = 13;
            // 
            // textBox9
            // 
            textBox9.BackColor = Color.White;
            textBox9.BorderStyle = BorderStyle.None;
            textBox9.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            textBox9.ForeColor = Color.Black;
            textBox9.Location = new Point(266, 79);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(211, 32);
            textBox9.TabIndex = 17;
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
            panel10.Location = new Point(12, 70);
            panel10.Name = "panel10";
            panel10.Size = new Size(482, 115);
            panel10.TabIndex = 120;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(84, 116, 173);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnExcel);
            panel1.Location = new Point(500, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(89, 211);
            panel1.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.ForeColor = Color.White;
            label4.Location = new Point(20, 67);
            label4.Name = "label4";
            label4.Size = new Size(49, 21);
            label4.TabIndex = 117;
            label4.Text = "Aktar";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.White;
            label3.Location = new Point(16, 43);
            label3.Name = "label3";
            label3.Size = new Size(60, 21);
            label3.TabIndex = 116;
            label3.Text = "Excel'e";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.White;
            label1.Location = new Point(1, 22);
            label1.Name = "label1";
            label1.Size = new Size(85, 21);
            label1.TabIndex = 2;
            label1.Text = "Seçilenleri";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(84, 116, 173);
            panel2.Controls.Add(flatCombo1);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(fcFilter);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(970, 171);
            panel2.Name = "panel2";
            panel2.Size = new Size(259, 32);
            panel2.TabIndex = 121;
            // 
            // flatCombo1
            // 
            flatCombo1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            flatCombo1.BackColor = Color.FromArgb(84, 116, 173);
            flatCombo1.BorderColor = Color.White;
            flatCombo1.ButtonColor = Color.FromArgb(84, 116, 173);
            flatCombo1.DrawMode = DrawMode.OwnerDrawFixed;
            flatCombo1.DropDownStyle = ComboBoxStyle.DropDownList;
            flatCombo1.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            flatCombo1.ForeColor = Color.White;
            flatCombo1.FormattingEnabled = true;
            flatCombo1.HighlightColor = Color.FromArgb(84, 116, 173);
            flatCombo1.Items.AddRange(new object[] { "YOK", "ÇOK SATANLAR", "ÇOK BULUNAN", "FİYAT (ARTAN)", "FİYAT (AZALAN)", "BARKOD (ARTAN)", "BARKOD (AZALAN)", "İSİM (A - Z)", "İSİM (Z - A)" });
            flatCombo1.Location = new Point(58, 0);
            flatCombo1.Margin = new Padding(1);
            flatCombo1.Name = "flatCombo1";
            flatCombo1.Size = new Size(200, 32);
            flatCombo1.TabIndex = 116;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(84, 116, 173);
            label6.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(0, 3);
            label6.Margin = new Padding(0, 0, 10, 0);
            label6.Name = "label6";
            label6.Size = new Size(55, 25);
            label6.TabIndex = 115;
            label6.Text = "Filtre";
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
            fcFilter.Location = new Point(117, -68);
            fcFilter.Margin = new Padding(1);
            fcFilter.Name = "fcFilter";
            fcFilter.Size = new Size(200, 32);
            fcFilter.TabIndex = 114;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(49, 121, 199);
            label5.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(29, -31);
            label5.Margin = new Padding(0, 0, 10, 0);
            label5.Name = "label5";
            label5.Size = new Size(55, 25);
            label5.TabIndex = 111;
            label5.Text = "Filtre";
            // 
            // tglCountMode
            // 
            tglCountMode.AutoSize = true;
            tglCountMode.Location = new Point(393, 16);
            tglCountMode.MinimumSize = new Size(45, 22);
            tglCountMode.Name = "tglCountMode";
            tglCountMode.OffBackColor = Color.Red;
            tglCountMode.OffToggleColor = Color.White;
            tglCountMode.OnBackColor = Color.FromArgb(0, 140, 71);
            tglCountMode.OnToggleColor = Color.White;
            tglCountMode.Size = new Size(45, 22);
            tglCountMode.TabIndex = 122;
            tglCountMode.UseVisualStyleBackColor = true;
            tglCountMode.CheckedChanged += tglCountMode_CheckedChanged;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(lblCountMode);
            panel3.Controls.Add(tglCountMode);
            panel3.Location = new Point(663, 24);
            panel3.Name = "panel3";
            panel3.Size = new Size(574, 52);
            panel3.TabIndex = 123;
            // 
            // lblCountMode
            // 
            lblCountMode.AutoSize = true;
            lblCountMode.Font = new Font("Segoe UI Semibold", 22F, FontStyle.Bold);
            lblCountMode.ForeColor = Color.Red;
            lblCountMode.Location = new Point(179, 6);
            lblCountMode.Name = "lblCountMode";
            lblCountMode.Size = new Size(208, 41);
            lblCountMode.TabIndex = 0;
            lblCountMode.Text = "SAYIM MODU";
            // 
            // CMPanel
            // 
            CMPanel.BackColor = Color.FromArgb(84, 116, 173);
            CMPanel.Controls.Add(checkBox1);
            CMPanel.Controls.Add(btnApply);
            CMPanel.Controls.Add(btnClear);
            CMPanel.Controls.Add(dataGridView1);
            CMPanel.Location = new Point(663, 74);
            CMPanel.Name = "CMPanel";
            CMPanel.Size = new Size(575, 514);
            CMPanel.TabIndex = 124;
            CMPanel.Visible = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            checkBox1.ForeColor = Color.White;
            checkBox1.Location = new Point(10, 21);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(105, 23);
            checkBox1.TabIndex = 121;
            checkBox1.Text = "Tümünü Seç";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnApply
            // 
            btnApply.BackColor = Color.FromArgb(0, 140, 71);
            btnApply.DialogResult = DialogResult.OK;
            btnApply.FlatAppearance.BorderSize = 0;
            btnApply.FlatStyle = FlatStyle.Flat;
            btnApply.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnApply.ForeColor = Color.White;
            btnApply.ImageAlign = ContentAlignment.MiddleLeft;
            btnApply.Location = new Point(438, 449);
            btnApply.Name = "btnApply";
            btnApply.Size = new Size(129, 54);
            btnApply.TabIndex = 119;
            btnApply.Text = "UYGULA";
            btnApply.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Red;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(303, 449);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(129, 54);
            btnClear.TabIndex = 120;
            btnClear.Text = "TEMİZLE";
            btnClear.UseVisualStyleBackColor = false;
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
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(1, 39, 103);
            dataGridViewCellStyle3.SelectionBackColor = Color.White;
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(1, 39, 103);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.ColumnHeadersHeight = 50;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { CMBARCODE, CMCheckBox, dataGridViewTextBoxColumn8, dataGridViewTextBoxColumn9, dataGridViewTextBoxColumn10, dataGridViewTextBoxColumn11 });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 162);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(1, 39, 103);
            dataGridViewCellStyle4.SelectionBackColor = Color.White;
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(1, 39, 103);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.White;
            dataGridView1.Location = new Point(10, 51);
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
            dataGridView1.Size = new Size(557, 385);
            dataGridView1.TabIndex = 77;
            // 
            // CMBARCODE
            // 
            CMBARCODE.DataPropertyName = "BARCODE";
            CMBARCODE.HeaderText = "BARCODE";
            CMBARCODE.Name = "CMBARCODE";
            CMBARCODE.Visible = false;
            // 
            // CMCheckBox
            // 
            CMCheckBox.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CMCheckBox.FillWeight = 7F;
            CMCheckBox.HeaderText = "";
            CMCheckBox.Name = "CMCheckBox";
            CMCheckBox.Resizable = DataGridViewTriState.True;
            CMCheckBox.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn8.DataPropertyName = "TOTAL";
            dataGridViewTextBoxColumn8.FillWeight = 63F;
            dataGridViewTextBoxColumn8.HeaderText = "ÜRÜN";
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewTextBoxColumn9.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn9.DataPropertyName = "PROFIT";
            dataGridViewTextBoxColumn9.FillWeight = 10F;
            dataGridViewTextBoxColumn9.HeaderText = "STOK";
            dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            dataGridViewTextBoxColumn10.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn10.DataPropertyName = "PAYMENT";
            dataGridViewTextBoxColumn10.FillWeight = 15F;
            dataGridViewTextBoxColumn10.HeaderText = "YENİ STOK";
            dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            dataGridViewTextBoxColumn11.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn11.FillWeight = 10F;
            dataGridViewTextBoxColumn11.HeaderText = "STOK FARK";
            dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // StockReportInnerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 74, 173);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1249, 600);
            Controls.Add(CMPanel);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel10);
            Controls.Add(pnlGrid);
            Controls.Add(panel5);
            Controls.Add(panel4);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "StockReportInnerForm";
            StartPosition = FormStartPosition.CenterScreen;
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMain).EndInit();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            CMPanel.ResumeLayout(false);
            CMPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel4;
        private CustomObjects.FlatCombo fcCategory;
        private Label lblProductCategory;
        private Panel panel5;
        private Label label2;
        private TextBox textBox1;
        private Button btnExcel;
        private Panel pnlGrid;
        private DataGridView dgvMain;
        private Label label9;
        private TextBox textBox10;
        private Label label10;
        private Label label8;
        private TextBox textBox11;
        private TextBox textBox9;
        private Panel panel10;
        private Panel panel1;
        private Label label4;
        private Label label3;
        private Label label1;
        private Panel panel2;
        private CustomObjects.FlatCombo fcFilter;
        private Label label5;
        private CustomObjects.FlatCombo flatCombo1;
        private Label label6;
        private CustomObjects.AvpToggle tglCountMode;
        private Panel panel3;
        private Label lblCountMode;
        private Panel CMPanel;
        private DataGridView dataGridView1;
        private Button btnApply;
        private Button btnClear;
        private CheckBox checkBox1;
        private DataGridViewTextBoxColumn CMBARCODE;
        private DataGridViewCheckBoxColumn CMCheckBox;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn BARCODE;
        private DataGridViewTextBoxColumn NAME;
        private DataGridViewTextBoxColumn QUANTITY;
        private DataGridViewTextBoxColumn BUYPRICE;
        private DataGridViewTextBoxColumn SALEPRICE;
        private DataGridViewTextBoxColumn TOTAL;
        private DataGridViewTextBoxColumn SUPPLIER;
        private DataGridViewTextBoxColumn BRANCH;
    }
}