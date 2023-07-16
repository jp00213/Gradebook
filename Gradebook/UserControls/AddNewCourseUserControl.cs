using Gradebook.Controller;
using Gradebook.Function;
using Gradebook.Model;
using System;
using System.Windows.Forms;

namespace Gradebook.UserControls
{
    /// <summary>
    /// Add New Course UserControl
    /// </summary>
    public partial class AddNewCourseUserControl : UserControl
    {
        private readonly CourseController _courseController;
        private readonly TeacherController _teacherController;

        /// <summary>
        /// Constructor for UserControl
        /// </summary>
        public AddNewCourseUserControl()
        {
            InitializeComponent();
            this._courseController = new CourseController();
            this._teacherController = new TeacherController();
            try
            {
                this.teacherComboBox.DataSource = this._teacherController.GetAllActiveTeachers();
                this.teacherComboBox.DisplayMember = "FullName";
                this.teacherComboBox.ValueMember = "TeacherID";
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.teacherComboBox.Items.Insert(0, "No teacher available");
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            this.ResetFields();
            this.ResetErrorMessages();
        }

        private void addCourseButton_Click(object sender, EventArgs e)
        {
            Course newCourse = new Course();
            if (string.IsNullOrEmpty(this.nameTextBox.Text) || !ValidationUtility.IsBetweenNumberOfCharacters(1, 3, this.prefixTextBox.Text) ||
                !ValidationUtility.IsBetweenNumberOfCharacters(1, 4, this.numberTextBox.Text) || !ValidationUtility.IsInt32(this.sectionTextBox.Text) ||
                !ValidationUtility.IsInt32(this.creditHoursComboBox.Text) || string.IsNullOrEmpty(this.semesterComboBox.Text) ||
                string.IsNullOrEmpty(this.courseYearPicker.Value.Year.ToString()) || this.teacherComboBox.SelectedValue == null)
            {
                this.ValidateDataEntry();
            }
            else
            {
                newCourse.Name = this.nameTextBox.Text;
                newCourse.Prefix = this.prefixTextBox.Text;
                newCourse.Number = this.numberTextBox.Text;
                if (Int32.TryParse(this.sectionTextBox.Text, out int section))
                {
                    newCourse.Section = section;
                }
                if (Int32.TryParse(this.creditHoursComboBox.Text, out int credit))
                {
                    newCourse.CreditHours = credit;
                }
                newCourse.Semester = this.semesterComboBox.Text;
                newCourse.Year = this.courseYearPicker.Value.Year;
                newCourse.TeacherID = (int)this.teacherComboBox.SelectedValue;

                // Chiaosy iteration 2 

                string currentTeacher_ID = this.teacherComboBox.SelectedValue.ToString();

                Teacher theTeacher = this._teacherController.GetTeacherByID(Int32.Parse(currentTeacher_ID));

                if (theTeacher.ActiveStatus != 1)
                {
                    MessageBox.Show("The Teacher status is disabled. Please check teacher status first.", "Status Disabled", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // end iteration 2 modification

                if (this._courseController.AddNewCourse(newCourse))
                {
                    MessageBox.Show("Course Successfully Added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Course was not added, check data and try again.", "Course Not Added", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ResetFields()
        {
            this.nameTextBox.Text = string.Empty;
            this.prefixTextBox.Text = string.Empty;
            this.numberTextBox.Text = string.Empty;
            this.sectionTextBox.Text = string.Empty;
            this.semesterComboBox.SelectedIndex = 0;
            this.creditHoursComboBox.SelectedIndex = 0;
            this.teacherComboBox.SelectedIndex = 0;
            this.courseYearPicker.Value = DateTime.Now;
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

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            this.ResetErrorMessages();
        }

        private Boolean ValidateDataEntry()
        {
            Boolean status = false;
            if (string.IsNullOrEmpty(this.nameTextBox.Text))
            {
                this.nameErrorLabel.Text = "Name cannot be empty";
            }
            if (!ValidationUtility.IsBetweenNumberOfCharacters(1, 3, this.prefixTextBox.Text))
            {
                this.prefixErrorLabel.Text = "Prefix must be between 1 and 3 characters";
            }
            if (!ValidationUtility.IsBetweenNumberOfCharacters(1, 4, this.numberTextBox.Text))
            {
                this.numberErrorLabel.Text = "Number must be between 1 and 4 characters";
            }
            if (!ValidationUtility.IsInt32(this.sectionTextBox.Text))
            {
                this.sectionErrorLabel.Text = "Section must be a number";
            }
            if (!ValidationUtility.IsInt32(this.creditHoursComboBox.Text))
            {
                this.creditErrorLabel.Text = "Credit hours must be a number";
            }
            if (string.IsNullOrEmpty(this.semesterComboBox.Text))
            {
                this.semesterErrorLabel.Text = "Semester cannot be empty";
            }
            if (string.IsNullOrEmpty(this.courseYearPicker.Value.Year.ToString()))
            {
                this.yearErrorLabel.Text = "Year cannot be empty";
            }
            if (this.teacherComboBox.SelectedValue == null)
            {
                this.teacherErrorLabel.Text = "Teacher cannot be empty";
            }

            return status;
        }
    }
}
