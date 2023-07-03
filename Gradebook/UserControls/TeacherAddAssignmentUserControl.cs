using Gradebook.Controller;
using Gradebook.Function;
using Gradebook.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Gradebook.UserControls
{
    /// <summary>
    /// UserControl to add assingments for students
    /// </summary>
    public partial class TeacherAddAssignmentUserControl : UserControl
    {
        private CourseController _courseController;
        private TeacherController _teacherController;
        private AssignmentController _assignmentController;
        private int _courseID;
        private string _courseName;

        /// <summary>
        /// Used to add assignments
        /// </summary>
        public TeacherAddAssignmentUserControl()
        {
            InitializeComponent();
            this._courseController = new CourseController();
            this._teacherController= new TeacherController();
            this._assignmentController= new AssignmentController();
            this._courseName = "";
            this.currentAssignmentsButton.Enabled = false;
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
            List<Course> currentCourses = this._courseController.GetCoursesByTeacherIDYearAndSemester(this.GetTeacherID(), this.GetCurrentSemester(), DateTime.Now.Year);
            foreach (Course course in currentCourses)
            {
                string courseName = course.Name;
                this.selectClassComboBox.Items.Add(courseName);
            }
        }

        private int GetCourseID()
        {
            this._courseName = this.selectClassComboBox.SelectedItem.ToString();
            Course currentCourse = this._courseController.GetCourseByName(this._courseName);
            return currentCourse.CourseID;
        }

        private string GetCurrentSemester()
        {
            return ValidationUtility.GetCurrentSemester(DateTime.Now);
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
            this.currentAssignmentsButton.Enabled = false;
            this.HideInvalidErrorMessages();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            ResetInputFields();
            this.HideInvalidErrorMessages();
            this.currentAssignmentsButton.Enabled = false;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(this.selectClassComboBox.Text))
                {
                    this._courseID = this.GetCourseID();
                } else
                {
                    this.ShowInvalidErrorMessages();
                    return;
                }
                    
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
                        Assignment newAssignment = new Assignment(-1, this.GetCourseID(), description, weight);
                        bool success = this._assignmentController.AddNewAssignment(newAssignment);

                        if (success)
                        {
                            MessageBox.Show("Assignment successfully saved!", "Assignment Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.RefreshDataGridView(this.GetCourseID());
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
            this.currentAssignmentsButton.Enabled = true;
        }

        private void currentAssignmentsButton_Click(object sender, EventArgs e)
        {
            this._courseID = this.GetCourseID();
            if (this._courseID <= 0)
            {
                MessageBox.Show(this._courseID.ToString());
                this.classErrorMessageLabel.Text = "Please select a course.";
                this.classErrorMessageLabel.ForeColor = Color.Red;
            }
            this.classAssignmentsDataGridView.DataSource = this._assignmentController.GetAssignmentsByCourseID(this._courseID);
        }

        private void RefreshDataGridView(int courseID)
        {
            this.classAssignmentsDataGridView.DataSource = this._assignmentController.GetAssignmentsByCourseID(courseID);
        }

        private void ClassAssignmentDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == this.classAssignmentsDataGridView.Columns["UpdateGradeButton"].Index && e.RowIndex >= 0)
                {
                    DataGridViewRow row = classAssignmentsDataGridView.Rows[e.RowIndex];
                    object description = row.Cells["descriptionDataGridViewTextBoxColumn"].Value ?? "";
                    object weight = row.Cells["assignmentIDDataGridViewTextBoxColumn"].Value;

                    if (string.IsNullOrEmpty(description.ToString()) || string.IsNullOrEmpty(weight.ToString()) || description == null || weight == null)
                    {
                        MessageBox.Show("Please fill out the description and weight box. They cannot be blank.", "Incomplete Assignment Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    } else if (!Decimal.TryParse(weight.ToString(), out var weightAsDecimal)) 
                    {
                        MessageBox.Show("Must enter a valid weight for the assignment. Weight cannot be less than 0 or more than 100", "Invalid Weight", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    } else
                    {
                        Assignment assignmentToUpdate = row.DataBoundItem as Assignment;
                        bool success = this._assignmentController.UpdateAssignment(assignmentToUpdate);

                        if (success)
                        {
                            MessageBox.Show("The assignment has been successfully updated!", "Assignment Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        } else
                        {
                            MessageBox.Show("Warning: The assignment was not updated. Please check the values entered and try again.", "Incomplete Assignment Update", MessageBoxButtons.OK,MessageBoxIcon.Error);
                        }
                    }
                } 
            } 
            catch (FormatException)
            {
                MessageBox.Show("There was an input error, please double check your inputs and try again.", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
            catch (Exception) 
            {
                MessageBox.Show("There was an error, please double check your inputs and try again.", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void classAssignmentsDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("There was an input error, please double check your inputs and try again.", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
