using System;



class Classes
{
    public static void Main(string[] args)
    {
    
        Constants c = new Constants(); // this is instantiate

        Console.WriteLine(Arithmetic1.add(5,2));
        Console.WriteLine(Arithmetic1.subtract(5,2));
        Console.WriteLine(Arithmetic1.multiply(5,2));
        Console.WriteLine(Arithmetic1.divide(5,2));

        Console.WriteLine(c.pi);
        Console.WriteLine(c.gravity);
        
    }
}

//static class it means you dont need to instantiate
static class Arithmetic1
{
    //public class it means you can call it to another class
    public static int add(int num1, int num2)
    {
        return num1 + num2;
    }

    public static int subtract(int num1, int num2)
    {
        return num1 - num2;
    }
    public static int multiply(int num1, int num2)
    {
        return num1 * num2;
    }
    public static int divide(int num1, int num2)
    {
        return num1 / num2;
    }
}

class Constants
{
    public float pi = 3.14f;
    public float gravity = 9.8f;

}
