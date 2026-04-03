using MidDb26_2025CS60.BL;
using MidDb26_2025CS60.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace MidDb26_2025CS60.Forms
{
    public partial class ManageCLOs : Form
    {
        CloBL bl = new CloBL();
        private List<(TextBox txtName, int id, Label lblDates)> cloRows = new();

        public ManageCLOs() { InitializeComponent(); }

        private void ManageCLOsForm_Load(object sender, EventArgs e) => LoadRows();

        private void LoadRows()
        {
            pnlRows.Controls.Clear();
            cloRows.Clear();
            DataTable dt = bl.GetAll();
            foreach (DataRow row in dt.Rows)
            {
                int id = Convert.ToInt32(row["Id"]);
                string name = row["Name"].ToString();
                string created = Convert.ToDateTime(row["DateCreated"]).ToString("dd MMM yyyy");
                string updated = Convert.ToDateTime(row["DateUpdated"]).ToString("dd MMM yyyy");
                AddRow(id, name, $"Created: {created}  |  Updated: {updated}", false);
            }
        }

        private void AddRow(int id, string name, string dates, bool isNew)
        {
            Panel row = new Panel { Size = new System.Drawing.Size(690, 55), BackColor = System.Drawing.Color.White };
            Label lblId = new Label { Text = id > 0 ? $"#{id}" : "New", Location = new System.Drawing.Point(5, 8), Size = new System.Drawing.Size(40, 20), ForeColor = System.Drawing.Color.Gray, Font = new System.Drawing.Font("Segoe UI", 8F) };
            TextBox txtName = new TextBox { Text = name, Location = new System.Drawing.Point(50, 5), Size = new System.Drawing.Size(450, 26) };
            Label lblDates = new Label { Text = dates, Location = new System.Drawing.Point(50, 33), Size = new System.Drawing.Size(440, 18), ForeColor = System.Drawing.Color.Gray, Font = new System.Drawing.Font("Segoe UI", 8F) };
            Button btnDel = new Button { Text = "Delete", Location = new System.Drawing.Point(500, 5), Size = new System.Drawing.Size(75, 28), BackColor = System.Drawing.Color.Brown, ForeColor = System.Drawing.Color.White, FlatStyle = FlatStyle.Flat, Tag = id };
            btnDel.Click += (s, e) => {
                int rid = (int)((Button)s).Tag;
                if (rid == 0) { pnlRows.Controls.Remove(row); return; }
                if (MessageBox.Show("Delete this CLO? This may affect rubrics linked to it.", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                { string res = bl.Delete(rid); if (res == "success") LoadRows(); else MessageBox.Show(res, "Error"); }
            };
            row.Controls.AddRange(new System.Windows.Forms.Control[] { lblId, txtName, lblDates, btnDel });
            pnlRows.Controls.Add(row);
            cloRows.Add((txtName, id, lblDates));
        }

        private void lnkAddCLO_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
            => AddRow(0, "", "New CLO — fill name and click Save All", true);

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> cloNames = new List<string>();

            foreach (Control ctrl in pnlRows.Controls)
            {
                if (ctrl is Panel rowPanel)
                {
                    foreach (Control child in rowPanel.Controls)
                    {
                        if (child is TextBox txt && txt.Text.Trim() != "")
                            cloNames.Add(txt.Text.Trim());
                    }
                }
            }
            if (cloNames.Count == 0)
            {
                MessageBox.Show("Please add at least one CLO.");
                return;
            }

            try
            {
                foreach (string name in cloNames)
                {
                    string query = "INSERT INTO clo (Name, DateCreated, DateUpdated) VALUES (@name, NOW(), NOW())";
                    DatabaseHelper.ExecuteNonQuery(query, new Dictionary<string, object>
            {
                { "@name", name }
            });
                }
                MessageBox.Show("CLOs saved successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving CLOs: " + ex.Message);
            }
        }
    }
}