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
            this.viewStudentTabPage = new System.Windows.Forms.TabPage();
            this.updateStudentTabPage = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.addStudentUserControl1 = new Gradebook.UserControls.AddStudentUserControl();
            this.findLastUserName1 = new Gradebook.UserControls.FindLastUserName();
            this.administratorStudentTabControl.SuspendLayout();
            this.addStudentTabPage.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // administratorStudentTabControl
            // 
            this.administratorStudentTabControl.Controls.Add(this.addStudentTabPage);
            this.administratorStudentTabControl.Controls.Add(this.viewStudentTabPage);
            this.administratorStudentTabControl.Controls.Add(this.updateStudentTabPage);
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
            // viewStudentTabPage
            // 
            this.viewStudentTabPage.Location = new System.Drawing.Point(4, 22);
            this.viewStudentTabPage.Name = "viewStudentTabPage";
            this.viewStudentTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.viewStudentTabPage.Size = new System.Drawing.Size(986, 620);
            this.viewStudentTabPage.TabIndex = 1;
            this.viewStudentTabPage.Text = "View Student";
            this.viewStudentTabPage.UseVisualStyleBackColor = true;
            // 
            // updateStudentTabPage
            // 
            this.updateStudentTabPage.Location = new System.Drawing.Point(4, 22);
            this.updateStudentTabPage.Name = "updateStudentTabPage";
            this.updateStudentTabPage.Size = new System.Drawing.Size(986, 620);
            this.updateStudentTabPage.TabIndex = 2;
            this.updateStudentTabPage.Text = "Update Student";
            this.updateStudentTabPage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.52631F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.47368F));
            this.tableLayoutPanel1.Controls.Add(this.addStudentUserControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.findLastUserName1, 1, 0);
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
            this.addStudentUserControl1.Location = new System.Drawing.Point(3, 3);
            this.addStudentUserControl1.Name = "addStudentUserControl1";
            this.addStudentUserControl1.Size = new System.Drawing.Size(750, 539);
            this.addStudentUserControl1.TabIndex = 0;
            // 
            // findLastUserName1
            // 
            this.findLastUserName1.Location = new System.Drawing.Point(759, 3);
            this.findLastUserName1.Name = "findLastUserName1";
            this.findLastUserName1.Size = new System.Drawing.Size(202, 402);
            this.findLastUserName1.TabIndex = 1;
            // 
            // AdministratorStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 693);
            this.Controls.Add(this.administratorStudentTabControl);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdministratorStudents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdministratorStudents";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdministratorStudents_FormClosed);
            this.administratorStudentTabControl.ResumeLayout(false);
            this.addStudentTabPage.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl administratorStudentTabControl;
        private System.Windows.Forms.TabPage addStudentTabPage;
        private System.Windows.Forms.TabPage viewStudentTabPage;
        private System.Windows.Forms.TabPage updateStudentTabPage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private UserControls.AddStudentUserControl addStudentUserControl1;
        private UserControls.FindLastUserName findLastUserName1;
    }
}