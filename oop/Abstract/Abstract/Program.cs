using System;

namespace Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            //Animal a = new Animal(); - you can't instantiate because abstract class
            Animal a = new Dog("Ginger", 2, "chowchow");
            Animal b = new Cat("Monkey", 2);

            a.makeSound();
            b.makeSound();

            Console.WriteLine("--- Abstraction Interface ---");

            //but do not interface to instantiate
            //IAnimal aa = new IAnimal(); - you can't instantiate beecause they are interface or abstract
            IAnimal aa = new Dog1(); // this is allow because dog is an IAnimal inherit
            ILandAnimal bb = new Dog1(); // this is allow also because dog is from ILandAnimal
            IAnimal cc = new Bird(); // this is allow because bird is an IAnimal inherit
            IAirAnimal dd = new Bird(); // this is alllow also because bird is an IAirAnimal inherit
            //ILandAnimal dd = new Bird(); - this not allowed  because bird is not from ILandAnimal
            //IAirAnimal ee = new Dog(); = this is not allowed because dog is not from IAIrAnimal
            


        }
    }

    //always put an abstract
    //you can't instantiate the abstract class

    abstract class Animal
    {
        //always public the modifier if you override
        //only abstract is allowed to dont have an body
        public abstract void makeSound();

        //needs a body here because its not abstract
        public void sleep()
        {

        }

        String name {  get; set; }
        int age { get; set; }

        protected Animal(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }

    class Dog : Animal
    {
        //if you add a constructor
        String breed { get; set; }
        public Dog(String name, int age, String breed) : base(name, age) 
        {
            //put it here not to create a new functions or methods
            this.breed = breed;
        }
        public override void makeSound()
        {
            Console.WriteLine("Arf");
        }
    }

    class Cat : Animal
    {
        public Cat(String name, int age) : base(name, age) { }
        public override void makeSound()
        {
            Console.WriteLine("meow");
        }
    }
}