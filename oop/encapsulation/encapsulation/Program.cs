using System;
using System.Data;

namespace encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User(999, "sdptDavid", "David", "SDPT");

            Console.WriteLine(user.FullName);

            person person = new person(1, "David");


            person.personName = "Alenere";

            Console.WriteLine(person.personName);
            
            
        }
    }
}