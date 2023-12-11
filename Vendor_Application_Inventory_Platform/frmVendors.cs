using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;

namespace Vendor_Application_Inventory_Platform
{

    public partial class frmVendors : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\91623\source\repos\albinsaji00\New folder\Vendor_Application_Inventory_Platform\batmon.mdf"";Integrated Security=True");
        // sql database connection
        public frmVendors()
        {
            InitializeComponent();
            displayvendorData();
            InitializeDataGridView();

        }
        private void InitializeDataGridView()
        {
            // Add a new column for comments and ratings
            DataGridViewTextBoxColumn commentRatingColumn = new DataGridViewTextBoxColumn();
            commentRatingColumn.Name = "CommentRatingColumn";
            commentRatingColumn.HeaderText = "Comment and Rating";
            dataGridView1.Columns.Add(commentRatingColumn);
        }
            private void frmVendors_Load(object sender, EventArgs e)
        {

        }

        private void frmVendors_Load_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmVendors_Load_2(object sender, EventArgs e)
        {

        }

        public void displayvendorData()
        {
            vendorData vd = new vendorData();
           
            List<vendorData> listData = vd.vendorListData();

    
            dataGridView1.DataSource = listData;
            //to deisplay vendorData 


        }
        public void displayvendorData(string searchQuery = "") //to display vendor data in the DataGridView based on a search query


        {
            vendorData vd = new();
            List<vendorData> listData = vd.vendorListData(searchQuery);


            dataGridView1.DataSource = listData;
            dataGridView1.Refresh();
        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {



            // Checks if the clicked cell is within a valid row and corresponds to the "website" column
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["website"].Index)

            {
                //to get the value of the clicked cell
                object cellValue = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

                if (cellValue != null)
                {
                    // Convert the cell value to a string (assuming it contains a URL)
                    string urlString = cellValue.ToString();


                    // Check if the URL does not start with "http://" or "https://"
                    if (!urlString.StartsWith("http://") && !urlString.StartsWith("https://"))
                    {

                        // If not, prepend "http://" to the URL
                        urlString = "http://" + urlString;
                    }

                    // Open the website in an external browser
                    OpenWebsiteInExternalBrowser(urlString);
                }
            }

        }

        private void OpenWebsiteInExternalBrowser(string url)
        {
            try
            {
                //try to create a Uri from the provided URL

                if (Uri.TryCreate(url, UriKind.Absolute, out Uri uri))
                {
                    // If successful, create ProcessStartInfo to start the default browser
                    ProcessStartInfo psi = new ProcessStartInfo
                    {
                        FileName = uri.ToString(),
                        UseShellExecute = true
                    };

                    // Start the default browser with the specified URL
                    Process.Start(psi);
                }
                else
                {
                    //display error if URL works
                    MessageBox.Show("Invalid URL format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error opening website: " + ex.Message,
                    "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            // Get the trimmed search query from the search TextBox
            string searchQuery = search.Text.Trim();

            // Call the displayvendorData method with the specified search query
            displayvendorData(searchQuery);
        }

        private void search_btn_Click(object sender, EventArgs e)
        {

            // Get the trimmed search query from the search TextBox
            string searchQuery = search.Text.Trim();
            // Call the displayvendorData method with the specified search query            displayvendorData(searchQuery);
        }

        private void pdfBtn_Click(object sender, EventArgs e)
        {
            GeneratePDF(false);
        }

        private void selectPdfBtn_Click(object sender, EventArgs e)
        {
            GeneratePDF(true);
        }
        private void GeneratePDF(bool selectedRowsOnly)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.FileName = "output";
                saveFileDialog.DefaultExt = "pdf";
                saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*";

                DialogResult result = saveFileDialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;

                    try
                    {
                        using (var pdfWriter = new PdfWriter(filePath))
                        {
                            using (var pdf = new PdfDocument(pdfWriter))
                            {
                                var document = new Document(pdf);

                                // Set document properties
                                pdf.GetDocumentInfo().SetTitle("DataGridView to PDF");
                                document.SetMargins(20, 20, 20, 20);

                                // Add a title to the PDF
                                document.Add(new Paragraph("Citisoft Vendor and Product Information")
                                    .SetTextAlignment(TextAlignment.CENTER)
                                    .SetFontSize(16)
                                    .SetBold());

                                // Add a timestamp
                                document.Add(new Paragraph($"Generated on: {DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}")
                                    .SetTextAlignment(TextAlignment.RIGHT)
                                    .SetFontSize(10));

                                // Create a table for headers and content
                                Table dataTable = new Table(dataGridView1.Columns.Count, false);

                                // Add column headers to the table
                                foreach (DataGridViewColumn column in dataGridView1.Columns)
                                {
                                    dataTable.AddCell(new Cell().Add(new Paragraph(column.HeaderText).SetBold()));
                                }

                                // Add content from the DataGridView to the table
                                IEnumerable<DataGridViewRow> rowsToInclude = selectedRowsOnly
                                    ? dataGridView1.SelectedRows.Cast<DataGridViewRow>()
                                    : dataGridView1.Rows.Cast<DataGridViewRow>();

                                foreach (DataGridViewRow row in rowsToInclude)
                                {
                                    foreach (DataGridViewCell cell in row.Cells)
                                    {
                                        dataTable.AddCell(new Cell().Add(new Paragraph($"{cell.Value}")));
                                    }
                                }

                                // Add the table to the PDF
                                document.Add(dataTable);
                            }
                        }

                        MessageBox.Show($"PDF created successfully at: {filePath}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Get the selected cell data
                object cellValue = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                string selectedCellData = cellValue?.ToString();

                if (!string.IsNullOrEmpty(selectedCellData))
                {
                    // Open the CommentRatingForm with the selected cell data
                    CommentRatingForm commentRatingForm = new CommentRatingForm(selectedCellData);
                    commentRatingForm.ShowDialog();

                    // Update the DataGridView after saving comment and rating
                    displayvendorData();
                }
            }
        }

            private void button1_Click(object sender, EventArgs e)
        {

            // Check if any cell is selected
            if (dataGridView1.SelectedCells.Count > 0)
            {
                // Get the data from the selected cell
                string selectedCellData = dataGridView1.SelectedCells[0].Value.ToString();

                // Pass the selected cell data to CommentRatingForm constructor
                CommentRatingForm commentRatingForm = new CommentRatingForm(selectedCellData);
                commentRatingForm.ShowDialog();

                // Update the DataGridView after saving comment and rating
                displayvendorData();
            }
            else
            {
                MessageBox.Show("Please select a cell before adding a comment and rating.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }




        
    }
}
