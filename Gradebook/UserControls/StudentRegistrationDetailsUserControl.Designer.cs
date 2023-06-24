namespace Gradebook.UserControls
{
    partial class StudentRegistrationDetailsUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.registrationDetailsLabel = new System.Windows.Forms.Label();
            this.semesterLabel = new System.Windows.Forms.Label();
            this.semesterComboBox = new System.Windows.Forms.ComboBox();
            this.yearLabel = new System.Windows.Forms.Label();
            this.courseYearPicker = new System.Windows.Forms.DateTimePicker();
            this.searchButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.registeredUnitsLabel = new System.Windows.Forms.Label();
            this.registeredUnitsDisplayLabel = new System.Windows.Forms.Label();
            this.currentStudentIDSetLabel = new System.Windows.Forms.Label();
            this.currentStudentIDForEdit = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.currentStudentIDForEdit);
            this.panel1.Controls.Add(this.currentStudentIDSetLabel);
            this.panel1.Controls.Add(this.registeredUnitsDisplayLabel);
            this.panel1.Controls.Add(this.registeredUnitsLabel);
            this.panel1.Controls.Add(this.clearButton);
            this.panel1.Controls.Add(this.searchButton);
            this.panel1.Controls.Add(this.courseYearPicker);
            this.panel1.Controls.Add(this.yearLabel);
            this.panel1.Controls.Add(this.semesterComboBox);
            this.panel1.Controls.Add(this.semesterLabel);
            this.panel1.Controls.Add(this.registrationDetailsLabel);
            this.panel1.Location = new System.Drawing.Point(11, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(932, 634);
            this.panel1.TabIndex = 0;
            // 
            // registrationDetailsLabel
            // 
            this.registrationDetailsLabel.AutoSize = true;
            this.registrationDetailsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrationDetailsLabel.Location = new System.Drawing.Point(3, 10);
            this.registrationDetailsLabel.Name = "registrationDetailsLabel";
            this.registrationDetailsLabel.Size = new System.Drawing.Size(284, 20);
            this.registrationDetailsLabel.TabIndex = 1;
            this.registrationDetailsLabel.Text = "Registration Details by Student ID";
            // 
            // semesterLabel
            // 
            this.semesterLabel.AutoSize = true;
            this.semesterLabel.Location = new System.Drawing.Point(20, 43);
            this.semesterLabel.Name = "semesterLabel";
            this.semesterLabel.Size = new System.Drawing.Size(51, 13);
            this.semesterLabel.TabIndex = 3;
            this.semesterLabel.Text = "Semester";
            // 
            // semesterComboBox
            // 
            this.semesterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.semesterComboBox.FormattingEnabled = true;
            this.semesterComboBox.Items.AddRange(new object[] {
            "Spring",
            "Summer",
            "Fall"});
            this.semesterComboBox.Location = new System.Drawing.Point(77, 40);
            this.semesterComboBox.Name = "semesterComboBox";
            this.semesterComboBox.Size = new System.Drawing.Size(150, 21);
            this.semesterComboBox.TabIndex = 4;
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(248, 43);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(29, 13);
            this.yearLabel.TabIndex = 5;
            this.yearLabel.Text = "Year";
            // 
            // courseYearPicker
            // 
            this.courseYearPicker.CustomFormat = "yyyy";
            this.courseYearPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.courseYearPicker.Location = new System.Drawing.Point(283, 40);
            this.courseYearPicker.Name = "courseYearPicker";
            this.courseYearPicker.ShowUpDown = true;
            this.courseYearPicker.Size = new System.Drawing.Size(63, 20);
            this.courseYearPicker.TabIndex = 6;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(379, 38);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 7;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(473, 38);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 8;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            // 
            // registeredUnitsLabel
            // 
            this.registeredUnitsLabel.AutoSize = true;
            this.registeredUnitsLabel.Location = new System.Drawing.Point(20, 91);
            this.registeredUnitsLabel.Name = "registeredUnitsLabel";
            this.registeredUnitsLabel.Size = new System.Drawing.Size(91, 13);
            this.registeredUnitsLabel.TabIndex = 46;
            this.registeredUnitsLabel.Text = "Units Registered: ";
            // 
            // registeredUnitsDisplayLabel
            // 
            this.registeredUnitsDisplayLabel.AutoSize = true;
            this.registeredUnitsDisplayLabel.Location = new System.Drawing.Point(117, 91);
            this.registeredUnitsDisplayLabel.Name = "registeredUnitsDisplayLabel";
            this.registeredUnitsDisplayLabel.Size = new System.Drawing.Size(13, 13);
            this.registeredUnitsDisplayLabel.TabIndex = 47;
            this.registeredUnitsDisplayLabel.Text = "0";
            // 
            // currentStudentIDSetLabel
            // 
            this.currentStudentIDSetLabel.AutoSize = true;
            this.currentStudentIDSetLabel.Location = new System.Drawing.Point(610, 46);
            this.currentStudentIDSetLabel.Name = "currentStudentIDSetLabel";
            this.currentStudentIDSetLabel.Size = new System.Drawing.Size(61, 13);
            this.currentStudentIDSetLabel.TabIndex = 48;
            this.currentStudentIDSetLabel.Text = "Student ID:";
            // 
            // currentStudentIDForEdit
            // 
            this.currentStudentIDForEdit.AutoSize = true;
            this.currentStudentIDForEdit.Location = new System.Drawing.Point(678, 46);
            this.currentStudentIDForEdit.Name = "currentStudentIDForEdit";
            this.currentStudentIDForEdit.Size = new System.Drawing.Size(13, 13);
            this.currentStudentIDForEdit.TabIndex = 49;
            this.currentStudentIDForEdit.Text = "0";
            // 
            // StudentRegistrationDetailsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "StudentRegistrationDetailsUserControl";
            this.Size = new System.Drawing.Size(960, 640);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label registrationDetailsLabel;
        private System.Windows.Forms.ComboBox semesterComboBox;
        private System.Windows.Forms.Label semesterLabel;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.DateTimePicker courseYearPicker;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label registeredUnitsDisplayLabel;
        private System.Windows.Forms.Label registeredUnitsLabel;
        private System.Windows.Forms.Label currentStudentIDSetLabel;
        private System.Windows.Forms.Label currentStudentIDForEdit;
    }
}
