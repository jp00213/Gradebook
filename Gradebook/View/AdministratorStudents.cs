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

        private void searchStudentUserControl1_StudentNumberChanged(object sender, System.EventArgs e)
        {
            this.currentStudentIDDataLabel.Text = searchStudentUserControl1.getCurrentStudentID();
        }

        private void currentStudentIDDataLabel_TextChanged(object sender, System.EventArgs e)
        {
            changeStudentPasswordUserControl1.SetCurrentStudentID(this.currentStudentIDDataLabel.Text);
            studentRegistrationDetailsUserControl1.SetCurrentStudentID(this.currentStudentIDDataLabel.Text);
        }

        private void backHomeButton_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            Owner.Show();
        }
    }
}
