namespace MidDb26_2025CS60.Forms
{
    partial class AddStudent
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblFirstName = new Label();
            txtFirstName = new TextBox();
            lblLastName = new Label();
            txtLastName = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblContact = new Label();
            txtContact = new TextBox();
            lblRegNo = new Label();
            txtRegNo = new TextBox();
            lblStatus = new Label();
            txtStatus = new TextBox();
            btnSave = new Button();
            pnlHeader = new Panel();
            lblTitle = new Label();
            lblRequired = new Label();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(67, 183);
            lblFirstName.Margin = new Padding(5, 0, 5, 0);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(110, 25);
            lblFirstName.TabIndex = 0;
            lblFirstName.Text = "First Name *";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(49, 214);
            txtFirstName.Margin = new Padding(5, 6, 5, 6);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(847, 31);
            txtFirstName.TabIndex = 1;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(67, 285);
            lblLastName.Margin = new Padding(5, 0, 5, 0);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(95, 25);
            lblLastName.TabIndex = 2;
            lblLastName.Text = "Last Name";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(67, 317);
            txtLastName.Margin = new Padding(5, 6, 5, 6);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(847, 31);
            txtLastName.TabIndex = 3;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(67, 387);
            lblEmail.Margin = new Padding(5, 0, 5, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(67, 25);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Email *";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(67, 419);
            txtEmail.Margin = new Padding(5, 6, 5, 6);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(847, 31);
            txtEmail.TabIndex = 5;
            // 
            // lblContact
            // 
            lblContact.AutoSize = true;
            lblContact.Location = new Point(67, 488);
            lblContact.Margin = new Padding(5, 0, 5, 0);
            lblContact.Name = "lblContact";
            lblContact.Size = new Size(73, 25);
            lblContact.TabIndex = 6;
            lblContact.Text = "Contact";
            // 
            // txtContact
            // 
            txtContact.Location = new Point(67, 521);
            txtContact.Margin = new Padding(5, 6, 5, 6);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(847, 31);
            txtContact.TabIndex = 7;
            // 
            // lblRegNo
            // 
            lblRegNo.AutoSize = true;
            lblRegNo.Location = new Point(67, 590);
            lblRegNo.Margin = new Padding(5, 0, 5, 0);
            lblRegNo.Name = "lblRegNo";
            lblRegNo.Size = new Size(148, 25);
            lblRegNo.TabIndex = 8;
            lblRegNo.Text = "Registration No *";
            // 
            // txtRegNo
            // 
            txtRegNo.Location = new Point(67, 623);
            txtRegNo.Margin = new Padding(5, 6, 5, 6);
            txtRegNo.Name = "txtRegNo";
            txtRegNo.Size = new Size(847, 31);
            txtRegNo.TabIndex = 9;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(67, 692);
            lblStatus.Margin = new Padding(5, 0, 5, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(60, 25);
            lblStatus.TabIndex = 10;
            lblStatus.Text = "Status";
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(67, 725);
            txtStatus.Margin = new Padding(5, 6, 5, 6);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(847, 31);
            txtStatus.TabIndex = 11;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(30, 50, 90);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(67, 794);
            btnSave.Margin = new Padding(5, 6, 5, 6);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(850, 87);
            btnSave.TabIndex = 12;
            btnSave.Text = "Save Student";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(30, 50, 90);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Location = new Point(67, 38);
            pnlHeader.Margin = new Padding(5, 6, 5, 6);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(850, 106);
            pnlHeader.TabIndex = 13;
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(0, 0);
            lblTitle.Margin = new Padding(5, 0, 5, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(850, 106);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Add New Student";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRequired
            // 
            lblRequired.AutoSize = true;
            lblRequired.ForeColor = Color.Gray;
            lblRequired.Location = new Point(67, 894);
            lblRequired.Margin = new Padding(5, 0, 5, 0);
            lblRequired.Name = "lblRequired";
            lblRequired.Size = new Size(155, 25);
            lblRequired.TabIndex = 14;
            lblRequired.Text = "* = required fields";
           
            // 
            // AddStudent
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 238, 232);
            ClientSize = new Size(1000, 962);
            Controls.Add(pnlHeader);
            Controls.Add(lblFirstName);
            Controls.Add(txtFirstName);
            Controls.Add(lblLastName);
            Controls.Add(txtLastName);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Controls.Add(lblContact);
            Controls.Add(txtContact);
            Controls.Add(lblRegNo);
            Controls.Add(txtRegNo);
            Controls.Add(lblStatus);
            Controls.Add(txtStatus);
            Controls.Add(btnSave);
            Controls.Add(lblRequired);
            Margin = new Padding(5, 6, 5, 6);
            Name = "AddStudent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add New Student";
            pnlHeader.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFirstName;
        private TextBox txtFirstName;
        private Label lblLastName;
        private TextBox txtLastName;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblContact;
        private TextBox txtContact;
        private Label lblRegNo;
        private TextBox txtRegNo;
        private Label lblStatus;
        private TextBox txtStatus;
        private Button btnSave;
        private Panel pnlHeader;
        private Label lblTitle;
        private Label lblRequired;
    }
}