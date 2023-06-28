using Gradebook.Controller;
using Gradebook.Function;
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
    public partial class TeacherAddAssignmentUserControl : UserControl
    {
        private CourseController _courseController;
        private TeacherController _teacherController;
        private AssignmentController _assignmentController;
        private int _courseID;
        public TeacherAddAssignmentUserControl()
        {
            InitializeComponent();
            this._courseController = new CourseController();
            this._teacherController= new TeacherController();
            this._assignmentController= new AssignmentController();
            this._courseID= 4;
            this.classAssignmentsDataGridView.DataSource = this._assignmentController.GetAssignmentsByCourseID(this._courseID);
            this.SetUpTypeComboBox();
            this.SetUpClassComboBox();
        }


        private void SetUpTypeComboBox()
        {
            this.assignmentTypeComboBox.Items.Insert(0, "Quiz");
            this.assignmentTypeComboBox.Items.Insert(1, "Test");
            this.assignmentTypeComboBox.Items.Insert(2, "Individual Project");
            this.assignmentTypeComboBox.Items.Insert(3, "Group Project");
            this.assignmentTypeComboBox.Items.Insert(4, "Discussion Post");
            this.assignmentTypeComboBox.Items.Insert(5, "Paper");
        }

        private void SetUpClassComboBox()
        {
            List<Course> currentCourses = this._courseController.GetCoursesByTeacherIDYearAndSemester(2, this.GetCurrentSemester(), DateTime.Now.Year);
            foreach (Course course in currentCourses)
            {
                /*this.selectClassComboBox.Items.Add(course.Name + " - " + course.Prefix + " " + course.Number);*/
                this.selectClassComboBox.Items.Add(course.Name);
            }
        }

        private int GetCourseID()
        {
            /*Course selectedCourse = this.selectClassComboBox.GetItemText(this.selectClassComboBox.SelectedItem);
            string courseName = selectedCourse*/;
            /*Course selected = (Course)this.selectClassComboBox.SelectedItem;*/
            /*MessageBox.Show(this._courseController.GetCourseByName(courseName));*/
            /*MessageBox.Show(selected.Name);*/
            
            return 4;
        }

        private string GetCurrentSemester()
        {
            string semester;

            if (DateTime.Now.Month <= 4)
            {
                semester = "Spring";
            }
            else if (DateTime.Now.Month > 4 && DateTime.Now.Month < 8)
            {
                semester = "Summer";
            }
            else
            {
                semester = "Fall";
            }

            return semester;
        }

        private void CheckForParseErrors(bool parseable)
        {
            if (!parseable)
            {
                this.ShowInvalidErrorMessages();
            }
        }

        private void ShowInvalidErrorMessages()
        {
            if (string.IsNullOrEmpty(this.selectClassComboBox.Text)) {
                this.classErrorMessageLabel.Text = "Please select a course to create and assignment for.";
                this.classErrorMessageLabel.ForeColor = Color.Red;
            }

            if (string.IsNullOrEmpty(this.assignmentTypeComboBox.Text))
            {
                this.assignmentTypeErrorMessageLabel.Text = "Please select an assignment type.";
                this.assignmentTypeErrorMessageLabel.ForeColor = Color.Red;
            }

            if (!Decimal.TryParse(this.weightTextBox.Text.Trim(), out _) || Decimal.Parse(this.weightTextBox.Text.Trim()) < 0 || Decimal.Parse(this.weightTextBox.Text.Trim()) > 100 || string.IsNullOrEmpty(this.weightTextBox.Text))
            {
                this.weightErrorMessageLabel.Text = "Please enter a valid assignment weight as a whole number. Ex: 5";
                this.weightErrorMessageLabel.ForeColor = Color.Red;
            }

            if (string.IsNullOrEmpty(this.descriptionRichTextBox.Text))
            {
                this.descriptionErrorMessageLabel.Text = "Please input a brief assignment description.";
                this.descriptionErrorMessageLabel.ForeColor = Color.Red;
            }

        }

        private void HideInvalidErrorMessages()
        {
            this.classErrorMessageLabel.Text = "";
            this.assignmentTypeErrorMessageLabel.Text = "";
            this.weightErrorMessageLabel.Text = "";
            this.descriptionErrorMessageLabel.Text = "";
        }

        private void ResetInputFields()
        {
            this.selectClassComboBox.SelectedItem = null;
            this.assignmentTypeComboBox.SelectedItem = null;
            this.weightTextBox.Clear();
            this.descriptionRichTextBox.Clear();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            ResetInputFields();
            this.HideInvalidErrorMessages();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                this._courseID = this.GetCourseID();
                Decimal weight;
                this.CheckForParseErrors(Decimal.TryParse(this.weightTextBox.Text.Trim(), out weight));
                var description = (this.assignmentTypeComboBox.Text + " - " + this.descriptionRichTextBox.Text.Trim());
                this.ShowInvalidErrorMessages();
                
                if (string.IsNullOrEmpty(this.selectClassComboBox.Text) || string.IsNullOrEmpty(this.assignmentTypeComboBox.Text) || !ValidationUtility.IsInt32(this.weightTextBox.Text.Trim()) || !ValidationUtility.IsLessThan100(this.weightTextBox.Text.Trim()) || !ValidationUtility.IsGreaterThan0(this.weightTextBox.Text.Trim()) || string.IsNullOrEmpty(this.weightTextBox.Text.Trim()) || string.IsNullOrEmpty(this.descriptionRichTextBox.Text.Trim()))
                {
                    this.ShowInvalidErrorMessages();
                } else
                {
                    if (this.ConfirmAssignment() == DialogResult.Yes)
                    {
                        Assignment newAssignment = new Assignment(-1, this._courseID, description, weight);
                        bool success = this._assignmentController.AddNewAssignment(newAssignment);

                        if (success)
                        {
                            MessageBox.Show("Assignment successfully saved!", "Assignment Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.ResetInputFields();
                        }
                        else
                        {
                            MessageBox.Show("Assignment not added, there was an error.", "Assignment Not Saved", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }

            }   
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private DialogResult ConfirmAssignment()
        {
            string selectedCourse = this.selectClassComboBox.GetItemText(this.selectClassComboBox.SelectedItem);
            string type = this.assignmentTypeComboBox.Text.Trim();
            DialogResult dialogResult = MessageBox.Show("Please confirm the following assignment details:" + "\n \n" + "   •  Course Name: " + selectedCourse + "\n \n" + "   •  Assignment Type: " + type + "\n \n" + "   •  Assignment Weight: " + this.weightTextBox.Text.Trim() + "\n  \n" + "   •  Description: " + this.descriptionRichTextBox.Text.Trim(), "Pending Assignment Details", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            return dialogResult;
        }

        private int GetTeacherID()
        {
            string teacherUsername = TeacherController.GetUsername();
            Teacher currentTeacher = this._teacherController.GetTeacherByUsername(teacherUsername);
            return currentTeacher.TeacherID;
        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.HideInvalidErrorMessages();
        }
    }
}
