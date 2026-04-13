using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using MidDb26_2025CS60.BL;

namespace MidDb26_2025CS60.Forms
{
    public partial class MarkEvaluation : Form
    {
        StudentBL studentBL = new StudentBL();
        AssessmentBL assessmentBL = new AssessmentBL();
        AssessmentComponentBL componentBL = new AssessmentComponentBL();
        RubricLevelBL levelBL = new RubricLevelBL();
        StudentResultBL resultBL = new StudentResultBL();
        private List<(int compId, int rubricId, int compMarks, ComboBox cboLevel, Label lblMarks)> compRows = new();

        public MarkEvaluation() { InitializeComponent(); }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            DataTable students = studentBL.GetForDropdown();
            cmbStudent.DataSource = students;
            cmbStudent.DisplayMember = "FullName";
            cmbStudent.ValueMember = "Id";

            DataTable assessments = assessmentBL.GetForDropdown();
            cmbAssessment.DataSource = assessments;
            cmbAssessment.DisplayMember = "Title";
            cmbAssessment.ValueMember = "Id";
            cmbAssessment.SelectedIndex = -1;
            cmbAssessment.SelectedIndexChanged += cmbAssessment_SelectedIndexChanged;
            btnSaveEvaluation.Click += btnSaveEvaluation_Click;
        }

        private void cmbAssessment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAssessment.SelectedValue == null) return;
            LoadComponentRows(Convert.ToInt32(cmbAssessment.SelectedValue));
        }

        private void LoadComponentRows(int assessmentId)
        {
            pnlComponentsBody.Controls.Clear(); compRows.Clear(); lblTotalValue.Text = "0 / —";
            DataTable components = componentBL.GetByAssessment(assessmentId);
            if (components.Rows.Count == 0)
            { pnlComponentsBody.Controls.Add(new Label { Text = "No components found. Add components in Manage Assessments first.", ForeColor = System.Drawing.Color.Gray, Location = new System.Drawing.Point(10, 10), AutoSize = true }); return; }

            int y = 10;
            foreach (DataRow row in components.Rows)
            {
                int compId = Convert.ToInt32(row["Id"]), rubricId = Convert.ToInt32(row["RubricId"]), compMarks = Convert.ToInt32(row["TotalMarks"]);
                Panel compRow = new Panel { Location = new System.Drawing.Point(5, y), Size = new System.Drawing.Size(835, 45), BackColor = System.Drawing.Color.White };
                Label lComp = new Label { Text = row["Name"].ToString(), Location = new System.Drawing.Point(10, 12), Size = new System.Drawing.Size(180, 25) };
                string rd = row["RubricDetails"].ToString();
                Label lRubric = new Label { Text = rd.Length > 20 ? rd.Substring(0, 20) + "..." : rd, Location = new System.Drawing.Point(300, 12), Size = new System.Drawing.Size(180, 25), ForeColor = System.Drawing.Color.DimGray };
                int maxLevel = levelBL.GetMaxLevel(rubricId);
                Label lMax = new Label { Text = $"Max:{maxLevel}", Location = new System.Drawing.Point(500, 12), Size = new System.Drawing.Size(70, 25) };
                ComboBox cboLevel = new ComboBox { Location = new System.Drawing.Point(600, 10), Size = new System.Drawing.Size(220, 28), DropDownStyle = ComboBoxStyle.DropDownList };
                DataTable levels = levelBL.GetByRubric(rubricId).Copy();
                cboLevel.DataSource = levels; cboLevel.DisplayMember = "Details"; cboLevel.ValueMember = "Id";
                cboLevel.DataSource = levels;
                cboLevel.SelectedIndex = -1;
                Label lMarks = new Label { Text = "—", Location = new System.Drawing.Point(0, 12), Size = new System.Drawing.Size(70, 25), ForeColor = System.Drawing.Color.FromArgb(30, 50, 90) };
                int capMax = maxLevel, capMarks = compMarks;
                cboLevel.SelectedIndexChanged += (s, ev) => {
                    if (cboLevel.SelectedItem == null) return;
                    DataRowView drv = (DataRowView)cboLevel.SelectedItem;
                    lMarks.Text = resultBL.CalculateMarks(Convert.ToInt32(drv["MeasurementLevel"]), capMax, capMarks).ToString("0.##");
                    UpdateTotal();
                };
                compRow.Controls.AddRange(new System.Windows.Forms.Control[] { lComp, lRubric, lMax, cboLevel, lMarks });
                pnlComponentsBody.Controls.Add(compRow);
                compRows.Add((compId, rubricId, compMarks, cboLevel, lMarks));
                y += 50;
            }
        }

        private void UpdateTotal()
        {
            double total = 0; int max = 0;
            foreach (var (_, _, cm, _, lm) in compRows) { if (double.TryParse(lm.Text, out double m)) total += m; max += cm; }
            lblTotalValue.Text = $"{total:0.##} / {max}";
        }

        private void btnSaveEvaluation_Click(object sender, EventArgs e)
        {
            if (cmbStudent.SelectedValue == null) { MessageBox.Show("Select a student.", "Validation"); return; }
            if (compRows.Count == 0) { MessageBox.Show("Select an assessment with components first.", "Validation"); return; }
            int studentId = Convert.ToInt32(cmbStudent.SelectedValue);
            foreach (var (compId, _, _, cboLevel, _) in compRows)
            {
                if (cboLevel.SelectedValue == null) { MessageBox.Show("Assign a level to every component before saving.", "Validation"); return; }
                string res = resultBL.Save(studentId, compId, Convert.ToInt32(cboLevel.SelectedValue));
                if (res != "success") { MessageBox.Show(res, "Error"); return; }
            }
            MessageBox.Show("Evaluation saved successfully!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}