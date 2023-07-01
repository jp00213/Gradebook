namespace Gradebook.View
{
    partial class AdministratorStudents
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.administratorStudentTabControl = new System.Windows.Forms.TabControl();
            this.addStudentTabPage = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.addStudentUserControl1 = new Gradebook.UserControls.AddStudentUserControl();
            this.viewStudentTabPage = new System.Windows.Forms.TabPage();
            this.searchStudentUserControl1 = new Gradebook.UserControls.SearchStudentUserControl();
            this.updateStudentTabPage = new System.Windows.Forms.TabPage();
            this.viewAndUpdateStudentUserControl1 = new Gradebook.UserControls.ViewAndUpdateStudentUserControl();
            this.changePasswordTagPage = new System.Windows.Forms.TabPage();
            this.changeStudentPasswordUserControl1 = new Gradebook.UserControls.ChangeStudentPasswordUserControl();
            this.studentReistrationDetailsTablPage = new System.Windows.Forms.TabPage();
            this.studentRegistrationDetailsUserControl1 = new Gradebook.UserControls.StudentRegistrationDetailsUserControl();
            this.currentStudentIDMasterLabel = new System.Windows.Forms.Label();
            this.currentStudentIDDataLabel = new System.Windows.Forms.Label();
            this.backHomeButton = new System.Windows.Forms.Button();
            this.instructionLabel = new System.Windows.Forms.Label();
            this.administratorStudentTabControl.SuspendLayout();
            this.addStudentTabPage.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.viewStudentTabPage.SuspendLayout();
            this.updateStudentTabPage.SuspendLayout();
            this.changePasswordTagPage.SuspendLayout();
            this.studentReistrationDetailsTablPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // administratorStudentTabControl
            // 
            this.administratorStudentTabControl.Controls.Add(this.addStudentTabPage);
            this.administratorStudentTabControl.Controls.Add(this.viewStudentTabPage);
            this.administratorStudentTabControl.Controls.Add(this.updateStudentTabPage);
            this.administratorStudentTabControl.Controls.Add(this.changePasswordTagPage);
            this.administratorStudentTabControl.Controls.Add(this.studentReistrationDetailsTablPage);
            this.administratorStudentTabControl.Location = new System.Drawing.Point(2, 43);
            this.administratorStudentTabControl.Name = "administratorStudentTabControl";
            this.administratorStudentTabControl.SelectedIndex = 0;
            this.administratorStudentTabControl.Size = new System.Drawing.Size(994, 646);
            this.administratorStudentTabControl.TabIndex = 0;
            // 
            // addStudentTabPage
            // 
            this.addStudentTabPage.Controls.Add(this.tableLayoutPanel1);
            this.addStudentTabPage.Location = new System.Drawing.Point(4, 22);
            this.addStudentTabPage.Name = "addStudentTabPage";
            this.addStudentTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.addStudentTabPage.Size = new System.Drawing.Size(986, 620);
            this.addStudentTabPage.TabIndex = 0;
            this.addStudentTabPage.Text = "Add Student";
            this.addStudentTabPage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.52631F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.47368F));
            this.tableLayoutPanel1.Controls.Add(this.addStudentUserControl1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 15);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 96.09929F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.900709F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(964, 568);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // addStudentUserControl1
            // 
            this.addStudentUserControl1.Location = new System.Drawing.Point(4, 4);
            this.addStudentUserControl1.Margin = new System.Windows.Forms.Padding(4);
            this.addStudentUserControl1.Name = "addStudentUserControl1";
            this.addStudentUserControl1.Size = new System.Drawing.Size(748, 537);
            this.addStudentUserControl1.TabIndex = 0;
            // 
            // viewStudentTabPage
            // 
            this.viewStudentTabPage.Controls.Add(this.searchStudentUserControl1);
            this.viewStudentTabPage.Location = new System.Drawing.Point(4, 22);
            this.viewStudentTabPage.Name = "viewStudentTabPage";
            this.viewStudentTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.viewStudentTabPage.Size = new System.Drawing.Size(986, 620);
            this.viewStudentTabPage.TabIndex = 1;
            this.viewStudentTabPage.Text = "View Student";
            this.viewStudentTabPage.UseVisualStyleBackColor = true;
            // 
            // searchStudentUserControl1
            // 
            this.searchStudentUserControl1.Location = new System.Drawing.Point(6, 6);
            this.searchStudentUserControl1.Margin = new System.Windows.Forms.Padding(4);
            this.searchStudentUserControl1.Name = "searchStudentUserControl1";
            this.searchStudentUserControl1.Size = new System.Drawing.Size(960, 640);
            this.searchStudentUserControl1.TabIndex = 0;
            this.searchStudentUserControl1.StudentNumberChanged += new System.EventHandler(this.searchStudentUserControl1_StudentNumberChanged);
            // 
            // updateStudentTabPage
            // 
            this.updateStudentTabPage.Controls.Add(this.viewAndUpdateStudentUserControl1);
            this.updateStudentTabPage.Location = new System.Drawing.Point(4, 22);
            this.updateStudentTabPage.Name = "updateStudentTabPage";
            this.updateStudentTabPage.Size = new System.Drawing.Size(986, 620);
            this.updateStudentTabPage.TabIndex = 2;
            this.updateStudentTabPage.Text = "Update Student";
            this.updateStudentTabPage.UseVisualStyleBackColor = true;
            // 
            // viewAndUpdateStudentUserControl1
            // 
            this.viewAndUpdateStudentUserControl1.Location = new System.Drawing.Point(6, 3);
            this.viewAndUpdateStudentUserControl1.Margin = new System.Windows.Forms.Padding(4);
            this.viewAndUpdateStudentUserControl1.Name = "viewAndUpdateStudentUserControl1";
            this.viewAndUpdateStudentUserControl1.Size = new System.Drawing.Size(960, 640);
            this.viewAndUpdateStudentUserControl1.TabIndex = 0;
            // 
            // changePasswordTagPage
            // 
            this.changePasswordTagPage.Controls.Add(this.changeStudentPasswordUserControl1);
            this.changePasswordTagPage.Location = new System.Drawing.Point(4, 22);
            this.changePasswordTagPage.Name = "changePasswordTagPage";
            this.changePasswordTagPage.Size = new System.Drawing.Size(986, 620);
            this.changePasswordTagPage.TabIndex = 3;
            this.changePasswordTagPage.Text = "Change Password";
            this.changePasswordTagPage.UseVisualStyleBackColor = true;
            // 
            // changeStudentPasswordUserControl1
            // 
            this.changeStudentPasswordUserControl1.Location = new System.Drawing.Point(3, 3);
            this.changeStudentPasswordUserControl1.Margin = new System.Windows.Forms.Padding(4);
            this.changeStudentPasswordUserControl1.Name = "changeStudentPasswordUserControl1";
            this.changeStudentPasswordUserControl1.Size = new System.Drawing.Size(929, 540);
            this.changeStudentPasswordUserControl1.TabIndex = 0;
            // 
            // studentReistrationDetailsTablPage
            // 
            this.studentReistrationDetailsTablPage.Controls.Add(this.studentRegistrationDetailsUserControl1);
            this.studentReistrationDetailsTablPage.Location = new System.Drawing.Point(4, 22);
            this.studentReistrationDetailsTablPage.Name = "studentReistrationDetailsTablPage";
            this.studentReistrationDetailsTablPage.Padding = new System.Windows.Forms.Padding(3);
            this.studentReistrationDetailsTablPage.Size = new System.Drawing.Size(986, 620);
            this.studentReistrationDetailsTablPage.TabIndex = 4;
            this.studentReistrationDetailsTablPage.Text = "Registration & Grade Details";
            this.studentReistrationDetailsTablPage.UseVisualStyleBackColor = true;
            // 
            // studentRegistrationDetailsUserControl1
            // 
            this.studentRegistrationDetailsUserControl1.Location = new System.Drawing.Point(6, 6);
            this.studentRegistrationDetailsUserControl1.Name = "studentRegistrationDetailsUserControl1";
            this.studentRegistrationDetailsUserControl1.Size = new System.Drawing.Size(973, 598);
            this.studentRegistrationDetailsUserControl1.TabIndex = 0;
            // 
            // currentStudentIDMasterLabel
            // 
            this.currentStudentIDMasterLabel.AutoSize = true;
            this.currentStudentIDMasterLabel.Location = new System.Drawing.Point(702, 27);
            this.currentStudentIDMasterLabel.Name = "currentStudentIDMasterLabel";
            this.currentStudentIDMasterLabel.Size = new System.Drawing.Size(106, 13);
            this.currentStudentIDMasterLabel.TabIndex = 1;
            this.currentStudentIDMasterLabel.Text = "Selected Student ID:";
            // 
            // currentStudentIDDataLabel
            // 
            this.currentStudentIDDataLabel.AutoSize = true;
            this.currentStudentIDDataLabel.Location = new System.Drawing.Point(814, 27);
            this.currentStudentIDDataLabel.Name = "currentStudentIDDataLabel";
            this.currentStudentIDDataLabel.Size = new System.Drawing.Size(13, 13);
            this.currentStudentIDDataLabel.TabIndex = 2;
            this.currentStudentIDDataLabel.Text = "0";
            this.currentStudentIDDataLabel.TextChanged += new System.EventHandler(this.currentStudentIDDataLabel_TextChanged);
            // 
            // backHomeButton
            // 
            this.backHomeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backHomeButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.backHomeButton.Location = new System.Drawing.Point(6, 7);
            this.backHomeButton.Name = "backHomeButton";
            this.backHomeButton.Size = new System.Drawing.Size(104, 30);
            this.backHomeButton.TabIndex = 3;
            this.backHomeButton.Text = "Home";
            this.backHomeButton.UseVisualStyleBackColor = true;
            this.backHomeButton.Click += new System.EventHandler(this.backHomeButton_Click);
            // 
            // instructionLabel
            // 
            this.instructionLabel.AutoSize = true;
            this.instructionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.instructionLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.instructionLabel.Location = new System.Drawing.Point(148, 16);
            this.instructionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(515, 15);
            this.instructionLabel.TabIndex = 4;
            this.instructionLabel.Text = "Select student in View Tab to use in Update, Change Password, and Registration De" +
    "tails Tabs";
            // 
            // AdministratorStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 693);
            this.Controls.Add(this.instructionLabel);
            this.Controls.Add(this.backHomeButton);
            this.Controls.Add(this.currentStudentIDDataLabel);
            this.Controls.Add(this.currentStudentIDMasterLabel);
            this.Controls.Add(this.administratorStudentTabControl);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdministratorStudents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdministratorStudents";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdministratorStudents_FormClosed);
            this.administratorStudentTabControl.ResumeLayout(false);
            this.addStudentTabPage.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.viewStudentTabPage.ResumeLayout(false);
            this.updateStudentTabPage.ResumeLayout(false);
            this.changePasswordTagPage.ResumeLayout(false);
            this.studentReistrationDetailsTablPage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl administratorStudentTabControl;
        private System.Windows.Forms.TabPage addStudentTabPage;
        private System.Windows.Forms.TabPage viewStudentTabPage;
        private System.Windows.Forms.TabPage updateStudentTabPage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private UserControls.AddStudentUserControl addStudentUserControl1;
        private UserControls.SearchStudentUserControl searchStudentUserControl1;
        private UserControls.ViewAndUpdateStudentUserControl viewAndUpdateStudentUserControl1;
        private System.Windows.Forms.Label currentStudentIDMasterLabel;
        private System.Windows.Forms.Label currentStudentIDDataLabel;
        private System.Windows.Forms.TabPage changePasswordTagPage;
        private UserControls.ChangeStudentPasswordUserControl changeStudentPasswordUserControl1;
        private System.Windows.Forms.Button backHomeButton;
        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.TabPage studentReistrationDetailsTablPage;
        private UserControls.StudentRegistrationDetailsUserControl studentRegistrationDetailsUserControl1;
    }
}