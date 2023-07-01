namespace Gradebook.UserControls
{
    partial class CourseGradesUserControl
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
            this.notesLabel = new System.Windows.Forms.Label();
            this.courseSetLabel = new System.Windows.Forms.Label();
            this.courseclickedLabel = new System.Windows.Forms.Label();
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
            this.courseListView = new System.Windows.Forms.ListView();
            this.CourseIDHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.courseNameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.prefixHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.numberHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sectionHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.unitsHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.studentCountHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.errorlabel = new System.Windows.Forms.Label();
            this.teacherNameComboBox = new System.Windows.Forms.ComboBox();
            this.teacherlabel = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.courseYearPicker = new System.Windows.Forms.DateTimePicker();
            this.yearLabel = new System.Windows.Forms.Label();
            this.semesterComboBox = new System.Windows.Forms.ComboBox();
            this.semesterLabel = new System.Windows.Forms.Label();
            this.gradeDetailsLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.notesLabel);
            this.panel1.Controls.Add(this.courseSetLabel);
            this.panel1.Controls.Add(this.courseclickedLabel);
            this.panel1.Controls.Add(this.CourseGradesListView);
            this.panel1.Controls.Add(this.courseListView);
            this.panel1.Controls.Add(this.errorlabel);
            this.panel1.Controls.Add(this.teacherNameComboBox);
            this.panel1.Controls.Add(this.teacherlabel);
            this.panel1.Controls.Add(this.clearButton);
            this.panel1.Controls.Add(this.searchButton);
            this.panel1.Controls.Add(this.courseYearPicker);
            this.panel1.Controls.Add(this.yearLabel);
            this.panel1.Controls.Add(this.semesterComboBox);
            this.panel1.Controls.Add(this.semesterLabel);
            this.panel1.Controls.Add(this.gradeDetailsLabel);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(954, 625);
            this.panel1.TabIndex = 0;
            // 
            // notesLabel
            // 
            this.notesLabel.AutoSize = true;
            this.notesLabel.Location = new System.Drawing.Point(432, 208);
            this.notesLabel.Name = "notesLabel";
            this.notesLabel.Size = new System.Drawing.Size(120, 13);
            this.notesLabel.TabIndex = 72;
            this.notesLabel.Text = "A = Assignment Number";
            // 
            // courseSetLabel
            // 
            this.courseSetLabel.AutoSize = true;
            this.courseSetLabel.Location = new System.Drawing.Point(70, 208);
            this.courseSetLabel.Name = "courseSetLabel";
            this.courseSetLabel.Size = new System.Drawing.Size(10, 13);
            this.courseSetLabel.TabIndex = 71;
            this.courseSetLabel.Text = "-";
            // 
            // courseclickedLabel
            // 
            this.courseclickedLabel.AutoSize = true;
            this.courseclickedLabel.Location = new System.Drawing.Point(21, 208);
            this.courseclickedLabel.Name = "courseclickedLabel";
            this.courseclickedLabel.Size = new System.Drawing.Size(43, 13);
            this.courseclickedLabel.TabIndex = 70;
            this.courseclickedLabel.Text = "Course:";
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
            this.CourseGradesListView.Location = new System.Drawing.Point(3, 224);
            this.CourseGradesListView.Name = "CourseGradesListView";
            this.CourseGradesListView.Size = new System.Drawing.Size(668, 136);
            this.CourseGradesListView.TabIndex = 69;
            this.CourseGradesListView.UseCompatibleStateImageBehavior = false;
            this.CourseGradesListView.View = System.Windows.Forms.View.Details;
            // 
            // studentIDHeader
            // 
            this.studentIDHeader.Text = "Student ID";
            this.studentIDHeader.Width = 90;
            // 
            // assigment1Header
            // 
            this.assigment1Header.Text = "A-1";
            this.assigment1Header.Width = 54;
            // 
            // assigment2Header
            // 
            this.assigment2Header.Text = "A-2";
            this.assigment2Header.Width = 54;
            // 
            // assigment3Header
            // 
            this.assigment3Header.Text = "A-3";
            this.assigment3Header.Width = 54;
            // 
            // assigment4Header
            // 
            this.assigment4Header.Text = "A-4";
            this.assigment4Header.Width = 54;
            // 
            // assigment5Header
            // 
            this.assigment5Header.Text = "A-5";
            this.assigment5Header.Width = 54;
            // 
            // assigment6Header
            // 
            this.assigment6Header.Text = "A-6";
            this.assigment6Header.Width = 54;
            // 
            // assigment7Header
            // 
            this.assigment7Header.Text = "A-7";
            this.assigment7Header.Width = 54;
            // 
            // assigment8Header
            // 
            this.assigment8Header.Text = "A-8";
            this.assigment8Header.Width = 54;
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
            this.WeightedGradeHeader.Width = 95;
            // 
            // courseListView
            // 
            this.courseListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CourseIDHeader,
            this.courseNameHeader,
            this.prefixHeader,
            this.numberHeader,
            this.sectionHeader,
            this.unitsHeader,
            this.studentCountHeader});
            this.courseListView.FullRowSelect = true;
            this.courseListView.HideSelection = false;
            this.courseListView.Location = new System.Drawing.Point(3, 83);
            this.courseListView.Name = "courseListView";
            this.courseListView.Size = new System.Drawing.Size(668, 124);
            this.courseListView.TabIndex = 68;
            this.courseListView.UseCompatibleStateImageBehavior = false;
            this.courseListView.View = System.Windows.Forms.View.Details;
            this.courseListView.Click += new System.EventHandler(this.courseListView_Click);
            // 
            // CourseIDHeader
            // 
            this.CourseIDHeader.Text = "Course ID";
            this.CourseIDHeader.Width = 120;
            // 
            // courseNameHeader
            // 
            this.courseNameHeader.Text = "Title";
            this.courseNameHeader.Width = 180;
            // 
            // prefixHeader
            // 
            this.prefixHeader.Text = "Prefix";
            // 
            // numberHeader
            // 
            this.numberHeader.Text = "Number";
            this.numberHeader.Width = 90;
            // 
            // sectionHeader
            // 
            this.sectionHeader.Text = "Section";
            this.sectionHeader.Width = 90;
            // 
            // unitsHeader
            // 
            this.unitsHeader.Text = "Units";
            // 
            // studentCountHeader
            // 
            this.studentCountHeader.Text = "Student Count";
            this.studentCountHeader.Width = 140;
            // 
            // errorlabel
            // 
            this.errorlabel.AutoSize = true;
            this.errorlabel.Location = new System.Drawing.Point(36, 67);
            this.errorlabel.Name = "errorlabel";
            this.errorlabel.Size = new System.Drawing.Size(10, 13);
            this.errorlabel.TabIndex = 67;
            this.errorlabel.Text = "-";
            // 
            // teacherNameComboBox
            // 
            this.teacherNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.teacherNameComboBox.FormattingEnabled = true;
            this.teacherNameComboBox.Items.AddRange(new object[] {
            "Spring",
            "Summer",
            "Fall"});
            this.teacherNameComboBox.Location = new System.Drawing.Point(63, 41);
            this.teacherNameComboBox.Name = "teacherNameComboBox";
            this.teacherNameComboBox.Size = new System.Drawing.Size(150, 21);
            this.teacherNameComboBox.TabIndex = 66;
            this.teacherNameComboBox.Click += new System.EventHandler(this.teacherNameComboBox_Click);
            // 
            // teacherlabel
            // 
            this.teacherlabel.AutoSize = true;
            this.teacherlabel.Location = new System.Drawing.Point(10, 44);
            this.teacherlabel.Name = "teacherlabel";
            this.teacherlabel.Size = new System.Drawing.Size(47, 13);
            this.teacherlabel.TabIndex = 65;
            this.teacherlabel.Text = "Teacher";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(585, 40);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 64;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(504, 41);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 63;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // courseYearPicker
            // 
            this.courseYearPicker.CustomFormat = "yyyy";
            this.courseYearPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.courseYearPicker.Location = new System.Drawing.Point(435, 44);
            this.courseYearPicker.Name = "courseYearPicker";
            this.courseYearPicker.ShowUpDown = true;
            this.courseYearPicker.Size = new System.Drawing.Size(63, 20);
            this.courseYearPicker.TabIndex = 62;
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(400, 45);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(29, 13);
            this.yearLabel.TabIndex = 61;
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
            this.semesterComboBox.Location = new System.Drawing.Point(276, 41);
            this.semesterComboBox.Name = "semesterComboBox";
            this.semesterComboBox.Size = new System.Drawing.Size(118, 21);
            this.semesterComboBox.TabIndex = 60;
            this.semesterComboBox.Click += new System.EventHandler(this.semesterComboBox_Click);
            // 
            // semesterLabel
            // 
            this.semesterLabel.AutoSize = true;
            this.semesterLabel.Location = new System.Drawing.Point(219, 45);
            this.semesterLabel.Name = "semesterLabel";
            this.semesterLabel.Size = new System.Drawing.Size(51, 13);
            this.semesterLabel.TabIndex = 59;
            this.semesterLabel.Text = "Semester";
            // 
            // gradeDetailsLabel
            // 
            this.gradeDetailsLabel.AutoSize = true;
            this.gradeDetailsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradeDetailsLabel.Location = new System.Drawing.Point(9, 4);
            this.gradeDetailsLabel.Name = "gradeDetailsLabel";
            this.gradeDetailsLabel.Size = new System.Drawing.Size(204, 20);
            this.gradeDetailsLabel.TabIndex = 58;
            this.gradeDetailsLabel.Text = "Grade Report by Course";
            // 
            // CourseGradesUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "CourseGradesUserControl";
            this.Size = new System.Drawing.Size(960, 640);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView courseListView;
        private System.Windows.Forms.ColumnHeader CourseIDHeader;
        private System.Windows.Forms.ColumnHeader courseNameHeader;
        private System.Windows.Forms.ColumnHeader prefixHeader;
        private System.Windows.Forms.ColumnHeader numberHeader;
        private System.Windows.Forms.ColumnHeader sectionHeader;
        private System.Windows.Forms.ColumnHeader unitsHeader;
        private System.Windows.Forms.ColumnHeader studentCountHeader;
        private System.Windows.Forms.Label errorlabel;
        private System.Windows.Forms.ComboBox teacherNameComboBox;
        private System.Windows.Forms.Label teacherlabel;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.DateTimePicker courseYearPicker;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.ComboBox semesterComboBox;
        private System.Windows.Forms.Label semesterLabel;
        private System.Windows.Forms.Label gradeDetailsLabel;
        private System.Windows.Forms.ListView CourseGradesListView;
        private System.Windows.Forms.Label courseSetLabel;
        private System.Windows.Forms.Label courseclickedLabel;
        private System.Windows.Forms.Label notesLabel;
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
