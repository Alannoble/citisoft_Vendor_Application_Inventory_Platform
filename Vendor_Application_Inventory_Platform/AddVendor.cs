using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Diagnostics;

namespace Vendor_Application_Inventory_Platform
{
    public partial class AddVendor : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\91623\Source\Repos\Alannoble\citisoft_Vendor_Application_Inventory_Platform\Vendor_Application_Inventory_Platform\batmon.mdf;Integrated Security=True");



        public AddVendor()
        {
            InitializeComponent();
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;

            displayvendorData();
        }

        private void DataGridView1_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
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
            if (addVendor_id.Text == ""
                || addVendor_companyName.Text == ""
                || addVendor_companyWebsite.Text == ""
                || addVendor_companyAddress.Text == ""
                || addVendor_softwareName.Text == ""
                || addVendor_typeOfSoftware.Text == "")

            {
                MessageBox.Show("Please fill all blank fields",
                    "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State == ConnectionState.Closed)
                {
                    try
                    {
                        connect.Open();
                        string checkvmID = "SELECT COUNT(*) from vendortable WHERE vendor_id = @vmID AND delete_date IS NULL";

                        using (SqlCommand checkvm = new SqlCommand(checkvmID, connect))
                        {
                            checkvm.Parameters.AddWithValue("@vmID", addVendor_id.Text.Trim());
                            int count = (int)checkvm.ExecuteScalar();

                            if (count >= 1)
                            {
                                MessageBox.Show(addVendor_id.Text.Trim() + "is already taken",
                                     "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                DateTime today = DateTime.Today;
                                string insertData = "Insert into vendortable" +
                                    "(vendor_id, company_name, company_website, " +
                                    "company_address, software_name, type_of_software, insert_date)" +
                                    "VALUES(@vmID, @company_name, @company_website, @company_address " +
                                    ", @software_name, @type_of_software, @insert_date)";





                                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@vmID", addVendor_id.Text.Trim());
                                    cmd.Parameters.AddWithValue("@company_name", addVendor_companyName.Text.Trim());
                                    cmd.Parameters.AddWithValue("@company_website", addVendor_companyWebsite.Text.Trim());
                                    cmd.Parameters.AddWithValue("@company_address", addVendor_companyAddress.Text.Trim());
                                    cmd.Parameters.AddWithValue("@software_name", addVendor_softwareName.Text.Trim());
                                    cmd.Parameters.AddWithValue("@type_of_software", addVendor_typeOfSoftware.Text.Trim());
                                    cmd.Parameters.AddWithValue("@insert_date", today);


                                    cmd.ExecuteNonQuery();
                                    displayvendorData();


                                    MessageBox.Show("Saved successfully!"
                                        , "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);



                                    clearFields();


                                }
                            }
                        }

                    } catch (Exception ex)
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



        private void OpenWebsiteInExternalBrowser(string url)
        {
            try
            {
                // Check if the URL is valid before attempting to open it
                if (Uri.TryCreate(url, UriKind.Absolute, out Uri uri))
                {
                    // Use ProcessStartInfo to configure the process start
                    ProcessStartInfo psi = new ProcessStartInfo
                    {
                        FileName = uri.ToString(),  // Use the formatted URI
                        UseShellExecute = true      // Use the default shell to open the URL
                    };

                    // Start the process
                    Process.Start(psi);
                }
                else
                {
                    // Notify the user of an invalid URL
                    MessageBox.Show("Invalid URL format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                // Handle any exceptions that might occur
                MessageBox.Show("Error opening website: " + ex.Message,
                    "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        public void clearFields()
        {
            addVendor_id.Text = "";
            addVendor_companyName.Text = "";
            addVendor_companyWebsite.Text = "";
            addVendor_companyAddress.Text = "";
            addVendor_softwareName.Text = "";
            addVendor_typeOfSoftware.Text = "";
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["website"].Index)
            {
                object cellValue = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

                if (cellValue != null)
                {
                    string urlString = cellValue.ToString();

                    // Check if the URL has a valid scheme (http:// or https://), and add it if missing
                    if (!urlString.StartsWith("http://") && !urlString.StartsWith("https://"))
                    {
                        urlString = "http://" + urlString;
                    }

                    OpenWebsiteInExternalBrowser(urlString);
                }
            }

        }

            private void addVendor_id_TextChanged(object sender, EventArgs e)
            {

            }

            private void tableAdapterManagerBindingSource_CurrentChanged(object sender, EventArgs e)
            {

            }

            private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
            {

            }

            private void panel1_Paint(object sender, PaintEventArgs e)
            {

            }

            private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
            {
                if (e.RowIndex != -1)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    addVendor_id.Text = row.Cells[1].Value.ToString();
                    addVendor_companyName.Text = row.Cells[2].Value.ToString();
                    addVendor_companyWebsite.Text = row.Cells[3].Value.ToString();
                    addVendor_companyAddress.Text = row.Cells[4].Value.ToString();
                    addVendor_softwareName.Text = row.Cells[5].Value.ToString();
                    addVendor_typeOfSoftware.Text = row.Cells[6].Value.ToString();

                }
            }
        
    }
}

