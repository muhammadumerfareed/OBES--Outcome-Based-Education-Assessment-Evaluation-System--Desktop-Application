using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using MidDb26_2025CS60.BL;

namespace MidDb26_2025CS60.Forms
{
    public partial class AddStudent : Form
    {
        StudentBL bl = new StudentBL();

        public AddStudent()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            txtStatus.Text = "Active";
            txtStatus.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtStatus.AutoCompleteSource = AutoCompleteSource.CustomSource;
            var src = new AutoCompleteStringCollection();
            src.AddRange(new[] { "Active", "InActive" });
            txtStatus.AutoCompleteCustomSource = src;
            lblStatus.Text = "Status (Active / InActive)";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
         
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            { MessageBox.Show("First name is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            { MessageBox.Show("Email is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            string regNo = txtRegNo.Text.Trim();
            // Pattern: 20XX-CS-60 or 2025-MECH-123 etc.
            if (!Regex.IsMatch(regNo, @"^20\d{2}-[A-Z]{2,5}-\d{1,5}$"))
            {
                MessageBox.Show(
                    "Invalid registration number format.\n\nValid examples:\n  2025-CS-60\n  2024-SE-123\n  2023-MECH-5\n\nFormat: 20XX-DEPT-NUMBER",
                    "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int statusId = GetStatusId();

            try
            {
                string result = bl.Add(
                    txtFirstName.Text.Trim(),
                    txtLastName.Text.Trim(),
                    txtContact.Text.Trim(),
                    txtEmail.Text.Trim(),
                    regNo,
                    statusId
                );

                if (result == "success")
                {
                    MessageBox.Show("Student added successfully!", "Done",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                }
                else
                    MessageBox.Show(result, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int GetStatusId()
        {
            string s = txtStatus.Text.Trim().ToLower();
            return s == "inactive" ? 6 : 5;
        }

        private void ClearForm()
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtEmail.Text = "";
            txtContact.Text = "";
            txtRegNo.Text = "";
            txtStatus.Text = "Active";
        }
    }
}