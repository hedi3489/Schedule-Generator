using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schedule_Generator
{
    internal class Day
    {
        private int dayId;
        private Lesson[] lessons;

        public int DayId
        { get { return dayId; } set { dayId = value; } }
        public Lesson[] Lessons
        { get { return lessons; } set {  lessons = value; } }

        public Day(int dayId, Lesson[] lessons)
        {
            DayId = dayId;
            Lessons = lessons;
        }
    }
}
