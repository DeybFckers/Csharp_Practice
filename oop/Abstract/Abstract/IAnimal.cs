using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract
{
    //interface is automatically abstract
    //so when you implement the method you dont need to type override
    internal interface IAnimal
    {
        void makeSound();

        void sleep();
        
    }

    interface ILandAnimal
    {
        void walk();
    }

    interface IAirAnimal
    {
        void fly();
       
    }

    class Bird : IAnimal, IAirAnimal
    {
        public void fly()
        {
            
        }

        public void makeSound()
        {
            
        }

        public void sleep()
        {
            
        }
    }
}
