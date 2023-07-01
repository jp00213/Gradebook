namespace Gradebook.UserControls
{
    partial class AdministratorRegisterStudent
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label studentFullNameLabel;
            System.Windows.Forms.Label studentBirthdayLabel;
            this.courseDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchCourseButton = new System.Windows.Forms.Button();
            this.semesterComboBox = new System.Windows.Forms.ComboBox();
            this.semesterLabel = new System.Windows.Forms.Label();
            this.courseYearPicker = new System.Windows.Forms.DateTimePicker();
            this.yearLabel = new System.Windows.Forms.Label();
            this.studentIDTextBox = new System.Windows.Forms.TextBox();
            this.studentIDLabel = new System.Windows.Forms.Label();
            this.searchStudentButton = new System.Windows.Forms.Button();
            this.registerButton = new System.Windows.Forms.Button();
            this.studentNameTextBox = new System.Windows.Forms.TextBox();
            this.studentBirthdayTextBox = new System.Windows.Forms.TextBox();
            this.findStudentErrorLabel = new System.Windows.Forms.Label();
            studentFullNameLabel = new System.Windows.Forms.Label();
            studentBirthdayLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.courseDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // studentFullNameLabel
            // 
            studentFullNameLabel.AutoSize = true;
            studentFullNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            studentFullNameLabel.Location = new System.Drawing.Point(622, 337);
            studentFullNameLabel.Name = "studentFullNameLabel";
            studentFullNameLabel.Size = new System.Drawing.Size(100, 25);
            studentFullNameLabel.TabIndex = 22;
            studentFullNameLabel.Text = "Full Name";
            // 
            // studentBirthdayLabel
            // 
            studentBirthdayLabel.AutoSize = true;
            studentBirthdayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            studentBirthdayLabel.Location = new System.Drawing.Point(622, 371);
            studentBirthdayLabel.Name = "studentBirthdayLabel";
            studentBirthdayLabel.Size = new System.Drawing.Size(83, 25);
            studentBirthdayLabel.TabIndex = 23;
            studentBirthdayLabel.Text = "Birthday";
            // 
            // courseDataGridView
            // 
            this.courseDataGridView.AllowUserToAddRows = false;
            this.courseDataGridView.AllowUserToDeleteRows = false;
            this.courseDataGridView.AutoGenerateColumns = false;
            this.courseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.courseDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.courseDataGridView.DataSource = this.courseBindingSource;
            this.courseDataGridView.Location = new System.Drawing.Point(59, 80);
            this.courseDataGridView.MultiSelect = false;
            this.courseDataGridView.Name = "courseDataGridView";
            this.courseDataGridView.ReadOnly = true;
            this.courseDataGridView.RowHeadersWidth = 51;
            this.courseDataGridView.RowTemplate.Height = 24;
            this.courseDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.courseDataGridView.Size = new System.Drawing.Size(1134, 220);
            this.courseDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CourseID";
            this.dataGridViewTextBoxColumn1.HeaderText = "CourseID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Prefix";
            this.dataGridViewTextBoxColumn3.HeaderText = "Prefix";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Number";
            this.dataGridViewTextBoxColumn4.HeaderText = "Number";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Section";
            this.dataGridViewTextBoxColumn5.HeaderText = "Section";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "CreditHours";
            this.dataGridViewTextBoxColumn6.HeaderText = "CreditHours";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataSource = typeof(Gradebook.Model.Course);
            // 
            // searchCourseButton
            // 
            this.searchCourseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.searchCourseButton.Location = new System.Drawing.Point(645, 18);
            this.searchCourseButton.Name = "searchCourseButton";
            this.searchCourseButton.Size = new System.Drawing.Size(179, 43);
            this.searchCourseButton.TabIndex = 2;
            this.searchCourseButton.Text = "Search Courses";
            this.searchCourseButton.UseVisualStyleBackColor = true;
            this.searchCourseButton.Click += new System.EventHandler(this.searchCourseButton_Click);
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
            this.semesterComboBox.Location = new System.Drawing.Point(177, 31);
            this.semesterComboBox.Name = "semesterComboBox";
            this.semesterComboBox.Size = new System.Drawing.Size(193, 33);
            this.semesterComboBox.TabIndex = 17;
            // 
            // semesterLabel
            // 
            this.semesterLabel.AutoSize = true;
            this.semesterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.semesterLabel.Location = new System.Drawing.Point(75, 31);
            this.semesterLabel.Name = "semesterLabel";
            this.semesterLabel.Size = new System.Drawing.Size(96, 25);
            this.semesterLabel.TabIndex = 16;
            this.semesterLabel.Text = "Semester";
            // 
            // courseYearPicker
            // 
            this.courseYearPicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.courseYearPicker.CustomFormat = "yyyy";
            this.courseYearPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.courseYearPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.courseYearPicker.Location = new System.Drawing.Point(479, 31);
            this.courseYearPicker.Name = "courseYearPicker";
            this.courseYearPicker.ShowUpDown = true;
            this.courseYearPicker.Size = new System.Drawing.Size(115, 30);
            this.courseYearPicker.TabIndex = 19;
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.yearLabel.Location = new System.Drawing.Point(420, 31);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(53, 25);
            this.yearLabel.TabIndex = 18;
            this.yearLabel.Text = "Year";
            // 
            // studentIDTextBox
            // 
            this.studentIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.studentIDTextBox.Location = new System.Drawing.Point(190, 334);
            this.studentIDTextBox.Name = "studentIDTextBox";
            this.studentIDTextBox.Size = new System.Drawing.Size(121, 30);
            this.studentIDTextBox.TabIndex = 20;
            this.studentIDTextBox.TextChanged += new System.EventHandler(this.studentIDTextBox_TextChanged);
            // 
            // studentIDLabel
            // 
            this.studentIDLabel.AutoSize = true;
            this.studentIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.studentIDLabel.Location = new System.Drawing.Point(71, 334);
            this.studentIDLabel.Name = "studentIDLabel";
            this.studentIDLabel.Size = new System.Drawing.Size(104, 25);
            this.studentIDLabel.TabIndex = 21;
            this.studentIDLabel.Text = "Student ID";
            // 
            // searchStudentButton
            // 
            this.searchStudentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.searchStudentButton.Location = new System.Drawing.Point(352, 334);
            this.searchStudentButton.Name = "searchStudentButton";
            this.searchStudentButton.Size = new System.Drawing.Size(178, 38);
            this.searchStudentButton.TabIndex = 22;
            this.searchStudentButton.Text = "Find Student";
            this.searchStudentButton.UseVisualStyleBackColor = true;
            this.searchStudentButton.Click += new System.EventHandler(this.searchStudentButton_Click);
            // 
            // registerButton
            // 
            this.registerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.registerButton.Location = new System.Drawing.Point(425, 434);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(315, 46);
            this.registerButton.TabIndex = 25;
            this.registerButton.Text = "Register Student For Course";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // studentNameTextBox
            // 
            this.studentNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.studentNameTextBox.Location = new System.Drawing.Point(756, 334);
            this.studentNameTextBox.Name = "studentNameTextBox";
            this.studentNameTextBox.ReadOnly = true;
            this.studentNameTextBox.Size = new System.Drawing.Size(235, 30);
            this.studentNameTextBox.TabIndex = 26;
            // 
            // studentBirthdayTextBox
            // 
            this.studentBirthdayTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.studentBirthdayTextBox.Location = new System.Drawing.Point(756, 371);
            this.studentBirthdayTextBox.Name = "studentBirthdayTextBox";
            this.studentBirthdayTextBox.ReadOnly = true;
            this.studentBirthdayTextBox.Size = new System.Drawing.Size(235, 30);
            this.studentBirthdayTextBox.TabIndex = 27;
            // 
            // findStudentErrorLabel
            // 
            this.findStudentErrorLabel.AutoSize = true;
            this.findStudentErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.findStudentErrorLabel.Location = new System.Drawing.Point(118, 378);
            this.findStudentErrorLabel.Name = "findStudentErrorLabel";
            this.findStudentErrorLabel.Size = new System.Drawing.Size(13, 16);
            this.findStudentErrorLabel.TabIndex = 28;
            this.findStudentErrorLabel.Text = "  ";
            // 
            // AdministratorRegisterStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.findStudentErrorLabel);
            this.Controls.Add(this.studentBirthdayTextBox);
            this.Controls.Add(this.studentNameTextBox);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(studentBirthdayLabel);
            this.Controls.Add(studentFullNameLabel);
            this.Controls.Add(this.searchStudentButton);
            this.Controls.Add(this.studentIDLabel);
            this.Controls.Add(this.studentIDTextBox);
            this.Controls.Add(this.courseYearPicker);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.semesterComboBox);
            this.Controls.Add(this.semesterLabel);
            this.Controls.Add(this.searchCourseButton);
            this.Controls.Add(this.courseDataGridView);
            this.Name = "AdministratorRegisterStudent";
            this.Size = new System.Drawing.Size(1267, 553);
            ((System.ComponentModel.ISupportInitialize)(this.courseDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource courseBindingSource;
        private System.Windows.Forms.DataGridView courseDataGridView;
        private System.Windows.Forms.Button searchCourseButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.ComboBox semesterComboBox;
        private System.Windows.Forms.Label semesterLabel;
        private System.Windows.Forms.DateTimePicker courseYearPicker;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.TextBox studentIDTextBox;
        private System.Windows.Forms.Label studentIDLabel;
        private System.Windows.Forms.Button searchStudentButton;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.TextBox studentNameTextBox;
        private System.Windows.Forms.TextBox studentBirthdayTextBox;
        private System.Windows.Forms.Label findStudentErrorLabel;
    }
}
