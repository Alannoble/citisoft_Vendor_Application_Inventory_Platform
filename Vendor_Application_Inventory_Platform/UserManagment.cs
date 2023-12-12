using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vendor_Application_Inventory_Platform
{
    public class UserManagment
    {
        private const string CredentialsFilePath = @"C:\Users\91623\source\repos\albinsaji00\New folder\Vendor_Application_Inventory_Platform\UserData.txt";

        public bool CheckCredentials(string username, string password)
        {
            string[] lines = File.ReadAllLines(CredentialsFilePath);
            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                if (parts.Length == 2 && parts[0] == username && parts[1] == password)
                {
                    return true;
                }
            }
            return false;
        }

        public bool CheckUserExists(string username)
        {
            string filePath = Path.Combine(Application.StartupPath, CredentialsFilePath);

            string[] lines = File.ReadAllLines(CredentialsFilePath);
            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                if (parts.Length == 2 && parts[0] == username)
                {
                    return true;
                }
            }
            return false;
        }

        public void RegisterUser(string username, string password)
        {
            string filePath = Path.Combine(Application.StartupPath, CredentialsFilePath);

            using (StreamWriter sw = File.AppendText(CredentialsFilePath))
            {
                sw.WriteLine($"{username},{password}");
            }
        }
    }
}
