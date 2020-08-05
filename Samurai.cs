using System;

namespace WizardNinjaSamurai
{
    public class Samurai : Human
        {
            public Samurai (string name) : base (name)
            {
                Name = name;
                health = 200;
            }
            //Provide override Attack method to Samurai
            public override int Attack (Human target)
            {
                base.Attack(target);
                if (target.Health < 50){
                    target.Health = 0;
                }
                return target.Health;
            }
            // Samurai method Meditate, which heals Samurai back to full health
            public int Meditate()
            {
                Health = 200;
                Console.WriteLine ($"{Name} has recovered 200 hp!");
                return Health;
            }
        }
    }

