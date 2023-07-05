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
            this.clearButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.courseYearPicker = new System.Windows.Forms.DateTimePicker();
            this.yearLabel = new System.Windows.Forms.Label();
            this.semesterComboBox = new System.Windows.Forms.ComboBox();
            this.semesterLabel = new System.Windows.Forms.Label();
            this.currentStudentID = new System.Windows.Forms.Label();
            this.currentStudentIDSetLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
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
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(383, 17);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 27;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(302, 17);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 26;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // courseYearPicker
            // 
            this.courseYearPicker.CustomFormat = "yyyy";
            this.courseYearPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.courseYearPicker.Location = new System.Drawing.Point(233, 18);
            this.courseYearPicker.Name = "courseYearPicker";
            this.courseYearPicker.ShowUpDown = true;
            this.courseYearPicker.Size = new System.Drawing.Size(63, 20);
            this.courseYearPicker.TabIndex = 25;
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(198, 21);
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
            this.semesterComboBox.Location = new System.Drawing.Point(74, 17);
            this.semesterComboBox.Name = "semesterComboBox";
            this.semesterComboBox.Size = new System.Drawing.Size(118, 21);
            this.semesterComboBox.TabIndex = 24;
            // 
            // semesterLabel
            // 
            this.semesterLabel.AutoSize = true;
            this.semesterLabel.Location = new System.Drawing.Point(17, 21);
            this.semesterLabel.Name = "semesterLabel";
            this.semesterLabel.Size = new System.Drawing.Size(51, 13);
            this.semesterLabel.TabIndex = 22;
            this.semesterLabel.Text = "Semester";
            // 
            // currentStudentID
            // 
            this.currentStudentID.AutoSize = true;
            this.currentStudentID.Location = new System.Drawing.Point(522, 22);
            this.currentStudentID.Name = "currentStudentID";
            this.currentStudentID.Size = new System.Drawing.Size(13, 13);
            this.currentStudentID.TabIndex = 45;
            this.currentStudentID.Text = "0";
            // 
            // currentStudentIDSetLabel
            // 
            this.currentStudentIDSetLabel.AutoSize = true;
            this.currentStudentIDSetLabel.Location = new System.Drawing.Point(464, 22);
            this.currentStudentIDSetLabel.Name = "currentStudentIDSetLabel";
            this.currentStudentIDSetLabel.Size = new System.Drawing.Size(61, 13);
            this.currentStudentIDSetLabel.TabIndex = 44;
            this.currentStudentIDSetLabel.Text = "Student ID:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(541, 22);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(13, 13);
            this.nameLabel.TabIndex = 46;
            this.nameLabel.Text = "--";
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
    }
}
