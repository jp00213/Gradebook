using Gradebook.Controller;
using Gradebook.Model;
using System;
using System.Windows.Forms;

namespace Gradebook.UserControls
{
    /// <summary>
    /// UserControl for administrator to search for and update courses
    /// </summary>
    public partial class AdministratorSearchUpdateCourse : UserControl
    {
        private readonly CourseController _courseController;
        private readonly TeacherController _teacherController;

        /// <summary>
        /// Constructor for user control
        /// </summary>
        public AdministratorSearchUpdateCourse()
        {
            InitializeComponent();
            this._courseController = new CourseController();
            this._teacherController = new TeacherController();
            try
            {
                this.teacherComboBox.DataSource = this._teacherController.GetAllActiveTeachers();
                this.teacherComboBox.DisplayMember = "FullName";
                this.teacherComboBox.ValueMember = "TeacherID";
                this.teacherComboBoxUpdate.DataSource = this._teacherController.GetAllActiveTeachers();
                this.teacherComboBoxUpdate.DisplayMember = "FullName";
                this.teacherComboBoxUpdate.ValueMember = "TeacherID";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.teacherComboBox.Items.Insert(0, "No teacher available");
                this.teacherComboBoxUpdate.Items.Insert(0, "No teacher available");
            }
        }

        private void searchCourseButton_Click(object sender, System.EventArgs e)
        {
            try
            {
                Course parameters = new Course
                {
                    Name = this.nameTextBox.Text,
                    Prefix = this.prefixTextBox.Text,
                    Number = this.numberTextBox.Text,
                    Year = this.courseYearPicker.Value.Year,
                    Semester = this.semesterComboBox.Text,
                    TeacherID = (int)this.teacherComboBox.SelectedValue
                };

                this.courseDataGridView.DataSource = this._courseController.GetCoursesByMultipleParameters(parameters);
            }
            catch { }
        }

        private void courseDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Course viewCourse = (Course)this.courseDataGridView.SelectedRows[0].DataBoundItem;

            this.nameTextBoxUpdate.Text = viewCourse.Name;
            this.creditHoursComboBoxUpdate.Text = viewCourse.CreditHours.ToString();
            this.prefixTextBoxUpdate.Text = viewCourse.Prefix;
            this.numberTextBoxUpdate.Text = viewCourse.Number;
            this.sectionTextBoxUpdate.Text = viewCourse.Section.ToString();
            this.dateTimePickerUpdate.Value = DateTime.Parse(viewCourse.Year.ToString() + "-01-01");
            this.semesterComboBoxUpdate.Text = viewCourse.Semester;
            this.teacherComboBoxUpdate.SelectedValue = viewCourse.TeacherID;
        }

        private void clearSearchButton_Click(object sender, EventArgs e)
        {
            this.ClearSearchDetails();
        }

        private void deleteCourseButton_Click(object sender, EventArgs e)
        {
            Course viewCourse = (Course)this.courseDataGridView.SelectedRows[0].DataBoundItem;
            if (this._courseController.DeleteCourse(viewCourse.CourseID))
            {
                MessageBox.Show("Course deleted");
                this.ClearCourseDetails();
            }
            else
            {
                MessageBox.Show("Course was not deleted. Check student registrations.");
            }

        }

        private void clearCourseButton_Click(object sender, EventArgs e)
        {
            this.ClearCourseDetails();
        }

        private void ClearCourseDetails()
        {
            this.nameTextBoxUpdate.Text = "";
            this.creditHoursComboBoxUpdate.Text = "";
            this.prefixTextBoxUpdate.Text = "";
            this.numberTextBoxUpdate.Text = "";
            this.sectionTextBoxUpdate.Text = "";
            this.dateTimePickerUpdate.Value = DateTime.Now;
            this.semesterComboBoxUpdate.SelectedValue = 0;
            this.teacherComboBoxUpdate.SelectedValue = 0;
        }

        private void ClearSearchDetails()
        {
            this.nameTextBox.Text = "";
            this.prefixTextBox.Text = "";
            this.numberTextBox.Text = "";
            this.courseYearPicker.Value = DateTime.Now;
            this.semesterComboBox.SelectedIndex = 0;
            this.teacherComboBox.SelectedIndex = 0;
        }
    }
}
