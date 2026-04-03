using MidDb26_2025CS60.DL;
using MidDb26_2025CS60.BL;
using System;
using System.Data;
using System.Windows.Forms;

namespace MidDb26_2025CS60.Forms
{
    public partial class EditStudentForm : Form
    {
        StudentBL bl = new StudentBL();
        private int foundStudentId = -1;

        public EditStudentForm()
        {
            InitializeComponent();
        }

    
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string regNo = txtSearch.Text.Trim();
            if (string.IsNullOrWhiteSpace(regNo))
            {
                MessageBox.Show("Enter a registration number.", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DataTable dt = bl.GetAll();
            DataRow[] rows = dt.Select($"RegistrationNumber = '{regNo}'");

            if (rows.Length == 0)
            {
                MessageBox.Show("No student found with that reg no.", "Not Found",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                foundStudentId = -1;
                btnSave.Enabled = false;
                return;
            }

            DataRow row = rows[0];
            foundStudentId = Convert.ToInt32(row["Id"]);
            txtFirstName.Text = row["FirstName"].ToString();
            txtLastName.Text = row["LastName"].ToString();
            txtEmail.Text = row["Email"].ToString();
            txtFirstName.Enabled = true;
            txtLastName.Enabled = true;
            txtEmail.Enabled = true;
            btnSave.Enabled = true;
            btnSave.BackColor = System.Drawing.Color.MidnightBlue;
        }

      


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (foundStudentId == -1) return;

            DataTable dt = bl.GetAll();
            DataRow[] rows = dt.Select($"Id = {foundStudentId}");
            if (rows.Length == 0) return;

            string contact = rows[0]["Contact"].ToString();
            string regNo = rows[0]["RegistrationNumber"].ToString();
            int status = Convert.ToInt32(rows[0]["Status"]);

            string result = bl.Update(
                foundStudentId,
                txtFirstName.Text,
                txtLastName.Text,
                contact,
                txtEmail.Text,
                regNo,
                status
            );

            if (result == "success")
            {
                MessageBox.Show("Student updated!", "Done",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show(result, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}