using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Containers
{
    public class Stat
    {
        public string Name { get; private set; }
        public int Value { get; private set; }
        public string Description { get; private set; }

        public Stat(string name, int value)
        {
            Name = name;
            Value = value;
        }
        public override string ToString()
        {
            string data = Name + ":" + Value + "\n" + Description + "\n";
            return data;
        }

        //test for type conversion
        //public static explicit operator Stat(int i)
        //{
        //    Stat test = new Stat("boi", i);
        //    return test;
        //}
    }

    public class Character
    {
        public Dictionary<string, Stat> SavingThrows = new Dictionary<string, Stat>();
        public int ExperiencePoints { get; set; }
        public string CharacterName { get; set; }
        public int Level { get; set; }

        public void GenCharacter()
        {
            Random r = new Random();
            SavingThrows.Add("Str", new Stat("Strength", r.Next(1, 11)));
            SavingThrows.Add("Intel", new Stat("Intelligence", r.Next(1, 11)));
            SavingThrows.Add("Wis", new Stat("Wisdom", r.Next(1, 11)));
            SavingThrows.Add("Char", new Stat("Charisma", r.Next(1, 11)));
            SavingThrows.Add("Cons", new Stat("Constitution", r.Next(1, 11)));
            SavingThrows.Add("Dex", new Stat("Dexterity", r.Next(1, 11)));
        }

        public override string ToString()
        {
            string data = "Name: " + CharacterName + "\n" +
                "Level: " + Level + "\n" +
                "Exp: " + ExperiencePoints + "\n" + "\n";
            foreach (var stat in SavingThrows)
            {
                data += stat.Value.ToString();
            }
            return data;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
