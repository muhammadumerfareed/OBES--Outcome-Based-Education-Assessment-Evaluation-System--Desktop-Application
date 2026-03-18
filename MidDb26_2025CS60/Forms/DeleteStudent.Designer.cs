

namespace MidDb26_2025CS60.Forms
{
    partial class DeleteStudentForm : Form
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
            lblInstruction = new Label();
            txtRegNo = new TextBox();
            btnFind = new Button();
            pnlResult = new Panel();
            lblFoundName = new Label();
            lblFoundDetails = new Label();
            btnDelete = new Button();
            pnlWarning = new Panel();
            lblWarning = new Label();
            pnlHeader.SuspendLayout();
            pnlResult.SuspendLayout();
            pnlWarning.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.Brown;
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
            lblTitle.Text = "Delete Student";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblInstruction
            // 
            lblInstruction.AutoSize = true;
            lblInstruction.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInstruction.ForeColor = Color.DimGray;
            lblInstruction.Location = new Point(25, 85);
            lblInstruction.Name = "lblInstruction";
            lblInstruction.Size = new Size(337, 25);
            lblInstruction.TabIndex = 1;
            lblInstruction.Text = "Enter Registration No to find the student:";
            // 
            // txtRegNo
            // 
            txtRegNo.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRegNo.ForeColor = Color.Gray;
            txtRegNo.Location = new Point(30, 113);
            txtRegNo.Name = "txtRegNo";
            txtRegNo.Size = new Size(440, 34);
            txtRegNo.TabIndex = 2;
            txtRegNo.Text = "e.g. 20XX-YY-ZZ";
            // 
            // btnFind
            // 
            btnFind.BackColor = Color.MidnightBlue;
            btnFind.FlatStyle = FlatStyle.Flat;
            btnFind.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFind.ForeColor = Color.White;
            btnFind.Location = new Point(480, 110);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(110, 37);
            btnFind.TabIndex = 3;
            btnFind.Text = "Find";
            btnFind.UseVisualStyleBackColor = false;
            // 
            // pnlResult
            // 
            pnlResult.BackColor = Color.White;
            pnlResult.BorderStyle = BorderStyle.FixedSingle;
            pnlResult.Controls.Add(lblFoundName);
            pnlResult.Controls.Add(lblFoundDetails);
            pnlResult.Location = new Point(30, 158);
            pnlResult.Name = "pnlResult";
            pnlResult.Size = new Size(560, 65);
            pnlResult.TabIndex = 4;
            pnlResult.Visible = false;
            // 
            // lblFoundName
            // 
            lblFoundName.AutoSize = true;
            lblFoundName.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFoundName.ForeColor = Color.Black;
            lblFoundName.Location = new Point(10, 10);
            lblFoundName.Name = "lblFoundName";
            lblFoundName.Size = new Size(0, 28);
            lblFoundName.TabIndex = 0;
            // 
            // lblFoundDetails
            // 
            lblFoundDetails.AutoSize = true;
            lblFoundDetails.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFoundDetails.ForeColor = Color.DimGray;
            lblFoundDetails.Location = new Point(10, 35);
            lblFoundDetails.Name = "lblFoundDetails";
            lblFoundDetails.Size = new Size(0, 25);
            lblFoundDetails.TabIndex = 1;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Brown;
            btnDelete.Enabled = false;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(30, 238);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(560, 45);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Confirm Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // pnlWarning
            // 
            pnlWarning.BackColor = Color.White;
            pnlWarning.BorderStyle = BorderStyle.FixedSingle;
            pnlWarning.Controls.Add(lblWarning);
            pnlWarning.Location = new Point(30, 295);
            pnlWarning.Name = "pnlWarning";
            pnlWarning.Size = new Size(560, 40);
            pnlWarning.TabIndex = 6;
            // 
            // lblWarning
            // 
            lblWarning.Dock = DockStyle.Fill;
            lblWarning.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWarning.ForeColor = Color.Brown;
            lblWarning.Location = new Point(0, 0);
            lblWarning.Name = "lblWarning";
            lblWarning.Size = new Size(558, 38);
            lblWarning.TabIndex = 0;
            lblWarning.Text = "Warning: This action cannot be undone!";
            lblWarning.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DeleteStudentForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 238, 232);
            ClientSize = new Size(624, 355);
            Controls.Add(pnlHeader);
            Controls.Add(lblInstruction);
            Controls.Add(txtRegNo);
            Controls.Add(btnFind);
            Controls.Add(pnlResult);
            Controls.Add(btnDelete);
            Controls.Add(pnlWarning);
            Name = "DeleteStudentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Delete Student";
            pnlHeader.ResumeLayout(false);
            pnlResult.ResumeLayout(false);
            pnlResult.PerformLayout();
            pnlWarning.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
        private Label lblTitle;
        private Label lblInstruction;
        private TextBox txtRegNo;
        private Button btnFind;
        private Panel pnlResult;
        private Label lblFoundName;
        private Label lblFoundDetails;
        private Button btnDelete;
        private Panel pnlWarning;
        private Label lblWarning;
    }
}