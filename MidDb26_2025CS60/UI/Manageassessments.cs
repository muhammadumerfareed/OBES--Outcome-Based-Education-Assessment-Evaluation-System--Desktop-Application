using System;
using System.Data;
using System.Windows.Forms;
using MidDb26_2025CS60.BL;

namespace MidDb26_2025CS60.Forms
{
    public partial class Manageassessments : Form
    {
        AssessmentBL bl = new AssessmentBL();
        private int selectedId = -1;

        public Manageassessments() { InitializeComponent(); }

        protected override void OnLoad(EventArgs e) { base.OnLoad(e); LoadGrid(); dgvAssessments.CellClick += dgvAssessments_CellClick; }

        private void LoadGrid() => dgvAssessments.DataSource = bl.GetAll();

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAssessmentTitle.Text))
            { MessageBox.Show("Assessment title is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            if (!int.TryParse(txtTotalMarks.Text, out int marks) || marks <= 0)
            { MessageBox.Show("Enter valid total marks (must be > 0).", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            if (!int.TryParse(txtWeightage.Text, out int weightage) || weightage <= 0)
            { MessageBox.Show("Enter valid weightage % (must be > 0).", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            string result;
            int assessmentIdToEdit;

            if (selectedId == -1)
            {
                result = bl.Add(txtAssessmentTitle.Text.Trim(), marks, weightage);
                if (result != "success") { MessageBox.Show(result, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                MessageBox.Show("Assessment added!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataTable dt = bl.GetAll();
                assessmentIdToEdit = Convert.ToInt32(dt.Rows[dt.Rows.Count - 1]["Id"]);
            }
            else
            {
                result = bl.Update(selectedId, txtAssessmentTitle.Text.Trim(), marks, weightage);
                if (result != "success") { MessageBox.Show(result, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                MessageBox.Show("Assessment updated!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                assessmentIdToEdit = selectedId;
            }

            
            new AddQuestions(assessmentIdToEdit, txtAssessmentTitle.Text.Trim(), marks).ShowDialog();

            ClearForm(); 
            LoadGrid();
        }

        private void dgvAssessments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow row = dgvAssessments.Rows[e.RowIndex];
            selectedId = Convert.ToInt32(row.Cells["Id"].Value);
            txtAssessmentTitle.Text = row.Cells["Title"].Value?.ToString();
            txtTotalMarks.Text = row.Cells["TotalMarks"].Value?.ToString();
            txtWeightage.Text = row.Cells["TotalWeightage"].Value?.ToString();
            btnSave.Text = "Update Assessment";
        }

        private void ClearForm()
        { txtAssessmentTitle.Text = ""; txtTotalMarks.Text = ""; txtWeightage.Text = ""; selectedId = -1; btnSave.Text = "Save Assessment"; }
    }
}