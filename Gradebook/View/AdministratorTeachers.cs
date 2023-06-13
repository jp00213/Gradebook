using System.Windows.Forms;

namespace Gradebook.View
{
    /// <summary>
    /// Administrator sub-dashboard for teachers
    /// </summary>
    public partial class AdministratorTeachers : Form
    {
        /// <summary>
        /// Constructor for the Administrator Teacher Form
        /// </summary>
        public AdministratorTeachers()
        {
            InitializeComponent();
        }

        private void AdministratorTeachers_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Owner.Show();
        }

        private void backHomeButton_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            Owner.Show();
        }
    }
}
