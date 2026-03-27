using Org.BouncyCastle.Asn1.Crmf;
using System.Drawing.Printing;
using System.Xml.Linq;


namespace MidDb26_2025CS60.Forms
{
    partial class AddQuestions:Form
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
            pnlInfo = new Panel();
            lblAssessmentName = new Label();
            lblMarksInfo = new Label();
            pnlQuestionsHeader = new Panel();
            lblColNum = new Label();
            lblColName = new Label();
            lblColRubric = new Label();
            lblColMarks = new Label();
            lblColRemove = new Label();
            pnlQuestionsBody = new Panel();
            lnkAddQuestion = new LinkLabel();
            pnlMarksUsed = new Panel();
            lblMarksUsed = new Label();
            lblMarksUsedValue = new Label();
            btnSaveQuestions = new Button();
            btnSkip = new Button();
            lblRequired = new Label();
            pnlHeader.SuspendLayout();
            pnlInfo.SuspendLayout();
            pnlQuestionsHeader.SuspendLayout();
            pnlMarksUsed.SuspendLayout();
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
            lblTitle.Text = "Add Questions";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlInfo
            // 
            pnlInfo.BackColor = Color.FromArgb(220, 230, 245);
            pnlInfo.BorderStyle = BorderStyle.FixedSingle;
            pnlInfo.Controls.Add(lblAssessmentName);
            pnlInfo.Controls.Add(lblMarksInfo);
            pnlInfo.Location = new Point(67, 175);
            pnlInfo.Margin = new Padding(5, 6, 5, 6);
            pnlInfo.Name = "pnlInfo";
            pnlInfo.Size = new Size(850, 55);
            pnlInfo.TabIndex = 1;
        
