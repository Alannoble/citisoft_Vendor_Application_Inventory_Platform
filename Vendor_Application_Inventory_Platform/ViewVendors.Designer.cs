namespace Vendor_Application_Inventory_Platform
{
    partial class ViewVendors
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.addVendor_typeOfSoftware = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.addVendor_softwareName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.addVendor_companyAddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.addVendor_companyWebsite = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addVendor_companyName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addVendor_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.search_btn = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(398, 115);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 33;
            this.dataGridView2.Size = new System.Drawing.Size(757, 596);
            this.dataGridView2.TabIndex = 3;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(398, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Vendors";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(80, 609);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 34);
            this.button1.TabIndex = 29;
            this.button1.Text = "save changes";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // addVendor_typeOfSoftware
            // 
            this.addVendor_typeOfSoftware.Location = new System.Drawing.Point(59, 510);
            this.addVendor_typeOfSoftware.Multiline = true;
            this.addVendor_typeOfSoftware.Name = "addVendor_typeOfSoftware";
            this.addVendor_typeOfSoftware.Size = new System.Drawing.Size(264, 35);
            this.addVendor_typeOfSoftware.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(59, 488);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 19);
            this.label7.TabIndex = 27;
            this.label7.Text = "Type Of Software:";
            // 
            // addVendor_softwareName
            // 
            this.addVendor_softwareName.Location = new System.Drawing.Point(59, 439);
            this.addVendor_softwareName.Multiline = true;
            this.addVendor_softwareName.Name = "addVendor_softwareName";
            this.addVendor_softwareName.Size = new System.Drawing.Size(264, 35);
            this.addVendor_softwareName.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(59, 417);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 19);
            this.label6.TabIndex = 25;
            this.label6.Text = "Software Name:";
            // 
            // addVendor_companyAddress
            // 
            this.addVendor_companyAddress.Location = new System.Drawing.Point(59, 370);
            this.addVendor_companyAddress.Multiline = true;
            this.addVendor_companyAddress.Name = "addVendor_companyAddress";
            this.addVendor_companyAddress.Size = new System.Drawing.Size(264, 35);
            this.addVendor_companyAddress.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(59, 348);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 19);
            this.label5.TabIndex = 23;
            this.label5.Text = "Company Address:";
            // 
            // addVendor_companyWebsite
            // 
            this.addVendor_companyWebsite.Location = new System.Drawing.Point(59, 295);
            this.addVendor_companyWebsite.Multiline = true;
            this.addVendor_companyWebsite.Name = "addVendor_companyWebsite";
            this.addVendor_companyWebsite.Size = new System.Drawing.Size(264, 35);
            this.addVendor_companyWebsite.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(59, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 19);
            this.label4.TabIndex = 21;
            this.label4.Text = "Company Website:";
            // 
            // addVendor_companyName
            // 
            this.addVendor_companyName.Location = new System.Drawing.Point(59, 221);
            this.addVendor_companyName.Multiline = true;
            this.addVendor_companyName.Name = "addVendor_companyName";
            this.addVendor_companyName.Size = new System.Drawing.Size(264, 35);
            this.addVendor_companyName.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(59, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 19);
            this.label3.TabIndex = 19;
            this.label3.Text = "Company Name:";
            // 
            // addVendor_id
            // 
            this.addVendor_id.Location = new System.Drawing.Point(59, 137);
            this.addVendor_id.Multiline = true;
            this.addVendor_id.Name = "addVendor_id";
            this.addVendor_id.Size = new System.Drawing.Size(264, 35);
            this.addVendor_id.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(59, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 19);
            this.label2.TabIndex = 17;
            this.label2.Text = "Vendor ID:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(80, 666);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(160, 34);
            this.button2.TabIndex = 30;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(740, 53);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(112, 34);
            this.search_btn.TabIndex = 31;
            this.search_btn.Text = "Search";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(858, 56);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(243, 31);
            this.search.TabIndex = 32;
            this.search.TextChanged += new System.EventHandler(this.search_TextChanged);
            // 
            // ViewVendors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.search);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.addVendor_typeOfSoftware);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.addVendor_softwareName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.addVendor_companyAddress);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.addVendor_companyWebsite);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.addVendor_companyName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.addVendor_id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label1);
            this.Name = "ViewVendors";
            this.Size = new System.Drawing.Size(1173, 763);
            this.Load += new System.EventHandler(this.ViewVendors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView2;
        private Label label1;
        private Button button1;
        private TextBox addVendor_typeOfSoftware;
        private Label label7;
        private TextBox addVendor_softwareName;
        private Label label6;
        private TextBox addVendor_companyAddress;
        private Label label5;
        private TextBox addVendor_companyWebsite;
        private Label label4;
        private TextBox addVendor_companyName;
        private Label label3;
        private TextBox addVendor_id;
        private Label label2;
        private Button button2;
        private Button search_btn;
        private TextBox search;
    }
}
