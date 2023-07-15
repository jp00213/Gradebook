using Gradebook.UserControls;
using System.Windows.Forms;

namespace Gradebook.View
{
    /// <summary>
    /// Main Dashboard for Students
    /// </summary>
    public partial class StudentDashboard : Form
    {
        /// <summary>
        /// Constructor for the Main Dashboard for Students
        /// </summary>
        /// <param name="username"></param>
        public StudentDashboard(string username)
        {
            InitializeComponent();
            this.userNameDataLabel.Text = username;
            studentCourseSummaryUserControl1.SetCurrentStudentID(username);
            studentRegistrationUserControl1.SetCurrentStudentID(username);
            studentGPAUserControl1.SetCurrentStudentID(username);
            studentProfileUserControl1.SetCurrentStudentID(username);

        }

        private void logoutLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Owner.Show();
        }

        private void AdministratorDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


    }
}
