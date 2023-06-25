namespace Gradebook.View
{
    partial class AdministratorCourses
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
            this.backHomeButton = new System.Windows.Forms.Button();
            this.courseTabControl = new System.Windows.Forms.TabControl();
            this.createCourseTab = new System.Windows.Forms.TabPage();
            this.addNewCourseUserControl1 = new Gradebook.UserControls.AddNewCourseUserControl();
            this.registerStudentTab = new System.Windows.Forms.TabPage();
            this.administratorRegisterStudent1 = new Gradebook.UserControls.AdministratorRegisterStudent();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.administratorSearchUpdateCourse1 = new Gradebook.UserControls.AdministratorSearchUpdateCourse();
            this.courseTabControl.SuspendLayout();
            this.createCourseTab.SuspendLayout();
            this.registerStudentTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // backHomeButton
            // 
            this.backHomeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backHomeButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.backHomeButton.Location = new System.Drawing.Point(36, 24);
            this.backHomeButton.Margin = new System.Windows.Forms.Padding(4);
            this.backHomeButton.Name = "backHomeButton";
            this.backHomeButton.Size = new System.Drawing.Size(139, 37);
            this.backHomeButton.TabIndex = 2;
            this.backHomeButton.Text = "Home";
            this.backHomeButton.UseVisualStyleBackColor = true;
            this.backHomeButton.Click += new System.EventHandler(this.backHomeButton_Click);
            // 
            // courseTabControl
            // 
            this.courseTabControl.Controls.Add(this.createCourseTab);
            this.courseTabControl.Controls.Add(this.registerStudentTab);
            this.courseTabControl.Controls.Add(this.tabPage1);
            this.courseTabControl.Controls.Add(this.tabPage2);
            this.courseTabControl.Location = new System.Drawing.Point(0, 87);
            this.courseTabControl.Name = "courseTabControl";
            this.courseTabControl.SelectedIndex = 0;
            this.courseTabControl.Size = new System.Drawing.Size(1357, 589);
            this.courseTabControl.TabIndex = 3;
            // 
            // createCourseTab
            // 
            this.createCourseTab.Controls.Add(this.addNewCourseUserControl1);
            this.createCourseTab.Location = new System.Drawing.Point(4, 25);
            this.createCourseTab.Name = "createCourseTab";
            this.createCourseTab.Padding = new System.Windows.Forms.Padding(3);
            this.createCourseTab.Size = new System.Drawing.Size(1349, 560);
            this.createCourseTab.TabIndex = 0;
            this.createCourseTab.Text = "Create Course";
            this.createCourseTab.UseVisualStyleBackColor = true;
            // 
            // addNewCourseUserControl1
            // 
            this.addNewCourseUserControl1.Font = new System.Drawing.Font("Symbol", 8.25F);
            this.addNewCourseUserControl1.Location = new System.Drawing.Point(8, 6);
            this.addNewCourseUserControl1.Name = "addNewCourseUserControl1";
            this.addNewCourseUserControl1.Size = new System.Drawing.Size(1253, 643);
            this.addNewCourseUserControl1.TabIndex = 0;
            // 
            // registerStudentTab
            // 
            this.registerStudentTab.Controls.Add(this.administratorRegisterStudent1);
            this.registerStudentTab.Location = new System.Drawing.Point(4, 25);
            this.registerStudentTab.Name = "registerStudentTab";
            this.registerStudentTab.Padding = new System.Windows.Forms.Padding(3);
            this.registerStudentTab.Size = new System.Drawing.Size(1349, 560);
            this.registerStudentTab.TabIndex = 1;
            this.registerStudentTab.Text = "Register Student";
            this.registerStudentTab.UseVisualStyleBackColor = true;
            // 
            // administratorRegisterStudent1
            // 
            this.administratorRegisterStudent1.Location = new System.Drawing.Point(3, 1);
            this.administratorRegisterStudent1.Name = "administratorRegisterStudent1";
            this.administratorRegisterStudent1.Size = new System.Drawing.Size(1346, 553);
            this.administratorRegisterStudent1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.administratorSearchUpdateCourse1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1349, 560);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Search/Update Course";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1349, 560);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "View/Drop Student Registrations";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // administratorSearchUpdateCourse1
            // 
            this.administratorSearchUpdateCourse1.Location = new System.Drawing.Point(3, 0);
            this.administratorSearchUpdateCourse1.Name = "administratorSearchUpdateCourse1";
            this.administratorSearchUpdateCourse1.Size = new System.Drawing.Size(1124, 549);
            this.administratorSearchUpdateCourse1.TabIndex = 0;
            // 
            // AdministratorCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1356, 675);
            this.Controls.Add(this.courseTabControl);
            this.Controls.Add(this.backHomeButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdministratorCourses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrator Courses";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdministratorCourses_FormClosed);
            this.courseTabControl.ResumeLayout(false);
            this.createCourseTab.ResumeLayout(false);
            this.registerStudentTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backHomeButton;
        private System.Windows.Forms.TabControl courseTabControl;
        private System.Windows.Forms.TabPage createCourseTab;
        private System.Windows.Forms.TabPage registerStudentTab;
        private UserControls.AddNewCourseUserControl addNewCourseUserControl1;
        private UserControls.AdministratorRegisterStudent administratorRegisterStudent1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private UserControls.AdministratorSearchUpdateCourse administratorSearchUpdateCourse1;
    }
}