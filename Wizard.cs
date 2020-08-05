using System;

namespace WizardNinjaSamurai
{
    public class Wizard : Human {

        public Wizard (string name) : base (name)
        {
            Name = name;
            Intelligence = 25;
            health = 50;
        }

        //Provide an override attack method to Wizard
        public override int Attack (Human target)
        {
            int dmg = Intelligence * 5;
            target.Health -= dmg;
            Console.WriteLine ($"{Name} attacked {target.Name} for {dmg} damage!");
            health += dmg;
            return target.Health;
        }

        //Wizard needs method called heal, which heals a target by 10 * Intelligence
        public int Heal (Human target)
        {
            int cure = Intelligence * 10;
            target.Health += cure;
            Console.WriteLine ($"{Name} has healed {target.Name} and restored {cure.ToString()} hp!");
            return target.Health;
        }
    }
}
