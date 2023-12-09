using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermReview.BLL
{
    public class Teacher
    {
        private int teacherId;
        public int TeacherId
        {
            get { return teacherId; }
            set { teacherId = value; }
        }

        private string firstName;
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        private string lastName;
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        //default contructor
        public Teacher()
        {
            teacherId = 1234;
            firstName = "Mary";
            lastName = "Brown";
        }
        //parameterized contructor

        public Teacher( int tId, string fName, string lName)
        {
            teacherId = tId;
            firstName = fName;
            lastName = lName;
        }
        public Teacher SearchByTeacherId(List<Teacher> listT, int tId)
        {
            Teacher aTeacher = new Teacher();
            foreach (Teacher t  in listT)
            {
                if (t.TeacherId == tId )
                {
                    aTeacher.TeacherId = t.TeacherId;
                    aTeacher.FirstName = t.FirstName;
                    aTeacher.LastName = t.LastName;
                    return aTeacher;
                }
                
            }
            return null;
            //aTeacher = null;
            //return aTeacher;

        }

    }
}
