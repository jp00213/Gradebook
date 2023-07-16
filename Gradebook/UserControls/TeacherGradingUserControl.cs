using Gradebook.Controller;
using Gradebook.Function;
using Gradebook.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Gradebook.UserControls
{
    /// <summary>
    /// The usercontrol that allows teachers to input grades
    /// </summary>
    public partial class TeacherGradingUserControl : UserControl
    {
        private CourseController _courseController;
        private TeacherController _teacherController;
        private AssignmentController _assignmentController;
        private GradesController _gradesController;
        private StudentController _studentController;
        private Person _student;

        /// <summary>
        /// User Control constructor
        /// </summary>
        public TeacherGradingUserControl()
        {
            InitializeComponent();
            this._courseController = new CourseController();
            this._teacherController = new TeacherController();
            this._assignmentController = new AssignmentController();
            this._studentController = new StudentController();
            this._gradesController= new GradesController();
            this._student = new Person();
            this.SetUpClassComboBox();
        }

        private void SetUpClassComboBox()
        {
            List<Course> currentCourses = this._courseController.GetCoursesByTeacherIDYearAndSemester(this.GetTeacherID(), this.GetCurrentSemester(), DateTime.Now.Year);
            foreach (Course course in currentCourses)
            {
                string courseName = course.Name;
                this.selectClassComboBox.Items.Add(courseName);
            }
            
        }

        private void SetupAssignmentComboBox()
        {
            this.selectAssignmentComboBox.Items.Clear();
            List<Assignment> currentAssignments = this._assignmentController.GetAssignmentsByCourseID(this.GetCourseID());
            foreach (Assignment assignment in currentAssignments)
            {
                string assignmentName = assignment.Description;
                this.selectAssignmentComboBox.Items.Add(assignmentName);
            }
        }

        private void SetupStudentCombobox()
        {
            this.selectStudentComboBox.Items.Clear();
            List<Person> studentsInClass = this._studentController.GetStudentsByCourseID(this.GetCourseID());
            foreach (Person student in studentsInClass)
            {
                string studentName = student.FullName;
                this.selectStudentComboBox.Items.Add(studentName);
            }
        }

        private int GetCourseID()
        {
            //make try catch with blanket exception
            string courseName = this.selectClassComboBox.Text;
            if (String.IsNullOrEmpty(courseName))
            {
                return -1;
            }
            Course currentCourse = this._courseController.GetCourseByName(courseName);
            return currentCourse.CourseID;
        }

        private int GetAssignmentID()
        {
            string assignmentDescription = this.selectAssignmentComboBox.Text;
            Assignment assignment = this._assignmentController.GetAssignmentByDescription(assignmentDescription);
            return assignment.AssignmentID;
        }

        private int GetStudentID()
        {
            string fullName = this.selectStudentComboBox.Text;

            if (string.IsNullOrEmpty(fullName))
            {
                MessageBox.Show("Please select a student to continue.", "No Student Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }

            var names = fullName.Split(' ');
            string firstName = names[0];
            string lastName = names[1];
            Person student = this._studentController.GetStudentByNameAndCourseID(firstName, lastName, this.GetCourseID());
            int studentID = student.StudentID;
            return studentID;
        }

        private string GetCurrentSemester()
        {
            return ValidationUtility.GetCurrentSemester(DateTime.Now);
        }

        private int GetTeacherID()
        {
            string teacherUsername = TeacherController.GetUsername();
            Teacher currentTeacher = this._teacherController.GetTeacherByUsername(teacherUsername);
            return currentTeacher.TeacherID;
        }

        private void ClassSelected(object sender, EventArgs e)
        {
            this.SetupAssignmentComboBox();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            this.selectAssignmentComboBox.SelectedItem= null;
            this.selectClassComboBox.SelectedItem = null;
            this.selectStudentComboBox.SelectedItem = null;
            this.gradeTextBox.Text= "";
            this.selectStudentErrorLabel.Text = "";
            this.gradeErrorMessageLabel.Text = "";
            this.selectAssignmentErrorLabel.Text= "";
            this.selectClassErrorLabel.Text = "";
        }

        private void populateButton_Click(object sender, EventArgs e)
        {
            
            try
            {
                int score = Int32.Parse(this.gradeTextBox.Text);
                if (score > 0)
                {
                    bool success = this._gradesController.AddGrade(GetAssignmentID(), GetStudentID(), score);
                    if (success)
                    {
                        MessageBox.Show("Grade successfully submitted!", "Grade Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.PopulateGradeDataGridView();
                    } 
                }

                this.PopulateGradeDataGridView();
            } catch (Exception ex) 
            {
                MessageBox.Show("A grade already exists for this student. Editing not permitted yet. Please select another student or assignment.", "Grade Not Saved" + ex.GetType(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void selectAssignmentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.PopulateGradeDataGridView();
            this.SetupStudentCombobox();
        }

        private void PopulateGradeDataGridView()
        {
            this.studentGradesDataGridView.DataSource = this._gradesController.GetAssignmentGrades(this.GetCourseID(), this.GetAssignmentID());
            /*this.studentGradesDataGridView.DataSource = this._gradesController.GetAllGrades();*/


        }
    }
}
