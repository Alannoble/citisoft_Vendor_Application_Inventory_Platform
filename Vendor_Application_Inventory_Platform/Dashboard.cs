using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Vendor_Application_Inventory_Platform
{
    public partial class Dashboard : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn

            (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
            );


        public Dashboard()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNav.Width = homeBtn.Width;
            pnlNav.Left = homeBtn.Left;
            homeBtn.BackColor = Color.FromArgb(250, 250, 250);

            this.pnlFormLoader.Controls.Clear();
            frmDashboard frmDashboard_Vrb = new frmDashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = false };
            frmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmDashboard_Vrb);
            frmDashboard_Vrb.Show();
        }

        //
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.pnlFormLoader.Controls.Clear();
            frmProfilePrev frmProfilePrev_Vrb = new frmProfilePrev() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmProfilePrev_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmProfilePrev_Vrb);
            frmProfilePrev_Vrb.Show();
        }

        //
        private void contactBtn_Click(object sender, EventArgs e)
        {
            pnlNav.Width = contactBtn.Width;
            pnlNav.Left = contactBtn.Left;
            contactBtn.BackColor = Color.FromArgb(170, 170, 170);

            this.pnlFormLoader.Controls.Clear();
            frmContact frmContact_Vrb = new frmContact() { Dock = DockStyle.Fill, TopLevel = false, TopMost = false };
            frmContact_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmContact_Vrb);
            frmContact_Vrb.Show();
        }

        //
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }


        //
        private void homeBtn_Click_1(object sender, EventArgs e)
        {
            pnlNav.Width = homeBtn.Width;
            pnlNav.Left = homeBtn.Left;
            homeBtn.BackColor = Color.FromArgb(170, 170, 170);

            this.pnlFormLoader.Controls.Clear();
            frmDashboard frmDashboard_Vrb = new frmDashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = false };
            frmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmDashboard_Vrb);
            frmDashboard_Vrb.Show();
        }

        //
        private void vendorBtn_Click(object sender, EventArgs e)
        {
            pnlNav.Width = vendorBtn.Width;
            pnlNav.Left = vendorBtn.Left;
            vendorBtn.BackColor = Color.FromArgb(170, 170, 170);

            this.pnlFormLoader.Controls.Clear();
            frmVendors frmVendors_Vrb = new frmVendors() { Dock = DockStyle.Fill, TopLevel = false, TopMost = false };
            frmVendors_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmVendors_Vrb);
            frmVendors_Vrb.Show();
        }

        //
        private void homeBtn_Leave_1(object sender, EventArgs e)
        {
            homeBtn.BackColor = Color.FromArgb(255, 255, 255);
        }

        //
        private void vendorBtn_Leave(object sender, EventArgs e)
        {
            vendorBtn.BackColor = Color.FromArgb(255, 255, 255);
        }

        //
        private void contactBtn_Leave(object sender, EventArgs e)
        {
            contactBtn.BackColor = Color.FromArgb(255, 255, 255);
        }






        //
        private void pnlFormLoader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void searchBtn_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

    }
}

