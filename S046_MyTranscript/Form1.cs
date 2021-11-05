using System;
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
        List<Course> year2Sem1;
        List<Course> year2Sem2;
        List<Course> year2Sem3;
        List<Course> year3Sem1;
        List<Course> year3Sem2;
        List<Course> year4Sem1;
        List<Course> year4Sem2;
        public Form1()
        {
            InitializeComponent();
            year1Sem1 = new List<Course>();
            year1Sem2 = new List<Course>();
            year2Sem1 = new List<Course>();
            year2Sem2 = new List<Course>();
            year2Sem3 = new List<Course>();
            year3Sem1 = new List<Course>();
            year3Sem2 = new List<Course>();
            year4Sem1 = new List<Course>();
            year4Sem2 = new List<Course>();

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
                case 2:
                    dataGridViewViewY2S1.DataSource = null;
                    year2Sem1.Add(newCourse);
                    dataGridViewViewY2S1.DataSource = year2Sem1;
                    break;
                case 3:
                    dataGridViewViewY2S2.DataSource = null;
                    year2Sem2.Add(newCourse);
                    dataGridViewViewY2S2.DataSource = year2Sem2;
                    break;
                case 4:
                    dataGridViewViewY2S3.DataSource = null;
                    year2Sem3.Add(newCourse);
                    dataGridViewViewY2S3.DataSource = year2Sem3;
                    break;
                case 5:
                    dataGridViewViewY3S1.DataSource = null;
                    year3Sem1.Add(newCourse);
                    dataGridViewViewY3S1.DataSource = year3Sem1;
                    break;
                case 6:
                    dataGridViewViewY3S2.DataSource = null;
                    year3Sem2.Add(newCourse);
                    dataGridViewViewY3S2.DataSource = year3Sem2;
                    break;
                case 7:
                    dataGridViewViewY4S1.DataSource = null;
                    year4Sem1.Add(newCourse);
                    dataGridViewViewY4S1.DataSource = year4Sem1;
                    break;
                case 8:
                    dataGridViewViewY4S2.DataSource = null;
                    year4Sem2.Add(newCourse);
                    dataGridViewViewY4S2.DataSource = year4Sem2;
                    break;
            }
            
        }

        private void SaveFile(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            int counter;
            //// prepare data

            // write header
            sb.AppendLine(labelUniversityName.Text);
            sb.AppendLine(labelFacultyName.Text);


            // Year 1 Semester 1
            if (year1Sem1.Count > 0) //ปี1
            {
                sb.AppendLine("");
                sb.AppendLine("Year 1 Semester 1");
                sb.AppendLine("No, Course ID, Course Name, Credit, Grade");
                counter = 1;
                foreach (var item in year1Sem1)
                {
                    sb.AppendLine(counter.ToString() + ", " + item.ToString());
                    counter++;
                }
            }
            // Year 1 Semester 2
            if (year1Sem2.Count > 0) 
            {
                sb.AppendLine("");
                sb.AppendLine("Year 1 Semester 2");
                sb.AppendLine("No, Course ID, Course Name, Credit, Grade");
                counter = 1;
                foreach (var item in year1Sem2)
                {
                    sb.AppendLine(counter.ToString() + ", " + item.ToString());
                    counter++;
                }
            }
//////////////////////////////////////////////////////////////////////////////////////////
            if (year2Sem1.Count > 0) //ปี2
            {
                sb.AppendLine("");
                sb.AppendLine("Year 2 Semester 1");
                sb.AppendLine("No, Course ID, Course Name, Credit, Grade");
                counter = 1;
                foreach (var item in year2Sem1)
                {
                    sb.AppendLine(counter.ToString() + ", " + item.ToString());
                    counter++;
                }
            }
            if (year2Sem2.Count > 0) 
            {
                sb.AppendLine("");
                sb.AppendLine("Year 2 Semester 2");
                sb.AppendLine("No, Course ID, Course Name, Credit, Grade");
                counter = 1;
                foreach (var item in year2Sem2)
                {
                    sb.AppendLine(counter.ToString() + ", " + item.ToString());
                    counter++;
                }
            }
            if (year2Sem3.Count > 0) 
            {
                sb.AppendLine("");
                sb.AppendLine("Year 2 Semester 3");
                sb.AppendLine("No, Course ID, Course Name, Credit, Grade");
                counter = 1;
                foreach (var item in year2Sem3)
                {
                    sb.AppendLine(counter.ToString() + ", " + item.ToString());
                    counter++;
                }
            }
//////////////////////////////////////////////////////////////////////////////////////////
            if (year3Sem1.Count > 0) //ปี3
            {
                sb.AppendLine("");
                sb.AppendLine("Year 3 Semester 1");
                sb.AppendLine("No, Course ID, Course Name, Credit, Grade");
                counter = 1;
                foreach (var item in year3Sem1)
                {
                    sb.AppendLine(counter.ToString() + ", " + item.ToString());
                    counter++;
                }
            }
            if (year3Sem2.Count > 0) 
            {
                sb.AppendLine("");
                sb.AppendLine("Year 3 Semester 2");
                sb.AppendLine("No, Course ID, Course Name, Credit, Grade");
                counter = 1;
                foreach (var item in year3Sem2)
                {
                    sb.AppendLine(counter.ToString() + ", " + item.ToString());
                    counter++;
                }
            }
            //////////////////////////////////////////////////////////////////////////////////////////
            if (year4Sem1.Count > 0) // ปี4
            {
                sb.AppendLine("");
                sb.AppendLine("Year 4 Semester 1");
                sb.AppendLine("No, Course ID, Course Name, Credit, Grade");
                counter = 1;
                foreach (var item in year4Sem1)
                {
                    sb.AppendLine(counter.ToString() + ", " + item.ToString());
                    counter++;
                }
            }
            if (year4Sem2.Count > 0) 
            {
                sb.AppendLine("");
                sb.AppendLine("Year 4 Semester 2");
                sb.AppendLine("No, Course ID, Course Name, Credit, Grade");
                counter = 1;
                foreach (var item in year4Sem2)
                {
                    sb.AppendLine(counter.ToString() + ", " + item.ToString());
                    counter++;
                }
            }


            string filename = "mygrade.csv";
            WriteToFile(filename, sb);
        }
        private void WriteToFile(string filename, StringBuilder sb)
        {
            Console.WriteLine(sb.ToString());
            System.IO.File.WriteAllText(filename, sb.ToString());
        }
    }
    class Course
    {
        public string CourseID { get; set; }
        public string CourseName { get; set; }
        public string CourseCredit { get; set; }
        public string Grade { get; set; }
        public override string ToString()
        {
            return CourseID + "," + CourseName + "," + CourseCredit + "," + Grade;
        }
    }
    
}
