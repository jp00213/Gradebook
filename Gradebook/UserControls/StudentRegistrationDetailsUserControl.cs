using Gradebook.Controller;
using Gradebook.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Gradebook.UserControls
{
    /// <summary>
    /// This class manages usercontrol for search student registration information
    /// </summary>
    public partial class StudentRegistrationDetailsUserControl : UserControl
    {

        private readonly StudentController _studentController;
        private readonly CourseController _courseController;
        private Person theStudent;

        /// <summary>
        /// create constructors
        /// </summary>
        public StudentRegistrationDetailsUserControl()
        {
            InitializeComponent();
            this._studentController = new StudentController();
            this._courseController = new CourseController();
            theStudent = new Person();
            this.DisableAllFields();
        }

        public void SetCurrentStudentID(string currentStudentIDIn)
        {
            this.currentStudentIDForEdit.Text = currentStudentIDIn;
        }

        private SearchItem CreateSearchItems()
        {
            SearchItem searchItem = new SearchItem();
            searchItem.StudentID = Convert.ToInt32(this.currentStudentIDForEdit.Text);
            searchItem.Semester = this.semesterComboBox.Text;
            searchItem.Year = this.courseYearPicker.Value.Year.ToString();
            return searchItem;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (this.semesterComboBox.Text == " ")
            {
                this.errorlabel.Text = "Please enter a term.";
                this.errorlabel.ForeColor = Color.Blue;
                return;
            }

            SearchItem searchItem = this.CreateSearchItems();

            int studentIDInteger = Convert.ToInt32(this.currentStudentIDForEdit.Text);

            this.registeredUnitsDisplayLabel.Text = this._studentController.GetStudentRegisteredUnitsTotal(searchItem).ToString();
            this.allowedUnitsLabel.Text = this._studentController.GetStudentMaximumAllowedUnits(studentIDInteger).ToString();

            this.CalculateUnitsBalance();
            this.LoadCourseListByTermYear();




            if (this.registeredUnitsDisplayLabel.Text == "0")
            {
                this.errorlabel.Text = "No registration data found.";
                this.errorlabel.ForeColor = Color.Blue;
            }
        }

        private void CalculateUnitsBalance()
        {
            SearchItem searchItem = this.CreateSearchItems();
            int totalAllowUnits = this._studentController.GetStudentMaximumAllowedUnits(searchItem.StudentID);
            int registeredUnits = this._studentController.GetStudentRegisteredUnitsTotal(searchItem);

            int balance = totalAllowUnits - registeredUnits;

            if (balance < 0)
            {
                unitsBalanceLabel.Text = "Over " + (balance * -1) + " units.";
            }
            else
            {
                unitsBalanceLabel.Text = balance.ToString();
            }

        }

        private void ClearErrors()
        {
            this.errorlabel.Text = "";
            this.courseListView.Items.Clear();
            this.allowedUnitsLabel.Text = "0";
            this.registeredUnitsDisplayLabel.Text = "0";
            this.unitsBalanceLabel.Text = "0";
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            this.ClearErrors();
        }

        private void semesterComboBox_Click(object sender, EventArgs e)
        {
            this.ClearErrors();
        }

        private void courseYearPicker_ValueChanged(object sender, EventArgs e)
        {
            this.ClearErrors();
        }

        private void DisableAllFields()
        {
            this.semesterComboBox.Text = string.Empty;
            this.semesterComboBox.Enabled = false;
            this.courseYearPicker.Enabled = false;
            this.allowedUnitsLabel.Text = "0";
            this.registeredUnitsDisplayLabel.Text = "0";
            this.unitsBalanceLabel.Text = "0";
            this.errorlabel.Text = "";
            this.searchButton.Enabled = false;
            this.clearButton.Enabled = false;
            this.courseListView.Items.Clear();
        }

        private void EnableAllFields()
        {
            this.semesterComboBox.Text = string.Empty;
            this.semesterComboBox.Enabled = true;
            this.courseYearPicker.Enabled = true;
            this.allowedUnitsLabel.Text = "0";
            this.registeredUnitsDisplayLabel.Text = "0";
            this.unitsBalanceLabel.Text = "0";
            this.errorlabel.Text = "";
            this.searchButton.Enabled = true;
            this.clearButton.Enabled = true;
            this.courseListView.Items.Clear();
        }

        private void currentStudentIDForEdit_TextChanged(object sender, EventArgs e)
        {
            if (this.currentStudentIDForEdit.Text == "0")
            {
                this.DisableAllFields();
            }
            else
            {
                this.EnableAllFields();
            }
        }

        private void LoadCourseListByTermYear()
        {
            Course searchItem = new Course();

            searchItem.StudentID = Convert.ToInt32(this.currentStudentIDForEdit.Text);
            searchItem.Semester = this.semesterComboBox.Text;
            searchItem.Year = this.courseYearPicker.Value.Year;
            this.courseListView.Items.Clear();

            List<Course> courseList = this._courseController.GetStudentCourseDetailsByTermAndYearAndStudentID(searchItem);

            if (courseList.Count > 0)
            {
                Course currentData;
                for (int i = 0; i < courseList.Count; i++)
                {
                    currentData = courseList[i];
                    courseListView.Items.Add(currentData.CourseID.ToString());
                    courseListView.Items[i].SubItems.Add(currentData.Prefix.ToString());
                    courseListView.Items[i].SubItems.Add(currentData.Number.ToString());
                    courseListView.Items[i].SubItems.Add(currentData.Section.ToString());
                    courseListView.Items[i].SubItems.Add(currentData.Name.ToString());
                    courseListView.Items[i].SubItems.Add(currentData.CreditHours.ToString());
                    courseListView.Items[i].SubItems.Add(currentData.TeacherFullName.ToString());
                }
            }
            else
            {
                this.errorlabel.Text = "Record not found.";
            }


        }
    }
    
}
