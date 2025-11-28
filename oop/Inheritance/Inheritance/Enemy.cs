using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    internal class Enemy
    {
        public String name { get; set; }
        public int health { get; set; }

        public Enemy(string name, int health)
        {
            this.name = name;
            this.health = health;
        }

        public void attack()
        {
            Console.Write("Attacking ");
        }

        public void die()
        {
            Console.WriteLine(name + " is Dead");
        }
        
    }
}
