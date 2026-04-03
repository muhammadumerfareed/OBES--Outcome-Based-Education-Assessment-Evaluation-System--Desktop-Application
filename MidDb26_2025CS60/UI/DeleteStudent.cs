using MidDb26_2025CS60.DL;
using MidDb26_2025CS60.BL;
using System;
using System.Data;
using System.Windows.Forms;

namespace MidDb26_2025CS60.Forms
{
    public partial class DeleteStudentForm : Form
    {
        StudentBL bl = new StudentBL();
        private int foundStudentId = -1;

        public DeleteStudentForm()
        {
            InitializeComponent();
        }

     
        private void btnFind_Click(object sender, EventArgs e)
        {
            string regNo = txtRegNo.Text.Trim();
            if (string.IsNullOrWhiteSpace(regNo) || regNo == "e.g. 20XX-YY-ZZ")
            {
                MessageBox.Show("Enter a registration number.", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DataTable dt = bl.GetAll();
            DataRow[] rows = dt.Select($"RegistrationNumber = '{regNo}'");

            if (rows.Length == 0)
            {
                MessageBox.Show("No student found.", "Not Found",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                pnlResult.Visible = false;
                btnDelete.Enabled = false;
                foundStudentId = -1;
                return;
            }

            DataRow row = rows[0];
            foundStudentId = Convert.ToInt32(row["Id"]);
            lblFoundName.Text = $"{row["FirstName"]} {row["LastName"]}";
            lblFoundDetails.Text = $"Email: {row["Email"]}  |  Reg: {row["RegistrationNumber"]}";
            pnlResult.Visible = true;
            btnDelete.Enabled = true;
        }

    
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (foundStudentId == -1) return;

            var confirm = MessageBox.Show(
                $"Delete {lblFoundName.Text}? This cannot be undone.",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                string result = bl.Delete(foundStudentId);
                if (result == "success")
                {
                    MessageBox.Show("Student deleted.", "Done",
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
}