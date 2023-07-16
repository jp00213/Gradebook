namespace Gradebook.UserControls
{
    partial class SearchStudentUserControl
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.currentStudentIDSetLabel = new System.Windows.Forms.Label();
            this.currentStudentIDLabel = new System.Windows.Forms.Label();
            this.searchOptionGroup = new System.Windows.Forms.GroupBox();
            this.searchDobPicker = new System.Windows.Forms.RadioButton();
            this.searchNameRadioButton = new System.Windows.Forms.RadioButton();
            this.searchUsernameRadioButton = new System.Windows.Forms.RadioButton();
            this.searchStudentIDRadioButton = new System.Windows.Forms.RadioButton();
            this.ErrorMessageLabel = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.dob_Datepicker = new System.Windows.Forms.DateTimePicker();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.studentIDTextBox = new System.Windows.Forms.TextBox();
            this.dobTimePicker = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.studentIDLabel = new System.Windows.Forms.Label();
            this.searchTitleLabel = new System.Windows.Forms.Label();
            this.studentDataGridView = new System.Windows.Forms.DataGridView();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.searchOptionGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.studentDataGridView);
            this.panel1.Controls.Add(this.currentStudentIDSetLabel);
            this.panel1.Controls.Add(this.currentStudentIDLabel);
            this.panel1.Controls.Add(this.searchOptionGroup);
            this.panel1.Controls.Add(this.ErrorMessageLabel);
            this.panel1.Controls.Add(this.clearButton);
            this.panel1.Controls.Add(this.searchButton);
            this.panel1.Controls.Add(this.dob_Datepicker);
            this.panel1.Controls.Add(this.lastNameTextBox);
            this.panel1.Controls.Add(this.firstNameTextBox);
            this.panel1.Controls.Add(this.usernameTextBox);
            this.panel1.Controls.Add(this.studentIDTextBox);
            this.panel1.Controls.Add(this.dobTimePicker);
            this.panel1.Controls.Add(this.lastNameLabel);
            this.panel1.Controls.Add(this.firstNameLabel);
            this.panel1.Controls.Add(this.usernameLabel);
            this.panel1.Controls.Add(this.studentIDLabel);
            this.panel1.Controls.Add(this.searchTitleLabel);
            this.panel1.Location = new System.Drawing.Point(40, 17);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1179, 632);
            this.panel1.TabIndex = 0;
            // 
            // currentStudentIDSetLabel
            // 
            this.currentStudentIDSetLabel.AutoSize = true;
            this.currentStudentIDSetLabel.Location = new System.Drawing.Point(705, 46);
            this.currentStudentIDSetLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.currentStudentIDSetLabel.Name = "currentStudentIDSetLabel";
            this.currentStudentIDSetLabel.Size = new System.Drawing.Size(10, 16);
            this.currentStudentIDSetLabel.TabIndex = 18;
            this.currentStudentIDSetLabel.Text = ":";
            // 
            // currentStudentIDLabel
            // 
            this.currentStudentIDLabel.AutoSize = true;
            this.currentStudentIDLabel.Location = new System.Drawing.Point(567, 46);
            this.currentStudentIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.currentStudentIDLabel.Name = "currentStudentIDLabel";
            this.currentStudentIDLabel.Size = new System.Drawing.Size(113, 16);
            this.currentStudentIDLabel.TabIndex = 17;
            this.currentStudentIDLabel.Text = "Current Student ID";
            // 
            // searchOptionGroup
            // 
            this.searchOptionGroup.Controls.Add(this.searchDobPicker);
            this.searchOptionGroup.Controls.Add(this.searchNameRadioButton);
            this.searchOptionGroup.Controls.Add(this.searchUsernameRadioButton);
            this.searchOptionGroup.Controls.Add(this.searchStudentIDRadioButton);
            this.searchOptionGroup.Location = new System.Drawing.Point(33, 46);
            this.searchOptionGroup.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchOptionGroup.Name = "searchOptionGroup";
            this.searchOptionGroup.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchOptionGroup.Size = new System.Drawing.Size(525, 50);
            this.searchOptionGroup.TabIndex = 16;
            this.searchOptionGroup.TabStop = false;
            this.searchOptionGroup.Text = "Search By:";
            // 
            // searchDobPicker
            // 
            this.searchDobPicker.AutoSize = true;
            this.searchDobPicker.Location = new System.Drawing.Point(416, 18);
            this.searchDobPicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchDobPicker.Name = "searchDobPicker";
            this.searchDobPicker.Size = new System.Drawing.Size(57, 20);
            this.searchDobPicker.TabIndex = 6;
            this.searchDobPicker.TabStop = true;
            this.searchDobPicker.Text = "DOB";
            this.searchDobPicker.UseVisualStyleBackColor = true;
            this.searchDobPicker.CheckedChanged += new System.EventHandler(this.ChangeSearchBox);
            // 
            // searchNameRadioButton
            // 
            this.searchNameRadioButton.AutoSize = true;
            this.searchNameRadioButton.Location = new System.Drawing.Point(312, 18);
            this.searchNameRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchNameRadioButton.Name = "searchNameRadioButton";
            this.searchNameRadioButton.Size = new System.Drawing.Size(65, 20);
            this.searchNameRadioButton.TabIndex = 5;
            this.searchNameRadioButton.TabStop = true;
            this.searchNameRadioButton.Text = "Name";
            this.searchNameRadioButton.UseVisualStyleBackColor = true;
            this.searchNameRadioButton.CheckedChanged += new System.EventHandler(this.ChangeSearchBox);
            // 
            // searchUsernameRadioButton
            // 
            this.searchUsernameRadioButton.AutoSize = true;
            this.searchUsernameRadioButton.Location = new System.Drawing.Point(177, 18);
            this.searchUsernameRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchUsernameRadioButton.Name = "searchUsernameRadioButton";
            this.searchUsernameRadioButton.Size = new System.Drawing.Size(91, 20);
            this.searchUsernameRadioButton.TabIndex = 4;
            this.searchUsernameRadioButton.TabStop = true;
            this.searchUsernameRadioButton.Text = "Username";
            this.searchUsernameRadioButton.UseVisualStyleBackColor = true;
            this.searchUsernameRadioButton.CheckedChanged += new System.EventHandler(this.ChangeSearchBox);
            // 
            // searchStudentIDRadioButton
            // 
            this.searchStudentIDRadioButton.AutoSize = true;
            this.searchStudentIDRadioButton.Location = new System.Drawing.Point(37, 18);
            this.searchStudentIDRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchStudentIDRadioButton.Name = "searchStudentIDRadioButton";
            this.searchStudentIDRadioButton.Size = new System.Drawing.Size(96, 20);
            this.searchStudentIDRadioButton.TabIndex = 3;
            this.searchStudentIDRadioButton.TabStop = true;
            this.searchStudentIDRadioButton.Text = "Student ID#";
            this.searchStudentIDRadioButton.UseVisualStyleBackColor = true;
            this.searchStudentIDRadioButton.CheckedChanged += new System.EventHandler(this.ChangeSearchBox);
            // 
            // ErrorMessageLabel
            // 
            this.ErrorMessageLabel.AutoSize = true;
            this.ErrorMessageLabel.Location = new System.Drawing.Point(567, 11);
            this.ErrorMessageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ErrorMessageLabel.Name = "ErrorMessageLabel";
            this.ErrorMessageLabel.Size = new System.Drawing.Size(15, 16);
            this.ErrorMessageLabel.TabIndex = 15;
            this.ErrorMessageLabel.Text = "--";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(1023, 116);
            this.clearButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(100, 28);
            this.clearButton.TabIndex = 13;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(901, 116);
            this.searchButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(100, 28);
            this.searchButton.TabIndex = 12;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // dob_Datepicker
            // 
            this.dob_Datepicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dob_Datepicker.Location = new System.Drawing.Point(737, 119);
            this.dob_Datepicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dob_Datepicker.Name = "dob_Datepicker";
            this.dob_Datepicker.Size = new System.Drawing.Size(141, 22);
            this.dob_Datepicker.TabIndex = 11;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(540, 119);
            this.lastNameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(188, 22);
            this.lastNameTextBox.TabIndex = 10;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(316, 119);
            this.firstNameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(215, 22);
            this.firstNameTextBox.TabIndex = 9;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(175, 119);
            this.usernameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(132, 22);
            this.usernameTextBox.TabIndex = 8;
            // 
            // studentIDTextBox
            // 
            this.studentIDTextBox.Location = new System.Drawing.Point(33, 119);
            this.studentIDTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.studentIDTextBox.Name = "studentIDTextBox";
            this.studentIDTextBox.Size = new System.Drawing.Size(132, 22);
            this.studentIDTextBox.TabIndex = 7;
            // 
            // dobTimePicker
            // 
            this.dobTimePicker.AutoSize = true;
            this.dobTimePicker.Location = new System.Drawing.Point(733, 100);
            this.dobTimePicker.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dobTimePicker.Name = "dobTimePicker";
            this.dobTimePicker.Size = new System.Drawing.Size(36, 16);
            this.dobTimePicker.TabIndex = 7;
            this.dobTimePicker.Text = "DOB";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(536, 100);
            this.lastNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(72, 16);
            this.lastNameLabel.TabIndex = 6;
            this.lastNameLabel.Text = "Last Name";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(312, 100);
            this.firstNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(72, 16);
            this.firstNameLabel.TabIndex = 5;
            this.firstNameLabel.Text = "First Name";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(171, 100);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(70, 16);
            this.usernameLabel.TabIndex = 4;
            this.usernameLabel.Text = "Username";
            // 
            // studentIDLabel
            // 
            this.studentIDLabel.AutoSize = true;
            this.studentIDLabel.Location = new System.Drawing.Point(29, 100);
            this.studentIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.studentIDLabel.Name = "studentIDLabel";
            this.studentIDLabel.Size = new System.Drawing.Size(68, 16);
            this.studentIDLabel.TabIndex = 3;
            this.studentIDLabel.Text = "Student ID";
            // 
            // searchTitleLabel
            // 
            this.searchTitleLabel.AutoSize = true;
            this.searchTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTitleLabel.Location = new System.Drawing.Point(19, 5);
            this.searchTitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.searchTitleLabel.Name = "searchTitleLabel";
            this.searchTitleLabel.Size = new System.Drawing.Size(247, 25);
            this.searchTitleLabel.TabIndex = 0;
            this.searchTitleLabel.Text = "Search and Edit Student";
            // 
            // studentDataGridView
            // 
            this.studentDataGridView.AllowUserToAddRows = false;
            this.studentDataGridView.AllowUserToDeleteRows = false;
            this.studentDataGridView.AutoGenerateColumns = false;
            this.studentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn13});
            this.studentDataGridView.DataSource = this.studentBindingSource;
            this.studentDataGridView.Location = new System.Drawing.Point(17, 161);
            this.studentDataGridView.MultiSelect = false;
            this.studentDataGridView.Name = "studentDataGridView";
            this.studentDataGridView.ReadOnly = true;
            this.studentDataGridView.RowHeadersWidth = 51;
            this.studentDataGridView.RowTemplate.Height = 24;
            this.studentDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.studentDataGridView.Size = new System.Drawing.Size(1135, 220);
            this.studentDataGridView.TabIndex = 18;
            this.studentDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentDataGridView_CellContentClick);
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataSource = typeof(Gradebook.Model.Student);
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn16.DataPropertyName = "StudentID";
            this.dataGridViewTextBoxColumn16.HeaderText = "StudentID";
            this.dataGridViewTextBoxColumn16.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            this.dataGridViewTextBoxColumn16.Width = 94;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "RecordId";
            this.dataGridViewTextBoxColumn1.HeaderText = "RecordId";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 92;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn15.DataPropertyName = "Username";
            this.dataGridViewTextBoxColumn15.HeaderText = "Username";
            this.dataGridViewTextBoxColumn15.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            this.dataGridViewTextBoxColumn15.Width = 99;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "FirstName";
            this.dataGridViewTextBoxColumn3.HeaderText = "FirstName";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 98;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "LastName";
            this.dataGridViewTextBoxColumn2.HeaderText = "LastName";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 98;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DateOfBirth";
            this.dataGridViewTextBoxColumn4.HeaderText = "DateOfBirth";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 104;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Phone";
            this.dataGridViewTextBoxColumn9.HeaderText = "Phone";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 75;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn13.DataPropertyName = "SSN";
            this.dataGridViewTextBoxColumn13.HeaderText = "SSN";
            this.dataGridViewTextBoxColumn13.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Width = 64;
            // 
            // SearchStudentUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SearchStudentUserControl";
            this.Size = new System.Drawing.Size(1280, 788);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.searchOptionGroup.ResumeLayout(false);
            this.searchOptionGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label searchTitleLabel;
        private System.Windows.Forms.Label dobTimePicker;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label studentIDLabel;
        private System.Windows.Forms.TextBox studentIDTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.DateTimePicker dob_Datepicker;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label ErrorMessageLabel;
        private System.Windows.Forms.GroupBox searchOptionGroup;
        private System.Windows.Forms.Label currentStudentIDLabel;
        private System.Windows.Forms.RadioButton searchStudentIDRadioButton;
        private System.Windows.Forms.RadioButton searchDobPicker;
        private System.Windows.Forms.RadioButton searchNameRadioButton;
        private System.Windows.Forms.RadioButton searchUsernameRadioButton;
        private System.Windows.Forms.Label currentStudentIDSetLabel;
        private System.Windows.Forms.DataGridView studentDataGridView;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
    }
}
