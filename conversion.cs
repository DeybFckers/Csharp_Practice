using System;
using System.Threading.Tasks;

class Conversion
{
    public static async Task Main(string[] args)
    {
        //implicit casting lowest value to highest
        //char -> int -> long -> float -> double
        int myInt = 10;
        double myDouble = myInt;

        char myChar = 'B';
        int asciiCode = myChar;

        Console.WriteLine(myChar);
        Console.WriteLine(asciiCode);

        //explicit casting highest to lowest
        //double -> float -> long -> int -> char
        //but you need to cast the variable
        int asciiCode2 = 66;
                       //cast
        char myChar2 = (char) asciiCode2;
        Console.WriteLine(myChar2);

        double myDouble2 = 236.75;
                     //cast
        int myInt2 = (int) myDouble2;
        Console.WriteLine(myInt2);

        String x = "5";
        int y = Convert.ToInt32(x);

        Console.WriteLine(y + 5);

        String xx;
        String cc;

        Console.Write("Enter first Number: ");
        xx = Console.ReadLine();
        int yy = Convert.ToInt32(xx);
        Console.Write("Enter Second Number: ");
        cc = Console.ReadLine();
        int vv = Convert.ToInt32(cc);

        Console.WriteLine("Sum: "+ (yy + vv));
    }
}