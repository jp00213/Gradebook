using Gradebook.Controller;
using Gradebook.Function;
using Gradebook.Model;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Gradebook.UserControls
{
    /// <summary>
    /// Student profile user control
    /// </summary>
    public partial class StudentProfileUserControl : UserControl
    {

        private StudentController _studentController;
        private Person _student;

        /// <summary>
        /// Student profile user control
        /// </summary>
        public StudentProfileUserControl()
        {
            InitializeComponent();
            this._studentController = new StudentController();
            this._student = null;
            this.SetupComboBoxes();

        }

        /// <summary>
        /// Sets current studentID
        /// </summary>
        /// <param name="username"></param>
        public void SetCurrentStudentID(string username)
        {
            Person person = new Person();
            person = this._studentController.GetStudentByUsername(username);
            String name = person.FirstName + ' ' + person.LastName;
            int studentID = person.StudentID;
            this.studentIDtextBox.Text = studentID.ToString();
            this._student = this.GetCurrentStudent(studentID);
        }

        private Person GetCurrentStudent(int studentID)
        {
            this._student = this._studentController.GetStudentByID(studentID);
            return this._student;
        }

        private void FillStudentInfo()
        {
            try
            {
                this.studentIDtextBox.Text = this._student.StudentID.ToString();
                this.firstNameTextbox.Text = this._student.FirstName;
                this.lastNameTextBox.Text = this._student.LastName;
                this.dobDateTimePicker.Value = this._student.DateOfBirth;
                this.ssnTextBox.Text = this._student.SSN;
                this.sexComboBox.Text = this._student.Sex;
                this.addressTextBox.Text = this._student.AddressStreet;
                this.cityTextBox.Text = this._student.City;
                this.stateComboBox.Text = this._student.State;
                this.zipTextBox.Text = this._student.Zip;
                this.phoneTextBox.Text = this._student.Phone;
                this.activeStatusComboBox.SelectedIndex = this._student.ActiveStatus;
                
                this.saveButton.Enabled = false;
            } catch (Exception)
            {
                MessageBox.Show("Please log in as a student.", "Error", MessageBoxButtons.OK);
            }
        }

        private void SetupComboBoxes()
        {
            this.activeStatusComboBox.Items.Insert(0, "-- select --");
            this.activeStatusComboBox.Items.Insert(1, "Active");
            this.activeStatusComboBox.Items.Insert(2, "Hold");
            this.activeStatusComboBox.Items.Insert(3, "Disable");
            this.sexComboBox.Items.Insert(0, "M");
            this.sexComboBox.Items.Insert(1, "F");
        }

        private void StudentProfileUserControl_Enter(object sender, EventArgs e)
        {
            this.FillStudentInfo();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            this.saveButton.Enabled = true;
            this.firstNameTextbox.Enabled = true;
            this.lastNameTextBox.Enabled = true;
            this.dobDateTimePicker.Enabled = true;
            this.ssnTextBox.Enabled = true;
            this.sexComboBox.Enabled = true;
            this.addressTextBox.Enabled = true;
            this.cityTextBox.Enabled = true;
            this.stateComboBox.Enabled = true;
            this.zipTextBox.Enabled = true;
            this.phoneTextBox.Enabled = true;

        }


        private void RefreshPage()
        {
            this.GetCurrentStudent(this._student.StudentID);
            this.FillStudentInfo();
            this.saveButton.Enabled = false;
            this.firstNameTextbox.Enabled = false;
            this.lastNameTextBox.Enabled = false;
            this.dobDateTimePicker.Enabled = false;
            this.ssnTextBox.Enabled = false;
            this.sexComboBox.Enabled = false;
            this.addressTextBox.Enabled = false;
            this.cityTextBox.Enabled = false;
            this.stateComboBox.Enabled = false;
            this.zipTextBox.Enabled = false;
            this.phoneTextBox.Enabled = false;

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (!this.firstNameTextbox.Enabled)
            {
                MessageBox.Show("Please click the edit button to make edits, then click save.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                Person oldStudent = this._student;
                Person newStudent = new Person
                {
                    LastName = this.lastNameTextBox.Text.Trim(),
                    FirstName = this.firstNameTextbox.Text.Trim(),
                    DateOfBirth = this.dobDateTimePicker.Value,
                    Phone = this.phoneTextBox.Text.Trim(),
                    AddressStreet = this.addressTextBox.Text.Trim(),
                    City = this.cityTextBox.Text.Trim(),
                    State = this.stateComboBox.Text.Trim(),
                    Zip = this.zipTextBox.Text.Trim(),
                    Sex = this.sexComboBox.Text.Trim(),
                    SSN = this.ssnTextBox.Text.Trim(),
                    ActiveStatus = this.activeStatusComboBox.SelectedIndex
                };
                string lastName = this.lastNameTextBox.Text.Trim();
                string firstName = this.firstNameTextbox.Text.Trim();
                DateTime dob = this.dobDateTimePicker.Value;
                string phone = this.phoneTextBox.Text.Trim();
                string address = this.addressTextBox.Text.Trim();
                string city = this.cityTextBox.Text.Trim();
                string state = this.stateComboBox.Text.Trim();
                string zip = this.zipTextBox.Text.Trim();
                string sex = this.sexComboBox.Text.Trim();
                string ssn = this.ssnTextBox.Text.Trim();
                string status = this.activeStatusComboBox.Text.Trim();

                if (string.IsNullOrEmpty(lastName) || !ValidationUtility.IsMoreThanOneLetters(lastName) ||
                    string.IsNullOrEmpty(firstName) || !ValidationUtility.IsMoreThanOneLetters(firstName) ||
                    dob > DateTime.Now || string.IsNullOrEmpty(address) ||
                    !ValidationUtility.IsMoreThanOneLetters(address) || string.IsNullOrEmpty(city) ||
                    !ValidationUtility.IsMoreThanOneLetters(city) || string.IsNullOrEmpty(state) ||
                    state.Length != 2 || !ValidationUtility.IsValidZipCode(zip) ||
                    !ValidationUtility.IsValidPhoneNumber(phone) || !ValidationUtility.IsGenderValid(sex) ||
                    !ValidationUtility.IsSSNValid(ssn) || !ValidationUtility.IsStatusValid(status))
                {
                    this.ShowInvalidErrorMessages();
                }
                else
                {

                    if (this._studentController.UpdatePersonStudent(oldStudent, newStudent))
                    {
                        MessageBox.Show("Student profile successfully updated!", "Profile Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.RefreshPage();
                        
                    }
                    else
                    {
                        MessageBox.Show("Please check your inputs. Update failed.", "Profile Update Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }   
        }

        private void ShowInvalidErrorMessages()
        {
            if (string.IsNullOrEmpty(lastNameTextBox.Text) || string.IsNullOrWhiteSpace(lastNameTextBox.Text) ||
                !ValidationUtility.IsMoreThanOneLetters(this.lastNameTextBox.Text.Trim()))
            {
                this.lastNameErrorLabel.Text = "Please enter your last name.";
                this.lastNameErrorLabel.ForeColor = Color.Red;
            }

            if (string.IsNullOrEmpty(firstNameTextbox.Text) || string.IsNullOrWhiteSpace(firstNameTextbox.Text) ||
                 !ValidationUtility.IsMoreThanOneLetters(this.firstNameTextbox.Text.Trim()))
            {
                this.firstNameErrorLabel.Text = "Please enter your first name.";
                this.firstNameErrorLabel.ForeColor = Color.Red;
            }

            if (this.dobDateTimePicker.Value > DateTime.Now)
            {
                this.DOBErrorLabel.Text = "Invalid Date. Birthday cannot be in future.";
                this.DOBErrorLabel.ForeColor = Color.Red;
            }

            if (!ValidationUtility.IsMoreThanOneLetters(this.addressTextBox.Text.Trim()) ||
                    string.IsNullOrEmpty(this.addressTextBox.Text.Trim()))
            {
                this.addressErrorLabel.Text = "Please enter your full street address.";
                this.addressErrorLabel.ForeColor = Color.Red;
            }

            if (!ValidationUtility.IsMoreThanOneLetters(this.cityTextBox.Text.Trim()) ||
                    string.IsNullOrEmpty(this.cityTextBox.Text.Trim()))
            {
                this.cityErrorLabel.Text = "Please enter your city.";
                this.cityErrorLabel.ForeColor = Color.Red;
            }

            if (this.stateComboBox.Text.Trim().Length != 2 || string.IsNullOrEmpty(this.stateComboBox.Text.Trim()))
            {
                this.stateErrorLabel.Text = "Please select your state abbreviation.";
                this.stateErrorLabel.ForeColor = Color.Red;
            }

            if (!ValidationUtility.IsValidZipCode(this.zipTextBox.Text.Trim()))
            {
                this.zipErrorLabel.Text = "Please enter a valid zipcode.";
                this.zipErrorLabel.ForeColor = Color.Red;
            }

            if (!ValidationUtility.IsValidPhoneNumber(this.phoneTextBox.Text.Trim()))
            {
                this.phoneErrorLabel.Text = "Please enter your 10 digit phone only numbers.";
                this.phoneErrorLabel.ForeColor = Color.Red;
            }

            if (!ValidationUtility.IsGenderValid(this.sexComboBox.Text.Trim()))
            {
                this.sexErrorLabel.Text = "Please enter M or F.";
                this.sexErrorLabel.ForeColor = Color.Red;
            }

            if (!ValidationUtility.IsSSNValid(this.ssnTextBox.Text.Trim()))
            {
                this.ssnErrorLabel.Text = "Please enter a valid 9 digit SSN, numbers only.";
                this.ssnErrorLabel.ForeColor = Color.Red;
            }

        }

        private void resultsDOBDateTimePicker_MouseDown(object sender, MouseEventArgs e)
        {
            this.HideInvalidErrorMessages();
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

        private void TextBox_Changed(object sender, EventArgs e)
        {
            this.HideInvalidErrorMessages();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.RefreshPage();
        }
    }
}
