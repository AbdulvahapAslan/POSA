﻿namespace POSA.Forms
{
    partial class AddBranch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBranch));
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            btnClose = new CustomObjects.RoundButton();
            lblPageHeaderAddBranch = new Label();
            btnSave = new Button();
            dgvMain = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            NAME = new DataGridViewTextBoxColumn();
            ADDRESS = new DataGridViewTextBoxColumn();
            DESCRIPTION = new DataGridViewTextBoxColumn();
            UPDATE = new DataGridViewImageColumn();
            DELETE = new DataGridViewImageColumn();
            panel1 = new Panel();
            pbClearSearch = new PictureBox();
            pictureBox3 = new PictureBox();
            rtbSearch = new CustomObjects.RoundTextBox();
            tbDescription = new TextBox();
            lblProductName = new Label();
            tbBranch = new TextBox();
            lblBranch = new Label();
            tbAddress = new TextBox();
            lblAddress = new Label();
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
            btnClose.Location = new Point(1012, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(28, 28);
            btnClose.TabIndex = 34;
            btnClose.TextColor = Color.White;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // lblPageHeaderAddBranch
            // 
            lblPageHeaderAddBranch.AutoSize = true;
            lblPageHeaderAddBranch.BackColor = Color.Transparent;
            lblPageHeaderAddBranch.Font = new Font("Segoe UI Semibold", 17F, FontStyle.Bold);
            lblPageHeaderAddBranch.ForeColor = Color.White;
            lblPageHeaderAddBranch.Location = new Point(12, 9);
            lblPageHeaderAddBranch.Name = "lblPageHeaderAddBranch";
            lblPageHeaderAddBranch.Size = new Size(124, 31);
            lblPageHeaderAddBranch.TabIndex = 43;
            lblPageHeaderAddBranch.Text = "ŞUBE EKLE";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.LightGreen;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSave.ForeColor = Color.Black;
            btnSave.ImageAlign = ContentAlignment.TopCenter;
            btnSave.Location = new Point(136, 433);
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
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(1, 39, 103);
            dataGridViewCellStyle4.SelectionBackColor = Color.White;
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(1, 39, 103);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvMain.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvMain.ColumnHeadersHeight = 50;
            dgvMain.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvMain.Columns.AddRange(new DataGridViewColumn[] { ID, NAME, ADDRESS, DESCRIPTION, UPDATE, DELETE });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(1, 39, 103);
            dataGridViewCellStyle6.SelectionBackColor = Color.White;
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(1, 39, 103);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvMain.DefaultCellStyle = dataGridViewCellStyle6;
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
            dgvMain.Size = new Size(613, 362);
            dgvMain.TabIndex = 75;
            dgvMain.CellClick += dgvMain_CellClick;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            dataGridViewCellStyle5.NullValue = "0";
            ID.DefaultCellStyle = dataGridViewCellStyle5;
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Visible = false;
            // 
            // NAME
            // 
            NAME.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NAME.DataPropertyName = "NAME";
            NAME.FillWeight = 22F;
            NAME.HeaderText = "ŞUBE";
            NAME.MaxInputLength = 50;
            NAME.Name = "NAME";
            NAME.ReadOnly = true;
            // 
            // ADDRESS
            // 
            ADDRESS.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ADDRESS.DataPropertyName = "ADDRESS";
            ADDRESS.FillWeight = 39F;
            ADDRESS.HeaderText = "ADRES";
            ADDRESS.Name = "ADDRESS";
            ADDRESS.ReadOnly = true;
            // 
            // DESCRIPTION
            // 
            DESCRIPTION.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DESCRIPTION.DataPropertyName = "DESCRIPTION";
            DESCRIPTION.FillWeight = 39F;
            DESCRIPTION.HeaderText = "AÇIKLAMA";
            DESCRIPTION.MaxInputLength = 100;
            DESCRIPTION.Name = "DESCRIPTION";
            DESCRIPTION.ReadOnly = true;
            // 
            // UPDATE
            // 
            UPDATE.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            UPDATE.FillWeight = 7F;
            UPDATE.HeaderText = "";
            UPDATE.Image = Properties.Resources._24pxUpdate;
            UPDATE.Name = "UPDATE";
            UPDATE.ReadOnly = true;
            UPDATE.Resizable = DataGridViewTriState.False;
            UPDATE.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // DELETE
            // 
            DELETE.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DELETE.FillWeight = 7F;
            DELETE.HeaderText = "";
            DELETE.Image = Properties.Resources._24pxRedTrash;
            DELETE.Name = "DELETE";
            DELETE.ReadOnly = true;
            DELETE.Resizable = DataGridViewTriState.False;
            DELETE.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pbClearSearch);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(rtbSearch);
            panel1.Controls.Add(dgvMain);
            panel1.Location = new Point(402, 50);
            panel1.Name = "panel1";
            panel1.Size = new Size(633, 428);
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
            tbDescription.Location = new Point(136, 259);
            tbDescription.Multiline = true;
            tbDescription.Name = "tbDescription";
            tbDescription.Size = new Size(260, 168);
            tbDescription.TabIndex = 80;
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.BackColor = Color.Transparent;
            lblProductName.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            lblProductName.ForeColor = Color.White;
            lblProductName.Location = new Point(12, 259);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(93, 28);
            lblProductName.TabIndex = 79;
            lblProductName.Text = "Açıklama";
            // 
            // tbBranch
            // 
            tbBranch.BorderStyle = BorderStyle.None;
            tbBranch.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            tbBranch.Location = new Point(136, 50);
            tbBranch.Name = "tbBranch";
            tbBranch.Size = new Size(260, 27);
            tbBranch.TabIndex = 78;
            // 
            // lblBranch
            // 
            lblBranch.AutoSize = true;
            lblBranch.BackColor = Color.Transparent;
            lblBranch.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            lblBranch.ForeColor = Color.White;
            lblBranch.Location = new Point(12, 49);
            lblBranch.Name = "lblBranch";
            lblBranch.Size = new Size(58, 28);
            lblBranch.TabIndex = 77;
            lblBranch.Text = "Şube";
            // 
            // tbAddress
            // 
            tbAddress.BorderStyle = BorderStyle.None;
            tbAddress.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            tbAddress.Location = new Point(136, 85);
            tbAddress.Multiline = true;
            tbAddress.Name = "tbAddress";
            tbAddress.Size = new Size(260, 168);
            tbAddress.TabIndex = 82;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.BackColor = Color.Transparent;
            lblAddress.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            lblAddress.ForeColor = Color.White;
            lblAddress.Location = new Point(12, 85);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(64, 28);
            lblAddress.TabIndex = 81;
            lblAddress.Text = "Adres";
            // 
            // AddBranch
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 74, 173);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1057, 499);
            Controls.Add(tbAddress);
            Controls.Add(lblAddress);
            Controls.Add(tbDescription);
            Controls.Add(lblProductName);
            Controls.Add(tbBranch);
            Controls.Add(lblBranch);
            Controls.Add(panel1);
            Controls.Add(btnSave);
            Controls.Add(lblPageHeaderAddBranch);
            Controls.Add(btnClose);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddBranch";
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
        private Label lblPageHeaderAddBranch;
        private Button btnSave;
        private DataGridView dgvMain;
        private Panel panel1;
        private TextBox tbDescription;
        private Label lblProductName;
        private TextBox tbBranch;
        private Label lblBranch;
        private PictureBox pbClearSearch;
        private PictureBox pictureBox3;
        private CustomObjects.RoundTextBox rtbSearch;
        private TextBox tbAddress;
        private Label lblAddress;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn NAME;
        private DataGridViewTextBoxColumn ADDRESS;
        private DataGridViewTextBoxColumn DESCRIPTION;
        private DataGridViewImageColumn UPDATE;
        private DataGridViewImageColumn DELETE;
    }
}