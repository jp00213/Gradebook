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
            this.weightGradeTotalValueLabel = new System.Windows.Forms.Label();
            this.weightedGradeTotalLabel = new System.Windows.Forms.Label();
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
            this.panel1.Location = new System.Drawing.Point(15, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1243, 780);
            this.panel1.TabIndex = 0;
            // 
            // weightGradeTotalValueLabel
            // 
            this.weightGradeTotalValueLabel.AutoSize = true;
            this.weightGradeTotalValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.weightGradeTotalValueLabel.Location = new System.Drawing.Point(616, 592);
            this.weightGradeTotalValueLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.weightGradeTotalValueLabel.Name = "weightGradeTotalValueLabel";
            this.weightGradeTotalValueLabel.Size = new System.Drawing.Size(23, 25);
            this.weightGradeTotalValueLabel.TabIndex = 58;
            this.weightGradeTotalValueLabel.Text = "0";
            // 
            // weightedGradeTotalLabel
            // 
            this.weightedGradeTotalLabel.AutoSize = true;
            this.weightedGradeTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.weightedGradeTotalLabel.Location = new System.Drawing.Point(398, 592);
            this.weightedGradeTotalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.weightedGradeTotalLabel.Name = "weightedGradeTotalLabel";
            this.weightedGradeTotalLabel.Size = new System.Drawing.Size(210, 25);
            this.weightedGradeTotalLabel.TabIndex = 57;
            this.weightedGradeTotalLabel.Text = "Weighted Grade Total:";
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
            this.gradeListView.Location = new System.Drawing.Point(31, 375);
            this.gradeListView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gradeListView.Name = "gradeListView";
            this.gradeListView.Size = new System.Drawing.Size(1183, 213);
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
            this.errorlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.errorlabel.ForeColor = System.Drawing.Color.Red;
            this.errorlabel.Location = new System.Drawing.Point(27, 92);
            this.errorlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.errorlabel.Name = "errorlabel";
            this.errorlabel.Size = new System.Drawing.Size(15, 20);
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
            this.courseListView.Location = new System.Drawing.Point(31, 156);
            this.courseListView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.courseListView.Name = "courseListView";
            this.courseListView.Size = new System.Drawing.Size(1183, 200);
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
            this.unitsBalanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.unitsBalanceLabel.Location = new System.Drawing.Point(939, 117);
            this.unitsBalanceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.unitsBalanceLabel.Name = "unitsBalanceLabel";
            this.unitsBalanceLabel.Size = new System.Drawing.Size(23, 25);
            this.unitsBalanceLabel.TabIndex = 53;
            this.unitsBalanceLabel.Text = "0";
            // 
            // unitAvailableLabel
            // 
            this.unitAvailableLabel.AutoSize = true;
            this.unitAvailableLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.unitAvailableLabel.Location = new System.Drawing.Point(748, 117);
            this.unitAvailableLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.unitAvailableLabel.Name = "unitAvailableLabel";
            this.unitAvailableLabel.Size = new System.Drawing.Size(183, 25);
            this.unitAvailableLabel.TabIndex = 52;
            this.unitAvailableLabel.Text = "Units Still Available:";
            // 
            // allowedUnitsLabel
            // 
            this.allowedUnitsLabel.AutoSize = true;
            this.allowedUnitsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.allowedUnitsLabel.Location = new System.Drawing.Point(430, 117);
            this.allowedUnitsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.allowedUnitsLabel.Name = "allowedUnitsLabel";
            this.allowedUnitsLabel.Size = new System.Drawing.Size(23, 25);
            this.allowedUnitsLabel.TabIndex = 51;
            this.allowedUnitsLabel.Text = "0";
            // 
            // maxAllowedUnitLabel
            // 
            this.maxAllowedUnitLabel.AutoSize = true;
            this.maxAllowedUnitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.maxAllowedUnitLabel.Location = new System.Drawing.Point(45, 117);
            this.maxAllowedUnitLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.maxAllowedUnitLabel.Name = "maxAllowedUnitLabel";
            this.maxAllowedUnitLabel.Size = new System.Drawing.Size(350, 25);
            this.maxAllowedUnitLabel.TabIndex = 50;
            this.maxAllowedUnitLabel.Text = "Maximum Allowed Units Per Semester:";
            // 
            // currentStudentIDForEdit
            // 
            this.currentStudentIDForEdit.AutoSize = true;
            this.currentStudentIDForEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.currentStudentIDForEdit.Location = new System.Drawing.Point(969, 53);
            this.currentStudentIDForEdit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.currentStudentIDForEdit.Name = "currentStudentIDForEdit";
            this.currentStudentIDForEdit.Size = new System.Drawing.Size(23, 25);
            this.currentStudentIDForEdit.TabIndex = 49;
            this.currentStudentIDForEdit.Text = "0";
            this.currentStudentIDForEdit.TextChanged += new System.EventHandler(this.currentStudentIDForEdit_TextChanged);
            // 
            // currentStudentIDSetLabel
            // 
            this.currentStudentIDSetLabel.AutoSize = true;
            this.currentStudentIDSetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.currentStudentIDSetLabel.Location = new System.Drawing.Point(851, 53);
            this.currentStudentIDSetLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.currentStudentIDSetLabel.Name = "currentStudentIDSetLabel";
            this.currentStudentIDSetLabel.Size = new System.Drawing.Size(110, 25);
            this.currentStudentIDSetLabel.TabIndex = 48;
            this.currentStudentIDSetLabel.Text = "Student ID:";
            // 
            // registeredUnitsDisplayLabel
            // 
            this.registeredUnitsDisplayLabel.AutoSize = true;
            this.registeredUnitsDisplayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.registeredUnitsDisplayLabel.Location = new System.Drawing.Point(678, 117);
            this.registeredUnitsDisplayLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.registeredUnitsDisplayLabel.Name = "registeredUnitsDisplayLabel";
            this.registeredUnitsDisplayLabel.Size = new System.Drawing.Size(23, 25);
            this.registeredUnitsDisplayLabel.TabIndex = 47;
            this.registeredUnitsDisplayLabel.Text = "0";
            // 
            // registeredUnitsLabel
            // 
            this.registeredUnitsLabel.AutoSize = true;
            this.registeredUnitsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.registeredUnitsLabel.Location = new System.Drawing.Point(504, 117);
            this.registeredUnitsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.registeredUnitsLabel.Name = "registeredUnitsLabel";
            this.registeredUnitsLabel.Size = new System.Drawing.Size(165, 25);
            this.registeredUnitsLabel.TabIndex = 46;
            this.registeredUnitsLabel.Text = "Units Registered: ";
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.clearButton.Location = new System.Drawing.Point(695, 52);
            this.clearButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(113, 42);
            this.clearButton.TabIndex = 8;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.searchButton.Location = new System.Drawing.Point(569, 52);
            this.searchButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(113, 42);
            this.searchButton.TabIndex = 7;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // courseYearPicker
            // 
            this.courseYearPicker.CustomFormat = "yyyy";
            this.courseYearPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.courseYearPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.courseYearPicker.Location = new System.Drawing.Point(441, 54);
            this.courseYearPicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.courseYearPicker.Name = "courseYearPicker";
            this.courseYearPicker.ShowUpDown = true;
            this.courseYearPicker.Size = new System.Drawing.Size(83, 30);
            this.courseYearPicker.TabIndex = 6;
            this.courseYearPicker.ValueChanged += new System.EventHandler(this.courseYearPicker_ValueChanged);
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.yearLabel.Location = new System.Drawing.Point(368, 54);
            this.yearLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(53, 25);
            this.yearLabel.TabIndex = 5;
            this.yearLabel.Text = "Year";
            // 
            // semesterComboBox
            // 
            this.semesterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.semesterComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.semesterComboBox.FormattingEnabled = true;
            this.semesterComboBox.Items.AddRange(new object[] {
            "Spring",
            "Summer",
            "Fall"});
            this.semesterComboBox.Location = new System.Drawing.Point(140, 50);
            this.semesterComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.semesterComboBox.Name = "semesterComboBox";
            this.semesterComboBox.Size = new System.Drawing.Size(199, 33);
            this.semesterComboBox.TabIndex = 4;
            this.semesterComboBox.Click += new System.EventHandler(this.semesterComboBox_Click);
            // 
            // semesterLabel
            // 
            this.semesterLabel.AutoSize = true;
            this.semesterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.semesterLabel.Location = new System.Drawing.Point(27, 53);
            this.semesterLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.semesterLabel.Name = "semesterLabel";
            this.semesterLabel.Size = new System.Drawing.Size(96, 25);
            this.semesterLabel.TabIndex = 3;
            this.semesterLabel.Text = "Semester";
            // 
            // registrationDetailsLabel
            // 
            this.registrationDetailsLabel.AutoSize = true;
            this.registrationDetailsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrationDetailsLabel.Location = new System.Drawing.Point(4, 12);
            this.registrationDetailsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.registrationDetailsLabel.Name = "registrationDetailsLabel";
            this.registrationDetailsLabel.Size = new System.Drawing.Size(335, 25);
            this.registrationDetailsLabel.TabIndex = 1;
            this.registrationDetailsLabel.Text = "Registration Details by Student ID";
            // 
            // StudentRegistrationDetailsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "StudentRegistrationDetailsUserControl";
            this.Size = new System.Drawing.Size(1280, 788);
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
