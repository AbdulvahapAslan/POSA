namespace POSA
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            tbUsername = new TextBox();
            tbPassword = new TextBox();
            pboxUser = new PictureBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            btnOne = new CustomObjects.RoundButton();
            btnTwo = new CustomObjects.RoundButton();
            btnThree = new CustomObjects.RoundButton();
            btnLogin = new CustomObjects.RoundButton();
            btnZero = new CustomObjects.RoundButton();
            btnClearPass = new CustomObjects.RoundButton();
            btnClose = new CustomObjects.RoundButton();
            btnSix = new CustomObjects.RoundButton();
            btnFive = new CustomObjects.RoundButton();
            btnFour = new CustomObjects.RoundButton();
            btnEight = new CustomObjects.RoundButton();
            btnSeven = new CustomObjects.RoundButton();
            btnNine = new CustomObjects.RoundButton();
            lblWrongPassword = new Label();
            chkRememberMe = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pboxUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tbUsername
            // 
            tbUsername.BorderStyle = BorderStyle.FixedSingle;
            tbUsername.Font = new Font("Segoe UI", 15F);
            tbUsername.ForeColor = Color.FromArgb(2, 69, 171);
            tbUsername.Location = new Point(770, 123);
            tbUsername.Name = "tbUsername";
            tbUsername.PlaceholderText = "Kullanıcı adı";
            tbUsername.Size = new Size(206, 34);
            tbUsername.TabIndex = 1;
            // 
            // tbPassword
            // 
            tbPassword.BorderStyle = BorderStyle.FixedSingle;
            tbPassword.Font = new Font("Segoe UI", 15F);
            tbPassword.ForeColor = Color.FromArgb(2, 69, 171);
            tbPassword.Location = new Point(770, 169);
            tbPassword.Name = "tbPassword";
            tbPassword.PasswordChar = '*';
            tbPassword.PlaceholderText = "Şifre";
            tbPassword.Size = new Size(206, 34);
            tbPassword.TabIndex = 2;
            tbPassword.WordWrap = false;
            // 
            // pboxUser
            // 
            pboxUser.BackColor = Color.Transparent;
            pboxUser.BackgroundImage = (Image)resources.GetObject("pboxUser.BackgroundImage");
            pboxUser.BackgroundImageLayout = ImageLayout.Stretch;
            pboxUser.ErrorImage = null;
            pboxUser.InitialImage = null;
            pboxUser.Location = new Point(724, 117);
            pboxUser.Name = "pboxUser";
            pboxUser.Size = new Size(40, 40);
            pboxUser.TabIndex = 3;
            pboxUser.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.ErrorImage = null;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(724, 163);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 40);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.White;
            label1.Location = new Point(110, 15);
            label1.Name = "label1";
            label1.Size = new Size(136, 25);
            label1.TabIndex = 20;
            label1.Text = "Satış Programı";
            // 
            // btnOne
            // 
            btnOne.BackColor = Color.White;
            btnOne.BackgroundColor = Color.White;
            btnOne.BorderColor = Color.PaleVioletRed;
            btnOne.BorderRadius = 3;
            btnOne.BorderSize = 0;
            btnOne.FlatAppearance.BorderSize = 0;
            btnOne.FlatStyle = FlatStyle.Flat;
            btnOne.Font = new Font("MS Reference Sans Serif", 20F);
            btnOne.ForeColor = Color.FromArgb(2, 69, 171);
            btnOne.Location = new Point(732, 222);
            btnOne.Name = "btnOne";
            btnOne.Size = new Size(60, 60);
            btnOne.TabIndex = 21;
            btnOne.Text = "1";
            btnOne.TextColor = Color.FromArgb(2, 69, 171);
            btnOne.UseVisualStyleBackColor = false;
            btnOne.Click += btnOne_Click;
            // 
            // btnTwo
            // 
            btnTwo.BackColor = Color.White;
            btnTwo.BackgroundColor = Color.White;
            btnTwo.BorderColor = Color.PaleVioletRed;
            btnTwo.BorderRadius = 3;
            btnTwo.BorderSize = 0;
            btnTwo.FlatAppearance.BorderSize = 0;
            btnTwo.FlatStyle = FlatStyle.Flat;
            btnTwo.Font = new Font("MS Reference Sans Serif", 20F);
            btnTwo.ForeColor = Color.FromArgb(2, 69, 171);
            btnTwo.Location = new Point(824, 222);
            btnTwo.Name = "btnTwo";
            btnTwo.Size = new Size(60, 60);
            btnTwo.TabIndex = 22;
            btnTwo.Text = "2";
            btnTwo.TextColor = Color.FromArgb(2, 69, 171);
            btnTwo.UseVisualStyleBackColor = false;
            btnTwo.Click += btnTwo_Click;
            // 
            // btnThree
            // 
            btnThree.BackColor = Color.White;
            btnThree.BackgroundColor = Color.White;
            btnThree.BorderColor = Color.PaleVioletRed;
            btnThree.BorderRadius = 3;
            btnThree.BorderSize = 0;
            btnThree.FlatAppearance.BorderSize = 0;
            btnThree.FlatStyle = FlatStyle.Flat;
            btnThree.Font = new Font("MS Reference Sans Serif", 20F);
            btnThree.ForeColor = Color.FromArgb(2, 69, 171);
            btnThree.Location = new Point(916, 222);
            btnThree.Name = "btnThree";
            btnThree.Size = new Size(60, 60);
            btnThree.TabIndex = 23;
            btnThree.Text = "3";
            btnThree.TextColor = Color.FromArgb(2, 69, 171);
            btnThree.UseVisualStyleBackColor = false;
            btnThree.Click += btnThree_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.White;
            btnLogin.BackgroundColor = Color.White;
            btnLogin.BackgroundImage = (Image)resources.GetObject("btnLogin.BackgroundImage");
            btnLogin.BackgroundImageLayout = ImageLayout.Center;
            btnLogin.BorderColor = Color.PaleVioletRed;
            btnLogin.BorderRadius = 3;
            btnLogin.BorderSize = 0;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 19F);
            btnLogin.ForeColor = Color.FromArgb(2, 69, 171);
            btnLogin.Location = new Point(916, 420);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(95, 95);
            btnLogin.TabIndex = 32;
            btnLogin.TextAlign = ContentAlignment.TopRight;
            btnLogin.TextColor = Color.FromArgb(2, 69, 171);
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnZero
            // 
            btnZero.BackColor = Color.White;
            btnZero.BackgroundColor = Color.White;
            btnZero.BorderColor = Color.PaleVioletRed;
            btnZero.BorderRadius = 3;
            btnZero.BorderSize = 0;
            btnZero.FlatAppearance.BorderSize = 0;
            btnZero.FlatStyle = FlatStyle.Flat;
            btnZero.Font = new Font("MS Reference Sans Serif", 20F);
            btnZero.ForeColor = Color.FromArgb(2, 69, 171);
            btnZero.Location = new Point(824, 420);
            btnZero.Name = "btnZero";
            btnZero.Size = new Size(60, 60);
            btnZero.TabIndex = 31;
            btnZero.Text = "0";
            btnZero.TextColor = Color.FromArgb(2, 69, 171);
            btnZero.UseVisualStyleBackColor = false;
            btnZero.Click += btnZero_Click;
            // 
            // btnClearPass
            // 
            btnClearPass.BackColor = Color.White;
            btnClearPass.BackgroundColor = Color.White;
            btnClearPass.BackgroundImage = (Image)resources.GetObject("btnClearPass.BackgroundImage");
            btnClearPass.BackgroundImageLayout = ImageLayout.Center;
            btnClearPass.BorderColor = Color.PaleVioletRed;
            btnClearPass.BorderRadius = 3;
            btnClearPass.BorderSize = 0;
            btnClearPass.FlatAppearance.BorderSize = 0;
            btnClearPass.FlatStyle = FlatStyle.Flat;
            btnClearPass.Font = new Font("Segoe UI", 19F);
            btnClearPass.ForeColor = Color.FromArgb(2, 69, 171);
            btnClearPass.Location = new Point(732, 420);
            btnClearPass.Name = "btnClearPass";
            btnClearPass.Size = new Size(60, 60);
            btnClearPass.TabIndex = 30;
            btnClearPass.TextAlign = ContentAlignment.TopRight;
            btnClearPass.TextColor = Color.FromArgb(2, 69, 171);
            btnClearPass.UseVisualStyleBackColor = false;
            btnClearPass.Click += btnClearPass_Click;
            // 
            // btnClose
            // 
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
            btnClose.Location = new Point(1091, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(28, 28);
            btnClose.TabIndex = 33;
            btnClose.TextColor = Color.White;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnSix
            // 
            btnSix.BackColor = Color.White;
            btnSix.BackgroundColor = Color.White;
            btnSix.BorderColor = Color.PaleVioletRed;
            btnSix.BorderRadius = 3;
            btnSix.BorderSize = 0;
            btnSix.FlatAppearance.BorderSize = 0;
            btnSix.FlatStyle = FlatStyle.Flat;
            btnSix.Font = new Font("MS Reference Sans Serif", 20F);
            btnSix.ForeColor = Color.FromArgb(2, 69, 171);
            btnSix.Location = new Point(916, 288);
            btnSix.Name = "btnSix";
            btnSix.Size = new Size(60, 60);
            btnSix.TabIndex = 36;
            btnSix.Text = "6";
            btnSix.TextColor = Color.FromArgb(2, 69, 171);
            btnSix.UseVisualStyleBackColor = false;
            btnSix.Click += btnSix_Click;
            // 
            // btnFive
            // 
            btnFive.BackColor = Color.White;
            btnFive.BackgroundColor = Color.White;
            btnFive.BorderColor = Color.PaleVioletRed;
            btnFive.BorderRadius = 3;
            btnFive.BorderSize = 0;
            btnFive.FlatAppearance.BorderSize = 0;
            btnFive.FlatStyle = FlatStyle.Flat;
            btnFive.Font = new Font("MS Reference Sans Serif", 20F);
            btnFive.ForeColor = Color.FromArgb(2, 69, 171);
            btnFive.Location = new Point(824, 288);
            btnFive.Name = "btnFive";
            btnFive.Size = new Size(60, 60);
            btnFive.TabIndex = 35;
            btnFive.Text = "5";
            btnFive.TextColor = Color.FromArgb(2, 69, 171);
            btnFive.UseVisualStyleBackColor = false;
            btnFive.Click += btnFive_Click;
            // 
            // btnFour
            // 
            btnFour.BackColor = Color.White;
            btnFour.BackgroundColor = Color.White;
            btnFour.BorderColor = Color.PaleVioletRed;
            btnFour.BorderRadius = 3;
            btnFour.BorderSize = 0;
            btnFour.FlatAppearance.BorderSize = 0;
            btnFour.FlatStyle = FlatStyle.Flat;
            btnFour.Font = new Font("MS Reference Sans Serif", 20F);
            btnFour.ForeColor = Color.FromArgb(2, 69, 171);
            btnFour.Location = new Point(732, 288);
            btnFour.Name = "btnFour";
            btnFour.Size = new Size(60, 60);
            btnFour.TabIndex = 34;
            btnFour.Text = "4";
            btnFour.TextColor = Color.FromArgb(2, 69, 171);
            btnFour.UseVisualStyleBackColor = false;
            btnFour.Click += btnFour_Click;
            // 
            // btnEight
            // 
            btnEight.BackColor = Color.White;
            btnEight.BackgroundColor = Color.White;
            btnEight.BorderColor = Color.PaleVioletRed;
            btnEight.BorderRadius = 3;
            btnEight.BorderSize = 0;
            btnEight.FlatAppearance.BorderSize = 0;
            btnEight.FlatStyle = FlatStyle.Flat;
            btnEight.Font = new Font("MS Reference Sans Serif", 20F);
            btnEight.ForeColor = Color.FromArgb(2, 69, 171);
            btnEight.Location = new Point(824, 354);
            btnEight.Name = "btnEight";
            btnEight.Size = new Size(60, 60);
            btnEight.TabIndex = 38;
            btnEight.Text = "8";
            btnEight.TextColor = Color.FromArgb(2, 69, 171);
            btnEight.UseVisualStyleBackColor = false;
            btnEight.Click += btnEight_Click;
            // 
            // btnSeven
            // 
            btnSeven.BackColor = Color.White;
            btnSeven.BackgroundColor = Color.White;
            btnSeven.BorderColor = Color.PaleVioletRed;
            btnSeven.BorderRadius = 3;
            btnSeven.BorderSize = 0;
            btnSeven.FlatAppearance.BorderSize = 0;
            btnSeven.FlatStyle = FlatStyle.Flat;
            btnSeven.Font = new Font("MS Reference Sans Serif", 20F);
            btnSeven.ForeColor = Color.FromArgb(2, 69, 171);
            btnSeven.Location = new Point(732, 354);
            btnSeven.Name = "btnSeven";
            btnSeven.Size = new Size(60, 60);
            btnSeven.TabIndex = 37;
            btnSeven.Text = "7";
            btnSeven.TextColor = Color.FromArgb(2, 69, 171);
            btnSeven.UseVisualStyleBackColor = false;
            btnSeven.Click += btnSeven_Click;
            // 
            // btnNine
            // 
            btnNine.BackColor = Color.White;
            btnNine.BackgroundColor = Color.White;
            btnNine.BorderColor = Color.PaleVioletRed;
            btnNine.BorderRadius = 3;
            btnNine.BorderSize = 0;
            btnNine.FlatAppearance.BorderSize = 0;
            btnNine.FlatStyle = FlatStyle.Flat;
            btnNine.Font = new Font("MS Reference Sans Serif", 20F);
            btnNine.ForeColor = Color.FromArgb(2, 69, 171);
            btnNine.Location = new Point(916, 354);
            btnNine.Name = "btnNine";
            btnNine.Size = new Size(60, 60);
            btnNine.TabIndex = 39;
            btnNine.Text = "9";
            btnNine.TextColor = Color.FromArgb(2, 69, 171);
            btnNine.UseVisualStyleBackColor = false;
            btnNine.Click += btnNine_Click;
            // 
            // lblWrongPassword
            // 
            lblWrongPassword.AutoSize = true;
            lblWrongPassword.BackColor = Color.Transparent;
            lblWrongPassword.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblWrongPassword.ForeColor = Color.White;
            lblWrongPassword.Location = new Point(732, 530);
            lblWrongPassword.Name = "lblWrongPassword";
            lblWrongPassword.Size = new Size(278, 20);
            lblWrongPassword.TabIndex = 40;
            lblWrongPassword.Text = "Bilgileri kontrol ederek tekrar deneyin!";
            lblWrongPassword.Visible = false;
            // 
            // chkRememberMe
            // 
            chkRememberMe.AutoSize = true;
            chkRememberMe.BackColor = Color.Transparent;
            chkRememberMe.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            chkRememberMe.ForeColor = Color.White;
            chkRememberMe.Location = new Point(732, 490);
            chkRememberMe.Name = "chkRememberMe";
            chkRememberMe.Size = new Size(119, 25);
            chkRememberMe.TabIndex = 41;
            chkRememberMe.Text = "Beni Hatırla";
            chkRememberMe.UseVisualStyleBackColor = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(48, 110, 185);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1131, 636);
            Controls.Add(chkRememberMe);
            Controls.Add(lblWrongPassword);
            Controls.Add(btnNine);
            Controls.Add(btnEight);
            Controls.Add(btnSeven);
            Controls.Add(btnSix);
            Controls.Add(btnFive);
            Controls.Add(btnFour);
            Controls.Add(btnClose);
            Controls.Add(btnLogin);
            Controls.Add(btnZero);
            Controls.Add(btnClearPass);
            Controls.Add(btnThree);
            Controls.Add(btnTwo);
            Controls.Add(btnOne);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(pboxUser);
            Controls.Add(tbPassword);
            Controls.Add(tbUsername);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(1131, 636);
            MinimumSize = new Size(1131, 636);
            Name = "Login";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "POSA Giriş";
            Load += Login_Load;
            MouseDown += Login_MouseDown;
            ((System.ComponentModel.ISupportInitialize)pboxUser).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomObjects.RoundButton btnClose;
        private TextBox tbUsername;
        private TextBox tbPassword;
        private PictureBox pboxUser;
        private PictureBox pictureBox1;
        private Label label1;
        private CustomObjects.RoundButton btnOne;
        private CustomObjects.RoundButton btnTwo;
        private CustomObjects.RoundButton btnThree;
        private CustomObjects.RoundButton btnLogin;
        private CustomObjects.RoundButton btnZero;
        private CustomObjects.RoundButton btnClearPass;
        private CustomObjects.RoundButton btnSix;
        private CustomObjects.RoundButton btnFive;
        private CustomObjects.RoundButton btnFour;
        private CustomObjects.RoundButton btnEight;
        private CustomObjects.RoundButton btnSeven;
        private CustomObjects.RoundButton btnNine;
        private Label lblWrongPassword;
        private CheckBox chkRememberMe;
    }
}
