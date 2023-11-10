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
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // SignUp_button
            // 
            SignUp_button.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SignUp_button.BackColor = Color.RoyalBlue;
            SignUp_button.Location = new Point(382, 572);
            SignUp_button.Margin = new Padding(3, 4, 3, 4);
            SignUp_button.Name = "SignUp_button";
            SignUp_button.Size = new Size(138, 44);
            SignUp_button.TabIndex = 6;
            SignUp_button.Text = "Sign Up";
            SignUp_button.UseVisualStyleBackColor = false;
            SignUp_button.Click += button1_Click;
            // 
            // Login_button
            // 
            Login_button.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Login_button.BackColor = Color.RoyalBlue;
            Login_button.Location = new Point(564, 572);
            Login_button.Margin = new Padding(3, 4, 3, 4);
            Login_button.Name = "Login_button";
            Login_button.Size = new Size(128, 44);
            Login_button.TabIndex = 7;
            Login_button.Text = "Login";
            Login_button.UseVisualStyleBackColor = false;
            Login_button.Click += button2_Click;
            // 
            // Password_textBox1
            // 
            Password_textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Password_textBox1.Location = new Point(382, 475);
            Password_textBox1.Margin = new Padding(3, 4, 3, 4);
            Password_textBox1.Name = "Password_textBox1";
            Password_textBox1.Size = new Size(306, 27);
            Password_textBox1.TabIndex = 1;
            Password_textBox1.UseSystemPasswordChar = true;
            Password_textBox1.TextChanged += textBox1_TextChanged;
            // 
            // Username_textBox
            // 
            Username_textBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Username_textBox.BackColor = SystemColors.Window;
            Username_textBox.Location = new Point(382, 393);
            Username_textBox.Margin = new Padding(3, 4, 3, 4);
            Username_textBox.Multiline = true;
            Username_textBox.Name = "Username_textBox";
            Username_textBox.Size = new Size(306, 29);
            Username_textBox.TabIndex = 0;
            Username_textBox.TextChanged += textBox2_TextChanged;
            // 
            // Password_label
            // 
            Password_label.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Password_label.AutoEllipsis = true;
            Password_label.AutoSize = true;
            Password_label.BackColor = Color.Transparent;
            Password_label.FlatStyle = FlatStyle.Popup;
            Password_label.ForeColor = SystemColors.Window;
            Password_label.Location = new Point(236, 478);
            Password_label.Name = "Password_label";
            Password_label.Size = new Size(70, 20);
            Password_label.TabIndex = 5;
            Password_label.Text = "Password";
            Password_label.Click += label2_Click;
            // 
            // username_label
            // 
            username_label.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            username_label.AutoEllipsis = true;
            username_label.AutoSize = true;
            username_label.BackColor = Color.Transparent;
            username_label.FlatStyle = FlatStyle.Popup;
            username_label.ForeColor = SystemColors.Window;
            username_label.Location = new Point(236, 395);
            username_label.Name = "username_label";
            username_label.Size = new Size(75, 20);
            username_label.TabIndex = 4;
            username_label.Text = "Username";
            username_label.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(364, 52);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(324, 302);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, -1);
            pictureBox2.Margin = new Padding(1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(138, 76);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            pictureBox2.WaitOnLoad = true;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // Forgotpassword_button
            // 
            Forgotpassword_button.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Forgotpassword_button.AutoEllipsis = true;
            Forgotpassword_button.AutoSize = true;
            Forgotpassword_button.BackColor = Color.Transparent;
            Forgotpassword_button.FlatStyle = FlatStyle.Popup;
            Forgotpassword_button.ForeColor = SystemColors.Window;
            Forgotpassword_button.Location = new Point(467, 518);
            Forgotpassword_button.Name = "Forgotpassword_button";
            Forgotpassword_button.Size = new Size(129, 20);
            Forgotpassword_button.TabIndex = 8;
            Forgotpassword_button.Text = "Forgot Password ?";
            Forgotpassword_button.Click += Forgotpassword_button_Click;
            // 
            // button1
            // 
            button1.Location = new Point(813, 382);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 9;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(997, 658);
            Controls.Add(button1);
            Controls.Add(Forgotpassword_button);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(Password_label);
            Controls.Add(username_label);
            Controls.Add(Username_textBox);
            Controls.Add(Password_textBox1);
            Controls.Add(Login_button);
            Controls.Add(SignUp_button);
            Margin = new Padding(3, 4, 3, 4);
            Name = "LoginPage";
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
        private Button button1;
    }
}