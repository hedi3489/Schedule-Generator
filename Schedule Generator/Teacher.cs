using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Schedule_Generator
{
    internal class Teacher
    {
        private int teacherId; 
        private string firstName;
        private string lastName;
        private Duration[] availability;
        public int TeacherId
        { get { return teacherId; } set { teacherId = value; } }
        public string FirstName
        { get { return firstName; } set { firstName = value; } }
        public string LastName
        { get { return lastName; } set { lastName = value; } }
        public Duration[] Availability
        { get { return availability; } set { availability = value; } }

        public Teacher(int teacherId, string firstName, string lastName, Duration[] availability)
        {
            TeacherId = teacherId;
            FirstName = firstName;
            LastName = lastName;
            Availability = availability;
        }
    }
}
