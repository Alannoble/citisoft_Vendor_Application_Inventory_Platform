using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Vendor_Application_Inventory_Platform
{

    class vendorData
    {


        public int ID { get; set; } 
        public string VendorID { get; set; }
        public string Company { get; set; }
        public string Website { get; set; }
        public string Address { get; set; }
        public string Software { get; set; }
        public string Software_Type { get; set; }



        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\91623\Source\Repos\Alannoble\citisoft_Vendor_Application_Inventory_Platform\Vendor_Application_Inventory_Platform\batmon.mdf;Integrated Security=True");



        public List<vendorData> vendorListData(string searchQuery = "")
        {
            List<vendorData> listData = new List<vendorData>();

            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();
                    string selectData = "SELECT * FROM vendortable WHERE delete_date is NULL ";

                    if (!string.IsNullOrEmpty(searchQuery))
                    {
                        selectData += "AND (vendor_id LIKE @searchQuery OR company_name LIKE @searchQuery)";
                    }

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        if (!string.IsNullOrEmpty(searchQuery))
                        {
                            cmd.Parameters.AddWithValue("@searchQuery", "%" + searchQuery + "%");
                        }

                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            vendorData vd = new vendorData();
                            vd.ID = (int)reader["id"];
                            vd.VendorID = reader["vendor_id"].ToString();
                            vd.Company = reader["company_name"].ToString();
                            vd.Website = reader["company_website"].ToString();
                            vd.Address = reader["company_address"].ToString();
                            vd.Software = reader["software_name"].ToString();
                            vd.Software_Type = reader["type_of_software"].ToString();

                            listData.Add(vd);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex);
                }
                finally
                {
                    connect.Close();
                }
            }

            return listData;
        }

        public List<vendorData> SearchVendorData(string searchQuery)
        {
            return vendorListData(searchQuery);
        }
    


    public List<vendorData> vendorListData()


        {
            List<vendorData> listData = new List<vendorData>();

            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();
                    string selectData = "SELECT * FROM vendortable WHERE delete_date is NULL ";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            vendorData vd = new vendorData();
                            vd.ID = (int)reader["id"];
                            vd.VendorID = reader["vendor_id"].ToString();
                            vd.Company = reader["company_name"].ToString();
                            vd.Website = reader["company_website"].ToString();
                            vd.Address = reader["company_address"].ToString();
                            vd.Software = reader["software_name"].ToString();
                            vd.Software_Type = reader["type_of_software"].ToString();


                            listData.Add(vd);

                        }
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex);
                }

                finally
                {
                    connect.Close();
                }
            }
            
            return listData;
        }
            
    }
}

