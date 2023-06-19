using Gradebook.Controller;
using Gradebook.Model;
using System;
using System.Drawing;
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
            /*if(_teacher != null)
            {
                this.dobDateTimePicker.Value = this._teacher.DateOfBirth.Date;
            }*/
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
            string ssn = this.statusComboBox.Text;
            Teacher oldTeacher = _teacher;

            if (string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(firstName) || dob > DateTime.Now || string.IsNullOrEmpty(address) || address.Length < 5 || string.IsNullOrEmpty(city) || string.IsNullOrEmpty(state) || !IsValidZipCode(zip) || !IsPhoneNumberValid(phone) || string.IsNullOrEmpty(sex) || string.IsNullOrEmpty(ssn))
            {
                this.ShowInvalidErrorMessages();
            }
            else
            {
                bool success = this._teacherController.UpdateTeacher(oldTeacher.RecordId, lastName, firstName, dob, address, city, state, zip, phone, sex, ssn);
                if (success)
                {
                    MessageBox.Show("Teacher successfully updated!", "Teacher Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.ResetForm();
                }
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            this.ClearEdits();
            this.HideInvalidErrorMessages();
        }

        private void ResetForm()
        {
            this.firstNameTextbox.Text = "";
            this.lastNameTextbox.Text = "";
            this.dobDateTimePicker.Value = DateTime.Now;
            this.searchButton_Click(null, null);

        }

        private void ClearEdits()
        {
            this._teacher = null;
            this.teacherBindingSource.DataSource = this._teacherController.GetTeacherByNameDOB("", "", DateTime.Now);
            this.saveButton.Enabled = false;
        }

        private void ShowInvalidErrorMessages()
        {
            if (string.IsNullOrEmpty(resultsLastNameTextBox.Text) || string.IsNullOrWhiteSpace(resultsLastNameTextBox.Text))
            {
                this.lastNameErrorLabel.Text = "Please enter your last name.";
                this.lastNameErrorLabel.ForeColor = Color.Red;
            }

            if (string.IsNullOrEmpty(resultsFirstNameTextbox.Text) || string.IsNullOrWhiteSpace(resultsFirstNameTextbox.Text))
            {
                this.firstNameErrorLabel.Text = "Please enter your first name.";
                this.firstNameErrorLabel.ForeColor = Color.Red;
            }

            if (resultsDOBDateTimePicker.Value > DateTime.Now)
            {
                this.DOBErrorLabel.Text = "DOB cannot be in the future.";
                this.DOBErrorLabel.ForeColor = Color.Red;
            }

            if (string.IsNullOrEmpty(addressTextBox.Text) || string.IsNullOrWhiteSpace(addressTextBox.Text) || addressTextBox.Text.Length < 5)
            {
                this.addressErrorLabel.Text = "Please enter your full street address.";
                this.addressErrorLabel.ForeColor = Color.Red;
            }

            if (string.IsNullOrEmpty(cityTextBox.Text) || string.IsNullOrWhiteSpace(cityTextBox.Text))
            {
                this.cityErrorLabel.Text = "Please enter your city.";
                this.cityErrorLabel.ForeColor = Color.Red;
            }

            if (string.IsNullOrEmpty(stateComboBox.Text))
            {
                this.stateErrorLabel.Text = "Please select your state abbreviation.";
                this.stateErrorLabel.ForeColor = Color.Red;
            }

            if (!IsValidZipCode(zipTextBox.Text))
            {
                this.zipErrorLabel.Text = "Please enter a valid zipcode.";
                this.zipErrorLabel.ForeColor = Color.Red;
            }

            if (!IsPhoneNumberValid(phoneTextBox.Text))
            {
                this.phoneErrorLabel.Text = "Please enter your 10 digit phone only numbers.";
                this.phoneErrorLabel.ForeColor = Color.Red;
            }

            if (!IsSexValid(sexComboBox.Text))
            {
                this.sexErrorLabel.Text = "Please enter M or F.";
                this.sexErrorLabel.ForeColor = Color.Red;
            }

            if (!IsSSNValid(ssnTextBox.Text))
            {
                this.ssnErrorLabel.Text = "Please enter a valid 9 digit SSN, numbers only.";
                this.ssnErrorLabel.ForeColor = Color.Red;
            }
        }

        private void HideInvalidErrorMessages()
        {
            this.lastNameErrorLabel.Text = "";
            this.firstNameErrorLabel.Text = "";
            this.DOBErrorLabel.Text = "";
            this.addressErrorLabel.Text = "";
            this.phoneErrorLabel.Text = "";
            this.cityErrorLabel.Text = "";
            this.stateErrorLabel.Text = "";
            this.zipErrorLabel.Text = "";
            this.sexErrorLabel.Text = "";
            this.ssnErrorLabel.Text = "";
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

        private bool IsSSNValid(string ssn)
        {
            string ssnRegEx = @"^[0-9]{9}$";
            bool validSSN = true;
            if (ssn.Equals(""))
            {
                validSSN = true;
            }
            else if (!Regex.Match(ssn, ssnRegEx).Success)
            {
                validSSN = false;
            }
            return validSSN;
        }

        private bool IsSexValid(string sex)
        {
            bool validSex = true;
            if (String.Equals(sex, "M") || String.Equals(sex, "F"))
            {
                validSex = true;
            }
            else
            {
                validSex = false;
            }
            return validSex;
        }
    }
}
