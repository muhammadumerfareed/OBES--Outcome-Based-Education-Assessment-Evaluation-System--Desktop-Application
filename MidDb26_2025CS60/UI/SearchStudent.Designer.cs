
namespace MidDb26_2025CS60.Forms
{
    partial class SearchStudent: Form
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
            txtRegNo = new TextBox();
            btnSearch = new Button();
            lvResult = new ListView();
            colField = new ColumnHeader();
            colValue = new ColumnHeader();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.MidnightBlue;
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
            lblTitle.Text = "Search Student";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtRegNo
            // 
            txtRegNo.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRegNo.ForeColor = Color.Gray;
            txtRegNo.Location = new Point(30, 95);
            txtRegNo.Name = "txtRegNo";
            txtRegNo.Size = new Size(440, 34);
            txtRegNo.TabIndex = 1;
            txtRegNo.Text = "Enter Reg No...";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.MidnightBlue;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(480, 92);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(110, 37);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // lvResult
            // 
            lvResult.BackColor = Color.White;
            lvResult.BorderStyle = BorderStyle.FixedSingle;
            lvResult.Columns.AddRange(new ColumnHeader[] { colField, colValue });
            lvResult.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lvResult.FullRowSelect = true;
            lvResult.GridLines = true;
            lvResult.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            lvResult.Location = new Point(30, 140);
            lvResult.Name = "lvResult";
            lvResult.Size = new Size(560, 230);
            lvResult.TabIndex = 3;
            lvResult.UseCompatibleStateImageBehavior = false;
            lvResult.View = View.Details;
            lvResult.Visible = false;
            lvResult.SelectedIndexChanged += lvResult_SelectedIndexChanged;
            // 
            // colField
            // 
            colField.Text = "Field";
            colField.Width = 180;
            // 
            // colValue
            // 
            colValue.Text = "Value";
            colValue.Width = 350;
            // 
            // SearchStudent
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 238, 232);
            ClientSize = new Size(624, 400);
            Controls.Add(pnlHeader);
            Controls.Add(txtRegNo);
            Controls.Add(btnSearch);
            Controls.Add(lvResult);
            Name = "SearchStudent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Search Student";
            pnlHeader.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
        private Label lblTitle;
        private TextBox txtRegNo;
        private Button btnSearch;
        private ListView lvResult;
        private ColumnHeader colField;
        private ColumnHeader colValue;
    }
}