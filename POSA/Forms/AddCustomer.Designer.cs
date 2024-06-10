namespace POSA.Forms
{
    partial class AddCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCustomer));
            btnMinimize = new Button();
            btnMaximize = new Button();
            btnClose = new Button();
            lblPageHeaderAddCustomer = new Label();
            scMain = new SplitContainer();
            btnCustomerReport = new Button();
            btnAddCustomer = new Button();
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
            btnClose.BackgroundImage = Properties.Resources._32pxWhiteX;
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
            // lblPageHeaderAddCustomer
            // 
            lblPageHeaderAddCustomer.AutoSize = true;
            lblPageHeaderAddCustomer.BackColor = Color.Transparent;
            lblPageHeaderAddCustomer.Font = new Font("Segoe UI Semibold", 17F, FontStyle.Bold);
            lblPageHeaderAddCustomer.ForeColor = Color.White;
            lblPageHeaderAddCustomer.Location = new Point(12, 9);
            lblPageHeaderAddCustomer.Name = "lblPageHeaderAddCustomer";
            lblPageHeaderAddCustomer.Size = new Size(165, 31);
            lblPageHeaderAddCustomer.TabIndex = 9;
            lblPageHeaderAddCustomer.Text = "MÜŞTERİ EKLE";
            // 
            // scMain
            // 
            scMain.Anchor = AnchorStyles.None;
            scMain.BackColor = Color.Transparent;
            scMain.FixedPanel = FixedPanel.Panel1;
            scMain.Location = new Point(125, 84);
            scMain.Name = "scMain";
            scMain.Orientation = Orientation.Horizontal;
            // 
            // scMain.Panel1
            // 
            scMain.Panel1.BackColor = Color.Transparent;
            scMain.Panel1.Controls.Add(btnCustomerReport);
            scMain.Panel1.Controls.Add(btnAddCustomer);
            // 
            // scMain.Panel2
            // 
            scMain.Panel2.BackColor = Color.FromArgb(0, 74, 173);
            scMain.Size = new Size(1109, 600);
            scMain.SplitterDistance = 73;
            scMain.TabIndex = 10;
            // 
            // btnCustomerReport
            // 
            btnCustomerReport.BackColor = Color.White;
            btnCustomerReport.FlatAppearance.BorderSize = 0;
            btnCustomerReport.FlatStyle = FlatStyle.Flat;
            btnCustomerReport.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnCustomerReport.ForeColor = Color.FromArgb(47, 124, 213);
            btnCustomerReport.Image = Properties.Resources._64pxBlueReport1;
            btnCustomerReport.ImageAlign = ContentAlignment.MiddleLeft;
            btnCustomerReport.Location = new Point(219, 3);
            btnCustomerReport.Name = "btnCustomerReport";
            btnCustomerReport.Size = new Size(210, 67);
            btnCustomerReport.TabIndex = 1;
            btnCustomerReport.Text = "Müşteri Rapor";
            btnCustomerReport.TextAlign = ContentAlignment.MiddleRight;
            btnCustomerReport.UseVisualStyleBackColor = false;
            btnCustomerReport.Click += btnSupplierReport_Click;
            // 
            // btnAddCustomer
            // 
            btnAddCustomer.BackColor = Color.White;
            btnAddCustomer.FlatAppearance.BorderSize = 0;
            btnAddCustomer.FlatStyle = FlatStyle.Flat;
            btnAddCustomer.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnAddCustomer.ForeColor = Color.FromArgb(47, 124, 213);
            btnAddCustomer.Image = Properties.Resources._64pxBluePlus;
            btnAddCustomer.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddCustomer.Location = new Point(3, 3);
            btnAddCustomer.Name = "btnAddCustomer";
            btnAddCustomer.Size = new Size(210, 67);
            btnAddCustomer.TabIndex = 0;
            btnAddCustomer.Text = "Müşteri Ekle";
            btnAddCustomer.TextAlign = ContentAlignment.MiddleRight;
            btnAddCustomer.UseVisualStyleBackColor = false;
            btnAddCustomer.Click += btnAddCustomer_Click;
            // 
            // AddCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = Properties.Resources.BackgroundGeneral;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1360, 768);
            Controls.Add(scMain);
            Controls.Add(lblPageHeaderAddCustomer);
            Controls.Add(btnMinimize);
            Controls.Add(btnMaximize);
            Controls.Add(btnClose);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddCustomer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddSupplier";
            Load += AddCustomer_Load;
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
        private Label lblPageHeaderAddCustomer;
        private SplitContainer scMain;
        private Button btnAddCustomer;
        public Button btnCustomerReport;
    }
}