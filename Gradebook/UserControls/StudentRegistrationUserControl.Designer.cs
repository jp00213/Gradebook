namespace Gradebook.UserControls
{
    partial class StudentRegistrationUserControl
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
            this.courseYearPicker = new System.Windows.Forms.DateTimePicker();
            this.yearLabel = new System.Windows.Forms.Label();
            this.semesterComboBox = new System.Windows.Forms.ComboBox();
            this.semesterLabel = new System.Windows.Forms.Label();
            this.searchCourseButton = new System.Windows.Forms.Button();
            this.courseDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.registerButton = new System.Windows.Forms.Button();
            this.registeredGridView = new System.Windows.Forms.DataGridView();
            this.TeacherContact = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentRegistrationsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.courseDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registeredGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // courseYearPicker
            // 
            this.courseYearPicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.courseYearPicker.CustomFormat = "yyyy";
            this.courseYearPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.courseYearPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.courseYearPicker.Location = new System.Drawing.Point(384, 16);
            this.courseYearPicker.Name = "courseYearPicker";
            this.courseYearPicker.ShowUpDown = true;
            this.courseYearPicker.Size = new System.Drawing.Size(115, 30);
            this.courseYearPicker.TabIndex = 26;
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.yearLabel.Location = new System.Drawing.Point(325, 16);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(53, 25);
            this.yearLabel.TabIndex = 27;
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
            this.semesterComboBox.Location = new System.Drawing.Point(110, 16);
            this.semesterComboBox.Name = "semesterComboBox";
            this.semesterComboBox.Size = new System.Drawing.Size(193, 33);
            this.semesterComboBox.TabIndex = 25;
            // 
            // semesterLabel
            // 
            this.semesterLabel.AutoSize = true;
            this.semesterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.semesterLabel.Location = new System.Drawing.Point(8, 16);
            this.semesterLabel.Name = "semesterLabel";
            this.semesterLabel.Size = new System.Drawing.Size(96, 25);
            this.semesterLabel.TabIndex = 24;
            this.semesterLabel.Text = "Semester";
            // 
            // searchCourseButton
            // 
            this.searchCourseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.searchCourseButton.Location = new System.Drawing.Point(550, 16);
            this.searchCourseButton.Name = "searchCourseButton";
            this.searchCourseButton.Size = new System.Drawing.Size(179, 43);
            this.searchCourseButton.TabIndex = 28;
            this.searchCourseButton.Text = "Search Courses";
            this.searchCourseButton.UseVisualStyleBackColor = true;
            this.searchCourseButton.Click += new System.EventHandler(this.searchCourseButton_Click);
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
            this.courseDataGridView.Location = new System.Drawing.Point(21, 65);
            this.courseDataGridView.MultiSelect = false;
            this.courseDataGridView.Name = "courseDataGridView";
            this.courseDataGridView.ReadOnly = true;
            this.courseDataGridView.RowHeadersWidth = 51;
            this.courseDataGridView.RowTemplate.Height = 24;
            this.courseDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.courseDataGridView.Size = new System.Drawing.Size(927, 226);
            this.courseDataGridView.TabIndex = 29;
            this.courseDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.courseDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CourseID";
            this.dataGridViewTextBoxColumn1.HeaderText = "CourseID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 92;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 73;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Prefix";
            this.dataGridViewTextBoxColumn3.HeaderText = "Prefix";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 69;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Number";
            this.dataGridViewTextBoxColumn4.HeaderText = "Number";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 84;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Section";
            this.dataGridViewTextBoxColumn5.HeaderText = "Section";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 81;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "CreditHours";
            this.dataGridViewTextBoxColumn6.HeaderText = "CreditHours";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 107;
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataSource = typeof(Gradebook.Model.Course);
            // 
            // registerButton
            // 
            this.registerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.registerButton.Location = new System.Drawing.Point(735, 16);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(216, 43);
            this.registerButton.TabIndex = 30;
            this.registerButton.Text = "Register For Course";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // registeredGridView
            // 
            this.registeredGridView.AllowUserToAddRows = false;
            this.registeredGridView.AllowUserToDeleteRows = false;
            this.registeredGridView.AutoGenerateColumns = false;
            this.registeredGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.registeredGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TeacherContact,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.registeredGridView.DataSource = this.courseBindingSource;
            this.registeredGridView.Location = new System.Drawing.Point(21, 362);
            this.registeredGridView.MultiSelect = false;
            this.registeredGridView.Name = "registeredGridView";
            this.registeredGridView.ReadOnly = true;
            this.registeredGridView.RowHeadersWidth = 51;
            this.registeredGridView.RowTemplate.Height = 24;
            this.registeredGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.registeredGridView.Size = new System.Drawing.Size(927, 226);
            this.registeredGridView.TabIndex = 31;
            this.registeredGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.registeredGridView_CellContentClick);
            // 
            // TeacherContact
            // 
            this.TeacherContact.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TeacherContact.HeaderText = "Teacher Contact";
            this.TeacherContact.MinimumWidth = 6;
            this.TeacherContact.Name = "TeacherContact";
            this.TeacherContact.ReadOnly = true;
            this.TeacherContact.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TeacherContact.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.TeacherContact.Text = "Info";
            this.TeacherContact.UseColumnTextForButtonValue = true;
            this.TeacherContact.Width = 124;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "CourseID";
            this.dataGridViewTextBoxColumn7.HeaderText = "CourseID";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 92;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn8.HeaderText = "Name";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 73;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Prefix";
            this.dataGridViewTextBoxColumn9.HeaderText = "Prefix";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 69;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Number";
            this.dataGridViewTextBoxColumn10.HeaderText = "Number";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 84;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Section";
            this.dataGridViewTextBoxColumn11.HeaderText = "Section";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Width = 81;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn12.DataPropertyName = "CreditHours";
            this.dataGridViewTextBoxColumn12.HeaderText = "CreditHours";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Width = 107;
            // 
            // currentRegistrationsLabel
            // 
            this.currentRegistrationsLabel.AutoSize = true;
            this.currentRegistrationsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.currentRegistrationsLabel.Location = new System.Drawing.Point(27, 334);
            this.currentRegistrationsLabel.Name = "currentRegistrationsLabel";
            this.currentRegistrationsLabel.Size = new System.Drawing.Size(346, 25);
            this.currentRegistrationsLabel.TabIndex = 32;
            this.currentRegistrationsLabel.Text = "You\'re Registered For These Courses:";
            // 
            // StudentRegistrationUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.currentRegistrationsLabel);
            this.Controls.Add(this.registeredGridView);
            this.Controls.Add(this.courseYearPicker);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.semesterComboBox);
            this.Controls.Add(this.semesterLabel);
            this.Controls.Add(this.searchCourseButton);
            this.Controls.Add(this.courseDataGridView);
            this.Controls.Add(this.registerButton);
            this.Name = "StudentRegistrationUserControl";
            this.Size = new System.Drawing.Size(1056, 655);
            ((System.ComponentModel.ISupportInitialize)(this.courseDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registeredGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker courseYearPicker;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.ComboBox semesterComboBox;
        private System.Windows.Forms.Label semesterLabel;
        private System.Windows.Forms.Button searchCourseButton;
        private System.Windows.Forms.DataGridView courseDataGridView;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.DataGridView registeredGridView;
        private System.Windows.Forms.Label currentRegistrationsLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewButtonColumn TeacherContact;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
    }
}
