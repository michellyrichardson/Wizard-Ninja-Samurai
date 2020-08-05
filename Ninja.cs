using System;

namespace WizardNinjaSamurai
{
    public class Ninja : Human
        {
            public Ninja (string name) : base (name)
            {
                Name = name;
                Dexterity = 175;
            }
            //provide an override attack method to ninja
            public override int Attack (Human target)
            {
                Random rand = new Random();
                int critChance = rand.Next(0,100);
                int dmg = 0;
                if (critChance <= 20){
                    dmg = 10 + (Dexterity * 5);
                }
                else{
                    dmg = Dexterity * 5;
                }
                target.Health -= dmg;
                Console.WriteLine ($"{Name} attacked {target.Name} for {dmg} damage!");
                health += dmg;
                return target.Health;
            }
            //Ninja method Steal  to reduce human health
            public int Steal (Human target)
            {
                target.Health -= 5;
                Health += 5;
                Console.WriteLine($"{Name} has stolen 5 hp from {target.Name}!");
                return target.Health;
            }
        }
    }

