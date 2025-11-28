using System;

namespace Polymorphism
{
    class Program
    {
        public static void Main(string[] args)
        {
            //polymorphism
            //you can instantiate using the base class or parent class
            //parents     child class
            Animal a = new Dog();
            Animal b = new Cat();

            a.makeSound();
            b.makeSound();
        }
    }
    
    class Animal
    {
        //you need to put the virtual to allow the overrider
        virtual public void makeSound()
        {
            Console.WriteLine("Override This Please");
        }
    }

    class Dog : Animal
    {
        //declare override
        override public void makeSound()
        {
            Console.WriteLine("Arf");
        }
    }

    class Cat : Animal 
    {
        override public void makeSound()
        {
            Console.WriteLine("Meow");
        }
    }
}