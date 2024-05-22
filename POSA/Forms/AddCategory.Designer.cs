namespace POSA.Forms
{
    partial class AddCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCategory));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            btnClose = new CustomObjects.RoundButton();
            lblPageHeader = new Label();
            btnSave = new Button();
            dgvMain = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            NAME = new DataGridViewTextBoxColumn();
            DESCRIPTION = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            pbClearSearch = new PictureBox();
            pictureBox3 = new PictureBox();
            rtbSearch = new CustomObjects.RoundTextBox();
            tbDescription = new TextBox();
            lblProductName = new Label();
            tbCategory = new TextBox();
            lblBarcode = new Label();
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
            // lblPageHeader
            // 
            lblPageHeader.AutoSize = true;
            lblPageHeader.BackColor = Color.Transparent;
            lblPageHeader.Font = new Font("Segoe UI Semibold", 17F, FontStyle.Bold);
            lblPageHeader.ForeColor = Color.White;
            lblPageHeader.Location = new Point(12, 9);
            lblPageHeader.Name = "lblPageHeader";
            lblPageHeader.Size = new Size(175, 31);
            lblPageHeader.TabIndex = 43;
            lblPageHeader.Text = "KATEGORİ EKLE";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.LightGreen;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSave.ForeColor = Color.Black;
            btnSave.ImageAlign = ContentAlignment.TopCenter;
            btnSave.Location = new Point(136, 259);
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
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 162);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(1, 39, 103);
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(1, 39, 103);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvMain.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvMain.ColumnHeadersHeight = 50;
            dgvMain.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvMain.Columns.AddRange(new DataGridViewColumn[] { ID, NAME, DESCRIPTION });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 162);
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
            dgvMain.RowTemplate.DefaultCellStyle.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
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
            dataGridViewCellStyle2.NullValue = "0";
            ID.DefaultCellStyle = dataGridViewCellStyle2;
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
            NAME.HeaderText = "KATEGORİ";
            NAME.MaxInputLength = 50;
            NAME.Name = "NAME";
            // 
            // DESCRIPTION
            // 
            DESCRIPTION.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DESCRIPTION.DataPropertyName = "DESCRIPTION";
            DESCRIPTION.FillWeight = 64F;
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
            tbDescription.Location = new Point(136, 85);
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
            lblProductName.Location = new Point(12, 83);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(93, 28);
            lblProductName.TabIndex = 79;
            lblProductName.Text = "Açıklama";
            // 
            // tbCategory
            // 
            tbCategory.BorderStyle = BorderStyle.None;
            tbCategory.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            tbCategory.Location = new Point(136, 52);
            tbCategory.Name = "tbCategory";
            tbCategory.Size = new Size(260, 27);
            tbCategory.TabIndex = 78;
            // 
            // lblBarcode
            // 
            lblBarcode.AutoSize = true;
            lblBarcode.BackColor = Color.Transparent;
            lblBarcode.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            lblBarcode.ForeColor = Color.White;
            lblBarcode.Location = new Point(12, 50);
            lblBarcode.Name = "lblBarcode";
            lblBarcode.Size = new Size(88, 28);
            lblBarcode.TabIndex = 77;
            lblBarcode.Text = "Kategori";
            // 
            // AddCategory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.BackgroundSmall1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1057, 499);
            Controls.Add(tbDescription);
            Controls.Add(lblProductName);
            Controls.Add(tbCategory);
            Controls.Add(lblBarcode);
            Controls.Add(panel1);
            Controls.Add(btnSave);
            Controls.Add(lblPageHeader);
            Controls.Add(btnClose);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddCategory";
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
        private Label lblPageHeader;
        private Button btnSave;
        private DataGridView dgvMain;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn NAME;
        private DataGridViewTextBoxColumn DESCRIPTION;
        private Panel panel1;
        private TextBox tbDescription;
        private Label lblProductName;
        private TextBox tbCategory;
        private Label lblBarcode;
        private PictureBox pbClearSearch;
        private PictureBox pictureBox3;
        private CustomObjects.RoundTextBox rtbSearch;
    }
}