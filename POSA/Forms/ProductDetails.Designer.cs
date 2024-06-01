namespace POSA.Forms
{
    partial class ProductDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductDetails));
            btnClose = new CustomObjects.RoundButton();
            lblPageHeaderProductDetails = new Label();
            pnlShadow = new Panel();
            lblName = new Label();
            lblStockPlace = new Label();
            lblStock = new Label();
            lblPrice = new Label();
            btnShowBuyingPrice = new Button();
            tbBuyPrice = new TextBox();
            label6 = new Label();
            label3 = new Label();
            label4 = new Label();
            label1 = new Label();
            label2 = new Label();
            tbSearch = new TextBox();
            rbBackGround = new CustomObjects.RoundButton();
            btnMinimize = new Button();
            pnlPassword = new Panel();
            btnConfirmPass = new Button();
            lblParola = new Label();
            tbPassword = new TextBox();
            pnlShadow.SuspendLayout();
            pnlPassword.SuspendLayout();
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
            // lblPageHeaderProductDetails
            // 
            lblPageHeaderProductDetails.AutoSize = true;
            lblPageHeaderProductDetails.BackColor = Color.Transparent;
            lblPageHeaderProductDetails.Font = new Font("Segoe UI Semibold", 17F, FontStyle.Bold);
            lblPageHeaderProductDetails.ForeColor = Color.White;
            lblPageHeaderProductDetails.Location = new Point(12, 9);
            lblPageHeaderProductDetails.Name = "lblPageHeaderProductDetails";
            lblPageHeaderProductDetails.Size = new Size(203, 31);
            lblPageHeaderProductDetails.TabIndex = 43;
            lblPageHeaderProductDetails.Text = "ÜRÜN DETAY GÖR";
            // 
            // pnlShadow
            // 
            pnlShadow.BackColor = Color.FromArgb(3, 73, 169);
            pnlShadow.Controls.Add(lblName);
            pnlShadow.Controls.Add(lblStockPlace);
            pnlShadow.Controls.Add(lblStock);
            pnlShadow.Controls.Add(lblPrice);
            pnlShadow.Controls.Add(btnShowBuyingPrice);
            pnlShadow.Controls.Add(tbBuyPrice);
            pnlShadow.Controls.Add(label6);
            pnlShadow.Controls.Add(label3);
            pnlShadow.Controls.Add(label4);
            pnlShadow.Controls.Add(label1);
            pnlShadow.Controls.Add(label2);
            pnlShadow.Controls.Add(tbSearch);
            pnlShadow.Controls.Add(rbBackGround);
            pnlShadow.Location = new Point(75, 75);
            pnlShadow.Name = "pnlShadow";
            pnlShadow.Size = new Size(400, 400);
            pnlShadow.TabIndex = 44;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.BackColor = Color.Transparent;
            lblName.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblName.ForeColor = Color.White;
            lblName.Location = new Point(168, 127);
            lblName.Margin = new Padding(3, 15, 3, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(0, 28);
            lblName.TabIndex = 56;
            // 
            // lblStockPlace
            // 
            lblStockPlace.AutoSize = true;
            lblStockPlace.BackColor = Color.Transparent;
            lblStockPlace.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblStockPlace.ForeColor = Color.White;
            lblStockPlace.Location = new Point(168, 170);
            lblStockPlace.Margin = new Padding(3, 15, 3, 0);
            lblStockPlace.Name = "lblStockPlace";
            lblStockPlace.Size = new Size(0, 28);
            lblStockPlace.TabIndex = 55;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.BackColor = Color.Transparent;
            lblStock.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblStock.ForeColor = Color.White;
            lblStock.Location = new Point(168, 213);
            lblStock.Margin = new Padding(3, 15, 3, 0);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(0, 28);
            lblStock.TabIndex = 54;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.BackColor = Color.FromArgb(28, 145, 58);
            lblPrice.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblPrice.ForeColor = Color.White;
            lblPrice.Location = new Point(168, 256);
            lblPrice.Margin = new Padding(3, 15, 3, 0);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(0, 28);
            lblPrice.TabIndex = 53;
            // 
            // btnShowBuyingPrice
            // 
            btnShowBuyingPrice.FlatAppearance.BorderSize = 0;
            btnShowBuyingPrice.FlatStyle = FlatStyle.Flat;
            btnShowBuyingPrice.Image = Properties.Resources._24pxWhiteEye;
            btnShowBuyingPrice.Location = new Point(357, 299);
            btnShowBuyingPrice.Name = "btnShowBuyingPrice";
            btnShowBuyingPrice.Size = new Size(27, 27);
            btnShowBuyingPrice.TabIndex = 52;
            btnShowBuyingPrice.UseVisualStyleBackColor = true;
            btnShowBuyingPrice.Click += btnShowBuyingPrice_Click;
            // 
            // tbBuyPrice
            // 
            tbBuyPrice.BorderStyle = BorderStyle.None;
            tbBuyPrice.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            tbBuyPrice.Location = new Point(168, 300);
            tbBuyPrice.Name = "tbBuyPrice";
            tbBuyPrice.PasswordChar = '*';
            tbBuyPrice.Size = new Size(184, 27);
            tbBuyPrice.TabIndex = 51;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label6.ForeColor = Color.White;
            label6.Location = new Point(12, 299);
            label6.Margin = new Padding(3, 15, 3, 0);
            label6.Name = "label6";
            label6.Size = new Size(97, 28);
            label6.TabIndex = 50;
            label6.Text = "Alış Fiyatı";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.White;
            label3.Location = new Point(12, 256);
            label3.Margin = new Padding(3, 15, 3, 0);
            label3.Name = "label3";
            label3.Size = new Size(107, 28);
            label3.TabIndex = 49;
            label3.Text = "Satış Fiyatı";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.ForeColor = Color.White;
            label4.Location = new Point(12, 213);
            label4.Margin = new Padding(3, 15, 3, 0);
            label4.Name = "label4";
            label4.Size = new Size(106, 28);
            label4.TabIndex = 48;
            label4.Text = "Stok Adeti";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 170);
            label1.Margin = new Padding(3, 15, 3, 0);
            label1.Name = "label1";
            label1.Size = new Size(131, 28);
            label1.TabIndex = 47;
            label1.Text = "Ürün Raf Yeri";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 127);
            label2.Margin = new Padding(3, 15, 3, 0);
            label2.Name = "label2";
            label2.Size = new Size(90, 28);
            label2.TabIndex = 46;
            label2.Text = "Ürün adı";
            // 
            // tbSearch
            // 
            tbSearch.BorderStyle = BorderStyle.None;
            tbSearch.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 162);
            tbSearch.ForeColor = Color.Black;
            tbSearch.Location = new Point(57, 44);
            tbSearch.Name = "tbSearch";
            tbSearch.PlaceholderText = "Barkod okutunuz...";
            tbSearch.Size = new Size(260, 27);
            tbSearch.TabIndex = 1;
            tbSearch.TextAlign = HorizontalAlignment.Center;
            tbSearch.KeyDown += tbSearch_KeyDown;
            // 
            // rbBackGround
            // 
            rbBackGround.BackColor = Color.White;
            rbBackGround.BackgroundColor = Color.White;
            rbBackGround.BorderColor = Color.White;
            rbBackGround.BorderRadius = 20;
            rbBackGround.BorderSize = 0;
            rbBackGround.FlatAppearance.BorderSize = 0;
            rbBackGround.FlatAppearance.MouseDownBackColor = Color.White;
            rbBackGround.FlatAppearance.MouseOverBackColor = Color.White;
            rbBackGround.FlatStyle = FlatStyle.Flat;
            rbBackGround.ForeColor = Color.White;
            rbBackGround.Image = Properties.Resources._24pxEye;
            rbBackGround.ImageAlign = ContentAlignment.MiddleRight;
            rbBackGround.Location = new Point(45, 39);
            rbBackGround.Name = "rbBackGround";
            rbBackGround.Size = new Size(307, 40);
            rbBackGround.TabIndex = 0;
            rbBackGround.Text = "roundButton1";
            rbBackGround.TextColor = Color.White;
            rbBackGround.UseVisualStyleBackColor = false;
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
            // pnlPassword
            // 
            pnlPassword.BackColor = Color.White;
            pnlPassword.BorderStyle = BorderStyle.FixedSingle;
            pnlPassword.Controls.Add(btnConfirmPass);
            pnlPassword.Controls.Add(lblParola);
            pnlPassword.Controls.Add(tbPassword);
            pnlPassword.Location = new Point(267, 268);
            pnlPassword.Name = "pnlPassword";
            pnlPassword.Size = new Size(192, 100);
            pnlPassword.TabIndex = 57;
            pnlPassword.Visible = false;
            // 
            // btnConfirmPass
            // 
            btnConfirmPass.FlatStyle = FlatStyle.Flat;
            btnConfirmPass.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnConfirmPass.Location = new Point(3, 65);
            btnConfirmPass.Name = "btnConfirmPass";
            btnConfirmPass.Size = new Size(186, 30);
            btnConfirmPass.TabIndex = 58;
            btnConfirmPass.Text = "Giriş";
            btnConfirmPass.TextAlign = ContentAlignment.TopCenter;
            btnConfirmPass.UseVisualStyleBackColor = true;
            btnConfirmPass.Click += btnConfirmPass_Click;
            // 
            // lblParola
            // 
            lblParola.AutoSize = true;
            lblParola.BackColor = Color.Transparent;
            lblParola.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblParola.ForeColor = Color.Black;
            lblParola.Location = new Point(3, 0);
            lblParola.Margin = new Padding(3, 15, 3, 0);
            lblParola.Name = "lblParola";
            lblParola.Size = new Size(67, 28);
            lblParola.TabIndex = 57;
            lblParola.Text = "Parola";
            // 
            // tbPassword
            // 
            tbPassword.BorderStyle = BorderStyle.FixedSingle;
            tbPassword.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            tbPassword.Location = new Point(3, 31);
            tbPassword.Name = "tbPassword";
            tbPassword.PasswordChar = '*';
            tbPassword.Size = new Size(186, 31);
            tbPassword.TabIndex = 57;
            tbPassword.KeyDown += tbPassword_KeyDown;
            // 
            // ProductDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.BackgroundSmall1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(550, 550);
            Controls.Add(pnlPassword);
            Controls.Add(btnMinimize);
            Controls.Add(pnlShadow);
            Controls.Add(lblPageHeaderProductDetails);
            Controls.Add(btnClose);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProductDetails";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddCategory";
            MouseDown += ProductDetails_MouseDown;
            pnlShadow.ResumeLayout(false);
            pnlShadow.PerformLayout();
            pnlPassword.ResumeLayout(false);
            pnlPassword.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomObjects.RoundButton btnClose;
        private Label lblPageHeaderProductDetails;
        private Panel pnlShadow;
        private Button btnMinimize;
        private TextBox tbSearch;
        private CustomObjects.RoundButton rbBackGround;
        private Label lblStock;
        private Label lblPrice;
        private Button btnShowBuyingPrice;
        private TextBox tbBuyPrice;
        private Label label6;
        private Label label3;
        private Label label4;
        private Label label1;
        private Label label2;
        private Label lblName;
        private Label lblStockPlace;
        private Panel pnlPassword;
        private Button btnConfirmPass;
        private Label lblParola;
        private TextBox tbPassword;
    }
}