﻿namespace Vendor_Application_Inventory_Platform
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
            pictureBox1 = new PictureBox();
            Forgotpassword_button = new Label();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            btnLogin = new Button();
            panel1 = new Panel();
            username_label = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // SignUp_button
            // 
            SignUp_button.Anchor = AnchorStyles.None;
            SignUp_button.BackColor = Color.Transparent;
            SignUp_button.Cursor = Cursors.Hand;
            SignUp_button.FlatAppearance.BorderSize = 0;
            SignUp_button.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            SignUp_button.ForeColor = SystemColors.Highlight;
            SignUp_button.Location = new Point(156, 573);
            SignUp_button.Margin = new Padding(3, 4, 3, 4);
            SignUp_button.Name = "SignUp_button";
            SignUp_button.Size = new Size(120, 67);
            SignUp_button.TabIndex = 6;
            SignUp_button.Text = "Sign Up";
            SignUp_button.UseVisualStyleBackColor = false;
            SignUp_button.Click += SignUp_button_Click_1;
            // 
            // Login_button
            // 
            Login_button.Anchor = AnchorStyles.None;
            Login_button.BackColor = Color.DodgerBlue;
            Login_button.Cursor = Cursors.Hand;
            Login_button.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Login_button.ForeColor = Color.White;
            Login_button.Location = new Point(114, 474);
            Login_button.Margin = new Padding(3, 4, 3, 4);
            Login_button.Name = "Login_button";
            Login_button.Size = new Size(207, 54);
            Login_button.TabIndex = 7;
            Login_button.Text = "Login";
            Login_button.UseVisualStyleBackColor = false;
            Login_button.Click += Login_button_Click;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.None;
            txtPassword.BackColor = SystemColors.Control;
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Location = new Point(121, 413);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(200, 20);
            txtPassword.TabIndex = 1;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            txtUsername.Anchor = AnchorStyles.None;
            txtUsername.BackColor = SystemColors.Control;
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Cursor = Cursors.IBeam;
            txtUsername.Location = new Point(121, 329);
            txtUsername.Margin = new Padding(3, 4, 3, 4);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(200, 20);
            txtUsername.TabIndex = 0;
            // 
            // Password_label
            // 
            Password_label.Anchor = AnchorStyles.None;
            Password_label.AutoEllipsis = true;
            Password_label.BackColor = Color.Transparent;
            Password_label.FlatStyle = FlatStyle.Popup;
            Password_label.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Password_label.ForeColor = SystemColors.InactiveCaption;
            Password_label.Location = new Point(121, 386);
            Password_label.Name = "Password_label";
            Password_label.Size = new Size(84, 23);
            Password_label.TabIndex = 5;
            Password_label.Text = "Password";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Location = new Point(0, 60);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(441, 200);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
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
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Dock = DockStyle.Left;
            pictureBox3.Image = Properties.Resources.Screenshot_2023_11_10_004008;
            pictureBox3.Location = new Point(0, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(125, 60);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveBorder;
            label1.Location = new Point(136, 549);
            label1.Name = "label1";
            label1.Size = new Size(162, 20);
            label1.TabIndex = 10;
            label1.Text = "Don't have an account?";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(418, 4);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(18, 20);
            label2.TabIndex = 11;
            label2.Text = "X";
            label2.Click += label2_Click_2;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(0, 0);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 0;
            btnLogin.Click += btnLogin_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(441, 60);
            panel1.TabIndex = 12;
            // 
            // username_label
            // 
            username_label.Anchor = AnchorStyles.None;
            username_label.AutoEllipsis = true;
            username_label.BackColor = Color.Transparent;
            username_label.FlatStyle = FlatStyle.Popup;
            username_label.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            username_label.ForeColor = SystemColors.InactiveCaption;
            username_label.Location = new Point(121, 302);
            username_label.Name = "username_label";
            username_label.Size = new Size(89, 23);
            username_label.TabIndex = 4;
            username_label.Text = "Username";
            // 
            // LoginPage
            // 
            AcceptButton = Login_button;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(441, 739);
            Controls.Add(username_label);
            Controls.Add(btnLogin);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Forgotpassword_button);
            Controls.Add(pictureBox1);
            Controls.Add(Password_label);
            Controls.Add(txtUsername);
            Controls.Add(txtPassword);
            Controls.Add(Login_button);
            Controls.Add(SignUp_button);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "LoginPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += LoginPage_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SignUp_button;
        private Button Login_button;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Label Password_label;
        public PictureBox pictureBox1;
        private Label Forgotpassword_button;
        private PictureBox pictureBox3;
        private Label label1;
        private Label label2;
        private Button btnLogin;
        private Panel panel1;
        private Label username_label;
    }
}