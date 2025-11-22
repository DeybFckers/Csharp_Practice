using System;

class Forloop
{
    public static void Main(string[] args)
    {
        // the index is starting from zero
        String[] names = { "David", "Alenere","Jasfer", "Ace", "Patrick","Jaymar"};
        //             // always remember that length is getting the size and it start from 1
        for (int i = 0; i < names.Length; i++)
        {
            if(names[i].Equals("Ace"))
            {
                Console.WriteLine("We Found: " + names[i]);
                break;
            }else{
                Console.WriteLine(names[i]);
            }
        }

        int[] numbers = {3,4,5,6,7,8};
        int sum = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
            if(sum > 20){
                Console.WriteLine("Sum exceeded 20: " + sum);
                break;
            }
            else{
                Console.WriteLine(sum);
            }
        }

        Console.WriteLine("--Authentication Simulation--");

        String[] usernames = {"admin", "user", "guest"};
        String[] passwords = {"admin123", "user123", "guest123"};

        bool isFound = false;

        int lives = 3;
        
        for(int i = 0; i < usernames.Length; i++)
        {

            Console.Write("Enter Username: ");
            String authUsername = Console.ReadLine();

            Console.Write("Enter Password: ");
            String authPassword = Console.ReadLine();

            if(authUsername.Equals(usernames[i]) && authPassword.Equals(passwords[i]))
            {
                isFound = true;
                Console.WriteLine("Login Successful! Welcome " + usernames[i]);
                break;
            }
            else{
                lives --;
                Console.WriteLine("Invalid Credentials. Try Again.");
                Console.WriteLine("You have " + lives + " attempts left.");
            }if(lives == 0){
                Console.WriteLine("Try again later!");
            }
    
        }

        if(!isFound){
            Console.WriteLine("Account Not Found");
        }


        
    }
}