using MidDb26_2025CS60.DAL;
using MidDb26_2025CS60.Forms;
namespace MidDb26_2025CS60
{

    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void btnStudents_Click(object sender, EventArgs e)
        {
            new StudentMenuForm().ShowDialog();
        }
        private void btnCLOs_Click(object sender, EventArgs e)
        {
            new ManageCLOs().ShowDialog();
        }
        private void btnRubrics_Click(object sender, EventArgs e)
        {
            new ManageRubrics().ShowDialog();
        }

        private void btnAssesments_Click(object sender, EventArgs e)
        {
            new Manageassessments().ShowDialog();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            new Reports().ShowDialog();
        }

        private void btnEvaluations_Click(object sender, EventArgs e)
        {
            new MarkEvaluation().ShowDialog();
        }
    }

}
