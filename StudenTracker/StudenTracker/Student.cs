using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTracker
{
    public class Student
    {
        private int studentID;
        private string firstName;
        private string lastName;
        private string field;
        private string date;
        private string age;

        public Student()
        {

        }

        public int StudentID
        {
            get { return studentID; }
            set { studentID = value; }
        }
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public string Field
        {
            get { return field; }
            set { field = value; }
        }
        public string Date
        {
            get { return date; }
            set { date = value; }
        }
        public string Age
        {
            get { return age; }
            set { age = value; }
        }

    }
}
