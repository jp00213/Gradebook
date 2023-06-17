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
    /// <summary>
    /// This class manages usercontrol for viewing student information
    /// </summary>
    public partial class SearchStudentUserControl : UserControl
    {
        private readonly StudentController _studentController;
        private readonly Person _controlNumber;

        public event EventHandler StudentNumberChanged;
        /// <summary>
        /// create constructors
        /// </summary>
        public SearchStudentUserControl()
        {
            InitializeComponent();
            this.SetupDatePickerMinus10Years();
            this.viewOnlyRadioButton.Enabled = true;
            this._studentController = new StudentController();
            this._controlNumber = new Person();
            this.ErrorMessageLabel.Text = string.Empty;
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
                this.LoadStudentListView(
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
            }
        }
    }
}
