using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filter2
{
    /// <summary>
    /// Define class for student
    /// </summary>
    class Student
    {
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int yearOfBirth { get; private set; }
        public int numberOfLanguage { get; private set; }
        public int phoneNumber { get; private set; }
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name">student name</param>
        /// <param name="surname">student surname</param>
        /// <param name="year">studen year of birth</param>
        /// <param name="languagesCount">how many language student knows</param>
        /// <param name="phone">student phone number</param>
        public Student(string name, string surname, int year, int languagesCount, int phone)
        {
            this.Name = name;
            this.Surname = surname;
            this.numberOfLanguage = languagesCount;
            this.phoneNumber = phone;
            this.yearOfBirth = year;
        }
        /// <summary>
        /// override ToString() for students
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return String.Format(" Name:{0} \n Surname:{1} \n Year of birth:{2} \n Number of languages:{3} \n Phone number:{4} \n\n", this.Name, this.Surname, this.yearOfBirth, this.numberOfLanguage, this.phoneNumber);
        }

    }
}
