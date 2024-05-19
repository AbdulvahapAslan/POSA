namespace POSA.Forms
{
    partial class AddSupplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSupplier));
            btnMinimize = new Button();
            btnMaximize = new Button();
            btnClose = new Button();
            lblPageHeaderAddSupplier = new Label();
            scMain = new SplitContainer();
            btnSupplierReport = new Button();
            btnAddSupplier = new Button();
            ((System.ComponentModel.ISupportInitialize)scMain).BeginInit();
            scMain.Panel1.SuspendLayout();
            scMain.SuspendLayout();
            SuspendLayout();
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimize.BackColor = Color.Transparent;
            btnMinimize.BackgroundImage = (Image)resources.GetObject("btnMinimize.BackgroundImage");
            btnMinimize.BackgroundImageLayout = ImageLayout.Center;
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.ForeColor = Color.White;
            btnMinimize.Location = new Point(1132, 12);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(70, 35);
            btnMinimize.TabIndex = 8;
            btnMinimize.UseVisualStyleBackColor = false;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // btnMaximize
            // 
            btnMaximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximize.BackColor = Color.Transparent;
            btnMaximize.BackgroundImage = (Image)resources.GetObject("btnMaximize.BackgroundImage");
            btnMaximize.BackgroundImageLayout = ImageLayout.Center;
            btnMaximize.FlatAppearance.BorderSize = 0;
            btnMaximize.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnMaximize.FlatStyle = FlatStyle.Flat;
            btnMaximize.ForeColor = Color.White;
            btnMaximize.Location = new Point(1205, 12);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(70, 35);
            btnMaximize.TabIndex = 7;
            btnMaximize.UseVisualStyleBackColor = false;
            btnMaximize.Click += btnMaximize_Click;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.BackColor = Color.Transparent;
            btnClose.BackgroundImage = (Image)resources.GetObject("btnClose.BackgroundImage");
            btnClose.BackgroundImageLayout = ImageLayout.Center;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatAppearance.MouseOverBackColor = Color.Red;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(1278, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(70, 35);
            btnClose.TabIndex = 6;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // lblPageHeaderAddSupplier
            // 
            lblPageHeaderAddSupplier.AutoSize = true;
            lblPageHeaderAddSupplier.BackColor = Color.Transparent;
            lblPageHeaderAddSupplier.Font = new Font("Segoe UI Semibold", 17F, FontStyle.Bold);
            lblPageHeaderAddSupplier.ForeColor = Color.White;
            lblPageHeaderAddSupplier.Location = new Point(12, 9);
            lblPageHeaderAddSupplier.Name = "lblPageHeaderAddSupplier";
            lblPageHeaderAddSupplier.Size = new Size(181, 31);
            lblPageHeaderAddSupplier.TabIndex = 9;
            lblPageHeaderAddSupplier.Text = "TEDARİKÇİ EKLE";
            // 
            // scMain
            // 
            scMain.Anchor = AnchorStyles.None;
            scMain.BackColor = Color.Transparent;
            scMain.FixedPanel = FixedPanel.Panel1;
            scMain.Location = new Point(254, 121);
            scMain.Name = "scMain";
            scMain.Orientation = Orientation.Horizontal;
            // 
            // scMain.Panel1
            // 
            scMain.Panel1.BackColor = Color.Transparent;
            scMain.Panel1.Controls.Add(btnSupplierReport);
            scMain.Panel1.Controls.Add(btnAddSupplier);
            // 
            // scMain.Panel2
            // 
            scMain.Panel2.BackColor = Color.Transparent;
            scMain.Size = new Size(852, 526);
            scMain.SplitterDistance = 73;
            scMain.TabIndex = 10;
            // 
            // btnSupplierReport
            // 
            btnSupplierReport.BackColor = Color.White;
            btnSupplierReport.FlatAppearance.BorderSize = 0;
            btnSupplierReport.FlatStyle = FlatStyle.Flat;
            btnSupplierReport.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnSupplierReport.ForeColor = Color.FromArgb(47, 124, 213);
            btnSupplierReport.Image = Properties.Resources._64pxBlueReport1;
            btnSupplierReport.ImageAlign = ContentAlignment.MiddleLeft;
            btnSupplierReport.Location = new Point(219, 3);
            btnSupplierReport.Name = "btnSupplierReport";
            btnSupplierReport.Size = new Size(210, 67);
            btnSupplierReport.TabIndex = 1;
            btnSupplierReport.Text = "Tedarikçi Rapor";
            btnSupplierReport.TextAlign = ContentAlignment.MiddleRight;
            btnSupplierReport.UseVisualStyleBackColor = false;
            btnSupplierReport.Click += btnSupplierReport_Click;
            // 
            // btnAddSupplier
            // 
            btnAddSupplier.BackColor = Color.White;
            btnAddSupplier.FlatAppearance.BorderSize = 0;
            btnAddSupplier.FlatStyle = FlatStyle.Flat;
            btnAddSupplier.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnAddSupplier.ForeColor = Color.FromArgb(47, 124, 213);
            btnAddSupplier.Image = Properties.Resources._64pxBluePlus;
            btnAddSupplier.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddSupplier.Location = new Point(3, 3);
            btnAddSupplier.Name = "btnAddSupplier";
            btnAddSupplier.Size = new Size(210, 67);
            btnAddSupplier.TabIndex = 0;
            btnAddSupplier.Text = "Tedarikçi Ekle";
            btnAddSupplier.TextAlign = ContentAlignment.MiddleRight;
            btnAddSupplier.UseVisualStyleBackColor = false;
            btnAddSupplier.Click += btnAddSupplier_Click;
            // 
            // AddSupplier
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = Properties.Resources.BackgroundGeneral;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1360, 768);
            Controls.Add(scMain);
            Controls.Add(lblPageHeaderAddSupplier);
            Controls.Add(btnMinimize);
            Controls.Add(btnMaximize);
            Controls.Add(btnClose);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddSupplier";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddSupplier";
            Load += AddSupplier_Load;
            MouseDown += AddSupplier_MouseDown;
            scMain.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)scMain).EndInit();
            scMain.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMinimize;
        private Button btnMaximize;
        private Button btnClose;
        private Label lblPageHeaderAddSupplier;
        private SplitContainer scMain;
        private Button btnSupplierReport;
        private Button btnAddSupplier;
    }
}