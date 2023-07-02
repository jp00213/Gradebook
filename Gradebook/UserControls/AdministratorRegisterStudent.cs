using Gradebook.Controller;
using Gradebook.Function;
using Gradebook.Model;
using System;
using System.Windows.Forms;

namespace Gradebook.UserControls
{
    /// <summary>
    /// UserControl for administrator to register student
    /// </summary>
    public partial class AdministratorRegisterStudent : UserControl
    {
        private readonly CourseController _courseController;
        private readonly StudentController _studentController;

        /// <summary>
        /// Constructor for user control
        /// </summary>
        public AdministratorRegisterStudent()
        {
            InitializeComponent();
            this._courseController = new CourseController();
            this._studentController = new StudentController();
            this.registerButton.Enabled = false;
        }

        private void searchCourseButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.courseDataGridView.DataSource = this._courseController.GetCoursesByYearSemester(this.semesterComboBox.Text, this.courseYearPicker.Value.Year);
            } catch { }
        }

        private void searchStudentButton_Click(object sender, EventArgs e)
        {
            int studentID = 0;
            if (ValidationUtility.IsInt32(this.studentIDTextBox.Text))
            {
                studentID = Convert.ToInt32(this.studentIDTextBox.Text);
            } else
            {
                this.findStudentErrorLabel.Text = "Student ID must be a number";
                this.registerButton.Enabled = false;
            }
            try
            {
                Person student = this._studentController.GetStudentByID(studentID);
                if (string.IsNullOrEmpty(student.FirstName))
                {
                    this.findStudentErrorLabel.Text = "Cannot find student";
                    this.registerButton.Enabled = false;
                }
                else
                {
                    this.studentNameTextBox.Text = student.FirstName + " " + student.LastName;
                    this.studentBirthdayTextBox.Text = student.DateOfBirth.ToString("yyyy-MM-dd");
                    this.registerButton.Enabled = true;
                }
            } catch
            {
                this.findStudentErrorLabel.Text = "Error finding student";
            }
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            try
            {
                int course = (int)this.courseDataGridView.SelectedRows[0].Cells[0].Value;
                this._courseController.RegisterStudent(Convert.ToInt32(this.studentIDTextBox.Text), course);
                MessageBox.Show("Successfully registered for course");
                this.studentIDTextBox.Text = "";
                this.studentBirthdayTextBox.Text = "";
                this.studentNameTextBox.Text = "";
            this.registerButton.Enabled = false;
            } catch
            {
                MessageBox.Show("Did not register for course. Check previous registrations and try again");
            }
        }

        private void studentIDTextBox_TextChanged(object sender, EventArgs e)
        {
            this.findStudentErrorLabel.Text = "";
        }
    }
}
