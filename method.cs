using System;
using Microsoft.VisualBasic;

class Method
{
    //continue later
    public static void Main(string[] args)
    {
        SayHi("Dave", 21);
        Sum(4, 5);
        
    }

    static void SayHi(String Name, int agee)
    {
        Console.WriteLine("Hello " + Name + " You are " + agee);
    }

    static void Sum(int num1, int num2)
    {
        Console.WriteLine(num1 + num2);
    }
}