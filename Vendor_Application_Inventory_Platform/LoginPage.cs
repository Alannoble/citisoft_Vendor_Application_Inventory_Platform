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

        static SqlConnection conn = null!;
        static SqlConnection cmd = null!;
        static SqlDataReader reader = null!;


        public LoginPage()
        {
            InitializeComponent();
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
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            if (username.Equals("citisoft") && password.Equals("citisoft")) //  NametextBox1_TextChanged. == "citisoft" && textBox1_TextChanged == "citisoft")
            {
                new Dashboard().Show();
                this.Hide();
            }
            else if (username.Equals("Admin") && password.Equals("Password"))
            {
                new MainForm().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or Password");
            }


            if (username == "" && password == "")
            {
                MessageBox.Show("Username and Password cannot be left empty, Please try again", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                username = "";
                password = "";
                txtUsername.Focus();
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

        private void LoginPage_Load_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_3(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SignUp_button_Click(object sender, EventArgs e)
        {
            UserManagment userManager = new UserManagment();
            SignUp_Page signUpPage = new SignUp_Page(userManager);
            signUpPage.Show();
        }

        private void LoginPage_Load_2(object sender, EventArgs e)
        {

        }

        private void label2_Click_4(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SignUp_button_Click_2(object sender, EventArgs e)
        {
            UserManagment userManager = new UserManagment();
            SignUp_Page signUpPage = new SignUp_Page(userManager);
            signUpPage.Show();
        }
    }
}