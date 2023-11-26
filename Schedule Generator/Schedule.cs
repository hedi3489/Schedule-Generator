using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schedule_Generator
{
    internal class Schedule
    {
        private int scheduleId;
        private Day[] days;

        public int ScheduleId
        { get { return scheduleId; } set { scheduleId = value; } }
        public Day[] Days
        { get { return days; } set {  days = value; } }

        public Schedule(int scheduleId, Day[] days)
        {
            ScheduleId = scheduleId;
            Days = days;
        }
    }
}
