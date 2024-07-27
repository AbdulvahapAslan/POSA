namespace POSA.Forms
{
    partial class AddExpense
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            btnSave = new Button();
            dgvMain = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            BID = new DataGridViewTextBoxColumn();
            COST = new DataGridViewTextBoxColumn();
            BRANCH = new DataGridViewTextBoxColumn();
            DATE = new DataGridViewTextBoxColumn();
            DESCRIPTION = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            pbClearSearch = new PictureBox();
            pictureBox3 = new PictureBox();
            rtbSearch = new CustomObjects.RoundTextBox();
            tbDescription = new TextBox();
            lblProductName = new Label();
            lblBranch = new Label();
            tbCost = new TextBox();
            lblAddress = new Label();
            cbBranch = new ComboBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvMain).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbClearSearch).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.LightGreen;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSave.ForeColor = Color.Black;
            btnSave.ImageAlign = ContentAlignment.TopCenter;
            btnSave.Location = new Point(136, 258);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(260, 33);
            btnSave.TabIndex = 74;
            btnSave.Text = "EKLE";
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
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(1, 39, 103);
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(1, 39, 103);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvMain.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvMain.ColumnHeadersHeight = 50;
            dgvMain.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvMain.Columns.AddRange(new DataGridViewColumn[] { ID, BID, COST, BRANCH, DATE, DESCRIPTION });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(1, 39, 103);
            dataGridViewCellStyle3.SelectionBackColor = Color.White;
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(1, 39, 103);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvMain.DefaultCellStyle = dataGridViewCellStyle3;
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
            dgvMain.RowTemplate.DefaultCellStyle.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            dgvMain.RowTemplate.DefaultCellStyle.ForeColor = Color.FromArgb(1, 39, 103);
            dgvMain.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(109, 134, 176);
            dgvMain.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvMain.RowTemplate.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvMain.RowTemplate.DividerHeight = 10;
            dgvMain.RowTemplate.Height = 40;
            dgvMain.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMain.Size = new Size(613, 395);
            dgvMain.TabIndex = 75;
            dgvMain.CellClick += dgvMain_CellClick;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            dataGridViewCellStyle2.NullValue = "0";
            ID.DefaultCellStyle = dataGridViewCellStyle2;
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Visible = false;
            // 
            // BID
            // 
            BID.DataPropertyName = "BID";
            BID.HeaderText = "BID";
            BID.Name = "BID";
            BID.Visible = false;
            // 
            // COST
            // 
            COST.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            COST.DataPropertyName = "COST";
            COST.FillWeight = 20F;
            COST.HeaderText = "GİDER";
            COST.MaxInputLength = 50;
            COST.Name = "COST";
            // 
            // BRANCH
            // 
            BRANCH.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            BRANCH.DataPropertyName = "BRANCH";
            BRANCH.FillWeight = 20F;
            BRANCH.HeaderText = "ŞUBE";
            BRANCH.Name = "BRANCH";
            // 
            // DATE
            // 
            DATE.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DATE.DataPropertyName = "DATE";
            DATE.FillWeight = 20F;
            DATE.HeaderText = "TARİH";
            DATE.Name = "DATE";
            // 
            // DESCRIPTION
            // 
            DESCRIPTION.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DESCRIPTION.DataPropertyName = "DESCRIPTION";
            DESCRIPTION.FillWeight = 40F;
            DESCRIPTION.HeaderText = "AÇIKLAMA";
            DESCRIPTION.MaxInputLength = 100;
            DESCRIPTION.Name = "DESCRIPTION";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pbClearSearch);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(rtbSearch);
            panel1.Controls.Add(dgvMain);
            panel1.Location = new Point(402, 17);
            panel1.Name = "panel1";
            panel1.Size = new Size(633, 461);
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
            pbClearSearch.TabIndex = 84;
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
            pictureBox3.TabIndex = 83;
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
            rtbSearch.TabIndex = 85;
            rtbSearch.Texts = "";
            rtbSearch.UnderlinedStyle = false;
            rtbSearch._TextChanged += rtbSearch__TextChanged;
            // 
            // tbDescription
            // 
            tbDescription.BorderStyle = BorderStyle.None;
            tbDescription.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            tbDescription.Location = new Point(136, 84);
            tbDescription.Multiline = true;
            tbDescription.Name = "tbDescription";
            tbDescription.Size = new Size(260, 168);
            tbDescription.TabIndex = 80;
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.BackColor = Color.Transparent;
            lblProductName.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            lblProductName.ForeColor = Color.White;
            lblProductName.Location = new Point(12, 84);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(85, 25);
            lblProductName.TabIndex = 79;
            lblProductName.Text = "Açıklama";
            // 
            // lblBranch
            // 
            lblBranch.AutoSize = true;
            lblBranch.BackColor = Color.Transparent;
            lblBranch.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            lblBranch.ForeColor = Color.White;
            lblBranch.Location = new Point(12, 18);
            lblBranch.Name = "lblBranch";
            lblBranch.Size = new Size(54, 25);
            lblBranch.TabIndex = 77;
            lblBranch.Text = "Şube";
            // 
            // tbCost
            // 
            tbCost.BorderStyle = BorderStyle.None;
            tbCost.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            tbCost.Location = new Point(136, 51);
            tbCost.Name = "tbCost";
            tbCost.Size = new Size(260, 27);
            tbCost.TabIndex = 82;
            tbCost.KeyPress += tbCost_KeyPress;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.BackColor = Color.Transparent;
            lblAddress.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            lblAddress.ForeColor = Color.White;
            lblAddress.Location = new Point(12, 51);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(121, 25);
            lblAddress.TabIndex = 81;
            lblAddress.Text = "Masraf Tutarı";
            // 
            // cbBranch
            // 
            cbBranch.BackColor = Color.White;
            cbBranch.DropDownStyle = ComboBoxStyle.DropDownList;
            cbBranch.FlatStyle = FlatStyle.Flat;
            cbBranch.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            cbBranch.FormattingEnabled = true;
            cbBranch.Location = new Point(136, 17);
            cbBranch.Name = "cbBranch";
            cbBranch.Size = new Size(260, 28);
            cbBranch.TabIndex = 83;
            // 
            // button1
            // 
            button1.BackColor = Color.Firebrick;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.ForeColor = Color.White;
            button1.ImageAlign = ContentAlignment.TopCenter;
            button1.Location = new Point(12, 258);
            button1.Name = "button1";
            button1.Size = new Size(118, 33);
            button1.TabIndex = 84;
            button1.Text = "İPTAL ET";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // AddExpense
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 74, 173);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1057, 499);
            Controls.Add(button1);
            Controls.Add(cbBranch);
            Controls.Add(tbCost);
            Controls.Add(lblAddress);
            Controls.Add(tbDescription);
            Controls.Add(lblProductName);
            Controls.Add(lblBranch);
            Controls.Add(panel1);
            Controls.Add(btnSave);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddExpense";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddCategory";
            Load += AddExpense_Load;
            MouseDown += AddCategory_MouseDown;
            ((System.ComponentModel.ISupportInitialize)dgvMain).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbClearSearch).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnSave;
        private DataGridView dgvMain;
        private Panel panel1;
        private TextBox tbDescription;
        private Label lblProductName;
        private Label lblBranch;
        private PictureBox pbClearSearch;
        private PictureBox pictureBox3;
        private CustomObjects.RoundTextBox rtbSearch;
        private TextBox tbCost;
        private Label lblAddress;
        private ComboBox cbBranch;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn BID;
        private DataGridViewTextBoxColumn COST;
        private DataGridViewTextBoxColumn BRANCH;
        private DataGridViewTextBoxColumn DATE;
        private DataGridViewTextBoxColumn DESCRIPTION;
        private Button button1;
    }
}