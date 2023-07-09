namespace Gradebook.View
{
    partial class StudentDashboard
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
            this.logoutLinkLabel = new System.Windows.Forms.LinkLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.courseSummaryTab = new System.Windows.Forms.TabPage();
            this.studentCourseSummaryUserControl1 = new Gradebook.UserControls.StudentCourseSummaryUserControl();
            this.gradeDetailstab = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.studentRegistrationUserControl1 = new Gradebook.UserControls.StudentRegistrationUserControl();
            this.currentUsernameLabel = new System.Windows.Forms.Label();
            this.userNameDataLabel = new System.Windows.Forms.Label();
            this.studentGPAUserControl1 = new Gradebook.UserControls.StudentGPAUserControl();
            this.tabControl1.SuspendLayout();
            this.courseSummaryTab.SuspendLayout();
            this.gradeDetailstab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // logoutLinkLabel
            // 
            this.logoutLinkLabel.AutoSize = true;
            this.logoutLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.logoutLinkLabel.Location = new System.Drawing.Point(856, 16);
            this.logoutLinkLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.logoutLinkLabel.Name = "logoutLinkLabel";
            this.logoutLinkLabel.Size = new System.Drawing.Size(59, 20);
            this.logoutLinkLabel.TabIndex = 1;
            this.logoutLinkLabel.TabStop = true;
            this.logoutLinkLabel.Text = "Logout";
            this.logoutLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.logoutLinkLabel_LinkClicked);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.courseSummaryTab);
            this.tabControl1.Controls.Add(this.gradeDetailstab);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(2, 39);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(994, 651);
            this.tabControl1.TabIndex = 2;
            // 
            // courseSummaryTab
            // 
            this.courseSummaryTab.Controls.Add(this.studentCourseSummaryUserControl1);
            this.courseSummaryTab.Location = new System.Drawing.Point(4, 25);
            this.courseSummaryTab.Name = "courseSummaryTab";
            this.courseSummaryTab.Padding = new System.Windows.Forms.Padding(3);
            this.courseSummaryTab.Size = new System.Drawing.Size(986, 622);
            this.courseSummaryTab.TabIndex = 0;
            this.courseSummaryTab.Text = "Grade Summary";
            this.courseSummaryTab.UseVisualStyleBackColor = true;
            // 
            // studentCourseSummaryUserControl1
            // 
            this.studentCourseSummaryUserControl1.Location = new System.Drawing.Point(-7, 0);
            this.studentCourseSummaryUserControl1.Margin = new System.Windows.Forms.Padding(4);
            this.studentCourseSummaryUserControl1.Name = "studentCourseSummaryUserControl1";
            this.studentCourseSummaryUserControl1.Size = new System.Drawing.Size(997, 603);
            this.studentCourseSummaryUserControl1.TabIndex = 0;
            // 
            // gradeDetailstab
            // 
            this.gradeDetailstab.Controls.Add(this.studentGPAUserControl1);
            this.gradeDetailstab.Location = new System.Drawing.Point(4, 25);
            this.gradeDetailstab.Name = "gradeDetailstab";
            this.gradeDetailstab.Padding = new System.Windows.Forms.Padding(3);
            this.gradeDetailstab.Size = new System.Drawing.Size(986, 622);
            this.gradeDetailstab.TabIndex = 1;
            this.gradeDetailstab.Text = "Grade Details";
            this.gradeDetailstab.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.studentRegistrationUserControl1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(986, 622);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Registration";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // studentRegistrationUserControl1
            // 
            this.studentRegistrationUserControl1.Location = new System.Drawing.Point(-3, 6);
            this.studentRegistrationUserControl1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.studentRegistrationUserControl1.Name = "studentRegistrationUserControl1";
            this.studentRegistrationUserControl1.Size = new System.Drawing.Size(986, 613);
            this.studentRegistrationUserControl1.TabIndex = 0;
            // 
            // currentUsernameLabel
            // 
            this.currentUsernameLabel.AutoSize = true;
            this.currentUsernameLabel.Location = new System.Drawing.Point(572, 16);
            this.currentUsernameLabel.Name = "currentUsernameLabel";
            this.currentUsernameLabel.Size = new System.Drawing.Size(84, 13);
            this.currentUsernameLabel.TabIndex = 3;
            this.currentUsernameLabel.Text = "Current Student:";
            // 
            // userNameDataLabel
            // 
            this.userNameDataLabel.AutoSize = true;
            this.userNameDataLabel.Location = new System.Drawing.Point(671, 16);
            this.userNameDataLabel.Name = "userNameDataLabel";
            this.userNameDataLabel.Size = new System.Drawing.Size(10, 13);
            this.userNameDataLabel.TabIndex = 4;
            this.userNameDataLabel.Text = "-";
            // 
            // studentGPAUserControl1
            // 
            this.studentGPAUserControl1.Location = new System.Drawing.Point(-4, 0);
            this.studentGPAUserControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.studentGPAUserControl1.Name = "studentGPAUserControl1";
            this.studentGPAUserControl1.Size = new System.Drawing.Size(978, 575);
            this.studentGPAUserControl1.TabIndex = 0;
            // 
            // StudentDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 693);
            this.Controls.Add(this.userNameDataLabel);
            this.Controls.Add(this.currentUsernameLabel);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.logoutLinkLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StudentDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentDashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdministratorDashboard_FormClosed);
            this.tabControl1.ResumeLayout(false);
            this.courseSummaryTab.ResumeLayout(false);
            this.gradeDetailstab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel logoutLinkLabel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage courseSummaryTab;
        private System.Windows.Forms.TabPage gradeDetailstab;
        private System.Windows.Forms.Label currentUsernameLabel;
        private System.Windows.Forms.Label userNameDataLabel;
        private UserControls.StudentCourseSummaryUserControl studentCourseSummaryUserControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private UserControls.StudentRegistrationUserControl studentRegistrationUserControl1;
        private UserControls.StudentGPAUserControl studentGPAUserControl1;
    }
}