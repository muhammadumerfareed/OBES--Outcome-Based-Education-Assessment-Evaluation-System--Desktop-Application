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
            Panel row = new Panel
            {
                Height = 40,
                Width = pnlRubrics.Width - 20,
                BackColor = System.Drawing.Color.White,
                Margin = new Padding(0, 2, 0, 2)
            };

            TableLayoutPanel tlp = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 5,
                RowCount = 1,
                AutoSize = true
            };
            tlp.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));  
            tlp.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));  
            tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60f)); 
            tlp.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            tlp.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize)); 

            Label lblId = new Label { Text = "ID:", TextAlign = ContentAlignment.MiddleLeft, Dock = DockStyle.Fill };
            TextBox txtId = new TextBox { Text = idText, Width = 50, Enabled = rubricId == 0, Dock = DockStyle.Fill };
            TextBox txtDetails = new TextBox { Text = detailsText, PlaceholderText = "Rubric criteria...", Dock = DockStyle.Fill };

            Button btnLevels = new Button
            {
                Text = "Levels",
                BackColor = System.Drawing.Color.MidnightBlue,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Tag = rubricId,
                Width = 80,
                Dock = DockStyle.Fill
            };
            btnLevels.FlatAppearance.BorderSize = 0;
            btnLevels.Click += (s, e) =>
            {
                int rid = (int)((Button)s).Tag;
                if (rid == 0) { MessageBox.Show("Save the rubric first before adding levels.", "Info"); return; }
                ShowLevelsPopup(rid, txtDetails.Text);
            };

            Button btnDel = new Button
            {
                Text = "Del",
                BackColor = Color.Brown,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Tag = rubricId,
                Width = 60,
                Dock = DockStyle.Fill
            };
            btnDel.FlatAppearance.BorderSize = 0;
            btnDel.Click += (s, e) =>
            {
                int rid = (int)((Button)s).Tag;
                if (rid == 0) { pnlRubrics.Controls.Remove(row); return; }
                if (MessageBox.Show("Delete this rubric and its levels?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string res = rubricBL.Delete(rid);
                    if (res == "success") LoadRubricRows(selectedCloId);
                    else MessageBox.Show(res, "Error");
                }
            };

            tlp.Controls.Add(lblId, 0, 0);
            tlp.Controls.Add(txtId, 1, 0);
            tlp.Controls.Add(txtDetails, 2, 0);
            tlp.Controls.Add(btnLevels, 3, 0);
            tlp.Controls.Add(btnDel, 4, 0);

            row.Controls.Add(tlp);
            pnlRubrics.Controls.Add(row);
            rubricRows.Add((rubricId, txtId, txtDetails));
        }


        private void ShowLevelsPopup(int rubricId, string rubricName)
        {
            Form popup = new Form
            {
                Text = $"Levels for: {rubricName}",
                Size = new Size(900, 600),
                StartPosition = FormStartPosition.CenterParent,
                BackColor = Color.FromArgb(240, 238, 232),
                FormBorderStyle = FormBorderStyle.FixedDialog,
                MaximizeBox = false,
                MinimizeBox = false
            };

          
            TableLayoutPanel tlp = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                RowCount = 3,
                ColumnCount = 1
            };
            tlp.RowStyles.Add(new RowStyle(SizeType.Absolute, 50)); 
            tlp.RowStyles.Add(new RowStyle(SizeType.Percent, 100f)); 
            tlp.RowStyles.Add(new RowStyle(SizeType.Absolute, 70)); 

         
            Label lbl = new Label
            {
                Text = $"Rubric Levels (ID {rubricId}) — Level 1=Unsatisfactory, 2=Fair, 3=Good, 4=Excellent",
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleLeft,
                Padding = new Padding(10),
                ForeColor = Color.DimGray
            };

            Panel pnlLevels = new Panel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true,
                BackColor = Color.White,
                Padding = new Padding(5)
            };

            FlowLayoutPanel btnPanel = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                FlowDirection = FlowDirection.RightToLeft,
                Padding = new Padding(10),
                BackColor = Color.Transparent
            };

            Button btnAddLevel = new Button
            {
                Text = "+ Add Level",
                Size = new Size(120, 35),
                BackColor = Color.MidnightBlue,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };
            btnAddLevel.FlatAppearance.BorderSize = 0;

            Button btnSaveLevels = new Button
            {
                Text = "Save Levels",
                Size = new Size(120, 35),
                BackColor = Color.MidnightBlue,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };
            btnSaveLevels.FlatAppearance.BorderSize = 0;

            btnPanel.Controls.Add(btnSaveLevels);
            btnPanel.Controls.Add(btnAddLevel);

            List<(int levelId, TextBox txtDet, NumericUpDown nudLevel)> levelRows = new();

            void LoadLevelsData()
            {
                pnlLevels.Controls.Clear();
                levelRows.Clear();
                DataTable dt = levelBL.GetByRubric(rubricId);

                foreach (DataRow r in dt.Rows)
                {
                    int lid = Convert.ToInt32(r["Id"]);

                    Panel lr = new Panel
                    {
                        Height = 42,
                        Dock = DockStyle.Top,
                        BackColor = Color.White,
                        Margin = new Padding(0, 2, 0, 2)
                    };

                 
                    Label lLvl = new Label { Text = "Level:", Location = new Point(5, 10), Size = new Size(60, 30) };
                    NumericUpDown nud = new NumericUpDown { Minimum = 1, Maximum = 4, Value = Convert.ToInt32(r["MeasurementLevel"]), Location = new Point(65, 7), Size = new Size(60, 26) };

                    TextBox td = new TextBox
                    {
                        Text = r["Details"].ToString(),
                        Location = new Point(135, 7),
                        Width = lr.Width - 180,
                        Anchor = AnchorStyles.Left | AnchorStyles.Right
                    };

                    Button bd = new Button
                    {
                        Text = "X",
                        Size = new Size(35, 26),
                        Location = new Point(lr.Width - 45, 7),
                        BackColor = Color.Brown,
                        ForeColor = Color.White,
                        FlatStyle = FlatStyle.Flat,
                        Tag = lid,
                        Anchor = AnchorStyles.Top | AnchorStyles.Right
                    };
                    bd.FlatAppearance.BorderSize = 0;

                    bd.Click += (s, e2) =>
                    {
                        if (MessageBox.Show("Delete level?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            levelBL.Delete(lid);
                            LoadLevelsData();
                        }
                    };

                    lr.Controls.AddRange(new Control[] { lLvl, nud, td, bd });
                    pnlLevels.Controls.Add(lr);
                    levelRows.Add((lid, td, nud));
                }
            }

            btnAddLevel.Click += (s, e) =>
            {
                Panel lr = new Panel { Height = 42, Dock = DockStyle.Top, BackColor = Color.White, Margin = new Padding(0, 2, 0, 2) };
                Label lLvl = new Label { Text = "Level:", Location = new Point(5, 10), Size = new Size(60, 20) };
                NumericUpDown nud = new NumericUpDown { Minimum = 1, Maximum = 4, Value = 1, Location = new Point(65, 7), Size = new Size(60, 26) };
                TextBox td = new TextBox { PlaceholderText = "Level description...", Location = new Point(135, 7), Width = lr.Width - 180, Anchor = AnchorStyles.Left | AnchorStyles.Right };
                lr.Controls.AddRange(new Control[] { lLvl, nud, td });
                pnlLevels.Controls.Add(lr);
                levelRows.Add((0, td, nud));
            };

            btnSaveLevels.Click += (s, e) =>
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
                LoadLevelsData();
            };

            LoadLevelsData();

            tlp.Controls.Add(lbl, 0, 0);
            tlp.Controls.Add(pnlLevels, 0, 1);
            tlp.Controls.Add(btnPanel, 0, 2);

            popup.Controls.Add(tlp);
            popup.ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (selectedCloId == -1) { MessageBox.Show("Load a CLO first.", "Info"); return; }

            foreach (var (rubricId, txtId, txtDetails) in rubricRows)
            {
                string details = txtDetails.Text.Trim();
                if (string.IsNullOrWhiteSpace(details)) continue;

                if (rubricId == 0)
                {

                    if (!int.TryParse(txtId.Text.Trim(), out int newId) || newId <= 0)
                    {
                        MessageBox.Show("Enter a valid numeric ID for new rubric.", "Error");
                        return;
                    }
                    string result = rubricBL.Add(newId, details, selectedCloId);
                    if (result != "success") { MessageBox.Show(result, "Error"); return; }
                }
                else
                {

                    string result = rubricBL.Update(rubricId, details, selectedCloId);
                    if (result != "success") { MessageBox.Show(result, "Error"); return; }
                }
            }

            MessageBox.Show("Rubrics saved!", "Done");
            LoadRubricRows(selectedCloId);
        }

    }
}