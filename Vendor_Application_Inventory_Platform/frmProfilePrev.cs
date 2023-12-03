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
    public partial class frmProfilePrev : Form
    {
        public frmProfilePrev()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmContact contactForm = new frmContact();
            contactForm.Show();
            this.Hide();
            DialogResult result = MessageBox.Show("Contact Us", "Contact Us", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if(result == DialogResult.OK)
            {
                contactForm.Close();
                if (Application.OpenForms["Dashboard"] != null)
                {
                    Application.OpenForms["Dashboard"].Close();
                }

                Dashboard dashboard = new Dashboard();
                dashboard.Show();

                
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
