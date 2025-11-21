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

        /*array in Dart
        DataTypes Variable = [Value];
        var       names = ['Stupid', 'Fucker']
        */

        Console.WriteLine("---Paired Array By Index---");
        /*Sample Output
        Index :0
        Email :slear@gmail.com
        Username :SlearMendoza
        Password :shoutoutsayo
        */

        int index;
        String[] email = { "slear@gmail.com", "David@gmail.com", "Alenere@gmail.com",};
        String[] username = { "SlearMendoza", "DavidFckers", "AlenereDog",};
        String[] password = { "shoutoutsayo", "12345", "qwerty"};

        Console.Write("Index : ");
        index = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Email : " + email[index]);
        Console.WriteLine("Username :" + username[index]);
        Console.WriteLine("Password :" + password[index]);
        
    }
}