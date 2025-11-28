using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    internal class BasicEnemy : Enemy
    {
        public int walkSpeed { get; set; }
        public BasicEnemy(String name, int health, int walkSpeed) : base(name, health) 
        {
            this.walkSpeed = walkSpeed;
        }
        public void attack()
        {
            base.attack();
            Console.WriteLine("on the Ground");
        }

        public void walk()
        {
            Console.WriteLine(name + " is Walking");
        }
    }
}
