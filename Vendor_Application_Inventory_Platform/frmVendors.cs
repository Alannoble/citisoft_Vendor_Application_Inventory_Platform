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
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\alanj\Source\Repos\Alannoble\citisoft_Vendor_Application_Inventory_Platform\Vendor_Application_Inventory_Platform\batmon.mdf;Integrated Security=True");

        public frmVendors()
        {
            InitializeComponent();
            displayvendorData();

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


        }
        public void displayvendorData(string searchQuery = "")
        {
            vendorData vd = new();
            List<vendorData> listData = vd.vendorListData(searchQuery);


            dataGridView1.DataSource = listData;
            dataGridView1.Refresh();
        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {




            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["website"].Index)
            {
                object cellValue = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

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

        private void search_TextChanged(object sender, EventArgs e)
        {
            string searchQuery = search.Text.Trim();
            displayvendorData(searchQuery);
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            string searchQuery = search.Text.Trim();
            displayvendorData(searchQuery);
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
    }
}
