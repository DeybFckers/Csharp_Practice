using System;

namespace objectmethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Character c = new Character("David", "Hello World", 100, 100, 100);
            Console.WriteLine(c.introduce());
            Console.WriteLine(c.sayDialog());
            c.checkStats();

            Console.WriteLine("----- Challenge -----");

            Console.Write("First Name: ");
            string firstName = Console.ReadLine();
            Console.Write("Last Name: ");
            string lastName = Console.ReadLine();
            Console.Write("Course: ");
            string course = Console.ReadLine();
            Console.Write("Section: ");
            string section = Console.ReadLine();
            Console.Write("Year: ");
            float year = Convert.ToSingle(Console.ReadLine());
            Console.Write("Mid Term Grade: ");
            float midtermGrade = Convert.ToSingle(Console.ReadLine());
            Console.Write("Final Grade: ");
            float finalGrade = Convert.ToSingle(Console.ReadLine());

            Students s = new Students(firstName, lastName, course, section, year, midtermGrade, finalGrade);
            Console.WriteLine("Information: " + s.introduceSelf());
            s.evaluateGrade();
            
        }
    }
}