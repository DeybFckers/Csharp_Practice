using System;

namespace constructors
{
    class StudentConstructors
    {
        public string firstName;
        public string lastName;
        public int grade;
        public char section;
        public StudentConstructors(string firstName, string lastName, int grade, char section)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.grade = grade;
            this.section = section;

            Console.WriteLine("Student Created");
            Console.WriteLine(firstName + " " + lastName);
            Console.WriteLine(grade + " - " + section);
        }
    }
}