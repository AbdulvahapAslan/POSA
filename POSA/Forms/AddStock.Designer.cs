namespace POSA.Forms
{
    partial class AddStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStock));
            btnMinimize = new Button();
            btnMaximize = new Button();
            btnClose = new Button();
            lblPageHeaderStocks = new Label();
            scMain = new SplitContainer();
            btnShowStocks = new Button();
            btnAddStocks = new Button();
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
            // lblPageHeaderStocks
            // 
            lblPageHeaderStocks.AutoSize = true;
            lblPageHeaderStocks.BackColor = Color.Transparent;
            lblPageHeaderStocks.Font = new Font("Segoe UI Semibold", 17F, FontStyle.Bold);
            lblPageHeaderStocks.ForeColor = Color.White;
            lblPageHeaderStocks.Location = new Point(12, 9);
            lblPageHeaderStocks.Name = "lblPageHeaderStocks";
            lblPageHeaderStocks.Size = new Size(111, 31);
            lblPageHeaderStocks.TabIndex = 9;
            lblPageHeaderStocks.Text = "STOKLAR";
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
            scMain.Panel1.Controls.Add(btnShowStocks);
            scMain.Panel1.Controls.Add(btnAddStocks);
            // 
            // scMain.Panel2
            // 
            scMain.Panel2.BackColor = Color.Transparent;
            scMain.Size = new Size(1109, 600);
            scMain.SplitterDistance = 73;
            scMain.TabIndex = 10;
            // 
            // btnShowStocks
            // 
            btnShowStocks.BackColor = Color.White;
            btnShowStocks.FlatAppearance.BorderSize = 0;
            btnShowStocks.FlatStyle = FlatStyle.Flat;
            btnShowStocks.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnShowStocks.ForeColor = Color.FromArgb(47, 124, 213);
            btnShowStocks.Image = Properties.Resources._64pxBlueBoxes;
            btnShowStocks.ImageAlign = ContentAlignment.MiddleLeft;
            btnShowStocks.Location = new Point(193, 3);
            btnShowStocks.Name = "btnShowStocks";
            btnShowStocks.Size = new Size(152, 67);
            btnShowStocks.TabIndex = 1;
            btnShowStocks.Text = "Stoklar";
            btnShowStocks.TextAlign = ContentAlignment.MiddleRight;
            btnShowStocks.UseVisualStyleBackColor = false;
            btnShowStocks.Click += btnShowStocks_Click;
            // 
            // btnAddStocks
            // 
            btnAddStocks.BackColor = Color.White;
            btnAddStocks.FlatAppearance.BorderSize = 0;
            btnAddStocks.FlatStyle = FlatStyle.Flat;
            btnAddStocks.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnAddStocks.ForeColor = Color.FromArgb(47, 124, 213);
            btnAddStocks.Image = Properties.Resources._64pxBluePlus;
            btnAddStocks.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddStocks.Location = new Point(3, 3);
            btnAddStocks.Name = "btnAddStocks";
            btnAddStocks.Size = new Size(184, 67);
            btnAddStocks.TabIndex = 0;
            btnAddStocks.Text = "Stok Girişi";
            btnAddStocks.TextAlign = ContentAlignment.MiddleRight;
            btnAddStocks.UseVisualStyleBackColor = false;
            btnAddStocks.Click += btnAddStocks_Click;
            // 
            // Stocks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = Properties.Resources.BackgroundGeneral;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1360, 768);
            Controls.Add(scMain);
            Controls.Add(lblPageHeaderStocks);
            Controls.Add(btnMinimize);
            Controls.Add(btnMaximize);
            Controls.Add(btnClose);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Stocks";
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
        private Label lblPageHeaderStocks;
        private SplitContainer scMain;
        private Button btnShowStocks;
        private Button btnAddStocks;
    }
}