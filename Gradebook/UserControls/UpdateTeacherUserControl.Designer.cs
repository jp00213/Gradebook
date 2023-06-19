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
            this.sexLabel = new System.Windows.Forms.Label();
            this.resultsDOBLabel = new System.Windows.Forms.Label();
            this.resultsLastNameLabel = new System.Windows.Forms.Label();
            this.resultsFirstNameLabel = new System.Windows.Forms.Label();
            this.teacherIDLabel = new System.Windows.Forms.Label();
            this.teacherSearchDataGridView = new System.Windows.Forms.DataGridView();
            this.searchButton = new System.Windows.Forms.Button();
            this.dobDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lastNameTextbox = new System.Windows.Forms.TextBox();
            this.firstNameTextbox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.stateComboBox = new System.Windows.Forms.ComboBox();
            this.sexComboBox = new System.Windows.Forms.ComboBox();
            this.ssnLabel = new System.Windows.Forms.Label();
            this.firstNameErrorLabel = new System.Windows.Forms.Label();
            this.lastNameErrorLabel = new System.Windows.Forms.Label();
            this.DOBErrorLabel = new System.Windows.Forms.Label();
            this.ssnErrorLabel = new System.Windows.Forms.Label();
            this.sexErrorLabel = new System.Windows.Forms.Label();
            this.addressErrorLabel = new System.Windows.Forms.Label();
            this.cityErrorLabel = new System.Windows.Forms.Label();
            this.stateErrorLabel = new System.Windows.Forms.Label();
            this.zipErrorLabel = new System.Windows.Forms.Label();
            this.phoneErrorLabel = new System.Windows.Forms.Label();
            this.ssnTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.teacherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teacherIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // resultsDOBDateTimePicker
            // 
            this.resultsDOBDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teacherBindingSource, "DateOfBirth", true));
            this.resultsDOBDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.resultsDOBDateTimePicker.Location = new System.Drawing.Point(235, 451);
            this.resultsDOBDateTimePicker.Name = "resultsDOBDateTimePicker";
            this.resultsDOBDateTimePicker.Size = new System.Drawing.Size(233, 20);
            this.resultsDOBDateTimePicker.TabIndex = 61;
            this.resultsDOBDateTimePicker.MouseDown += new System.Windows.Forms.MouseEventHandler(this.resultsDOBDateTimePicker_MouseDown);
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
            // zipTextBox
            // 
            this.zipTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teacherBindingSource, "Zip", true));
            this.zipTextBox.Location = new System.Drawing.Point(589, 451);
            this.zipTextBox.Name = "zipTextBox";
            this.zipTextBox.Size = new System.Drawing.Size(233, 20);
            this.zipTextBox.TabIndex = 56;
            this.zipTextBox.TextChanged += new System.EventHandler(this.TextBox_Changed);
            // 
            // cityTextBox
            // 
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teacherBindingSource, "City", true));
            this.cityTextBox.Location = new System.Drawing.Point(588, 365);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(234, 20);
            this.cityTextBox.TabIndex = 54;
            this.cityTextBox.TextChanged += new System.EventHandler(this.TextBox_Changed);
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teacherBindingSource, "AddressStreet", true));
            this.addressTextBox.Location = new System.Drawing.Point(589, 325);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(233, 20);
            this.addressTextBox.TabIndex = 53;
            this.addressTextBox.TextChanged += new System.EventHandler(this.TextBox_Changed);
            // 
            // resultsLastNameTextBox
            // 
            this.resultsLastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teacherBindingSource, "LastName", true));
            this.resultsLastNameTextBox.Location = new System.Drawing.Point(235, 409);
            this.resultsLastNameTextBox.Name = "resultsLastNameTextBox";
            this.resultsLastNameTextBox.Size = new System.Drawing.Size(233, 20);
            this.resultsLastNameTextBox.TabIndex = 50;
            this.resultsLastNameTextBox.TextChanged += new System.EventHandler(this.TextBox_Changed);
            // 
            // resultsFirstNameTextbox
            // 
            this.resultsFirstNameTextbox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teacherBindingSource, "FirstName", true));
            this.resultsFirstNameTextbox.Location = new System.Drawing.Point(235, 365);
            this.resultsFirstNameTextbox.Name = "resultsFirstNameTextbox";
            this.resultsFirstNameTextbox.Size = new System.Drawing.Size(233, 20);
            this.resultsFirstNameTextbox.TabIndex = 49;
            this.resultsFirstNameTextbox.TextChanged += new System.EventHandler(this.TextBox_Changed);
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
            // sexLabel
            // 
            this.sexLabel.AutoSize = true;
            this.sexLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sexLabel.Location = new System.Drawing.Point(195, 535);
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
            this.resultsFirstNameLabel.Location = new System.Drawing.Point(157, 365);
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
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.dateOfBirthDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.sexDataGridViewTextBoxColumn});
            this.teacherSearchDataGridView.DataSource = this.teacherBindingSource;
            this.teacherSearchDataGridView.Location = new System.Drawing.Point(103, 109);
            this.teacherSearchDataGridView.Name = "teacherSearchDataGridView";
            this.teacherSearchDataGridView.Size = new System.Drawing.Size(738, 177);
            this.teacherSearchDataGridView.TabIndex = 36;
            this.teacherSearchDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.teacherSearchDataGridView_CellClick);
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
            this.dobDateTimePicker.ValueChanged += new System.EventHandler(this.dobDateTimePicker_ValueChanged);
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
            this.saveButton.Enabled = false;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(527, 582);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(137, 32);
            this.saveButton.TabIndex = 66;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // stateComboBox
            // 
            this.stateComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teacherBindingSource, "State", true));
            this.stateComboBox.FormattingEnabled = true;
            this.stateComboBox.Location = new System.Drawing.Point(589, 409);
            this.stateComboBox.Name = "stateComboBox";
            this.stateComboBox.Size = new System.Drawing.Size(233, 21);
            this.stateComboBox.TabIndex = 65;
            this.stateComboBox.SelectedIndexChanged += new System.EventHandler(this.TextBox_Changed);
            // 
            // sexComboBox
            // 
            this.sexComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teacherBindingSource, "Sex", true));
            this.sexComboBox.FormattingEnabled = true;
            this.sexComboBox.Location = new System.Drawing.Point(235, 535);
            this.sexComboBox.Name = "sexComboBox";
            this.sexComboBox.Size = new System.Drawing.Size(233, 21);
            this.sexComboBox.TabIndex = 63;
            this.sexComboBox.SelectedIndexChanged += new System.EventHandler(this.TextBox_Changed);
            // 
            // ssnLabel
            // 
            this.ssnLabel.AutoSize = true;
            this.ssnLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ssnLabel.Location = new System.Drawing.Point(177, 493);
            this.ssnLabel.Name = "ssnLabel";
            this.ssnLabel.Size = new System.Drawing.Size(35, 16);
            this.ssnLabel.TabIndex = 67;
            this.ssnLabel.Text = "SSN";
            // 
            // firstNameErrorLabel
            // 
            this.firstNameErrorLabel.AutoSize = true;
            this.firstNameErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameErrorLabel.Location = new System.Drawing.Point(232, 388);
            this.firstNameErrorLabel.Name = "firstNameErrorLabel";
            this.firstNameErrorLabel.Size = new System.Drawing.Size(0, 15);
            this.firstNameErrorLabel.TabIndex = 69;
            // 
            // lastNameErrorLabel
            // 
            this.lastNameErrorLabel.AutoSize = true;
            this.lastNameErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameErrorLabel.Location = new System.Drawing.Point(232, 433);
            this.lastNameErrorLabel.Name = "lastNameErrorLabel";
            this.lastNameErrorLabel.Size = new System.Drawing.Size(0, 15);
            this.lastNameErrorLabel.TabIndex = 70;
            // 
            // DOBErrorLabel
            // 
            this.DOBErrorLabel.AutoSize = true;
            this.DOBErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DOBErrorLabel.Location = new System.Drawing.Point(232, 475);
            this.DOBErrorLabel.Name = "DOBErrorLabel";
            this.DOBErrorLabel.Size = new System.Drawing.Size(0, 15);
            this.DOBErrorLabel.TabIndex = 71;
            // 
            // ssnErrorLabel
            // 
            this.ssnErrorLabel.AutoSize = true;
            this.ssnErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ssnErrorLabel.Location = new System.Drawing.Point(232, 516);
            this.ssnErrorLabel.Name = "ssnErrorLabel";
            this.ssnErrorLabel.Size = new System.Drawing.Size(0, 15);
            this.ssnErrorLabel.TabIndex = 72;
            // 
            // sexErrorLabel
            // 
            this.sexErrorLabel.AutoSize = true;
            this.sexErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sexErrorLabel.Location = new System.Drawing.Point(232, 559);
            this.sexErrorLabel.Name = "sexErrorLabel";
            this.sexErrorLabel.Size = new System.Drawing.Size(0, 15);
            this.sexErrorLabel.TabIndex = 73;
            // 
            // addressErrorLabel
            // 
            this.addressErrorLabel.AutoSize = true;
            this.addressErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressErrorLabel.Location = new System.Drawing.Point(586, 348);
            this.addressErrorLabel.Name = "addressErrorLabel";
            this.addressErrorLabel.Size = new System.Drawing.Size(0, 15);
            this.addressErrorLabel.TabIndex = 74;
            // 
            // cityErrorLabel
            // 
            this.cityErrorLabel.AutoSize = true;
            this.cityErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityErrorLabel.Location = new System.Drawing.Point(586, 391);
            this.cityErrorLabel.Name = "cityErrorLabel";
            this.cityErrorLabel.Size = new System.Drawing.Size(0, 15);
            this.cityErrorLabel.TabIndex = 75;
            // 
            // stateErrorLabel
            // 
            this.stateErrorLabel.AutoSize = true;
            this.stateErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stateErrorLabel.Location = new System.Drawing.Point(586, 433);
            this.stateErrorLabel.Name = "stateErrorLabel";
            this.stateErrorLabel.Size = new System.Drawing.Size(0, 15);
            this.stateErrorLabel.TabIndex = 76;
            // 
            // zipErrorLabel
            // 
            this.zipErrorLabel.AutoSize = true;
            this.zipErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zipErrorLabel.Location = new System.Drawing.Point(586, 474);
            this.zipErrorLabel.Name = "zipErrorLabel";
            this.zipErrorLabel.Size = new System.Drawing.Size(0, 15);
            this.zipErrorLabel.TabIndex = 77;
            // 
            // phoneErrorLabel
            // 
            this.phoneErrorLabel.AutoSize = true;
            this.phoneErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneErrorLabel.Location = new System.Drawing.Point(586, 518);
            this.phoneErrorLabel.Name = "phoneErrorLabel";
            this.phoneErrorLabel.Size = new System.Drawing.Size(0, 15);
            this.phoneErrorLabel.TabIndex = 78;
            // 
            // ssnTextBox
            // 
            this.ssnTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teacherBindingSource, "SSN", true));
            this.ssnTextBox.Location = new System.Drawing.Point(235, 493);
            this.ssnTextBox.Name = "ssnTextBox";
            this.ssnTextBox.Size = new System.Drawing.Size(233, 20);
            this.ssnTextBox.TabIndex = 80;
            this.ssnTextBox.TextChanged += new System.EventHandler(this.TextBox_Changed);
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teacherBindingSource, "Phone", true));
            this.phoneTextBox.Location = new System.Drawing.Point(589, 492);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(233, 20);
            this.phoneTextBox.TabIndex = 81;
            this.phoneTextBox.TextChanged += new System.EventHandler(this.TextBox_Changed);
            // 
            // teacherBindingSource
            // 
            this.teacherBindingSource.DataSource = typeof(Gradebook.Model.Teacher);
            // 
            // teacherIDDataGridViewTextBoxColumn
            // 
            this.teacherIDDataGridViewTextBoxColumn.DataPropertyName = "TeacherID";
            this.teacherIDDataGridViewTextBoxColumn.HeaderText = "TeacherID";
            this.teacherIDDataGridViewTextBoxColumn.Name = "teacherIDDataGridViewTextBoxColumn";
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // dateOfBirthDataGridViewTextBoxColumn
            // 
            this.dateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "DateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn.HeaderText = "DateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn.Name = "dateOfBirthDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // sexDataGridViewTextBoxColumn
            // 
            this.sexDataGridViewTextBoxColumn.DataPropertyName = "Sex";
            this.sexDataGridViewTextBoxColumn.HeaderText = "Sex";
            this.sexDataGridViewTextBoxColumn.Name = "sexDataGridViewTextBoxColumn";
            // 
            // UpdateTeacherUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.ssnTextBox);
            this.Controls.Add(this.phoneErrorLabel);
            this.Controls.Add(this.zipErrorLabel);
            this.Controls.Add(this.stateErrorLabel);
            this.Controls.Add(this.cityErrorLabel);
            this.Controls.Add(this.addressErrorLabel);
            this.Controls.Add(this.sexErrorLabel);
            this.Controls.Add(this.ssnErrorLabel);
            this.Controls.Add(this.DOBErrorLabel);
            this.Controls.Add(this.lastNameErrorLabel);
            this.Controls.Add(this.firstNameErrorLabel);
            this.Controls.Add(this.ssnLabel);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.stateComboBox);
            this.Controls.Add(this.sexComboBox);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.resultsDOBDateTimePicker);
            this.Controls.Add(this.dobLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
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
        private System.Windows.Forms.ComboBox stateComboBox;
        private System.Windows.Forms.ComboBox sexComboBox;
        private System.Windows.Forms.Label ssnLabel;
        private System.Windows.Forms.Label firstNameErrorLabel;
        private System.Windows.Forms.Label lastNameErrorLabel;
        private System.Windows.Forms.Label DOBErrorLabel;
        private System.Windows.Forms.Label ssnErrorLabel;
        private System.Windows.Forms.Label sexErrorLabel;
        private System.Windows.Forms.Label addressErrorLabel;
        private System.Windows.Forms.Label cityErrorLabel;
        private System.Windows.Forms.Label stateErrorLabel;
        private System.Windows.Forms.Label zipErrorLabel;
        private System.Windows.Forms.Label phoneErrorLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacherIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox ssnTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
    }
}
