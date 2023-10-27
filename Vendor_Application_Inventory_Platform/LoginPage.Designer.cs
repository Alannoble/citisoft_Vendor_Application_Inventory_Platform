namespace Vendor_Application_Inventory_Platform
{
    partial class LoginPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            SignUp_button = new Button();
            Login_button = new Button();
            Password_textBox1 = new TextBox();
            Username_textBox = new TextBox();
            Password_label = new Label();
            username_label = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            Forgotpassword_button = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // SignUp_button
            // 
            SignUp_button.BackColor = Color.RoyalBlue;
            SignUp_button.Location = new Point(811, 1173);
            SignUp_button.Margin = new Padding(7, 8, 7, 8);
            SignUp_button.Name = "SignUp_button";
            SignUp_button.Size = new Size(294, 90);
            SignUp_button.TabIndex = 0;
            SignUp_button.Text = "Sign Up";
            SignUp_button.UseVisualStyleBackColor = false;
            SignUp_button.Click += button1_Click;
            // 
            // Login_button
            // 
            Login_button.BackColor = Color.RoyalBlue;
            Login_button.Location = new Point(1199, 1173);
            Login_button.Margin = new Padding(7, 8, 7, 8);
            Login_button.Name = "Login_button";
            Login_button.Size = new Size(272, 90);
            Login_button.TabIndex = 1;
            Login_button.Text = "Login";
            Login_button.UseVisualStyleBackColor = false;
            Login_button.Click += button2_Click;
            // 
            // Password_textBox1
            // 
            Password_textBox1.Location = new Point(811, 973);
            Password_textBox1.Margin = new Padding(7, 8, 7, 8);
            Password_textBox1.Name = "Password_textBox1";
            Password_textBox1.Size = new Size(645, 47);
            Password_textBox1.TabIndex = 2;
            Password_textBox1.UseSystemPasswordChar = true;
            Password_textBox1.TextChanged += textBox1_TextChanged;
            // 
            // Username_textBox
            // 
            Username_textBox.BackColor = SystemColors.Window;
            Username_textBox.Location = new Point(811, 806);
            Username_textBox.Margin = new Padding(7, 8, 7, 8);
            Username_textBox.Multiline = true;
            Username_textBox.Name = "Username_textBox";
            Username_textBox.Size = new Size(645, 56);
            Username_textBox.TabIndex = 3;
            Username_textBox.TextChanged += textBox2_TextChanged;
            // 
            // Password_label
            // 
            Password_label.AutoEllipsis = true;
            Password_label.AutoSize = true;
            Password_label.BackColor = Color.Transparent;
            Password_label.FlatStyle = FlatStyle.Popup;
            Password_label.ForeColor = SystemColors.Window;
            Password_label.Location = new Point(501, 979);
            Password_label.Margin = new Padding(7, 0, 7, 0);
            Password_label.Name = "Password_label";
            Password_label.Size = new Size(143, 41);
            Password_label.TabIndex = 5;
            Password_label.Text = "Password";
            Password_label.Click += label2_Click;
            // 
            // username_label
            // 
            username_label.AutoEllipsis = true;
            username_label.AutoSize = true;
            username_label.BackColor = Color.Transparent;
            username_label.FlatStyle = FlatStyle.Popup;
            username_label.ForeColor = SystemColors.Window;
            username_label.Location = new Point(501, 809);
            username_label.Margin = new Padding(7, 0, 7, 0);
            username_label.Name = "username_label";
            username_label.Size = new Size(152, 41);
            username_label.TabIndex = 4;
            username_label.Text = "Username";
            username_label.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Location = new Point(853, 107);
            pictureBox1.Margin = new Padding(7, 8, 7, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(538, 515);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, -2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(294, 155);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            pictureBox2.WaitOnLoad = true;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // Forgotpassword_button
            // 
            Forgotpassword_button.AutoEllipsis = true;
            Forgotpassword_button.AutoSize = true;
            Forgotpassword_button.BackColor = Color.Transparent;
            Forgotpassword_button.FlatStyle = FlatStyle.Popup;
            Forgotpassword_button.ForeColor = SystemColors.Window;
            Forgotpassword_button.Location = new Point(993, 1061);
            Forgotpassword_button.Margin = new Padding(7, 0, 7, 0);
            Forgotpassword_button.Name = "Forgotpassword_button";
            Forgotpassword_button.Size = new Size(261, 41);
            Forgotpassword_button.TabIndex = 8;
            Forgotpassword_button.Text = "Forgot Password ?";
            Forgotpassword_button.Click += Forgotpassword_button_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(2147, 1479);
            Controls.Add(Forgotpassword_button);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(Password_label);
            Controls.Add(username_label);
            Controls.Add(Username_textBox);
            Controls.Add(Password_textBox1);
            Controls.Add(Login_button);
            Controls.Add(SignUp_button);
            Margin = new Padding(7, 8, 7, 8);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SignUp_button;
        private Button Login_button;
        private TextBox Password_textBox1;
        private TextBox Username_textBox;
        private Label Password_label;
        private Label username_label;
        public PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label Forgotpassword_button;
    }
}