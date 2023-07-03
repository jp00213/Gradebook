namespace Gradebook.UserControls
{
    partial class RosterUserControl
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
            this.rosterListView = new System.Windows.Forms.ListView();
            this.courseHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.studentHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.studentNameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.registrationDetailsLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rosterListView);
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
            this.panel1.Controls.Add(this.registrationDetailsLabel);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1256, 767);
            this.panel1.TabIndex = 0;
            // 
            // rosterListView
            // 
            this.rosterListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.courseHeader,
            this.studentHeader,
            this.studentNameHeader});
            this.rosterListView.HideSelection = false;
            this.rosterListView.Location = new System.Drawing.Point(21, 268);
            this.rosterListView.Margin = new System.Windows.Forms.Padding(4);
            this.rosterListView.Name = "rosterListView";
            this.rosterListView.Size = new System.Drawing.Size(809, 162);
            this.rosterListView.TabIndex = 58;
            this.rosterListView.UseCompatibleStateImageBehavior = false;
            this.rosterListView.View = System.Windows.Forms.View.Details;
            // 
            // courseHeader
            // 
            this.courseHeader.Text = "Course ID";
            this.courseHeader.Width = 120;
            // 
            // studentHeader
            // 
            this.studentHeader.Text = "Student ID";
            this.studentHeader.Width = 120;
            // 
            // studentNameHeader
            // 
            this.studentNameHeader.Text = "Student Name";
            this.studentNameHeader.Width = 170;
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
            this.courseListView.Location = new System.Drawing.Point(21, 108);
            this.courseListView.Margin = new System.Windows.Forms.Padding(4);
            this.courseListView.Name = "courseListView";
            this.courseListView.Size = new System.Drawing.Size(809, 152);
            this.courseListView.TabIndex = 57;
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
            this.errorlabel.Location = new System.Drawing.Point(67, 78);
            this.errorlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.errorlabel.Name = "errorlabel";
            this.errorlabel.Size = new System.Drawing.Size(11, 16);
            this.errorlabel.TabIndex = 56;
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
            this.teacherNameComboBox.Location = new System.Drawing.Point(88, 46);
            this.teacherNameComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.teacherNameComboBox.Name = "teacherNameComboBox";
            this.teacherNameComboBox.Size = new System.Drawing.Size(199, 24);
            this.teacherNameComboBox.TabIndex = 17;
            this.teacherNameComboBox.Click += new System.EventHandler(this.teacherNameComboBox_Click);
            // 
            // teacherlabel
            // 
            this.teacherlabel.AutoSize = true;
            this.teacherlabel.Location = new System.Drawing.Point(17, 49);
            this.teacherlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.teacherlabel.Name = "teacherlabel";
            this.teacherlabel.Size = new System.Drawing.Size(58, 16);
            this.teacherlabel.TabIndex = 16;
            this.teacherlabel.Text = "Teacher";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(784, 46);
            this.clearButton.Margin = new System.Windows.Forms.Padding(4);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(100, 28);
            this.clearButton.TabIndex = 21;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(676, 46);
            this.searchButton.Margin = new System.Windows.Forms.Padding(4);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(100, 28);
            this.searchButton.TabIndex = 20;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // courseYearPicker
            // 
            this.courseYearPicker.CustomFormat = "yyyy";
            this.courseYearPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.courseYearPicker.Location = new System.Drawing.Point(584, 49);
            this.courseYearPicker.Margin = new System.Windows.Forms.Padding(4);
            this.courseYearPicker.Name = "courseYearPicker";
            this.courseYearPicker.ShowUpDown = true;
            this.courseYearPicker.Size = new System.Drawing.Size(83, 22);
            this.courseYearPicker.TabIndex = 19;
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(537, 50);
            this.yearLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(36, 16);
            this.yearLabel.TabIndex = 12;
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
            this.semesterComboBox.Location = new System.Drawing.Point(372, 46);
            this.semesterComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.semesterComboBox.Name = "semesterComboBox";
            this.semesterComboBox.Size = new System.Drawing.Size(156, 24);
            this.semesterComboBox.TabIndex = 18;
            this.semesterComboBox.Click += new System.EventHandler(this.semesterComboBox_Click);
            // 
            // semesterLabel
            // 
            this.semesterLabel.AutoSize = true;
            this.semesterLabel.Location = new System.Drawing.Point(296, 50);
            this.semesterLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.semesterLabel.Name = "semesterLabel";
            this.semesterLabel.Size = new System.Drawing.Size(65, 16);
            this.semesterLabel.TabIndex = 10;
            this.semesterLabel.Text = "Semester";
            // 
            // registrationDetailsLabel
            // 
            this.registrationDetailsLabel.AutoSize = true;
            this.registrationDetailsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrationDetailsLabel.Location = new System.Drawing.Point(16, 0);
            this.registrationDetailsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.registrationDetailsLabel.Name = "registrationDetailsLabel";
            this.registrationDetailsLabel.Size = new System.Drawing.Size(160, 25);
            this.registrationDetailsLabel.TabIndex = 9;
            this.registrationDetailsLabel.Text = "Teacher Roster";
            // 
            // RosterUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RosterUserControl";
            this.Size = new System.Drawing.Size(1280, 788);
            this.VisibleChanged += new System.EventHandler(this.RosterUserControl_VisibleChanged);
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
        private System.Windows.Forms.Label registrationDetailsLabel;
        private System.Windows.Forms.ComboBox teacherNameComboBox;
        private System.Windows.Forms.Label teacherlabel;
        private System.Windows.Forms.Label errorlabel;
        private System.Windows.Forms.ListView courseListView;
        private System.Windows.Forms.ColumnHeader CourseIDHeader;
        private System.Windows.Forms.ColumnHeader courseNameHeader;
        private System.Windows.Forms.ColumnHeader prefixHeader;
        private System.Windows.Forms.ColumnHeader numberHeader;
        private System.Windows.Forms.ColumnHeader sectionHeader;
        private System.Windows.Forms.ColumnHeader unitsHeader;
        private System.Windows.Forms.ColumnHeader studentCountHeader;
        private System.Windows.Forms.ListView rosterListView;
        private System.Windows.Forms.ColumnHeader courseHeader;
        private System.Windows.Forms.ColumnHeader studentHeader;
        private System.Windows.Forms.ColumnHeader studentNameHeader;
    }
}
