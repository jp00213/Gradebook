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
    /// This class manages usercontrol for student password information
    /// </summary>
    public partial class ChangeStudentPasswordUserControl : UserControl
    {
        private StudentController _studentController;
        private Person theStudent;
        /// <summary>
        /// create constructors
        /// </summary>
        public ChangeStudentPasswordUserControl()
        {
            InitializeComponent();
            this._studentController = new StudentController();
            theStudent = new Person();
            this.DisableAllFields();
        }

        //set current student id
        public void SetCurrentStudentID(string currentStudentIDIn)
        {
            this.currentStudentIDForEdit.Text = currentStudentIDIn;
        }

        private void DisableAllFields()
        {
            this.changePasswordButton.Enabled = false;
            this.maskedPasswordTextBox1.Enabled = false;
            this.maskedPasswordTextBox2.Enabled = false;
            this.errorMessageLabel.Text = string.Empty;
        }

        private void EnableAllFields()
        {
            this.changePasswordButton.Enabled = true;
            this.maskedPasswordTextBox1.Enabled = true;
            this.maskedPasswordTextBox2.Enabled = true;
            this.errorMessageLabel.Text = string.Empty;
        }

        private void studentIDChanged(object sender, EventArgs e)
        {
            this.CheckStudentIDChange();
        }

        private void LoadStudentInformation()
        {
            theStudent = this._studentController.GetStudentByID(Convert.ToInt32(this.currentStudentIDForEdit.Text));
            this.usernameLabelText.Text = theStudent.Username;
            this.firstLastNameLabelText.Text = theStudent.FirstName + " " + theStudent.LastName;
            this.errorMessageLabel.Text = string.Empty;
        }

        private void CheckStudentIDChange()
        {
            this.maskedPasswordTextBox1.Text = string.Empty;
            this.maskedPasswordTextBox2.Text = string.Empty;
            this.usernameLabelText.Text = string.Empty;
            this.firstLastNameLabelText.Text += string.Empty;
            this.errorMessageLabel.Text = string.Empty;

            if (currentStudentIDForEdit.Text == "0")
            {
                this.maskedPasswordTextBox1.Text = string.Empty;
                this.maskedPasswordTextBox2.Text = string.Empty;
                this.usernameLabelText.Text = string.Empty;
                this.firstLastNameLabelText.Text += string.Empty;
                this.DisableAllFields();
            }
            else
            {
                this.EnableAllFields();
                this.LoadStudentInformation();
            }
        }

        private void changePasswordButton_Click(object sender, EventArgs e)
        {
            if (this.maskedPasswordTextBox1.Text == this.maskedPasswordTextBox2.Text)
            {
                this.ResetPassword();
            }
            else
            {
                this.errorMessageLabel.Text = "Passwords do not match! Please try again.";
                this.errorMessageLabel.ForeColor = Color.Blue;
            }
        }

        private void ResetPassword()
        {
            if (this._studentController.UpdateStudentPassword(theStudent.Username, this.maskedPasswordTextBox1.Text) == true)
            {
                this.maskedPasswordTextBox1.Text = String.Empty;
                this.maskedPasswordTextBox2.Text = String.Empty;
                MessageBox.Show("Password changed successfully.");
            };
        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            this.errorMessageLabel.Text = string.Empty;
        }
    }
}
