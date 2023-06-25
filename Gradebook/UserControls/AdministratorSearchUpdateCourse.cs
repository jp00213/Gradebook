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
                this.courseDataGridView.DataSource = this._courseController.GetCoursesByYearSemester(this.semesterComboBox.Text, this.courseYearPicker.Value.Year);
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
    }
}
