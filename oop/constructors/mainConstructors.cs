using System;

namespace constructors
{
    class MainConstructors
    {
        static void Main(string[] args)
        {
            ProductConstructors pc = new ProductConstructors("Milk", 50);

            Console.WriteLine("Product Name: " + pc.name);
            Console.WriteLine("Product Name: " + pc.price);


            //Challenge

            Console.Write("First Name: ");
            string firstName = Console.ReadLine();

            Console.Write("Last Name: ");
            string lastName = Console.ReadLine();

            Console.Write("Grade: ");
            int grade = Convert.ToInt32(Console.ReadLine());

            Console.Write("Section: ");
            char section = (char) Console.Read();

            StudentConstructors sc = new StudentConstructors(
                firstName,
                lastName,
                grade,
                section
            );
           
        }
    }
}