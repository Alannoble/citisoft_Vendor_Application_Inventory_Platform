namespace Vendor_Application_Inventory_Platform
{
    partial class frmProfilePrev
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Dock = DockStyle.Top;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Nirmala UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(951, 70);
            button1.TabIndex = 1;
            button1.Text = "Account";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.Dock = DockStyle.Top;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Nirmala UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(0, 70);
            button2.Name = "button2";
            button2.Size = new Size(951, 70);
            button2.TabIndex = 1;
            button2.Text = "Settings";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.Dock = DockStyle.Top;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Nirmala UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(0, 140);
            button3.Name = "button3";
            button3.Size = new Size(951, 70);
            button3.TabIndex = 1;
            button3.Text = "Help";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.Transparent;
            button4.Dock = DockStyle.Bottom;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Nirmala UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(0, 443);
            button4.Name = "button4";
            button4.Size = new Size(951, 63);
            button4.TabIndex = 1;
            button4.Text = "QUIT";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // frmProfilePrev
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(951, 506);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmProfilePrev";
            Text = "frmProfilePrev";
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}