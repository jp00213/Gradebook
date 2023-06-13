namespace Gradebook.View
{
    partial class AdministratorTeachers
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
            this.adminTeacherTabControl = new System.Windows.Forms.TabControl();
            this.addTeacherTabPage = new System.Windows.Forms.TabPage();
            this.viewTeacherTabPage = new System.Windows.Forms.TabPage();
            this.updateTeacherTabPage = new System.Windows.Forms.TabPage();
            this.adminTeacherTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // adminTeacherTabControl
            // 
            this.adminTeacherTabControl.Controls.Add(this.addTeacherTabPage);
            this.adminTeacherTabControl.Controls.Add(this.viewTeacherTabPage);
            this.adminTeacherTabControl.Controls.Add(this.updateTeacherTabPage);
            this.adminTeacherTabControl.Location = new System.Drawing.Point(-4, 61);
            this.adminTeacherTabControl.Name = "adminTeacherTabControl";
            this.adminTeacherTabControl.SelectedIndex = 0;
            this.adminTeacherTabControl.Size = new System.Drawing.Size(995, 565);
            this.adminTeacherTabControl.TabIndex = 0;
            // 
            // addTeacherTabPage
            // 
            this.addTeacherTabPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTeacherTabPage.Location = new System.Drawing.Point(4, 22);
            this.addTeacherTabPage.Name = "addTeacherTabPage";
            this.addTeacherTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.addTeacherTabPage.Size = new System.Drawing.Size(987, 539);
            this.addTeacherTabPage.TabIndex = 0;
            this.addTeacherTabPage.Text = "Add Teacher";
            this.addTeacherTabPage.UseVisualStyleBackColor = true;
            // 
            // viewTeacherTabPage
            // 
            this.viewTeacherTabPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewTeacherTabPage.Location = new System.Drawing.Point(4, 22);
            this.viewTeacherTabPage.Name = "viewTeacherTabPage";
            this.viewTeacherTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.viewTeacherTabPage.Size = new System.Drawing.Size(987, 539);
            this.viewTeacherTabPage.TabIndex = 1;
            this.viewTeacherTabPage.Text = "View Teacher";
            this.viewTeacherTabPage.UseVisualStyleBackColor = true;
            // 
            // updateTeacherTabPage
            // 
            this.updateTeacherTabPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateTeacherTabPage.Location = new System.Drawing.Point(4, 22);
            this.updateTeacherTabPage.Name = "updateTeacherTabPage";
            this.updateTeacherTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.updateTeacherTabPage.Size = new System.Drawing.Size(987, 539);
            this.updateTeacherTabPage.TabIndex = 2;
            this.updateTeacherTabPage.Text = "Update Teacher";
            this.updateTeacherTabPage.UseVisualStyleBackColor = true;
            // 
            // AdministratorTeachers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 626);
            this.Controls.Add(this.adminTeacherTabControl);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdministratorTeachers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdministratorTeachers";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdministratorTeachers_FormClosed);
            this.adminTeacherTabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl adminTeacherTabControl;
        private System.Windows.Forms.TabPage addTeacherTabPage;
        private System.Windows.Forms.TabPage viewTeacherTabPage;
        private System.Windows.Forms.TabPage updateTeacherTabPage;
    }
}