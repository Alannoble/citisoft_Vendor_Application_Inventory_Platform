using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vendor_Application_Inventory_Platform
{
    public partial class ViewVendors : UserControl
    {
        public ViewVendors()
        {
            InitializeComponent();
            displayvendorData();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }
        public void displayvendorData()
        {
            vendorData vd = new vendorData();
            List<vendorData> listData = vd.vendorListData();

            dataGridView2.DataSource = listData;

        }

            private void ViewVendors_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
