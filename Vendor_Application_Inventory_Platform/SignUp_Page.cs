using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vendor_Application_Inventory_Platform
{
    public partial class SignUp_Page : Form
    {
        static SqlConnection conn = null!;
        static SqlConnection cmd = null!;
        static SqlDataReader reader = null!;

        public SignUp_Page()
        {
            InitializeComponent();
            Database_Connection();
        }

        private void Database_Connection()
        {
            string url = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\emman\Source\Repos\Alannoble\citisoft_Vendor_Application_Inventory_Platform\Vendor_Application_Inventory_Platform\dbuser.mdf;Integrated Security=True";

            conn = new SqlConnection(url);
        }


        private void Register_button_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" && txtPassword.Text == "" && txtConPassword.Text == "")
            {
                MessageBox.Show("Username and Password fields cannot be left empty.", "SIGN UP FAILED!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (txtPassword.Text == txtConPassword.Text)
            {
                string username = txtUsername.Text;
                string password = txtPassword.Text;


                txtUsername.Text = "";
                txtPassword.Text = "";
                txtConPassword.Text = "";


                MessageBox.Show("Registration successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            else
            {
                MessageBox.Show("Password does not match. Please try again", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Text = "";
                txtConPassword.Text = "";
                txtPassword.Focus();
            }
        }

        private void logIn_button_Click(object sender, EventArgs e)
        {
            new LoginPage().Show();
            this.Hide();
        }
    }
}
