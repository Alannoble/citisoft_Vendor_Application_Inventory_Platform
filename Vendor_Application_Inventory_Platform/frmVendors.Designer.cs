namespace Vendor_Application_Inventory_Platform
{
    partial class frmVendors
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.profileBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.profileBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.vendorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.search_btn = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.profileBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profileBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(464, 245);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "No Vendors Yet...";
            // 
            // profileBindingSource
            // 
            this.profileBindingSource.DataSource = typeof(Vendor_Application_Inventory_Platform.Profile);
            // 
            // profileBindingSource1
            // 
            this.profileBindingSource1.DataSource = typeof(Vendor_Application_Inventory_Platform.Profile);
            // 
            // vendorBindingSource
            // 
            this.vendorBindingSource.DataMember = "vendor";
            this.vendorBindingSource.DataSource = this.dataSet1BindingSource;
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = typeof(Vendor_Application_Inventory_Platform.DataSet1);
            this.dataSet1BindingSource.Position = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1065, 423);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_2);
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(717, 32);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(112, 34);
            this.search_btn.TabIndex = 32;
            this.search_btn.Text = "Search";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(843, 32);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(243, 31);
            this.search.TabIndex = 33;
            this.search.TextChanged += new System.EventHandler(this.search_TextChanged);
            // 
            // frmVendors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 528);
            this.Controls.Add(this.search);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmVendors";
            this.Text = "frmVendors";
            this.Load += new System.EventHandler(this.frmVendors_Load_2);
            ((System.ComponentModel.ISupportInitialize)(this.profileBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profileBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private BindingSource profileBindingSource;
        private BindingSource profileBindingSource1;
        private BindingSource vendorBindingSource;
        private BindingSource dataSet1BindingSource;
        private DataGridView dataGridView1;
        private Button search_btn;
        private TextBox search;
    }
}