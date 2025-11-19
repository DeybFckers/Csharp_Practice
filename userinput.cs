using System;

class UserInput
{
    public static void Main(string[] arg)
    {
        String name;
        Console.Write("Enter your name: ");
        name = Console.ReadLine();
        Console.WriteLine("Your name is: " + name);

        //char userinput
        char letter;
        Console.Write("Enter your sex:");
        //you need to put "(char)" before Console.Read() because it leads to a asciiCode or error
        letter = (char) Console.Read();
        Console.WriteLine("Your Sex is:" + letter);
        //alternative way instead of putting (char)
        Console.WriteLine("Press a letter: ");
        letter = Console.ReadKey().KeyChar;
        Console.WriteLine("\nYou Press a letter: " +letter);

        /*
        Sentence builder Challenge
        Hi My name is DeybFckers
        I'am From Mindanao
        I study in Youtube
        */

        String name1;
        String place;
        String platform;

        Console.Write("Enter your name: ");
        name1 = Console.ReadLine();
        
        Console.Write("Enter your place: ");
        place = Console.ReadLine();
    
        Console.Write("Where did you study?: ");
        platform = Console.ReadLine();

        Console.WriteLine("Hi my name is "+name1);
        Console.WriteLine("I'am From "+place);
        Console.WriteLine("I study in "+ platform);
    }
}