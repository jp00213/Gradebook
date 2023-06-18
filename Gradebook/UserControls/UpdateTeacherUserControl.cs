using Gradebook.Controller;
using Gradebook.Model;
using System;
using System.Windows.Forms;

namespace Gradebook.UserControls
{
    public partial class UpdateTeacherUserControl : UserControl
    {

        private TeacherController _teacherController;
        private Teacher _teacher;
        public UpdateTeacherUserControl()
        {
            InitializeComponent();
            this._teacherController = new TeacherController();
            this._teacher= new Teacher();   
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string firstName = this.firstNameTextbox.Text;
            string lastName = this.lastNameTextbox.Text;
            DateTime dob = this.dobDateTimePicker.Value;

            this.teacherSearchDataGridView.DataSource = _teacherController.GetTeacherByNameDOB(firstName, lastName, dob);
        }

        private void teacherSearchDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var teacherID = teacherSearchDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            this._teacher = this._teacherController.GetTeacherById(Int32.Parse(teacherID));

            if (_teacher != null)
            {
                teacherBindingSource.DataSource = _teacher;
                teacherBindingSource.ResetBindings(true);
                this.update
            }
        }
    }
}
