using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MidDb26_2025CS60.Forms
{
    public partial class StudentMenuForm : Form
    {
        public StudentMenuForm()
        {
            InitializeComponent();
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            new AddStudent().ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            new EditStudentForm().ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            new SearchStudent().ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            new DeleteStudentForm().ShowDialog();
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {

            new Attendance().ShowDialog();
        }
    }
}
