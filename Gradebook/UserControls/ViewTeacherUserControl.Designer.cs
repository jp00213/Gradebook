namespace Gradebook.UserControls
{
    partial class ViewTeacherUserControl
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
            this.firstNameTextbox = new System.Windows.Forms.TextBox();
            this.lastNameTextbox = new System.Windows.Forms.TextBox();
            this.dobDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.searchButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.teacherIDLabel = new System.Windows.Forms.Label();
            this.resultsFirstNameLabel = new System.Windows.Forms.Label();
            this.resultsLastNameLabel = new System.Windows.Forms.Label();
            this.resultsDOBLabel = new System.Windows.Forms.Label();
            this.sexLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.stateLabel = new System.Windows.Forms.Label();
            this.zipLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.teacherIDtextBox = new System.Windows.Forms.TextBox();
            this.resultsFirstNameTextbox = new System.Windows.Forms.TextBox();
            this.resultsLastNameTextBox = new System.Windows.Forms.TextBox();
            this.sexTextBox = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.stateTextBox = new System.Windows.Forms.TextBox();
            this.zipTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.dobLabel = new System.Windows.Forms.Label();
            this.resultsDOBDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.clearButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // firstNameTextbox
            // 
            this.firstNameTextbox.Location = new System.Drawing.Point(53, 57);
            this.firstNameTextbox.Name = "firstNameTextbox";
            this.firstNameTextbox.Size = new System.Drawing.Size(200, 20);
            this.firstNameTextbox.TabIndex = 0;
            // 
            // lastNameTextbox
            // 
            this.lastNameTextbox.Location = new System.Drawing.Point(276, 57);
            this.lastNameTextbox.Name = "lastNameTextbox";
            this.lastNameTextbox.Size = new System.Drawing.Size(200, 20);
            this.lastNameTextbox.TabIndex = 1;
            // 
            // dobDateTimePicker
            // 
            this.dobDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dobDateTimePicker.Location = new System.Drawing.Point(496, 57);
            this.dobDateTimePicker.Name = "dobDateTimePicker";
            this.dobDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dobDateTimePicker.TabIndex = 2;
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(720, 50);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(104, 27);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(129, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(662, 177);
            this.dataGridView1.TabIndex = 4;
            // 
            // teacherIDLabel
            // 
            this.teacherIDLabel.AutoSize = true;
            this.teacherIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherIDLabel.Location = new System.Drawing.Point(126, 313);
            this.teacherIDLabel.Name = "teacherIDLabel";
            this.teacherIDLabel.Size = new System.Drawing.Size(74, 16);
            this.teacherIDLabel.TabIndex = 5;
            this.teacherIDLabel.Text = "Teacher ID";
            // 
            // resultsFirstNameLabel
            // 
            this.resultsFirstNameLabel.AutoSize = true;
            this.resultsFirstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultsFirstNameLabel.Location = new System.Drawing.Point(126, 353);
            this.resultsFirstNameLabel.Name = "resultsFirstNameLabel";
            this.resultsFirstNameLabel.Size = new System.Drawing.Size(72, 16);
            this.resultsFirstNameLabel.TabIndex = 6;
            this.resultsFirstNameLabel.Text = "First Name";
            // 
            // resultsLastNameLabel
            // 
            this.resultsLastNameLabel.AutoSize = true;
            this.resultsLastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultsLastNameLabel.Location = new System.Drawing.Point(126, 402);
            this.resultsLastNameLabel.Name = "resultsLastNameLabel";
            this.resultsLastNameLabel.Size = new System.Drawing.Size(72, 16);
            this.resultsLastNameLabel.TabIndex = 7;
            this.resultsLastNameLabel.Text = "Last Name";
            // 
            // resultsDOBLabel
            // 
            this.resultsDOBLabel.AutoSize = true;
            this.resultsDOBLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultsDOBLabel.Location = new System.Drawing.Point(113, 444);
            this.resultsDOBLabel.Name = "resultsDOBLabel";
            this.resultsDOBLabel.Size = new System.Drawing.Size(81, 16);
            this.resultsDOBLabel.TabIndex = 8;
            this.resultsDOBLabel.Text = "Date Of Birth";
            // 
            // sexLabel
            // 
            this.sexLabel.AutoSize = true;
            this.sexLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sexLabel.Location = new System.Drawing.Point(164, 486);
            this.sexLabel.Name = "sexLabel";
            this.sexLabel.Size = new System.Drawing.Size(30, 16);
            this.sexLabel.TabIndex = 9;
            this.sexLabel.Text = "Sex";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.Location = new System.Drawing.Point(150, 527);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(44, 16);
            this.statusLabel.TabIndex = 10;
            this.statusLabel.Text = "Status";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLabel.Location = new System.Drawing.Point(493, 314);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(58, 16);
            this.addressLabel.TabIndex = 11;
            this.addressLabel.Text = "Address";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityLabel.Location = new System.Drawing.Point(516, 354);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(29, 16);
            this.cityLabel.TabIndex = 12;
            this.cityLabel.Text = "City";
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stateLabel.Location = new System.Drawing.Point(507, 402);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(38, 16);
            this.stateLabel.TabIndex = 13;
            this.stateLabel.Text = "State";
            // 
            // zipLabel
            // 
            this.zipLabel.AutoSize = true;
            this.zipLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zipLabel.Location = new System.Drawing.Point(483, 440);
            this.zipLabel.Name = "zipLabel";
            this.zipLabel.Size = new System.Drawing.Size(62, 16);
            this.zipLabel.TabIndex = 14;
            this.zipLabel.Text = "Zip Code";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneLabel.Location = new System.Drawing.Point(500, 482);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(46, 16);
            this.phoneLabel.TabIndex = 15;
            this.phoneLabel.Text = "Phone";
            // 
            // teacherIDtextBox
            // 
            this.teacherIDtextBox.Location = new System.Drawing.Point(204, 313);
            this.teacherIDtextBox.Name = "teacherIDtextBox";
            this.teacherIDtextBox.ReadOnly = true;
            this.teacherIDtextBox.Size = new System.Drawing.Size(233, 20);
            this.teacherIDtextBox.TabIndex = 16;
            // 
            // resultsFirstNameTextbox
            // 
            this.resultsFirstNameTextbox.Location = new System.Drawing.Point(204, 353);
            this.resultsFirstNameTextbox.Name = "resultsFirstNameTextbox";
            this.resultsFirstNameTextbox.ReadOnly = true;
            this.resultsFirstNameTextbox.Size = new System.Drawing.Size(233, 20);
            this.resultsFirstNameTextbox.TabIndex = 17;
            // 
            // resultsLastNameTextBox
            // 
            this.resultsLastNameTextBox.Location = new System.Drawing.Point(204, 398);
            this.resultsLastNameTextBox.Name = "resultsLastNameTextBox";
            this.resultsLastNameTextBox.ReadOnly = true;
            this.resultsLastNameTextBox.Size = new System.Drawing.Size(233, 20);
            this.resultsLastNameTextBox.TabIndex = 18;
            // 
            // sexTextBox
            // 
            this.sexTextBox.Location = new System.Drawing.Point(204, 482);
            this.sexTextBox.Name = "sexTextBox";
            this.sexTextBox.ReadOnly = true;
            this.sexTextBox.Size = new System.Drawing.Size(233, 20);
            this.sexTextBox.TabIndex = 20;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(204, 523);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(233, 20);
            this.textBox8.TabIndex = 21;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(558, 314);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.ReadOnly = true;
            this.addressTextBox.Size = new System.Drawing.Size(233, 20);
            this.addressTextBox.TabIndex = 22;
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(557, 354);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.ReadOnly = true;
            this.cityTextBox.Size = new System.Drawing.Size(234, 20);
            this.cityTextBox.TabIndex = 23;
            // 
            // stateTextBox
            // 
            this.stateTextBox.Location = new System.Drawing.Point(558, 398);
            this.stateTextBox.Name = "stateTextBox";
            this.stateTextBox.ReadOnly = true;
            this.stateTextBox.Size = new System.Drawing.Size(233, 20);
            this.stateTextBox.TabIndex = 24;
            // 
            // zipTextBox
            // 
            this.zipTextBox.Location = new System.Drawing.Point(558, 440);
            this.zipTextBox.Name = "zipTextBox";
            this.zipTextBox.ReadOnly = true;
            this.zipTextBox.Size = new System.Drawing.Size(233, 20);
            this.zipTextBox.TabIndex = 25;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(558, 482);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.ReadOnly = true;
            this.phoneTextBox.Size = new System.Drawing.Size(233, 20);
            this.phoneTextBox.TabIndex = 26;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLabel.Location = new System.Drawing.Point(50, 36);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(91, 18);
            this.firstNameLabel.TabIndex = 27;
            this.firstNameLabel.Text = "First Name";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLabel.Location = new System.Drawing.Point(273, 36);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(89, 18);
            this.lastNameLabel.TabIndex = 28;
            this.lastNameLabel.Text = "Last Name";
            // 
            // dobLabel
            // 
            this.dobLabel.AutoSize = true;
            this.dobLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobLabel.Location = new System.Drawing.Point(493, 36);
            this.dobLabel.Name = "dobLabel";
            this.dobLabel.Size = new System.Drawing.Size(44, 18);
            this.dobLabel.TabIndex = 29;
            this.dobLabel.Text = "DOB";
            // 
            // resultsDOBDateTimePicker
            // 
            this.resultsDOBDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.resultsDOBDateTimePicker.Location = new System.Drawing.Point(204, 440);
            this.resultsDOBDateTimePicker.Name = "resultsDOBDateTimePicker";
            this.resultsDOBDateTimePicker.Size = new System.Drawing.Size(233, 20);
            this.resultsDOBDateTimePicker.TabIndex = 30;
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(400, 569);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(137, 32);
            this.clearButton.TabIndex = 31;
            this.clearButton.Text = "Clear Search";
            this.clearButton.UseVisualStyleBackColor = true;
            // 
            // ViewTeacherUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.resultsDOBDateTimePicker);
            this.Controls.Add(this.dobLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.zipTextBox);
            this.Controls.Add(this.stateTextBox);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.sexTextBox);
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
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.dobDateTimePicker);
            this.Controls.Add(this.lastNameTextbox);
            this.Controls.Add(this.firstNameTextbox);
            this.Name = "ViewTeacherUserControl";
            this.Size = new System.Drawing.Size(917, 620);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstNameTextbox;
        private System.Windows.Forms.TextBox lastNameTextbox;
        private System.Windows.Forms.DateTimePicker dobDateTimePicker;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label teacherIDLabel;
        private System.Windows.Forms.Label resultsFirstNameLabel;
        private System.Windows.Forms.Label resultsLastNameLabel;
        private System.Windows.Forms.Label resultsDOBLabel;
        private System.Windows.Forms.Label sexLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.Label zipLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.TextBox teacherIDtextBox;
        private System.Windows.Forms.TextBox resultsFirstNameTextbox;
        private System.Windows.Forms.TextBox resultsLastNameTextBox;
        private System.Windows.Forms.TextBox sexTextBox;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox stateTextBox;
        private System.Windows.Forms.TextBox zipTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label dobLabel;
        private System.Windows.Forms.DateTimePicker resultsDOBDateTimePicker;
        private System.Windows.Forms.Button clearButton;
    }
}
