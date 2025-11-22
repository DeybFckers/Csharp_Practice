using System;

class Function
{
    //this is Global Variables and the rules is you need to put static keyword
    //but global variable is not good practice in programming
    static String name = "Alenere";
    static int age = 20;
    static void Main(string[] args)
    {
        //it used a global variable here
        Console.WriteLine("Hello "+ name);
        Console.WriteLine("I am "+ age + " years old");

        introduce2("John", 25);

        int x = add(5, 2);
        Console.WriteLine(x);
        
        //you can use a declare variable here
        //declare variable
        String lastName = "SDPT";
        Console.WriteLine(makeName("Alenere",lastName));
        Console.WriteLine(makeName("David", lastName));

        //calling overloading
        Console.WriteLine(sub(5,3,2));

        //challenge
        Console.WriteLine(summation(new int[] {5,4,3,2,1}));
        //you can declare like this allso
        int[] numbers = {5,4,3,2,1};
        Console.WriteLine(summation(numbers));
    }

    static void introduce()
    {
        //local variables
        //if you declare a variable with the same name as a global variable
        //the local variable will take precedence over the global variable
        String name = "David";
        //so the result here is "Hi my name is David"
        Console.WriteLine("Hi my name is " + name);

    }
                        //inside the parentheses is called parameters
    static void introduce2(string name, int age)
    {
        Console.WriteLine("Hello my name is " + name);
        Console.WriteLine("I am " + age + " years old");
    }

    static int add(int a, int b)
    {
        int sum = a + b;
        /*it means it return the sum
        instead of writing the console.writeline*/
        return sum;
    }
    
    static String makeName(String firstName, String lastName)
    {
        return firstName + " " + lastName;
    }

    /* overloading method
    it allows to reuse the name as long as 
    the parameters isn't same*/

    static int sub (int num1, int num2)
    {
        return num1 - num2;
    }
    //
    static int sub (int num1, int num2 , int num3)
    {
        return num1- num2 - num3;
    }

    //challenge
    static int summation(int[] numbers)
    {
        int sum = 0;
        for(int i = 0; i< numbers.Length; i ++)
        {
            sum += numbers[i];
        }

        return sum;
    }

}