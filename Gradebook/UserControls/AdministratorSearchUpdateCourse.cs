using Gradebook.Controller;
using Gradebook.Function;
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

        private void updateCourseButton_Click(object sender, EventArgs e)
        {
            Course updateCourse = new Course();
            if (string.IsNullOrEmpty(this.nameTextBoxUpdate.Text) || !ValidationUtility.IsBetweenNumberOfCharacters(1, 3, this.prefixTextBoxUpdate.Text) ||
                !ValidationUtility.IsBetweenNumberOfCharacters(1, 4, this.numberTextBoxUpdate.Text) || !ValidationUtility.IsInt32(this.sectionTextBoxUpdate.Text) ||
                !ValidationUtility.IsInt32(this.creditHoursComboBoxUpdate.Text) || string.IsNullOrEmpty(this.semesterComboBoxUpdate.Text) ||
                string.IsNullOrEmpty(this.dateTimePickerUpdate.Value.Year.ToString()) || this.teacherComboBoxUpdate.SelectedValue == null)
            {
                this.ValidateDataEntry();
            }
            else
            {
                Course oldCourse = (Course)this.courseDataGridView.SelectedRows[0].DataBoundItem;
                updateCourse.Name = this.nameTextBoxUpdate.Text;
                updateCourse.Prefix = this.prefixTextBoxUpdate.Text;
                updateCourse.Number = this.numberTextBoxUpdate.Text;
                if (Int32.TryParse(this.sectionTextBoxUpdate.Text, out int section))
                {
                    updateCourse.Section = section;
                }
                if (Int32.TryParse(this.creditHoursComboBoxUpdate.Text, out int credit))
                {
                    updateCourse.CreditHours = credit;
                }
                updateCourse.Semester = this.semesterComboBoxUpdate.Text;
                updateCourse.Year = this.dateTimePickerUpdate.Value.Year;
                updateCourse.TeacherID = (int)this.teacherComboBoxUpdate.SelectedValue;

                // Chiaosy iteration 2 
                string currentTeacher_ID = this.teacherComboBox.SelectedValue.ToString();
                                Teacher theTeacher = this._teacherController.GetTeacherByID(Int32.Parse(currentTeacher_ID));
                if (theTeacher.ActiveStatus != 1)
                {
                    MessageBox.Show("The Teacher status is disabled. Please check teacher status first.");
                    return;
                }
                // end iteration 2 modification

                if (this._courseController.UpdateCourse(updateCourse, oldCourse))
                {
                    MessageBox.Show("Course Successfully Updated");
                }
                else
                {
                    MessageBox.Show("Course was not updated, check data and try again");
                }
            }
        }

        private Boolean ValidateDataEntry()
        {
            Boolean status = false;
            if (string.IsNullOrEmpty(this.nameTextBoxUpdate.Text))
            {
                this.nameErrorLabel.Text = "Name cannot be empty";
            }
            if (!ValidationUtility.IsBetweenNumberOfCharacters(1, 3, this.prefixTextBoxUpdate.Text))
            {
                this.prefixErrorLabel.Text = "Prefix must be between 1 and 3 characters";
            }
            if (!ValidationUtility.IsBetweenNumberOfCharacters(1, 4, this.numberTextBoxUpdate.Text))
            {
                this.numberErrorLabel.Text = "Number must be between 1 and 4 characters";
            }
            if (!ValidationUtility.IsInt32(this.sectionTextBoxUpdate.Text))
            {
                this.sectionErrorLabel.Text = "Section must be a number";
            }
            if (!ValidationUtility.IsInt32(this.creditHoursComboBoxUpdate.Text))
            {
                this.creditErrorLabel.Text = "Credit hours must be a number";
            }
            if (string.IsNullOrEmpty(this.semesterComboBoxUpdate.Text))
            {
                this.semesterErrorLabel.Text = "Semester cannot be empty";
            }
            if (string.IsNullOrEmpty(this.dateTimePickerUpdate.Value.Year.ToString()))
            {
                this.yearErrorLabel.Text = "Year cannot be empty";
            }
            if (this.teacherComboBoxUpdate.SelectedValue == null)
            {
                this.teacherErrorLabel.Text = "Teacher cannot be empty";
            }

            return status;
        }

        private void ResetErrorMessages()
        {
            this.nameErrorLabel.Text = string.Empty;
            this.prefixErrorLabel.Text = string.Empty;
            this.numberErrorLabel.Text = string.Empty;
            this.sectionErrorLabel.Text = string.Empty;
            this.semesterErrorLabel.Text = string.Empty;
            this.creditErrorLabel.Text = string.Empty;
            this.teacherErrorLabel.Text = string.Empty;
            this.yearErrorLabel.Text = string.Empty;
        }

        private void nameTextBoxUpdate_TextChanged(object sender, EventArgs e)
        {
            this.ResetErrorMessages();
        }
    }
}
