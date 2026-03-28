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
            lblTitle.Text = "Mark Evaluation";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSelectStudent
            // 
            lblSelectStudent.AutoSize = true;
            lblSelectStudent.Location = new Point(67, 183);
            lblSelectStudent.Margin = new Padding(5, 0, 5, 0);
            lblSelectStudent.Name = "lblSelectStudent";
            lblSelectStudent.Size = new Size(135, 25);
            lblSelectStudent.TabIndex = 1;
            lblSelectStudent.Text = "Select Student *";
            // 
            // cmbStudent
            // 
            cmbStudent.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStudent.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbStudent.Location = new Point(67, 214);
            cmbStudent.Margin = new Padding(5, 6, 5, 6);
            cmbStudent.Name = "cmbStudent";
            cmbStudent.Size = new Size(850, 31);
            cmbStudent.TabIndex = 2;
           
            // 
            // lblSelectAssessment
            // 
            lblSelectAssessment.AutoSize = true;
            lblSelectAssessment.Location = new Point(67, 285);
            lblSelectAssessment.Margin = new Padding(5, 0, 5, 0);
            lblSelectAssessment.Name = "lblSelectAssessment";
            lblSelectAssessment.Size = new Size(160, 25);
            lblSelectAssessment.TabIndex = 3;
            lblSelectAssessment.Text = "Select Assessment *";
            // 
            // cmbAssessment
            // 
            cmbAssessment.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAssessment.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbAssessment.Location = new Point(67, 317);
            cmbAssessment.Margin = new Padding(5, 6, 5, 6);
            cmbAssessment.Name = "cmbAssessment";
            cmbAssessment.Size = new Size(850, 31);
            cmbAssessment.TabIndex = 4;
            
            // 
            // lblComponents
            // 
            lblComponents.AutoSize = true;
            lblComponents.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblComponents.ForeColor = Color.Gray;
            lblComponents.Location = new Point(67, 390);
            lblComponents.Margin = new Padding(5, 0, 5, 0);
            lblComponents.Name = "lblComponents";
            lblComponents.Size = new Size(245, 25);
            lblComponents.TabIndex = 5;
            lblComponents.Text = "Components — assign a level to each:";
            // 
            // pnlComponentsHeader
            // 
            pnlComponentsHeader.BackColor = Color.FromArgb(30, 50, 90);
            pnlComponentsHeader.Controls.Add(lblColComponent);
            pnlComponentsHeader.Controls.Add(lblColRubric);
            pnlComponentsHeader.Controls.Add(lblColMax);
            pnlComponentsHeader.Controls.Add(lblColLevel);
            pnlComponentsHeader.Controls.Add(lblColMarks);
            pnlComponentsHeader.Location = new Point(67, 425);
            pnlComponentsHeader.Margin = new Padding(5, 6, 5, 6);
            pnlComponentsHeader.Name = "pnlComponentsHeader";
            pnlComponentsHeader.Size = new Size(850, 45);
            pnlComponentsHeader.TabIndex = 6;
            // 
            // lblColComponent
            // 
            lblColComponent.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblColComponent.ForeColor = Color.White;
            lblColComponent.Location = new Point(10, 10);
            lblColComponent.Name = "lblColComponent";
            lblColComponent.Size = new Size(180, 25);
            lblColComponent.TabIndex = 0;
            lblColComponent.Text = "Component";
            // 
            // lblColRubric
            // 
            lblColRubric.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblColRubric.ForeColor = Color.White;
            lblColRubric.Location = new Point(260, 10);
            lblColRubric.Name = "lblColRubric";
            lblColRubric.Size = new Size(120, 25);
            lblColRubric.TabIndex = 1;
            lblColRubric.Text = "Rubric";
            // 
            // lblColMax
            // 
            lblColMax.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblColMax.ForeColor = Color.White;
            lblColMax.Location = new Point(430, 10);
            lblColMax.Name = "lblColMax";
            lblColMax.Size = new Size(60, 25);
            lblColMax.TabIndex = 2;
            lblColMax.Text = "Max";
            // 
            // lblColLevel
            // 
            lblColLevel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblColLevel.ForeColor = Color.White;
            lblColLevel.Location = new Point(530, 10);
            lblColLevel.Name = "lblColLevel";
            lblColLevel.Size = new Size(200, 25);
            lblColLevel.TabIndex = 3;
            lblColLevel.Text = "Level";
            // 
            // lblColMarks
            // 
            lblColMarks.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblColMarks.ForeColor = Color.White;
            lblColMarks.Location = new Point(760, 10);
            lblColMarks.Name = "lblColMarks";
            lblColMarks.Size = new Size(80, 25);
            lblColMarks.TabIndex = 4;
            lblColMarks.Text = "Marks";
            // 
            // pnlComponentsBody
            // 
            pnlComponentsBody.AutoScroll = true;
            pnlComponentsBody.BackColor = Color.FromArgb(240, 238, 232);
            pnlComponentsBody.BorderStyle = BorderStyle.FixedSingle;
            pnlComponentsBody.Location = new Point(67, 470);
            pnlComponentsBody.Margin = new Padding(5, 6, 5, 6);
            pnlComponentsBody.Name = "pnlComponentsBody";
            pnlComponentsBody.Size = new Size(850, 280);
            pnlComponentsBody.TabIndex = 7;
            // 
            // pnlTotalMarks
            // 
            pnlTotalMarks.BackColor = Color.FromArgb(220, 230, 245);
            pnlTotalMarks.BorderStyle = BorderStyle.FixedSingle;
            pnlTotalMarks.Controls.Add(lblTotalObtained);
            pnlTotalMarks.Controls.Add(lblTotalValue);
            pnlTotalMarks.Location = new Point(67, 770);
            pnlTotalMarks.Margin = new Padding(5, 6, 5, 6);
            pnlTotalMarks.Name = "pnlTotalMarks";
            pnlTotalMarks.Size = new Size(850, 55);
            pnlTotalMarks.TabIndex = 8;
            // 
            // lblTotalObtained
            // 
            lblTotalObtained.AutoSize = true;
            lblTotalObtained.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalObtained.Location = new Point(12, 14);
            lblTotalObtained.Name = "lblTotalObtained";
            lblTotalObtained.Size = new Size(185, 25);
            lblTotalObtained.TabIndex = 0;
            lblTotalObtained.Text = "Total Obtained Marks:";
            // 
            // lblTotalValue
            // 
            lblTotalValue.AutoSize = true;
            lblTotalValue.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalValue.ForeColor = Color.FromArgb(30, 50, 90);
            lblTotalValue.Location = new Point(680, 12);
            lblTotalValue.Name = "lblTotalValue";
            lblTotalValue.Size = new Size(80, 32);
            lblTotalValue.TabIndex = 1;
            lblTotalValue.Text = "0 / —";
            // 
            // btnSaveEvaluation
            // 
            btnSaveEvaluation.BackColor = Color.FromArgb(30, 50, 90);
            btnSaveEvaluation.FlatStyle = FlatStyle.Flat;
            btnSaveEvaluation.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSaveEvaluation.ForeColor = Color.White;
            btnSaveEvaluation.Location = new Point(67, 855);
            btnSaveEvaluation.Margin = new Padding(5, 6, 5, 6);
            btnSaveEvaluation.Name = "btnSaveEvaluation";
            btnSaveEvaluation.Size = new Size(850, 87);
            btnSaveEvaluation.TabIndex = 9;
            btnSaveEvaluation.Text = "Save Evaluation";
            btnSaveEvaluation.UseVisualStyleBackColor = false;
            
            // lblFormula
            // 
            lblFormula.AutoSize = true;
            lblFormula.ForeColor = Color.Gray;
            lblFormula.Location = new Point(67, 960);
            lblFormula.Margin = new Padding(5, 0, 5, 0);
            lblFormula.Name = "lblFormula";
            lblFormula.Size = new Size(340, 25);
            lblFormula.TabIndex = 10;
            lblFormula.Text = "Marks = (Level / MaxLevel) x Component Marks";
            // 
            // MarkEvaluation
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 238, 232);
            ClientSize = new Size(1000, 1010);
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
            Margin = new Padding(5, 6, 5, 6);
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