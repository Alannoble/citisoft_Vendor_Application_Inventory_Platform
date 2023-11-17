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
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            Password_label = new Label();
            username_label = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            Forgotpassword_button = new Label();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // SignUp_button
            // 
            SignUp_button.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SignUp_button.BackColor = Color.Transparent;
            SignUp_button.Cursor = Cursors.Hand;
            SignUp_button.FlatAppearance.BorderSize = 0;
            SignUp_button.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            SignUp_button.ForeColor = SystemColors.Highlight;
            SignUp_button.Location = new Point(332, 1175);
            SignUp_button.Margin = new Padding(6, 8, 6, 8);
            SignUp_button.Name = "SignUp_button";
            SignUp_button.Size = new Size(255, 92);
            SignUp_button.TabIndex = 6;
            SignUp_button.Text = "Sign Up";
            SignUp_button.UseVisualStyleBackColor = false;
            SignUp_button.Click += button1_Click;
            // 
            // Login_button
            // 
            Login_button.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Login_button.BackColor = Color.DodgerBlue;
            Login_button.Cursor = Cursors.Hand;
            Login_button.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Login_button.ForeColor = Color.White;
            Login_button.Location = new Point(242, 972);
            Login_button.Margin = new Padding(6, 8, 6, 8);
            Login_button.Name = "Login_button";
            Login_button.Size = new Size(440, 109);
            Login_button.TabIndex = 7;
            Login_button.Text = "Login";
            Login_button.UseVisualStyleBackColor = false;
            Login_button.Click += button2_Click;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtPassword.BackColor = SystemColors.Control;
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Location = new Point(257, 847);
            txtPassword.Margin = new Padding(6, 8, 6, 8);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(425, 40);
            txtPassword.TabIndex = 1;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.TextChanged += textBox1_TextChanged;
            // 
            // txtUsername
            // 
            txtUsername.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtUsername.BackColor = SystemColors.Control;
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Location = new Point(257, 674);
            txtUsername.Margin = new Padding(6, 8, 6, 8);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(425, 55);
            txtUsername.TabIndex = 0;
            txtUsername.TextChanged += textBox2_TextChanged;
            // 
            // Password_label
            // 
            Password_label.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Password_label.AutoEllipsis = true;
            Password_label.AutoSize = true;
            Password_label.BackColor = Color.Transparent;
            Password_label.FlatStyle = FlatStyle.Popup;
            Password_label.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Password_label.ForeColor = SystemColors.InactiveCaption;
            Password_label.Location = new Point(257, 791);
            Password_label.Margin = new Padding(6, 0, 6, 0);
            Password_label.Name = "Password_label";
            Password_label.Size = new Size(171, 46);
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
            username_label.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            username_label.ForeColor = SystemColors.InactiveCaption;
            username_label.Location = new Point(257, 619);
            username_label.Margin = new Padding(6, 0, 6, 0);
            username_label.Name = "username_label";
            username_label.Size = new Size(180, 46);
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
            pictureBox1.Location = new Point(387, 177);
            pictureBox1.Margin = new Padding(6, 8, 6, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 200);
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
            pictureBox2.Location = new Point(0, -2);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(0, 322);
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
            Forgotpassword_button.Location = new Point(992, 1062);
            Forgotpassword_button.Margin = new Padding(6, 0, 6, 0);
            Forgotpassword_button.Name = "Forgotpassword_button";
            Forgotpassword_button.Size = new Size(261, 41);
            Forgotpassword_button.TabIndex = 8;
            Forgotpassword_button.Text = "Forgot Password ?";
            Forgotpassword_button.Click += Forgotpassword_button_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Image = Properties.Resources.Screenshot_2023_11_10_004008;
            pictureBox3.Location = new Point(-2, 0);
            pictureBox3.Margin = new Padding(6);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(266, 127);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveBorder;
            label1.Location = new Point(289, 1125);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(324, 41);
            label1.TabIndex = 10;
            label1.Text = "Don't have an account?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(889, 9);
            label2.Name = "label2";
            label2.Size = new Size(36, 41);
            label2.TabIndex = 11;
            label2.Text = "X";
            label2.Click += label2_Click_1;
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(937, 1515);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox3);
            Controls.Add(Forgotpassword_button);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(Password_label);
            Controls.Add(username_label);
            Controls.Add(txtUsername);
            Controls.Add(txtPassword);
            Controls.Add(Login_button);
            Controls.Add(SignUp_button);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(6, 8, 6, 8);
            Name = "LoginPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SignUp_button;
        private Button Login_button;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Label Password_label;
        private Label username_label;
        public PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label Forgotpassword_button;
        private PictureBox pictureBox3;
        private Label label1;
        private Label label2;
    }
}