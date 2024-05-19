namespace POSA.Forms
{
    partial class AddSupplierInnerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSupplierInnerForm));
            panel1 = new Panel();
            btnSave = new Button();
            btnCancel = new Button();
            tbAddress = new TextBox();
            label9 = new Label();
            tbNote = new TextBox();
            label7 = new Label();
            tbSector = new TextBox();
            label8 = new Label();
            tbTaxDept = new TextBox();
            label5 = new Label();
            tbTaxNo = new TextBox();
            label6 = new Label();
            tbPhone = new TextBox();
            label3 = new Label();
            tbExecutive = new TextBox();
            label4 = new Label();
            tbCompany = new TextBox();
            label2 = new Label();
            tbName = new TextBox();
            label1 = new Label();
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
            panel1.Controls.Add(label9);
            panel1.Controls.Add(tbNote);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(tbSector);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(tbTaxDept);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(tbTaxNo);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(tbPhone);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(tbExecutive);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(tbCompany);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(tbName);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(60, 58);
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
            tbAddress.Location = new Point(100, 147);
            tbAddress.Multiline = true;
            tbAddress.Name = "tbAddress";
            tbAddress.Size = new Size(554, 89);
            tbAddress.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.FromArgb(143, 175, 219);
            label9.Font = new Font("Segoe UI", 12.5F, FontStyle.Bold);
            label9.ForeColor = Color.White;
            label9.Location = new Point(15, 147);
            label9.Name = "label9";
            label9.Size = new Size(101, 23);
            label9.TabIndex = 16;
            label9.Text = "Adres         ";
            // 
            // tbNote
            // 
            tbNote.BorderStyle = BorderStyle.None;
            tbNote.Font = new Font("Segoe UI", 12.5F, FontStyle.Bold);
            tbNote.Location = new Point(434, 118);
            tbNote.Name = "tbNote";
            tbNote.Size = new Size(220, 23);
            tbNote.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(143, 175, 219);
            label7.Font = new Font("Segoe UI", 12.5F, FontStyle.Bold);
            label7.ForeColor = Color.White;
            label7.Location = new Point(323, 118);
            label7.Name = "label7";
            label7.Size = new Size(140, 23);
            label7.TabIndex = 14;
            label7.Text = "Not                    ";
            // 
            // tbSector
            // 
            tbSector.BorderStyle = BorderStyle.None;
            tbSector.Font = new Font("Segoe UI", 12.5F, FontStyle.Bold);
            tbSector.Location = new Point(100, 118);
            tbSector.Name = "tbSector";
            tbSector.Size = new Size(220, 23);
            tbSector.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(143, 175, 219);
            label8.Font = new Font("Segoe UI", 12.5F, FontStyle.Bold);
            label8.ForeColor = Color.White;
            label8.Location = new Point(15, 118);
            label8.Name = "label8";
            label8.Size = new Size(98, 23);
            label8.TabIndex = 12;
            label8.Text = "Sektör       ";
            // 
            // tbTaxDept
            // 
            tbTaxDept.BorderStyle = BorderStyle.None;
            tbTaxDept.Font = new Font("Segoe UI", 12.5F, FontStyle.Bold);
            tbTaxDept.Location = new Point(434, 89);
            tbTaxDept.Name = "tbTaxDept";
            tbTaxDept.Size = new Size(220, 23);
            tbTaxDept.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(143, 175, 219);
            label5.Font = new Font("Segoe UI", 12.5F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(323, 89);
            label5.Name = "label5";
            label5.Size = new Size(112, 23);
            label5.TabIndex = 10;
            label5.Text = "Vergi Dairesi";
            // 
            // tbTaxNo
            // 
            tbTaxNo.BorderStyle = BorderStyle.None;
            tbTaxNo.Font = new Font("Segoe UI", 12.5F, FontStyle.Bold);
            tbTaxNo.Location = new Point(100, 89);
            tbTaxNo.Name = "tbTaxNo";
            tbTaxNo.Size = new Size(220, 23);
            tbTaxNo.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(143, 175, 219);
            label6.Font = new Font("Segoe UI", 12.5F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(15, 89);
            label6.Name = "label6";
            label6.Size = new Size(100, 23);
            label6.TabIndex = 8;
            label6.Text = "Vergi No    ";
            // 
            // tbPhone
            // 
            tbPhone.BorderStyle = BorderStyle.None;
            tbPhone.Font = new Font("Segoe UI", 12.5F, FontStyle.Bold);
            tbPhone.Location = new Point(434, 60);
            tbPhone.Name = "tbPhone";
            tbPhone.Size = new Size(220, 23);
            tbPhone.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(143, 175, 219);
            label3.Font = new Font("Segoe UI", 12.5F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(323, 60);
            label3.Name = "label3";
            label3.Size = new Size(133, 23);
            label3.TabIndex = 6;
            label3.Text = "Telefon             ";
            // 
            // tbExecutive
            // 
            tbExecutive.BorderStyle = BorderStyle.None;
            tbExecutive.Font = new Font("Segoe UI", 12.5F, FontStyle.Bold);
            tbExecutive.Location = new Point(100, 60);
            tbExecutive.Name = "tbExecutive";
            tbExecutive.Size = new Size(220, 23);
            tbExecutive.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(143, 175, 219);
            label4.Font = new Font("Segoe UI", 12.5F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(15, 60);
            label4.Name = "label4";
            label4.Size = new Size(99, 23);
            label4.TabIndex = 4;
            label4.Text = "Yetkili        ";
            // 
            // tbCompany
            // 
            tbCompany.BorderStyle = BorderStyle.None;
            tbCompany.Font = new Font("Segoe UI", 12.5F, FontStyle.Bold);
            tbCompany.Location = new Point(434, 31);
            tbCompany.Name = "tbCompany";
            tbCompany.Size = new Size(220, 23);
            tbCompany.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(143, 175, 219);
            label2.Font = new Font("Segoe UI", 12.5F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(323, 31);
            label2.Name = "label2";
            label2.Size = new Size(141, 23);
            label2.TabIndex = 2;
            label2.Text = "Firma                 ";
            // 
            // tbName
            // 
            tbName.BorderStyle = BorderStyle.None;
            tbName.Font = new Font("Segoe UI", 12.5F, FontStyle.Bold);
            tbName.Location = new Point(100, 31);
            tbName.Name = "tbName";
            tbName.Size = new Size(220, 23);
            tbName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(143, 175, 219);
            label1.Font = new Font("Segoe UI", 12.5F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(15, 31);
            label1.Name = "label1";
            label1.Size = new Size(87, 23);
            label1.TabIndex = 0;
            label1.Text = "Ad Soyad";
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
            btnClose.Location = new Point(760, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(28, 28);
            btnClose.TabIndex = 35;
            btnClose.TextColor = Color.White;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Visible = false;
            btnClose.Click += btnClose_Click;
            // 
            // AddSupplierInnerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 74, 173);
            ClientSize = new Size(800, 450);
            Controls.Add(btnClose);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddSupplierInnerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddSuplierInnerForm";
            Load += AddSupplierInnerForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox tbName;
        private Label label1;
        private TextBox tbAddress;
        private Label label9;
        private TextBox tbNote;
        private Label label7;
        private TextBox tbSector;
        private Label label8;
        private TextBox tbTaxDept;
        private Label label5;
        private TextBox tbTaxNo;
        private Label label6;
        private TextBox tbPhone;
        private Label label3;
        private TextBox tbExecutive;
        private Label label4;
        private TextBox tbCompany;
        private Label label2;
        private Button btnSave;
        private Button btnCancel;
        private CustomObjects.RoundButton btnClose;
    }
}