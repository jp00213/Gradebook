using Gradebook.Controller;
using Gradebook.Function;
using Gradebook.Model;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Gradebook.UserControls
{
    /// <summary>
    /// Update teacher user control
    /// </summary>
    public partial class UpdateTeacherUserControl : UserControl
    {

        private TeacherController _teacherController;
        private Teacher _teacher;

        /// <summary>
        /// THe update student user control
        /// </summary>
        public UpdateTeacherUserControl()
        {
            InitializeComponent();
            this._teacherController = new TeacherController();
            this._teacher= null;
            this.SetupGenderComboBox();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string firstName = this.firstNameTextbox.Text;
            string lastName = this.lastNameTextbox.Text;
            DateTime dob = this.dobDateTimePicker.Value.Date;
            this.teacherSearchDataGridView.DataSource = _teacherController.GetTeacherByNameDOB(firstName, lastName, dob);

            this.ClearEdits();
        }

        private void teacherSearchDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            try
            {
                var teacherID = teacherSearchDataGridView.SelectedRows[0].Cells[0].Value.ToString();
                this._teacher = this._teacherController.GetTeacherByID(Int32.Parse(teacherID));

                if (_teacher != null)
                {
                    teacherBindingSource.DataSource = _teacher;
                    teacherBindingSource.ResetBindings(true);
                    this.saveButton.Enabled = true;
                }
            } catch (Exception)
            {
                MessageBox.Show("Please click the selection arrow next to the row you would like to select.", "Error", MessageBoxButtons.OK);
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
            string lastName = this.resultsLastNameTextBox.Text.Trim();
            string firstName = this.resultsFirstNameTextbox.Text.Trim();
            DateTime dob = this.resultsDOBDateTimePicker.Value;
            string phone = this.phoneTextBox.Text.Trim();
            string address = this.addressTextBox.Text.Trim();
            string city = this.cityTextBox.Text.Trim();
            string state = this.stateComboBox.Text.Trim();
            string zip = this.zipTextBox.Text.Trim();
            string sex = this.sexComboBox.Text.Trim();
            string ssn = this.ssnTextBox.Text.Trim();
            Teacher oldTeacher = _teacher;

            if (string.IsNullOrEmpty(lastName) || !ValidationUtility.IsMoreThanOneLetters(lastName) ||
                string.IsNullOrEmpty(firstName) || !ValidationUtility.IsMoreThanOneLetters(firstName) ||
                dob > DateTime.Now || string.IsNullOrEmpty(address) ||
                !ValidationUtility.IsMoreThanOneLetters(address) || string.IsNullOrEmpty(city) ||
                !ValidationUtility.IsMoreThanOneLetters(city) || string.IsNullOrEmpty(state) ||
                state.Length != 2 || !ValidationUtility.IsValidZipCode(zip) ||
                !ValidationUtility.IsValidPhoneNumber(phone) || !ValidationUtility.IsGenderValid(sex) ||
                !ValidationUtility.IsSSNValid(ssn) || string.IsNullOrEmpty(ssn))
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
                else
                {
                    MessageBox.Show("Please check your inputs. Update failed.", "Update Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (string.IsNullOrEmpty(resultsLastNameTextBox.Text) || string.IsNullOrWhiteSpace(resultsLastNameTextBox.Text) ||
                !ValidationUtility.IsMoreThanOneLetters(this.resultsLastNameTextBox.Text.Trim()))
            {
                this.lastNameErrorLabel.Text = "Please enter your last name.";
                this.lastNameErrorLabel.ForeColor = Color.Red;
            }

            if (string.IsNullOrEmpty(resultsFirstNameTextbox.Text) || string.IsNullOrWhiteSpace(resultsFirstNameTextbox.Text) ||
                 !ValidationUtility.IsMoreThanOneLetters(this.resultsFirstNameTextbox.Text.Trim()))
            {
                this.firstNameErrorLabel.Text = "Please enter your first name.";
                this.firstNameErrorLabel.ForeColor = Color.Red;
            }

            if (this.resultsDOBDateTimePicker.Value > DateTime.Now)
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

        private void resultsDOBDateTimePicker_MouseDown(object sender, MouseEventArgs e)
        {
            this.HideInvalidErrorMessages();
        }

        private void SetupGenderComboBox()
        {
            this.sexComboBox.Items.Insert(0, "-- select --");
            this.sexComboBox.Items.Insert(1, "M");
            this.sexComboBox.Items.Insert(2, "F");
        }
    }
}
