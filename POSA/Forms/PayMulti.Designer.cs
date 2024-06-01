namespace POSA.Forms
{
    partial class PayMulti
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PayMulti));
            btnClose = new CustomObjects.RoundButton();
            lblPageHeaderPayMulti = new Label();
            pnlShadow = new Panel();
            tbCard = new TextBox();
            tbCash = new TextBox();
            lblTotalPrice = new Label();
            label2 = new Label();
            btnCancel = new Button();
            btnSave = new Button();
            btnMinimize = new Button();
            pnlShadow.SuspendLayout();
            SuspendLayout();
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
            btnClose.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(505, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(28, 28);
            btnClose.TabIndex = 34;
            btnClose.TextColor = Color.White;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // lblPageHeaderPayMulti
            // 
            lblPageHeaderPayMulti.AutoSize = true;
            lblPageHeaderPayMulti.BackColor = Color.Transparent;
            lblPageHeaderPayMulti.Font = new Font("Segoe UI Semibold", 17F, FontStyle.Bold);
            lblPageHeaderPayMulti.ForeColor = Color.White;
            lblPageHeaderPayMulti.Location = new Point(12, 9);
            lblPageHeaderPayMulti.Name = "lblPageHeaderPayMulti";
            lblPageHeaderPayMulti.Size = new Size(170, 31);
            lblPageHeaderPayMulti.TabIndex = 43;
            lblPageHeaderPayMulti.Text = "ÇOKLU ÖDEME";
            // 
            // pnlShadow
            // 
            pnlShadow.BackColor = Color.FromArgb(3, 73, 169);
            pnlShadow.Controls.Add(tbCard);
            pnlShadow.Controls.Add(tbCash);
            pnlShadow.Controls.Add(lblTotalPrice);
            pnlShadow.Controls.Add(label2);
            pnlShadow.Controls.Add(btnCancel);
            pnlShadow.Controls.Add(btnSave);
            pnlShadow.Location = new Point(75, 152);
            pnlShadow.Margin = new Padding(66, 143, 66, 143);
            pnlShadow.Name = "pnlShadow";
            pnlShadow.Size = new Size(400, 246);
            pnlShadow.TabIndex = 44;
            // 
            // tbCard
            // 
            tbCard.BorderStyle = BorderStyle.None;
            tbCard.Font = new Font("Segoe UI Semibold", 25F, FontStyle.Bold);
            tbCard.Location = new Point(10, 112);
            tbCard.Name = "tbCard";
            tbCard.PlaceholderText = "KARTLA ÖDENEN";
            tbCard.Size = new Size(380, 45);
            tbCard.TabIndex = 80;
            tbCard.TextChanged += tbCard_TextChanged;
            tbCard.KeyPress += tbCard_KeyPress;
            // 
            // tbCash
            // 
            tbCash.BorderStyle = BorderStyle.None;
            tbCash.Font = new Font("Segoe UI Semibold", 25F, FontStyle.Bold);
            tbCash.Location = new Point(10, 61);
            tbCash.Name = "tbCash";
            tbCash.PlaceholderText = "NAKİT ÖDENEN";
            tbCash.Size = new Size(380, 45);
            tbCash.TabIndex = 79;
            tbCash.TextChanged += tbCash_TextChanged;
            tbCash.KeyPress += tbCash_KeyPress;
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.BackColor = Color.Transparent;
            lblTotalPrice.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            lblTotalPrice.ForeColor = Color.White;
            lblTotalPrice.Location = new Point(232, 10);
            lblTotalPrice.Margin = new Padding(3, 15, 3, 0);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(0, 37);
            lblTotalPrice.TabIndex = 78;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(10, 10);
            label2.Margin = new Padding(3, 15, 3, 0);
            label2.Name = "label2";
            label2.Size = new Size(216, 37);
            label2.TabIndex = 77;
            label2.Text = "Ödenecek Tutar:";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(255, 59, 59);
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            btnCancel.ForeColor = Color.White;
            btnCancel.Image = Properties.Resources._64pxWhiteX50Scale1;
            btnCancel.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancel.Location = new Point(10, 170);
            btnCancel.Margin = new Padding(10);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(185, 66);
            btnCancel.TabIndex = 75;
            btnCancel.Text = "İPTAL       ";
            btnCancel.TextAlign = ContentAlignment.MiddleRight;
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(66, 178, 38);
            btnSave.DialogResult = DialogResult.OK;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Image = Properties.Resources._64pxGreenCheck;
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(205, 170);
            btnSave.Margin = new Padding(10);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(185, 66);
            btnSave.TabIndex = 74;
            btnSave.Text = "KAYDET      ";
            btnSave.TextAlign = ContentAlignment.MiddleRight;
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
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
            btnMinimize.Location = new Point(471, 12);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(28, 28);
            btnMinimize.TabIndex = 45;
            btnMinimize.UseVisualStyleBackColor = false;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // PayMulti
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.BackgroundSmall1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(550, 550);
            Controls.Add(btnMinimize);
            Controls.Add(pnlShadow);
            Controls.Add(lblPageHeaderPayMulti);
            Controls.Add(btnClose);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "PayMulti";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddCategory";
            Load += PayMulti_Load;
            MouseDown += ProductDetails_MouseDown;
            pnlShadow.ResumeLayout(false);
            pnlShadow.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomObjects.RoundButton btnClose;
        private Label lblPageHeaderPayMulti;
        private Panel pnlShadow;
        private Button btnMinimize;
        private Button btnSave;
        private Button btnCancel;
        private Label lblTotalPrice;
        private Label label2;
        private TextBox tbCard;
        private TextBox tbCash;
    }
}