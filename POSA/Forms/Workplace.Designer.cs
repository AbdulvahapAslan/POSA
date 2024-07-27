namespace POSA.Forms
{
    partial class Workplace
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Workplace));
            lblPageHeaderUpdatePrice = new Label();
            btnMinimize = new Button();
            btnMaximize = new Button();
            btnClose = new Button();
            scMain = new SplitContainer();
            btnExpenses = new Button();
            btnBranches = new Button();
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
            lblPageHeaderUpdatePrice.Size = new Size(103, 31);
            lblPageHeaderUpdatePrice.TabIndex = 124;
            lblPageHeaderUpdatePrice.Text = "İŞLETME";
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
            scMain.Location = new Point(170, 112);
            scMain.Name = "scMain";
            scMain.Orientation = Orientation.Horizontal;
            // 
            // scMain.Panel1
            // 
            scMain.Panel1.BackColor = Color.Transparent;
            scMain.Panel1.Controls.Add(btnExpenses);
            scMain.Panel1.Controls.Add(btnBranches);
            // 
            // scMain.Panel2
            // 
            scMain.Panel2.BackColor = Color.FromArgb(0, 74, 173);
            scMain.Size = new Size(1057, 577);
            scMain.SplitterDistance = 73;
            scMain.TabIndex = 125;
            // 
            // btnExpenses
            // 
            btnExpenses.BackColor = Color.White;
            btnExpenses.FlatAppearance.BorderSize = 0;
            btnExpenses.FlatStyle = FlatStyle.Flat;
            btnExpenses.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnExpenses.ForeColor = Color.FromArgb(47, 124, 213);
            btnExpenses.Image = Properties.Resources._64pxExpenses;
            btnExpenses.ImageAlign = ContentAlignment.MiddleLeft;
            btnExpenses.Location = new Point(219, 3);
            btnExpenses.Name = "btnExpenses";
            btnExpenses.Size = new Size(210, 67);
            btnExpenses.TabIndex = 1;
            btnExpenses.Text = "       Masraflar";
            btnExpenses.UseVisualStyleBackColor = false;
            // 
            // btnBranches
            // 
            btnBranches.BackColor = Color.White;
            btnBranches.FlatAppearance.BorderSize = 0;
            btnBranches.FlatStyle = FlatStyle.Flat;
            btnBranches.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnBranches.ForeColor = Color.FromArgb(47, 124, 213);
            btnBranches.Image = Properties.Resources._64pxBranchesblue;
            btnBranches.ImageAlign = ContentAlignment.MiddleLeft;
            btnBranches.Location = new Point(3, 3);
            btnBranches.Name = "btnBranches";
            btnBranches.Size = new Size(210, 67);
            btnBranches.TabIndex = 0;
            btnBranches.Text = "Şube Yönetimi";
            btnBranches.TextAlign = ContentAlignment.MiddleRight;
            btnBranches.UseVisualStyleBackColor = false;
            // 
            // Workplace
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
            Name = "Workplace";
            Text = "Workplace";
            Load += Workplace_Load;
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
        public Button btnExpenses;
        private Button btnBranches;
    }
}