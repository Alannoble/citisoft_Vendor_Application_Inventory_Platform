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

namespace Vendor_Application_Inventory_Platform
{
    public partial class CommentRatingForm : Form
    {

        
        private readonly SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\91623\source\repos\albinsaji00\New folder\Vendor_Application_Inventory_Platform\batmon.mdf"";Integrated Security=True");


        private string selectedCellData;
        private string comment;
        private int rating;

        public CommentRatingForm(string? selectedCellData)
        {

            InitializeComponent();
            // Set the private variable to the selected cell data
            // Set the private variable to the selected cell data
            this.selectedCellData = selectedCellData;

            // For demonstration purposes, you can display the selected cell data in a MessageBox
            MessageBox.Show($"Selected Cell Data: {selectedCellData}", "Cell Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CommentRatingForm_Load(object sender, EventArgs e)
        {

        }

        private void commenttxt_TextChanged(object sender, EventArgs e)
        {

        }


        private void savebtn_Click(object sender, EventArgs e)
        {


            string comment = commenttxt.Text;
            int rating = (int)numericUpDownrating.Value;

            // Save the comment and rating to the database
            SaveCommentAndRatingToDatabase(comment, rating);

            // Update the DataGridView in frmVendors
            if (Owner is frmVendors frmVendors)
            {
                frmVendors.displayvendorData();
            }

            // Optionally, close the form after saving
            this.Close();
        }
        private void SaveCommentAndRatingToDatabase(string comment, int rating)
        {
            try
            {
                connection.Open();

                // Assuming you have columns named 'VendorName', 'Comment', and 'Rating' in your main table
                string query = "INSERT INTO CommentsRatings (VendorID, Comment, Rating) VALUES (@VendorID, @Comment, @Rating)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@VendorID", selectedCellData); // Replace with the actual column name
                    command.Parameters.AddWithValue("@Comment", comment);
                    command.Parameters.AddWithValue("@Rating", rating);

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving comment and rating to the database: " + ex.Message,
                    "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }



        private void deletebtn_Click(object sender, EventArgs e)
        {

        }


        private void numericUpDownrating_ValueChanged(object sender, EventArgs e)
        {

        }
    
}
}

