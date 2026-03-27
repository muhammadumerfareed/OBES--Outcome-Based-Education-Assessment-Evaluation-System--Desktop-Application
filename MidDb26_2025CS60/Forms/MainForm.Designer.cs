namespace MidDb26_2025CS60
{
    partial class MainForm
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

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            btnStudents = new Button();
            btnCLOs = new Button();
            btnRubrics = new Button();
            btnAssesments = new Button();
            btnEvaluations = new Button();
            btnReports = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.FlatStyle = FlatStyle.Flat;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.DarkBlue;
            lblTitle.Location = new Point(108, 66);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(525, 54);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Student Evaluation System";
            // 
            // btnStudents
            // 
            btnStudents.BackColor = Color.DarkBlue;
            btnStudents.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnStudents.ForeColor = Color.White;
            btnStudents.Location = new Point(37, 203);
            btnStudents.Name = "btnStudents";
            btnStudents.Size = new Size(311, 72);
            btnStudents.TabIndex = 1;
            btnStudents.Text = "👨‍🎓 Manage Students";
            btnStudents.UseVisualStyleBackColor = false;
            btnStudents.Click += btnStudents_Click;
            // 
            // btnCLOs
            // 
            btnCLOs.BackColor = Color.DarkBlue;
            btnCLOs.FlatStyle = FlatStyle.Flat;
            btnCLOs.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCLOs.ForeColor = Color.White;
            btnCLOs.Location = new Point(404, 210);
            btnCLOs.Name = "btnCLOs";
            btnCLOs.Size = new Size(345, 58);
            btnCLOs.TabIndex = 2;
            btnCLOs.Text = "📚 Manage CLOs";
            btnCLOs.UseVisualStyleBackColor = false;
            btnCLOs.Click += btnCLOs_Click;
            // 
            // btnRubrics
            // 
            btnRubrics.BackColor = Color.DarkBlue;
            btnRubrics.FlatStyle = FlatStyle.Flat;
            btnRubrics.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRubrics.ForeColor = Color.White;
            btnRubrics.Location = new Point(37, 302);
            btnRubrics.Name = "btnRubrics";
            btnRubrics.Size = new Size(273, 60);
            btnRubrics.TabIndex = 3;
            btnRubrics.Text = "📏 Manage Rubrics";
            btnRubrics.UseVisualStyleBackColor = true;
            btnRubrics.Click += btnRubrics_Click;
            // 
            // btnAssesments
            // 
            btnAssesments.BackColor = Color.DarkBlue;
            btnAssesments.FlatStyle = FlatStyle.Flat;
            btnAssesments.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAssesments.ForeColor = Color.White;
            btnAssesments.Location = new Point(421, 302);
            btnAssesments.Name = "btnAssesments";
            btnAssesments.Size = new Size(345, 60);
            btnAssesments.TabIndex = 4;
            btnAssesments.Text = "📝 Manage Assessments";
            btnAssesments.UseVisualStyleBackColor = true;
            btnAssesments.Click += btnAssesments_Click;
            // 
            // btnEvaluations
            // 
            btnEvaluations.BackColor = Color.DarkBlue;
            btnEvaluations.FlatStyle = FlatStyle.Flat;
            btnEvaluations.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEvaluations.ForeColor = Color.White;
            btnEvaluations.Location = new Point(47, 397);
            btnEvaluations.Name = "btnEvaluations";
            btnEvaluations.Size = new Size(263, 60);
            btnEvaluations.TabIndex = 5;
            btnEvaluations.Text = "✅ Mark Evaluations";
            btnEvaluations.UseVisualStyleBackColor = true;
            btnEvaluations.Click += btnEvaluations_Click;
            // 
            // btnReports
            // 
            btnReports.BackColor = Color.DarkBlue;
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReports.ForeColor = Color.White;
            btnReports.Location = new Point(455, 397);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(311, 60);
            btnReports.TabIndex = 6;
            btnReports.Text = "📄 Reports";
            btnReports.UseVisualStyleBackColor = true;
            btnReports.Click += btnReports_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 238, 232);
            ClientSize = new Size(778, 544);
            Controls.Add(btnReports);
            Controls.Add(btnEvaluations);
            Controls.Add(btnAssesments);
            Controls.Add(btnRubrics);
            Controls.Add(btnCLOs);
            Controls.Add(btnStudents);
            Controls.Add(lblTitle);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StudentEvaluationSystem";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Button btnStudents;
        private Button btnCLOs;
        private Button btnRubrics;
        private Button btnAssesments;
        private Button btnEvaluations;
        private Button btnReports;
    }
}
