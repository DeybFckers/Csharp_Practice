using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            /*the inheritance is just like a family 
             * for example what father can do, also son can do
             * but the father can't do what the son can do,
               always take note if you modify the method from the 
             * parent class always put the base*/

            //father class
            Person p = new Person("David", "Male", 21);

            // this is from father
            p.introduceSelf();
            //p.cry(); - it cause an error because cry its from child

            //son class
            Toddler t = new Toddler("Alenere", "Female", 1, "Peek-a-Boo");
            //t.name = "Alenere";
            //t.sex = "Female";
            //t.age = 1;
            //this is from father do
            t.introduceSelf();
            //only son can do 
            t.cry();

            Child c = new Child("Jaymar", "Male", 6, "Hide and seek", "Coding");
            c.introduceSelf();
            c.cry();
            c.doHobby();

            Console.WriteLine("--- METHOD OVERRIDING ---");

            p.introduceSelf();
            t.introduceSelf();

            Console.WriteLine("--- Different File ---");

            BasicEnemy be = new BasicEnemy("Ban", 100, 5);
            be.attack();
            be.die();
            be.walk();

            FlyingEnemy fe = new FlyingEnemy("Flight", 25, 10);
            fe.attack();
            fe.die();
            fe.fly();
        }
    }

    //parent/father class
    class Person
    {
        public string name { get; set; }
        public string sex { get; set; }
        public int age { get; set; }

        //if you call this it will ask for value of parameters
        public Person(string name, string sex, int age)
        {
            this.name = name;
            this.sex = sex;
            this.age = age;
        }
        /*but if you do this it wont ask anymore
        public Person()
        {

        }*/

        public void introduceSelf()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Sex: " + sex);
            Console.WriteLine("Age: " + age);
        }
    }
    /*if the parent class has constructor, 
     it will require an constructor on child class*/
    class Toddler : Person
    {
        public string faveGame { get; set; }

        //then you will create a constructor : base(parameters of child constructos)
                                                                            //always put the base class
        public Toddler(String name, String sex, int age, String faveGame) : base(name, sex, age)
        {
            {
                this.faveGame = faveGame;
            }
        }
        public void cry()
        {
            Console.WriteLine(name + ": Crying");
        }

        public void introduceSelf()
        {
            //always put the base class
            base.introduceSelf();
            Console.WriteLine("Favorite Game :" + faveGame);
            //base.introduceSelf(); - if you declare here its not a problem but the ordering will be confusing
        }
    }

    //inheritance construct is a chain
    class Child : Toddler
    {
        public string hobby { get; set; }
        public Child(String name, String sex, int age, String faveGame, String hobby)
            : base(name, sex, age, faveGame)
        {
            this.hobby = hobby;
        }
        
        public void doHobby()
        {
            Console.WriteLine(name + " is " + hobby);
        }
    }
}