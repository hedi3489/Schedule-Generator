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
  public  class Teacher
    {
        public int TeacherID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string JobTitle { get; set; }

        // a method to get all the courses assigned
        public List<CourseAssignment> ListCoursesAssigned { get; set; }

        public List<Teacher> GetTeacherList()
        {
            return TeacherDA.GetRecordList();
        }
    }
}
