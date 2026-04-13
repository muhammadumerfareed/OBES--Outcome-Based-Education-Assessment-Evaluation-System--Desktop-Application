using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
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
            this.assessmentId = assessmentId; this.totalMarks = totalMarks;
            lblAssessmentName.Text = $"Assessment: {assessmentTitle}";
            UpdateMarksLabel(0);
        }

        private void ReNumberRows()
        {
            int i = 1;
            foreach (Control row in pnlQuestionsBody.Controls)
            {
                foreach (Control c in row.Controls)
                {
                    if (c is Label lbl && lbl.Text.All(char.IsDigit))
                    {
                        lbl.Text = i.ToString();
                        break;
                    }
                }
                i++;
            }
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
            Panel row = new Panel
            {
                Height = 45,
                Dock = DockStyle.Top,
                BackColor = Color.White,
                Padding = new Padding(0),
                Margin = new Padding(0, 0, 0, 2)
            };

            Label lNum = new Label
            {
                Text = (questionRows.Count + 1).ToString(),
                Location = new Point(8, 12),
                Size = new Size(25, 25)
            };

            TextBox txtName = new TextBox
            {
                Text = name,
                Location = new Point(38, 10),
                Size = new Size(230, 25),
                PlaceholderText = "e.g. Question "
            };

            ComboBox cboRubric = new ComboBox
            {
                Location = new Point(350, 10),
                Size = new Size(300, 25),
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            DataTable rubrics = rubricBL.GetForDropdown().Copy();
            cboRubric.DataSource = rubrics;
            cboRubric.DisplayMember = "Details";
            cboRubric.ValueMember = "Id";
            if (rubricId > 0)
            {
                foreach (DataRowView drv in cboRubric.Items)
                {
                    if (Convert.ToInt32(drv["Id"]) == rubricId)
                    { cboRubric.SelectedItem = drv; break; }
                }
            }

           
            TextBox txtMarks = new TextBox
            {
                Text = marks > 0 ? marks.ToString() : "",
                Location = new Point(700, 12),
                Size = new Size(80, 25)
            };
            txtMarks.TextChanged += (s, e) => UpdateMarksCounter();

          
            Button btnDel = new Button
            {
                Text = "✕",
                Location = new Point(850, 12), 
                Size = new Size(50, 35),
                BackColor = Color.FromArgb(160, 30, 30),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Tag = compId
            };
            btnDel.FlatAppearance.BorderSize = 0;
            btnDel.Click += (s, e) =>
            {
                if (compId > 0) componentBL.Delete(compId);
                pnlQuestionsBody.Controls.Remove(row);
                questionRows.Remove((txtName, cboRubric, txtMarks, compId));
                UpdateMarksCounter();
                ReNumberRows();
            };

            row.Controls.AddRange(new Control[] { lNum, txtName, cboRubric, txtMarks, btnDel });
            pnlQuestionsBody.Controls.Add(row);
            pnlQuestionsBody.Controls.SetChildIndex(row, 0);
            questionRows.Add((txtName, cboRubric, txtMarks, compId));
            UpdateMarksCounter();
        }

        private void UpdateMarksCounter()
        {
            int used = 0;
            foreach (var (_, _, txtMarks, _) in questionRows)
            {
                if (int.TryParse(txtMarks.Text, out int m))
                    used += m;
            }
            marksUsed = used;
            UpdateMarksLabel(used);
        }

        private void UpdateMarksLabel(int used)
        {
            lblMarksInfo.Text = $"Total: {totalMarks} | Used: {used} | Remaining: {totalMarks - used}";
            lblMarksUsedValue.Text = $"{used} / {totalMarks}";
            lblMarksInfo.ForeColor = (used > totalMarks) ? Color.Red : Color.FromArgb(30, 50, 90);
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