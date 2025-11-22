using System;

class ForEach
{
    static void Main(string[] args)
    {
        int[] numbers = { 3, 4, 5, 6, 7, 8 };

        int sum = 0;

        foreach(int number in numbers)
        {
            sum += number;
            Console.WriteLine(sum); 
        }

         String[,] users =
        {           //0       //1
         /*0*/   { "David", "david123" },
         /*1*/   { "Alenere", "alenere123" },
         /*2*/   { "Hezel", "hezel123" },
         /*3*/   { "Jaymar", "jaymar123" },
        };

        int i = 1;

        foreach(String info in users)
        {
            Console.WriteLine(info);
            if(i % 3 == 0)
            {
                Console.WriteLine();
            }
            i++;
        }
    }
}