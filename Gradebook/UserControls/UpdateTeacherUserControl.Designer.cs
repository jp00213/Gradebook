namespace Gradebook.UserControls
{
    partial class UpdateTeacherUserControl
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
            this.clearButton = new System.Windows.Forms.Button();
            this.resultsDOBDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dobLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.zipTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.resultsLastNameTextBox = new System.Windows.Forms.TextBox();
            this.resultsFirstNameTextbox = new System.Windows.Forms.TextBox();
            this.teacherIDtextBox = new System.Windows.Forms.TextBox();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.zipLabel = new System.Windows.Forms.Label();
            this.stateLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.sexLabel = new System.Windows.Forms.Label();
            this.resultsDOBLabel = new System.Windows.Forms.Label();
            this.resultsLastNameLabel = new System.Windows.Forms.Label();
            this.resultsFirstNameLabel = new System.Windows.Forms.Label();
            this.teacherIDLabel = new System.Windows.Forms.Label();
            this.teacherSearchDataGridView = new System.Windows.Forms.DataGridView();
            this.teacherIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recordIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressStreetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sSNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchButton = new System.Windows.Forms.Button();
            this.dobDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lastNameTextbox = new System.Windows.Forms.TextBox();
            this.firstNameTextbox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.stateComboBox = new System.Windows.Forms.ComboBox();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.sexComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.teacherSearchDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(275, 582);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(137, 32);
            this.clearButton.TabIndex = 62;
            this.clearButton.Text = "Clear Edits";
            this.clearButton.UseVisualStyleBackColor = true;
            // 
            // resultsDOBDateTimePicker
            // 
            this.resultsDOBDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teacherBindingSource, "DateOfBirth", true));
            this.resultsDOBDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.resultsDOBDateTimePicker.Location = new System.Drawing.Point(235, 451);
            this.resultsDOBDateTimePicker.Name = "resultsDOBDateTimePicker";
            this.resultsDOBDateTimePicker.Size = new System.Drawing.Size(233, 20);
            this.resultsDOBDateTimePicker.TabIndex = 61;
            // 
            // dobLabel
            // 
            this.dobLabel.AutoSize = true;
            this.dobLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobLabel.Location = new System.Drawing.Point(524, 47);
            this.dobLabel.Name = "dobLabel";
            this.dobLabel.Size = new System.Drawing.Size(44, 18);
            this.dobLabel.TabIndex = 60;
            this.dobLabel.Text = "DOB";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLabel.Location = new System.Drawing.Point(304, 47);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(89, 18);
            this.lastNameLabel.TabIndex = 59;
            this.lastNameLabel.Text = "Last Name";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLabel.Location = new System.Drawing.Point(81, 47);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(91, 18);
            this.firstNameLabel.TabIndex = 58;
            this.firstNameLabel.Text = "First Name";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teacherBindingSource, "Phone", true));
            this.phoneTextBox.Location = new System.Drawing.Point(589, 493);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(233, 20);
            this.phoneTextBox.TabIndex = 57;
            // 
            // zipTextBox
            // 
            this.zipTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teacherBindingSource, "Zip", true));
            this.zipTextBox.Location = new System.Drawing.Point(589, 451);
            this.zipTextBox.Name = "zipTextBox";
            this.zipTextBox.Size = new System.Drawing.Size(233, 20);
            this.zipTextBox.TabIndex = 56;
            // 
            // cityTextBox
            // 
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teacherBindingSource, "City", true));
            this.cityTextBox.Location = new System.Drawing.Point(588, 365);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(234, 20);
            this.cityTextBox.TabIndex = 54;
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teacherBindingSource, "AddressStreet", true));
            this.addressTextBox.Location = new System.Drawing.Point(589, 325);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(233, 20);
            this.addressTextBox.TabIndex = 53;
            // 
            // resultsLastNameTextBox
            // 
            this.resultsLastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teacherBindingSource, "LastName", true));
            this.resultsLastNameTextBox.Location = new System.Drawing.Point(235, 409);
            this.resultsLastNameTextBox.Name = "resultsLastNameTextBox";
            this.resultsLastNameTextBox.Size = new System.Drawing.Size(233, 20);
            this.resultsLastNameTextBox.TabIndex = 50;
            // 
            // resultsFirstNameTextbox
            // 
            this.resultsFirstNameTextbox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teacherBindingSource, "FirstName", true));
            this.resultsFirstNameTextbox.Location = new System.Drawing.Point(235, 364);
            this.resultsFirstNameTextbox.Name = "resultsFirstNameTextbox";
            this.resultsFirstNameTextbox.Size = new System.Drawing.Size(233, 20);
            this.resultsFirstNameTextbox.TabIndex = 49;
            // 
            // teacherIDtextBox
            // 
            this.teacherIDtextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teacherBindingSource, "TeacherID", true));
            this.teacherIDtextBox.Location = new System.Drawing.Point(235, 324);
            this.teacherIDtextBox.Name = "teacherIDtextBox";
            this.teacherIDtextBox.ReadOnly = true;
            this.teacherIDtextBox.Size = new System.Drawing.Size(233, 20);
            this.teacherIDtextBox.TabIndex = 48;
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneLabel.Location = new System.Drawing.Point(531, 493);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(46, 16);
            this.phoneLabel.TabIndex = 47;
            this.phoneLabel.Text = "Phone";
            // 
            // zipLabel
            // 
            this.zipLabel.AutoSize = true;
            this.zipLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zipLabel.Location = new System.Drawing.Point(514, 451);
            this.zipLabel.Name = "zipLabel";
            this.zipLabel.Size = new System.Drawing.Size(62, 16);
            this.zipLabel.TabIndex = 46;
            this.zipLabel.Text = "Zip Code";
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stateLabel.Location = new System.Drawing.Point(538, 413);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(38, 16);
            this.stateLabel.TabIndex = 45;
            this.stateLabel.Text = "State";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityLabel.Location = new System.Drawing.Point(547, 365);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(29, 16);
            this.cityLabel.TabIndex = 44;
            this.cityLabel.Text = "City";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLabel.Location = new System.Drawing.Point(524, 325);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(58, 16);
            this.addressLabel.TabIndex = 43;
            this.addressLabel.Text = "Address";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.Location = new System.Drawing.Point(181, 538);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(44, 16);
            this.statusLabel.TabIndex = 42;
            this.statusLabel.Text = "Status";
            // 
            // sexLabel
            // 
            this.sexLabel.AutoSize = true;
            this.sexLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sexLabel.Location = new System.Drawing.Point(195, 497);
            this.sexLabel.Name = "sexLabel";
            this.sexLabel.Size = new System.Drawing.Size(30, 16);
            this.sexLabel.TabIndex = 41;
            this.sexLabel.Text = "Sex";
            // 
            // resultsDOBLabel
            // 
            this.resultsDOBLabel.AutoSize = true;
            this.resultsDOBLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultsDOBLabel.Location = new System.Drawing.Point(144, 455);
            this.resultsDOBLabel.Name = "resultsDOBLabel";
            this.resultsDOBLabel.Size = new System.Drawing.Size(81, 16);
            this.resultsDOBLabel.TabIndex = 40;
            this.resultsDOBLabel.Text = "Date Of Birth";
            // 
            // resultsLastNameLabel
            // 
            this.resultsLastNameLabel.AutoSize = true;
            this.resultsLastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultsLastNameLabel.Location = new System.Drawing.Point(157, 413);
            this.resultsLastNameLabel.Name = "resultsLastNameLabel";
            this.resultsLastNameLabel.Size = new System.Drawing.Size(72, 16);
            this.resultsLastNameLabel.TabIndex = 39;
            this.resultsLastNameLabel.Text = "Last Name";
            // 
            // resultsFirstNameLabel
            // 
            this.resultsFirstNameLabel.AutoSize = true;
            this.resultsFirstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultsFirstNameLabel.Location = new System.Drawing.Point(157, 364);
            this.resultsFirstNameLabel.Name = "resultsFirstNameLabel";
            this.resultsFirstNameLabel.Size = new System.Drawing.Size(72, 16);
            this.resultsFirstNameLabel.TabIndex = 38;
            this.resultsFirstNameLabel.Text = "First Name";
            // 
            // teacherIDLabel
            // 
            this.teacherIDLabel.AutoSize = true;
            this.teacherIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherIDLabel.Location = new System.Drawing.Point(157, 324);
            this.teacherIDLabel.Name = "teacherIDLabel";
            this.teacherIDLabel.Size = new System.Drawing.Size(74, 16);
            this.teacherIDLabel.TabIndex = 37;
            this.teacherIDLabel.Text = "Teacher ID";
            // 
            // teacherSearchDataGridView
            // 
            this.teacherSearchDataGridView.AutoGenerateColumns = false;
            this.teacherSearchDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teacherSearchDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.teacherIDDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.recordIdDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.dateOfBirthDataGridViewTextBoxColumn,
            this.addressStreetDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.stateDataGridViewTextBoxColumn,
            this.zipDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn,
            this.sexDataGridViewTextBoxColumn,
            this.sSNDataGridViewTextBoxColumn});
            this.teacherSearchDataGridView.DataSource = this.teacherBindingSource;
            this.teacherSearchDataGridView.Location = new System.Drawing.Point(160, 111);
            this.teacherSearchDataGridView.Name = "teacherSearchDataGridView";
            this.teacherSearchDataGridView.Size = new System.Drawing.Size(662, 177);
            this.teacherSearchDataGridView.TabIndex = 36;
            // 
            // teacherIDDataGridViewTextBoxColumn
            // 
            this.teacherIDDataGridViewTextBoxColumn.DataPropertyName = "TeacherID";
            this.teacherIDDataGridViewTextBoxColumn.HeaderText = "TeacherID";
            this.teacherIDDataGridViewTextBoxColumn.Name = "teacherIDDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // recordIdDataGridViewTextBoxColumn
            // 
            this.recordIdDataGridViewTextBoxColumn.DataPropertyName = "RecordId";
            this.recordIdDataGridViewTextBoxColumn.HeaderText = "RecordId";
            this.recordIdDataGridViewTextBoxColumn.Name = "recordIdDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // dateOfBirthDataGridViewTextBoxColumn
            // 
            this.dateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "DateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn.HeaderText = "DateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn.Name = "dateOfBirthDataGridViewTextBoxColumn";
            // 
            // addressStreetDataGridViewTextBoxColumn
            // 
            this.addressStreetDataGridViewTextBoxColumn.DataPropertyName = "AddressStreet";
            this.addressStreetDataGridViewTextBoxColumn.HeaderText = "AddressStreet";
            this.addressStreetDataGridViewTextBoxColumn.Name = "addressStreetDataGridViewTextBoxColumn";
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            // 
            // stateDataGridViewTextBoxColumn
            // 
            this.stateDataGridViewTextBoxColumn.DataPropertyName = "State";
            this.stateDataGridViewTextBoxColumn.HeaderText = "State";
            this.stateDataGridViewTextBoxColumn.Name = "stateDataGridViewTextBoxColumn";
            // 
            // zipDataGridViewTextBoxColumn
            // 
            this.zipDataGridViewTextBoxColumn.DataPropertyName = "Zip";
            this.zipDataGridViewTextBoxColumn.HeaderText = "Zip";
            this.zipDataGridViewTextBoxColumn.Name = "zipDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "FullName";
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            this.fullNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sexDataGridViewTextBoxColumn
            // 
            this.sexDataGridViewTextBoxColumn.DataPropertyName = "Sex";
            this.sexDataGridViewTextBoxColumn.HeaderText = "Sex";
            this.sexDataGridViewTextBoxColumn.Name = "sexDataGridViewTextBoxColumn";
            // 
            // sSNDataGridViewTextBoxColumn
            // 
            this.sSNDataGridViewTextBoxColumn.DataPropertyName = "SSN";
            this.sSNDataGridViewTextBoxColumn.HeaderText = "SSN";
            this.sSNDataGridViewTextBoxColumn.Name = "sSNDataGridViewTextBoxColumn";
            // 
            // teacherBindingSource
            // 
            this.teacherBindingSource.DataSource = typeof(Gradebook.Model.Teacher);
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(751, 61);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(104, 27);
            this.searchButton.TabIndex = 35;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // dobDateTimePicker
            // 
            this.dobDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dobDateTimePicker.Location = new System.Drawing.Point(527, 68);
            this.dobDateTimePicker.Name = "dobDateTimePicker";
            this.dobDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dobDateTimePicker.TabIndex = 34;
            // 
            // lastNameTextbox
            // 
            this.lastNameTextbox.Location = new System.Drawing.Point(307, 68);
            this.lastNameTextbox.Name = "lastNameTextbox";
            this.lastNameTextbox.Size = new System.Drawing.Size(200, 20);
            this.lastNameTextbox.TabIndex = 33;
            // 
            // firstNameTextbox
            // 
            this.firstNameTextbox.Location = new System.Drawing.Point(84, 68);
            this.firstNameTextbox.Name = "firstNameTextbox";
            this.firstNameTextbox.Size = new System.Drawing.Size(200, 20);
            this.firstNameTextbox.TabIndex = 32;
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(527, 582);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(137, 32);
            this.saveButton.TabIndex = 66;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // stateComboBox
            // 
            this.stateComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teacherBindingSource, "State", true));
            this.stateComboBox.FormattingEnabled = true;
            this.stateComboBox.Location = new System.Drawing.Point(589, 409);
            this.stateComboBox.Name = "stateComboBox";
            this.stateComboBox.Size = new System.Drawing.Size(233, 21);
            this.stateComboBox.TabIndex = 65;
            // 
            // statusComboBox
            // 
            this.statusComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teacherBindingSource, "Status", true));
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Location = new System.Drawing.Point(235, 538);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(233, 21);
            this.statusComboBox.TabIndex = 64;
            // 
            // sexComboBox
            // 
            this.sexComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teacherBindingSource, "Sex", true));
            this.sexComboBox.FormattingEnabled = true;
            this.sexComboBox.Location = new System.Drawing.Point(235, 497);
            this.sexComboBox.Name = "sexComboBox";
            this.sexComboBox.Size = new System.Drawing.Size(233, 21);
            this.sexComboBox.TabIndex = 63;
            // 
            // UpdateTeacherUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.stateComboBox);
            this.Controls.Add(this.statusComboBox);
            this.Controls.Add(this.sexComboBox);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.resultsDOBDateTimePicker);
            this.Controls.Add(this.dobLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.zipTextBox);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.resultsLastNameTextBox);
            this.Controls.Add(this.resultsFirstNameTextbox);
            this.Controls.Add(this.teacherIDtextBox);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.zipLabel);
            this.Controls.Add(this.stateLabel);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.sexLabel);
            this.Controls.Add(this.resultsDOBLabel);
            this.Controls.Add(this.resultsLastNameLabel);
            this.Controls.Add(this.resultsFirstNameLabel);
            this.Controls.Add(this.teacherIDLabel);
            this.Controls.Add(this.teacherSearchDataGridView);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.dobDateTimePicker);
            this.Controls.Add(this.lastNameTextbox);
            this.Controls.Add(this.firstNameTextbox);
            this.Name = "UpdateTeacherUserControl";
            this.Size = new System.Drawing.Size(947, 634);
            ((System.ComponentModel.ISupportInitialize)(this.teacherSearchDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.DateTimePicker resultsDOBDateTimePicker;
        private System.Windows.Forms.Label dobLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox zipTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox resultsLastNameTextBox;
        private System.Windows.Forms.TextBox resultsFirstNameTextbox;
        private System.Windows.Forms.TextBox teacherIDtextBox;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label zipLabel;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label sexLabel;
        private System.Windows.Forms.Label resultsDOBLabel;
        private System.Windows.Forms.Label resultsLastNameLabel;
        private System.Windows.Forms.Label resultsFirstNameLabel;
        private System.Windows.Forms.Label teacherIDLabel;
        private System.Windows.Forms.DataGridView teacherSearchDataGridView;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.DateTimePicker dobDateTimePicker;
        private System.Windows.Forms.TextBox lastNameTextbox;
        private System.Windows.Forms.TextBox firstNameTextbox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.BindingSource teacherBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacherIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn recordIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressStreetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sSNDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox stateComboBox;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.ComboBox sexComboBox;
    }
}
