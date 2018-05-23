using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_Creator
{
    public class Job
    {
        public string Name { get; set; }
        public List<SavingThrow> SavingThrows = new List<SavingThrow>();

        //Prototype : public override string ToString()
        //Argument : none
        //Description : overrides the ToString() operator to set the name
        //Precondition : an instance of the Job class
        //Postcondition : overrides the ToString() operator to set the name
        //Protection Level : Public
        public override string ToString()
        {
            var data = "Name: " + Name + "\nStats: " + "\n";
            foreach (var stat in SavingThrows)
            {
                data += stat.ToString();
            }
            return data;
        }
        public void GenStats()
        {
            Random r = new Random();
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

    }
    public class Knight : Job
    {

    }
    public class Mage : Job
    {

    }
    public class Healer : Job
    {

    }
    public class SharpShooter : Job
    {

    }
}
