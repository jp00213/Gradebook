using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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

    }
}
