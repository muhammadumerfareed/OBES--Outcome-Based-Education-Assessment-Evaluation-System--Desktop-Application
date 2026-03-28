using Org.BouncyCastle.Asn1.Crmf;
using System.Drawing.Printing;
using System.Xml.Linq;


namespace MidDb26_2025CS60.Forms
{
    partial class Manageassessments
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        /// <summary>
        ///  Clean up any resources being used.
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

        private void InitializeComponent()
        {
            pnlHeader = new Panel();
            lblTitle = new Label();
            lblAssessmentTitle = new Label();
            txtAssessmentTitle = new TextBox();
            lblTotalMarks = new Label();
            txtTotalMarks = new TextBox();
            lblWeightage = new Label();
            txtWeightage = new TextBox();
            btnSave = new Button();
            lblExisting = new Label();
            dgvAssessments = new DataGridView();
            lblRequired = new Label();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAssessments).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(30, 50, 90);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Location = new Point(67, 38);
            pnlHeader.Margin = new Padding(5, 6, 5, 6);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(850, 106);
            pnlHeader.TabIndex = 0;
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
            lblTitle.Text = "Manage Assessments";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAssessmentTitle
            // 
            lblAssessmentTitle.AutoSize = true;
            lblAssessmentTitle.Location = new Point(67, 183);
            lblAssessmentTitle.Margin = new Padding(5, 0, 5, 0);
            lblAssessmentTitle.Name = "lblAssessmentTitle";
            lblAssessmentTitle.Size = new Size(156, 25);
            lblAssessmentTitle.TabIndex = 1;
            lblAssessmentTitle.Text = "Assessment Title *";
            // 
            // txtAssessmentTitle
            // 
            txtAssessmentTitle.Location = new Point(67, 214);
            txtAssessmentTitle.Margin = new Padding(5, 6, 5, 6);
            txtAssessmentTitle.Name = "txtAssessmentTitle";
            txtAssessmentTitle.PlaceholderText = "e.g. Lab1";
            txtAssessmentTitle.Size = new Size(850, 31);
            txtAssessmentTitle.TabIndex = 2;
            // 
            // lblTotalMarks
            // 
            lblTotalMarks.AutoSize = true;
            lblTotalMarks.Location = new Point(67, 285);
            lblTotalMarks.Margin = new Padding(5, 0, 5, 0);
            lblTotalMarks.Name = "lblTotalMarks";
            lblTotalMarks.Size = new Size(115, 25);
            lblTotalMarks.TabIndex = 3;
            lblTotalMarks.Text = "Total Marks *";
            // 
            // txtTotalMarks
            // 
            txtTotalMarks.Location = new Point(67, 317);
            txtTotalMarks.Margin = new Padding(5, 6, 5, 6);
            txtTotalMarks.Name = "txtTotalMarks";
            txtTotalMarks.PlaceholderText = "e.g. 10";
            txtTotalMarks.Size = new Size(850, 31);
            txtTotalMarks.TabIndex = 4;
            // 
            // lblWeightage
            // 
            lblWeightage.AutoSize = true;
            lblWeightage.Location = new Point(67, 387);
            lblWeightage.Margin = new Padding(5, 0, 5, 0);
            lblWeightage.Name = "lblWeightage";
            lblWeightage.Size = new Size(130, 25);
            lblWeightage.TabIndex = 5;
            lblWeightage.Text = "Weightage % *";
            // 
            // txtWeightage
            // 
            txtWeightage.Location = new Point(67, 419);
            txtWeightage.Margin = new Padding(5, 6, 5, 6);
            txtWeightage.Name = "txtWeightage";
            txtWeightage.PlaceholderText = "e.g. 5";
            txtWeightage.Size = new Size(850, 31);
            txtWeightage.TabIndex = 6;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(30, 50, 90);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(67, 494);
            btnSave.Margin = new Padding(5, 6, 5, 6);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(850, 87);
            btnSave.TabIndex = 7;
            btnSave.Text = "Save Assessment";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // lblExisting
            // 
            lblExisting.AutoSize = true;
            lblExisting.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblExisting.ForeColor = Color.Gray;
            lblExisting.Location = new Point(67, 610);
            lblExisting.Margin = new Padding(5, 0, 5, 0);
            lblExisting.Name = "lblExisting";
            lblExisting.Size = new Size(401, 28);
            lblExisting.TabIndex = 8;
            lblExisting.Text = "Existing Assessments — click any row to edit:";
            // 
            // dgvAssessments
            // 
            dgvAssessments.AllowUserToAddRows = false;
            dgvAssessments.AllowUserToDeleteRows = false;
            dgvAssessments.BackgroundColor = Color.FromArgb(240, 238, 232);
            dgvAssessments.BorderStyle = BorderStyle.None;
            dgvAssessments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAssessments.Location = new Point(67, 645);
            dgvAssessments.Margin = new Padding(5, 6, 5, 6);
            dgvAssessments.Name = "dgvAssessments";
            dgvAssessments.ReadOnly = true;
            dgvAssessments.RowHeadersVisible = false;
            dgvAssessments.RowHeadersWidth = 62;
            dgvAssessments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAssessments.Size = new Size(850, 250);
            dgvAssessments.TabIndex = 9;
            // 
            // lblRequired
            // 
            lblRequired.AutoSize = true;
            lblRequired.ForeColor = Color.Gray;
            lblRequired.Location = new Point(67, 915);
            lblRequired.Margin = new Padding(5, 0, 5, 0);
            lblRequired.Name = "lblRequired";
            lblRequired.Size = new Size(155, 25);
            lblRequired.TabIndex = 10;
            lblRequired.Text = "* = required fields";
            // 
            // Manageassessments
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 238, 232);
            ClientSize = new Size(1000, 980);
            Controls.Add(pnlHeader);
            Controls.Add(lblAssessmentTitle);
            Controls.Add(txtAssessmentTitle);
            Controls.Add(lblTotalMarks);
            Controls.Add(txtTotalMarks);
            Controls.Add(lblWeightage);
            Controls.Add(txtWeightage);
            Controls.Add(btnSave);
            Controls.Add(lblExisting);
            Controls.Add(dgvAssessments);
            Controls.Add(lblRequired);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Manageassessments";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manage Assessments";
            pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAssessments).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
        private Label lblTitle;
        private Label lblAssessmentTitle;
        private TextBox txtAssessmentTitle;
        private Label lblTotalMarks;
        private TextBox txtTotalMarks;
        private Label lblWeightage;
        private TextBox txtWeightage;
        private Button btnSave;
        private Label lblExisting;
        private DataGridView dgvAssessments;
        private Label lblRequired;
    }
}