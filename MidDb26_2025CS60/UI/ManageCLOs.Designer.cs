

namespace MidDb26_2025CS60.Forms
{
    partial class ManageCLOs: Form
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
            lblSubtitle = new Label();
            lblTitle = new Label();
            pnlBody = new Panel();
            lnkAddCLO = new LinkLabel();
            pnlRows = new FlowLayoutPanel();
            pnlColumnHeaders = new Panel();
            lblColHash = new Label();
            lblColCLOName = new Label();
            lblColAction = new Label();
            pnlFooter = new Panel();
            btnSave = new Button();
            pnlHeader.SuspendLayout();
            pnlBody.SuspendLayout();
            pnlColumnHeaders.SuspendLayout();
            pnlFooter.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.MidnightBlue;
            pnlHeader.Controls.Add(lblSubtitle);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(700, 75);
            pnlHeader.TabIndex = 0;
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitle.ForeColor = Color.LightSteelBlue;
            lblSubtitle.Location = new Point(20, 45);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(441, 25);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "All CLOs shown below. Edit, remove, or add new ones.";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(20, 10);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(194, 38);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Manage CLOs";
            // 
            // pnlBody
            // 
            pnlBody.BackColor = Color.White;
            pnlBody.BorderStyle = BorderStyle.FixedSingle;
            pnlBody.Controls.Add(lnkAddCLO);
            pnlBody.Controls.Add(pnlRows);
            pnlBody.Controls.Add(pnlColumnHeaders);
            pnlBody.Location = new Point(20, 90);
            pnlBody.Name = "pnlBody";
            pnlBody.Size = new Size(660, 380);
            pnlBody.TabIndex = 1;
            // 
            // lnkAddCLO
            // 
            lnkAddCLO.ActiveLinkColor = Color.MidnightBlue;
            lnkAddCLO.AutoSize = true;
            lnkAddCLO.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lnkAddCLO.LinkColor = Color.MidnightBlue;
            lnkAddCLO.Location = new Point(10, 335);
            lnkAddCLO.Name = "lnkAddCLO";
            lnkAddCLO.Size = new Size(105, 28);
            lnkAddCLO.TabIndex = 2;
            lnkAddCLO.TabStop = true;
            lnkAddCLO.Text = "+ add CLO";
            lnkAddCLO.LinkClicked += lnkAddCLO_LinkClicked;
            // 
            // pnlRows
            // 
            pnlRows.AutoScroll = true;
            pnlRows.BackColor = Color.White;
            pnlRows.FlowDirection = FlowDirection.TopDown;
            pnlRows.Location = new Point(0, 35);
            pnlRows.Name = "pnlRows";
            pnlRows.Size = new Size(658, 290);
            pnlRows.TabIndex = 1;
            pnlRows.WrapContents = false;           
            // 
            // pnlColumnHeaders
            // 
            pnlColumnHeaders.BackColor = Color.FromArgb(240, 238, 232);
            pnlColumnHeaders.Controls.Add(lblColHash);
            pnlColumnHeaders.Controls.Add(lblColCLOName);
            pnlColumnHeaders.Controls.Add(lblColAction);
            pnlColumnHeaders.Dock = DockStyle.Top;
            pnlColumnHeaders.Location = new Point(0, 0);
            pnlColumnHeaders.Name = "pnlColumnHeaders";
            pnlColumnHeaders.Size = new Size(658, 35);
            pnlColumnHeaders.TabIndex = 0;
            // 
            // lblColHash
            // 
            lblColHash.AutoSize = true;
            lblColHash.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblColHash.ForeColor = Color.DimGray;
            lblColHash.Location = new Point(10, 8);
            lblColHash.Name = "lblColHash";
            lblColHash.Size = new Size(23, 25);
            lblColHash.TabIndex = 0;
            lblColHash.Text = "#";
            // 
            // lblColCLOName
            // 
            lblColCLOName.AutoSize = true;
            lblColCLOName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblColCLOName.ForeColor = Color.DimGray;
            lblColCLOName.Location = new Point(55, 8);
            lblColCLOName.Name = "lblColCLOName";
            lblColCLOName.Size = new Size(101, 25);
            lblColCLOName.TabIndex = 1;
            lblColCLOName.Text = "CLO Name";
            // 
            // lblColAction
            // 
            lblColAction.AutoSize = true;
            lblColAction.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblColAction.ForeColor = Color.DimGray;
            lblColAction.Location = new Point(565, 8);
            lblColAction.Name = "lblColAction";
            lblColAction.Size = new Size(68, 25);
            lblColAction.TabIndex = 2;
            lblColAction.Text = "Action";
            // 
            // pnlFooter
            // 
            pnlFooter.BackColor = Color.White;
            pnlFooter.BorderStyle = BorderStyle.FixedSingle;
            pnlFooter.Controls.Add(btnSave);
            pnlFooter.Location = new Point(20, 482);
            pnlFooter.Name = "pnlFooter";
            pnlFooter.Size = new Size(660, 60);
            pnlFooter.TabIndex = 2;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.MidnightBlue;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(10, 10);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(180, 40);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save All CLOs";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // ManageCLOs
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 238, 232);
            ClientSize = new Size(700, 560);
            Controls.Add(pnlHeader);
            Controls.Add(pnlBody);
            Controls.Add(pnlFooter);
            Name = "ManageCLOs";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manage CLOs";
            Load += ManageCLOsForm_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlBody.ResumeLayout(false);
            pnlBody.PerformLayout();
            pnlColumnHeaders.ResumeLayout(false);
            pnlColumnHeaders.PerformLayout();
            pnlFooter.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lblTitle;
        private Label lblSubtitle;
        private Panel pnlBody;
        private Panel pnlColumnHeaders;
        private Label lblColHash;
        private Label lblColCLOName;
        private Label lblColAction;
        private FlowLayoutPanel pnlRows;
        private LinkLabel lnkAddCLO;
        private Panel pnlFooter;
        private Button btnSave;
    }
}