using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MidDb26_2025CS60.Forms
{
    public partial class ManageCLOs : Form
    {
        int cloCounter = 0;
        public ManageCLOs()
        {
            InitializeComponent();
        }

        private void ManageCLOsForm_Load(object sender, EventArgs e)
        {
          
        }

        private void AddCLORow(string cloText = "")
        {
            cloCounter++;

            Panel rowPanel = new Panel();
            rowPanel.Size = new Size(650, 50);
            rowPanel.BackColor = Color.White;

            Panel separator = new Panel();
            separator.BackColor = Color.LightGray;
            separator.Size = new Size(650, 1);
            separator.Location = new Point(0, 49);
            rowPanel.Controls.Add(separator);

            Label lblNum = new Label();
            lblNum.Text = cloCounter.ToString();
            lblNum.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNum.ForeColor = Color.DimGray;
            lblNum.Location = new Point(10, 12);
            lblNum.Size = new Size(35, 25);
            rowPanel.Controls.Add(lblNum);

            TextBox txtCLO = new TextBox();
            txtCLO.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCLO.Text = cloText;
            txtCLO.Location = new Point(55, 10);
            txtCLO.Size = new Size(480, 28);
            txtCLO.BorderStyle = BorderStyle.FixedSingle;
            rowPanel.Controls.Add(txtCLO);

            Button btnRemove = new Button();
            btnRemove.Text = "Remove";
            btnRemove.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemove.BackColor = Color.Brown;
            btnRemove.ForeColor = Color.White;
            btnRemove.FlatStyle = FlatStyle.Flat;
            btnRemove.FlatAppearance.BorderSize = 0;
            btnRemove.Size = new Size(85, 28);
            btnRemove.Location = new Point(548, 10);
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += (s, e) =>
            {
                pnlRows.Controls.Remove(rowPanel);
                RenumberRows();
            };
            rowPanel.Controls.Add(btnRemove);

            pnlRows.Controls.Add(rowPanel);
        }

        private void RenumberRows()
        {
          int   cloCounter = 0;
            foreach (Control ctrl in pnlRows.Controls)
            {
                if (ctrl is Panel rowPanel)
                {
                    cloCounter++;
                    foreach (Control child in rowPanel.Controls)
                    {
                        if (child is Label lbl && int.TryParse(lbl.Text, out _))
                            lbl.Text = cloCounter.ToString();
                    }
                }
            }
        }

        private void lnkAddCLO_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddCLORow("");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> cloNames = new List<string>();

            foreach (Control ctrl in pnlRows.Controls)
            {
                if (ctrl is Panel rowPanel)
                {
                    foreach (Control child in rowPanel.Controls)
                    {
                        if (child is TextBox txt)
                            cloNames.Add(txt.Text.Trim());
                    }
                }
            }

          
        }
    }
}