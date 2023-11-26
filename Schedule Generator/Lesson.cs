using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schedule_Generator
{
    internal class Lesson
    {
        private int lessonId;
        private int courseId;
        private Duration period;

        public int LessonId
        { get { return lessonId; } set { lessonId = value; } }
        public int CourseId 
        { get {  return courseId; } set {  courseId = value; } }
        public Duration Period
        { get { return period; } set {  period = value; } }

        public Lesson(int lessonId, int courseId, Duration period)
        {
            LessonId = lessonId;
            CourseId = courseId;
            Period = period;
        }
    }
}
