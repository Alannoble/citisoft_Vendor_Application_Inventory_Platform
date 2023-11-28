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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            label1 = new Label();
            profileBindingSource = new BindingSource(components);
            profileBindingSource1 = new BindingSource(components);
            dataGridView1 = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            companyNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            companyWebsiteDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            companyAddressDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            softwareNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            typeOfSoftwareDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            vendorBindingSource = new BindingSource(components);
            dataSet1BindingSource = new BindingSource(components);
            searchBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)profileBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)profileBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)vendorBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataSet1BindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(371, 196);
            label1.Name = "label1";
            label1.Size = new Size(185, 31);
            label1.TabIndex = 0;
            label1.Text = "No Vendors Yet...";
            // 
            // profileBindingSource
            // 
            profileBindingSource.DataSource = typeof(Profile);
            // 
            // profileBindingSource1
            // 
            profileBindingSource1.DataSource = typeof(Profile);
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Font = new Font("Nirmala UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Transparent;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SunkenHorizontal;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, companyNameDataGridViewTextBoxColumn, companyWebsiteDataGridViewTextBoxColumn, companyAddressDataGridViewTextBoxColumn, softwareNameDataGridViewTextBoxColumn, typeOfSoftwareDataGridViewTextBoxColumn });
            dataGridView1.DataSource = vendorBindingSource;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 54);
            dataGridView1.Margin = new Padding(2, 2, 2, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(951, 452);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 8;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Width = 150;
            // 
            // companyNameDataGridViewTextBoxColumn
            // 
            companyNameDataGridViewTextBoxColumn.DataPropertyName = "companyName";
            companyNameDataGridViewTextBoxColumn.HeaderText = "companyName";
            companyNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            companyNameDataGridViewTextBoxColumn.Name = "companyNameDataGridViewTextBoxColumn";
            companyNameDataGridViewTextBoxColumn.ReadOnly = true;
            companyNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // companyWebsiteDataGridViewTextBoxColumn
            // 
            companyWebsiteDataGridViewTextBoxColumn.DataPropertyName = "companyWebsite";
            companyWebsiteDataGridViewTextBoxColumn.HeaderText = "companyWebsite";
            companyWebsiteDataGridViewTextBoxColumn.MinimumWidth = 8;
            companyWebsiteDataGridViewTextBoxColumn.Name = "companyWebsiteDataGridViewTextBoxColumn";
            companyWebsiteDataGridViewTextBoxColumn.ReadOnly = true;
            companyWebsiteDataGridViewTextBoxColumn.Width = 150;
            // 
            // companyAddressDataGridViewTextBoxColumn
            // 
            companyAddressDataGridViewTextBoxColumn.DataPropertyName = "companyAddress";
            companyAddressDataGridViewTextBoxColumn.HeaderText = "companyAddress";
            companyAddressDataGridViewTextBoxColumn.MinimumWidth = 8;
            companyAddressDataGridViewTextBoxColumn.Name = "companyAddressDataGridViewTextBoxColumn";
            companyAddressDataGridViewTextBoxColumn.ReadOnly = true;
            companyAddressDataGridViewTextBoxColumn.Width = 150;
            // 
            // softwareNameDataGridViewTextBoxColumn
            // 
            softwareNameDataGridViewTextBoxColumn.DataPropertyName = "softwareName";
            softwareNameDataGridViewTextBoxColumn.HeaderText = "softwareName";
            softwareNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            softwareNameDataGridViewTextBoxColumn.Name = "softwareNameDataGridViewTextBoxColumn";
            softwareNameDataGridViewTextBoxColumn.ReadOnly = true;
            softwareNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // typeOfSoftwareDataGridViewTextBoxColumn
            // 
            typeOfSoftwareDataGridViewTextBoxColumn.DataPropertyName = "TypeOfSoftware";
            typeOfSoftwareDataGridViewTextBoxColumn.HeaderText = "TypeOfSoftware";
            typeOfSoftwareDataGridViewTextBoxColumn.MinimumWidth = 8;
            typeOfSoftwareDataGridViewTextBoxColumn.Name = "typeOfSoftwareDataGridViewTextBoxColumn";
            typeOfSoftwareDataGridViewTextBoxColumn.ReadOnly = true;
            typeOfSoftwareDataGridViewTextBoxColumn.Width = 150;
            // 
            // vendorBindingSource
            // 
            vendorBindingSource.DataMember = "vendor";
            vendorBindingSource.DataSource = dataSet1BindingSource;
            // 
            // dataSet1BindingSource
            // 
            dataSet1BindingSource.DataSource = typeof(DataSet1);
            dataSet1BindingSource.Position = 0;
            // 
            // searchBox
            // 
            searchBox.Location = new Point(601, 12);
            searchBox.Name = "searchBox";
            searchBox.Size = new Size(233, 27);
            searchBox.TabIndex = 3;
            searchBox.Text = "Search";
            // 
            // frmVendors
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(951, 506);
            Controls.Add(searchBox);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmVendors";
            Text = "frmVendors";
            Load += frmVendors_Load_1;
            ((System.ComponentModel.ISupportInitialize)profileBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)profileBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)vendorBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataSet1BindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
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