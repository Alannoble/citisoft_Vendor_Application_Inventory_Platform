using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Vendor_Application_Inventory_Platform
{
    public partial class LoginPage : Form
    {
        private UserManagment userManager;

        public LoginPage(UserManagment userManager)
        {
            InitializeComponent();
            this.userManager = userManager;
        }

        static SqlConnection conn = null!;
        static SqlConnection cmd = null!;
        static SqlDataReader reader = null!;


        public LoginPage()
        {
            InitializeComponent();
            userManager = new UserManagment();
            Database_Connection();
        }

        private void Database_Connection()
        {
            string url = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\emman\Source\Repos\Alannoble\citisoft_Vendor_Application_Inventory_Platform\Vendor_Application_Inventory_Platform\dbuser.mdf;Integrated Security=True";

            conn = new SqlConnection(url);


        }
        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to CITISOFT");
        }

        private void Login_button_Click(object sender, EventArgs e)
        {
            if (userManager != null)
            {

                if (txtUsername.Text == "" && txtPassword.Text == "")
                {
                    MessageBox.Show("Username and Password fields cannot be left empty.", "LOGIN FAILED!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    string username = txtUsername.Text;
                    string password = txtPassword.Text;

                    if (userManager.CheckCredentials(username, password))
                    {
                        if (IsAdminUser(username))
                        {
                            // Open the admin form
                            MainForm adminForm = new MainForm();
                            adminForm.Show();
                        }
                        else
                        {
                            // Open the normal user form
                            Dashboard normalUserForm = new Dashboard();
                            normalUserForm.Show();
                        }

                        MessageBox.Show("Login successful!");
                        this.Hide(); // Close the login form after successful login
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password!");
                    }
                }
            }
            else
            {
                MessageBox.Show("User Managment not initialized.");
            }


        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void SignUp_button_Click_1(object sender, EventArgs e)
        {
            SignUp_Page registrationForm = new SignUp_Page(userManager);
            registrationForm.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Forgotpassword_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Error", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            new Dashboard().Show();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_2(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private bool IsAdminUser(string username)
        {
            return username.EndsWith("_admin", StringComparison.OrdinalIgnoreCase);
        }

    }
}