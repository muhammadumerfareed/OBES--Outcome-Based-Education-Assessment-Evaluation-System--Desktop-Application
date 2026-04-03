
namespace MidDb26_2025CS60.Forms
{
    partial class ManageRubrics:Form
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
            pnlCLOSelect = new Panel();
            lblSelectCLO = new Label();
            cboCLO = new ComboBox();
            btnLoadCLO = new Button();
            pnlBody = new Panel();
            pnlRubrics = new FlowLayoutPanel();
            lnkAddRubric = new LinkLabel();
            pnlFooter = new Panel();
            btnSave = new Button();
            pnlHeader.SuspendLayout();
            pnlCLOSelect.SuspendLayout();
            pnlBody.SuspendLayout();
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
            pnlHeader.Size = new Size(760, 75);
            pnlHeader.TabIndex = 0;
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitle.ForeColor = Color.LightSteelBlue;
            lblSubtitle.Location = new Point(20, 45);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(390, 25);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Select a CLO, then manage its rubrics and levels.";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(20, 10);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(227, 38);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Manage Rubrics";
            // 
            // pnlCLOSelect
            // 
            pnlCLOSelect.BackColor = Color.White;
            pnlCLOSelect.BorderStyle = BorderStyle.FixedSingle;
            pnlCLOSelect.Controls.Add(lblSelectCLO);
            pnlCLOSelect.Controls.Add(cboCLO);
            pnlCLOSelect.Controls.Add(btnLoadCLO);
            pnlCLOSelect.Location = new Point(20, 90);
            pnlCLOSelect.Name = "pnlCLOSelect";
            pnlCLOSelect.Size = new Size(720, 55);
            pnlCLOSelect.TabIndex = 1;
            // 
            // lblSelectCLO
            // 
            lblSelectCLO.AutoSize = true;
            lblSelectCLO.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSelectCLO.ForeColor = Color.DimGray;
            lblSelectCLO.Location = new Point(16, 14);
            lblSelectCLO.Name = "lblSelectCLO";
            lblSelectCLO.Size = new Size(108, 28);
            lblSelectCLO.TabIndex = 0;
            lblSelectCLO.Text = "Select CLO:";
            // 
            // cboCLO
            // 
            cboCLO.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCLO.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboCLO.Location = new Point(130, 10);
            cboCLO.Name = "cboCLO";
            cboCLO.Size = new Size(464, 36);
            cboCLO.TabIndex = 1;
            // 
            // btnLoadCLO
            // 
            btnLoadCLO.BackColor = Color.MidnightBlue;
            btnLoadCLO.FlatStyle = FlatStyle.Flat;
            btnLoadCLO.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLoadCLO.ForeColor = Color.White;
            btnLoadCLO.Location = new Point(600, 10);
            btnLoadCLO.Name = "btnLoadCLO";
            btnLoadCLO.Size = new Size(110, 40);
            btnLoadCLO.TabIndex = 2;
            btnLoadCLO.Text = "Load Rubrics";
            btnLoadCLO.UseVisualStyleBackColor = false;
            // 
            // pnlBody
            // 
            pnlBody.AutoScroll = true;
            pnlBody.BackColor = Color.White;
            pnlBody.BorderStyle = BorderStyle.FixedSingle;
            pnlBody.Controls.Add(pnlRubrics);
            pnlBody.Controls.Add(lnkAddRubric);
            pnlBody.Location = new Point(20, 158);
            pnlBody.Name = "pnlBody";
            pnlBody.Size = new Size(720, 370);
            pnlBody.TabIndex = 2;
            // 
            // pnlRubrics
            // 
            pnlRubrics.BackColor = Color.White;
            pnlRubrics.FlowDirection = FlowDirection.TopDown;
            pnlRubrics.Location = new Point(0, 0);
            pnlRubrics.Name = "pnlRubrics";
            pnlRubrics.Size = new Size(716, 330);
            pnlRubrics.TabIndex = 0;
            pnlRubrics.WrapContents = false;
            // 
            // lnkAddRubric
            // 
            lnkAddRubric.ActiveLinkColor = Color.MidnightBlue;
            lnkAddRubric.AutoSize = true;
            lnkAddRubric.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lnkAddRubric.LinkColor = Color.MidnightBlue;
            lnkAddRubric.Location = new Point(10, 338);
            lnkAddRubric.Name = "lnkAddRubric";
            lnkAddRubric.Size = new Size(121, 28);
            lnkAddRubric.TabIndex = 1;
            lnkAddRubric.TabStop = true;
            lnkAddRubric.Text = "+ add rubric";
            lnkAddRubric.Visible = false;
            // 
            // pnlFooter
            // 
            pnlFooter.BackColor = Color.White;
            pnlFooter.BorderStyle = BorderStyle.FixedSingle;
            pnlFooter.Controls.Add(btnSave);
            pnlFooter.Location = new Point(20, 540);
            pnlFooter.Name = "pnlFooter";
            pnlFooter.Size = new Size(720, 60);
            pnlFooter.TabIndex = 3;
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
            btnSave.Text = "Save All Rubrics";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // ManageRubrics
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 238, 232);
            ClientSize = new Size(760, 620);
            Controls.Add(pnlHeader);
            Controls.Add(pnlCLOSelect);
            Controls.Add(pnlBody);
            Controls.Add(pnlFooter);
            Name = "ManageRubrics";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manage Rubrics";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlCLOSelect.ResumeLayout(false);
            pnlCLOSelect.PerformLayout();
            pnlBody.ResumeLayout(false);
            pnlBody.PerformLayout();
            pnlFooter.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lblTitle;
        private Label lblSubtitle;
        private Panel pnlCLOSelect;
        private Label lblSelectCLO;
        private ComboBox cboCLO;
        private Button btnLoadCLO;
        private Panel pnlBody;
        private FlowLayoutPanel pnlRubrics;
        private LinkLabel lnkAddRubric;
        private Panel pnlFooter;
        private Button btnSave;
    }
}