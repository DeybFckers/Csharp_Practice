using System;

class While
{
    public static void Main(string[] args)
    {
        String[] names = { "Jedd", "Cy", "Mikay", "Mj", "Solo",};
        int i = 0;

        while(i < names.Length)
        {
            Console.WriteLine(names[i]);
            i++;
        }

        while(i < 5)
        {
            if (names[i].Equals("Mikay"))
            {
                Console.WriteLine("We Found: "+ names[i]);
                break;
            }
            else
            {
                Console.WriteLine(names[i]);
            }
            i++;
        }

        Console.WriteLine("--Quiz Game--");

        int lives = 3;

        while(lives >= 0)
        {
            Console.Write("Answer :" );
            string answer = Console.ReadLine();

            if(answer.Equals("Yes", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Correct Answer");
                break;
            }
            else
            {
                lives--;
                Console.WriteLine("Invalid Answer");
                Console.WriteLine("You have " + lives + " lives left");
            }
            if(lives == 0)
            {
                Console.WriteLine("Try Again Later!");
                break;
            }
        }
    }
}