using System;

class Arithmetic
{
    public static void Main(string[] args)
    {
        //Arithmetic
        float x = 5;
        float y = 2;

        float sum = x + y;
        float product = x + y;
        float difference = x - y;
        float quotient = x / y;
        float remainder = x % y;

        Console.WriteLine("Sum: " + sum);
        Console.WriteLine("Product: " + product);
        Console.WriteLine("Difference: " + difference); 
        Console.WriteLine("Quotient: " + quotient);
        Console.WriteLine("Remainder: " + remainder);

        //pemdas rule
        float mid = (x + y) / 2;
        Console.WriteLine(mid);

        Console.WriteLine("----Assignment Arithmetic----");

        //Assignment Arithmetic

        int num1 = 5;
        int num2 = 10;
        
        //new variable
        int sum1 = num1 + num2;
        
        /*
        Instead of declaring new variable
        you can use this instead
        */
        num2 += num1;
        num2 *= num1;

        Console.WriteLine(num2);

        Console.WriteLine("----Average Calculator----");

        //Average Calculator
        /*
        Sample Output
        English: 95,
        Math: 92,
        Science: 93,
        Computer: 98,

        Average: 94.5,
        */

        Console.Write("English: ");
        double english = Convert.ToDouble(Console.ReadLine());

        Console.Write("Math: ");
        double math = Convert.ToDouble(Console.ReadLine());

        Console.Write("Science: ");
        double science = Convert.ToDouble(Console.ReadLine());

        Console.Write("Computer: ");
        double computer = Convert.ToDouble(Console.ReadLine());

        double Average = (english + math + science + computer) / 4;
        
        Console.WriteLine("Average: " + Average);


    }
}