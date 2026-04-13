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
           
            Panel row = new Panel
            {
                Height = 60,
                Width = pnlRows.Width - 20,
                BackColor = System.Drawing.Color.White,
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(5)
            };

         
            TableLayoutPanel tlp = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 4,
                RowCount = 1,
                AutoSize = true
            };

            tlp.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));  // ID
            tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f)); // Name textbox
            tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40f)); // Dates
            tlp.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize)); // Delete button

            Label lblId = new Label
            {
                Text = id > 0 ? $"#{id}" : "New",
                ForeColor = Color.Gray,
                Font = new Font("Segoe UI", 9F),
                TextAlign = ContentAlignment.MiddleLeft,
                AutoSize = true,
                Dock = DockStyle.Fill
            };

          
            TextBox txtName = new TextBox
            {
                Text = name,
                Font = new Font("Segoe UI", 10F),
                BorderStyle = BorderStyle.FixedSingle,
                Dock = DockStyle.Fill
            };

          
            Label lblDates = new Label
            {
                Text = dates,
                ForeColor = Color.Gray,
                Font = new Font("Segoe UI", 8F, FontStyle.Italic),
                TextAlign = ContentAlignment.MiddleLeft,
                Dock = DockStyle.Fill
            };

            
            Button btnDel = new Button
            {
                Text = "Delete",
                Width = 80,
                Height = 30,
                BackColor = Color.IndianRed,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Tag = id,
                Dock = DockStyle.Right
            };
            btnDel.FlatAppearance.BorderSize = 0;

            btnDel.Click += (s, e) =>
            {
                int rid = (int)((Button)s).Tag;
                if (rid == 0) { pnlRows.Controls.Remove(row); return; }
                if (MessageBox.Show("Delete this CLO? This may affect rubrics linked to it.", "Confirm",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    string res = bl.Delete(rid);
                    if (res == "success") LoadRows();
                    else MessageBox.Show(res, "Error");
                }
            };

            tlp.Controls.Add(lblId, 0, 0);
            tlp.Controls.Add(txtName, 1, 0);
            tlp.Controls.Add(lblDates, 2, 0);
            tlp.Controls.Add(btnDel, 3, 0);

           
            row.Controls.Add(tlp);

           
            pnlRows.Controls.Add(row);

            cloRows.Add((txtName, id, lblDates));
        }

        private void lnkAddCLO_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
            => AddRow(0, "", "New CLO — fill name and click Save All", true);


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cloRows.Count == 0)
            {
                MessageBox.Show("Please add at least one CLO.");
                return;
            }

            try
            {
                foreach (var (txtName, id, lblDates) in cloRows)
                {
                    string name = txtName.Text.Trim();
                    if (string.IsNullOrEmpty(name)) continue;

                    if (id == 0)
                    {

                        string query = "INSERT INTO clo (Name, DateCreated, DateUpdated) VALUES (@name, NOW(), NOW())";
                        DatabaseHelper.ExecuteNonQuery(query, new Dictionary<string, object>
                {
                    { "@name", name }
                });
                    }
                    else
                    {

                        string query = "UPDATE clo SET Name=@name, DateUpdated=NOW() WHERE Id=@id";
                        DatabaseHelper.ExecuteNonQuery(query, new Dictionary<string, object>
                {
                    { "@name", name },
                    { "@id", id }
                });
                    }
                }

                MessageBox.Show("CLOs saved successfully!");
                LoadRows();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving CLOs: " + ex.Message);
            }
        }
        private IEnumerable<TextBox> GetTextBoxes(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {
                if (ctrl is TextBox txt)
                    yield return txt;
                else if (ctrl.HasChildren)
                {
                    foreach (var child in GetTextBoxes(ctrl))
                        yield return child;
                }
            }
        }
    }
}