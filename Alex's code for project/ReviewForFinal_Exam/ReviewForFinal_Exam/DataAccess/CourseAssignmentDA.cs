using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReviewForFinal_Exam.Business;
using System.Runtime.Serialization.Formatters.Binary; //required for BinaryFormatter class
using System.IO;

namespace ReviewForFinal_Exam.DataAccess
{
  public static class CourseAssignmentDA
    {
        static string dir = @"";
        static string filePath = dir + "CourseAssignments.bin";

        /// <summary>
        /// This methods save a course assignment to the file CourseAssignments.bin
        /// </summary>
        /// <param name="ca"></param>
        public static void Save (CourseAssignment ca)
        {
            FileStream fs = new FileStream(filePath,FileMode.Append,FileAccess.Write);
            BinaryFormatter binF = new BinaryFormatter();
            binF.Serialize(fs, ca);
            fs.Close();

        }

        public static List<CourseAssignment> List(int tId)
        {
            List<CourseAssignment> listCA = new List<CourseAssignment>();

            FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            BinaryFormatter binF = new BinaryFormatter();

            if (File.Exists(filePath))
            {
                while (fs.Position < fs.Length)
                {
                    CourseAssignment ca = new CourseAssignment();
                    ca = (CourseAssignment)binF.Deserialize(fs);

                    if (ca.Teacher.TeacherID == tId)
                    {
                        listCA.Add(ca);
                    }

                }

            }
            fs.Close();
            return listCA;

        }


    }
}
