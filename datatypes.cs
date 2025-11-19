using System;

public class DataTypes{
    public static void Main(string[] args){
        // DataTypes [String, int, double, float, bool]
        int age = 21;
        String name = "David";
        char sex = 'M';
        bool isTall = true;
        double grade = 92.5;
        float average = 92.5f;

        var name1 = "Dave";
        //var datatypes can be declared any types of datatypes but we can't reuse the variable with another datatypes,
        //but you can't do this var name1 = "Dave", name2 = "Fckers", it is only allowed on String datatypes
        dynamic name2 = "Cy";
        name2 = 10;
        //dynamic datatypes we can reuse the variable and use it to another datatypes, 
        
        Console.Write("My name is: ");
        Console.WriteLine(name1);
        
        Console.Write("My age is: ");
        Console.WriteLine(age);

        age = 22;
        Console.Write("My age is: ");
        Console.WriteLine(age);

        //concatenation
        Console.WriteLine("Hello" + "World");
        Console.Write("My name is: " + name1);
        Console.WriteLine(", And I'm " + age +" years old");
        
        /**
        Sentence Builder Challenge
        Hi my name is DeybFckers
        I'am 21 Years old.
        My GPA is 2.25
        My sex is M
        **/
        String name6 = "Deyb", name7 = "Fckers";
        int age3 = 21;
        double gpa = 2.25;
        char sex1 = 'M';
        Console.Write("Hi my name is " + name6);
        Console.WriteLine(" " +name7);
        Console.WriteLine("I'am " + age3 + "Years old.");
        Console.WriteLine("My GPA is " + gpa);
        Console.WriteLine("My sex is " + sex1);

    }
}