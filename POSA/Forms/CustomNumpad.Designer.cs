namespace POSA.Forms
{
    partial class CustomNumpad
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
            btnClose = new CustomObjects.RoundButton();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btnClear = new Button();
            btn0 = new Button();
            btnDot = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btn1 = new Button();
            tmr = new System.Windows.Forms.Timer(components);
            btnEnter = new Button();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.BackColor = Color.Transparent;
            btnClose.BackgroundColor = Color.Transparent;
            btnClose.BackgroundImage = Properties.Resources._24pxWhiteX;
            btnClose.BackgroundImageLayout = ImageLayout.Center;
            btnClose.BorderColor = Color.PaleVioletRed;
            btnClose.BorderRadius = 0;
            btnClose.BorderSize = 0;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(208, 1, 27);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(232, 8);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(45, 28);
            btnClose.TabIndex = 34;
            btnClose.TextColor = Color.White;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btn7
            // 
            btn7.BackColor = Color.White;
            btn7.FlatAppearance.BorderSize = 0;
            btn7.FlatStyle = FlatStyle.Flat;
            btn7.Font = new Font("Segoe UI Semibold", 35F, FontStyle.Bold);
            btn7.ForeColor = Color.FromArgb(1, 72, 172);
            btn7.Location = new Point(10, 45);
            btn7.Margin = new Padding(1);
            btn7.Name = "btn7";
            btn7.Size = new Size(85, 85);
            btn7.TabIndex = 35;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += btnGeneralNumbers_Click;
            // 
            // btn8
            // 
            btn8.BackColor = Color.White;
            btn8.FlatAppearance.BorderSize = 0;
            btn8.FlatStyle = FlatStyle.Flat;
            btn8.Font = new Font("Segoe UI Semibold", 35F, FontStyle.Bold);
            btn8.ForeColor = Color.FromArgb(1, 72, 172);
            btn8.Location = new Point(97, 45);
            btn8.Margin = new Padding(1);
            btn8.Name = "btn8";
            btn8.Size = new Size(85, 85);
            btn8.TabIndex = 36;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += btnGeneralNumbers_Click;
            // 
            // btn9
            // 
            btn9.BackColor = Color.White;
            btn9.FlatAppearance.BorderSize = 0;
            btn9.FlatStyle = FlatStyle.Flat;
            btn9.Font = new Font("Segoe UI Semibold", 35F, FontStyle.Bold);
            btn9.ForeColor = Color.FromArgb(1, 72, 172);
            btn9.Location = new Point(184, 45);
            btn9.Margin = new Padding(1);
            btn9.Name = "btn9";
            btn9.Size = new Size(85, 85);
            btn9.TabIndex = 37;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += btnGeneralNumbers_Click;
            // 
            // btn6
            // 
            btn6.BackColor = Color.White;
            btn6.FlatAppearance.BorderSize = 0;
            btn6.FlatStyle = FlatStyle.Flat;
            btn6.Font = new Font("Segoe UI Semibold", 35F, FontStyle.Bold);
            btn6.ForeColor = Color.FromArgb(1, 72, 172);
            btn6.Location = new Point(184, 132);
            btn6.Margin = new Padding(1);
            btn6.Name = "btn6";
            btn6.Size = new Size(85, 85);
            btn6.TabIndex = 40;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += btnGeneralNumbers_Click;
            // 
            // btn5
            // 
            btn5.BackColor = Color.White;
            btn5.FlatAppearance.BorderSize = 0;
            btn5.FlatStyle = FlatStyle.Flat;
            btn5.Font = new Font("Segoe UI Semibold", 35F, FontStyle.Bold);
            btn5.ForeColor = Color.FromArgb(1, 72, 172);
            btn5.Location = new Point(97, 132);
            btn5.Margin = new Padding(1);
            btn5.Name = "btn5";
            btn5.Size = new Size(85, 85);
            btn5.TabIndex = 39;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += btnGeneralNumbers_Click;
            // 
            // btn4
            // 
            btn4.BackColor = Color.White;
            btn4.FlatAppearance.BorderSize = 0;
            btn4.FlatStyle = FlatStyle.Flat;
            btn4.Font = new Font("Segoe UI Semibold", 35F, FontStyle.Bold);
            btn4.ForeColor = Color.FromArgb(1, 72, 172);
            btn4.Location = new Point(10, 132);
            btn4.Margin = new Padding(1);
            btn4.Name = "btn4";
            btn4.Size = new Size(85, 85);
            btn4.TabIndex = 38;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += btnGeneralNumbers_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.White;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnClear.ForeColor = Color.FromArgb(1, 72, 172);
            btnClear.Image = Properties.Resources._64pxEraserBlue;
            btnClear.Location = new Point(184, 306);
            btnClear.Margin = new Padding(1);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(85, 85);
            btnClear.TabIndex = 46;
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btn0
            // 
            btn0.BackColor = Color.White;
            btn0.FlatAppearance.BorderSize = 0;
            btn0.FlatStyle = FlatStyle.Flat;
            btn0.Font = new Font("Segoe UI Semibold", 35F, FontStyle.Bold);
            btn0.ForeColor = Color.FromArgb(1, 72, 172);
            btn0.Location = new Point(97, 306);
            btn0.Margin = new Padding(1);
            btn0.Name = "btn0";
            btn0.Size = new Size(85, 85);
            btn0.TabIndex = 45;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            btn0.Click += btnGeneralNumbers_Click;
            // 
            // btnDot
            // 
            btnDot.BackColor = Color.White;
            btnDot.FlatAppearance.BorderSize = 0;
            btnDot.FlatStyle = FlatStyle.Flat;
            btnDot.Font = new Font("Segoe UI Semibold", 35F, FontStyle.Bold);
            btnDot.ForeColor = Color.FromArgb(1, 72, 172);
            btnDot.Location = new Point(10, 306);
            btnDot.Margin = new Padding(1);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(85, 85);
            btnDot.TabIndex = 44;
            btnDot.Text = ".";
            btnDot.UseVisualStyleBackColor = false;
            btnDot.Click += btnDot_Click;
            // 
            // btn3
            // 
            btn3.BackColor = Color.White;
            btn3.FlatAppearance.BorderSize = 0;
            btn3.FlatStyle = FlatStyle.Flat;
            btn3.Font = new Font("Segoe UI Semibold", 35F, FontStyle.Bold);
            btn3.ForeColor = Color.FromArgb(1, 72, 172);
            btn3.Location = new Point(184, 219);
            btn3.Margin = new Padding(1);
            btn3.Name = "btn3";
            btn3.Size = new Size(85, 85);
            btn3.TabIndex = 43;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += btnGeneralNumbers_Click;
            // 
            // btn2
            // 
            btn2.BackColor = Color.White;
            btn2.FlatAppearance.BorderSize = 0;
            btn2.FlatStyle = FlatStyle.Flat;
            btn2.Font = new Font("Segoe UI Semibold", 35F, FontStyle.Bold);
            btn2.ForeColor = Color.FromArgb(1, 72, 172);
            btn2.Location = new Point(97, 219);
            btn2.Margin = new Padding(1);
            btn2.Name = "btn2";
            btn2.Size = new Size(85, 85);
            btn2.TabIndex = 42;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += btnGeneralNumbers_Click;
            // 
            // btn1
            // 
            btn1.BackColor = Color.White;
            btn1.FlatAppearance.BorderSize = 0;
            btn1.FlatStyle = FlatStyle.Flat;
            btn1.Font = new Font("Segoe UI Semibold", 35F, FontStyle.Bold);
            btn1.ForeColor = Color.FromArgb(1, 72, 172);
            btn1.Location = new Point(10, 219);
            btn1.Margin = new Padding(1);
            btn1.Name = "btn1";
            btn1.Size = new Size(85, 85);
            btn1.TabIndex = 41;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += btnGeneralNumbers_Click;
            // 
            // tmr
            // 
            tmr.Tick += tmr_Tick;
            // 
            // btnEnter
            // 
            btnEnter.BackColor = Color.White;
            btnEnter.FlatAppearance.BorderSize = 0;
            btnEnter.FlatStyle = FlatStyle.Flat;
            btnEnter.Font = new Font("Segoe UI Semibold", 25F, FontStyle.Bold);
            btnEnter.ForeColor = Color.FromArgb(1, 72, 172);
            btnEnter.Location = new Point(10, 393);
            btnEnter.Margin = new Padding(1);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(259, 85);
            btnEnter.TabIndex = 47;
            btnEnter.Text = "TAMAM";
            btnEnter.UseVisualStyleBackColor = false;
            btnEnter.Click += btnEnter_Click;
            // 
            // CustomNumpad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.BackgroundSmall1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(280, 493);
            Controls.Add(btnEnter);
            Controls.Add(btnClear);
            Controls.Add(btn0);
            Controls.Add(btnDot);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btnClose);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "CustomNumpad";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddCategory";
            MouseDown += CustomNumpad_MouseDown;
            ResumeLayout(false);
        }

        #endregion

        private CustomObjects.RoundButton btnClose;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btnClear;
        private Button btn0;
        private Button btnDot;
        private Button btn3;
        private Button btn2;
        private Button btn1;
        private System.Windows.Forms.Timer tmr;
        private Button btnEnter;
    }
}