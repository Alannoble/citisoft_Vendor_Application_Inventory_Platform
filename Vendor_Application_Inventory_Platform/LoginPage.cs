namespace Vendor_Application_Inventory_Platform
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to CITISOFT");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Username_textBox.Text.Equals("citisoft") && Password_textBox1.Text.Equals("citisoft")) //  NametextBox1_TextChanged. == "citisoft" && textBox1_TextChanged == "citisoft")
            {
                MessageBox.Show("Login sucessfull, You are Log in as a USER (limited privileges)");
                new Dashboard().Show();
                this.Hide();
            }
            else if (Username_textBox.Text.Equals("Admin") && Password_textBox1.Text.Equals("Password"))
            {
                MessageBox.Show("Login Sucessfull, You are Logged In  to the Admin portal");
                new Dashboard().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or Password");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new SignUp_Page().Show();
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
    }
}