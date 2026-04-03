using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using MidDb26_2025CS60.BL;
using MidDb26_2025CS60.DL;

namespace MidDb26_2025CS60.Forms
{
    public partial class ManageRubrics : Form
    {
        CloBL cloBL = new CloBL();
        RubricBL rubricBL = new RubricBL();
        RubricLevelBL levelBL = new RubricLevelBL();
        private int selectedCloId = -1;
        private List<(int rubricId, TextBox txtId, TextBox txtDetails)> rubricRows = new();

        public ManageRubrics() { InitializeComponent(); }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            LoadCloDropdown();
            btnLoadCLO.Click += btnLoadCLO_Click;
            btnSave.Click += btnSave_Click;
            lnkAddRubric.LinkClicked += (s, ev) => AddRubricRow(0, "", "");
        }

        private void LoadCloDropdown()
        {
            DataTable dt = cloBL.GetAll();
            cboCLO.Items.Clear(); cboCLO.Items.Add("-- Select CLO --"); cboCLO.SelectedIndex = 0;
            foreach (DataRow row in dt.Rows)
                cboCLO.Items.Add(new { Id = Convert.ToInt32(row["Id"]), Name = row["Name"].ToString() });
            cboCLO.DisplayMember = "Name";
        }

        private void btnLoadCLO_Click(object sender, EventArgs e)
        {
            if (cboCLO.SelectedIndex <= 0) { MessageBox.Show("Select a CLO first.", "Info"); return; }
            dynamic sel = cboCLO.SelectedItem;
            selectedCloId = sel.Id;
            LoadRubricRows(selectedCloId);
            lnkAddRubric.Visible = true;
        }

        private void LoadRubricRows(int cloId)
        {
            pnlRubrics.Controls.Clear(); rubricRows.Clear();
            DataTable dt = rubricBL.GetByClo(cloId);
            foreach (DataRow row in dt.Rows)
                AddRubricRow(Convert.ToInt32(row["Id"]), row["Id"].ToString(), row["Details"].ToString());
        }

