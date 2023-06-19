using Gradebook.Controller;
using Gradebook.Function;
using Gradebook.Model;
using System;
using System.Windows.Forms;

namespace Gradebook.UserControls
{
    /// <summary>
    /// The usercontrol to register students
    /// </summary>
    public partial class AdministratorRegisterStudent : UserControl
    {
        private readonly CourseController _courseController;
        private readonly StudentController _studentController;

        /// <summary>
        /// The registerstudent constructor
        /// </summary>
        public AdministratorRegisterStudent()
        {
            InitializeComponent();
            this._courseController = new CourseController();
            this._studentController = new StudentController();
        }

        private void searchCourseButton_Click(object sender, EventArgs e)
        {
            this.courseDataGridView.DataSource = this._courseController.GetCoursesByYearSemester(this.semesterComboBox.Text, this.courseYearPicker.Value.Year);
        }

        private void searchStudentButton_Click(object sender, EventArgs e)
        {
            int studentID = 0;
            if (ValidationUtility.IsInt32(this.studentIDTextBox.Text))
            {
                studentID = Convert.ToInt32(this.studentIDTextBox.Text);
            }
            try
            {
                Person student = this._studentController.GetStudentByID(studentID);
                this.studentNameTextBox.Text = student.FirstName + " " + student.LastName;
                this.studentBirthdayTextBox.Text = student.DateOfBirth.ToString("yyyy-MM-dd");
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            int course = (int)this.courseDataGridView.SelectedRows[0].Cells[0].Value;
            try
            {
                this._courseController.RegisterStudent(Convert.ToInt32(this.studentIDTextBox.Text), course);
                MessageBox.Show("Successfully registered for course");
            } catch
            {
                MessageBox.Show("Did not register for course. Check previous registrations and try again");
            }
        }
    }
}
