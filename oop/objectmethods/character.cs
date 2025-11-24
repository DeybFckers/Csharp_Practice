using System;

namespace objectmethods
{
    class Character
    {
        public String name, dialog;
        public int hp, mp, lvl;

        public Character(String name, String dialog, int hp, int mp, int lvl)
        {
            this.name = name;
            this.dialog = dialog;
            this.hp = hp;
            this.mp = mp;
            this.lvl = lvl;
        }

        public String introduce()
        {
            return "I'am " + name;
        }

        public String sayDialog()
        {
            return name + " : " + dialog;
        }

        public void checkStats()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("HP: " + hp);
            Console.WriteLine("MP: " + mp);
            Console.WriteLine("LEVEL: " + lvl);
        }
    }
}