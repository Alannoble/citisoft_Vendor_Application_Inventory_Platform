namespace Vendor_Application_Inventory_Platform
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            panel3 = new Panel();
            panel2 = new Panel();
            label4 = new Label();
            logout_btn = new Button();
            viewVendor_btn = new Button();
            addVendor_btn = new Button();
            dashboard_btn = new Button();
            greet_admin = new Label();
            pictureBox1 = new PictureBox();
            addVendor1 = new AddVendor();
            viewVendors1 = new ViewVendors();
            adminDashboard1 = new adminDashboard();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.BackColor = Color.FromArgb(33, 11, 97);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1167, 40);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(1139, 9);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(22, 21);
            label1.TabIndex = 0;
            label1.Text = "X";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(9, 7);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(224, 23);
            label2.TabIndex = 1;
            label2.Text = "Vendor Management System";
            label2.Click += label2_Click;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(1167, 40);
            panel3.TabIndex = 2;
            panel3.Paint += panel3_Paint;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(33, 11, 97);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(logout_btn);
            panel2.Controls.Add(viewVendor_btn);
            panel2.Controls.Add(addVendor_btn);
            panel2.Controls.Add(dashboard_btn);
            panel2.Controls.Add(greet_admin);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 40);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(228, 611);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(81, 563);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(74, 23);
            label4.TabIndex = 6;
            label4.Text = "Signout";
            label4.Click += label4_Click;
            // 
            // logout_btn
            // 
            logout_btn.BackColor = Color.White;
            logout_btn.FlatAppearance.BorderColor = Color.White;
            logout_btn.FlatAppearance.BorderSize = 3;
            logout_btn.FlatStyle = FlatStyle.Flat;
            logout_btn.ForeColor = Color.White;
            logout_btn.Image = Properties.Resources.icons8_logout_251;
            logout_btn.Location = new Point(26, 561);
            logout_btn.Margin = new Padding(2);
            logout_btn.Name = "logout_btn";
            logout_btn.Size = new Size(28, 28);
            logout_btn.TabIndex = 5;
            logout_btn.UseVisualStyleBackColor = false;
            logout_btn.Click += logout_btn_Click;
            // 
            // viewVendor_btn
            // 
            viewVendor_btn.BackColor = Color.FromArgb(33, 11, 97);
            viewVendor_btn.Cursor = Cursors.UpArrow;
            viewVendor_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 8, 138);
            viewVendor_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 8, 138);
            viewVendor_btn.FlatStyle = FlatStyle.Flat;
            viewVendor_btn.ForeColor = Color.Transparent;
            viewVendor_btn.Location = new Point(34, 305);
            viewVendor_btn.Margin = new Padding(2);
            viewVendor_btn.Name = "viewVendor_btn";
            viewVendor_btn.Size = new Size(160, 32);
            viewVendor_btn.TabIndex = 4;
            viewVendor_btn.Text = "View / Edit Vendor";
            viewVendor_btn.UseVisualStyleBackColor = false;
            viewVendor_btn.Click += button3_Click;
            // 
            // addVendor_btn
            // 
            addVendor_btn.BackColor = Color.FromArgb(33, 11, 97);
            addVendor_btn.Cursor = Cursors.UpArrow;
            addVendor_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 8, 138);
            addVendor_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 8, 138);
            addVendor_btn.FlatStyle = FlatStyle.Flat;
            addVendor_btn.ForeColor = Color.Transparent;
            addVendor_btn.Location = new Point(34, 261);
            addVendor_btn.Margin = new Padding(2);
            addVendor_btn.Name = "addVendor_btn";
            addVendor_btn.Size = new Size(160, 32);
            addVendor_btn.TabIndex = 3;
            addVendor_btn.Text = "Add Vendor";
            addVendor_btn.UseVisualStyleBackColor = false;
            addVendor_btn.Click += addVendor_btn_Click;
            // 
            // dashboard_btn
            // 
            dashboard_btn.BackColor = Color.FromArgb(33, 11, 97);
            dashboard_btn.Cursor = Cursors.UpArrow;
            dashboard_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 8, 138);
            dashboard_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 8, 138);
            dashboard_btn.FlatStyle = FlatStyle.Flat;
            dashboard_btn.ForeColor = Color.Transparent;
            dashboard_btn.Location = new Point(34, 216);
            dashboard_btn.Margin = new Padding(2);
            dashboard_btn.Name = "dashboard_btn";
            dashboard_btn.Size = new Size(160, 32);
            dashboard_btn.TabIndex = 2;
            dashboard_btn.Text = "Dashboard";
            dashboard_btn.UseVisualStyleBackColor = false;
            dashboard_btn.Click += button1_Click;
            // 
            // greet_admin
            // 
            greet_admin.AutoSize = true;
            greet_admin.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point);
            greet_admin.ForeColor = Color.White;
            greet_admin.Location = new Point(54, 157);
            greet_admin.Margin = new Padding(2, 0, 2, 0);
            greet_admin.Name = "greet_admin";
            greet_admin.Size = new Size(130, 21);
            greet_admin.TabIndex = 1;
            greet_admin.Text = "Welcome Admin";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(68, 75);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 80);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // addVendor1
            // 
            addVendor1.BorderStyle = BorderStyle.FixedSingle;
            addVendor1.Location = new Point(228, 40);
            addVendor1.Margin = new Padding(4);
            addVendor1.Name = "addVendor1";
            addVendor1.Size = new Size(940, 612);
            addVendor1.TabIndex = 2;
            // 
            // viewVendors1
            // 
            viewVendors1.BorderStyle = BorderStyle.FixedSingle;
            viewVendors1.Location = new Point(228, 40);
            viewVendors1.Margin = new Padding(4);
            viewVendors1.Name = "viewVendors1";
            viewVendors1.Size = new Size(940, 612);
            viewVendors1.TabIndex = 3;
            // 
            // adminDashboard1
            // 
            adminDashboard1.BorderStyle = BorderStyle.FixedSingle;
            adminDashboard1.Location = new Point(228, 40);
            adminDashboard1.Margin = new Padding(4);
            adminDashboard1.MaximumSize = new Size(940, 612);
            adminDashboard1.MinimumSize = new Size(940, 612);
            adminDashboard1.Name = "adminDashboard1";
            adminDashboard1.RightToLeft = RightToLeft.No;
            adminDashboard1.Size = new Size(940, 612);
            adminDashboard1.TabIndex = 4;
            adminDashboard1.Load += adminDashboard1_Load;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1167, 651);
            Controls.Add(adminDashboard1);
            Controls.Add(viewVendors1);
            Controls.Add(addVendor1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Cursor = Cursors.Hand;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            Load += MainForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Button dashboard_btn;
        private Label greet_admin;
        private Button viewVendor_btn;
        private Button addVendor_btn;
        private Button logout_btn;
        private Label label4;
        private Panel panel3;
        private AddVendor addVendor1;
        private ViewVendors viewVendors1;
        private adminDashboard adminDashboard1;
    }
}