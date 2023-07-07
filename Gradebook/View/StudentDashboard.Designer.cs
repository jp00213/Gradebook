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
            this.tabControl1.SuspendLayout();
            this.courseSummaryTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // logoutLinkLabel
            // 
            this.logoutLinkLabel.AutoSize = true;
            this.logoutLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.logoutLinkLabel.Location = new System.Drawing.Point(1141, 20);
            this.logoutLinkLabel.Name = "logoutLinkLabel";
            this.logoutLinkLabel.Size = new System.Drawing.Size(72, 25);
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
            this.tabControl1.Location = new System.Drawing.Point(3, 48);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1325, 801);
            this.tabControl1.TabIndex = 2;
            // 
            // courseSummaryTab
            // 
            this.courseSummaryTab.Controls.Add(this.studentCourseSummaryUserControl1);
            this.courseSummaryTab.Location = new System.Drawing.Point(4, 29);
            this.courseSummaryTab.Margin = new System.Windows.Forms.Padding(4);
            this.courseSummaryTab.Name = "courseSummaryTab";
            this.courseSummaryTab.Padding = new System.Windows.Forms.Padding(4);
            this.courseSummaryTab.Size = new System.Drawing.Size(1317, 768);
            this.courseSummaryTab.TabIndex = 0;
            this.courseSummaryTab.Text = "Grade Summary";
            this.courseSummaryTab.UseVisualStyleBackColor = true;
            // 
            // studentCourseSummaryUserControl1
            // 
            this.studentCourseSummaryUserControl1.Location = new System.Drawing.Point(12, 7);
            this.studentCourseSummaryUserControl1.Margin = new System.Windows.Forms.Padding(5);
            this.studentCourseSummaryUserControl1.Name = "studentCourseSummaryUserControl1";
            this.studentCourseSummaryUserControl1.Size = new System.Drawing.Size(1283, 742);
            this.studentCourseSummaryUserControl1.TabIndex = 0;
            // 
            // gradeDetailstab
            // 
            this.gradeDetailstab.Location = new System.Drawing.Point(4, 29);
            this.gradeDetailstab.Margin = new System.Windows.Forms.Padding(4);
            this.gradeDetailstab.Name = "gradeDetailstab";
            this.gradeDetailstab.Padding = new System.Windows.Forms.Padding(4);
            this.gradeDetailstab.Size = new System.Drawing.Size(1317, 768);
            this.gradeDetailstab.TabIndex = 1;
            this.gradeDetailstab.Text = "Grade Details";
            this.gradeDetailstab.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.studentRegistrationUserControl1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1317, 768);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Registration";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // studentRegistrationUserControl1
            // 
            this.studentRegistrationUserControl1.Location = new System.Drawing.Point(16, 7);
            this.studentRegistrationUserControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.studentRegistrationUserControl1.Name = "studentRegistrationUserControl1";
            this.studentRegistrationUserControl1.Size = new System.Drawing.Size(1294, 754);
            this.studentRegistrationUserControl1.TabIndex = 0;
            // 
            // currentUsernameLabel
            // 
            this.currentUsernameLabel.AutoSize = true;
            this.currentUsernameLabel.Location = new System.Drawing.Point(763, 20);
            this.currentUsernameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.currentUsernameLabel.Name = "currentUsernameLabel";
            this.currentUsernameLabel.Size = new System.Drawing.Size(100, 16);
            this.currentUsernameLabel.TabIndex = 3;
            this.currentUsernameLabel.Text = "Current Student:";
            // 
            // userNameDataLabel
            // 
            this.userNameDataLabel.AutoSize = true;
            this.userNameDataLabel.Location = new System.Drawing.Point(895, 20);
            this.userNameDataLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userNameDataLabel.Name = "userNameDataLabel";
            this.userNameDataLabel.Size = new System.Drawing.Size(11, 16);
            this.userNameDataLabel.TabIndex = 4;
            this.userNameDataLabel.Text = "-";
            // 
            // StudentDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1329, 853);
            this.Controls.Add(this.userNameDataLabel);
            this.Controls.Add(this.currentUsernameLabel);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.logoutLinkLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StudentDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentDashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdministratorDashboard_FormClosed);
            this.tabControl1.ResumeLayout(false);
            this.courseSummaryTab.ResumeLayout(false);
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
    }
}