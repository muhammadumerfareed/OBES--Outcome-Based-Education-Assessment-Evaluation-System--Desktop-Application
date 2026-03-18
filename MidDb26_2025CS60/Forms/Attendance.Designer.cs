

namespace MidDb26_2025CS60.Forms
{
    partial class Attendance: Form
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            pnlHeader = new Panel();
            lblTitle = new Label();
            lblClassDate = new Label();
            dtpClassDate = new DateTimePicker();
            btnLoad = new Button();
            dgvAttendance = new DataGridView();
            colRegNo = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewComboBoxColumn();
            btnSave = new Button();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAttendance).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.MidnightBlue;
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Location = new Point(30, 20);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(620, 55);
            pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(620, 55);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Mark Attendance";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblClassDate
            // 
            lblClassDate.AutoSize = true;
            lblClassDate.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblClassDate.ForeColor = Color.DimGray;
            lblClassDate.Location = new Point(30, 95);
            lblClassDate.Name = "lblClassDate";
            lblClassDate.Size = new Size(105, 28);
            lblClassDate.TabIndex = 1;
            lblClassDate.Text = "Class Date:";
            // 
            // dtpClassDate
            // 
            dtpClassDate.CalendarFont = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpClassDate.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpClassDate.Location = new Point(115, 92);
            dtpClassDate.Name = "dtpClassDate";
            dtpClassDate.Size = new Size(390, 34);
            dtpClassDate.TabIndex = 2;
            // 
            // btnLoad
            // 
            btnLoad.BackColor = Color.MidnightBlue;
            btnLoad.FlatStyle = FlatStyle.Flat;
            btnLoad.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLoad.ForeColor = Color.White;
            btnLoad.Location = new Point(515, 89);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(135, 37);
            btnLoad.TabIndex = 3;
            btnLoad.Text = "Load Students";
            btnLoad.UseVisualStyleBackColor = false;
            // 
            // dgvAttendance
            // 
            dgvAttendance.AllowUserToAddRows = false;
            dgvAttendance.AllowUserToDeleteRows = false;
            dgvAttendance.BackgroundColor = Color.White;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.MidnightBlue;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.MidnightBlue;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvAttendance.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvAttendance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAttendance.Columns.AddRange(new DataGridViewColumn[] { colRegNo, colName, colStatus });
            dgvAttendance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvAttendance.GridColor = Color.LightGray;
            dgvAttendance.Location = new Point(30, 138);
            dgvAttendance.Name = "dgvAttendance";
            dgvAttendance.RowHeadersVisible = false;
            dgvAttendance.RowHeadersWidth = 62;
            dgvAttendance.RowTemplate.Height = 40;
            dgvAttendance.Size = new Size(620, 220);
            dgvAttendance.TabIndex = 4;
            // 
            // colRegNo
            // 
            colRegNo.HeaderText = "Reg No";
            colRegNo.MinimumWidth = 8;
            colRegNo.Name = "colRegNo";
            colRegNo.ReadOnly = true;
            colRegNo.Width = 150;
            // 
            // colName
            // 
            colName.HeaderText = "Name";
            colName.MinimumWidth = 8;
            colName.Name = "colName";
            colName.ReadOnly = true;
            colName.Width = 220;
            // 
            // colStatus
            // 
            colStatus.HeaderText = "Status";
            colStatus.Items.AddRange(new object[] { "Present", "Absent", "Late" });
            colStatus.MinimumWidth = 8;
            colStatus.Name = "colStatus";
            colStatus.Width = 200;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.MidnightBlue;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(30, 372);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(620, 45);
            btnSave.TabIndex = 5;
            btnSave.Text = "Save Attendance";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // Attendance
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 238, 232);
            ClientSize = new Size(684, 440);
            Controls.Add(pnlHeader);
            Controls.Add(lblClassDate);
            Controls.Add(dtpClassDate);
            Controls.Add(btnLoad);
            Controls.Add(dgvAttendance);
            Controls.Add(btnSave);
            Name = "Attendance";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mark Attendance";
            pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAttendance).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
        private Label lblTitle;
        private Label lblClassDate;
        private DateTimePicker dtpClassDate;
        private Button btnLoad;
        private DataGridView dgvAttendance;
        private DataGridViewTextBoxColumn colRegNo;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewComboBoxColumn colStatus;
        private Button btnSave;
    }
}