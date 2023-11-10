namespace Vendor_Application_Inventory_Platform
{
    public class Profile
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Software { get; set; }

        public Profile(string name, string description, string software)
        {
            Name = name;
            Description = description;
            Software = software;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Description: {Description}, Software: {Software}";
        }
    }
}