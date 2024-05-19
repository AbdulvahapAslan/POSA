namespace POSA.Forms
{
    partial class UpdateColor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateColor));
            tbDescription = new TextBox();
            lblUCDescription = new Label();
            tbColor = new TextBox();
            lblUCategory = new Label();
            btnSave = new Button();
            btnClose = new CustomObjects.RoundButton();
            lblPageHeaderUpdateCategory = new Label();
            SuspendLayout();
            // 
            // tbDescription
            // 
            tbDescription.BorderStyle = BorderStyle.None;
            tbDescription.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            tbDescription.Location = new Point(136, 89);
            tbDescription.Multiline = true;
            tbDescription.Name = "tbDescription";
            tbDescription.Size = new Size(260, 168);
            tbDescription.TabIndex = 86;
            // 
            // lblUCDescription
            // 
            lblUCDescription.AutoSize = true;
            lblUCDescription.BackColor = Color.Transparent;
            lblUCDescription.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            lblUCDescription.ForeColor = Color.White;
            lblUCDescription.Location = new Point(12, 87);
            lblUCDescription.Name = "lblUCDescription";
            lblUCDescription.Size = new Size(93, 28);
            lblUCDescription.TabIndex = 85;
            lblUCDescription.Text = "Açıklama";
            // 
            // tbColor
            // 
            tbColor.BorderStyle = BorderStyle.None;
            tbColor.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            tbColor.Location = new Point(136, 56);
            tbColor.Name = "tbColor";
            tbColor.Size = new Size(260, 27);
            tbColor.TabIndex = 84;
            // 
            // lblUCategory
            // 
            lblUCategory.AutoSize = true;
            lblUCategory.BackColor = Color.Transparent;
            lblUCategory.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            lblUCategory.ForeColor = Color.White;
            lblUCategory.Location = new Point(12, 54);
            lblUCategory.Name = "lblUCategory";
            lblUCategory.Size = new Size(57, 28);
            lblUCategory.TabIndex = 83;
            lblUCategory.Text = "Renk";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.LightGreen;
            btnSave.DialogResult = DialogResult.OK;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSave.ForeColor = Color.Black;
            btnSave.ImageAlign = ContentAlignment.TopCenter;
            btnSave.Location = new Point(136, 263);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(260, 33);
            btnSave.TabIndex = 82;
            btnSave.Text = "Kaydet";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
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
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(371, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(28, 28);
            btnClose.TabIndex = 81;
            btnClose.TextColor = Color.White;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // lblPageHeaderUpdateCategory
            // 
            lblPageHeaderUpdateCategory.AutoSize = true;
            lblPageHeaderUpdateCategory.BackColor = Color.Transparent;
            lblPageHeaderUpdateCategory.Font = new Font("Segoe UI Semibold", 17F, FontStyle.Bold);
            lblPageHeaderUpdateCategory.ForeColor = Color.White;
            lblPageHeaderUpdateCategory.Location = new Point(12, 12);
            lblPageHeaderUpdateCategory.Name = "lblPageHeaderUpdateCategory";
            lblPageHeaderUpdateCategory.Size = new Size(188, 31);
            lblPageHeaderUpdateCategory.TabIndex = 87;
            lblPageHeaderUpdateCategory.Text = "RENK GÜNCELLE";
            // 
            // UpdateColor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.BackgroundSmall1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(411, 313);
            Controls.Add(lblPageHeaderUpdateCategory);
            Controls.Add(tbDescription);
            Controls.Add(lblUCDescription);
            Controls.Add(tbColor);
            Controls.Add(lblUCategory);
            Controls.Add(btnSave);
            Controls.Add(btnClose);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "UpdateColor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UpdateCategory";
            Load += UpdateCategory_Load;
            MouseDown += UpdateCategory_MouseDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbDescription;
        private Label lblUCDescription;
        private TextBox tbColor;
        private Label lblUCategory;
        private Button btnSave;
        private CustomObjects.RoundButton btnClose;
        private Label lblPageHeaderUpdateCategory;
    }
}