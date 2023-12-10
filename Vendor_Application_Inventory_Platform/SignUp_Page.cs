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
        private UserManagment userManager;

        public SignUp_Page(UserManagment userManager)
        {
            InitializeComponent();
            this.userManager = new UserManagment();
        }
        private void Register_button_Click(object sender, EventArgs e)
        {
            if (userManager != null)
            {
                if (txtUsername.Text == "" && txtPassword.Text == "" && txtConPassword.Text == "")
                {
                    MessageBox.Show("Username and Password fields cannot be left empty.", "SIGN UP FAILED!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtPassword.Text == txtConPassword.Text)
                {

                    string username = txtUsername.Text;
                    string password = txtPassword.Text;
                    if (username.EndsWith("_admin", StringComparison.OrdinalIgnoreCase))
                    {
                        MessageBox.Show("Oops! It seems like you're trying to create an admin account. Please use a different username.", "ACCESS DENIED!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtUsername.Text = "";
                        txtPassword.Text = "";
                        txtConPassword.Text = "";
                        return;
                    }

                    if (userManager.CheckUserExists(username))
                    {
                        MessageBox.Show("Username already exists. Please choose a different username.");
                        txtUsername.Text = "";
                        txtPassword.Text = "";
                        txtConPassword.Text = "";
                    }
                    else
                    {
                        userManager.RegisterUser(username, password);
                        MessageBox.Show("Registration successful!", "SUCCESS!");
                        this.Close(); // Close the registration form after successful registration
                        new LoginPage().Show();
                    }
                }
                else
                {
                    MessageBox.Show("Password mismatch. Please try again.", "SIGN UP FAILED!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsername.Text = "";
                    txtPassword.Text = "";
                    txtConPassword.Text = "";
                }
            }
            else
            {
                MessageBox.Show("User Managment not initialized.");
            }
        }


        private void logIn_button_Click(object sender, EventArgs e)
        {
            new LoginPage().Show();
            this.Hide();

        }
    }
}
