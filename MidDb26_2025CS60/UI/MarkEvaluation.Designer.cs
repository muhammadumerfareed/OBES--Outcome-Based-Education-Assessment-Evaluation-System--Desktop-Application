namespace MidDb26_2025CS60.Forms
{
    partial class MarkEvaluation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        // <summary>
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
            lblSelectStudent = new Label();
            cmbStudent = new ComboBox();
            lblSelectAssessment = new Label();
            cmbAssessment = new ComboBox();
            lblComponents = new Label();
            pnlComponentsHeader = new Panel();
            lblColComponent = new Label();
            lblColRubric = new Label();
            lblColMax = new Label();
            lblColLevel = new Label();
            lblColMarks = new Label();
            pnlComponentsBody = new Panel();
            pnlTotalMarks = new Panel();
            lblTotalObtained = new Label();
            lblTotalValue = new Label();
            btnSaveEvaluation = new Button();
            lblFormula = new Label();
            pnlHeader.SuspendLayout();
            pnlComponentsHeader.SuspendLayout();
            pnlTotalMarks.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(30, 50, 90);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Location = new Point(80, 46);
            pnlHeader.Margin = new Padding(6, 7, 6, 7);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1020, 127);
            pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(0, 0);
            lblTitle.Margin = new Padding(6, 0, 6, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(1020, 127);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Mark Evaluation";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSelectStudent
            // 
            lblSelectStudent.AutoSize = true;
            lblSelectStudent.Location = new Point(80, 220);
            lblSelectStudent.Margin = new Padding(6, 0, 6, 0);
            lblSelectStudent.Name = "lblSelectStudent";
            lblSelectStudent.Size = new Size(160, 30);
            lblSelectStudent.TabIndex = 1;
            lblSelectStudent.Text = "Select Student *";
            // 
            // cmbStudent
            // 
            cmbStudent.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStudent.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbStudent.Location = new Point(80, 257);
            cmbStudent.Margin = new Padding(6, 7, 6, 7);
            cmbStudent.Name = "cmbStudent";
            cmbStudent.Size = new Size(1019, 39);
            cmbStudent.TabIndex = 2;
            // 
            // lblSelectAssessment
            // 
            lblSelectAssessment.AutoSize = true;
            lblSelectAssessment.Location = new Point(80, 342);
            lblSelectAssessment.Margin = new Padding(6, 0, 6, 0);
            lblSelectAssessment.Name = "lblSelectAssessment";
            lblSelectAssessment.Size = new Size(198, 30);
            lblSelectAssessment.TabIndex = 3;
            lblSelectAssessment.Text = "Select Assessment *";
            // 
            // cmbAssessment
            // 
            cmbAssessment.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAssessment.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbAssessment.Location = new Point(80, 380);
            cmbAssessment.Margin = new Padding(6, 7, 6, 7);
            cmbAssessment.Name = "cmbAssessment";
            cmbAssessment.Size = new Size(1019, 39);
            cmbAssessment.TabIndex = 4;
            // 
            // lblComponents
            // 
            lblComponents.AutoSize = true;
            lblComponents.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblComponents.ForeColor = Color.Gray;
            lblComponents.Location = new Point(80, 426);
            lblComponents.Margin = new Padding(6, 0, 6, 0);
            lblComponents.Name = "lblComponents";
            lblComponents.Size = new Size(422, 32);
            lblComponents.TabIndex = 5;
            lblComponents.Text = "Components — assign a level to each:";
            lblComponents.Click += lblComponents_Click;
            // 
            // pnlComponentsHeader
            // 
            pnlComponentsHeader.BackColor = Color.FromArgb(30, 50, 90);
            pnlComponentsHeader.Controls.Add(lblColComponent);
            pnlComponentsHeader.Controls.Add(lblColRubric);
            pnlComponentsHeader.Controls.Add(lblColMax);
            pnlComponentsHeader.Controls.Add(lblColLevel);
            pnlComponentsHeader.Controls.Add(lblColMarks);
            pnlComponentsHeader.Location = new Point(80, 465);
            pnlComponentsHeader.Margin = new Padding(6, 7, 6, 7);
            pnlComponentsHeader.Name = "pnlComponentsHeader";
            pnlComponentsHeader.Size = new Size(1020, 54);
            pnlComponentsHeader.TabIndex = 6;
            // 
            // lblColComponent
            // 
            lblColComponent.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblColComponent.ForeColor = Color.White;
            lblColComponent.Location = new Point(15, 12);
            lblColComponent.Margin = new Padding(4, 0, 4, 0);
            lblColComponent.Name = "lblColComponent";
            lblColComponent.Size = new Size(216, 30);
            lblColComponent.TabIndex = 0;
            lblColComponent.Text = "Component";
            // 
            // lblColRubric
            // 
            lblColRubric.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblColRubric.ForeColor = Color.White;
            lblColRubric.Location = new Point(312, 12);
            lblColRubric.Margin = new Padding(4, 0, 4, 0);
            lblColRubric.Name = "lblColRubric";
            lblColRubric.Size = new Size(144, 30);
            lblColRubric.TabIndex = 1;
            lblColRubric.Text = "Rubric";
            // 
            // lblColMax
            // 
            lblColMax.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblColMax.ForeColor = Color.White;
            lblColMax.Location = new Point(516, 12);
            lblColMax.Margin = new Padding(4, 0, 4, 0);
            lblColMax.Name = "lblColMax";
            lblColMax.Size = new Size(72, 30);
            lblColMax.TabIndex = 2;
            lblColMax.Text = "Max";
            // 
            // lblColLevel
            // 
            lblColLevel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblColLevel.ForeColor = Color.White;
            lblColLevel.Location = new Point(636, 12);
            lblColLevel.Margin = new Padding(4, 0, 4, 0);
            lblColLevel.Name = "lblColLevel";
            lblColLevel.Size = new Size(240, 30);
            lblColLevel.TabIndex = 3;
            lblColLevel.Text = "Level";
            // 
            // lblColMarks
            // 
            lblColMarks.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblColMarks.ForeColor = Color.White;
            lblColMarks.Location = new Point(912, 12);
            lblColMarks.Margin = new Padding(4, 0, 4, 0);
            lblColMarks.Name = "lblColMarks";
            lblColMarks.Size = new Size(96, 30);
            lblColMarks.TabIndex = 4;
            lblColMarks.Text = "Marks";
            // 
            // pnlComponentsBody
            // 
            pnlComponentsBody.AutoScroll = true;
            pnlComponentsBody.BackColor = Color.FromArgb(240, 238, 232);
            pnlComponentsBody.BorderStyle = BorderStyle.FixedSingle;
            pnlComponentsBody.Location = new Point(80, 564);
            pnlComponentsBody.Margin = new Padding(6, 7, 6, 7);
            pnlComponentsBody.Name = "pnlComponentsBody";
            pnlComponentsBody.Size = new Size(1020, 336);
            pnlComponentsBody.TabIndex = 7;
            // 
            // pnlTotalMarks
            // 
            pnlTotalMarks.BackColor = Color.FromArgb(220, 230, 245);
            pnlTotalMarks.BorderStyle = BorderStyle.FixedSingle;
            pnlTotalMarks.Controls.Add(lblTotalObtained);
            pnlTotalMarks.Controls.Add(lblTotalValue);
            pnlTotalMarks.Location = new Point(80, 914);
            pnlTotalMarks.Margin = new Padding(6, 7, 6, 7);
            pnlTotalMarks.Name = "pnlTotalMarks";
            pnlTotalMarks.Size = new Size(1020, 66);
            pnlTotalMarks.TabIndex = 8;
            // 
            // lblTotalObtained
            // 
            lblTotalObtained.AutoSize = true;
            lblTotalObtained.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalObtained.Location = new Point(14, 17);
            lblTotalObtained.Margin = new Padding(4, 0, 4, 0);
            lblTotalObtained.Name = "lblTotalObtained";
            lblTotalObtained.Size = new Size(247, 32);
            lblTotalObtained.TabIndex = 0;
            lblTotalObtained.Text = "Total Obtained Marks:";
            // 
            // lblTotalValue
            // 
            lblTotalValue.AutoSize = true;
            lblTotalValue.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalValue.ForeColor = Color.FromArgb(30, 50, 90);
            lblTotalValue.Location = new Point(816, 14);
            lblTotalValue.Margin = new Padding(4, 0, 4, 0);
            lblTotalValue.Name = "lblTotalValue";
            lblTotalValue.Size = new Size(89, 38);
            lblTotalValue.TabIndex = 1;
            lblTotalValue.Text = "0 / —";
            // 
            // btnSaveEvaluation
            // 
            btnSaveEvaluation.BackColor = Color.FromArgb(30, 50, 90);
            btnSaveEvaluation.FlatStyle = FlatStyle.Flat;
            btnSaveEvaluation.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSaveEvaluation.ForeColor = Color.White;
            btnSaveEvaluation.Location = new Point(70, 974);
            btnSaveEvaluation.Margin = new Padding(6, 7, 6, 7);
            btnSaveEvaluation.Name = "btnSaveEvaluation";
            btnSaveEvaluation.Size = new Size(1030, 69);
            btnSaveEvaluation.TabIndex = 9;
            btnSaveEvaluation.Text = "Save Evaluation";
            btnSaveEvaluation.UseVisualStyleBackColor = false;
            // 
            // lblFormula
            // 
            lblFormula.AutoSize = true;
            lblFormula.ForeColor = Color.Gray;
            lblFormula.Location = new Point(80, 1152);
            lblFormula.Margin = new Padding(6, 0, 6, 0);
            lblFormula.Name = "lblFormula";
            lblFormula.Size = new Size(454, 30);
            lblFormula.TabIndex = 10;
            lblFormula.Text = "Marks = (Level / MaxLevel) x Component Marks";
            // 
            // MarkEvaluation
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 238, 232);
            ClientSize = new Size(1200, 1044);
            Controls.Add(pnlHeader);
            Controls.Add(lblSelectStudent);
            Controls.Add(cmbStudent);
            Controls.Add(lblSelectAssessment);
            Controls.Add(cmbAssessment);
            Controls.Add(lblComponents);
            Controls.Add(pnlComponentsHeader);
            Controls.Add(pnlComponentsBody);
            Controls.Add(pnlTotalMarks);
            Controls.Add(btnSaveEvaluation);
            Controls.Add(lblFormula);
            Margin = new Padding(6, 7, 6, 7);
            Name = "MarkEvaluation";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mark Evaluation";
            pnlHeader.ResumeLayout(false);
            pnlComponentsHeader.ResumeLayout(false);
            pnlTotalMarks.ResumeLayout(false);
            pnlTotalMarks.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
        private Label lblTitle;
        private Label lblSelectStudent;
        private ComboBox cmbStudent;
        private Label lblSelectAssessment;
        private ComboBox cmbAssessment;
        private Label lblComponents;
        private Panel pnlComponentsHeader;
        private Label lblColComponent;
        private Label lblColRubric;
        private Label lblColMax;
        private Label lblColLevel;
        private Label lblColMarks;
        private Panel pnlComponentsBody;
        private Panel pnlTotalMarks;
        private Label lblTotalObtained;
        private Label lblTotalValue;
        private Button btnSaveEvaluation;
        private Label lblFormula;
    }
}