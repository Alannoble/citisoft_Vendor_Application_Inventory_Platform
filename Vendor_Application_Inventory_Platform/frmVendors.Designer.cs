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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.profileBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.profileBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyWebsiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.softwareNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeOfSoftwareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.profileBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profileBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
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
            // dataGridView1
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Transparent;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.companyNameDataGridViewTextBoxColumn,
            this.companyWebsiteDataGridViewTextBoxColumn,
            this.companyAddressDataGridViewTextBoxColumn,
            this.softwareNameDataGridViewTextBoxColumn,
            this.typeOfSoftwareDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vendorBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 67);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1189, 565);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 150;
            // 
            // companyNameDataGridViewTextBoxColumn
            // 
            this.companyNameDataGridViewTextBoxColumn.DataPropertyName = "companyName";
            this.companyNameDataGridViewTextBoxColumn.HeaderText = "companyName";
            this.companyNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.companyNameDataGridViewTextBoxColumn.Name = "companyNameDataGridViewTextBoxColumn";
            this.companyNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.companyNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // companyWebsiteDataGridViewTextBoxColumn
            // 
            this.companyWebsiteDataGridViewTextBoxColumn.DataPropertyName = "companyWebsite";
            this.companyWebsiteDataGridViewTextBoxColumn.HeaderText = "companyWebsite";
            this.companyWebsiteDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.companyWebsiteDataGridViewTextBoxColumn.Name = "companyWebsiteDataGridViewTextBoxColumn";
            this.companyWebsiteDataGridViewTextBoxColumn.ReadOnly = true;
            this.companyWebsiteDataGridViewTextBoxColumn.Width = 150;
            // 
            // companyAddressDataGridViewTextBoxColumn
            // 
            this.companyAddressDataGridViewTextBoxColumn.DataPropertyName = "companyAddress";
            this.companyAddressDataGridViewTextBoxColumn.HeaderText = "companyAddress";
            this.companyAddressDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.companyAddressDataGridViewTextBoxColumn.Name = "companyAddressDataGridViewTextBoxColumn";
            this.companyAddressDataGridViewTextBoxColumn.ReadOnly = true;
            this.companyAddressDataGridViewTextBoxColumn.Width = 150;
            // 
            // softwareNameDataGridViewTextBoxColumn
            // 
            this.softwareNameDataGridViewTextBoxColumn.DataPropertyName = "softwareName";
            this.softwareNameDataGridViewTextBoxColumn.HeaderText = "softwareName";
            this.softwareNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.softwareNameDataGridViewTextBoxColumn.Name = "softwareNameDataGridViewTextBoxColumn";
            this.softwareNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.softwareNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // typeOfSoftwareDataGridViewTextBoxColumn
            // 
            this.typeOfSoftwareDataGridViewTextBoxColumn.DataPropertyName = "TypeOfSoftware";
            this.typeOfSoftwareDataGridViewTextBoxColumn.HeaderText = "TypeOfSoftware";
            this.typeOfSoftwareDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.typeOfSoftwareDataGridViewTextBoxColumn.Name = "typeOfSoftwareDataGridViewTextBoxColumn";
            this.typeOfSoftwareDataGridViewTextBoxColumn.ReadOnly = true;
            this.typeOfSoftwareDataGridViewTextBoxColumn.Width = 150;
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
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(751, 15);
            this.searchBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(290, 31);
            this.searchBox.TabIndex = 3;
            this.searchBox.Text = "Search";
            // 
            // frmVendors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 632);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmVendors";
            this.Text = "frmVendors";
            ((System.ComponentModel.ISupportInitialize)(this.profileBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profileBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private BindingSource profileBindingSource;
        private BindingSource profileBindingSource1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn companyNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn companyWebsiteDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn companyAddressDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn softwareNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn typeOfSoftwareDataGridViewTextBoxColumn;
        private BindingSource vendorBindingSource;
        private BindingSource dataSet1BindingSource;
        private TextBox searchBox;
    }
}