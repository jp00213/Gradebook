﻿using Gradebook.Controller;
using Gradebook.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gradebook.UserControls
{
    public partial class TeacherClassesUserControl : UserControl
    {
        private TeacherController _teacherController;
        private CourseController _courseController;
        private List<Course> _pastCourses;
        private List<Course> _futureCourses;
        private int _semesterID;

        /// <summary>
        /// Constructor for teacher controller
        /// </summary>
        public TeacherClassesUserControl()
        {
            InitializeComponent();
            this._teacherController = new TeacherController();
            this._courseController = new CourseController();
            this._futureCourses = new List<Course>();
            this._pastCourses = new List<Course>();
            this._semesterID= 0;
            this.LoadDataGridViews();
        }

        private void LoadDataGridViews()
        {
            this.currentClassDataGridView.DataSource = this._courseController.GetCoursesByTeacherIDYearAndSemester(2, this.GetCurrentSemester(), this.GetCurrentYear());
            this.pastClasseseDataGridView.DataSource = this.DeterminePastClasses();
            this.futureClassesDataGridView.DataSource = this.DetermineFutureClasses();
        }

        private int GetCurrentYear()
        {
            int year = DateTime.Now.Year;
            return year;
        }

        private string GetCurrentSemester()
        {
            string semester;

            if (DateTime.Now.Month <= 4)
            {
                semester = "Spring";
            } else if (DateTime.Now.Month > 4 && DateTime.Now.Month < 8) 
            {
                semester = "Summer";
            } else
            {
                semester = "Fall";
            }

            return semester;
        }

        private int GetCurrentSemesterID(string semester)
        {
            string currentSemester = semester;
            switch (currentSemester)
            {
                case "Spring":
                    this._semesterID = 1; break;
                case "Summer":
                    this._semesterID = 2; break;
                case "Fall":
                    this._semesterID = 3; break;
            }
            return this._semesterID;
        }


        private List<Course> DeterminePastClasses()
        {
            List<Course> allCourses = this._courseController.GetCourseList();

            foreach (Course course in allCourses)
            {
                if (course.Year < DateTime.Now.Year)
                {
                    this._pastCourses.Add(course);
                }

                if (course.Year == DateTime.Now.Year && course.Semester != this.GetCurrentSemester() && this.GetCurrentSemesterID(course.Semester) < this.GetCurrentSemesterID(this.GetCurrentSemester()))
                {
                    this._pastCourses.Add(course);
                }
            } 

            return this._pastCourses;
        }

        private List<Course> DetermineFutureClasses()
        {
            this.GetCurrentSemesterID(this.GetCurrentSemester());
            List<Course> allCourses = this._courseController.GetCourseList();

            foreach (Course course in allCourses)
            {
                if (course.Year > DateTime.Now.Year)
                {
                    this._futureCourses.Add(course);
                }

                if (course.Year == DateTime.Now.Year && course.Semester != this.GetCurrentSemester() && this.GetCurrentSemesterID(course.Semester) > this.GetCurrentSemesterID(this.GetCurrentSemester()))
                {
                    this._futureCourses.Add(course);
                }
            }

            return this._futureCourses;
        }

    }
}
