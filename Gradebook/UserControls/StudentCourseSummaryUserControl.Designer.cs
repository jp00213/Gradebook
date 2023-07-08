namespace Gradebook.UserControls
{
    partial class StudentCourseSummaryUserControl
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
            this.errorLabel = new System.Windows.Forms.Label();
            this.gradeDetailsLabel = new System.Windows.Forms.Label();
            this.CourseGradesListView = new System.Windows.Forms.ListView();
            this.studentIDHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.assigment1Header = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.assigment2Header = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.assigment3Header = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.assigment4Header = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.assigment5Header = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.assigment6Header = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.assigment7Header = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.assigment8Header = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.assigment9Header = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.assigment10Header = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.assigment11Header = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.assigment12Header = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.assigment13Header = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.assigment14Header = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.assigment15Header = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.WeightedGradeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gradeSummaryListView = new System.Windows.Forms.ListView();
            this.yearHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.termHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.courseIDHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.descriptionHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sectionHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.unitsHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.scoreHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gradeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gradePointsHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pointsHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.errorMessageLabel = new System.Windows.Forms.Label();
            this.cumulativeGPADataLabel = new System.Windows.Forms.Label();
            this.cumulativeGPALabel = new System.Windows.Forms.Label();
            this.CourseAndGradeLabel = new System.Windows.Forms.Label();
            this.semesterGPADataLabel = new System.Windows.Forms.Label();
            this.semesterGPALabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.currentStudentID = new System.Windows.Forms.Label();
            this.currentStudentIDSetLabel = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.courseYearPicker = new System.Windows.Forms.DateTimePicker();
            this.yearLabel = new System.Windows.Forms.Label();
            this.semesterComboBox = new System.Windows.Forms.ComboBox();
            this.semesterLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.errorLabel);
            this.panel1.Controls.Add(this.gradeDetailsLabel);
            this.panel1.Controls.Add(this.CourseGradesListView);
            this.panel1.Controls.Add(this.gradeSummaryListView);
            this.panel1.Controls.Add(this.errorMessageLabel);
            this.panel1.Controls.Add(this.cumulativeGPADataLabel);
            this.panel1.Controls.Add(this.cumulativeGPALabel);
            this.panel1.Controls.Add(this.CourseAndGradeLabel);
            this.panel1.Controls.Add(this.semesterGPADataLabel);
            this.panel1.Controls.Add(this.semesterGPALabel);
            this.panel1.Controls.Add(this.nameLabel);
            this.panel1.Controls.Add(this.currentStudentID);
            this.panel1.Controls.Add(this.currentStudentIDSetLabel);
            this.panel1.Controls.Add(this.clearButton);
            this.panel1.Controls.Add(this.searchButton);
            this.panel1.Controls.Add(this.courseYearPicker);
            this.panel1.Controls.Add(this.yearLabel);
            this.panel1.Controls.Add(this.semesterComboBox);
            this.panel1.Controls.Add(this.semesterLabel);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(944, 625);
            this.panel1.TabIndex = 0;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(198, 240);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(10, 13);
            this.errorLabel.TabIndex = 75;
            this.errorLabel.Text = "-";
            // 
            // gradeDetailsLabel
            // 
            this.gradeDetailsLabel.AutoSize = true;
            this.gradeDetailsLabel.Location = new System.Drawing.Point(3, 240);
            this.gradeDetailsLabel.Name = "gradeDetailsLabel";
            this.gradeDetailsLabel.Size = new System.Drawing.Size(71, 13);
            this.gradeDetailsLabel.TabIndex = 74;
            this.gradeDetailsLabel.Text = "Grade Details";
            // 
            // CourseGradesListView
            // 
            this.CourseGradesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.studentIDHeader,
            this.assigment1Header,
            this.assigment2Header,
            this.assigment3Header,
            this.assigment4Header,
            this.assigment5Header,
            this.assigment6Header,
            this.assigment7Header,
            this.assigment8Header,
            this.assigment9Header,
            this.assigment10Header,
            this.assigment11Header,
            this.assigment12Header,
            this.assigment13Header,
            this.assigment14Header,
            this.assigment15Header,
            this.WeightedGradeHeader});
            this.CourseGradesListView.HideSelection = false;
            this.CourseGradesListView.Location = new System.Drawing.Point(3, 256);
            this.CourseGradesListView.Name = "CourseGradesListView";
            this.CourseGradesListView.Size = new System.Drawing.Size(726, 136);
            this.CourseGradesListView.TabIndex = 73;
            this.CourseGradesListView.UseCompatibleStateImageBehavior = false;
            this.CourseGradesListView.View = System.Windows.Forms.View.Details;
            // 
            // studentIDHeader
            // 
            this.studentIDHeader.Text = "Student ID";
            this.studentIDHeader.Width = 80;
            // 
            // assigment1Header
            // 
            this.assigment1Header.Text = "A-1";
            this.assigment1Header.Width = 53;
            // 
            // assigment2Header
            // 
            this.assigment2Header.Text = "A-2";
            this.assigment2Header.Width = 53;
            // 
            // assigment3Header
            // 
            this.assigment3Header.Text = "A-3";
            this.assigment3Header.Width = 53;
            // 
            // assigment4Header
            // 
            this.assigment4Header.Text = "A-4";
            this.assigment4Header.Width = 53;
            // 
            // assigment5Header
            // 
            this.assigment5Header.Text = "A-5";
            this.assigment5Header.Width = 53;
            // 
            // assigment6Header
            // 
            this.assigment6Header.Text = "A-6";
            this.assigment6Header.Width = 53;
            // 
            // assigment7Header
            // 
            this.assigment7Header.Text = "A-7";
            this.assigment7Header.Width = 53;
            // 
            // assigment8Header
            // 
            this.assigment8Header.Text = "A-8";
            this.assigment8Header.Width = 53;
            // 
            // assigment9Header
            // 
            this.assigment9Header.Text = "A-9";
            this.assigment9Header.Width = 54;
            // 
            // assigment10Header
            // 
            this.assigment10Header.Text = "A-10";
            this.assigment10Header.Width = 54;
            // 
            // assigment11Header
            // 
            this.assigment11Header.Text = "A-11";
            this.assigment11Header.Width = 54;
            // 
            // assigment12Header
            // 
            this.assigment12Header.Text = "A-12";
            this.assigment12Header.Width = 54;
            // 
            // assigment13Header
            // 
            this.assigment13Header.Text = "A-13";
            this.assigment13Header.Width = 54;
            // 
            // assigment14Header
            // 
            this.assigment14Header.Text = "A-14";
            this.assigment14Header.Width = 54;
            // 
            // assigment15Header
            // 
            this.assigment15Header.Text = "A-15";
            this.assigment15Header.Width = 54;
            // 
            // WeightedGradeHeader
            // 
            this.WeightedGradeHeader.Text = "Final Score";
            this.WeightedGradeHeader.Width = 103;
            // 
            // gradeSummaryListView
            // 
            this.gradeSummaryListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.yearHeader,
            this.termHeader,
            this.courseIDHeader,
            this.descriptionHeader,
            this.sectionHeader,
            this.unitsHeader,
            this.scoreHeader,
            this.gradeHeader,
            this.gradePointsHeader,
            this.pointsHeader});
            this.gradeSummaryListView.FullRowSelect = true;
            this.gradeSummaryListView.HideSelection = false;
            this.gradeSummaryListView.Location = new System.Drawing.Point(3, 85);
            this.gradeSummaryListView.Name = "gradeSummaryListView";
            this.gradeSummaryListView.Size = new System.Drawing.Size(726, 152);
            this.gradeSummaryListView.TabIndex = 63;
            this.gradeSummaryListView.UseCompatibleStateImageBehavior = false;
            this.gradeSummaryListView.View = System.Windows.Forms.View.Details;
            this.gradeSummaryListView.Click += new System.EventHandler(this.gradeSummaryListView_Click);
            // 
            // yearHeader
            // 
            this.yearHeader.Text = "Year";
            this.yearHeader.Width = 50;
            // 
            // termHeader
            // 
            this.termHeader.Text = "Term";
            this.termHeader.Width = 70;
            // 
            // courseIDHeader
            // 
            this.courseIDHeader.Text = "CourseID";
            this.courseIDHeader.Width = 70;
            // 
            // descriptionHeader
            // 
            this.descriptionHeader.Text = "Course";
            this.descriptionHeader.Width = 120;
            // 
            // sectionHeader
            // 
            this.sectionHeader.Text = "Number";
            // 
            // unitsHeader
            // 
            this.unitsHeader.Text = "Units";
            this.unitsHeader.Width = 50;
            // 
            // scoreHeader
            // 
            this.scoreHeader.Text = "Score";
            this.scoreHeader.Width = 50;
            // 
            // gradeHeader
            // 
            this.gradeHeader.Text = "Grade";
            this.gradeHeader.Width = 50;
            // 
            // gradePointsHeader
            // 
            this.gradePointsHeader.Text = "Grade Points";
            this.gradePointsHeader.Width = 90;
            // 
            // pointsHeader
            // 
            this.pointsHeader.Text = "Points";
            this.pointsHeader.Width = 50;
            // 
            // errorMessageLabel
            // 
            this.errorMessageLabel.AutoSize = true;
            this.errorMessageLabel.Location = new System.Drawing.Point(29, 40);
            this.errorMessageLabel.Name = "errorMessageLabel";
            this.errorMessageLabel.Size = new System.Drawing.Size(10, 13);
            this.errorMessageLabel.TabIndex = 62;
            this.errorMessageLabel.Text = "-";
            // 
            // cumulativeGPADataLabel
            // 
            this.cumulativeGPADataLabel.AutoSize = true;
            this.cumulativeGPADataLabel.Location = new System.Drawing.Point(531, 56);
            this.cumulativeGPADataLabel.Name = "cumulativeGPADataLabel";
            this.cumulativeGPADataLabel.Size = new System.Drawing.Size(10, 13);
            this.cumulativeGPADataLabel.TabIndex = 61;
            this.cumulativeGPADataLabel.Text = "-";
            // 
            // cumulativeGPALabel
            // 
            this.cumulativeGPALabel.AutoSize = true;
            this.cumulativeGPALabel.Location = new System.Drawing.Point(434, 56);
            this.cumulativeGPALabel.Name = "cumulativeGPALabel";
            this.cumulativeGPALabel.Size = new System.Drawing.Size(87, 13);
            this.cumulativeGPALabel.TabIndex = 60;
            this.cumulativeGPALabel.Text = "Cumulative GPA:";
            // 
            // CourseAndGradeLabel
            // 
            this.CourseAndGradeLabel.AutoSize = true;
            this.CourseAndGradeLabel.Location = new System.Drawing.Point(3, 56);
            this.CourseAndGradeLabel.Name = "CourseAndGradeLabel";
            this.CourseAndGradeLabel.Size = new System.Drawing.Size(137, 13);
            this.CourseAndGradeLabel.TabIndex = 58;
            this.CourseAndGradeLabel.Text = "Grade Summary Information";
            // 
            // semesterGPADataLabel
            // 
            this.semesterGPADataLabel.AutoSize = true;
            this.semesterGPADataLabel.Location = new System.Drawing.Point(382, 56);
            this.semesterGPADataLabel.Name = "semesterGPADataLabel";
            this.semesterGPADataLabel.Size = new System.Drawing.Size(10, 13);
            this.semesterGPADataLabel.TabIndex = 57;
            this.semesterGPADataLabel.Text = "-";
            // 
            // semesterGPALabel
            // 
            this.semesterGPALabel.AutoSize = true;
            this.semesterGPALabel.Location = new System.Drawing.Point(286, 56);
            this.semesterGPALabel.Name = "semesterGPALabel";
            this.semesterGPALabel.Size = new System.Drawing.Size(79, 13);
            this.semesterGPALabel.TabIndex = 56;
            this.semesterGPALabel.Text = "Semester GPA:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(541, 16);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(13, 13);
            this.nameLabel.TabIndex = 46;
            this.nameLabel.Text = "--";
            // 
            // currentStudentID
            // 
            this.currentStudentID.AutoSize = true;
            this.currentStudentID.Location = new System.Drawing.Point(522, 16);
            this.currentStudentID.Name = "currentStudentID";
            this.currentStudentID.Size = new System.Drawing.Size(13, 13);
            this.currentStudentID.TabIndex = 45;
            this.currentStudentID.Text = "0";
            // 
            // currentStudentIDSetLabel
            // 
            this.currentStudentIDSetLabel.AutoSize = true;
            this.currentStudentIDSetLabel.Location = new System.Drawing.Point(464, 16);
            this.currentStudentIDSetLabel.Name = "currentStudentIDSetLabel";
            this.currentStudentIDSetLabel.Size = new System.Drawing.Size(61, 13);
            this.currentStudentIDSetLabel.TabIndex = 44;
            this.currentStudentIDSetLabel.Text = "Student ID:";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(383, 11);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 27;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(302, 11);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 26;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // courseYearPicker
            // 
            this.courseYearPicker.CustomFormat = "yyyy";
            this.courseYearPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.courseYearPicker.Location = new System.Drawing.Point(233, 12);
            this.courseYearPicker.Name = "courseYearPicker";
            this.courseYearPicker.ShowUpDown = true;
            this.courseYearPicker.Size = new System.Drawing.Size(63, 20);
            this.courseYearPicker.TabIndex = 25;
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(198, 15);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(29, 13);
            this.yearLabel.TabIndex = 23;
            this.yearLabel.Text = "Year";
            // 
            // semesterComboBox
            // 
            this.semesterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.semesterComboBox.FormattingEnabled = true;
            this.semesterComboBox.Items.AddRange(new object[] {
            "-- Select One --",
            "Spring",
            "Summer",
            "Fall"});
            this.semesterComboBox.Location = new System.Drawing.Point(74, 11);
            this.semesterComboBox.Name = "semesterComboBox";
            this.semesterComboBox.Size = new System.Drawing.Size(118, 21);
            this.semesterComboBox.TabIndex = 24;
            // 
            // semesterLabel
            // 
            this.semesterLabel.AutoSize = true;
            this.semesterLabel.Location = new System.Drawing.Point(17, 15);
            this.semesterLabel.Name = "semesterLabel";
            this.semesterLabel.Size = new System.Drawing.Size(51, 13);
            this.semesterLabel.TabIndex = 22;
            this.semesterLabel.Text = "Semester";
            // 
            // StudentCourseSummaryUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "StudentCourseSummaryUserControl";
            this.Size = new System.Drawing.Size(960, 640);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.DateTimePicker courseYearPicker;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.ComboBox semesterComboBox;
        private System.Windows.Forms.Label semesterLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label currentStudentID;
        private System.Windows.Forms.Label currentStudentIDSetLabel;
        private System.Windows.Forms.Label errorMessageLabel;
        private System.Windows.Forms.Label cumulativeGPADataLabel;
        private System.Windows.Forms.Label cumulativeGPALabel;
        private System.Windows.Forms.Label CourseAndGradeLabel;
        private System.Windows.Forms.Label semesterGPADataLabel;
        private System.Windows.Forms.Label semesterGPALabel;
        private System.Windows.Forms.ListView gradeSummaryListView;
        private System.Windows.Forms.ColumnHeader yearHeader;
        private System.Windows.Forms.ColumnHeader termHeader;
        private System.Windows.Forms.ColumnHeader courseIDHeader;
        private System.Windows.Forms.ColumnHeader descriptionHeader;
        private System.Windows.Forms.ColumnHeader sectionHeader;
        private System.Windows.Forms.ColumnHeader unitsHeader;
        private System.Windows.Forms.ColumnHeader scoreHeader;
        private System.Windows.Forms.ColumnHeader gradeHeader;
        private System.Windows.Forms.ColumnHeader gradePointsHeader;
        private System.Windows.Forms.ColumnHeader pointsHeader;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Label gradeDetailsLabel;
        private System.Windows.Forms.ListView CourseGradesListView;
        private System.Windows.Forms.ColumnHeader studentIDHeader;
        private System.Windows.Forms.ColumnHeader assigment1Header;
        private System.Windows.Forms.ColumnHeader assigment2Header;
        private System.Windows.Forms.ColumnHeader assigment3Header;
        private System.Windows.Forms.ColumnHeader assigment4Header;
        private System.Windows.Forms.ColumnHeader assigment5Header;
        private System.Windows.Forms.ColumnHeader assigment6Header;
        private System.Windows.Forms.ColumnHeader assigment7Header;
        private System.Windows.Forms.ColumnHeader assigment8Header;
        private System.Windows.Forms.ColumnHeader assigment9Header;
        private System.Windows.Forms.ColumnHeader assigment10Header;
        private System.Windows.Forms.ColumnHeader assigment11Header;
        private System.Windows.Forms.ColumnHeader assigment12Header;
        private System.Windows.Forms.ColumnHeader assigment13Header;
        private System.Windows.Forms.ColumnHeader assigment14Header;
        private System.Windows.Forms.ColumnHeader assigment15Header;
        private System.Windows.Forms.ColumnHeader WeightedGradeHeader;
    }
}
