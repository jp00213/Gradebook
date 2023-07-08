using Gradebook.Controller;
using Gradebook.Function;
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
    public partial class StudentCourseSummaryUserControl : UserControl
    {
        /// <summary>
        /// This class manages usercontrol for viewing student course information
        /// </summary>
        private readonly StudentController _studentController;
        private readonly GradesController _gradesController;
        private readonly CourseController _courseController;

        /// <summary>
        /// create constructors
        /// </summary>
        public StudentCourseSummaryUserControl()
        {
            InitializeComponent();
            this._studentController = new StudentController();
            this._gradesController = new GradesController();
            this._courseController = new CourseController();
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
            Person person = new Person();
            person = this._studentController.GetStudentByUsername(username);
            String name = person.FirstName + ' ' + person.LastName;
            int studentID = person.StudentID;
            this.currentStudentID.Text = studentID.ToString();
            this.nameLabel.Text = name.ToString();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            this.LoadGradeSummaryListViewAndGPA();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            this.errorMessageLabel.Text = string.Empty;
            this.gradeSummaryListView.Items.Clear();
            this.CourseGradesListView.Items.Clear();
        }

        private void LoadGradeSummaryListViewAndGPA()
        {
            // need student id, semester, year
            this.errorMessageLabel.Text = string.Empty;
            this.gradeSummaryListView.Items.Clear();
            SearchItem searchItem = new SearchItem();
            int studentIDInteger = Convert.ToInt32(this.currentStudentID.Text);

            searchItem.StudentID = studentIDInteger;
            searchItem.Semester = this.semesterComboBox.Text;
            searchItem.Year = this.courseYearPicker.Value.Year.ToString();

            List<Grades> gradeList = this._gradesController.GetCourseGradesSummaryByStudentID(searchItem);

            try
            {
                Grades gradeGPA = this._gradesController.GetSemesterGPA(searchItem);
                this.semesterGPADataLabel.Text = gradeGPA.GPA;
            }
            catch (Exception)
            {
                this.semesterGPADataLabel.Text = "";
            }

            try
            {
                Grades cumulativeGPA = this._gradesController.GetCumulatedGPA(searchItem);


                this.cumulativeGPADataLabel.Text = cumulativeGPA.GPA;
            }
            catch (Exception)
            {
                this.cumulativeGPADataLabel.Text = "";
            }

            if (gradeList.Count > 0)
            {
                Grades currentData;
                for (int i = 0; i < gradeList.Count; i++)
                {
                    currentData = gradeList[i];
                    gradeSummaryListView.Items.Add(currentData.Year.ToString());
                    gradeSummaryListView.Items[i].SubItems.Add(currentData.Semester);
                    gradeSummaryListView.Items[i].SubItems.Add(currentData.CourseID.ToString());
                    gradeSummaryListView.Items[i].SubItems.Add(currentData.Description);
                    gradeSummaryListView.Items[i].SubItems.Add(currentData.Prefix_number);
                    gradeSummaryListView.Items[i].SubItems.Add(currentData.Units.ToString());
                    gradeSummaryListView.Items[i].SubItems.Add(currentData.WeightGrade);
                    gradeSummaryListView.Items[i].SubItems.Add(GradeUtility.ConvertIntoAlphabetGrade(Decimal.Parse(currentData.WeightGrade)));
                    gradeSummaryListView.Items[i].SubItems.Add(currentData.GradePoints.ToString());
                    gradeSummaryListView.Items[i].SubItems.Add((Convert.ToDouble(currentData.Units) * Convert.ToDouble(currentData.GradePoints.ToString())).ToString());
                }
            }
            else
            {
                this.errorMessageLabel.Text = "No record found.";
                this.errorMessageLabel.ForeColor = Color.Blue;
                this.semesterGPADataLabel.Text = "-";
                this.cumulativeGPADataLabel.Text = "-";
            }

        }

        private void gradeSummaryListView_Click(object sender, EventArgs e)
        {
            this.CourseGradesListView.Items.Clear();
            this.errorLabel.Text = string.Empty;
            string courseIDString = gradeSummaryListView.SelectedItems[0].SubItems[2].Text;
            int courseID = Convert.ToInt32(courseIDString);
            SearchItem searchItems = new SearchItem();
            searchItems.CourseID = courseID;
            int studentIDInInteger = Convert.ToInt32(this.currentStudentID.Text);

            searchItems.StudentID = studentIDInInteger;

            List<Grades> roster = this._courseController.GetClassGradesByStudentIDAndCourseID(searchItems);
            if (roster.Count > 0)
            {
                Grades currentData;
                for (int i = 0; i < roster.Count; i++)
                {
                    currentData = roster[i];
                    CourseGradesListView.Items.Add(currentData.StudentID.ToString());
                    CourseGradesListView.Items[i].SubItems.Add(currentData.Grade_1.ToString());
                    CourseGradesListView.Items[i].SubItems.Add(currentData.Grade_2.ToString());
                    CourseGradesListView.Items[i].SubItems.Add(currentData.Grade_3.ToString());
                    CourseGradesListView.Items[i].SubItems.Add(currentData.Grade_4.ToString());
                    CourseGradesListView.Items[i].SubItems.Add(currentData.Grade_5.ToString());
                    CourseGradesListView.Items[i].SubItems.Add(currentData.Grade_6.ToString());
                    CourseGradesListView.Items[i].SubItems.Add(currentData.Grade_7.ToString());
                    CourseGradesListView.Items[i].SubItems.Add(currentData.Grade_8.ToString());
                    CourseGradesListView.Items[i].SubItems.Add(currentData.Grade_9.ToString());
                    CourseGradesListView.Items[i].SubItems.Add(currentData.Grade_10.ToString());
                    CourseGradesListView.Items[i].SubItems.Add(currentData.Grade_11.ToString());
                    CourseGradesListView.Items[i].SubItems.Add(currentData.Grade_12.ToString());
                    CourseGradesListView.Items[i].SubItems.Add(currentData.Grade_13.ToString());
                    CourseGradesListView.Items[i].SubItems.Add(currentData.Grade_14.ToString());
                    CourseGradesListView.Items[i].SubItems.Add(currentData.Grade_15.ToString());
                    CourseGradesListView.Items[i].SubItems.Add(currentData.WeightGrade.ToString());
                }
            }
            else
            {
                this.errorLabel.Text = "Record not found.";
                this.errorLabel.ForeColor = Color.Blue;
            }
        }
    }
}
