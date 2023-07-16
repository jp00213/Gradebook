namespace Gradebook.UserControls
{
    partial class ChangeStudentPasswordUserControl
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
            this.changeStudentPasswordPanel = new System.Windows.Forms.Panel();
            this.complexityRequirementLabel = new System.Windows.Forms.Label();
            this.errorMessageLabel = new System.Windows.Forms.Label();
            this.changePasswordButton = new System.Windows.Forms.Button();
            this.maskedPasswordTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.maskedPasswordTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.firstLastNameLabelText = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.usernameLabelText = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.currentStudentIDForEdit = new System.Windows.Forms.Label();
            this.currentStudentIDSetLabel = new System.Windows.Forms.Label();
            this.changePasswordTitleLable = new System.Windows.Forms.Label();
            this.firstPasswordLabel = new System.Windows.Forms.Label();
            this.changeStudentPasswordPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // changeStudentPasswordPanel
            // 
            this.changeStudentPasswordPanel.Controls.Add(this.complexityRequirementLabel);
            this.changeStudentPasswordPanel.Controls.Add(this.errorMessageLabel);
            this.changeStudentPasswordPanel.Controls.Add(this.changePasswordButton);
            this.changeStudentPasswordPanel.Controls.Add(this.maskedPasswordTextBox2);
            this.changeStudentPasswordPanel.Controls.Add(this.maskedPasswordTextBox1);
            this.changeStudentPasswordPanel.Controls.Add(this.label1);
            this.changeStudentPasswordPanel.Controls.Add(this.firstLastNameLabelText);
            this.changeStudentPasswordPanel.Controls.Add(this.nameLabel);
            this.changeStudentPasswordPanel.Controls.Add(this.usernameLabelText);
            this.changeStudentPasswordPanel.Controls.Add(this.usernameLabel);
            this.changeStudentPasswordPanel.Controls.Add(this.currentStudentIDForEdit);
            this.changeStudentPasswordPanel.Controls.Add(this.currentStudentIDSetLabel);
            this.changeStudentPasswordPanel.Controls.Add(this.changePasswordTitleLable);
            this.changeStudentPasswordPanel.Controls.Add(this.firstPasswordLabel);
            this.changeStudentPasswordPanel.Location = new System.Drawing.Point(44, 36);
            this.changeStudentPasswordPanel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.changeStudentPasswordPanel.Name = "changeStudentPasswordPanel";
            this.changeStudentPasswordPanel.Size = new System.Drawing.Size(1834, 1123);
            this.changeStudentPasswordPanel.TabIndex = 0;
            // 
            // complexityRequirementLabel
            // 
            this.complexityRequirementLabel.AutoSize = true;
            this.complexityRequirementLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.complexityRequirementLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.complexityRequirementLabel.Location = new System.Drawing.Point(158, 196);
            this.complexityRequirementLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.complexityRequirementLabel.Name = "complexityRequirementLabel";
            this.complexityRequirementLabel.Size = new System.Drawing.Size(411, 25);
            this.complexityRequirementLabel.TabIndex = 56;
            this.complexityRequirementLabel.Text = "At least 8 characters including letters and digit.";
            // 
            // errorMessageLabel
            // 
            this.errorMessageLabel.AutoSize = true;
            this.errorMessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.errorMessageLabel.Location = new System.Drawing.Point(172, 156);
            this.errorMessageLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.errorMessageLabel.Name = "errorMessageLabel";
            this.errorMessageLabel.Size = new System.Drawing.Size(19, 25);
            this.errorMessageLabel.TabIndex = 55;
            this.errorMessageLabel.Text = "-";
            // 
            // changePasswordButton
            // 
            this.changePasswordButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.changePasswordButton.Location = new System.Drawing.Point(250, 374);
            this.changePasswordButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.changePasswordButton.Name = "changePasswordButton";
            this.changePasswordButton.Size = new System.Drawing.Size(310, 44);
            this.changePasswordButton.TabIndex = 54;
            this.changePasswordButton.Text = "Change Password";
            this.changePasswordButton.UseVisualStyleBackColor = true;
            this.changePasswordButton.Click += new System.EventHandler(this.changePasswordButton_Click);
            // 
            // maskedPasswordTextBox2
            // 
            this.maskedPasswordTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.maskedPasswordTextBox2.Location = new System.Drawing.Point(266, 291);
            this.maskedPasswordTextBox2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.maskedPasswordTextBox2.Name = "maskedPasswordTextBox2";
            this.maskedPasswordTextBox2.PasswordChar = '*';
            this.maskedPasswordTextBox2.Size = new System.Drawing.Size(357, 30);
            this.maskedPasswordTextBox2.TabIndex = 53;
            // 
            // maskedPasswordTextBox1
            // 
            this.maskedPasswordTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.maskedPasswordTextBox1.Location = new System.Drawing.Point(266, 227);
            this.maskedPasswordTextBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.maskedPasswordTextBox1.Name = "maskedPasswordTextBox1";
            this.maskedPasswordTextBox1.PasswordChar = '*';
            this.maskedPasswordTextBox1.Size = new System.Drawing.Size(357, 30);
            this.maskedPasswordTextBox1.TabIndex = 51;
            this.maskedPasswordTextBox1.TextChanged += new System.EventHandler(this.maskedTextBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(42, 294);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 25);
            this.label1.TabIndex = 50;
            this.label1.Text = "Confirm New Password:";
            // 
            // firstLastNameLabelText
            // 
            this.firstLastNameLabelText.AutoSize = true;
            this.firstLastNameLabelText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.firstLastNameLabelText.Location = new System.Drawing.Point(744, 98);
            this.firstLastNameLabelText.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.firstLastNameLabelText.Name = "firstLastNameLabelText";
            this.firstLastNameLabelText.Size = new System.Drawing.Size(26, 25);
            this.firstLastNameLabelText.TabIndex = 49;
            this.firstLastNameLabelText.Text = "--";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.nameLabel.Location = new System.Drawing.Point(610, 98);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(70, 25);
            this.nameLabel.TabIndex = 48;
            this.nameLabel.Text = "Name:";
            // 
            // usernameLabelText
            // 
            this.usernameLabelText.AutoSize = true;
            this.usernameLabelText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.usernameLabelText.Location = new System.Drawing.Point(448, 98);
            this.usernameLabelText.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.usernameLabelText.Name = "usernameLabelText";
            this.usernameLabelText.Size = new System.Drawing.Size(26, 25);
            this.usernameLabelText.TabIndex = 47;
            this.usernameLabelText.Text = "--";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.usernameLabel.Location = new System.Drawing.Point(296, 98);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(108, 25);
            this.usernameLabel.TabIndex = 46;
            this.usernameLabel.Text = "Username:";
            // 
            // currentStudentIDForEdit
            // 
            this.currentStudentIDForEdit.AutoSize = true;
            this.currentStudentIDForEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.currentStudentIDForEdit.Location = new System.Drawing.Point(189, 98);
            this.currentStudentIDForEdit.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.currentStudentIDForEdit.Name = "currentStudentIDForEdit";
            this.currentStudentIDForEdit.Size = new System.Drawing.Size(23, 25);
            this.currentStudentIDForEdit.TabIndex = 45;
            this.currentStudentIDForEdit.Text = "0";
            this.currentStudentIDForEdit.TextChanged += new System.EventHandler(this.studentIDChanged);
            // 
            // currentStudentIDSetLabel
            // 
            this.currentStudentIDSetLabel.AutoSize = true;
            this.currentStudentIDSetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.currentStudentIDSetLabel.Location = new System.Drawing.Point(55, 98);
            this.currentStudentIDSetLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.currentStudentIDSetLabel.Name = "currentStudentIDSetLabel";
            this.currentStudentIDSetLabel.Size = new System.Drawing.Size(110, 25);
            this.currentStudentIDSetLabel.TabIndex = 44;
            this.currentStudentIDSetLabel.Text = "Student ID:";
            // 
            // changePasswordTitleLable
            // 
            this.changePasswordTitleLable.AutoSize = true;
            this.changePasswordTitleLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePasswordTitleLable.Location = new System.Drawing.Point(98, 31);
            this.changePasswordTitleLable.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.changePasswordTitleLable.Name = "changePasswordTitleLable";
            this.changePasswordTitleLable.Size = new System.Drawing.Size(188, 25);
            this.changePasswordTitleLable.TabIndex = 1;
            this.changePasswordTitleLable.Text = "Change Password";
            // 
            // firstPasswordLabel
            // 
            this.firstPasswordLabel.AutoSize = true;
            this.firstPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.firstPasswordLabel.Location = new System.Drawing.Point(42, 230);
            this.firstPasswordLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.firstPasswordLabel.Name = "firstPasswordLabel";
            this.firstPasswordLabel.Size = new System.Drawing.Size(199, 25);
            this.firstPasswordLabel.TabIndex = 0;
            this.firstPasswordLabel.Text = "Enter New Password:";
            // 
            // ChangeStudentPasswordUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.changeStudentPasswordPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "ChangeStudentPasswordUserControl";
            this.Size = new System.Drawing.Size(1920, 1231);
            this.changeStudentPasswordPanel.ResumeLayout(false);
            this.changeStudentPasswordPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel changeStudentPasswordPanel;
        private System.Windows.Forms.Label firstPasswordLabel;
        private System.Windows.Forms.Label changePasswordTitleLable;
        private System.Windows.Forms.Label firstLastNameLabelText;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label usernameLabelText;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label currentStudentIDForEdit;
        private System.Windows.Forms.Label currentStudentIDSetLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button changePasswordButton;
        private System.Windows.Forms.MaskedTextBox maskedPasswordTextBox2;
        private System.Windows.Forms.MaskedTextBox maskedPasswordTextBox1;
        private System.Windows.Forms.Label errorMessageLabel;
        private System.Windows.Forms.Label complexityRequirementLabel;
    }
}
