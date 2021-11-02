﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S046_MyTranscript
{
    public partial class Form1 : Form
    {
        List<Course> year1Sem1;
        List<Course> year1Sem2;
        public Form1()
        {
            InitializeComponent();
            year1Sem1 = new List<Course>();
            year1Sem2 = new List<Course>();


        }

        private void AddGrade(object sender, EventArgs e)
        {
            Course newCourse = new Course();
            newCourse.CourseID = textBoxCourseID.Text;
            newCourse.CourseName = textBoxCourseName.Text;
            newCourse.CourseCredit = textBoxCourseCredit.Text;
            newCourse.Grade = textBoxCourseGrade.Text;

            switch (tabControl1.SelectedIndex) 
            {
                case 0:
                dataGridViewViewY1S1.DataSource = null;
                year1Sem1.Add(newCourse);
                dataGridViewViewY1S1.DataSource = year1Sem1;
                    break;
                case 1:
                dataGridViewViewY1S2.DataSource = null;
                year1Sem2.Add(newCourse);
                dataGridViewViewY1S2.DataSource = year1Sem2;
                    break;
            }
            
        }
    }
    class Course
    {
        public string CourseID { get; set; }
        public string CourseName { get; set; }
        public string CourseCredit { get; set; }
        public string Grade { get; set; }
    }
}
