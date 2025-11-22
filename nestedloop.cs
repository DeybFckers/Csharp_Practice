using System;

class NestedLoop
{
    public static void Main()
    {
        for(int i = 0; i < 5; i++)
        {
            for(int x = 0; x < 5; x++)
            {
                Console.WriteLine("x: " + x);
            }
            
            Console.WriteLine();
        }

         String[,] users =
        {           //0       //1
         /*0*/   { "David", "david123" },
         /*1*/   { "Alenere", "alenere123" },
         /*2*/   { "Hezel", "hezel123" },
         /*3*/   { "Jaymar", "jaymar123" },
        };

        for(int row = 0; row < users.GetLength(0); row++)
        {
            for(int col = 0; col < users.GetLength(1); col++)
            {
                Console.WriteLine(row + " " + col);
            }
            Console.WriteLine();
        }
    }
}