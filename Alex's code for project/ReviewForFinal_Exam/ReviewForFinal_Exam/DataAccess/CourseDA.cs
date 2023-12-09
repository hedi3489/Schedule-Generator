using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReviewForFinal_Exam.Business;
using System.IO;
using System.Windows.Forms;

namespace ReviewForFinal_Exam.DataAccess
{
    public static  class CourseDA
    {

        static string dir = @"";
        static string filePath = dir + "Courses.dat";
        public static List<Course> GetRecordList()
        {
            List<Course> listC = new List<Course>();

            StreamReader sr = new StreamReader(filePath);
            if (File.Exists(filePath))
            {
                string line = sr.ReadLine();
                while (line != null)
                {
                    string[] fields = line.Split(',');
                    Course course = new Course();
                    course.CourseCode = fields[0];
                    course.CourseTitle = fields[1];
                    course.TotalHour = Convert.ToInt32(fields[2]);
                    listC.Add(course);
                    line = sr.ReadLine();
                }
            }

            else
            {
                MessageBox.Show("File not found!", "Missing File");
            }
            sr.Close();
            return listC;

        }

    }
}
