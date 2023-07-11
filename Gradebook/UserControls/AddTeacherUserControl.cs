using Gradebook.Controller;
using Gradebook.Function;
using Gradebook.Model;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Gradebook.UserControls
{
    /// <summary>
    /// The usercontrol to add teachers
    /// </summary>
    public partial class AddTeacherUserControl : UserControl
    {
        private TeacherController _teacherController;

        /// <summary>
        /// The usercontrol for the add teacher form
        /// </summary>
        public AddTeacherUserControl()
        {
            InitializeComponent();
            this._teacherController= new TeacherController();   
        }

        /// <summary>
        /// Clears all textboxes on page
        /// </summary>
        public void ResetInputFields()
        {
            lastNameTextBox.Clear();
            firstNameTextBox.Clear();
            dateOfBirthDateTimePicker.Value = DateTime.Now;
            phoneTextBox.Clear();
            addressTextBox.Clear();
            cityTextBox.Clear();
            stateComboBox.SelectedItem = null;
            zipTextBox.Clear();
            ssnTextBox.Clear();
            stateComboBox.SelectedItem = null;
            sexComboBox.SelectedItem = null;    
        }
        private void clearButton_Click(object sender, EventArgs e)
        {
            ResetInputFields();
            this.HideInvalidErrorMessages();
        }

        private void addTeacherButton_Click(object sender, EventArgs e)
        {
            string lastName = this.lastNameTextBox.Text.Trim();
            string firstName = this.firstNameTextBox.Text.Trim();
            DateTime dateOfBirth = this.dateOfBirthDateTimePicker.Value;
            string phone = this.phoneTextBox.Text.Trim();
            string address = this.addressTextBox.Text.Trim();
            string city = this.cityTextBox.Text.Trim();
            string state = this.stateComboBox.Text;
            string zip = this.zipTextBox.Text.Trim();
            string sex = this.sexComboBox.Text;
            string ssn = this.ssnTextBox.Text.Trim();
            // string status = this.statusComboBox.Text;

            if (string.IsNullOrEmpty(lastName) || !ValidationUtility.IsMoreThanOneLetters(lastName) ||
                string.IsNullOrEmpty(firstName) || !ValidationUtility.IsMoreThanOneLetters(firstName) ||
                dateOfBirth > DateTime.Now || string.IsNullOrEmpty(address) ||
                !ValidationUtility.IsMoreThanOneLetters(address) || string.IsNullOrEmpty(city) ||
                !ValidationUtility.IsMoreThanOneLetters(city) || string.IsNullOrEmpty(state) ||
                state.Length != 2 || !ValidationUtility.IsValidZipCode(zip) ||
                !ValidationUtility.IsValidPhoneNumber(phone) || !ValidationUtility.IsGenderValid(sex) ||
                !ValidationUtility.IsSSNValid(ssn) || string.IsNullOrEmpty(ssn))
            {
                this.ShowInvalidErrorMessage();
            }
            else
            {
                Person person = new Person(lastName, firstName, dateOfBirth, address, city, state, zip, phone, sex, ssn);
                bool success = this._teacherController.AddPersonAsTeacher(person);
                if (success)
                {
                    MessageBox.Show("Teacher successfully created!", "Teacher Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.ResetInputFields();
                }
            }
        }

        private void ShowInvalidErrorMessage()
        {
            if (string.IsNullOrEmpty(lastNameTextBox.Text) || string.IsNullOrWhiteSpace(lastNameTextBox.Text) ||
                !ValidationUtility.IsMoreThanOneLetters(this.lastNameTextBox.Text.Trim()))
            {
                this.lastNameErrorMessageLabel.Text = "Please enter your last name.";
                this.lastNameErrorMessageLabel.ForeColor = Color.Red;
            }

            if (string.IsNullOrEmpty(firstNameTextBox.Text) || string.IsNullOrWhiteSpace(firstNameTextBox.Text) ||
                 !ValidationUtility.IsMoreThanOneLetters(this.firstNameTextBox.Text.Trim()))
            {
                this.firstNameErrorMessageLabel.Text = "Please enter your first name.";
                this.firstNameErrorMessageLabel.ForeColor = Color.Red;
            }

            if (this.dateOfBirthDateTimePicker.Value > DateTime.Now)
            {
                this.DOBErrorLabel.Text = "Invalid Date. Birthday cannot be in future.";
                this.DOBErrorLabel.ForeColor = Color.Red;
            }

            if (!ValidationUtility.IsMoreThanOneLetters(this.addressTextBox.Text.Trim()) ||
                    string.IsNullOrEmpty(this.addressTextBox.Text.Trim()))
            {
                this.addressErrorMessageLabel.Text = "Please enter your full street address.";
                this.addressErrorMessageLabel.ForeColor = Color.Red;
            }

            if (!ValidationUtility.IsMoreThanOneLetters(this.cityTextBox.Text.Trim()) ||
                    string.IsNullOrEmpty(this.cityTextBox.Text.Trim()))
            {
                this.cityErrorMessageLabel.Text = "Please enter your city.";
                this.cityErrorMessageLabel.ForeColor = Color.Red;
            }

            if (this.stateComboBox.Text.Trim().Length != 2 || string.IsNullOrEmpty(this.stateComboBox.Text.Trim()))
            {
                this.stateErrorMessageLabel.Text = "Please select your state abbreviation.";
                this.stateErrorMessageLabel.ForeColor = Color.Red;
            }

            if (!ValidationUtility.IsValidZipCode(this.zipTextBox.Text.Trim()))
            {
                this.zipErrorMessageLabel.Text = "Please enter a valid zipcode.";
                this.zipErrorMessageLabel.ForeColor = Color.Red;
            }

            if (!ValidationUtility.IsValidPhoneNumber(this.phoneTextBox.Text.Trim()))
            {
                this.phoneErrorLabel.Text = "Please enter your 10 digit phone only numbers.";
                this.phoneErrorLabel.ForeColor = Color.Red;
            }

            if (!ValidationUtility.IsGenderValid(this.sexComboBox.Text.Trim()))
            {
                this.sexErrorMessageLabel.Text = "Please enter M or F.";
                this.sexErrorMessageLabel.ForeColor = Color.Red;
            }

            if (!ValidationUtility.IsSSNValid(this.ssnTextBox.Text.Trim()) || string.IsNullOrEmpty(this.ssnTextBox.Text.Trim()))
            {
                this.ssnErrorMessageLabel.Text = "Please enter a valid 9 digit SSN, numbers only.";
                this.ssnErrorMessageLabel.ForeColor = Color.Red;
            }
        }

        private void HideInvalidErrorMessages()
        {
            this.lastNameErrorMessageLabel.Text = "";
            this.firstNameErrorMessageLabel.Text = "";
            this.DOBErrorLabel.Text = "";
            this.addressErrorMessageLabel.Text = "";
            this.ssnErrorMessageLabel.Text = "";
            this.cityErrorMessageLabel.Text = "";
            this.stateErrorMessageLabel.Text = "";
            this.zipErrorMessageLabel.Text = "";
            this.sexErrorMessageLabel.Text = "";
            this.statusErrorMessageLabel.Text = "";
            this.phoneErrorLabel.Text = "";
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            this.HideInvalidErrorMessages();
        }

        private void ComboboxOrDateTimePicker_MouseDown(object sender, MouseEventArgs e)
        {
            this.HideInvalidErrorMessages();
        }

    }

}
