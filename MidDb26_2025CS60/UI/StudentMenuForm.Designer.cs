namespace MidDb26_2025CS60.Forms
{
    partial class StudentMenuForm
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
            lblStudentManagement = new Label();
            btnAdd = new Button();
            btnEdit = new Button();
            btnSearch = new Button();
            btnDelete = new Button();
            btnAttendance = new Button();
            SuspendLayout();
            // 
            // lblStudentManagement
            // 
            lblStudentManagement.AutoSize = true;
            lblStudentManagement.BackColor = Color.MidnightBlue;
            lblStudentManagement.FlatStyle = FlatStyle.Flat;
            lblStudentManagement.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStudentManagement.ForeColor = Color.White;
            lblStudentManagement.Location = new Point(244, 42);
            lblStudentManagement.Name = "lblStudentManagement";
            lblStudentManagement.Size = new Size(343, 45);
            lblStudentManagement.TabIndex = 0;
            lblStudentManagement.Text = "Student Management";
            lblStudentManagement.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.MidnightBlue;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.WhiteSmoke;
            btnAdd.Location = new Point(275, 107);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(250, 48);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add Student";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.MidnightBlue;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnEdit.ForeColor = Color.WhiteSmoke;
            btnEdit.Location = new Point(275, 169);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(250, 48);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Edit Student";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.MidnightBlue;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnSearch.ForeColor = Color.WhiteSmoke;
            btnSearch.Location = new Point(275, 228);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(250, 48);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search Student";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Brown;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnDelete.ForeColor = Color.WhiteSmoke;
            btnDelete.Location = new Point(275, 293);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(250, 48);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete Student";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAttendance
            // 
            btnAttendance.BackColor = Color.MidnightBlue;
            btnAttendance.FlatStyle = FlatStyle.Flat;
            btnAttendance.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnAttendance.ForeColor = Color.WhiteSmoke;
            btnAttendance.Location = new Point(275, 357);
            btnAttendance.Name = "btnAttendance";
            btnAttendance.Size = new Size(250, 48);
            btnAttendance.TabIndex = 5;
            btnAttendance.Text = "Mark Attendance";
            btnAttendance.UseVisualStyleBackColor = false;
            btnAttendance.Click += btnAttendance_Click;
            // 
            // StudentMenuForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 238, 232);
            ClientSize = new Size(800, 450);
            Controls.Add(btnAttendance);
            Controls.Add(btnDelete);
            Controls.Add(btnSearch);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(lblStudentManagement);
            Name = "StudentMenuForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StudentManagement";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStudentManagement;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnSearch;
        private Button btnDelete;
        private Button btnAttendance;
    }
}