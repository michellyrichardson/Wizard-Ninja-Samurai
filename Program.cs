using System;
using System.Collections.Generic;

namespace WizardNinjaSamurai
{

    public class Human
    {
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        protected int health;
        public int Health
        {
            get; set;
        }

        public Human (string name)
        {
            Name = name;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            health = 100;
        }

        public Human (string name, int str, int intel, int dex, int hp)
        {
            Name = name;
            Strength = str;
            Intelligence = intel;
            Dexterity = dex;
            health = hp;
        }

        //Build attack method
        public virtual int Attack (Human target)
        {
            int dmg = Strength * 3;
            target.health -= dmg;
            Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
            return target.health;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Wizard ben = new Wizard("Ben");
            Ninja nikita = new Ninja("Nikita");
            Samurai zafar = new Samurai("Zafar");
            zafar.Attack(ben);
            ben.Attack(nikita);
            nikita.Attack(zafar);
            nikita.Steal(ben);
            zafar.Meditate();
            ben.Heal(ben);
        }
    }
}
