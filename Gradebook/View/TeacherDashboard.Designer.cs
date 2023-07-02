namespace Gradebook.View
{
    partial class TeacherDashboard
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
            this.teacherTabControl = new System.Windows.Forms.TabControl();
            this.classesTabPage = new System.Windows.Forms.TabPage();
            this.assignmentsTabPage = new System.Windows.Forms.TabPage();
            this.gradesTabPage = new System.Windows.Forms.TabPage();
            this.teacherClassesUserControl1 = new Gradebook.UserControls.TeacherClassesUserControl();
            this.teacherAddAssignmentUserControl1 = new Gradebook.UserControls.TeacherAddAssignmentUserControl();
            this.teacherGradingUserControl1 = new Gradebook.UserControls.TeacherGradingUserControl();
            this.teacherTabControl.SuspendLayout();
            this.classesTabPage.SuspendLayout();
            this.assignmentsTabPage.SuspendLayout();
            this.gradesTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // logoutLinkLabel
            // 
            this.logoutLinkLabel.AutoSize = true;
            this.logoutLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.logoutLinkLabel.Location = new System.Drawing.Point(950, 32);
            this.logoutLinkLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.logoutLinkLabel.Name = "logoutLinkLabel";
            this.logoutLinkLabel.Size = new System.Drawing.Size(59, 20);
            this.logoutLinkLabel.TabIndex = 1;
            this.logoutLinkLabel.TabStop = true;
            this.logoutLinkLabel.Text = "Logout";
            this.logoutLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.logoutLinkLabel_LinkClicked);
            // 
            // teacherTabControl
            // 
            this.teacherTabControl.Controls.Add(this.classesTabPage);
            this.teacherTabControl.Controls.Add(this.assignmentsTabPage);
            this.teacherTabControl.Controls.Add(this.gradesTabPage);
            this.teacherTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherTabControl.Location = new System.Drawing.Point(0, 55);
            this.teacherTabControl.Name = "teacherTabControl";
            this.teacherTabControl.SelectedIndex = 0;
            this.teacherTabControl.Size = new System.Drawing.Size(1058, 623);
            this.teacherTabControl.TabIndex = 2;
            // 
            // classesTabPage
            // 
            this.classesTabPage.Controls.Add(this.teacherClassesUserControl1);
            this.classesTabPage.Location = new System.Drawing.Point(4, 29);
            this.classesTabPage.Name = "classesTabPage";
            this.classesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.classesTabPage.Size = new System.Drawing.Size(1050, 590);
            this.classesTabPage.TabIndex = 0;
            this.classesTabPage.Text = "Classes";
            this.classesTabPage.UseVisualStyleBackColor = true;
            // 
            // assignmentsTabPage
            // 
            this.assignmentsTabPage.Controls.Add(this.teacherAddAssignmentUserControl1);
            this.assignmentsTabPage.Location = new System.Drawing.Point(4, 29);
            this.assignmentsTabPage.Name = "assignmentsTabPage";
            this.assignmentsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.assignmentsTabPage.Size = new System.Drawing.Size(1050, 590);
            this.assignmentsTabPage.TabIndex = 1;
            this.assignmentsTabPage.Text = "Assignments";
            this.assignmentsTabPage.UseVisualStyleBackColor = true;
            // 
            // gradesTabPage
            // 
            this.gradesTabPage.Controls.Add(this.teacherGradingUserControl1);
            this.gradesTabPage.Location = new System.Drawing.Point(4, 29);
            this.gradesTabPage.Name = "gradesTabPage";
            this.gradesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.gradesTabPage.Size = new System.Drawing.Size(1050, 590);
            this.gradesTabPage.TabIndex = 2;
            this.gradesTabPage.Text = "Grades";
            this.gradesTabPage.UseVisualStyleBackColor = true;
            // 
            // teacherClassesUserControl1
            // 
            this.teacherClassesUserControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherClassesUserControl1.Location = new System.Drawing.Point(71, -4);
            this.teacherClassesUserControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.teacherClassesUserControl1.Name = "teacherClassesUserControl1";
            this.teacherClassesUserControl1.Size = new System.Drawing.Size(934, 589);
            this.teacherClassesUserControl1.TabIndex = 0;
            // 
            // teacherAddAssignmentUserControl1
            // 
            this.teacherAddAssignmentUserControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherAddAssignmentUserControl1.Location = new System.Drawing.Point(18, -41);
            this.teacherAddAssignmentUserControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.teacherAddAssignmentUserControl1.Name = "teacherAddAssignmentUserControl1";
            this.teacherAddAssignmentUserControl1.Size = new System.Drawing.Size(999, 648);
            this.teacherAddAssignmentUserControl1.TabIndex = 0;
            // 
            // teacherGradingUserControl1
            // 
            this.teacherGradingUserControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherGradingUserControl1.Location = new System.Drawing.Point(9, -27);
            this.teacherGradingUserControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.teacherGradingUserControl1.Name = "teacherGradingUserControl1";
            this.teacherGradingUserControl1.Size = new System.Drawing.Size(1033, 672);
            this.teacherGradingUserControl1.TabIndex = 0;
            // 
            // TeacherDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 679);
            this.Controls.Add(this.teacherTabControl);
            this.Controls.Add(this.logoutLinkLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TeacherDashboard";
            this.Text = "TeacherDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdministratorDashboard_FormClosed);
            this.teacherTabControl.ResumeLayout(false);
            this.classesTabPage.ResumeLayout(false);
            this.assignmentsTabPage.ResumeLayout(false);
            this.gradesTabPage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel logoutLinkLabel;
        private System.Windows.Forms.TabControl teacherTabControl;
        private System.Windows.Forms.TabPage classesTabPage;
        private System.Windows.Forms.TabPage assignmentsTabPage;
        private System.Windows.Forms.TabPage gradesTabPage;
        private UserControls.TeacherClassesUserControl teacherClassesUserControl1;
        private UserControls.TeacherAddAssignmentUserControl teacherAddAssignmentUserControl1;
        private UserControls.TeacherGradingUserControl teacherGradingUserControl1;
    }
}