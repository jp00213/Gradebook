using Gradebook.Controller;
using Gradebook.Model;
using System;
using System.Text.RegularExpressions;
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
            this._teacher = this._teacherController.GetTeacherByID(Int32.Parse(teacherID));

            if (_teacher != null)
            {
                teacherBindingSource.DataSource = _teacher;
                teacherBindingSource.ResetBindings(true);
                this.saveButton.Enabled = true;
            }
        }

        private void dobDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if(_teacher != null)
            {
                this.dobDateTimePicker.Value = this._teacher.DateOfBirth.Date;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string lastName = this.lastNameTextbox.Text.Trim();
            string firstName = this.firstNameTextbox.Text.Trim();
            DateTime dob = this.dobDateTimePicker.Value;
            string phone = this.phoneTextBox.Text.Trim();
            string address = this.addressTextBox.Text.Trim();
            string city = this.cityTextBox.Text.Trim();
            string state = this.stateComboBox.Text;
            string zip = this.zipTextBox.Text.Trim();
            string sex = this.sexComboBox.Text;
            string status = this.statusComboBox.Text;
            Teacher oldTeacher = _teacher;

            if (string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(firstName) || dob > DateTime.Now || string.IsNullOrEmpty(address) || address.Length < 5 || string.IsNullOrEmpty(city) || string.IsNullOrEmpty(state) || !IsValidZipCode(zip) || !IsPhoneNumberValid(phone) || string.IsNullOrEmpty(sex) || string.IsNullOrEmpty(status))
            {
                this.ShowInvalidErrorMessages();
            }
            else
            {
                bool success = this._teacherController.UpdateTeacher(oldTeacher.RecordId, lastName, firstName, dob, address, city, state, zip, phone);
                if (success)
                {
                    MessageBox.Show("Patient successfully updated!", "Patient Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.ResetForm();
                }
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            this.ResetForm();
            this.HideInvalidErrorMessages();
        }

        private void ResetForm()
        {

        }

        private void ShowInvalidErrorMessages()
        {

        }

        private void HideInvalidErrorMessages()
        {

        }

        private bool IsValidZipCode(string zip)
        {
            string usZipRegEx = @"^\d{5}(\d{4})?$";

            bool validZipCode = true;
            if ((!Regex.Match(zip, usZipRegEx).Success))
            {
                validZipCode = false;
            }
            return validZipCode;
        }

        private bool IsPhoneNumberValid(string phoneNumber)
        {
            string phoneRegEx = @"^\d{10}$";
            bool validPhoneNumber = true;
            if (!Regex.Match(phoneNumber, phoneRegEx).Success)
            {
                validPhoneNumber = false;
            }
            return validPhoneNumber;
        }
    }
}
