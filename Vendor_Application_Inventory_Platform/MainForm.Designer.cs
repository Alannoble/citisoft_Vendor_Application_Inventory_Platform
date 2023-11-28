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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.logout_btn = new System.Windows.Forms.Button();
            this.viewVendor_btn = new System.Windows.Forms.Button();
            this.addVendor_btn = new System.Windows.Forms.Button();
            this.dashboard_btn = new System.Windows.Forms.Button();
            this.greet_admin = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.addVendor1 = new Vendor_Application_Inventory_Platform.AddVendor();
            this.viewVendors1 = new Vendor_Application_Inventory_Platform.ViewVendors();
            this.adminDashboard1 = new Vendor_Application_Inventory_Platform.adminDashboard();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1460, 50);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1424, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vendor Management System";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1460, 50);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.logout_btn);
            this.panel2.Controls.Add(this.viewVendor_btn);
            this.panel2.Controls.Add(this.addVendor_btn);
            this.panel2.Controls.Add(this.dashboard_btn);
            this.panel2.Controls.Add(this.greet_admin);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(285, 765);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(101, 704);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 27);
            this.label4.TabIndex = 6;
            this.label4.Text = "Signout";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // logout_btn
            // 
            this.logout_btn.BackColor = System.Drawing.Color.White;
            this.logout_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.logout_btn.FlatAppearance.BorderSize = 3;
            this.logout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout_btn.ForeColor = System.Drawing.Color.White;
            this.logout_btn.Image = global::Vendor_Application_Inventory_Platform.Properties.Resources.icons8_logout_251;
            this.logout_btn.Location = new System.Drawing.Point(33, 701);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(35, 35);
            this.logout_btn.TabIndex = 5;
            this.logout_btn.UseVisualStyleBackColor = false;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // viewVendor_btn
            // 
            this.viewVendor_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.viewVendor_btn.Cursor = System.Windows.Forms.Cursors.UpArrow;
            this.viewVendor_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.viewVendor_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.viewVendor_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewVendor_btn.ForeColor = System.Drawing.Color.Transparent;
            this.viewVendor_btn.Location = new System.Drawing.Point(43, 382);
            this.viewVendor_btn.Name = "viewVendor_btn";
            this.viewVendor_btn.Size = new System.Drawing.Size(200, 40);
            this.viewVendor_btn.TabIndex = 4;
            this.viewVendor_btn.Text = "View Vendor";
            this.viewVendor_btn.UseVisualStyleBackColor = false;
            this.viewVendor_btn.Click += new System.EventHandler(this.button3_Click);
            // 
            // addVendor_btn
            // 
            this.addVendor_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.addVendor_btn.Cursor = System.Windows.Forms.Cursors.UpArrow;
            this.addVendor_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.addVendor_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.addVendor_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addVendor_btn.ForeColor = System.Drawing.Color.Transparent;
            this.addVendor_btn.Location = new System.Drawing.Point(43, 327);
            this.addVendor_btn.Name = "addVendor_btn";
            this.addVendor_btn.Size = new System.Drawing.Size(200, 40);
            this.addVendor_btn.TabIndex = 3;
            this.addVendor_btn.Text = "Add Vendor";
            this.addVendor_btn.UseVisualStyleBackColor = false;
            this.addVendor_btn.Click += new System.EventHandler(this.addVendor_btn_Click);
            // 
            // dashboard_btn
            // 
            this.dashboard_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.dashboard_btn.Cursor = System.Windows.Forms.Cursors.UpArrow;
            this.dashboard_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.dashboard_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.dashboard_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboard_btn.ForeColor = System.Drawing.Color.Transparent;
            this.dashboard_btn.Location = new System.Drawing.Point(43, 270);
            this.dashboard_btn.Name = "dashboard_btn";
            this.dashboard_btn.Size = new System.Drawing.Size(200, 40);
            this.dashboard_btn.TabIndex = 2;
            this.dashboard_btn.Text = "Dashboard";
            this.dashboard_btn.UseVisualStyleBackColor = false;
            this.dashboard_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // greet_admin
            // 
            this.greet_admin.AutoSize = true;
            this.greet_admin.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.greet_admin.ForeColor = System.Drawing.Color.White;
            this.greet_admin.Location = new System.Drawing.Point(67, 196);
            this.greet_admin.Name = "greet_admin";
            this.greet_admin.Size = new System.Drawing.Size(154, 24);
            this.greet_admin.TabIndex = 1;
            this.greet_admin.Text = "Welcome Admin";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(85, 93);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // addVendor1
            // 
            this.addVendor1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addVendor1.Location = new System.Drawing.Point(285, 50);
            this.addVendor1.Name = "addVendor1";
            this.addVendor1.Size = new System.Drawing.Size(1175, 765);
            this.addVendor1.TabIndex = 2;
            // 
            // viewVendors1
            // 
            this.viewVendors1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.viewVendors1.Location = new System.Drawing.Point(285, 50);
            this.viewVendors1.Name = "viewVendors1";
            this.viewVendors1.Size = new System.Drawing.Size(1175, 765);
            this.viewVendors1.TabIndex = 3;
            // 
            // adminDashboard1
            // 
            this.adminDashboard1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.adminDashboard1.Location = new System.Drawing.Point(285, 50);
            this.adminDashboard1.Name = "adminDashboard1";
            this.adminDashboard1.Size = new System.Drawing.Size(1175, 765);
            this.adminDashboard1.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1460, 815);
            this.Controls.Add(this.adminDashboard1);
            this.Controls.Add(this.viewVendors1);
            this.Controls.Add(this.addVendor1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

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