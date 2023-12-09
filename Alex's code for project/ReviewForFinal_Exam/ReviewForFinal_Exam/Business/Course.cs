using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReviewForFinal_Exam.Business;
using ReviewForFinal_Exam.DataAccess;

namespace ReviewForFinal_Exam.Business
{
    [Serializable]
   public class Course
    {
        public string CourseCode { get; set; }
        public string CourseTitle { get; set; }
        public int TotalHour { get; set; }

        public List<Course> GetCourseList()
        {
            return CourseDA.GetRecordList();
        }
    }
}
