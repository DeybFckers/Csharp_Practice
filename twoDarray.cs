using System;

class twoDarray
{
    public static void Main(string[] args)
    {
        /* the difference of oneDarray and 2Darray is that
           oneDarray is a single line while twoDarray is a table or grid
           but when you define a 2Darray is you need a comma inside the square brackets
           like this Datatypes[,] arrayName = {{value1, value2}, {value3, value4} }; 
        */

        String[,] users =
        {           //0       //1
         /*0*/   { "David", "david123" },
         /*1*/   { "Alenere", "alenere123" },
         /*2*/   { "Hezel", "hezel123" },
         /*3*/   { "Jaymar", "jaymar123" },
        };

        //when you want to access a specific value in 2Darray you need to specify both indexes
        //like this arrayName[rowIndex, columnIndex]
        Console.WriteLine(users[3,1]);

        //to get the length of row of a 2Darray you can use GetLength method
        //use 0 for row and 1 for column
        Console.WriteLine(users.GetLength(0));
        Console.WriteLine(users.GetLength(1));
    }
}