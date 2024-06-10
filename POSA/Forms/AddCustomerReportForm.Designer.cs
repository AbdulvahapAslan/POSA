namespace POSA.Forms
{
    partial class AddCustomerReportForm
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
            panel1 = new Panel();
            pnlDepthAmount = new Panel();
            btnCancel = new Button();
            btnSave = new Button();
            tbDepth = new TextBox();
            dgvMain = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            NAME = new DataGridViewTextBoxColumn();
            PHONE = new DataGridViewTextBoxColumn();
            DEPTH = new DataGridViewTextBoxColumn();
            cbShowAll = new CheckBox();
            cbShowDepths = new CheckBox();
            pbClearSearch = new PictureBox();
            pbMagGlass = new PictureBox();
            rtbSearch = new CustomObjects.RoundTextBox();
            panel1.SuspendLayout();
            pnlDepthAmount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMain).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbClearSearch).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbMagGlass).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pnlDepthAmount);
            panel1.Controls.Add(dgvMain);
            panel1.Location = new Point(12, 65);
            panel1.Margin = new Padding(3, 3, 12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1085, 446);
            panel1.TabIndex = 0;
            // 
            // pnlDepthAmount
            // 
            pnlDepthAmount.BackgroundImage = Properties.Resources.BackgroundSmall1;
            pnlDepthAmount.BackgroundImageLayout = ImageLayout.Stretch;
            pnlDepthAmount.Controls.Add(btnCancel);
            pnlDepthAmount.Controls.Add(btnSave);
            pnlDepthAmount.Controls.Add(tbDepth);
            pnlDepthAmount.Location = new Point(405, 179);
            pnlDepthAmount.Name = "pnlDepthAmount";
            pnlDepthAmount.Size = new Size(273, 77);
            pnlDepthAmount.TabIndex = 77;
            pnlDepthAmount.Visible = false;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(255, 59, 59);
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            btnCancel.ForeColor = Color.White;
            btnCancel.Image = Properties.Resources._32pxWhiteX;
            btnCancel.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancel.Location = new Point(3, 39);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(132, 35);
            btnCancel.TabIndex = 77;
            btnCancel.Text = "İPTAL   ";
            btnCancel.TextAlign = ContentAlignment.MiddleRight;
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(66, 178, 38);
            btnSave.DialogResult = DialogResult.OK;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Image = Properties.Resources._32pxTick;
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(138, 39);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(132, 35);
            btnSave.TabIndex = 76;
            btnSave.Text = "KAYDET ";
            btnSave.TextAlign = ContentAlignment.MiddleRight;
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // tbDepth
            // 
            tbDepth.BorderStyle = BorderStyle.None;
            tbDepth.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            tbDepth.Location = new Point(3, 3);
            tbDepth.Name = "tbDepth";
            tbDepth.Size = new Size(267, 32);
            tbDepth.TabIndex = 4;
            tbDepth.KeyDown += tbDepth_KeyDown;
            tbDepth.KeyPress += tbDepth_KeyPress;
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
            dgvMain.Columns.AddRange(new DataGridViewColumn[] { ID, NAME, PHONE, DEPTH });
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
            dgvMain.Size = new Size(1065, 426);
            dgvMain.TabIndex = 76;
            dgvMain.CellClick += dgvMain_CellClick;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.Visible = false;
            // 
            // NAME
            // 
            NAME.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NAME.DataPropertyName = "NAME";
            NAME.FillWeight = 35F;
            NAME.HeaderText = "AD SOYAD";
            NAME.MaxInputLength = 100;
            NAME.Name = "NAME";
            NAME.ReadOnly = true;
            // 
            // PHONE
            // 
            PHONE.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            PHONE.DataPropertyName = "PHONE";
            PHONE.FillWeight = 20F;
            PHONE.HeaderText = "TELEFON";
            PHONE.MaxInputLength = 50;
            PHONE.Name = "PHONE";
            PHONE.ReadOnly = true;
            // 
            // DEPTH
            // 
            DEPTH.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DEPTH.DataPropertyName = "DEPTH";
            DEPTH.FillWeight = 20F;
            DEPTH.HeaderText = "BORÇ";
            DEPTH.Name = "DEPTH";
            // 
            // cbShowAll
            // 
            cbShowAll.AutoSize = true;
            cbShowAll.Checked = true;
            cbShowAll.CheckState = CheckState.Checked;
            cbShowAll.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            cbShowAll.ForeColor = Color.White;
            cbShowAll.Location = new Point(728, 30);
            cbShowAll.Name = "cbShowAll";
            cbShowAll.Size = new Size(170, 29);
            cbShowAll.TabIndex = 1;
            cbShowAll.Text = "Tümünü Göster";
            cbShowAll.UseVisualStyleBackColor = true;
            cbShowAll.CheckedChanged += cbShowAll_CheckedChanged;
            // 
            // cbShowDepths
            // 
            cbShowDepths.AutoSize = true;
            cbShowDepths.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            cbShowDepths.ForeColor = Color.White;
            cbShowDepths.Location = new Point(904, 30);
            cbShowDepths.Name = "cbShowDepths";
            cbShowDepths.Size = new Size(181, 29);
            cbShowDepths.TabIndex = 2;
            cbShowDepths.Text = "Borçluları Göster";
            cbShowDepths.UseVisualStyleBackColor = true;
            cbShowDepths.CheckedChanged += cbShowDepths_CheckedChanged;
            // 
            // pbClearSearch
            // 
            pbClearSearch.BackColor = Color.White;
            pbClearSearch.BackgroundImage = Properties.Resources._16pxCloseBlack;
            pbClearSearch.BackgroundImageLayout = ImageLayout.Center;
            pbClearSearch.Location = new Point(248, 29);
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
            pbMagGlass.Location = new Point(17, 29);
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
            rtbSearch.Location = new Point(13, 25);
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
            // AddCustomerReportForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(0, 74, 173);
            ClientSize = new Size(1118, 532);
            Controls.Add(pbClearSearch);
            Controls.Add(pbMagGlass);
            Controls.Add(rtbSearch);
            Controls.Add(cbShowDepths);
            Controls.Add(cbShowAll);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddCustomerReportForm";
            Text = "AddSupplierReportForm";
            Load += AddCustomerReportForm_Load;
            panel1.ResumeLayout(false);
            pnlDepthAmount.ResumeLayout(false);
            pnlDepthAmount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMain).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbClearSearch).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbMagGlass).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private DataGridView dgvMain;
        private CheckBox cbShowAll;
        private CheckBox cbShowDepths;
        private PictureBox pbClearSearch;
        private PictureBox pbMagGlass;
        private CustomObjects.RoundTextBox rtbSearch;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn NAME;
        private DataGridViewTextBoxColumn PHONE;
        private DataGridViewTextBoxColumn DEPTH;
        private Panel pnlDepthAmount;
        private TextBox tbDepth;
        private Button btnCancel;
        private Button btnSave;
    }
}