namespace Vendor_Application_Inventory_Platform
{
    partial class CommentRatingForm
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
            savebtn = new Button();
            deletebtn = new Button();
            commenttxt = new TextBox();
            numericUpDownrating = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownrating).BeginInit();
            SuspendLayout();
            // 
            // savebtn
            // 
            savebtn.Location = new Point(215, 370);
            savebtn.Name = "savebtn";
            savebtn.Size = new Size(112, 34);
            savebtn.TabIndex = 2;
            savebtn.Text = "save";
            savebtn.UseVisualStyleBackColor = true;
            savebtn.Click += savebtn_Click;
            // 
            // deletebtn
            // 
            deletebtn.Location = new Point(407, 370);
            deletebtn.Name = "deletebtn";
            deletebtn.Size = new Size(112, 34);
            deletebtn.TabIndex = 3;
            deletebtn.Text = "delete";
            deletebtn.UseVisualStyleBackColor = true;
            deletebtn.Click += deletebtn_Click;
            // 
            // commenttxt
            // 
            commenttxt.Location = new Point(432, 203);
            commenttxt.Name = "commenttxt";
            commenttxt.Size = new Size(150, 31);
            commenttxt.TabIndex = 4;
            commenttxt.TextChanged += commenttxt_TextChanged;
            // 
            // numericUpDownrating
            // 
            numericUpDownrating.Location = new Point(432, 254);
            numericUpDownrating.Name = "numericUpDownrating";
            numericUpDownrating.Size = new Size(180, 31);
            numericUpDownrating.TabIndex = 5;
            numericUpDownrating.ValueChanged += numericUpDownrating_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(263, 206);
            label1.Name = "label1";
            label1.Size = new Size(91, 25);
            label1.TabIndex = 6;
            label1.Text = "Comment";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(263, 260);
            label2.Name = "label2";
            label2.Size = new Size(63, 25);
            label2.TabIndex = 7;
            label2.Text = "Rating";
            // 
            // CommentRatingForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(numericUpDownrating);
            Controls.Add(commenttxt);
            Controls.Add(deletebtn);
            Controls.Add(savebtn);
            Name = "CommentRatingForm";
            Text = "CommentRatingForm";
            Load += CommentRatingForm_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownrating).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button savebtn;
        private Button deletebtn;
        private TextBox commenttxt;
        private NumericUpDown numericUpDownrating;
        private Label label1;
        private Label label2;
    }
}