        private void AddRubricRow(int rubricId, string idText, string detailsText)
        {
            Panel row = new Panel { Size = new System.Drawing.Size(710, 40), BackColor = System.Drawing.Color.White, Margin = new Padding(0, 2, 0, 2) };
            Label lblId = new Label { Text = "ID:", Location = new System.Drawing.Point(5, 12), Size = new System.Drawing.Size(25, 20) };
            TextBox txtId = new TextBox { Text = idText, Location = new System.Drawing.Point(30, 8), Size = new System.Drawing.Size(55, 28), Enabled = rubricId == 0 };
            TextBox txtDetails = new TextBox { Text = detailsText, Location = new System.Drawing.Point(90, 8), Size = new System.Drawing.Size(390, 28), PlaceholderText = "Rubric criteria..." };


            Button btnLevels = new Button { Text = "Levels", Location = new System.Drawing.Point(490, 7), Size = new System.Drawing.Size(80, 28), BackColor = System.Drawing.Color.MidnightBlue, ForeColor = System.Drawing.Color.White, FlatStyle = FlatStyle.Flat, Tag = rubricId };
            btnLevels.Click += (s, e) =>
            {
                int rid = (int)((Button)s).Tag;
                if (rid == 0) { MessageBox.Show("Save the rubric first before adding levels.", "Info"); return; }
                ShowLevelsPopup(rid, txtDetails.Text);
            };

            Button btnDel = new Button { Text = "Del", Location = new System.Drawing.Point(580, 7), Size = new System.Drawing.Size(50, 28), BackColor = System.Drawing.Color.Brown, ForeColor = System.Drawing.Color.White, FlatStyle = FlatStyle.Flat, Tag = rubricId };
            btnDel.Click += (s, e) =>
            {
                int rid = (int)((Button)s).Tag;
                if (rid == 0) { pnlRubrics.Controls.Remove(row); return; }
                if (MessageBox.Show("Delete this rubric and its levels?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                { string res = rubricBL.Delete(rid); if (res == "success") LoadRubricRows(selectedCloId); else MessageBox.Show(res, "Error"); }
            };

            row.Controls.AddRange(new System.Windows.Forms.Control[] { lblId, txtId, txtDetails, btnLevels, btnDel });
            pnlRubrics.Controls.Add(row);
            rubricRows.Add((rubricId, txtId, txtDetails));
        }


        private void ShowLevelsPopup(int rubricId, string rubricName)
        {
            Form popup = new Form { Text = $"Levels for: {rubricName}", Size = new System.Drawing.Size(600, 400), StartPosition = FormStartPosition.CenterParent, BackColor = System.Drawing.Color.FromArgb(240, 238, 232) };
            Label lbl = new Label { Text = $"Rubric Levels (ID {rubricId}) — Level 1=Unsatisfactory, 2=Fair, 3=Good, 4=Exceptional", Location = new System.Drawing.Point(10, 10), Size = new System.Drawing.Size(570, 30), ForeColor = System.Drawing.Color.DimGray };
            Panel pnlLevels = new Panel { Location = new System.Drawing.Point(10, 45), Size = new System.Drawing.Size(570, 270), AutoScroll = true, BackColor = System.Drawing.Color.White };
            Button btnAddLevel = new Button { Text = "+ Add Level", Location = new System.Drawing.Point(10, 325), Size = new System.Drawing.Size(100, 30), BackColor = System.Drawing.Color.MidnightBlue, ForeColor = System.Drawing.Color.White, FlatStyle = FlatStyle.Flat };
            Button btnSaveLevels = new Button { Text = "Save Levels", Location = new System.Drawing.Point(470, 325), Size = new System.Drawing.Size(110, 30), BackColor = System.Drawing.Color.MidnightBlue, ForeColor = System.Drawing.Color.White, FlatStyle = FlatStyle.Flat };

            List<(int levelId, TextBox txtDet, NumericUpDown nudLevel)> levelRows = new();


            void LoadLevelsData()
            {
                pnlLevels.Controls.Clear();
                levelRows.Clear();
                DataTable dt = levelBL.GetByRubric(rubricId);
                int y = 5;
                foreach (DataRow r in dt.Rows)
                {
                    int lid = Convert.ToInt32(r["Id"]);
                    Panel lr = new Panel { Location = new System.Drawing.Point(0, y), Size = new System.Drawing.Size(565, 38), BackColor = System.Drawing.Color.White };
                    Label lLvl = new Label { Text = "Level:", Location = new System.Drawing.Point(5, 10), Size = new System.Drawing.Size(44, 20) };
                    NumericUpDown nud = new NumericUpDown { Minimum = 1, Maximum = 4, Value = Convert.ToInt32(r["MeasurementLevel"]), Location = new System.Drawing.Point(50, 7), Size = new System.Drawing.Size(55, 26) };
                    TextBox td = new TextBox { Text = r["Details"].ToString(), Location = new System.Drawing.Point(115, 7), Size = new System.Drawing.Size(360, 26) };
                    Button bd = new Button { Text = "X", Location = new System.Drawing.Point(485, 7), Size = new System.Drawing.Size(35, 26), BackColor = System.Drawing.Color.Brown, ForeColor = System.Drawing.Color.White, FlatStyle = FlatStyle.Flat, Tag = lid };

                    bd.Click += (s, e2) =>
                    {
                        if (MessageBox.Show("Delete level?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            levelBL.Delete(lid);
                            LoadLevelsData(); // Refresh after delete
                        }
                    };

                    lr.Controls.AddRange(new Control[] { lLvl, nud, td, bd });
                    pnlLevels.Controls.Add(lr);
                    levelRows.Add((lid, td, nud));
                    y += 42;
                }
            }



            btnAddLevel.Click += (s, e2) =>
            {
                int y = pnlLevels.Controls.Count * 42 + 5;
                Panel lr = new Panel { Location = new System.Drawing.Point(0, y), Size = new System.Drawing.Size(565, 38), BackColor = System.Drawing.Color.White };
                Label lLvl = new Label { Text = "Level:", Location = new System.Drawing.Point(5, 10), Size = new System.Drawing.Size(44, 20) };
                NumericUpDown nud = new NumericUpDown { Minimum = 1, Maximum = 4, Value = 1, Location = new System.Drawing.Point(50, 7), Size = new System.Drawing.Size(55, 26) };
                TextBox td = new TextBox { PlaceholderText = "Level description...", Location = new System.Drawing.Point(115, 7), Size = new System.Drawing.Size(360, 26) };
                lr.Controls.AddRange(new Control[] { lLvl, nud, td });
                pnlLevels.Controls.Add(lr);
                levelRows.Add((0, td, nud));
            };

            btnSaveLevels.Click += (s, e2) =>
            {
                foreach (var (lid, td, nud) in levelRows)
                {
                    string det = td.Text.Trim();
                    if (string.IsNullOrWhiteSpace(det)) continue;
                    int lvl = (int)nud.Value;
                    string res = lid == 0 ? levelBL.Add(rubricId, det, lvl) : levelBL.Update(lid, det, lvl);
                    if (res != "success") { MessageBox.Show(res, "Error"); return; }
                }
                MessageBox.Show("Levels saved!", "Done");
                LoadLevelsData(); // Refresh after save
            };

            popup.Controls.AddRange(new Control[] { lbl, pnlLevels, btnAddLevel, btnSaveLevels });
            popup.ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (selectedCloId == -1) { MessageBox.Show("Load a CLO first.", "Info"); return; }
            foreach (var (rubricId, txtId, txtDetails) in rubricRows)
            {
                string details = txtDetails.Text.Trim();
                if (string.IsNullOrWhiteSpace(details)) continue;
                string result = rubricId == 0
                    ? (int.TryParse(txtId.Text.Trim(), out int nId) && nId > 0 ? rubricBL.Add(nId, details, selectedCloId) : "Enter a valid numeric ID.")
                    : rubricBL.Update(rubricId, details, selectedCloId);
                if (result != "success") { MessageBox.Show(result, "Error"); return; }
            }
            MessageBox.Show("Rubrics saved!", "Done"); LoadRubricRows(selectedCloId);
        }

       
    }
}