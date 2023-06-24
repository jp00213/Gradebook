using Gradebook.Controller;
using Gradebook.Model;
using System;
using System.Windows.Forms;

namespace Gradebook.UserControls
{
    /// <summary>
    /// This class manages usercontrol for search student registration information
    /// </summary>
    public partial class StudentRegistrationDetailsUserControl : UserControl
    {

        private readonly StudentController _studentController;
        private Person theStudent;

        /// <summary>
        /// create constructors
        /// </summary>
        public StudentRegistrationDetailsUserControl()
        {
            InitializeComponent();
            this._studentController = new StudentController();
            theStudent = new Person();
        }

        public void SetCurrentStudentID(string currentStudentIDIn)
        {
            this.currentStudentIDForEdit.Text = currentStudentIDIn;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            SearchItem searchItem = new SearchItem();
            searchItem.StudentID = Convert.ToInt32(this.currentStudentIDForEdit.Text);
            searchItem.Semester = this.semesterComboBox.Text;
            searchItem.Year = this.courseYearPicker.Value.Year.ToString();

            this.registeredUnitsDisplayLabel.Text = this._studentController.GetStudentRegisterUnitsTotal(searchItem).ToString();
        }
    }
    
}
