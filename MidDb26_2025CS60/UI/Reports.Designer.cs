namespace MidDb26_2025CS60.Forms
{
    partial class Reports
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

        private void InitializeComponent()
        {
            pnlHeader = new Panel();
            lblTitle = new Label();
            lblReportType = new Label();
            cmbReportType = new ComboBox();
            lblAssessment = new Label();
            cmbAssessment = new ComboBox();
            btnGenerate = new Button();
            lblRequired = new Label();
            pnlHeader.SuspendLayout();
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
            lblTitle.Text = "Reports";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblReportType
            // 
            lblReportType.AutoSize = true;
            lblReportType.Location = new Point(67, 183);
            lblReportType.Margin = new Padding(5, 0, 5, 0);
            lblReportType.Name = "lblReportType";
            lblReportType.Size = new Size(120, 25);
            lblReportType.TabIndex = 1;
            lblReportType.Text = "Report Type *";
            // 
            // cmbReportType
            // 
            cmbReportType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbReportType.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbReportType.Location = new Point(67, 214);
            cmbReportType.Margin = new Padding(5, 6, 5, 6);
            cmbReportType.Name = "cmbReportType";
            cmbReportType.Size = new Size(850, 36);
            cmbReportType.TabIndex = 2;
            // 
            // lblAssessment
            // 
            lblAssessment.AutoSize = true;
            lblAssessment.Location = new Point(67, 285);
            lblAssessment.Margin = new Padding(5, 0, 5, 0);
            lblAssessment.Name = "lblAssessment";
            lblAssessment.Size = new Size(157, 25);
            lblAssessment.TabIndex = 3;
            lblAssessment.Text = "Select Assessment";
            // 
            // cmbAssessment
            // 
            cmbAssessment.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAssessment.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbAssessment.Location = new Point(67, 317);
            cmbAssessment.Margin = new Padding(5, 6, 5, 6);
            cmbAssessment.Name = "cmbAssessment";
            cmbAssessment.Size = new Size(850, 36);
            cmbAssessment.TabIndex = 4;
            // 
            // btnGenerate
            // 
            btnGenerate.BackColor = Color.FromArgb(30, 50, 90);
            btnGenerate.FlatStyle = FlatStyle.Flat;
            btnGenerate.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerate.ForeColor = Color.White;
            btnGenerate.Location = new Point(67, 400);
            btnGenerate.Margin = new Padding(5, 6, 5, 6);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(850, 87);
            btnGenerate.TabIndex = 5;
            btnGenerate.Text = "Generate PDF Report";
            btnGenerate.UseVisualStyleBackColor = false;
            // 
            // lblRequired
            // 
            lblRequired.AutoSize = true;
            lblRequired.ForeColor = Color.Gray;
            lblRequired.Location = new Point(67, 505);
            lblRequired.Margin = new Padding(5, 0, 5, 0);
            lblRequired.Name = "lblRequired";
            lblRequired.Size = new Size(155, 25);
            lblRequired.TabIndex = 6;
            lblRequired.Text = "* = required fields";
            // 
            // Reports
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 238, 232);
            ClientSize = new Size(1000, 600);
            Controls.Add(pnlHeader);
            Controls.Add(lblReportType);
            Controls.Add(cmbReportType);
            Controls.Add(lblAssessment);
            Controls.Add(cmbAssessment);
            Controls.Add(btnGenerate);
            Controls.Add(lblRequired);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Reports";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reports";
         
            pnlHeader.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
        private Label lblTitle;
        private Label lblReportType;
        private ComboBox cmbReportType;
        private Label lblAssessment;
        private ComboBox cmbAssessment;
        private Button btnGenerate;
        private Label lblRequired;
    }
}