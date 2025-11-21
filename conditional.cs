using System;

class Conditional
{
    public static void Main(string[] args)
    {
        
        int age = 18;

        if(age >= 18)
        {
            Console.WriteLine("You can register");
        }
        else
        {
            Console.WriteLine("Access Denied!");
        }

        bool isRegister = false;

        if (isRegister)
        {
            Console.WriteLine("you cannot register");
        }

        Console.WriteLine(age >= 18);
        //user input with if else
        Console.Write("Enter Age: ");
        int age1 = Convert.ToInt32(Console.ReadLine());
        
        if(age1 >= 18)
        {
            Console.WriteLine("Welcome");
        }
        else if (age1 >= 13)
        {
            Console.WriteLine("you need a parent consent");
        }
        else
        {
            Console.WriteLine("Access Denied");
        }

        Console.Write("Enter your password: ");
        string pword = Console.ReadLine();

        /*you can't use StringComparison.InvariantCultureIgnoreCase
        if you use a retional operator(==, !=)*/
        if(pword.Equals("admin123",StringComparison.InvariantCultureIgnoreCase))
        {
            Console.WriteLine("Login Successfully");
        }
        else
        {
            Console.WriteLine("Wrong Crendentials");
        }

        Console.WriteLine("--Grade Average Program--");
        /*Grade Average Program
        Above 100 - Invalid Grade
        98 to 100 - With Highest Honor
        95 to 97.99 - With High Honor
        90 to 94.99 - With Honors
        75 to 89.99 -Passed
        Below 75 - Failed*/

        Console.Write("Math : ");
        double math = Convert.ToDouble(Console.ReadLine());

        Console.Write("Science :");
        double science = Convert.ToDouble(Console.ReadLine());

        Console.Write("English : ");
        double english = Convert.ToDouble(Console.ReadLine());

        Console.Write("Computer : ");
        double computer = Convert.ToDouble(Console.ReadLine());

        double Average = (math + science + english + computer) / 4;

        if(Average > 100)
        {
            Console.WriteLine("Invalid Grade :" + Average);
        }
        else if(Average >= 98 )
        {
            Console.WriteLine("With Highest Honor :" + Average);
        }else if(Average >= 95)
        {
            Console.WriteLine("With High Honor :" + Average);
        }else if(Average >= 90 )
        {
            Console.WriteLine("With Honor :" + Average);
        }else if(Average >= 75 )
        {
            Console.WriteLine("Passed :" + Average);
        }
        else
        {
            Console.WriteLine("Failed :" + Average);
        }
    }
}