            // 
            // lblAssessmentName
            // 
            lblAssessmentName.AutoSize = true;
            lblAssessmentName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAssessmentName.Location = new Point(12, 14);
            lblAssessmentName.Name = "lblAssessmentName";
            lblAssessmentName.Size = new Size(141, 28);
            lblAssessmentName.TabIndex = 0;
            lblAssessmentName.Text = "Assessment: —";
            // 
            // lblMarksInfo
            // 
            lblMarksInfo.AutoSize = true;
            lblMarksInfo.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMarksInfo.Location = new Point(450, 14);
            lblMarksInfo.Name = "lblMarksInfo";
            lblMarksInfo.Size = new Size(414, 28);
            lblMarksInfo.TabIndex = 1;
            lblMarksInfo.Text = "Total Marks: — | Marks Used: 0 | Remaining: —";
            // 
            // pnlQuestionsHeader
            // 
            pnlQuestionsHeader.BackColor = Color.FromArgb(30, 50, 90);
            pnlQuestionsHeader.Controls.Add(lblColNum);
            pnlQuestionsHeader.Controls.Add(lblColName);
            pnlQuestionsHeader.Controls.Add(lblColRubric);
            pnlQuestionsHeader.Controls.Add(lblColMarks);
            pnlQuestionsHeader.Controls.Add(lblColRemove);
            pnlQuestionsHeader.Location = new Point(67, 255);
            pnlQuestionsHeader.Margin = new Padding(5, 6, 5, 6);
            pnlQuestionsHeader.Name = "pnlQuestionsHeader";
            pnlQuestionsHeader.Size = new Size(850, 45);
            pnlQuestionsHeader.TabIndex = 2;
            // 
            // lblColNum
            // 
            lblColNum.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblColNum.ForeColor = Color.White;
            lblColNum.Location = new Point(5, 10);
            lblColNum.Name = "lblColNum";
            lblColNum.Size = new Size(40, 25);
            lblColNum.TabIndex = 0;
            lblColNum.Text = "#";
            // 
            // lblColName
            // 
            lblColName.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblColName.ForeColor = Color.White;
            lblColName.Location = new Point(55, 10);
            lblColName.Name = "lblColName";
            lblColName.Size = new Size(260, 25);
            lblColName.TabIndex = 1;
            lblColName.Text = "Question / Component Name";
            // 
            // lblColRubric
            // 
            lblColRubric.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblColRubric.ForeColor = Color.White;
            lblColRubric.Location = new Point(330, 10);
            lblColRubric.Name = "lblColRubric";
            lblColRubric.Size = new Size(180, 25);
            lblColRubric.TabIndex = 2;
            lblColRubric.Text = "Rubric";
            // 
            // lblColMarks
            // 
            lblColMarks.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblColMarks.ForeColor = Color.White;
            lblColMarks.Location = new Point(620, 10);
            lblColMarks.Name = "lblColMarks";
            lblColMarks.Size = new Size(100, 25);
            lblColMarks.TabIndex = 3;
            lblColMarks.Text = "Marks";
            // 
            // lblColRemove
            // 
            lblColRemove.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblColRemove.ForeColor = Color.White;
            lblColRemove.Location = new Point(760, 10);
            lblColRemove.Name = "lblColRemove";
            lblColRemove.Size = new Size(80, 25);
            lblColRemove.TabIndex = 4;
            lblColRemove.Text = "Remove";
            // 
            // pnlQuestionsBody
            // 
            pnlQuestionsBody.AutoScroll = true;
            pnlQuestionsBody.BackColor = Color.FromArgb(240, 238, 232);
            pnlQuestionsBody.BorderStyle = BorderStyle.FixedSingle;
            pnlQuestionsBody.Location = new Point(67, 300);
            pnlQuestionsBody.Margin = new Padding(5, 6, 5, 6);
            pnlQuestionsBody.Name = "pnlQuestionsBody";
            pnlQuestionsBody.Size = new Size(850, 300);
            pnlQuestionsBody.TabIndex = 3;
            // 
            // lnkAddQuestion
            // 
            lnkAddQuestion.AutoSize = true;
            lnkAddQuestion.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lnkAddQuestion.LinkColor = Color.FromArgb(30, 50, 90);
            lnkAddQuestion.Location = new Point(67, 615);
            lnkAddQuestion.Margin = new Padding(5, 0, 5, 0);
            lnkAddQuestion.Name = "lnkAddQuestion";
            lnkAddQuestion.Size = new Size(146, 28);
            lnkAddQuestion.TabIndex = 4;
            lnkAddQuestion.TabStop = true;
            lnkAddQuestion.Text = "+ add question";
            // 
            // pnlMarksUsed
            // 
            pnlMarksUsed.BackColor = Color.FromArgb(220, 230, 245);
            pnlMarksUsed.BorderStyle = BorderStyle.FixedSingle;
            pnlMarksUsed.Controls.Add(lblMarksUsed);
            pnlMarksUsed.Controls.Add(lblMarksUsedValue);
            pnlMarksUsed.Location = new Point(67, 660);
            pnlMarksUsed.Margin = new Padding(5, 6, 5, 6);
            pnlMarksUsed.Name = "pnlMarksUsed";
            pnlMarksUsed.Size = new Size(850, 55);
            pnlMarksUsed.TabIndex = 5;
            // 
            // lblMarksUsed
            // 
            lblMarksUsed.AutoSize = true;
            lblMarksUsed.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMarksUsed.Location = new Point(12, 14);
            lblMarksUsed.Name = "lblMarksUsed";
            lblMarksUsed.Size = new Size(198, 28);
            lblMarksUsed.TabIndex = 0;
            lblMarksUsed.Text = "Marks used out of —:";
            // 
            // lblMarksUsedValue
            // 
            lblMarksUsedValue.AutoSize = true;
            lblMarksUsedValue.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMarksUsedValue.ForeColor = Color.FromArgb(30, 50, 90);
            lblMarksUsedValue.Location = new Point(700, 14);
            lblMarksUsedValue.Name = "lblMarksUsedValue";
            lblMarksUsedValue.Size = new Size(65, 28);
            lblMarksUsedValue.TabIndex = 1;
            lblMarksUsedValue.Text = "0 / —";
            // 
            // btnSaveQuestions
            // 
            btnSaveQuestions.BackColor = Color.FromArgb(30, 50, 90);
            btnSaveQuestions.FlatStyle = FlatStyle.Flat;
            btnSaveQuestions.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSaveQuestions.ForeColor = Color.White;
            btnSaveQuestions.Location = new Point(67, 745);
            btnSaveQuestions.Margin = new Padding(5, 6, 5, 6);
            btnSaveQuestions.Name = "btnSaveQuestions";
            btnSaveQuestions.Size = new Size(614, 87);
            btnSaveQuestions.TabIndex = 6;
            btnSaveQuestions.Text = "Save Questions";
            btnSaveQuestions.UseVisualStyleBackColor = false;
            // 
            // btnSkip
            // 
            btnSkip.BackColor = Color.FromArgb(200, 198, 192);
            btnSkip.FlatStyle = FlatStyle.Flat;
            btnSkip.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSkip.ForeColor = Color.FromArgb(30, 50, 90);
            btnSkip.Location = new Point(695, 745);
            btnSkip.Margin = new Padding(5, 6, 5, 6);
            btnSkip.Name = "btnSkip";
            btnSkip.Size = new Size(222, 87);
            btnSkip.TabIndex = 7;
            btnSkip.Text = "Skip for now";
            btnSkip.UseVisualStyleBackColor = false;
            // 
            // lblRequired
            // 
            lblRequired.AutoSize = true;
            lblRequired.ForeColor = Color.Gray;
            lblRequired.Location = new Point(67, 850);
            lblRequired.Margin = new Padding(5, 0, 5, 0);
            lblRequired.Name = "lblRequired";
            lblRequired.Size = new Size(155, 25);
            lblRequired.TabIndex = 8;
            lblRequired.Text = "* = required fields";
            // 
            // AddQuestions
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 238, 232);
            ClientSize = new Size(1000, 920);
            Controls.Add(pnlHeader);
            Controls.Add(pnlInfo);
            Controls.Add(pnlQuestionsHeader);
            Controls.Add(pnlQuestionsBody);
            Controls.Add(lnkAddQuestion);
            Controls.Add(pnlMarksUsed);
            Controls.Add(btnSaveQuestions);
            Controls.Add(btnSkip);
            Controls.Add(lblRequired);
            Margin = new Padding(5, 6, 5, 6);
            Name = "AddQuestions";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Questions";
            pnlHeader.ResumeLayout(false);
            pnlInfo.ResumeLayout(false);
            pnlInfo.PerformLayout();
            pnlQuestionsHeader.ResumeLayout(false);
            pnlMarksUsed.ResumeLayout(false);
            pnlMarksUsed.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
        private Label lblTitle;
        private Panel pnlInfo;
        private Label lblAssessmentName;
        private Label lblMarksInfo;
        private Panel pnlQuestionsHeader;
        private Label lblColNum;
        private Label lblColName;
        private Label lblColRubric;
        private Label lblColMarks;
        private Label lblColRemove;
        private Panel pnlQuestionsBody;
        private LinkLabel lnkAddQuestion;
        private Panel pnlMarksUsed;
        private Label lblMarksUsed;
        private Label lblMarksUsedValue;
        private Button btnSaveQuestions;
        private Button btnSkip;
        private Label lblRequired;
    }
}