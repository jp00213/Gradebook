using Gradebook.Controller;
using Gradebook.DAL;
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
            this.statusComboBox.Items.Insert(2, "Disable");
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
            this.dobPicker.Value = DateTime.Now;
            this.phoneTextBox.Clear();
            this.genderComboBox.SelectedItem = null;
            this.streetTextBox.Clear();
            this.cityTextBox.Clear();
            this.stateComboBox.SelectedItem = null;
            this.statusComboBox.SelectedItem = null;
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
            string LastName = this.lastNameTextBox.Text;
            string FirstName = this.firstNameTextBox.Text;
            DateTime DateOfBirth = this.dobPicker.Value;
            string AddressStreet = this.streetTextBox.Text;
            string City = this.cityTextBox.Text;
            string State = this.stateComboBox.Text;
            string Zip = this.zipTextBox.Text;
            string Phone = this.phoneTextBox.Text;
            string Sex = this.genderComboBox.Text;
            string SSN = this.ssnTextBox.Text;

            Person newStudent = new Person(LastName, FirstName, DateOfBirth, AddressStreet, City, State, Zip, Phone, Sex, SSN);
            this._studentController.AddPersonAsStudent(newStudent);
            System.Windows.Forms.MessageBox.Show("view run processed");
        }

    }
}
