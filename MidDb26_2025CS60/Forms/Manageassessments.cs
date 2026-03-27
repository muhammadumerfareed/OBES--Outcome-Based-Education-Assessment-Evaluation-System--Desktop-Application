using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MidDb26_2025CS60.Forms
{
    public partial class Manageassessments : Form
    {
        public Manageassessments()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            new AddQuestions().ShowDialog();
        }
    }
}
