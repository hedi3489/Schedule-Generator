using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schedule_Generator
{
    internal class Course
    {
        private int courseId;
        private int teacherId;
        private string courseName;
        private int roomNo;

        public int CourseId 
        { get { return courseId; } set { courseId = value; } }
        public int TeacherId
        { get { return teacherId; } set { teacherId = value; } }
        public string CourseName
        { get { return courseName; } set { courseName = value; } }
        public int RoomNo
        { get { return roomNo; } set {  roomNo = value; } }

        public Course(int courseId, int teacherId, string courseName, int roomNo)
        {
            CourseId = courseId;
            TeacherId = teacherId;
            CourseName = courseName;
            RoomNo = roomNo;
        }
    }
}
