using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace Vendor_Application_Inventory_Platform
{
    public partial class AddVendor : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\91623\source\repos\citisoft_Vendor_Application_Inventory_Platform\Vendor_Application_Inventory_Platform\vendordatabase.mdf;Integrated Security=True;Connect Timeout=30");

        public AddVendor()
        {
            InitializeComponent();

            //to display the data from database to data grid view 
            displayvendorData();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        public void displayvendorData()
        {
            vendorData vd = new vendorData();
            List<vendorData> listData = vd.vendorListData();

            dataGridView1.DataSource = listData;


        }
        private void button2_Click(object sender, EventArgs e)
        {
            if(addVendor_id.Text == ""
                || addVendor_companyName.Text == ""
                || addVendor_companyWebsite.Text == ""
                || addVendor_companyAddress.Text == ""
                || addVendor_softwareName.Text ==  ""
                || addVendor_typeOfSoftware.Text == ""
                || addVendor_picture.Image == null)
            {
                MessageBox.Show("Please fill all blank fields",
                    "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(connect.State == ConnectionState.Closed)
                {
                    try
                    {
                        connect.Open();
                        string checkvmID = "Select count(*) from vendor where vendor_id = @vmID and delete_date is NULL";

                        using(SqlCommand checkvm = new SqlCommand(checkvmID, connect))
                        {
                            checkvm.Parameters.AddWithValue("@vmID", addVendor_id.Text.Trim());
                            int count = (int) checkvm.ExecuteScalar();

                            if(count >= 1)
                            {
                                MessageBox.Show(addVendor_id.Text.Trim() + "is already taken",
                                     "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                DateTime today = DateTime.Today;
                                string insertData = "Insert into vendors" +
                                    "(vendor_id, company_name, company_website, " +
                                    "company_address, software_name, type_of_software, image, insert_date)" +
                                    "VALUES(@vendor_id, @company_name, @company_website, @company_address " +
                                    ", @software_name, @type_of_software, @image , @insert_date)";

                                string path = Path.Combine(@"C:\Users\91623\Source\Repos\citisoft_Vendor_Application_Inventory_Platform\Vendor_Application_Inventory_Platform\Directory\"
                                 + addVendor_id.Text.Trim() + ".jpg");


                                string directoryPath = Path.GetDirectoryName(path);

                                if (!Directory.Exists(directoryPath))
                                {
                                    Directory.CreateDirectory(directoryPath);

                                }

                                File.Copy(addVendor_picture.ImageLocation, path, true);

                                using(SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@vendor_id", addVendor_id.Text.Trim());
                                    cmd.Parameters.AddWithValue("@company_name", addVendor_companyName.Text.Trim());
                                    cmd.Parameters.AddWithValue("@company_website", addVendor_companyWebsite.Text.Trim());
                                    cmd.Parameters.AddWithValue("@company_address", addVendor_companyAddress.Text.Trim());
                                    cmd.Parameters.AddWithValue("@software_name", addVendor_softwareName.Text.Trim());
                                    cmd.Parameters.AddWithValue("@type_of_software", addVendor_typeOfSoftware.Text.Trim());
                                    cmd.Parameters.AddWithValue("@image", path);
                                    cmd.Parameters.AddWithValue("@insert_date", today);


                                    cmd.ExecuteNonQuery();

                                    displayvendorData();


                                    MessageBox.Show("Added successfully!"
                                        , "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    

                                }
                            }
                        }

                    }catch(Exception ex)
                    {
                        MessageBox.Show("Error: " + ex,
                    "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
