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
            this.gradeListView = new System.Windows.Forms.ListView();
            this.courseHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.assignmentHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.descriptionHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.weightHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.scoreheader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.weightGradeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.errorlabel = new System.Windows.Forms.Label();
            this.courseListView = new System.Windows.Forms.ListView();
            this.courseIDHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.prefixHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nuberHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sectionHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.titleHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.unitsHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.instructorNameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.unitsBalanceLabel = new System.Windows.Forms.Label();
            this.unitAvailableLabel = new System.Windows.Forms.Label();
            this.allowedUnitsLabel = new System.Windows.Forms.Label();
            this.maxAllowedUnitLabel = new System.Windows.Forms.Label();
            this.currentStudentIDForEdit = new System.Windows.Forms.Label();
            this.currentStudentIDSetLabel = new System.Windows.Forms.Label();
            this.registeredUnitsDisplayLabel = new System.Windows.Forms.Label();
            this.registeredUnitsLabel = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.courseYearPicker = new System.Windows.Forms.DateTimePicker();
            this.yearLabel = new System.Windows.Forms.Label();
            this.semesterComboBox = new System.Windows.Forms.ComboBox();
            this.semesterLabel = new System.Windows.Forms.Label();
            this.registrationDetailsLabel = new System.Windows.Forms.Label();
            this.weightedGradeTotalLabel = new System.Windows.Forms.Label();
            this.weightGradeTotalValueLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.weightGradeTotalValueLabel);
            this.panel1.Controls.Add(this.weightedGradeTotalLabel);
            this.panel1.Controls.Add(this.gradeListView);
            this.panel1.Controls.Add(this.errorlabel);
            this.panel1.Controls.Add(this.courseListView);
            this.panel1.Controls.Add(this.unitsBalanceLabel);
            this.panel1.Controls.Add(this.unitAvailableLabel);
            this.panel1.Controls.Add(this.allowedUnitsLabel);
            this.panel1.Controls.Add(this.maxAllowedUnitLabel);
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
            // gradeListView
            // 
            this.gradeListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.courseHeader,
            this.assignmentHeader,
            this.descriptionHeader,
            this.weightHeader,
            this.scoreheader,
            this.weightGradeHeader});
            this.gradeListView.HideSelection = false;
            this.gradeListView.Location = new System.Drawing.Point(23, 305);
            this.gradeListView.Name = "gradeListView";
            this.gradeListView.Size = new System.Drawing.Size(888, 174);
            this.gradeListView.TabIndex = 56;
            this.gradeListView.UseCompatibleStateImageBehavior = false;
            this.gradeListView.View = System.Windows.Forms.View.Details;
            // 
            // courseHeader
            // 
            this.courseHeader.Text = "Course ID";
            // 
            // assignmentHeader
            // 
            this.assignmentHeader.Text = "AssignmentID";
            this.assignmentHeader.Width = 90;
            // 
            // descriptionHeader
            // 
            this.descriptionHeader.Text = "Description";
            this.descriptionHeader.Width = 150;
            // 
            // weightHeader
            // 
            this.weightHeader.Text = "Weight";
            // 
            // scoreheader
            // 
            this.scoreheader.Text = "Score";
            // 
            // weightGradeHeader
            // 
            this.weightGradeHeader.Text = "Weighted Grade";
            this.weightGradeHeader.Width = 100;
            // 
            // errorlabel
            // 
            this.errorlabel.AutoSize = true;
            this.errorlabel.Location = new System.Drawing.Point(23, 79);
            this.errorlabel.Name = "errorlabel";
            this.errorlabel.Size = new System.Drawing.Size(10, 13);
            this.errorlabel.TabIndex = 55;
            this.errorlabel.Text = "-";
            // 
            // courseListView
            // 
            this.courseListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.courseIDHeader,
            this.prefixHeader,
            this.nuberHeader,
            this.sectionHeader,
            this.titleHeader,
            this.unitsHeader,
            this.instructorNameHeader});
            this.courseListView.FullRowSelect = true;
            this.courseListView.HideSelection = false;
            this.courseListView.Location = new System.Drawing.Point(23, 127);
            this.courseListView.Name = "courseListView";
            this.courseListView.Size = new System.Drawing.Size(888, 163);
            this.courseListView.TabIndex = 54;
            this.courseListView.UseCompatibleStateImageBehavior = false;
            this.courseListView.View = System.Windows.Forms.View.Details;
            this.courseListView.Click += new System.EventHandler(this.courseListView_Click);
            // 
            // courseIDHeader
            // 
            this.courseIDHeader.Text = "Course #";
            // 
            // prefixHeader
            // 
            this.prefixHeader.Text = "Prefix";
            // 
            // nuberHeader
            // 
            this.nuberHeader.Text = "Number";
            // 
            // sectionHeader
            // 
            this.sectionHeader.Text = "Section";
            // 
            // titleHeader
            // 
            this.titleHeader.Text = "Title";
            this.titleHeader.Width = 200;
            // 
            // unitsHeader
            // 
            this.unitsHeader.Text = "Units";
            // 
            // instructorNameHeader
            // 
            this.instructorNameHeader.Text = "Instructor";
            this.instructorNameHeader.Width = 200;
            // 
            // unitsBalanceLabel
            // 
            this.unitsBalanceLabel.AutoSize = true;
            this.unitsBalanceLabel.Location = new System.Drawing.Point(525, 95);
            this.unitsBalanceLabel.Name = "unitsBalanceLabel";
            this.unitsBalanceLabel.Size = new System.Drawing.Size(13, 13);
            this.unitsBalanceLabel.TabIndex = 53;
            this.unitsBalanceLabel.Text = "0";
            // 
            // unitAvailableLabel
            // 
            this.unitAvailableLabel.AutoSize = true;
            this.unitAvailableLabel.Location = new System.Drawing.Point(428, 95);
            this.unitAvailableLabel.Name = "unitAvailableLabel";
            this.unitAvailableLabel.Size = new System.Drawing.Size(96, 13);
            this.unitAvailableLabel.TabIndex = 52;
            this.unitAvailableLabel.Text = "Units still available:";
            // 
            // allowedUnitsLabel
            // 
            this.allowedUnitsLabel.AutoSize = true;
            this.allowedUnitsLabel.Location = new System.Drawing.Point(224, 95);
            this.allowedUnitsLabel.Name = "allowedUnitsLabel";
            this.allowedUnitsLabel.Size = new System.Drawing.Size(13, 13);
            this.allowedUnitsLabel.TabIndex = 51;
            this.allowedUnitsLabel.Text = "0";
            // 
            // maxAllowedUnitLabel
            // 
            this.maxAllowedUnitLabel.AutoSize = true;
            this.maxAllowedUnitLabel.Location = new System.Drawing.Point(34, 95);
            this.maxAllowedUnitLabel.Name = "maxAllowedUnitLabel";
            this.maxAllowedUnitLabel.Size = new System.Drawing.Size(184, 13);
            this.maxAllowedUnitLabel.TabIndex = 50;
            this.maxAllowedUnitLabel.Text = "Maximum Allowed Units per semester:";
            // 
            // currentStudentIDForEdit
            // 
            this.currentStudentIDForEdit.AutoSize = true;
            this.currentStudentIDForEdit.Location = new System.Drawing.Point(678, 46);
            this.currentStudentIDForEdit.Name = "currentStudentIDForEdit";
            this.currentStudentIDForEdit.Size = new System.Drawing.Size(13, 13);
            this.currentStudentIDForEdit.TabIndex = 49;
            this.currentStudentIDForEdit.Text = "0";
            this.currentStudentIDForEdit.TextChanged += new System.EventHandler(this.currentStudentIDForEdit_TextChanged);
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
            // registeredUnitsDisplayLabel
            // 
            this.registeredUnitsDisplayLabel.AutoSize = true;
            this.registeredUnitsDisplayLabel.Location = new System.Drawing.Point(376, 95);
            this.registeredUnitsDisplayLabel.Name = "registeredUnitsDisplayLabel";
            this.registeredUnitsDisplayLabel.Size = new System.Drawing.Size(13, 13);
            this.registeredUnitsDisplayLabel.TabIndex = 47;
            this.registeredUnitsDisplayLabel.Text = "0";
            // 
            // registeredUnitsLabel
            // 
            this.registeredUnitsLabel.AutoSize = true;
            this.registeredUnitsLabel.Location = new System.Drawing.Point(280, 95);
            this.registeredUnitsLabel.Name = "registeredUnitsLabel";
            this.registeredUnitsLabel.Size = new System.Drawing.Size(91, 13);
            this.registeredUnitsLabel.TabIndex = 46;
            this.registeredUnitsLabel.Text = "Units Registered: ";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(473, 38);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 8;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
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
            // courseYearPicker
            // 
            this.courseYearPicker.CustomFormat = "yyyy";
            this.courseYearPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.courseYearPicker.Location = new System.Drawing.Point(283, 40);
            this.courseYearPicker.Name = "courseYearPicker";
            this.courseYearPicker.ShowUpDown = true;
            this.courseYearPicker.Size = new System.Drawing.Size(63, 20);
            this.courseYearPicker.TabIndex = 6;
            this.courseYearPicker.ValueChanged += new System.EventHandler(this.courseYearPicker_ValueChanged);
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
            this.semesterComboBox.Click += new System.EventHandler(this.semesterComboBox_Click);
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
            // weightedGradeTotalLabel
            // 
            this.weightedGradeTotalLabel.AutoSize = true;
            this.weightedGradeTotalLabel.Location = new System.Drawing.Point(339, 482);
            this.weightedGradeTotalLabel.Name = "weightedGradeTotalLabel";
            this.weightedGradeTotalLabel.Size = new System.Drawing.Size(115, 13);
            this.weightedGradeTotalLabel.TabIndex = 57;
            this.weightedGradeTotalLabel.Text = "Weighted Grade Total:";
            // 
            // weightGradeTotalValueLabel
            // 
            this.weightGradeTotalValueLabel.AutoSize = true;
            this.weightGradeTotalValueLabel.Location = new System.Drawing.Point(461, 482);
            this.weightGradeTotalValueLabel.Name = "weightGradeTotalValueLabel";
            this.weightGradeTotalValueLabel.Size = new System.Drawing.Size(13, 13);
            this.weightGradeTotalValueLabel.TabIndex = 58;
            this.weightGradeTotalValueLabel.Text = "0";
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
        private System.Windows.Forms.Label unitsBalanceLabel;
        private System.Windows.Forms.Label unitAvailableLabel;
        private System.Windows.Forms.Label allowedUnitsLabel;
        private System.Windows.Forms.Label maxAllowedUnitLabel;
        private System.Windows.Forms.ListView courseListView;
        private System.Windows.Forms.ColumnHeader courseIDHeader;
        private System.Windows.Forms.ColumnHeader prefixHeader;
        private System.Windows.Forms.ColumnHeader nuberHeader;
        private System.Windows.Forms.ColumnHeader sectionHeader;
        private System.Windows.Forms.ColumnHeader titleHeader;
        private System.Windows.Forms.ColumnHeader unitsHeader;
        private System.Windows.Forms.ColumnHeader instructorNameHeader;
        private System.Windows.Forms.Label errorlabel;
        private System.Windows.Forms.ListView gradeListView;
        private System.Windows.Forms.ColumnHeader courseHeader;
        private System.Windows.Forms.ColumnHeader assignmentHeader;
        private System.Windows.Forms.ColumnHeader descriptionHeader;
        private System.Windows.Forms.ColumnHeader weightHeader;
        private System.Windows.Forms.ColumnHeader scoreheader;
        private System.Windows.Forms.ColumnHeader weightGradeHeader;
        private System.Windows.Forms.Label weightedGradeTotalLabel;
        private System.Windows.Forms.Label weightGradeTotalValueLabel;
    }
}
