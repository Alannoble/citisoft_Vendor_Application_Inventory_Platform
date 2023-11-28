
namespace Vendor_Application_Inventory_Platform
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            pnlNav = new Panel();
            contactBtn = new Button();
            vendorBtn = new Button();
            homeBtn = new Button();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            button3 = new Button();
            button1 = new Button();
            pnlFormLoader = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(pnlNav);
            panel1.Controls.Add(contactBtn);
            panel1.Controls.Add(vendorBtn);
            panel1.Controls.Add(homeBtn);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(953, 75);
            panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(535, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(77, 75);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // pnlNav
            // 
            pnlNav.BackColor = Color.Black;
            pnlNav.Location = new Point(193, 0);
            pnlNav.Name = "pnlNav";
            pnlNav.Size = new Size(100, 3);
            pnlNav.TabIndex = 4;
            // 
            // contactBtn
            // 
            contactBtn.Dock = DockStyle.Left;
            contactBtn.FlatAppearance.BorderSize = 0;
            contactBtn.FlatStyle = FlatStyle.Flat;
            contactBtn.Font = new Font("Nirmala UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            contactBtn.ForeColor = SystemColors.Desktop;
            contactBtn.Location = new Point(397, 0);
            contactBtn.Name = "contactBtn";
            contactBtn.Size = new Size(138, 75);
            contactBtn.TabIndex = 2;
            contactBtn.Text = "Contact Us";
            contactBtn.UseVisualStyleBackColor = true;
            contactBtn.Click += contactBtn_Click;
            contactBtn.Leave += contactBtn_Leave;
            // 
            // vendorBtn
            // 
            vendorBtn.Dock = DockStyle.Left;
            vendorBtn.FlatAppearance.BorderSize = 0;
            vendorBtn.FlatStyle = FlatStyle.Flat;
            vendorBtn.Font = new Font("Nirmala UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            vendorBtn.ForeColor = SystemColors.Desktop;
            vendorBtn.Location = new Point(259, 0);
            vendorBtn.Name = "vendorBtn";
            vendorBtn.Size = new Size(138, 75);
            vendorBtn.TabIndex = 2;
            vendorBtn.Text = "Vendors";
            vendorBtn.UseVisualStyleBackColor = true;
            vendorBtn.Click += vendorBtn_Click;
            vendorBtn.Leave += vendorBtn_Leave_1;
            // 
            // homeBtn
            // 
            homeBtn.Dock = DockStyle.Left;
            homeBtn.FlatAppearance.BorderSize = 0;
            homeBtn.FlatStyle = FlatStyle.Flat;
            homeBtn.Font = new Font("Nirmala UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            homeBtn.ForeColor = SystemColors.Desktop;
            homeBtn.Location = new Point(121, 0);
            homeBtn.Name = "homeBtn";
            homeBtn.Size = new Size(138, 75);
            homeBtn.TabIndex = 2;
            homeBtn.Text = "Home";
            homeBtn.UseVisualStyleBackColor = true;
            homeBtn.Click += homeBtn_Click_1;
            homeBtn.Leave += homeBtn_Leave_1;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Left;
            pictureBox2.Image = Properties.Resources.Screenshot_2023_11_10_004008;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(121, 75);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button1);
            panel2.Location = new Point(739, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(214, 35);
            panel2.TabIndex = 0;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Right;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(144, 0);
            button3.Name = "button3";
            button3.Size = new Size(35, 35);
            button3.TabIndex = 2;
            button3.Text = "-";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Right;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Red;
            button1.Location = new Point(179, 0);
            button1.Name = "button1";
            button1.Size = new Size(35, 35);
            button1.TabIndex = 0;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pnlFormLoader
            // 
            pnlFormLoader.Dock = DockStyle.Bottom;
            pnlFormLoader.ImeMode = ImeMode.NoControl;
            pnlFormLoader.Location = new Point(0, 68);
            pnlFormLoader.Name = "pnlFormLoader";
            pnlFormLoader.Size = new Size(953, 506);
            pnlFormLoader.TabIndex = 3;
            pnlFormLoader.Paint += pnlFormLoader_Paint_1;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(953, 574);
            Controls.Add(pnlFormLoader);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            Margin = new Padding(1);
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            TransparencyKey = Color.Transparent;
            Load += Dashboard_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button homeBtn;
        private Button contactBtn;
        private Button vendorBtn;
        private Panel pnlNav;
        private Panel pnlFormLoader;
        private Button button3;
        private Button button1;
    }
}