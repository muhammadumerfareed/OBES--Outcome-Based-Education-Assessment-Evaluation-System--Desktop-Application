using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using MidDb26_2025CS60.BL;

namespace MidDb26_2025CS60.Forms
{
    public partial class AddQuestions : Form
    {
        AssessmentComponentBL componentBL = new AssessmentComponentBL();
        RubricBL rubricBL = new RubricBL();
        private int assessmentId, totalMarks, marksUsed;
        private List<(TextBox txtName, ComboBox cboRubric, TextBox txtMarks, int compId)> questionRows = new();

        public AddQuestions(int assessmentId, string assessmentTitle, int totalMarks)
        {
            InitializeComponent();
            lnkAddQuestion.LinkClicked += (s, ev) => AddQuestionRow(0, "", 0, 0);
            this.assessmentId = assessmentId; this.totalMarks = totalMarks;
            lblAssessmentName.Text = $"Assessment: {assessmentTitle}";
            lnkAddQuestion.LinkClicked += new LinkLabelLinkClickedEventHandler(lnkAddQuestion_LinkClicked);
            UpdateMarksLabel(0);

        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            DataTable existing = componentBL.GetByAssessment(assessmentId);
            foreach (DataRow row in existing.Rows)
                AddQuestionRow(Convert.ToInt32(row["Id"]), row["Name"].ToString(),
                    Convert.ToInt32(row["RubricId"]), Convert.ToInt32(row["TotalMarks"]));

            btnSaveQuestions.Click += btnSaveQuestions_Click;
            btnSkip.Click += (s, ev) => this.Close();
        }

        private void AddQuestionRow(int compId, string name, int rubricId, int marks)
        {
            Panel row = new Panel { Size = new System.Drawing.Size(840, 45), BackColor = System.Drawing.Color.White, Margin = new Padding(2) };
            Label lNum = new Label { Text = (questionRows.Count + 1).ToString(), Location = new System.Drawing.Point(5, 12), Size = new System.Drawing.Size(30, 25) };
            TextBox txtName = new TextBox { Text = name, Location = new System.Drawing.Point(40, 10), Size = new System.Drawing.Size(260, 28), PlaceholderText = "e.g. Question 1" };
            ComboBox cboRubric = new ComboBox { Location = new System.Drawing.Point(310, 10), Size = new System.Drawing.Size(280, 28), DropDownStyle = ComboBoxStyle.DropDownList };
            DataTable rubrics = rubricBL.GetForDropdown();
            cboRubric.DataSource = rubrics; cboRubric.DisplayMember = "Details"; cboRubric.ValueMember = "Id";
            if (rubricId > 0) cboRubric.SelectedValue = rubricId;
            TextBox txtMarks = new TextBox { Text = marks > 0 ? marks.ToString() : "", Location = new System.Drawing.Point(600, 10), Size = new System.Drawing.Size(80, 28), PlaceholderText = "Marks" };
            txtMarks.TextChanged += (s, e) => UpdateMarksCounter();
            Button btnDel = new Button { Text = "X", Location = new System.Drawing.Point(690, 10), Size = new System.Drawing.Size(40, 28), BackColor = System.Drawing.Color.Brown, ForeColor = System.Drawing.Color.White, FlatStyle = FlatStyle.Flat };
            btnDel.Click += (s, e) =>
            {
                if (compId > 0) componentBL.Delete(compId);
                pnlQuestionsBody.Controls.Remove(row); questionRows.Remove((txtName, cboRubric, txtMarks, compId)); UpdateMarksCounter();
            };
            row.Controls.AddRange(new System.Windows.Forms.Control[] { lNum, txtName, cboRubric, txtMarks, btnDel });
            pnlQuestionsBody.Controls.Add(row);
            questionRows.Add((txtName, cboRubric, txtMarks, compId));
            UpdateMarksCounter();
            pnlQuestionsBody.Controls.Add(row);
            pnlQuestionsBody.Tag = "Updated";
            row.BringToFront(); 
        }

        private void UpdateMarksCounter()
        {
            int used = 0;
            foreach (var (_, _, txtMarks, _) in questionRows)
                if (int.TryParse(txtMarks.Text, out int m)) used += m;
            marksUsed = used;
            UpdateMarksLabel(used);
        }

        private void UpdateMarksLabel(int used)
        {
            lblMarksInfo.Text = $"Total: {totalMarks} | Used: {used} | Remaining: {totalMarks - used}";
            lblMarksUsedValue.Text = $"{used} / {totalMarks}";
            lblMarksInfo.ForeColor = (used > totalMarks) ? System.Drawing.Color.Red : System.Drawing.Color.FromArgb(30, 50, 90);
        }

        private void btnSaveQuestions_Click(object sender, EventArgs e)
        {
            if (questionRows.Count == 0) { MessageBox.Show("Add at least one question/component.", "Validation"); return; }
            if (marksUsed != totalMarks)
            {
                var go = MessageBox.Show($"Warning: Marks used ({marksUsed}) do not equal total marks ({totalMarks}).\n\nSave anyway?",
                    "Marks Mismatch", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (go != DialogResult.Yes) return;
            }
            foreach (var (txtName, cboRubric, txtMarks, compId) in questionRows)
            {
                string nm = txtName.Text.Trim();
                if (string.IsNullOrWhiteSpace(nm)) continue;
                if (cboRubric.SelectedValue == null) { MessageBox.Show("Select a rubric for each component.", "Error"); return; }
                if (!int.TryParse(txtMarks.Text, out int m) || m <= 0) { MessageBox.Show("Enter valid marks > 0.", "Error"); return; }
                int rId = Convert.ToInt32(cboRubric.SelectedValue);
                string res = compId == 0 ? componentBL.Add(nm, rId, m, assessmentId) : componentBL.Update(compId, nm, rId, m);
                if (res != "success") { MessageBox.Show(res, "Error"); return; }
            }
            MessageBox.Show("Components saved successfully!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void lnkAddQuestion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddQuestionRow(0, "", -1, 0);
        }
    }
}