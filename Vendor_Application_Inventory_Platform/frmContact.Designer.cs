namespace Vendor_Application_Inventory_Platform
{
    partial class frmContact
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
            label1 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(65, 90);
            label1.Name = "label1";
            label1.Size = new Size(265, 62);
            label1.TabIndex = 0;
            label1.Text = "Contact Us";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Location = new Point(78, 172);
            panel1.Name = "panel1";
            panel1.Size = new Size(161, 10);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // label2
            // 
            label2.Font = new Font("Nirmala UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(78, 212);
            label2.Name = "label2";
            label2.Size = new Size(585, 87);
            label2.TabIndex = 2;
            label2.Text = "Please contact any of our locations listed below for further information about Citisoft, our team, and our capabilities";
            // 
            // frmContact
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(951, 506);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmContact";
            Text = "frmContact";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label2;
    }
}