﻿using Gradebook.Controller;
using Gradebook.Model;
using System;
using System.Windows.Forms;

namespace Gradebook.UserControls
{
    /// <summary>
    /// UserControl for administrator to search for and update registrations
    /// </summary>
    public partial class AdministratorUpdateRegistration : UserControl
    {
        private readonly CourseController _courseController;

        /// <summary>
        /// Constructor for user control
        /// </summary>
        public AdministratorUpdateRegistration()
        {
            InitializeComponent();
            this._courseController = new CourseController();
        }

        private void searchCourseButton_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (Int32.TryParse(this.studentIDTextBox.Text, out int studentid))
                {
                    this.courseDataGridView.DataSource = this._courseController.GetCoursesByStudentRegistration(studentid);
                } else
                {
                    this.studentIDErrorLabel.Text = "Please enter a number";
                }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void studentIDTextBox_TextChanged(object sender, EventArgs e)
        {
            this.studentIDErrorLabel.Text = "";
        }

        private void viewFutureCoursesButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (Int32.TryParse(this.studentIDTextBox.Text, out int studentid))
                {
                    this.courseDataGridView.DataSource = this._courseController.GetCoursesByYearSemesterStudentID(this.semesterComboBox.Text, this.courseYearPicker.Value.Year, studentid);
                }
                else
                {
                    this.studentIDErrorLabel.Text = "Please enter a number";
                }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }
    }
}
