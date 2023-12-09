using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReviewForFinal_Exam.Business;
using System.Windows.Forms;
using System.IO;

namespace ReviewForFinal_Exam.DataAccess
{
    public static class TeacherDA
    {

        static string dir = @"";
        static string filePath = dir + "Employees.dat";
        public static List<Teacher> GetRecordList()
        {
            List<Teacher> listT = new List<Teacher>();
            StreamReader sr = new StreamReader(filePath);
            if (File.Exists(filePath))
            {
                string line = sr.ReadLine();
                MessageBox.Show(line);
                while (line != null)
                {
                    string[] fields = line.Split(',');

                    if (fields[4].ToUpper() == "Teacher".ToUpper())
                    {
                        Teacher aTeacher = new Teacher();
                        aTeacher.TeacherID = Convert.ToInt32(fields[0]);
                        aTeacher.FirstName = fields[1];
                        aTeacher.LastName = fields[2];
                        aTeacher.Email = fields[3];
                        listT.Add(aTeacher);

                    }

                    line = sr.ReadLine();
                }
            }

            else
            {
                MessageBox.Show("File not found!","Missing File");
            }
            sr.Close();
            return listT;

        }
    }
}
