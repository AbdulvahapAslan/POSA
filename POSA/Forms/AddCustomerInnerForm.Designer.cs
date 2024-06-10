namespace POSA.Forms
{
    partial class AddCustomerInnerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCustomerInnerForm));
            panel1 = new Panel();
            btnSave = new Button();
            btnCancel = new Button();
            tbAddress = new TextBox();
            lblAddress = new Label();
            tbNote = new TextBox();
            lblNote = new Label();
            tbTaxDept = new TextBox();
            lblTaxDept = new Label();
            tbTaxNo = new TextBox();
            lnlTaxnumber = new Label();
            tbPhone = new TextBox();
            lblPhone = new Label();
            tbEmail = new TextBox();
            lblEmail = new Label();
            tbName = new TextBox();
            lblNameSurname = new Label();
            btnClose = new CustomObjects.RoundButton();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(tbAddress);
            panel1.Controls.Add(lblAddress);
            panel1.Controls.Add(tbNote);
            panel1.Controls.Add(lblNote);
            panel1.Controls.Add(tbTaxDept);
            panel1.Controls.Add(lblTaxDept);
            panel1.Controls.Add(tbTaxNo);
            panel1.Controls.Add(lnlTaxnumber);
            panel1.Controls.Add(tbPhone);
            panel1.Controls.Add(lblPhone);
            panel1.Controls.Add(tbEmail);
            panel1.Controls.Add(lblEmail);
            panel1.Controls.Add(tbName);
            panel1.Controls.Add(lblNameSurname);
            panel1.Location = new Point(219, 99);
            panel1.Name = "panel1";
            panel1.Size = new Size(680, 334);
            panel1.TabIndex = 0;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Green;
            btnSave.DialogResult = DialogResult.OK;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Image = Properties.Resources._64pxGreenCheckSmall;
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(448, 242);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(206, 58);
            btnSave.TabIndex = 19;
            btnSave.Text = "   KAYDET";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Red;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnCancel.ForeColor = Color.White;
            btnCancel.Image = Properties.Resources._64pxWhiteX50Scale1;
            btnCancel.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancel.Location = new Point(100, 242);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(206, 58);
            btnCancel.TabIndex = 18;
            btnCancel.Text = "İPTAL";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // tbAddress
            // 
            tbAddress.BorderStyle = BorderStyle.None;
            tbAddress.Font = new Font("Segoe UI", 12.5F, FontStyle.Bold);
            tbAddress.Location = new Point(100, 131);
            tbAddress.Multiline = true;
            tbAddress.Name = "tbAddress";
            tbAddress.Size = new Size(554, 89);
            tbAddress.TabIndex = 17;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.BackColor = Color.FromArgb(143, 175, 219);
            lblAddress.Font = new Font("Segoe UI", 12.5F, FontStyle.Bold);
            lblAddress.ForeColor = Color.White;
            lblAddress.Location = new Point(15, 131);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(101, 23);
            lblAddress.TabIndex = 16;
            lblAddress.Text = "Adres         ";
            // 
            // tbNote
            // 
            tbNote.BorderStyle = BorderStyle.None;
            tbNote.Font = new Font("Segoe UI", 12.5F, FontStyle.Bold);
            tbNote.Location = new Point(434, 102);
            tbNote.Name = "tbNote";
            tbNote.Size = new Size(220, 23);
            tbNote.TabIndex = 15;
            // 
            // lblNote
            // 
            lblNote.AutoSize = true;
            lblNote.BackColor = Color.FromArgb(143, 175, 219);
            lblNote.Font = new Font("Segoe UI", 12.5F, FontStyle.Bold);
            lblNote.ForeColor = Color.White;
            lblNote.Location = new Point(323, 102);
            lblNote.Name = "lblNote";
            lblNote.Size = new Size(140, 23);
            lblNote.TabIndex = 14;
            lblNote.Text = "Not                    ";
            // 
            // tbTaxDept
            // 
            tbTaxDept.BorderStyle = BorderStyle.None;
            tbTaxDept.Font = new Font("Segoe UI", 12.5F, FontStyle.Bold);
            tbTaxDept.Location = new Point(434, 73);
            tbTaxDept.Name = "tbTaxDept";
            tbTaxDept.Size = new Size(220, 23);
            tbTaxDept.TabIndex = 11;
            // 
            // lblTaxDept
            // 
            lblTaxDept.AutoSize = true;
            lblTaxDept.BackColor = Color.FromArgb(143, 175, 219);
            lblTaxDept.Font = new Font("Segoe UI", 12.5F, FontStyle.Bold);
            lblTaxDept.ForeColor = Color.White;
            lblTaxDept.Location = new Point(323, 73);
            lblTaxDept.Name = "lblTaxDept";
            lblTaxDept.Size = new Size(112, 23);
            lblTaxDept.TabIndex = 10;
            lblTaxDept.Text = "Vergi Dairesi";
            // 
            // tbTaxNo
            // 
            tbTaxNo.BorderStyle = BorderStyle.None;
            tbTaxNo.Font = new Font("Segoe UI", 12.5F, FontStyle.Bold);
            tbTaxNo.Location = new Point(100, 73);
            tbTaxNo.Name = "tbTaxNo";
            tbTaxNo.Size = new Size(220, 23);
            tbTaxNo.TabIndex = 9;
            // 
            // lnlTaxnumber
            // 
            lnlTaxnumber.AutoSize = true;
            lnlTaxnumber.BackColor = Color.FromArgb(143, 175, 219);
            lnlTaxnumber.Font = new Font("Segoe UI", 12.5F, FontStyle.Bold);
            lnlTaxnumber.ForeColor = Color.White;
            lnlTaxnumber.Location = new Point(15, 73);
            lnlTaxnumber.Name = "lnlTaxnumber";
            lnlTaxnumber.Size = new Size(100, 23);
            lnlTaxnumber.TabIndex = 8;
            lnlTaxnumber.Text = "Vergi No    ";
            // 
            // tbPhone
            // 
            tbPhone.BorderStyle = BorderStyle.None;
            tbPhone.Font = new Font("Segoe UI", 12.5F, FontStyle.Bold);
            tbPhone.Location = new Point(100, 102);
            tbPhone.Name = "tbPhone";
            tbPhone.Size = new Size(220, 23);
            tbPhone.TabIndex = 7;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.BackColor = Color.FromArgb(143, 175, 219);
            lblPhone.Font = new Font("Segoe UI", 12.5F, FontStyle.Bold);
            lblPhone.ForeColor = Color.White;
            lblPhone.Location = new Point(15, 102);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(133, 23);
            lblPhone.TabIndex = 6;
            lblPhone.Text = "Telefon             ";
            // 
            // tbEmail
            // 
            tbEmail.BorderStyle = BorderStyle.None;
            tbEmail.Font = new Font("Segoe UI", 12.5F, FontStyle.Bold);
            tbEmail.Location = new Point(434, 44);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(220, 23);
            tbEmail.TabIndex = 3;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BackColor = Color.FromArgb(143, 175, 219);
            lblEmail.Font = new Font("Segoe UI", 12.5F, FontStyle.Bold);
            lblEmail.ForeColor = Color.White;
            lblEmail.Location = new Point(323, 44);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(155, 23);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "E-posta                 ";
            // 
            // tbName
            // 
            tbName.BorderStyle = BorderStyle.None;
            tbName.Font = new Font("Segoe UI", 12.5F, FontStyle.Bold);
            tbName.Location = new Point(100, 44);
            tbName.Name = "tbName";
            tbName.Size = new Size(220, 23);
            tbName.TabIndex = 1;
            // 
            // lblNameSurname
            // 
            lblNameSurname.AutoSize = true;
            lblNameSurname.BackColor = Color.FromArgb(143, 175, 219);
            lblNameSurname.Font = new Font("Segoe UI", 12.5F, FontStyle.Bold);
            lblNameSurname.ForeColor = Color.White;
            lblNameSurname.Location = new Point(15, 44);
            lblNameSurname.Name = "lblNameSurname";
            lblNameSurname.Size = new Size(87, 23);
            lblNameSurname.TabIndex = 0;
            lblNameSurname.Text = "Ad Soyad";
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
            btnClose.Location = new Point(1078, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(28, 28);
            btnClose.TabIndex = 37;
            btnClose.TextColor = Color.White;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Visible = false;
            // 
            // AddCustomerInnerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(0, 74, 173);
            ClientSize = new Size(1118, 532);
            Controls.Add(btnClose);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddCustomerInnerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddSuplierInnerForm";
            Load += AddCustomerInnerForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox tbName;
        private Label lblNameSurname;
        private TextBox tbAddress;
        private Label lblAddress;
        private TextBox tbNote;
        private Label lblNote;
        private TextBox tbTaxDept;
        private Label lblTaxDept;
        private TextBox tbTaxNo;
        private Label lnlTaxnumber;
        private TextBox tbPhone;
        private Label lblPhone;
        private TextBox tbEmail;
        private Label lblEmail;
        private Button btnSave;
        private Button btnCancel;
        private CustomObjects.RoundButton btnClose;
    }
}