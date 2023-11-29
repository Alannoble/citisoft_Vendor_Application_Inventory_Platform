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
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\91623\source\repos\citisoft_Vendor_Application_Inventory_Platform\Vendor_Application_Inventory_Platform\vendordatabase.mdf; Integrated Security=True;Connect Timeout=30");


        public int ID { set; get; }
        public string vendor_id { set; get; }   
        public string company_name { set; get; }
        public string company_website { set; get; } 
        public string company_address { set; get; } 
        public string software_name { set; get; }   
        public string type_of_software { set; get; }  
        public string image { set; get; }   


        public List<vendorData> vendorDataList()

        {
            List<vendorData> listData = new List<vendorData>();

            if(connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();
                    string selectData = "SELECT * FROM vendor WHERE delete_data is NULL";

                    using(SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader(); 

                        while (reader.Read())
                        {
                            vendorData ed = new vendorData();
                            ed.ID = (int)reader["id"];
                            ed.vendor_id = reader["vendor_id"].ToString();
                            ed.company_name = reader["Company Name"].ToString(); 
                            ed.company_website = reader ["Company Website"].ToString();
                            ed.company_address = reader ["Company Address"].ToString();
                            ed.software_name = reader["Software"].ToString();
                            ed.type_of_software = reader ["Type of Software"].ToString();
                            ed.image = reader["image"].ToString();

                             listData.Add(ed);

                        }   
                    }

                }catch(Exception ex)
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
