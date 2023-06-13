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
    /// Add student user control
    /// </summary>
    public partial class AddStudentUserControl : UserControl
    {
        private PersonDAL _personDAL;
        public AddStudentUserControl()
        {
            InitializeComponent();
            this._personDAL = new PersonDAL();
        }

        private void addStudentButton_Click(object sender, EventArgs e)
        {
            string LastName = this.lastNameTextBox.Text;
            string FirstName = this.firstNameTextBox.Text;
            DateTime DateOfBirth = this.dobPicker.Value;
            string AddressStreet = this.streetTextBox.Text;
            string City = this.cityTextBox.Text;
            string State = this.stateTextBox.Text;
            string Zip = this.zipTextBox.Text;
            string Phone = this.phoneTextBox.Text;
            string Sex = this.genderTextBox.Text;
            string SSN = this.ssnTextBox.Text;

            Person newStudent = new Person(LastName, FirstName, DateOfBirth, AddressStreet, City, State, Zip, Phone, Sex, SSN);
            this._personDAL.AddPersonAsStudent(newStudent);
        }
    }
}
