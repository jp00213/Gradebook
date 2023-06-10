using System.Windows.Forms;

namespace Gradebook.View
{
    /// <summary>
    /// Main Dashboard for Administrators
    /// </summary>
    public partial class AdministratorDashboard : Form
    {
        /// <summary>
        /// Constructor for the Main Dashboard for Administrators
        /// </summary>
        /// <param name="username"></param>
        public AdministratorDashboard(string username)
        {
            InitializeComponent();
            this.welcomeUserLabel.Text = "Welcome " + username;
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
