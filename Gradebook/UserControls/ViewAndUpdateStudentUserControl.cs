using Gradebook.Controller;
using Gradebook.Function;
using Gradebook.Model;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Gradebook.UserControls
{
    /// <summary>
    /// This class manages usercontrol for updating student information
    /// </summary>
    public partial class ViewAndUpdateStudentUserControl : UserControl
    {
        /// <summary>
        /// create constructors
        /// </summary>
        private readonly StudentController _studentController;
        private Person theStudent;

        /// <summary>
        /// The update student user control
        /// </summary>
        public ViewAndUpdateStudentUserControl()
        {
            InitializeComponent();
            this._studentController = new StudentController();

            this.SetupGenderComboBox();
            this.SetupStatusComboBox();
            this.SetupDatePickerMinus10Years();
            theStudent = new Student();
            viewOnlyRadioButton.Checked = true;
            this.DisableEdit();
            this.viewOnlyRadioButton.Enabled = false;
            this.editRadioButton.Enabled = false;
        }

        /// <summary>
        /// when the ID change, load the new Student data and populate them to each field.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void currentStudentIDForEdit_TextChanged(object sender, EventArgs e)
        {
            this.LoadStudent();
        }

        private void LoadStudent()
        {
            theStudent = new Student();
            theStudent = this._studentController.GetStudentByID(Convert.ToInt32(this.currentStudentIDForEdit.Text));

            viewOnlyRadioButton.Checked = true;
            firstNameTextBox.Text = theStudent.FirstName;
            lastNameTextBox.Text = theStudent.LastName;

            DateTime minDateAccept = new DateTime(1900, 1, 1);

            if (theStudent.DateOfBirth == null || theStudent.DateOfBirth < minDateAccept)
            {
                dobPicker.Value = minDateAccept;
            }
            else
            {
                dobPicker.Value = theStudent.DateOfBirth;
            }

            phoneTextBox.Text = theStudent.Phone;
            genderComboBox.Text = theStudent.Sex;
            streetTextBox.Text = theStudent.AddressStreet;
            cityTextBox.Text = theStudent.City;
            stateComboBox.Text = theStudent.State;
            zipTextBox.Text = theStudent.Zip;
            ssnTextBox.Text = theStudent.SSN;
            label1.Text = theStudent.RecordId.ToString();
            //maximumAllowedUnitsComboBox.Text = "";
            //maximumAllowedUnitsComboBox.Text = theStudent.MaximumUnitsAllowed.ToString();
            if (theStudent.MaximumUnitsAllowed == null)
            {
                maximumAllowedUnitsComboBox.SelectedItem = null;
            }
            else
            {
                maximumAllowedUnitsComboBox.Text = theStudent.MaximumUnitsAllowed.ToString();
            };


            statusComboBox.SelectedIndex = theStudent.ActiveStatus;
            //  System.Windows.Forms.MessageBox.Show(theStudent.ActiveStatus.ToString());
            this.DisableEdit();
            this.viewOnlyRadioButton.Enabled = true;
            this.editRadioButton.Enabled = true;
            this.EnableViewEditRadioButtonIfIDIsNotZero();
        }

        private void EnableViewEditRadioButtonIfIDIsNotZero()
        {
            if (currentStudentIDForEdit.Text != "0")
            {
                this.viewOnlyRadioButton.Enabled = true;
                this.editRadioButton.Enabled = true;
            }
        }

        private void editRadioButton_Click(object sender, EventArgs e)
        {
            this.EnableEdit();
        }

        private void viewOnlyRadioButton_Click(object sender, EventArgs e)
        {
            this.DisableEdit();
        }

        private void DisableEdit()
        {
            firstNameTextBox.Enabled = false;
            lastNameTextBox.Enabled = false;
            dobPicker.Enabled = false;
            phoneTextBox.Enabled = false;
            genderComboBox.Enabled = false;
            streetTextBox.Enabled = false;
            cityTextBox.Enabled = false;
            stateComboBox.Enabled = false;
            zipTextBox.Enabled = false;
            ssnTextBox.Enabled = false;
            statusComboBox.Enabled = false;
            updateStudentButton.Enabled = false;
            maximumAllowedUnitsComboBox.Enabled = false;
        }

        private void EnableEdit()
        {
            firstNameTextBox.Enabled = true;
            lastNameTextBox.Enabled = true;
            dobPicker.Enabled = true;
            phoneTextBox.Enabled = true;
            genderComboBox.Enabled = true;
            streetTextBox.Enabled = true;
            cityTextBox.Enabled = true;
            stateComboBox.Enabled = true;
            zipTextBox.Enabled = true;
            ssnTextBox.Enabled = true;
            statusComboBox.Enabled = true;
            updateStudentButton.Enabled = true;
            maximumAllowedUnitsComboBox.Enabled = true;
        }

        /// <summary>
        /// this is for the top panel to set the sub panel student ID
        /// </summary>
        /// <param name="currentStudentIDIn"></param>
        public void SetCurrentViewEditID(string currentStudentIDIn)
        {
            this.currentStudentIDForEdit.Text = currentStudentIDIn;
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
            //      this.genderComboBox.SelectedIndex = 0;
        }

        private void SetupStatusComboBox()
        {
            this.statusComboBox.Items.Insert(0, "-- select --");
            this.statusComboBox.Items.Insert(1, "Active");
            this.statusComboBox.Items.Insert(2, "Hold");
            this.statusComboBox.Items.Insert(3, "Disable");
            //     this.statusComboBox.SelectedIndex = 0;
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

        private void updateStudentButton_Click(object sender, EventArgs e)
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
            int? maximumUnitsAllowed = null;
            if (this.maximumAllowedUnitsComboBox.Text.Trim() is null || this.maximumAllowedUnitsComboBox.Text.Trim() == "")
            {
                maximumUnitsAllowed = null;
            }
            else
            {
                maximumUnitsAllowed = Convert.ToInt32(this.maximumAllowedUnitsComboBox.Text.Trim());
            }
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
                //int recordID, int studentID, string lastName, string firstName, DateTime dateofBirth, string addressStreet, string city, string state, string zip, string phone, string sex, string ssn, int activeStatus, string username)
                Person newStudent = new Person(theStudent.RecordId, theStudent.StudentID, lastName, firstName, dateOfBirth, street, city, state, zip, phone, sex, ssn, status, theStudent.Username);
                newStudent.MaximumUnitsAllowed = maximumUnitsAllowed;
                if (this._studentController.UpdateStudent(newStudent, theStudent) == true)
                {
                    this.LoadStudent();
                    MessageBox.Show("The update is successful.");
                }
                else
                {
                    MessageBox.Show("Please check your inputs. Update failed.");
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

        private void TextBox_changed(object sender, EventArgs e)
        {
            this.ClearInvalidFields();
        }

    }
}
