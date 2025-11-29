using System;
using static System.Collections.Specialized.BitVector32;

namespace ArrayOfObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees = new Employee[5];
            employees[0] = new Employee("David", "Solutions", "SDPT", "Tutorialist", 1000);
            employees[1] = new Employee("Alenere", "Solutions", "SDPT", "Tutorialist", 1000);

            employees[0].introduceSelf();
            employees[1].introduceSelf();

            //foreach (Employee employee in employees)
            //{
            //    employee.introduceSelf();
            //}

            Console.WriteLine(employees[0].firstName);
            Console.WriteLine(employees[1].firstName);

            Console.WriteLine("--- With abstract and polymorphism ---");

            Animal[] animals = new Animal[5];
            animals[0] = new Pig();
            animals[1] = new Dog();
            animals[2] = new Dog();
            animals[3] = new Pig();
            animals[4] = new Pig();

            for(int i = 0; i< animals.Length; i++)
            {
                animals[i].makeSound();
            }

            Console.WriteLine("--- Student Registration ---");

            Console.Write("Student Count: ");
            int count = Convert.ToInt32(Console.ReadLine());
            Student[] students = new Student[count];

            for (int i = 0; i < students.Length; i++)
            {
                    
                Console.Write("Enter your First Name: ");
                string firstName = Console.ReadLine();

                Console.Write("Enter your Last Name: ");
                string lastName = Console.ReadLine();

                Console.Write("Enter your Year: ");
                int year = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter your Course: ");
                string course = Console.ReadLine();

                Console.Write("Enter your Section: ");
                string section = Console.ReadLine();

                
                students[i] = new Student(firstName, lastName, year, course, section);

            }
            Console.WriteLine("---Student Records---");
            Console.WriteLine(" ");
            foreach (Student student in students)
            {
                student.introduceYourSelf();
            }

        }
    }

    class Employee
    {
        public String firstName { get; set; }
        public String middleName { get; set; }
        public String lastName { get; set; }
        public String position { get; set; }
        public double salary { get; set; }

        public Employee(string firstName, string middleName, string lastName, string position, double salary)
        {
            this.firstName = firstName;
            this.middleName = middleName;
            this.lastName = lastName;
            this.position = position;
            this.salary = salary;
        }

        public void introduceSelf()
        {
            Console.WriteLine("I'am " + firstName + " " + middleName + " " + lastName);
        }
    }

    abstract class Animal
    {
       public abstract void makeSound();
    }

    class Pig : Animal
    {
        public override void makeSound()
        {
            Console.WriteLine("Oink, Oink");
        }
    }

    class Dog : Animal
    {
        public override void makeSound()
        {
            Console.WriteLine("Arf, Arf");
        }

        public void dig()
        {
            Console.WriteLine("Digging");
        }
    }

    class Student
    {
        public String firstName { get; set;}
        public String lastName { get; set; }
        public int Year { get; set; }
        public String Course { get; set;}
        public String Section {  get; set;}

        public Student(string firstName, string lastName, int year, string course, string section)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            Year = year;
            Course = course;
            Section = section;
        }

        public void introduceYourSelf()
        {
            Console.WriteLine("First Name: " + firstName);
            Console.WriteLine("Last Name: " + lastName);
            Console.WriteLine("Year: " + Year);
            Console.WriteLine("Course: " + Course);
            Console.WriteLine("Section: " + Section);
            Console.WriteLine(" ");
        }
    }
}