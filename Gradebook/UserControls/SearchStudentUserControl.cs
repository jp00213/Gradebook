using Gradebook.Controller;
using Gradebook.Model;
using System;
using System.Collections.Generic;
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
            //  this.viewOnlyRadioButton.Enabled = true;
            this._studentController = new StudentController();
            this.ErrorMessageLabel.Text = string.Empty;
            this.searchStudentIDRadioButton.Enabled = true;
            this.searchStudentIDRadioButton.Checked = true;

            this._controlNumber = new Person();
        }

        /// <summary>
        /// 3. event - return current studentID
        /// </summary>
        /// <param name="e"></param>
        protected virtual void OnNumberchanged(EventArgs e)
        {
            StudentNumberChanged?.Invoke(this, e);
        }

        private void SetStudentIDToZero()
        {
            this._controlNumber.StudentID = 0;
            this.studentListView.Items.Clear();
            // 5. event - event trigger
            this.OnNumberchanged(EventArgs.Empty);
        }


        // 4. event - return current studentID
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
            this.studentIDTextBox.Text = string.Empty;
            this.usernameTextBox.Text = string.Empty;
            this.firstNameTextBox.Text = string.Empty;
            this.lastNameTextBox.Text = string.Empty;
            this.SetupDatePickerMinus10Years();
            this.ErrorMessageLabel.Text = string.Empty;
            this.currentStudentIDSetLabel.Text = string.Empty;
            this.studentListView.Items.Clear();

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
            SearchItem searchItem = new SearchItem();
            searchItem.FirstName = firstName;
            searchItem.LastName = lastName;
            searchItem.DateOfBirth = dob;

            int numericValue;
            bool isNumber = int.TryParse(studentID, out numericValue);

            this.studentListView.Items.Clear();

            if ((studentID == null) || (isNumber != true))
            {
                searchItem.StudentID = 0;
            }
            else
            {
                searchItem.StudentID = Convert.ToInt32(studentID);
            }
            searchItem.Username = username;

            List<Person> studentList = this._studentController.GetStudentByParameters(searchItem);

            if (studentList.Count > 0)
            {
                this.ErrorMessageLabel.Text = "";
                this.studentListView.Items.Clear();
                Person currentPerson;
                for (int i = 0; i < studentList.Count; i++)
                {
                    currentPerson = studentList[i];
                    studentListView.Items.Add(currentPerson.StudentID.ToString());
                    studentListView.Items[i].SubItems.Add(currentPerson.RecordId.ToString());
                    studentListView.Items[i].SubItems.Add(currentPerson.Username);
                    studentListView.Items[i].SubItems.Add(currentPerson.FirstName);
                    studentListView.Items[i].SubItems.Add(currentPerson.LastName);
                    studentListView.Items[i].SubItems.Add(currentPerson.DateOfBirth.ToShortDateString());
                    studentListView.Items[i].SubItems.Add(currentPerson.Phone);
                    studentListView.Items[i].SubItems.Add(currentPerson.SSN);
                }
            }
            else
            {
                this.ErrorMessageLabel.Text = "No student found.";
                this.ErrorMessageLabel.ForeColor = Color.Blue;
            }
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

        private void studentListView_Click(object sender, EventArgs e)
        {
            this.currentStudentIDSetLabel.Text = studentListView.SelectedItems[0].SubItems[0].Text;
            this._controlNumber.StudentID = int.Parse(currentStudentIDSetLabel.Text);
            // 5. event - event trigger
            this.OnNumberchanged(EventArgs.Empty);

        }
    }
}
