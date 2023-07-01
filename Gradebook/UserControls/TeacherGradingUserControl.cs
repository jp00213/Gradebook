using Gradebook.Controller;
using Gradebook.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gradebook.UserControls
{
    public partial class TeacherGradingUserControl : UserControl
    {
        private CourseController _courseController;
        private TeacherController _teacherController;
        private AssignmentController _assignmentController;


        public TeacherGradingUserControl()
        {
            InitializeComponent();
            this._courseController = new CourseController();
            this._teacherController = new TeacherController();
            this._assignmentController = new AssignmentController();
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
            List<Assignment> currentAssignments = this._assignmentController.GetAssignmentsByCourseID(this.GetCourseID());
            foreach (Assignment assignment in currentAssignments)
            {
                string assignmentName = assignment.Description;
                this.selectAssignmentComboBox.Items.Add(assignmentName);
            }
        }

        private int GetCourseID()
        {
            string courseName = this.selectClassComboBox.Text;
            if (String.IsNullOrEmpty(courseName))
            {
                selectClassErrorLabel.Text = "Please select a course to grade for.";
                selectClassErrorLabel.ForeColor = Color.Red;
                return -1;
            }
            Course currentCourse = this._courseController.GetCourseByName(courseName);
            return currentCourse.CourseID;
        }

        private string GetCurrentSemester()
        {
            string semester;

            if (DateTime.Now.Month <= 4)
            {
                semester = "Spring";
            }
            else if (DateTime.Now.Month > 4 && DateTime.Now.Month < 8)
            {
                semester = "Summer";
            }
            else
            {
                semester = "Fall";
            }

            return semester;
        }

        private int GetTeacherID()
        {
            string teacherUsername = TeacherController.GetUsername();
            /*MessageBox.Show(teacherUsername);*/
            /*Teacher currentTeacher = this._teacherController.GetTeacherByUsername(teacherUsername);
            return currentTeacher.TeacherID;*/
            return 2;
        }

        private void ClassSelected(object sender, EventArgs e)
        {
            this.SetupAssignmentComboBox();
        }
    }
}
