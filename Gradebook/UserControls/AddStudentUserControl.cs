using Gradebook.Controller;
using Gradebook.DAL;
using Gradebook.Function;
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
    /// <summary>
    /// This class manages usercontrol for viewing student information
    /// </summary>
    public partial class AddStudentUserControl : UserControl
    {
        private readonly StudentController _studentController;
        
        /// <summary>
        /// create constructors
        /// </summary>
        public AddStudentUserControl()
        {
            InitializeComponent();
            this._studentController = new StudentController();

            this.SetupGenderComboBox();
            this.SetupStatusComboBox();
            this.SetupDatePickerMinus10Years();
        }

        private void SetupDatePickerMinus10Years()
        {
            this.dobPicker.Value = DateTime.Now.AddYears(-10);
        }

        private void SetupGenderComboBox()
        {
            this.genderComboBox.Items.Insert(0, "-- select --");
            this.genderComboBox.Items.Insert(1, "M");
            this.genderComboBox.Items.Insert(2, "F");
            this.genderComboBox.SelectedIndex = 0;
        }

        private void SetupStatusComboBox()
        {
            this.statusComboBox.Items.Insert(0, "-- select --");
            this.statusComboBox.Items.Insert(1, "Active");
            this.statusComboBox.Items.Insert(2, "Hold");
            this.statusComboBox.Items.Insert(3, "Disable");

            this.statusComboBox.SelectedIndex = 0;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            this.ClearInvalidFields();
            this.ResetInputFields();
        }

        private void ResetInputFields()
        {
            this.firstNameTextBox.Clear();
            this.lastNameTextBox.Clear();
            this.dobPicker.Value = DateTime.Now.AddYears(-10);
            this.phoneTextBox.Clear();
            this.genderComboBox.SelectedIndex = 0;
            this.streetTextBox.Clear();
            this.cityTextBox.Clear();
            this.stateComboBox.SelectedItem = null;
            this.statusComboBox.SelectedIndex = 0;
            this.zipTextBox.Clear();
            this.ssnTextBox.Clear();
        }

        private void ClearInvalidFields()
        {
            this.firstNameErrorMessageLabel.Text = string.Empty;
            this.lastNameErrorMessageLabel.Text = string.Empty;
            this.dobErrorMessageLabel.Text = string.Empty;
            this.phoneErrorMessageLabel.Text = string.Empty;
            this.genderErrorMessageLabel.Text = string.Empty;
            this.statusErrorMessageLabel.Text = string.Empty;
            this.addressErrorMessageLabel.Text = string.Empty;
            this.cityErrorMessageLabel.Text = string.Empty;
            this.stateErrorMessageLabel.Text = string.Empty;
            this.zipErrorMessageLabel.Text = string.Empty;
            this.ssnErrorMessageLabel.Text = string.Empty;
        }
        private void clearButton_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.ResetInputFields();
            this.ClearInvalidFields();
        }

        private void ShowInvalidErrorMessage()
        {

        }

        private void addStudentButton_Click(object sender, EventArgs e)
        {
            string lastName = this.lastNameTextBox.Text.Trim();
            string firstName = this.firstNameTextBox.Text.Trim();
            DateTime dateOfBirth = this.dobPicker.Value;
            string street = this.streetTextBox.Text.Trim();
            string city = this.cityTextBox.Text.Trim();
            string state = this.stateComboBox.Text.Trim();
            string zip = this.zipTextBox.Text.Trim();
            string phone = this.phoneTextBox.Text.Trim();
            string sex = this.genderComboBox.Text.Trim();
            string ssn = this.ssnTextBox.Text.Trim();
            int status = this.statusComboBox.SelectedIndex;


            if (
                string.IsNullOrEmpty(lastName) ||
                !ValidationUtility.IsMoreThanOneLetters(lastName) ||
                string.IsNullOrEmpty(firstName) ||
                !ValidationUtility.IsMoreThanOneLetters(firstName) ||
                dateOfBirth > DateTime.Now ||
                string.IsNullOrEmpty(street) ||
                 !ValidationUtility.IsMoreThanOneLetters(street) ||
                string.IsNullOrEmpty(city) ||
                 !ValidationUtility.IsMoreThanOneLetters(city) ||
                string.IsNullOrEmpty(state) ||
                state.Length != 2 ||
                !ValidationUtility.IsValidZipCode(zip) ||
                !ValidationUtility.IsValidPhoneNumber(phone) ||
                !ValidationUtility.IsGenderValid(sex) ||
                !ValidationUtility.IsSSNValid(ssn) ||
                string.IsNullOrEmpty(ssn) ||
                status < 1 ||
                status > 3

                )
            {
                this.DisplayErrorMessageOnInvalidFields();
            }
            else
            {

                Person newStudent = new Person(lastName, firstName, dateOfBirth, street, city, state, zip, phone, sex, ssn, status);

                if (this._studentController.AddPersonAsStudent(newStudent))
                {
                    string studentInfo = this._studentController.GetTheLastCreatedUsernameInformation(firstName, lastName);
                    MessageBox.Show("Student successfully created!" + "\n" + studentInfo, "Student Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.ResetInputFields();
                }
                else
                {
                    MessageBox.Show("Please check your inputs. Student was not created.");
                }
            }
        }

        private void DisplayErrorMessageOnInvalidFields()
        {
            if
            (string.IsNullOrEmpty(this.lastNameTextBox.Text.Trim()) ||
            !ValidationUtility.IsMoreThanOneLetters(this.lastNameTextBox.Text.Trim()))
            {
                this.lastNameErrorMessageLabel.Text = "Last name must have at least 2 letters.";
                this.lastNameErrorMessageLabel.ForeColor = Color.Red;
            }

            if
             (string.IsNullOrEmpty(this.firstNameTextBox.Text.Trim()) ||
             !ValidationUtility.IsMoreThanOneLetters(this.firstNameTextBox.Text.Trim()))
            {
                this.firstNameErrorMessageLabel.Text = "First name must have at least 2 letters.";
                this.firstNameErrorMessageLabel.ForeColor = Color.Red;
            }

            if (this.dobPicker.Value > DateTime.Now.AddYears(-10))
            {
                this.dobErrorMessageLabel.Text = "Invalid Date. Minimum 10 years old.";
                this.dobErrorMessageLabel.ForeColor = Color.Red;
            }

            if (!ValidationUtility.IsValidPhoneNumber(this.phoneTextBox.Text.Trim()))
            {
                this.phoneErrorMessageLabel.Text = "Please enter your 10 digit phone number, numbers only.";
                this.phoneErrorMessageLabel.ForeColor = Color.Red;
            }

            if (!ValidationUtility.IsGenderValid(this.genderComboBox.Text.Trim()))
            {
                this.genderErrorMessageLabel.Text = "Please enter M or F.";
                this.genderErrorMessageLabel.ForeColor = Color.Red;
            }

            if (!ValidationUtility.IsSSNValid(this.ssnTextBox.Text.Trim()) ||
                string.IsNullOrEmpty(this.ssnTextBox.Text.Trim()))
            {
                this.ssnErrorMessageLabel.Text = "Please enter a valid 9 digit SSN, numbers only.";
                this.ssnErrorMessageLabel.ForeColor = Color.Red;
            }

            if (!ValidationUtility.IsMoreThanOneLetters(this.streetTextBox.Text.Trim()) ||
                string.IsNullOrEmpty(this.streetTextBox.Text.Trim()))
            {
                this.addressErrorMessageLabel.Text = "Please enter your full street address.";
                this.addressErrorMessageLabel.ForeColor = Color.Red;
            }

            if (!ValidationUtility.IsMoreThanOneLetters(this.cityTextBox.Text.Trim()) ||
                string.IsNullOrEmpty(this.cityTextBox.Text.Trim()))
            {
                this.cityErrorMessageLabel.Text = "Please enter your full street address.";
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
            if ((this.statusComboBox.SelectedIndex < 1) || (this.statusComboBox.SelectedIndex > 3))
            {
                this.statusErrorMessageLabel.Text = "Please choose a valid item.";
                this.statusErrorMessageLabel.ForeColor = Color.Red;
            }

        }

    }
}
