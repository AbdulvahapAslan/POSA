namespace POSA.Forms
{
    partial class UpdateMaterial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateMaterial));
            tbDescription = new TextBox();
            lblUCDescription = new Label();
            tbUnit = new TextBox();
            lblUMaterial = new Label();
            btnSave = new Button();
            btnClose = new CustomObjects.RoundButton();
            lblPageHeaderUpdateMaterial = new Label();
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
            // tbUnit
            // 
            tbUnit.BorderStyle = BorderStyle.None;
            tbUnit.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            tbUnit.Location = new Point(136, 56);
            tbUnit.Name = "tbUnit";
            tbUnit.Size = new Size(260, 27);
            tbUnit.TabIndex = 84;
            // 
            // lblUMaterial
            // 
            lblUMaterial.AutoSize = true;
            lblUMaterial.BackColor = Color.Transparent;
            lblUMaterial.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            lblUMaterial.ForeColor = Color.White;
            lblUMaterial.Location = new Point(12, 54);
            lblUMaterial.Name = "lblUMaterial";
            lblUMaterial.Size = new Size(91, 28);
            lblUMaterial.TabIndex = 83;
            lblUMaterial.Text = "Materyal";
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
            // lblPageHeaderUpdateMaterial
            // 
            lblPageHeaderUpdateMaterial.AutoSize = true;
            lblPageHeaderUpdateMaterial.BackColor = Color.Transparent;
            lblPageHeaderUpdateMaterial.Font = new Font("Segoe UI Semibold", 17F, FontStyle.Bold);
            lblPageHeaderUpdateMaterial.ForeColor = Color.White;
            lblPageHeaderUpdateMaterial.Location = new Point(12, 12);
            lblPageHeaderUpdateMaterial.Name = "lblPageHeaderUpdateMaterial";
            lblPageHeaderUpdateMaterial.Size = new Size(240, 31);
            lblPageHeaderUpdateMaterial.TabIndex = 87;
            lblPageHeaderUpdateMaterial.Text = "MATERYAL GÜNCELLE";
            // 
            // UpdateMaterial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.BackgroundSmall1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(411, 313);
            Controls.Add(lblPageHeaderUpdateMaterial);
            Controls.Add(tbDescription);
            Controls.Add(lblUCDescription);
            Controls.Add(tbUnit);
            Controls.Add(lblUMaterial);
            Controls.Add(btnSave);
            Controls.Add(btnClose);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "UpdateMaterial";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UpdateCategory";
            Load += UpdateCategory_Load;
            MouseDown += UpdateUnit_MouseDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbDescription;
        private Label lblUCDescription;
        private TextBox tbUnit;
        private Label lblUMaterial;
        private Button btnSave;
        private CustomObjects.RoundButton btnClose;
        private Label lblPageHeaderUpdateMaterial;
    }
}