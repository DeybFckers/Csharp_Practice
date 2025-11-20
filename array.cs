using System;

class Array
{
    public static void Main(string[] args)
    {
        //Array
        String[] names = { "David", "Alener", "Slear",};
        
        float[] grades = { 92.5f, 93.25f, 85.75f,};

        
        //Array Values with user input
        String[] names1 = new string[5];

        Console.Write("Name 1: ");
        names1[0] = Console.ReadLine();

        Console.Write("Name 2: ");
        names1[1] = Console.ReadLine();

        foreach(var name in names1)
        {
            Console.WriteLine("List :" + name);
        }

    }
}