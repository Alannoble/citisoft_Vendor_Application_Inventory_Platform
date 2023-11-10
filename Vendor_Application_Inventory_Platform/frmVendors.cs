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

    public partial class frmVendors : Form
    {
        private List<Profile> profiles = new List<Profile>();
        public frmVendors()
        {
            InitializeComponent();
        }

        private void frmVendors_Load(object sender, EventArgs e)
        {

        }
    }
}
