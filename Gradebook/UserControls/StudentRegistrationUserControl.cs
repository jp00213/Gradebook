using Gradebook.Controller;
using Gradebook.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Gradebook.UserControls
{
    /// <summary>
    /// User control for students to register themselves
    /// </summary>
    public partial class StudentRegistrationUserControl : UserControl
    {
        private readonly CourseController _courseController;
        private readonly StudentController _studentController;
        private readonly TeacherController _teacherController;
        private int currentStudentID;
        private int totalCredits;
        private int maximumCredits;

        /// <summary>
        /// Constructor for user control
        /// </summary>
        public StudentRegistrationUserControl()
        {
            InitializeComponent();
            this._courseController = new CourseController();
            this._studentController = new StudentController();
            this._teacherController = new TeacherController();
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
            this.currentStudentID = person.StudentID;
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
            SearchItem searchTotal = new SearchItem
            {
                StudentID = this.currentStudentID,
                Semester = this.semesterComboBox.Text,
                Year = this.courseYearPicker.Value.Year.ToString()
            };
            this.totalCredits = this._studentController.GetStudentRegisteredUnitsTotal(searchTotal);
            this.registerTotalLabel.Text = "Registered for: " + this.totalCredits + " credits";
            Course search = new Course
            {
                StudentID = this.currentStudentID,
                Semester = this.semesterComboBox.Text,
                Year = this.courseYearPicker.Value.Year
            };
            List<Course> totalCourses = this._courseController.GetStudentCourseDetailsByTermAndYearAndStudentID(search);
            this.registeredGridView.DataSource = totalCourses;

        }

        private void registerButton_Click(object sender, System.EventArgs e)
        {
            try
            {
                Course course = (Course)this.courseDataGridView.SelectedRows[0].DataBoundItem;
                // int course = (int)this.courseDataGridView.SelectedRows[0].Cells[0].Value;
                this.maximumCredits = this._studentController.GetStudentMaximumAllowedUnits(this.currentStudentID);
                if ((this.totalCredits + course.CreditHours) <= this.maximumCredits)
                {
                    this._courseController.RegisterStudent(this.currentStudentID, course.CourseID);
                    MessageBox.Show("Successfully registered for course");
                    this.RedrawCurrentRegistrations();
                    this.registerButton.Enabled = false;
                } else
                {
                    MessageBox.Show("Did not register.\nYour maximum is " + this.maximumCredits + "credits.\nYou have " + this.totalCredits + " credits already");
                }
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

        private void registeredGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == registeredGridView.Columns["TeacherContact"].Index && e.RowIndex >= 0)
                {
                    Course viewCourse = (Course)this.courseDataGridView.Rows[e.RowIndex].DataBoundItem;
                    if (viewCourse.TeacherID == 0)
                    {
                        MessageBox.Show("No teacher assigned", "Teacher Contact Info", MessageBoxButtons.OK);
                    }
                    else
                    {
                        Teacher teacher = this._teacherController.GetTeacherByID(viewCourse.TeacherID);
                        string phone = teacher.Phone;
                        if (teacher.Phone.Length == 10)
                        {
                            phone = "(" + teacher.Phone.Substring(0, 3) + ") " + teacher.Phone.Substring(3, 3) + "-" + teacher.Phone.Substring(6, 4);
                        }
                        string message = "Name: " + teacher.FullName + "\nPhone: " + phone + "\nEmail: TBD";
                        MessageBox.Show(message, "Teacher Contact Info", MessageBoxButtons.OK);
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

    }
}
