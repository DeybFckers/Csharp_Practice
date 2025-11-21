using System;

class Swtich
{
    public static void Main(string[] args)
    {
        Console.Write("Grade : ");
        char grade = (char) Console.Read();

        switch (grade)
        {
            case 'A':
            Console.WriteLine("Outstanding");
            break;
            case 'B':
            Console.WriteLine("Excellent");
            break;
            case 'C':
            Console.WriteLine("Satisfactory");
            break;
            default:
            Console.WriteLine("Invalid Grade");
            break;
        }

        Console.Write("Number Word: ");
        String numberWord = Console.ReadLine();

        switch (numberWord)
        {
            case "one":
            Console.WriteLine(1);
            break;
            case "two":
            Console.WriteLine(2);
            break;
            case "three":
            Console.WriteLine(3);
            break;
            
        }

        /*Date Formatter
        Sample Output
        Month: 1
        Date: 13
        Year: 2020
        January 13, 2020
        */

        Console.Write("Month: ");
        int month = Convert.ToInt32(Console.ReadLine());
        Console.Write("Date: ");
        int date = Convert.ToInt32(Console.ReadLine());
        if(date > 32)
        {
            Console.WriteLine("Input an valid Date");
            //it means it will stop the program
            return;
            
        }
        Console.Write("Year: ");
        int year = Convert.ToInt32(Console.ReadLine());

        String monthWord;

        switch (month)
        {
            case 1:
            monthWord = "January";
            break;
            default:
            monthWord = "";
            Console.WriteLine("Invalid Input");
            return;
        }

        if(monthWord != "")
        {
            Console.WriteLine(monthWord + " " + date + "," + year);
        }

    }
}