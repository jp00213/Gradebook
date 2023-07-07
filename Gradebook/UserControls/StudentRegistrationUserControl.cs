using Gradebook.Controller;
using Gradebook.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Gradebook.UserControls
{
    public partial class StudentRegistrationUserControl : UserControl
    {
        private readonly CourseController _courseController;
        private readonly StudentController _studentController;
        private int currentStudentID;

        /// <summary>
        /// Constructor for user control
        /// </summary>
        public StudentRegistrationUserControl()
        {
            InitializeComponent();
            this._courseController = new CourseController();
            this._studentController = new StudentController();
            this.registerButton.Enabled = false;
        }

        /// <summary>
        /// set username
        /// </summary>
        /// <param name="username"></param>
        public void SetUserName(string username)
        {
            this.SetCurrentStudentID(username);
        }

        /// <summary>
        /// set current student ID
        /// </summary>
        /// <param name="username"></param>
        public void SetCurrentStudentID(string username)
        {
            Person person = this._studentController.GetStudentByUsername(username);
            // String name = person.FirstName + ' ' + person.LastName;
            this.currentStudentID = person.StudentID;
            // this.currentStudentID.Text = studentID.ToString();
            // this.nameLabel.Text = name.ToString();
        }


        private void searchCourseButton_Click(object sender, System.EventArgs e)
        {
            try
            {
                this.courseDataGridView.DataSource = this._courseController.GetCoursesByYearSemester(this.semesterComboBox.Text, this.courseYearPicker.Value.Year);
                this.RedrawCurrentRegistrations();
            }
            catch { }
        }

        private void RedrawCurrentRegistrations()
        {
            int totalCredits = 0;
            Course search = new Course
            {
                StudentID = this.currentStudentID,
                Semester = this.semesterComboBox.Text,
                Year = this.courseYearPicker.Value.Year
            };
            List<Course> totalCourses = this._courseController.GetStudentCourseDetailsByTermAndYearAndStudentID(search);
            // foreach (Course course in totalCourses) { totalCredits += course.CreditHours; }
            this.registeredGridView1.DataSource = totalCourses;

        }

        private void registerButton_Click(object sender, System.EventArgs e)
        {
            try
            {
                int course = (int)this.courseDataGridView.SelectedRows[0].Cells[0].Value;
                this._courseController.RegisterStudent(this.currentStudentID, course);
                MessageBox.Show("Successfully registered for course");
                this.RedrawCurrentRegistrations();
                this.registerButton.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Did not register for course. Check previous registrations and try again");
            }
        }

        private void courseDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.registerButton.Enabled = true;
        }
    }
}
