using MidDb26_2025CS60.BL;
using MidDb26_2025CS60.DL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MidDb26_2025CS60.Forms
{
    public partial class SearchStudent : Form
    {
        StudentBL bl = new StudentBL();

        public SearchStudent()
        {
            InitializeComponent();
        }

        // Runs when Search button is clicked
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string regNo = txtRegNo.Text.Trim();
            if (string.IsNullOrWhiteSpace(regNo) || regNo == "Enter Reg No...")
            {
                MessageBox.Show("Enter a registration number.", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DataTable dt = bl.GetAll();
            DataRow[] rows = dt.Select($"RegistrationNumber = '{regNo}'");

            lvResult.Items.Clear();
            lvResult.Visible = true;

            if (rows.Length == 0)
            {
                lvResult.Items.Add(new ListViewItem(new[] { "Result", "No student found." }));
                return;
            }

            DataRow row = rows[0];
            lvResult.Items.Add(new ListViewItem(new[] { "First Name", row["FirstName"].ToString() }));
            lvResult.Items.Add(new ListViewItem(new[] { "Last Name", row["LastName"].ToString() }));
            lvResult.Items.Add(new ListViewItem(new[] { "Email", row["Email"].ToString() }));
            lvResult.Items.Add(new ListViewItem(new[] { "Contact", row["Contact"].ToString() }));
            lvResult.Items.Add(new ListViewItem(new[] { "Reg No", row["RegistrationNumber"].ToString() }));
        }
        private void lvResult_SelectedIndexChanged(object sender, EventArgs e) { }
    }
}