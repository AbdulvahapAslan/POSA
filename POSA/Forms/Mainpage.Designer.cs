namespace POSA.Forms
{
    partial class Mainpage
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainpage));
            btnClose = new Button();
            btnMaximize = new Button();
            btnMinimize = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lblBusiness = new Label();
            lblUser = new Label();
            lblLicence = new Label();
            pnlButtons = new Panel();
            btnSettings = new Button();
            btnPricing = new Button();
            btnBackup = new Button();
            btnReports = new Button();
            btnCustomers = new Button();
            btnEmployees = new Button();
            btnBusiness = new Button();
            btnSales = new Button();
            btnWholesaler = new Button();
            btnBuying = new Button();
            btnStocks = new Button();
            trmCurrency = new System.Windows.Forms.Timer(components);
            pnlButtons.SuspendLayout();
            SuspendLayout();
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
            btnClose.Location = new Point(1294, 2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(70, 35);
            btnClose.TabIndex = 0;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
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
            btnMaximize.Location = new Point(1223, 2);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(70, 35);
            btnMaximize.TabIndex = 1;
            btnMaximize.UseVisualStyleBackColor = false;
            btnMaximize.Click += btnMaximize_Click;
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
            btnMinimize.Location = new Point(1152, 2);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(70, 35);
            btnMinimize.TabIndex = 2;
            btnMinimize.UseVisualStyleBackColor = false;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.White;
            label1.Location = new Point(1048, 936);
            label1.Name = "label1";
            label1.Size = new Size(278, 28);
            label1.TabIndex = 3;
            label1.Text = "BARKODLU SATIŞ PROGRAMI";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(84, 28);
            label2.TabIndex = 15;
            label2.Text = "İşletme:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.White;
            label3.Location = new Point(12, 37);
            label3.Name = "label3";
            label3.Size = new Size(92, 28);
            label3.TabIndex = 16;
            label3.Text = "Kullanıcı:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.ForeColor = Color.White;
            label4.Location = new Point(12, 65);
            label4.Name = "label4";
            label4.Size = new Size(153, 28);
            label4.TabIndex = 17;
            label4.Text = "Lisans Durumu:";
            // 
            // lblBusiness
            // 
            lblBusiness.AutoSize = true;
            lblBusiness.BackColor = Color.Transparent;
            lblBusiness.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblBusiness.ForeColor = Color.White;
            lblBusiness.Location = new Point(102, 9);
            lblBusiness.Name = "lblBusiness";
            lblBusiness.Size = new Size(18, 28);
            lblBusiness.TabIndex = 18;
            lblBusiness.Text = " ";
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.BackColor = Color.Transparent;
            lblUser.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblUser.ForeColor = Color.White;
            lblUser.Location = new Point(110, 37);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(18, 28);
            lblUser.TabIndex = 19;
            lblUser.Text = " ";
            // 
            // lblLicence
            // 
            lblLicence.AutoSize = true;
            lblLicence.BackColor = Color.Transparent;
            lblLicence.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblLicence.ForeColor = Color.White;
            lblLicence.Location = new Point(171, 65);
            lblLicence.Name = "lblLicence";
            lblLicence.Size = new Size(18, 28);
            lblLicence.TabIndex = 20;
            lblLicence.Text = " ";
            // 
            // pnlButtons
            // 
            pnlButtons.Anchor = AnchorStyles.None;
            pnlButtons.BackColor = Color.Transparent;
            pnlButtons.Controls.Add(btnSettings);
            pnlButtons.Controls.Add(btnPricing);
            pnlButtons.Controls.Add(btnBackup);
            pnlButtons.Controls.Add(btnReports);
            pnlButtons.Controls.Add(btnCustomers);
            pnlButtons.Controls.Add(btnEmployees);
            pnlButtons.Controls.Add(btnBusiness);
            pnlButtons.Controls.Add(btnSales);
            pnlButtons.Controls.Add(btnWholesaler);
            pnlButtons.Controls.Add(btnBuying);
            pnlButtons.Controls.Add(btnStocks);
            pnlButtons.Location = new Point(216, 190);
            pnlButtons.Name = "pnlButtons";
            pnlButtons.Size = new Size(922, 387);
            pnlButtons.TabIndex = 21;
            // 
            // btnSettings
            // 
            btnSettings.BackColor = Color.FromArgb(65, 156, 227);
            btnSettings.BackgroundImage = Properties.Resources.settings;
            btnSettings.BackgroundImageLayout = ImageLayout.Center;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Font = new Font("Segoe UI", 16F);
            btnSettings.ForeColor = Color.White;
            btnSettings.Location = new Point(740, 261);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(178, 123);
            btnSettings.TabIndex = 34;
            btnSettings.Text = "Ayarlar";
            btnSettings.TextAlign = ContentAlignment.BottomCenter;
            btnSettings.UseVisualStyleBackColor = false;
            // 
            // btnPricing
            // 
            btnPricing.BackColor = Color.FromArgb(65, 156, 227);
            btnPricing.BackgroundImage = Properties.Resources.shopping;
            btnPricing.BackgroundImageLayout = ImageLayout.Center;
            btnPricing.FlatStyle = FlatStyle.Flat;
            btnPricing.Font = new Font("Segoe UI", 16F);
            btnPricing.ForeColor = Color.White;
            btnPricing.Location = new Point(740, 132);
            btnPricing.Name = "btnPricing";
            btnPricing.Size = new Size(178, 123);
            btnPricing.TabIndex = 29;
            btnPricing.Text = "Fiyat Güncelle";
            btnPricing.TextAlign = ContentAlignment.BottomCenter;
            btnPricing.UseVisualStyleBackColor = false;
            // 
            // btnBackup
            // 
            btnBackup.BackColor = Color.FromArgb(65, 156, 227);
            btnBackup.BackgroundImage = Properties.Resources.cloud_sync;
            btnBackup.BackgroundImageLayout = ImageLayout.Center;
            btnBackup.FlatStyle = FlatStyle.Flat;
            btnBackup.Font = new Font("Segoe UI", 16F);
            btnBackup.ForeColor = Color.White;
            btnBackup.Location = new Point(556, 261);
            btnBackup.Name = "btnBackup";
            btnBackup.Size = new Size(178, 123);
            btnBackup.TabIndex = 33;
            btnBackup.Text = "Yedekleme";
            btnBackup.TextAlign = ContentAlignment.BottomCenter;
            btnBackup.UseVisualStyleBackColor = false;
            // 
            // btnReports
            // 
            btnReports.BackColor = Color.FromArgb(65, 156, 227);
            btnReports.BackgroundImage = Properties.Resources.statistics;
            btnReports.BackgroundImageLayout = ImageLayout.Center;
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.Font = new Font("Segoe UI", 16F);
            btnReports.ForeColor = Color.White;
            btnReports.Location = new Point(4, 132);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(178, 123);
            btnReports.TabIndex = 22;
            btnReports.Text = "Raporlar";
            btnReports.TextAlign = ContentAlignment.BottomCenter;
            btnReports.UseVisualStyleBackColor = false;
            // 
            // btnCustomers
            // 
            btnCustomers.BackColor = Color.FromArgb(65, 156, 227);
            btnCustomers.BackgroundImage = Properties.Resources.customer;
            btnCustomers.BackgroundImageLayout = ImageLayout.Center;
            btnCustomers.FlatStyle = FlatStyle.Flat;
            btnCustomers.Font = new Font("Segoe UI", 16F);
            btnCustomers.ForeColor = Color.White;
            btnCustomers.Location = new Point(372, 261);
            btnCustomers.Name = "btnCustomers";
            btnCustomers.Size = new Size(178, 123);
            btnCustomers.TabIndex = 32;
            btnCustomers.Text = "Müşteriler";
            btnCustomers.TextAlign = ContentAlignment.BottomCenter;
            btnCustomers.UseVisualStyleBackColor = false;
            // 
            // btnEmployees
            // 
            btnEmployees.BackColor = Color.FromArgb(65, 156, 227);
            btnEmployees.BackgroundImage = Properties.Resources.employees;
            btnEmployees.BackgroundImageLayout = ImageLayout.Center;
            btnEmployees.FlatStyle = FlatStyle.Flat;
            btnEmployees.Font = new Font("Segoe UI", 16F);
            btnEmployees.ForeColor = Color.White;
            btnEmployees.Location = new Point(556, 132);
            btnEmployees.Name = "btnEmployees";
            btnEmployees.Size = new Size(178, 123);
            btnEmployees.TabIndex = 28;
            btnEmployees.Text = "Personel İşleri";
            btnEmployees.TextAlign = ContentAlignment.BottomCenter;
            btnEmployees.UseVisualStyleBackColor = false;
            // 
            // btnBusiness
            // 
            btnBusiness.BackColor = Color.FromArgb(65, 156, 227);
            btnBusiness.BackgroundImage = Properties.Resources.portfolio;
            btnBusiness.BackgroundImageLayout = ImageLayout.Center;
            btnBusiness.FlatStyle = FlatStyle.Flat;
            btnBusiness.Font = new Font("Segoe UI", 16F);
            btnBusiness.ForeColor = Color.White;
            btnBusiness.Location = new Point(188, 261);
            btnBusiness.Name = "btnBusiness";
            btnBusiness.Size = new Size(178, 123);
            btnBusiness.TabIndex = 31;
            btnBusiness.Text = "İşletme";
            btnBusiness.TextAlign = ContentAlignment.BottomCenter;
            btnBusiness.UseVisualStyleBackColor = false;
            // 
            // btnSales
            // 
            btnSales.BackColor = Color.FromArgb(65, 156, 227);
            btnSales.FlatStyle = FlatStyle.Flat;
            btnSales.Font = new Font("Segoe UI", 18F);
            btnSales.ForeColor = Color.White;
            btnSales.Image = Properties.Resources.cart;
            btnSales.Location = new Point(4, 3);
            btnSales.Name = "btnSales";
            btnSales.Size = new Size(915, 123);
            btnSales.TabIndex = 22;
            btnSales.Text = "Satış İşlemi";
            btnSales.TextAlign = ContentAlignment.BottomCenter;
            btnSales.UseVisualStyleBackColor = false;
            btnSales.Click += btnSales_Click;
            // 
            // btnWholesaler
            // 
            btnWholesaler.BackColor = Color.FromArgb(65, 156, 227);
            btnWholesaler.BackgroundImage = (Image)resources.GetObject("btnWholesaler.BackgroundImage");
            btnWholesaler.BackgroundImageLayout = ImageLayout.Center;
            btnWholesaler.FlatStyle = FlatStyle.Flat;
            btnWholesaler.Font = new Font("Segoe UI", 16F);
            btnWholesaler.ForeColor = Color.White;
            btnWholesaler.Location = new Point(4, 261);
            btnWholesaler.Name = "btnWholesaler";
            btnWholesaler.Size = new Size(178, 123);
            btnWholesaler.TabIndex = 30;
            btnWholesaler.Text = "Toptancı";
            btnWholesaler.TextAlign = ContentAlignment.BottomCenter;
            btnWholesaler.UseVisualStyleBackColor = false;
            btnWholesaler.Click += btnWholesaler_Click;
            // 
            // btnBuying
            // 
            btnBuying.BackColor = Color.FromArgb(65, 156, 227);
            btnBuying.BackgroundImage = Properties.Resources.add;
            btnBuying.BackgroundImageLayout = ImageLayout.Center;
            btnBuying.FlatStyle = FlatStyle.Flat;
            btnBuying.Font = new Font("Segoe UI", 16F);
            btnBuying.ForeColor = Color.White;
            btnBuying.Location = new Point(372, 132);
            btnBuying.Name = "btnBuying";
            btnBuying.Size = new Size(178, 123);
            btnBuying.TabIndex = 27;
            btnBuying.Text = "Ürün Girişi";
            btnBuying.TextAlign = ContentAlignment.BottomCenter;
            btnBuying.UseVisualStyleBackColor = false;
            btnBuying.Click += btnBuying_Click;
            // 
            // btnStocks
            // 
            btnStocks.BackColor = Color.FromArgb(65, 156, 227);
            btnStocks.BackgroundImage = Properties.Resources.ready_stock;
            btnStocks.BackgroundImageLayout = ImageLayout.Center;
            btnStocks.FlatStyle = FlatStyle.Flat;
            btnStocks.Font = new Font("Segoe UI", 16F);
            btnStocks.ForeColor = Color.White;
            btnStocks.Location = new Point(188, 132);
            btnStocks.Name = "btnStocks";
            btnStocks.Size = new Size(178, 123);
            btnStocks.TabIndex = 26;
            btnStocks.Text = "Stoklar";
            btnStocks.TextAlign = ContentAlignment.BottomCenter;
            btnStocks.UseVisualStyleBackColor = false;
            btnStocks.Click += btnStocks_Click;
            // 
            // trmCurrency
            // 
            trmCurrency.Enabled = true;
            trmCurrency.Interval = 1200000;
            trmCurrency.Tick += trmCurrency_Tick;
            // 
            // Mainpage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(65, 156, 227);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1366, 768);
            Controls.Add(pnlButtons);
            Controls.Add(lblLicence);
            Controls.Add(lblUser);
            Controls.Add(lblBusiness);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnMinimize);
            Controls.Add(btnMaximize);
            Controls.Add(btnClose);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Mainpage";
            Opacity = 0D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mainpage";
            WindowState = FormWindowState.Maximized;
            Load += Mainpage_Load;
            MouseDown += Mainpage_MouseDown;
            pnlButtons.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClose;
        private Button btnMaximize;
        private Button btnMinimize;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblBusiness;
        private Label lblUser;
        private Label lblLicence;
        private Panel pnlButtons;
        private Button btnSales;
        private Button btnReports;
        private Button btnStocks;
        private Button btnEmployees;
        private Button btnPricing;
        private Button btnWholesaler;
        private Button btnBusiness;
        private Button btnCustomers;
        private Button btnBackup;
        private Button btnSettings;
        private Button btnBuying;
        private System.Windows.Forms.Timer trmCurrency;
    }
}