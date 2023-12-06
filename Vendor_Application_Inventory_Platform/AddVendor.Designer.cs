namespace Vendor_Application_Inventory_Platform
{
    partial class AddVendor
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            panel3 = new Panel();
            panel2 = new Panel();
            panel4 = new Panel();
            button2 = new Button();
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
            vendorTableAdapterBindingSource = new BindingSource(components);
            tableAdapterManagerBindingSource = new BindingSource(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)vendorTableAdapterBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tableAdapterManagerBindingSource).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(63, 41);
            panel1.Margin = new Padding(5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1868, 656);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(33, 11, 97);
            dataGridViewCellStyle2.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = SystemColors.ButtonHighlight;
            dataGridView1.Location = new Point(37, 131);
            dataGridView1.Margin = new Padding(5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(33, 11, 97);
            dataGridViewCellStyle4.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(1785, 477);
            dataGridView1.TabIndex = 1;
            dataGridView1.VirtualMode = true;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(34, 41);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(286, 57);
            label1.TabIndex = 3;
            label1.Text = "Vendor Data";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ButtonHighlight;
            panel3.Location = new Point(0, 651);
            panel3.Margin = new Padding(5);
            panel3.Name = "panel3";
            panel3.Size = new Size(1868, 549);
            panel3.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Location = new Point(0, 651);
            panel2.Margin = new Padding(5);
            panel2.Name = "panel2";
            panel2.Size = new Size(1868, 549);
            panel2.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ButtonHighlight;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(button2);
            panel4.Controls.Add(addVendor_typeOfSoftware);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(addVendor_softwareName);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(addVendor_companyAddress);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(addVendor_companyWebsite);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(addVendor_companyName);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(addVendor_id);
            panel4.Controls.Add(label2);
            panel4.Location = new Point(68, 725);
            panel4.Margin = new Padding(5);
            panel4.Name = "panel4";
            panel4.Size = new Size(1867, 481);
            panel4.TabIndex = 3;
            panel4.Paint += panel4_Paint;
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
            button2.Location = new Point(78, 389);
            button2.Margin = new Padding(5);
            button2.Name = "button2";
            button2.Size = new Size(160, 56);
            button2.TabIndex = 14;
            button2.Text = "Add";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // addVendor_typeOfSoftware
            // 
            addVendor_typeOfSoftware.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            addVendor_typeOfSoftware.Location = new Point(1343, 143);
            addVendor_typeOfSoftware.Margin = new Padding(5);
            addVendor_typeOfSoftware.Name = "addVendor_typeOfSoftware";
            addVendor_typeOfSoftware.Size = new Size(370, 41);
            addVendor_typeOfSoftware.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(988, 154);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(281, 41);
            label7.TabIndex = 10;
            label7.Text = "Type Of Software";
            // 
            // addVendor_softwareName
            // 
            addVendor_softwareName.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            addVendor_softwareName.Location = new Point(1343, 36);
            addVendor_softwareName.Margin = new Padding(5);
            addVendor_softwareName.Name = "addVendor_softwareName";
            addVendor_softwareName.Size = new Size(370, 41);
            addVendor_softwareName.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(988, 48);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(249, 41);
            label6.TabIndex = 8;
            label6.Text = "Software Name";
            // 
            // addVendor_companyAddress
            // 
            addVendor_companyAddress.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            addVendor_companyAddress.Location = new Point(384, 233);
            addVendor_companyAddress.Margin = new Padding(5);
            addVendor_companyAddress.Name = "addVendor_companyAddress";
            addVendor_companyAddress.Size = new Size(370, 41);
            addVendor_companyAddress.TabIndex = 7;
            addVendor_companyAddress.TextChanged += textBox4_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(29, 244);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(287, 41);
            label5.TabIndex = 6;
            label5.Text = "Company Address";
            // 
            // addVendor_companyWebsite
            // 
            addVendor_companyWebsite.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            addVendor_companyWebsite.Location = new Point(386, 157);
            addVendor_companyWebsite.Margin = new Padding(5);
            addVendor_companyWebsite.Name = "addVendor_companyWebsite";
            addVendor_companyWebsite.Size = new Size(370, 41);
            addVendor_companyWebsite.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(31, 169);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(289, 41);
            label4.TabIndex = 4;
            label4.Text = "Company Website";
            // 
            // addVendor_companyName
            // 
            addVendor_companyName.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            addVendor_companyName.Location = new Point(386, 87);
            addVendor_companyName.Margin = new Padding(5);
            addVendor_companyName.Name = "addVendor_companyName";
            addVendor_companyName.Size = new Size(370, 41);
            addVendor_companyName.TabIndex = 3;
            addVendor_companyName.TextChanged += textBox2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(31, 98);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(257, 41);
            label3.TabIndex = 2;
            label3.Text = "Company Name";
            // 
            // addVendor_id
            // 
            addVendor_id.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            addVendor_id.Location = new Point(386, 20);
            addVendor_id.Margin = new Padding(5);
            addVendor_id.Name = "addVendor_id";
            addVendor_id.Size = new Size(370, 41);
            addVendor_id.TabIndex = 1;
            addVendor_id.TextChanged += addVendor_id_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(31, 31);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(171, 41);
            label2.TabIndex = 0;
            label2.Text = "Vendor ID";
            label2.Click += label2_Click;
            // 
            // tableAdapterManagerBindingSource
            // 
            tableAdapterManagerBindingSource.CurrentChanged += tableAdapterManagerBindingSource_CurrentChanged;
            // 
            // AddVendor
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(panel4);
            Controls.Add(panel1);
            Margin = new Padding(5);
            Name = "AddVendor";
            Size = new Size(1994, 1251);
            Load += AddVendor_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)vendorTableAdapterBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)tableAdapterManagerBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel3;
        private Panel panel2;
        private Panel panel4;
        private Label label2;
        private TextBox addVendor_companyAddress;
        private Label label5;
        private TextBox addVendor_companyWebsite;
        private Label label4;
        private TextBox addVendor_companyName;
        private Label label3;
        private TextBox addVendor_id;
        private TextBox addVendor_typeOfSoftware;
        private Label label7;
        private TextBox addVendor_softwareName;
        private Label label6;
        private Button button2;
        private BindingSource vendorTableAdapterBindingSource;
        private BindingSource tableAdapterManagerBindingSource;
        private DataGridView dataGridView1;
    }
}
