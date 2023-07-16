using Gradebook.Controller;
using Gradebook.Function;
using Gradebook.Model;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Gradebook.UserControls
{
    /// <summary>
    /// This class manages usercontrol for viewing student information
    /// </summary>
    public partial class SearchStudentUserControl : UserControl
    {
        private readonly StudentController _studentController;
        // 1. customer event
        private Person _controlNumber;
        private Person theStudent;

        /// <summary>
        /// 2. custom event
        /// </summary>
        public event EventHandler StudentNumberChanged;

        /// <summary>
        /// create constructors
        /// </summary>
        public SearchStudentUserControl()
        {
            InitializeComponent();
            this.SetupDatePickerMinus10Years();
            this.SetupComboBoxes();
            this._studentController = new StudentController();
            this._controlNumber = new Person();

            this.ErrorMessageLabel.Text = string.Empty;
            this.searchStudentIDRadioButton.Enabled = true;
            this.searchStudentIDRadioButton.Checked = true;
        }

        /// <summary>
        /// 3. event - return current studentID
        /// </summary>
        /// <param name="e"></param>
        protected virtual void OnNumberchanged(EventArgs e)
        {
            StudentNumberChanged?.Invoke(this, e);
        }

        private void SetupComboBoxes()
        {
            this.genderComboBox.Items.Insert(0, "-- select --");
            this.genderComboBox.Items.Insert(1, "M");
            this.genderComboBox.Items.Insert(2, "F");
            this.statusComboBox.Items.Insert(0, "-- select --");
            this.statusComboBox.Items.Insert(1, "Active");
            this.statusComboBox.Items.Insert(2, "Hold");
            this.statusComboBox.Items.Insert(3, "Disable");
        }

        private void SetStudentIDToZero()
        {
            SearchItem searchItem = new SearchItem
            {
                FirstName = "",
                LastName = "",
                DateOfBirth = DateTime.Now,
                StudentID = 0,
                Username = ""
            };
            this.studentDataGridView.DataSource = this._studentController.GetStudentByParameters(searchItem);

            this._controlNumber.StudentID = 0;
            // 5. event - event trigger
            this.OnNumberchanged(EventArgs.Empty);
        }

        /// <summary>
        /// 4. event - return current studentID
        /// </summary>
        /// <returns></returns>
        public string getCurrentStudentID()
        {
            return this._controlNumber.StudentID.ToString();
        }

        private void SetupDatePickerMinus10Years()
        {
            this.dob_Datepicker.Value = DateTime.Now.AddYears(-10);
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            this.ClearSearchButton();
        }

        private void ClearSearchButton()
        {
            this.studentIDTextBox.Text = string.Empty;
            this.usernameTextBox.Text = string.Empty;
            this.firstNameTextBox.Text = string.Empty;
            this.lastNameTextBox.Text = string.Empty;
            this.SetupDatePickerMinus10Years();
            this.ErrorMessageLabel.Text = string.Empty;
            this.currentStudentIDSetLabel.Text = string.Empty;

            this.SetStudentIDToZero();

            if (searchStudentIDRadioButton.Checked == true || searchUsernameRadioButton.Checked == true || searchNameRadioButton.Checked == true)
            {
                dob_Datepicker.Value = new DateTime(1900, 1, 1);
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (
                 (this.firstNameTextBox.Text != string.Empty) ||
                 (this.lastNameTextBox.Text != string.Empty) ||
                 (this.dob_Datepicker.Value != DateTime.Now.AddYears(-10)) ||
                 (this.studentIDTextBox.Text != string.Empty) ||
                 (this.usernameTextBox.Text != string.Empty) ||
                 (this.firstNameTextBox.Text != string.Empty) ||
                 (this.lastNameTextBox.Text != string.Empty))
            {
                this.LoadStudentListView
                    (
                    this.studentIDTextBox.Text,
                    this.usernameTextBox.Text,
                    this.firstNameTextBox.Text,
                    this.lastNameTextBox.Text,
                    this.dob_Datepicker.Value
                    );
            }
            else
            {
                this.ErrorMessageLabel.Text = "Please enter search criteria first.";
                this.ErrorMessageLabel.ForeColor = Color.Red;
                return;
            }

        }

        private void LoadStudentListView(string studentID, string username, string firstName, string lastName, DateTime dob)
        {
            SearchItem searchItem = new SearchItem
            {
                FirstName = firstName,
                LastName = lastName,
                DateOfBirth = dob,
                Username = username
            };

            if (int.TryParse(studentID, out int numericValue))
            {
                searchItem.StudentID = numericValue;
            }
            else
            {
                searchItem.StudentID = 0;
            }

            this.studentDataGridView.DataSource = this._studentController.GetStudentByParameters(searchItem);
        }

        private void ChangeSearchBox(object sender, EventArgs e)
        {
            if (searchStudentIDRadioButton.Checked == true)
            {
                studentIDTextBox.Text = "";
                studentIDTextBox.ReadOnly = false;
                usernameTextBox.Text = "";
                usernameTextBox.ReadOnly = true;
                firstNameTextBox.Text = "";
                firstNameTextBox.ReadOnly = true;
                lastNameTextBox.Text = "";
                lastNameTextBox.ReadOnly = true;
                dob_Datepicker.Value = new DateTime(1900, 1, 1);
                dob_Datepicker.Enabled = false;
            }

            if (searchUsernameRadioButton.Checked == true)
            {
                studentIDTextBox.Text = "";
                studentIDTextBox.ReadOnly = true;
                usernameTextBox.Text = "";
                usernameTextBox.ReadOnly = false;
                firstNameTextBox.Text = "";
                firstNameTextBox.ReadOnly = true;
                lastNameTextBox.Text = "";
                lastNameTextBox.ReadOnly = true;
                dob_Datepicker.Value = new DateTime(1900, 1, 1);
                dob_Datepicker.Enabled = false;
            }

            if (searchNameRadioButton.Checked == true)
            {
                studentIDTextBox.Text = "";
                studentIDTextBox.ReadOnly = true;
                usernameTextBox.Text = "";
                usernameTextBox.ReadOnly = true;
                firstNameTextBox.Text = "";
                firstNameTextBox.ReadOnly = false;
                lastNameTextBox.Text = "";
                lastNameTextBox.ReadOnly = false;
                dob_Datepicker.Value = new DateTime(1900, 1, 1);
                dob_Datepicker.Enabled = false;
            }

            if (searchDobPicker.Checked == true)
            {
                studentIDTextBox.Text = "";
                studentIDTextBox.ReadOnly = true;
                usernameTextBox.Text = "";
                usernameTextBox.ReadOnly = true;
                firstNameTextBox.Text = "";
                firstNameTextBox.ReadOnly = true;
                lastNameTextBox.Text = "";
                lastNameTextBox.ReadOnly = true;
                dob_Datepicker.Value = DateTime.Now.AddYears(-10);
                dob_Datepicker.Enabled = true;
            }
        }

        private void studentDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.theStudent = (Person)this.studentDataGridView.SelectedRows[0].DataBoundItem;
            this.currentStudentIDSetLabel.Text = this.theStudent.StudentID.ToString();
            this._controlNumber.StudentID = this.theStudent.StudentID;
            // 5. event - event trigger
            this.OnNumberchanged(EventArgs.Empty);
            this.LoadStudentDetails();
        }

        private void LoadStudentDetails()
        {
            firstNameDetailsTextBox.Text = theStudent.FirstName;
            lastNameDetailsTextBox.Text = theStudent.LastName;
            dobPicker.Value = theStudent.DateOfBirth;
            phoneTextBox.Text = theStudent.Phone;
            genderComboBox.Text = theStudent.Sex;
            streetTextBox.Text = theStudent.AddressStreet;
            cityTextBox.Text = theStudent.City;
            stateComboBox.Text = theStudent.State;
            zipTextBox.Text = theStudent.Zip;
            ssnTextBox.Text = theStudent.SSN;
            if (theStudent.MaximumUnitsAllowed == null)
            {
                maximumAllowedUnitsComboBox.SelectedItem = null;
            }
            else
            {
                maximumAllowedUnitsComboBox.Text = theStudent.MaximumUnitsAllowed.ToString();
            };
            statusComboBox.SelectedIndex = theStudent.ActiveStatus;
        }

        private void updateStudentButton_Click(object sender, EventArgs e)
        {
            string lastName = this.lastNameDetailsTextBox.Text.Trim();
            string firstName = this.firstNameDetailsTextBox.Text.Trim();
            DateTime dateOfBirth = this.dobPicker.Value;
            string street = this.streetTextBox.Text.Trim();
            string city = this.cityTextBox.Text.Trim();
            string state = this.stateComboBox.Text.Trim();
            string zip = this.zipTextBox.Text.Trim();
            string phone = this.phoneTextBox.Text.Trim();
            string sex = this.genderComboBox.Text.Trim();
            string ssn = this.ssnTextBox.Text.Trim();
            int status = this.statusComboBox.SelectedIndex;
            int? maximumUnitsAllowed;
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
                Person newStudent = new Person
                {
                    RecordId = this.theStudent.RecordId,
                    StudentID = this.theStudent.StudentID,
                    FirstName = firstName,
                    LastName = lastName,
                    DateOfBirth = dateOfBirth,
                    AddressStreet = street,
                    City = city,
                    State = state,
                    Zip = zip,
                    Phone = phone,
                    Sex = sex,
                    SSN = ssn,
                    ActiveStatus = status,
                    MaximumUnitsAllowed = maximumUnitsAllowed,
                    Username = this.theStudent.Username
                };

                if (this._studentController.UpdateStudent(newStudent, this.theStudent))
                {
                    this.ClearLoadedStudent();
                    this.ClearSearchButton();
                    MessageBox.Show("The update is successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Please check your inputs. Update failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DisplayErrorMessageOnInvalidFields()
        {
            if
            (string.IsNullOrEmpty(this.lastNameDetailsTextBox.Text.Trim()) ||
            !ValidationUtility.IsMoreThanOneLetters(this.lastNameDetailsTextBox.Text.Trim()))
            {
                this.lastNameErrorMessageLabel.Text = "Last name must have at least 2 letters.";
                this.lastNameErrorMessageLabel.ForeColor = Color.Red;
            }

            if
             (string.IsNullOrEmpty(this.firstNameDetailsTextBox.Text.Trim()) ||
             !ValidationUtility.IsMoreThanOneLetters(this.firstNameDetailsTextBox.Text.Trim()))
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

        private void lastNameDetailsTextBox_TextChanged(object sender, EventArgs e)
        {
            this.ClearInvalidFields();
        }

        private void clearEditButton_Click(object sender, EventArgs e)
        {
            this.ClearInvalidFields();
            this.ClearLoadedStudent();
        }

        private void ClearLoadedStudent()
        {
            firstNameDetailsTextBox.Text = "";
            lastNameDetailsTextBox.Text = "";
            dobPicker.Value = DateTime.Now;
            phoneTextBox.Text = "";
            genderComboBox.Text = "M";
            streetTextBox.Text = "";
            cityTextBox.Text = "";
            stateComboBox.Text = "";
            zipTextBox.Text = "";
            ssnTextBox.Text = "";
            maximumAllowedUnitsComboBox.SelectedItem = null;
            statusComboBox.SelectedIndex = 0;

        }
    }
}
