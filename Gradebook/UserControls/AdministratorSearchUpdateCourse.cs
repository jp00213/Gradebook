using Gradebook.Controller;
using System.Windows.Forms;

namespace Gradebook.UserControls
{
    /// <summary>
    /// UserControl for administrator to search for and update courses
    /// </summary>
    public partial class AdministratorSearchUpdateCourse : UserControl
    {
        private readonly CourseController _courseController;

        /// <summary>
        /// Constructor for user control
        /// </summary>
        public AdministratorSearchUpdateCourse()
        {
            InitializeComponent();
            this._courseController = new CourseController();
        }

        private void searchCourseButton_Click(object sender, System.EventArgs e)
        {
            try
            {
                this.courseDataGridView.DataSource = this._courseController.GetCoursesByYearSemester(this.semesterComboBox.Text, this.courseYearPicker.Value.Year);
            }
            catch { }
        }
    }
}
