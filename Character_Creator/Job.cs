using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_Creator
{
    public class Job
    {
        //property to name an instance of the Job class
        public string Name { get; set; }
        //List of stats to display for the character
        public List<SavingThrow> SavingThrows = new List<SavingThrow>();
        //Part of the random class to make random values for the stats
        Random r = new Random();

        //Prototype : public override string ToString()
        //Argument : none
        //Description : overrides the ToString() operator to set the name
        //Precondition : an instance of the Job class
        //Postcondition : overrides the ToString() operator to set the name
        //Protection Level : Public
        public Job(string name)
        {
            Name = name;
            GenStats();
        }

        //Prototype : public override string ToString()
        //Argument : none
        //Description : overrides the ToString() operator to set the name
        //Precondition : an instance of the Job class
        //Postcondition : overrides the ToString() operator to set the name
        //Protection Level : Public
        public override string ToString()
        {
            var data =  Name + "\nStats: " +  "\n" + "\n";
            foreach (var stat in SavingThrows)
            {
                data += stat.ToString();
            }
            return data;
        }
         //Prototype : public void GenStats()
         //Argument : none
         //Description : generates the stats with random values for the character
         //Precondition : an instance of the Job class
         //Postcondition : generates the stats with random values for the character
         //Protection Level : Public
        public void GenStats()
        {

            SavingThrow newStats = new SavingThrow()
            {
                Charisma = new Stat("Charisma", r.Next(1, 11)),
                Constitution = new Stat("Constitution", r.Next(1, 11)),
                Intelligence = new Stat("Intelligence", r.Next(1, 11)),
                Strength = new Stat("Strength", r.Next(1, 11)),
                Dexterity = new Stat("Dexterity", r.Next(1, 11)),
                Wisdom = new Stat("Wisdom", r.Next(1, 11))
            };
            SavingThrows.Add(newStats);
        }
    }
    public class Assassin : Job
    {
        //Prototype : public Assassin(string name)
        //Argument : (string name)
        //Description : constructor for the Assassin class
        //Precondition : an instance of the Asssassin class
        //Postcondition : constructs and instance of the Assassin class
        //Protection Level : Public
        public Assassin(string name) : base(name)
        {
        }
    }
    public class Knight : Job
    {
        //Prototype : public Knight(string name)
        //Argument : (string name)
        //Description : constructor for the Knight class
        //Precondition : an instance of the Knight class
        //Postcondition : constructs and instance of the Knight class
        //Protection Level : Public
        public Knight(string name) : base(name)
        {
        }
    }
    public class Mage : Job
    {
        //Prototype : public Mage(string name)
        //Argument : (string name)
        //Description : constructor for the Mage class
        //Precondition : an instance of the Mage class
        //Postcondition : constructs and instance of the Mage class
        //Protection Level : Public
        public Mage(string name) : base(name)
        {
        }
    }
    public class Healer : Job
    {
        //Prototype : public Healer(string name)
        //Argument : (string name)
        //Description : constructor for the Healer class
        //Precondition : an instance of the Healer class
        //Postcondition : constructs and instance of the Healer class
        //Protection Level : Public
        public Healer(string name) : base(name)
        {
        }
    }
    public class SharpShooter : Job
    {
        //Prototype : public Sharpshooter(string name)
        //Argument : (string name)
        //Description : constructor for the Sharpshooter class
        //Precondition : an instance of the Sharpshooter class
        //Postcondition : constructs and instance of the Sharpshooter class
        //Protection Level : Public
        public SharpShooter(string name) : base(name)
        {
        }
    }
}
