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
        public string vendor_id { get; set; }
        public string company_name { get; set; }
        public string company_website { get; set; }
        public string company_address { get; set; }
        public string software_name { get; set; }
        public string type_of_software { get; set; }



        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\91623\source\repos\Alannoble\citisoft_Vendor_Application_Inventory_Platform\Vendor_Application_Inventory_Platform\batmon.mdf;Integrated Security=True;Connect Timeout=30");

        public List<vendorData> vendorListData()

        {
            List<vendorData> listData = new List<vendorData>();

            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();
                    string selectData = "SELECT * FROM vendortable ";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            vendorData vd = new vendorData();
                            vd.ID = (int)reader["id"];
                            vd.vendor_id = reader["vendor_id"].ToString();
                            vd.company_name = reader["company_name"].ToString();
                            vd.company_website = reader["company_website"].ToString();
                            vd.company_address = reader["company_address"].ToString();
                            vd.software_name = reader["software_name"].ToString();
                            vd.type_of_software = reader["type_of_sotware"].ToString();


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
