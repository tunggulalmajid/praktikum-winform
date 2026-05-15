namespace praktikum_winform
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
            panel1 = new Panel();
            BtnLogin = new Button();
            label3 = new Label();
            label2 = new Label();
            TbPassword = new TextBox();
            TbUsername = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(BtnLogin);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(TbPassword);
            panel1.Controls.Add(TbUsername);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(357, 93);
            panel1.Name = "panel1";
            panel1.Size = new Size(503, 527);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // BtnLogin
            // 
            BtnLogin.BackColor = SystemColors.Highlight;
            BtnLogin.Location = new Point(186, 344);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(177, 63);
            BtnLogin.TabIndex = 6;
            BtnLogin.Text = "LOGIN";
            BtnLogin.UseVisualStyleBackColor = false;
            BtnLogin.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(138, 259);
            label3.Name = "label3";
            label3.Size = new Size(76, 21);
            label3.TabIndex = 5;
            label3.Text = "Password";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(138, 190);
            label2.Name = "label2";
            label2.Size = new Size(81, 21);
            label2.TabIndex = 4;
            label2.Text = "Username";
            // 
            // TbPassword
            // 
            TbPassword.BackColor = SystemColors.InactiveCaption;
            TbPassword.BorderStyle = BorderStyle.None;
            TbPassword.Font = new Font("Segoe UI", 14F);
            TbPassword.Location = new Point(138, 283);
            TbPassword.Name = "TbPassword";
            TbPassword.PlaceholderText = "Password";
            TbPassword.Size = new Size(270, 25);
            TbPassword.TabIndex = 3;
            // 
            // TbUsername
            // 
            TbUsername.BackColor = SystemColors.InactiveCaption;
            TbUsername.BorderStyle = BorderStyle.None;
            TbUsername.Font = new Font("Segoe UI", 14F);
            TbUsername.Location = new Point(138, 214);
            TbUsername.Name = "TbUsername";
            TbUsername.PlaceholderText = "Username";
            TbUsername.Size = new Size(270, 25);
            TbUsername.TabIndex = 2;
            TbUsername.TextChanged += TbUsername_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(186, 131);
            label1.Name = "label1";
            label1.Size = new Size(163, 32);
            label1.TabIndex = 1;
            label1.Text = "FORM LOGIN";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.android_chrome_512x512__2_;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(225, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(89, 89);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            BackgroundImage = Properties.Resources._6193220;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1149, 712);
            Controls.Add(panel1);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label3;
        private Label label2;
        private TextBox TbPassword;
        private TextBox TbUsername;
        private Button BtnLogin;
    }
}
