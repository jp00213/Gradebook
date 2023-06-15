using Gradebook.Controller;
using Gradebook.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
