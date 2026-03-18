
namespace MidDb26_2025CS60.Forms
{
    partial class EditStudentForm : Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlHeader = new Panel();
            lblTitle = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            separatorPanel = new Panel();
            lblFirstName = new Label();
            txtFirstName = new TextBox();
            lblLastName = new Label();
            txtLastName = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            btnSave = new Button();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.MidnightBlue;
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Location = new Point(30, 20);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(560, 55);
            pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(560, 55);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Edit Student";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.ForeColor = Color.Gray;
            txtSearch.Location = new Point(30, 95);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(440, 34);
            txtSearch.TabIndex = 1;
            txtSearch.Text = "Enter Reg No...";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.MidnightBlue;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(480, 92);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(110, 44);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // separatorPanel
            // 
            separatorPanel.BackColor = Color.Silver;
            separatorPanel.Location = new Point(30, 135);
            separatorPanel.Name = "separatorPanel";
            separatorPanel.Size = new Size(560, 1);
            separatorPanel.TabIndex = 3;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFirstName.ForeColor = Color.DimGray;
            lblFirstName.Location = new Point(28, 183);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(97, 25);
            lblFirstName.TabIndex = 5;
            lblFirstName.Text = "First Name";
            // 
            // txtFirstName
            // 
            txtFirstName.BorderStyle = BorderStyle.FixedSingle;
            txtFirstName.Enabled = false;
            txtFirstName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFirstName.ForeColor = Color.Gray;
            txtFirstName.Location = new Point(30, 200);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(560, 34);
            txtFirstName.TabIndex = 6;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLastName.ForeColor = Color.DimGray;
            lblLastName.Location = new Point(30, 238);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(95, 25);
            lblLastName.TabIndex = 7;
            lblLastName.Text = "Last Name";
            // 
            // txtLastName
            // 
            txtLastName.BorderStyle = BorderStyle.FixedSingle;
            txtLastName.Enabled = false;
            txtLastName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLastName.ForeColor = Color.Gray;
            txtLastName.Location = new Point(30, 260);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(560, 34);
            txtLastName.TabIndex = 8;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.ForeColor = Color.DimGray;
            lblEmail.Location = new Point(30, 298);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(54, 25);
            lblEmail.TabIndex = 9;
            lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Enabled = false;
            txtEmail.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.ForeColor = Color.Gray;
            txtEmail.Location = new Point(30, 320);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(560, 34);
            txtEmail.TabIndex = 10;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.SlateGray;
            btnSave.Enabled = false;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(30, 362);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(560, 45);
            btnSave.TabIndex = 11;
            btnSave.Text = "Save Changes";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // EditStudentForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 238, 232);
            ClientSize = new Size(624, 450);
            Controls.Add(pnlHeader);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Controls.Add(separatorPanel);
            Controls.Add(lblFirstName);
            Controls.Add(txtFirstName);
            Controls.Add(lblLastName);
            Controls.Add(txtLastName);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Controls.Add(btnSave);
            Name = "EditStudentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Edit Student";
            pnlHeader.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
        private Label lblTitle;
        private TextBox txtSearch;
        private Button btnSearch;
        private Panel separatorPanel;
        private Label lblFirstName;
        private TextBox txtFirstName;
        private Label lblLastName;
        private TextBox txtLastName;
        private Label lblEmail;
        private TextBox txtEmail;
        private Button btnSave;
    }
}