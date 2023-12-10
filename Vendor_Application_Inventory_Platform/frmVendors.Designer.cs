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
            label1 = new Label();
            profileBindingSource = new BindingSource(components);
            profileBindingSource1 = new BindingSource(components);
            vendorBindingSource = new BindingSource(components);
            dataSet1BindingSource = new BindingSource(components);
            dataGridView1 = new DataGridView();
            search_btn = new Button();
            search = new TextBox();
            pdfBtn = new Button();
            selectPdfBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)profileBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)profileBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)vendorBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataSet1BindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(17, 66);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(852, 297);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_2;
            // 
            // search_btn
            // 
            search_btn.Location = new Point(574, 26);
            search_btn.Margin = new Padding(2);
            search_btn.Name = "search_btn";
            search_btn.Size = new Size(90, 27);
            search_btn.TabIndex = 32;
            search_btn.Text = "Search";
            search_btn.UseVisualStyleBackColor = true;
            search_btn.Click += search_btn_Click;
            // 
            // search
            // 
            search.Location = new Point(674, 26);
            search.Margin = new Padding(2);
            search.Name = "search";
            search.Size = new Size(195, 27);
            search.TabIndex = 33;
            search.TextChanged += search_TextChanged;
            // 
            // pdfBtn
            // 
            pdfBtn.Location = new Point(745, 377);
            pdfBtn.Name = "pdfBtn";
            pdfBtn.Size = new Size(124, 33);
            pdfBtn.TabIndex = 34;
            pdfBtn.Text = "Download all";
            pdfBtn.UseVisualStyleBackColor = true;
            pdfBtn.Click += pdfBtn_Click;
            // 
            // selectPdfBtn
            // 
            selectPdfBtn.Location = new Point(17, 377);
            selectPdfBtn.Name = "selectPdfBtn";
            selectPdfBtn.Size = new Size(94, 29);
            selectPdfBtn.TabIndex = 35;
            selectPdfBtn.Text = "Download as PDF";
            selectPdfBtn.UseVisualStyleBackColor = true;
            selectPdfBtn.Click += selectPdfBtn_Click;
            // 
            // frmVendors
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(890, 422);
            Controls.Add(selectPdfBtn);
            Controls.Add(pdfBtn);
            Controls.Add(search);
            Controls.Add(search_btn);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmVendors";
            Text = "frmVendors";
            Load += frmVendors_Load_2;
            ((System.ComponentModel.ISupportInitialize)profileBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)profileBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)vendorBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataSet1BindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private Button pdfBtn;
        private Button selectPdfBtn;
    }
}