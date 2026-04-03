using System;
using System.Data;
using System.Windows.Forms;
using MidDb26_2025CS60.BL;

namespace MidDb26_2025CS60.Forms
{
    public partial class Attendance : Form
    {
        StudentBL studentBL = new StudentBL();
        AttendanceBL attendanceBL = new AttendanceBL();

        public Attendance() { InitializeComponent(); }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            btnLoad.Click += btnLoad_Click;
            btnSave.Click += btnSave_Click;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            dgvAttendance.Rows.Clear();
            DataTable students = studentBL.GetAll();

          
            int existingSessionId = attendanceBL.GetSessionByDate(dtpClassDate.Value);
            DataTable existing = null;
            if (existingSessionId > 0)
                existing = attendanceBL.GetBySession(existingSessionId);

            foreach (DataRow row in students.Rows)
            {
                int i = dgvAttendance.Rows.Add();
                dgvAttendance.Rows[i].Cells["colRegNo"].Value = row["RegistrationNumber"].ToString();
                dgvAttendance.Rows[i].Cells["colName"].Value = $"{row["FirstName"]} {row["LastName"]}";
                dgvAttendance.Rows[i].Tag = Convert.ToInt32(row["Id"]);

                
                string status = "Present";
                if (existing != null)
                {
                    DataRow[] match = existing.Select($"StudentId = {row["Id"]}");
                    if (match.Length > 0)
                        status = match[0]["StatusName"].ToString();
                }
                dgvAttendance.Rows[i].Cells["colStatus"].Value = status;
            }

            if (existingSessionId > 0)
                MessageBox.Show("Attendance for this date was already saved. Loaded existing records — you can update and save again.",
                    "Existing Attendance Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dgvAttendance.Rows.Count == 0)
            { MessageBox.Show("Load students first.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }

            DataTable dt = new DataTable();
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("AttendanceStatus", typeof(int));

            foreach (DataGridViewRow row in dgvAttendance.Rows)
            {
                if (row.Tag == null) continue;
                int studentId = (int)row.Tag;
                string statusText = row.Cells["colStatus"].Value?.ToString() ?? "Present";
                int statusId;
                switch (statusText)
                {
                    case "Absent": statusId = 2; break;
                    case "Leave": statusId = 3; break;
                    case "Late": statusId = 4; break;
                    default: statusId = 1; break;
                }
                dt.Rows.Add(studentId, statusId);
            }

            string result = attendanceBL.SaveAttendance(dtpClassDate.Value, dt);
            if (result == "success")
            { MessageBox.Show("Attendance saved successfully!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            else
                MessageBox.Show(result, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}