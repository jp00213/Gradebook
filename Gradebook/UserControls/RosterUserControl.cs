using Gradebook.Controller;
using Gradebook.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Gradebook.UserControls
{
    /// <summary>
    /// This class manages usercontrol for roster information
    /// </summary>
    public partial class RosterUserControl : UserControl
    {
        private readonly CourseController _courseController;
        private readonly TeacherController _teacherController;

        /// <summary>
        /// create constructors
        /// </summary>
        public RosterUserControl()
        {
            InitializeComponent();
            this._courseController = new CourseController();
            this._teacherController = new TeacherController();
            this.SetTeacherComboBox();
            this.SetSemesterComboBox();
        }

        private void SetSemesterComboBox()
        {
            this.semesterComboBox.SelectedIndex = 0;

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            this.ClearAll();
        }

        private void teacherNameComboBox_Click(object sender, EventArgs e)
        {
            this.errorlabel.Text = string.Empty;
        }

        private void semesterComboBox_Click(object sender, EventArgs e)
        {
            this.errorlabel.Text = string.Empty;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            this.LoadTeacherCourseList();
        }

        private Course GetSearchItems()
        {

            Course searchItems = new Course();

            searchItems.TeacherID = (int)this.teacherNameComboBox.SelectedValue;
            searchItems.Semester = this.semesterComboBox.Text;
            searchItems.Year = this.courseYearPicker.Value.Year;

            return searchItems;
        }

        private void LoadTeacherCourseList()
        {

            if (this.semesterComboBox.SelectedIndex == 0)
            {
                this.errorlabel.Text = "Please choose a term.";
                this.errorlabel.ForeColor = Color.Blue;
                return;
            }

            Course searchItems = this.GetSearchItems();

            this.courseListView.Items.Clear();

            List<Course> courseList = this._courseController.GetCourseByTeacherIDAndSemesterAndYear(searchItems);

            if (courseList.Count > 0)
            {
                Course currentData;
                for (int i = 0; i < courseList.Count; i++)
                {
                    currentData = courseList[i];
                    courseListView.Items.Add(currentData.CourseID.ToString());
                    courseListView.Items[i].SubItems.Add(currentData.Name.ToString());
                    courseListView.Items[i].SubItems.Add(currentData.Prefix.ToString());
                    courseListView.Items[i].SubItems.Add(currentData.Number.ToString());
                    courseListView.Items[i].SubItems.Add(currentData.Section.ToString());
                    courseListView.Items[i].SubItems.Add(currentData.CreditHours.ToString());
                    courseListView.Items[i].SubItems.Add(currentData.StudentCount.ToString());
                }
            }
            else
            {
                this.errorlabel.Text = "Record not found.";
                this.errorlabel.ForeColor = Color.Blue;
            }
        }

        private void courseListView_Click(object sender, EventArgs e)
        {
            this.rosterListView.Items.Clear();
            this.errorlabel.Text = string.Empty;
            string courseIDString = courseListView.SelectedItems[0].SubItems[0].Text;
            int courseID = Convert.ToInt32(courseIDString);
            Course searchItems = this.GetSearchItems();
            searchItems.CourseID = courseID;

            List<Course> roster = this._courseController.GetRosterDataByTeacherIDAndSemesterAndYearAndCourseID(searchItems);
            if (roster.Count > 0)
            {
                Course currentData;
                for (int i = 0; i < roster.Count; i++)
                {
                    currentData = roster[i];
                    rosterListView.Items.Add(currentData.CourseID.ToString());
                    rosterListView.Items[i].SubItems.Add(currentData.StudentID.ToString());
                    rosterListView.Items[i].SubItems.Add(currentData.StudentFullName.ToString());
                }
            }
            else
            {
                this.errorlabel.Text = "Student record not found.";
                this.errorlabel.ForeColor = Color.Blue;
            }
        }

        private void ClearAll()
        {
            this.SetTeacherComboBox();
            this.SetSemesterComboBox();
            this.errorlabel.Text = string.Empty;
            this.courseListView.Items.Clear();
            this.rosterListView.Items.Clear();
        }

        private void SetTeacherComboBox()
        {
            try
            {
                teacherNameComboBox.DataSource = this._teacherController.GetAllActiveTeachers();
                teacherNameComboBox.DisplayMember = "FullName";
                teacherNameComboBox.ValueMember = "TeacherID";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                teacherNameComboBox.Items.Insert(0, "No teacher available");
            }
        }
    }
}
