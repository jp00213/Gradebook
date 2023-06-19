using System.Windows.Forms;

namespace Gradebook.View
{
    /// <summary>
    /// Main Dashboard for Teachers
    /// </summary>
    public partial class TeacherDashboard : Form
    {
        /// <summary>
        /// Constructor for the Main Dashboard for Teachers
        /// </summary>
        /// <param name="username"></param>
        public TeacherDashboard(string username)
        {
            InitializeComponent();
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
