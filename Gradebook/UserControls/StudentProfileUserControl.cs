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
    public partial class StudentProfileUserControl : UserControl
    {

        private StudentController _studentController;
        private Person _student;

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
                
                this.saveButton.Enabled = true;
            } catch (Exception)
            {
                MessageBox.Show("Please log in as a student.", "Error", MessageBoxButtons.OK);
            }
        }

        private void SetupComboBoxes()
        {
            this.sexComboBox.Items.Insert(1, "M");
            this.sexComboBox.Items.Insert(2, "F");
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
    }
}
