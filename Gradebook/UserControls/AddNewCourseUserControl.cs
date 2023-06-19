using Gradebook.Controller;
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
                this.teacherComboBox.Items.Add("No teacher available");
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
            newCourse.Name = this.nameTextBox.Text;
            newCourse.Prefix = this.prefixTextBox.Text;
            newCourse.Number = this.numberTextBox.Text;
            if (Int32.TryParse(this.sectionTextBox.Text, out int section))
            {
                newCourse.Section = section;
            }
            else
            {
                Console.WriteLine("Section could not be parsed.");
            }
            if (Int32.TryParse(this.creditHoursComboBox.Text, out int credit))
            {
                newCourse.CreditHours = credit;
            }
            else
            {
                Console.WriteLine("Credit could not be parsed.");
            }
            newCourse.Semester = this.semesterComboBox.Text;
            newCourse.Year = this.courseYearPicker.Value.Year;
            newCourse.TeacherID = (int)this.teacherComboBox.SelectedValue;

            if (this._courseController.AddNewCourse(newCourse))
            {
                MessageBox.Show("Course Successfully Added");
            } else
            {
                MessageBox.Show("Course was not added, check data and try again");
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
    }
}
