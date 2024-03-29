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
        private int studentid;
        private bool searchAll;

        /// <summary>
        /// Constructor for user control
        /// </summary>
        public AdministratorUpdateRegistration()
        {
            InitializeComponent();
            this._courseController = new CourseController();
            this.searchAll = false;
        }

        private void searchCourseButton_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (Int32.TryParse(this.studentIDTextBox.Text, out this.studentid))
                {
                    this.courseDataGridView.DataSource = this._courseController.GetCoursesByStudentRegistration(this.studentid);
                    this.searchAll = true;
                }
                else
                {
                    this.studentIDErrorLabel.Text = "Please enter a number";
                }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void viewFutureCoursesButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (Int32.TryParse(this.studentIDTextBox.Text, out this.studentid))
                {
                    this.courseDataGridView.DataSource = this._courseController.GetCoursesByYearSemesterStudentID(this.semesterComboBox.Text, this.courseYearPicker.Value.Year, this.studentid);
                    this.searchAll = false;
                }
                else
                {
                    this.studentIDErrorLabel.Text = "Please enter a number";
                }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void courseDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == courseDataGridView.Columns["DeleteButton"].Index && e.RowIndex >= 0)
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to remove this registration?", "Confirm Removal", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        Course viewCourse = (Course)this.courseDataGridView.Rows[e.RowIndex].DataBoundItem;
                        if (this._courseController.DeleteRegistration(viewCourse.CourseID, this.studentid))
                        {
                            MessageBox.Show("Registration successfully deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.RedrawGrid();
                        }
                        else
                        {
                            MessageBox.Show("Registration was not deleted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        MessageBox.Show("Registration was not deleted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void RedrawGrid()
        {
            try
            {
                if (this.searchAll)
                {
                    this.courseDataGridView.DataSource = this._courseController.GetCoursesByStudentRegistration(this.studentid);
                }
                else
                {
                    this.courseDataGridView.DataSource = this._courseController.GetCoursesByYearSemesterStudentID(this.semesterComboBox.Text, this.courseYearPicker.Value.Year, this.studentid);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void studentIDTextBox_TextChanged(object sender, EventArgs e)
        {
            this.studentIDErrorLabel.Text = "";
        }

    }
}
