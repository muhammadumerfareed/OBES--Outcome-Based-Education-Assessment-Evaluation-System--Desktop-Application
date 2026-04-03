using System;
using System.Data;
using System.IO;
using System.Text;
using System.Windows.Forms;
using MidDb26_2025CS60.BL;

namespace MidDb26_2025CS60.Forms
{
    public partial class Reports : Form
    {
        AssessmentBL assessmentBL = new AssessmentBL();
        StudentResultBL resultBL = new StudentResultBL();
        CloBL cloBL = new CloBL();

        public Reports() { InitializeComponent(); }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            cmbReportType.Items.Add("Assessment Wise Class Result");
            cmbReportType.Items.Add("CLO Wise Class Result");
            cmbReportType.SelectedIndex = 0;
            LoadAssessmentDropdown();
            cmbReportType.SelectedIndexChanged += cmbReportType_SelectedIndexChanged;
            btnGenerate.Click += btnGenerate_Click;
        }

        private void LoadAssessmentDropdown()
        {
            DataTable dt = assessmentBL.GetForDropdown();
            cmbAssessment.DataSource = dt;
            cmbAssessment.DisplayMember = "Title";
            cmbAssessment.ValueMember = "Id";
        }

        private void cmbReportType_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool needsAssessment = cmbReportType.SelectedIndex == 0;
            lblAssessment.Visible = needsAssessment;
            cmbAssessment.Visible = needsAssessment;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            int reportType = cmbReportType.SelectedIndex;
            DataTable data = null;
            string reportTitle = "";

            if (reportType == 0)
            {
                if (cmbAssessment.SelectedValue == null) { MessageBox.Show("Select an assessment.", "Error"); return; }
                int assessmentId = Convert.ToInt32(cmbAssessment.SelectedValue);
                data = resultBL.GetByAssessment(assessmentId);
                reportTitle = $"Assessment Result — {cmbAssessment.Text}";
            }
            else if (reportType == 1)
            {
                DataTable clos = cloBL.GetAll();
                if (clos.Rows.Count == 0) { MessageBox.Show("No CLOs found.", "Info"); return; }
                data = resultBL.GetByClo(Convert.ToInt32(clos.Rows[0]["Id"]));
                reportTitle = "CLO Wise Class Result";
            }
            else
            { MessageBox.Show("Attendance report coming soon!", "Info"); return; }

            if (data == null || data.Rows.Count == 0) { MessageBox.Show("No data found for this report.", "Info"); return; }
            GenerateHtmlReport(data, reportTitle);
        }

        private void GenerateHtmlReport(DataTable data, string title)
        {
            StringBuilder html = new StringBuilder();
            html.AppendLine("<!DOCTYPE html><html><head>");
            html.AppendLine($"<title>{title}</title>");
            html.AppendLine("<style>body{font-family:Segoe UI,Arial;margin:40px}h1{color:#1e3266}table{border-collapse:collapse;width:100%;margin-top:20px}th{background:#1e3266;color:white;padding:10px;text-align:left}td{padding:8px 10px;border-bottom:1px solid #ddd}tr:nth-child(even){background:#f0ede8}</style></head><body>");
            html.AppendLine($"<h1>{title}</h1>");
            html.AppendLine($"<p>Generated: {DateTime.Now:dd MMM yyyy, hh:mm tt} | CS104 Database Systems</p>");
            html.AppendLine("<table><tr>");
            foreach (DataColumn col in data.Columns)
                html.AppendLine($"<th>{col.ColumnName}</th>");
            html.AppendLine("</tr>");
            foreach (DataRow row in data.Rows)
            {
                html.AppendLine("<tr>");
                foreach (var val in row.ItemArray) html.AppendLine($"<td>{val}</td>");
                html.AppendLine("</tr>");
            }
            html.AppendLine("</table></body></html>");
            string path = Path.Combine(Path.GetTempPath(), "report.html");
            File.WriteAllText(path, html.ToString());
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo { FileName = path, UseShellExecute = true });
            MessageBox.Show("Report opened in browser!\n\nTo save as PDF: Press Ctrl+P → Save as PDF",
                "Report Generated", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}