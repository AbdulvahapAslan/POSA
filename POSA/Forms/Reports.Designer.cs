namespace POSA.Forms
{
    partial class Reports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reports));
            lblPageHeaderUpdatePrice = new Label();
            btnMinimize = new Button();
            btnMaximize = new Button();
            btnClose = new Button();
            scMain = new SplitContainer();
            btnStockCheckReport = new Button();
            btnWorkerReport = new Button();
            btnStockReport = new Button();
            btnCustomerReport = new Button();
            btnSaleReport = new Button();
            ((System.ComponentModel.ISupportInitialize)scMain).BeginInit();
            scMain.Panel1.SuspendLayout();
            scMain.SuspendLayout();
            SuspendLayout();
            // 
            // lblPageHeaderUpdatePrice
            // 
            lblPageHeaderUpdatePrice.AutoSize = true;
            lblPageHeaderUpdatePrice.BackColor = Color.Transparent;
            lblPageHeaderUpdatePrice.Font = new Font("Segoe UI Semibold", 17F, FontStyle.Bold);
            lblPageHeaderUpdatePrice.ForeColor = Color.White;
            lblPageHeaderUpdatePrice.Location = new Point(28, 12);
            lblPageHeaderUpdatePrice.Name = "lblPageHeaderUpdatePrice";
            lblPageHeaderUpdatePrice.Size = new Size(128, 31);
            lblPageHeaderUpdatePrice.TabIndex = 124;
            lblPageHeaderUpdatePrice.Text = "RAPORLAR";
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
            btnMinimize.Location = new Point(1142, 12);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(70, 35);
            btnMinimize.TabIndex = 123;
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
            btnMaximize.Location = new Point(1213, 12);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(70, 35);
            btnMaximize.TabIndex = 122;
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
            btnClose.FlatAppearance.MouseDownBackColor = Color.Red;
            btnClose.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(1284, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(70, 35);
            btnClose.TabIndex = 121;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // scMain
            // 
            scMain.Anchor = AnchorStyles.None;
            scMain.BackColor = Color.Transparent;
            scMain.FixedPanel = FixedPanel.Panel1;
            scMain.Location = new Point(59, 56);
            scMain.Margin = new Padding(50);
            scMain.Name = "scMain";
            scMain.Orientation = Orientation.Horizontal;
            // 
            // scMain.Panel1
            // 
            scMain.Panel1.BackColor = Color.Transparent;
            scMain.Panel1.Controls.Add(btnStockCheckReport);
            scMain.Panel1.Controls.Add(btnWorkerReport);
            scMain.Panel1.Controls.Add(btnStockReport);
            scMain.Panel1.Controls.Add(btnCustomerReport);
            scMain.Panel1.Controls.Add(btnSaleReport);
            // 
            // scMain.Panel2
            // 
            scMain.Panel2.BackColor = Color.FromArgb(0, 74, 173);
            scMain.Size = new Size(1248, 677);
            scMain.SplitterDistance = 73;
            scMain.TabIndex = 125;
            // 
            // btnStockCheckReport
            // 
            btnStockCheckReport.BackColor = Color.White;
            btnStockCheckReport.FlatAppearance.BorderSize = 0;
            btnStockCheckReport.FlatStyle = FlatStyle.Flat;
            btnStockCheckReport.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnStockCheckReport.ForeColor = Color.FromArgb(47, 124, 213);
            btnStockCheckReport.ImageAlign = ContentAlignment.MiddleLeft;
            btnStockCheckReport.Location = new Point(643, 3);
            btnStockCheckReport.Name = "btnStockCheckReport";
            btnStockCheckReport.Size = new Size(149, 67);
            btnStockCheckReport.TabIndex = 128;
            btnStockCheckReport.Text = "Sayım Raporu";
            btnStockCheckReport.UseVisualStyleBackColor = false;
            // 
            // btnWorkerReport
            // 
            btnWorkerReport.BackColor = Color.White;
            btnWorkerReport.FlatAppearance.BorderSize = 0;
            btnWorkerReport.FlatStyle = FlatStyle.Flat;
            btnWorkerReport.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnWorkerReport.ForeColor = Color.FromArgb(47, 124, 213);
            btnWorkerReport.ImageAlign = ContentAlignment.MiddleLeft;
            btnWorkerReport.Location = new Point(466, 3);
            btnWorkerReport.Name = "btnWorkerReport";
            btnWorkerReport.Size = new Size(171, 67);
            btnWorkerReport.TabIndex = 127;
            btnWorkerReport.Text = "Personel Raporu";
            btnWorkerReport.UseVisualStyleBackColor = false;
            // 
            // btnStockReport
            // 
            btnStockReport.BackColor = Color.White;
            btnStockReport.FlatAppearance.BorderSize = 0;
            btnStockReport.FlatStyle = FlatStyle.Flat;
            btnStockReport.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnStockReport.ForeColor = Color.FromArgb(47, 124, 213);
            btnStockReport.ImageAlign = ContentAlignment.MiddleLeft;
            btnStockReport.Location = new Point(159, 3);
            btnStockReport.Name = "btnStockReport";
            btnStockReport.Size = new Size(153, 67);
            btnStockReport.TabIndex = 1;
            btnStockReport.Text = "Stok Raporu";
            btnStockReport.UseVisualStyleBackColor = false;
            btnStockReport.Click += btnStockReport_Click;
            // 
            // btnCustomerReport
            // 
            btnCustomerReport.BackColor = Color.White;
            btnCustomerReport.FlatAppearance.BorderSize = 0;
            btnCustomerReport.FlatStyle = FlatStyle.Flat;
            btnCustomerReport.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnCustomerReport.ForeColor = Color.FromArgb(47, 124, 213);
            btnCustomerReport.ImageAlign = ContentAlignment.MiddleLeft;
            btnCustomerReport.Location = new Point(318, 3);
            btnCustomerReport.Name = "btnCustomerReport";
            btnCustomerReport.Size = new Size(142, 67);
            btnCustomerReport.TabIndex = 126;
            btnCustomerReport.Text = "Cari Raporu";
            btnCustomerReport.UseVisualStyleBackColor = false;
            // 
            // btnSaleReport
            // 
            btnSaleReport.BackColor = Color.White;
            btnSaleReport.FlatAppearance.BorderSize = 0;
            btnSaleReport.FlatStyle = FlatStyle.Flat;
            btnSaleReport.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnSaleReport.ForeColor = Color.FromArgb(47, 124, 213);
            btnSaleReport.ImageAlign = ContentAlignment.MiddleLeft;
            btnSaleReport.Location = new Point(3, 3);
            btnSaleReport.Name = "btnSaleReport";
            btnSaleReport.Size = new Size(150, 67);
            btnSaleReport.TabIndex = 0;
            btnSaleReport.Text = "Satış Raporu";
            btnSaleReport.UseVisualStyleBackColor = false;
            btnSaleReport.Click += btnSaleReport_Click;
            // 
            // Reports
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.BackgroundGeneral;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1366, 768);
            Controls.Add(scMain);
            Controls.Add(lblPageHeaderUpdatePrice);
            Controls.Add(btnMinimize);
            Controls.Add(btnMaximize);
            Controls.Add(btnClose);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Reports";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Workplace";
            WindowState = FormWindowState.Maximized;
            Load += Reports_Load;
            MouseDown += Workplace_MouseDown;
            scMain.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)scMain).EndInit();
            scMain.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPageHeaderUpdatePrice;
        private Button btnMinimize;
        private Button btnMaximize;
        private Button btnClose;
        private SplitContainer scMain;
        public Button btnStockReport;
        private Button btnSaleReport;
        public Button btnWorkerReport;
        private Button btnCustomerReport;
        private Button btnStockCheckReport;
    }
}