using System.Windows.Forms;

namespace Gradebook.View
{
    /// <summary>
    /// Administrator sub-dashboard for students
    /// </summary>
    public partial class AdministratorStudents : Form
    {
        /// <summary>
        /// Constructor for the Administrator Student Form
        /// </summary>
        public AdministratorStudents()
        {
            InitializeComponent();
        }
        private void AdministratorStudents_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Owner.Show();
        }

    }
}
