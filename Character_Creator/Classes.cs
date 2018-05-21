using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.Containers;
using Newtonsoft.Json;

namespace CharacterCreator
{

    public class Modifier
    {
        int _value;
        public int Value { get; set; }
    }

    public class Race : Character
    {
        public string Name { get; set; }
        public void JobStat()
        {
            Random r = new Random();
            if (Name == "Assassin")
            {
                SavingThrows.Intelligence.Value = r.Next(0, 5);
                SavingThrows.Charisma.Value = r.Next(0, 5);
                SavingThrows.Dexterity.Value = r.Next(0, 5);
            }
            else if (Name == "Knight")
            {
                SavingThrows.Strength.Value += r.Next(0, 5);
                SavingThrows.Constitution.Value += r.Next(0, 5);
                SavingThrows.Dexterity.Value += r.Next(0, 5);
            }
            else if (Name == "Mage")
            {
                SavingThrows.Intelligence.Value += r.Next(0, 5);
                SavingThrows.Wisdom.Value += r.Next(0, 5);
                SavingThrows.Constitution.Value += r.Next(0, 5);
            }
            else if (Name == "Healer")
            {
                SavingThrows.Intelligence.Value += r.Next(0, 5);
                SavingThrows.Wisdom.Value += r.Next(0, 5);
                SavingThrows.Charisma.Value += r.Next(0, 5);
                SavingThrows.Constitution.Value += r.Next(0, 5);
            }
            else if (Name == "Sharpshooter")
            {
                SavingThrows.Strength.Value += r.Next(0, 5);
                SavingThrows.Intelligence.Value += r.Next(0, 5);
                SavingThrows.Charisma.Value += r.Next(0, 5);
                SavingThrows.Dexterity.Value += r.Next(0, 5);
            }
        }
    }
    public class Human : Race
    {
    }
    public class Elf : Race
    {

    }
    public class Ogre : Race
    {

    }
    public class Dwarf : Race
    {

    }
    public class Job : Character
    {
        public string Name { get; set; }
     //Prototype : public override string ToString()
     //Argument : none
     //Description : overrides the ToString() operator to set the name
     //Precondition : an instance of the Job class
     //Postcondition : overrides the ToString() operator to set the name
     //Protection Level : Public
        public override string ToString()
        {
            var data = "\n" + Name + "\n";
            return data;
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
