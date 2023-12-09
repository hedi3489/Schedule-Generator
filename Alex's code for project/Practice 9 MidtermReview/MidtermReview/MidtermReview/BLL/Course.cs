using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermReview.BLL
{
    public class Course
    {
        private string courseNumber;
        public string CourseNumber
        {
            get { return courseNumber; }
            set { courseNumber = value; }
        }

        private string courseTitle;
        public string CourseTitle
        {
            get { return courseTitle; }
            set { courseTitle = value; }
        }

        private int totalHour;
        public int TotalHour
        {
            get { return totalHour; }
            set { totalHour = value; }
        }

        
    }
}
