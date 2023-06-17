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
            System.Windows.Forms.Label fullNameLabel;
            System.Windows.Forms.Label dateOfBirthLabel;
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
            this.label7 = new System.Windows.Forms.Label();
            this.courseYearPicker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.studentIDTextBox = new System.Windows.Forms.TextBox();
            this.studentIDLabel = new System.Windows.Forms.Label();
            this.searchStudentButton = new System.Windows.Forms.Button();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fullNameLabel1 = new System.Windows.Forms.Label();
            this.dateOfBirthLabel1 = new System.Windows.Forms.Label();
            this.registerButton = new System.Windows.Forms.Button();
            fullNameLabel = new System.Windows.Forms.Label();
            dateOfBirthLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.courseDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // fullNameLabel
            // 
            fullNameLabel.AutoSize = true;
            fullNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            fullNameLabel.Location = new System.Drawing.Point(622, 337);
            fullNameLabel.Name = "fullNameLabel";
            fullNameLabel.Size = new System.Drawing.Size(100, 25);
            fullNameLabel.TabIndex = 22;
            fullNameLabel.Text = "Full Name";
            // 
            // dateOfBirthLabel
            // 
            dateOfBirthLabel.AutoSize = true;
            dateOfBirthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dateOfBirthLabel.Location = new System.Drawing.Point(622, 371);
            dateOfBirthLabel.Name = "dateOfBirthLabel";
            dateOfBirthLabel.Size = new System.Drawing.Size(83, 25);
            dateOfBirthLabel.TabIndex = 23;
            dateOfBirthLabel.Text = "Birthday";
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
            this.searchCourseButton.Location = new System.Drawing.Point(672, 31);
            this.searchCourseButton.Name = "searchCourseButton";
            this.searchCourseButton.Size = new System.Drawing.Size(177, 30);
            this.searchCourseButton.TabIndex = 2;
            this.searchCourseButton.Text = "Search Courses";
            this.searchCourseButton.UseVisualStyleBackColor = true;
            this.searchCourseButton.Click += new System.EventHandler(this.searchCourseButton_Click);
            // 
            // semesterComboBox
            // 
            this.semesterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.semesterComboBox.FormattingEnabled = true;
            this.semesterComboBox.Items.AddRange(new object[] {
            "Spring",
            "Summer",
            "Fall"});
            this.semesterComboBox.Location = new System.Drawing.Point(177, 35);
            this.semesterComboBox.Name = "semesterComboBox";
            this.semesterComboBox.Size = new System.Drawing.Size(193, 24);
            this.semesterComboBox.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(75, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "Semester";
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(420, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 25);
            this.label6.TabIndex = 18;
            this.label6.Text = "Year";
            // 
            // studentIDTextBox
            // 
            this.studentIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.studentIDTextBox.Location = new System.Drawing.Point(190, 334);
            this.studentIDTextBox.Name = "studentIDTextBox";
            this.studentIDTextBox.Size = new System.Drawing.Size(121, 30);
            this.studentIDTextBox.TabIndex = 20;
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
            this.searchStudentButton.Size = new System.Drawing.Size(177, 30);
            this.searchStudentButton.TabIndex = 22;
            this.searchStudentButton.Text = "Find Student";
            this.searchStudentButton.UseVisualStyleBackColor = true;
            this.searchStudentButton.Click += new System.EventHandler(this.searchStudentButton_Click);
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataSource = typeof(Gradebook.Model.Student);
            // 
            // fullNameLabel1
            // 
            this.fullNameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "FullName", true));
            this.fullNameLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.fullNameLabel1.Location = new System.Drawing.Point(766, 337);
            this.fullNameLabel1.Name = "fullNameLabel1";
            this.fullNameLabel1.Size = new System.Drawing.Size(100, 23);
            this.fullNameLabel1.TabIndex = 23;
            this.fullNameLabel1.Text = "label1";
            // 
            // dateOfBirthLabel1
            // 
            this.dateOfBirthLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "DateOfBirth", true));
            this.dateOfBirthLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dateOfBirthLabel1.Location = new System.Drawing.Point(766, 371);
            this.dateOfBirthLabel1.Name = "dateOfBirthLabel1";
            this.dateOfBirthLabel1.Size = new System.Drawing.Size(100, 23);
            this.dateOfBirthLabel1.TabIndex = 24;
            this.dateOfBirthLabel1.Text = "label1";
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
            // AdministratorRegisterStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.registerButton);
            this.Controls.Add(dateOfBirthLabel);
            this.Controls.Add(this.dateOfBirthLabel1);
            this.Controls.Add(fullNameLabel);
            this.Controls.Add(this.fullNameLabel1);
            this.Controls.Add(this.searchStudentButton);
            this.Controls.Add(this.studentIDLabel);
            this.Controls.Add(this.studentIDTextBox);
            this.Controls.Add(this.courseYearPicker);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.semesterComboBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.searchCourseButton);
            this.Controls.Add(this.courseDataGridView);
            this.Name = "AdministratorRegisterStudent";
            this.Size = new System.Drawing.Size(1267, 553);
            ((System.ComponentModel.ISupportInitialize)(this.courseDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker courseYearPicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox studentIDTextBox;
        private System.Windows.Forms.Label studentIDLabel;
        private System.Windows.Forms.Button searchStudentButton;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private System.Windows.Forms.Label fullNameLabel1;
        private System.Windows.Forms.Label dateOfBirthLabel1;
        private System.Windows.Forms.Button registerButton;
    }
}
