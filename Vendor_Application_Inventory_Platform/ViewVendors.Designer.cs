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
            components = new System.ComponentModel.Container();
            dataGridView2 = new DataGridView();
            label1 = new Label();
            button1 = new Button();
            addVendor_typeOfSoftware = new TextBox();
            label7 = new Label();
            addVendor_softwareName = new TextBox();
            label6 = new Label();
            addVendor_companyAddress = new TextBox();
            label5 = new Label();
            addVendor_companyWebsite = new TextBox();
            label4 = new Label();
            addVendor_companyName = new TextBox();
            label3 = new Label();
            addVendor_id = new TextBox();
            label2 = new Label();
            button2 = new Button();
            search_btn = new Button();
            search = new TextBox();
            vendorTableAdapterBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)vendorTableAdapterBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(318, 92);
            dataGridView2.Margin = new Padding(2);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.RowTemplate.Height = 33;
            dataGridView2.Size = new Size(606, 477);
            dataGridView2.TabIndex = 3;
            dataGridView2.CellClick += dataGridView2_CellClick;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(318, 42);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(112, 33);
            label1.TabIndex = 2;
            label1.Text = "Vendors";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(33, 11, 97);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.CheckedBackColor = Color.FromArgb(75, 8, 138);
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 8, 138);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 8, 138);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(64, 487);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(128, 27);
            button1.TabIndex = 29;
            button1.Text = "save changes";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // addVendor_typeOfSoftware
            // 
            addVendor_typeOfSoftware.Location = new Point(47, 408);
            addVendor_typeOfSoftware.Margin = new Padding(2);
            addVendor_typeOfSoftware.Multiline = true;
            addVendor_typeOfSoftware.Name = "addVendor_typeOfSoftware";
            addVendor_typeOfSoftware.Size = new Size(212, 29);
            addVendor_typeOfSoftware.TabIndex = 28;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(47, 390);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(120, 17);
            label7.TabIndex = 27;
            label7.Text = "Type Of Software:";
            // 
            // addVendor_softwareName
            // 
            addVendor_softwareName.Location = new Point(47, 351);
            addVendor_softwareName.Margin = new Padding(2);
            addVendor_softwareName.Multiline = true;
            addVendor_softwareName.Name = "addVendor_softwareName";
            addVendor_softwareName.Size = new Size(212, 29);
            addVendor_softwareName.TabIndex = 26;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(47, 334);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(106, 17);
            label6.TabIndex = 25;
            label6.Text = "Software Name:";
            // 
            // addVendor_companyAddress
            // 
            addVendor_companyAddress.Location = new Point(47, 296);
            addVendor_companyAddress.Margin = new Padding(2);
            addVendor_companyAddress.Multiline = true;
            addVendor_companyAddress.Name = "addVendor_companyAddress";
            addVendor_companyAddress.Size = new Size(212, 29);
            addVendor_companyAddress.TabIndex = 24;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(47, 278);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(125, 17);
            label5.TabIndex = 23;
            label5.Text = "Company Address:";
            // 
            // addVendor_companyWebsite
            // 
            addVendor_companyWebsite.Location = new Point(47, 236);
            addVendor_companyWebsite.Margin = new Padding(2);
            addVendor_companyWebsite.Multiline = true;
            addVendor_companyWebsite.Name = "addVendor_companyWebsite";
            addVendor_companyWebsite.Size = new Size(212, 29);
            addVendor_companyWebsite.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(47, 218);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(126, 17);
            label4.TabIndex = 21;
            label4.Text = "Company Website:";
            // 
            // addVendor_companyName
            // 
            addVendor_companyName.Location = new Point(47, 177);
            addVendor_companyName.Margin = new Padding(2);
            addVendor_companyName.Multiline = true;
            addVendor_companyName.Name = "addVendor_companyName";
            addVendor_companyName.Size = new Size(212, 29);
            addVendor_companyName.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(47, 159);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(112, 17);
            label3.TabIndex = 19;
            label3.Text = "Company Name:";
            // 
            // addVendor_id
            // 
            addVendor_id.Location = new Point(47, 110);
            addVendor_id.Margin = new Padding(2);
            addVendor_id.Multiline = true;
            addVendor_id.Name = "addVendor_id";
            addVendor_id.Size = new Size(212, 29);
            addVendor_id.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(47, 92);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(75, 17);
            label2.TabIndex = 17;
            label2.Text = "Vendor ID:";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(33, 11, 97);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.CheckedBackColor = Color.FromArgb(75, 8, 138);
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 8, 138);
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 8, 138);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(64, 533);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(128, 27);
            button2.TabIndex = 30;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // search_btn
            // 
            search_btn.Location = new Point(592, 42);
            search_btn.Margin = new Padding(2);
            search_btn.Name = "search_btn";
            search_btn.Size = new Size(90, 27);
            search_btn.TabIndex = 31;
            search_btn.Text = "Search";
            search_btn.UseVisualStyleBackColor = true;
            search_btn.Click += search_btn_Click;
            // 
            // search
            // 
            search.Location = new Point(686, 45);
            search.Margin = new Padding(2);
            search.Name = "search";
            search.Size = new Size(195, 27);
            search.TabIndex = 32;
            search.TextChanged += search_TextChanged;
            // 
            // vendorTableAdapterBindingSource
            // 
            vendorTableAdapterBindingSource.DataSource = typeof(DataSet1TableAdapters.vendorTableAdapter);
            // 
            // ViewVendors
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(search);
            Controls.Add(search_btn);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(addVendor_typeOfSoftware);
            Controls.Add(label7);
            Controls.Add(addVendor_softwareName);
            Controls.Add(label6);
            Controls.Add(addVendor_companyAddress);
            Controls.Add(label5);
            Controls.Add(addVendor_companyWebsite);
            Controls.Add(label4);
            Controls.Add(addVendor_companyName);
            Controls.Add(label3);
            Controls.Add(addVendor_id);
            Controls.Add(label2);
            Controls.Add(dataGridView2);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "ViewVendors";
            Size = new Size(938, 610);
            Load += ViewVendors_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)vendorTableAdapterBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private BindingSource vendorTableAdapterBindingSource;
    }
}
