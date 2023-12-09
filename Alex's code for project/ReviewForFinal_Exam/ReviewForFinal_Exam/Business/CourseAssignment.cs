using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReviewForFinal_Exam.DataAccess;

namespace ReviewForFinal_Exam.Business
{
    [Serializable]
    public class CourseAssignment
    {
        public int AssignmentNumber { get; set; }
        public DateTime AssignedDate { get; set; }

        public Course Course { get; set; }
        public Teacher Teacher { get; set; }

        //constructor
        public CourseAssignment()
        {
            AssignmentNumber = 11111;
            AssignedDate = DateTime.Today;
            this.Course = new Course();
            this.Teacher = new Teacher();

        }

        // A method to assign a course to a teacher

        public void AssignCourse (CourseAssignment ca)
        {
            CourseAssignmentDA.Save(ca);
        }

        // A method to list all the courses assigned to a teacher

        public List<CourseAssignment> GetListCoursesAssigned (int teacherId)
        {
            return CourseAssignmentDA.List(teacherId);

        }
    }
}
