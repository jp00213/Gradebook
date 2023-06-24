using Gradebook.Controller;
using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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
            this.CaptureUsername(username);
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

        private void CaptureUsername(string userName)
        {
            try
            {
                TeacherController.SetUsername(userName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("That didn't work!");
            }
        }
    }
}
