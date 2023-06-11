using System.Windows.Forms;

namespace Gradebook.View
{
    /// <summary>
    /// Administrator sub-dashboard for courses
    /// </summary>
    public partial class AdministratorCourses : Form
    {
        /// <summary>
        /// Constructor for the Administrator Courses Form
        /// </summary>
        public AdministratorCourses()
        {
            InitializeComponent();
        }

        private void AdministratorCourses_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Owner.Show();
        }

    }
}
