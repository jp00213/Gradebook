using Gradebook.Controller;
using Gradebook.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Gradebook.UserControls
{

    public partial class StudentGPAUserControl : UserControl
    {
        /// <summary>
        /// This class manages usercontrol for viewing student GPA information
        /// </summary>
        private readonly StudentController _studentController;
        private readonly GradesController _gradesController;

        /// <summary>
        /// create constructors
        /// </summary>
        public StudentGPAUserControl()
        {
            InitializeComponent();
            this._studentController = new StudentController();
            this._gradesController = new GradesController();
        }

        /// <summary>
        /// Sets username
        /// </summary>
        /// <param name="username"></param>
        public void SetUserName(string username)
        {
            this.SetCurrentStudentID(username);
        }

        /// <summary>
        /// Sets current studentID
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
            this.LoadCompleteGradeInformationByStudentID();
        }

        private void LoadCompleteGradeInformationByStudentID()
        {
            this.completeGradeListView.Items.Clear();
            int studentIDInteger = Convert.ToInt32(this.currentStudentID.Text);
            List<Grades> gradeList = this._gradesController.GetCompleteGradeInformationByStudentID(studentIDInteger);

            //  System.Windows.Forms.MessageBox.Show("record count: " + gradeList.Count);
            if (gradeList.Count > 0)
            {
                Grades currentData;
                for (int i = 0; i < gradeList.Count; i++)
                {
                    currentData = gradeList[i];
                    completeGradeListView.Items.Add(currentData.Column1);
                    completeGradeListView.Items[i].SubItems.Add(currentData.Column2);
                    completeGradeListView.Items[i].SubItems.Add(currentData.Column3);
                    completeGradeListView.Items[i].SubItems.Add(currentData.Column4);
                    completeGradeListView.Items[i].SubItems.Add(currentData.Column5);
                    completeGradeListView.Items[i].SubItems.Add(currentData.Column6);
                }

                this.fullRecordLabel.Text = "Data loaded.";
                this.fullRecordLabel.ForeColor = Color.Blue;

                SearchItem searchItem = new SearchItem();

                searchItem.StudentID = studentIDInteger;

                try
                {
                    Grades cumulativeGPA = this._gradesController.GetCumulatedGPA(searchItem);

                    this.cumulativeGPADataLabel.Text = cumulativeGPA.GPA;
                }
                catch (Exception)
                {
                    this.cumulativeGPADataLabel.Text = "";
                }
            }
            else
            {
                this.fullRecordLabel.Text = "No academic grade found.";
                this.fullRecordLabel.ForeColor = Color.Blue;
            }

        }

    }
}
