using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Containers
{
    public interface IStat
    {
        string Name { get; set; }
         int Value { get; set; }
         string Description { get; set; }
    }
    public class Stat : IStat
    {
        public string Name { get; set; }
        public int Value { get; set; }
        public string Description { get; set; }

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

    public interface ISavingThrows
    {
        IStat Strength { get; set; }
        IStat Intelligence { get; set; }
        IStat Wisdom { get; set; }
        IStat Charisma { get; set; }
        IStat Constitution { get; set; }
        IStat Dexterity { get; set; }
    }
    public class CharacterStats : ISavingThrows
    {
        public IStat Charisma
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public IStat Constitution
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public IStat Dexterity
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public IStat Intelligence
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public IStat Strength
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public IStat Wisdom
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }
    }
    public class Character : ISavingThrows
    {
        ISavingThrows SavingThrows { get; set; }
        public int ExperiencePoints { get; set; }
        public string CharacterName { get; set; }
        public int Level { get; set; }

        public IStat Strength
        {
            get
            {

                return SavingThrows.Strength;
            }

            set
            {
                SavingThrows.Strength = value as Stat;
            }
        }

        public IStat Intelligence
        {
            get
            {

                return SavingThrows.Intelligence;
            }

            set
            {
                SavingThrows.Intelligence = value as Stat;
            }
        }

        public IStat Wisdom
        {
            get
            {

                return SavingThrows.Wisdom;
            }

            set
            {
                SavingThrows.Wisdom = value as Stat;
            }
        }

        public IStat Charisma
        {
            get
            {

                return SavingThrows.Charisma;
            }

            set
            {
                SavingThrows.Charisma = value as Stat;
            }
        }

        public IStat Constitution
        {
            get
            {

                return SavingThrows.Constitution;
            }

            set
            {
                SavingThrows.Constitution = value as Stat;
            }
        }

        public IStat Dexterity
        {
            get
            {

                return SavingThrows.Dexterity;
            }

            set
            {
                SavingThrows.Dexterity = value as Stat;
            }
        }

        public void GenCharacter()
        {
            var c = new Character();
            var stats = new CharacterStats();
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
