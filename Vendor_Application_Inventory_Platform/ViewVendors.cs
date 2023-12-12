using System.Data.SqlClient;
using iText.Layout;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Document = iText.Layout.Document;
using PdfWriter = iTextSharp.text.pdf.PdfWriter;
using iText.Kernel.Pdf;
using iText.Layout.Element;
using PdfDocument = iTextSharp.text.pdf.PdfDocument;
using System.Diagnostics;

namespace Vendor_Application_Inventory_Platform
{
    public partial class ViewVendors : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\91623\source\repos\albinsaji00\New folder\Vendor_Application_Inventory_Platform\batmon.mdf"";Integrated Security=True");


        public ViewVendors()
        {
            InitializeComponent();
            displayvendorData();
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;

        }

        public SignUp_Page SignUp_Page
        {
            get => default;
            set
            {
            }
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


            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView2.Columns["website"].Index)
            {
                object cellValue = dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

                if (cellValue != null)
                {
                    string urlString = cellValue.ToString();


                    if (!urlString.StartsWith("http://") && !urlString.StartsWith("https://"))
                    {
                        urlString = "http://" + urlString;
                    }

                    OpenWebsiteInExternalBrowser(urlString);
                }
            }

        }

        private void OpenWebsiteInExternalBrowser(string url)
        {
            try
            {

                if (Uri.TryCreate(url, UriKind.Absolute, out Uri uri))
                {

                    ProcessStartInfo psi = new ProcessStartInfo
                    {
                        FileName = uri.ToString(),
                        UseShellExecute = true
                    };


                    Process.Start(psi);
                }
                else
                {

                    MessageBox.Show("Invalid URL format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error opening website: " + ex.Message,
                    "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchQuery = search.Text.Trim();
            displayvendorData(searchQuery);
        }

        public void displayvendorData(string searchQuery = "")
        {
            vendorData vd = new();
            List<vendorData> listData = vd.vendorListData(searchQuery);


            dataGridView2.DataSource = listData;
            dataGridView2.Refresh();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];
                addVendor_id.Text = row.Cells[1].Value.ToString();
                addVendor_companyName.Text = row.Cells[2].Value.ToString();
                addVendor_companyWebsite.Text = row.Cells[3].Value.ToString();
                addVendor_companyAddress.Text = row.Cells[4].Value.ToString();
                addVendor_softwareName.Text = row.Cells[5].Value.ToString();
                addVendor_typeOfSoftware.Text = row.Cells[6].Value.ToString();

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

        private void button1_Click(object sender, EventArgs e)
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

                DialogResult check = MessageBox.Show("Are you sure you want to CHANGE" +
                    "Vendor ID: " + addVendor_id.Text.Trim() + "?", "Confirmation Message"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Information);


                if (check == DialogResult.Yes)
                {
                    try
                    {
                        connect.Open();

                        DateTime today = DateTime.Today;
                        string updateData = "UPDATE vendortable SET company_name = @company_name" +
                            ", company_website = @company_website, company_address = @company_address, software_name = @software_name" +
                            ", type_of_software = @type_of_software " +
                            "WHERE vendor_id = @vendor_id";

                        using (SqlCommand cmd = new(updateData, connect))
                        {
                            cmd.Parameters.AddWithValue("@company_name", addVendor_companyName.Text.Trim());
                            cmd.Parameters.AddWithValue("@company_website", addVendor_companyWebsite.Text.Trim());
                            cmd.Parameters.AddWithValue("@company_address", addVendor_companyAddress.Text.Trim());
                            cmd.Parameters.AddWithValue("@software_name", addVendor_softwareName.Text.Trim());
                            cmd.Parameters.AddWithValue("@type_of_software", addVendor_typeOfSoftware.Text.Trim());
                            cmd.Parameters.AddWithValue("@Vendor_id", addVendor_id.Text.Trim());

                            cmd.ExecuteNonQuery();

                            displayvendorData();


                            MessageBox.Show("Added successfully!"
                                , "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            clearFields();

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message,
                         "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Cancelled."
                        , "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


            }
        }

        private void button2_Click_1(object sender, EventArgs e)
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

                DialogResult check = MessageBox.Show("Are you sure you want to DELETE" +
                    "Vendor ID: " + addVendor_id.Text.Trim() + "?", "Confirmation Message"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Information);


                if (check == DialogResult.Yes)
                {
                    try
                    {
                        connect.Open();

                        DateTime today = DateTime.Today;

                        string updateData = "UPDATE vendortable SET delete_date = @delete_date " +
                            "WHERE vendor_id = @vendor_id";

                        using (SqlCommand cmd = new(updateData, connect))
                        {
                            cmd.Parameters.AddWithValue("@delete_date", today);
                            cmd.Parameters.AddWithValue("@vendor_id", addVendor_id.Text.Trim());


                            cmd.ExecuteNonQuery();

                            displayvendorData();


                            MessageBox.Show("deleted successfully!"
                                , "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            clearFields();

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message,
                         "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Cancelled."
                        , "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


            }
        }





        private void search_btn_Click(object sender, EventArgs e)
        {
            string searchQuery = search.Text.Trim();
            displayvendorData(searchQuery);
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            string searchQuery = search.Text.Trim();
            displayvendorData(searchQuery);
        }


    }
}









