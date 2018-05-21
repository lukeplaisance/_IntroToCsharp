using System;
using System.Collections;
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
        string ToString();
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
    }

    public interface ISavingThrows
    {
        Stat Strength { get; set; }
        Stat Intelligence { get; set; }
        Stat Wisdom { get; set; }
        Stat Charisma { get; set; }
        Stat Constitution { get; set; }
        Stat Dexterity { get; set; }
        string ToString();
    }

    public class SavingThrows : ISavingThrows
    {
        Stat _Strength;
        Stat _Intelligence;
        Stat _Wisdom;
        Stat _Charisma;
        Stat _Constitution;
        Stat _Dexterity;

        public Stat Strength
        {
            get
            {

                return _Strength;
            }

            set
            {
                _Strength = value as Stat;
            }
        }

        public Stat Intelligence
        {
            get
            {

                return _Intelligence;
            }

            set
            {
                _Intelligence = value as Stat;
            }
        }

        public Stat Wisdom
        {
            get
            {

                return _Wisdom;
            }

            set
            {
                _Wisdom = value as Stat;
            }
        }

        public Stat Charisma
        {
            get
            {
                return _Charisma;
            }

            set
            {
                _Charisma = value as Stat;
            }
        }

        public Stat Constitution
        {
            get
            {

                return _Constitution;
            }

            set
            {
                _Constitution = value as Stat;
            }
        }

        public Stat Dexterity
        {
            get
            {

                return _Dexterity;
            }

            set
            {
                _Dexterity = value as Stat;
            }
        }
        public override string ToString()
        {
            string data = Strength.Name + Strength.Value + "\n" + Intelligence.Name + Intelligence.Value
                + "\n" + Wisdom.Name + Wisdom.Value + "\n" + Charisma.Name + Charisma.Value + "\n" + Constitution.Name +
                Constitution.Value + "\n" + Dexterity.Name + Dexterity.Value;
            return data;
        }
    }

    public class Character
    {
        Random r = new Random();
        public ISavingThrows SavingThrows { get; set; }
        public int ExperiencePoints { get; set; }
        public string CharacterName { get; set; }
        public int Level { get; set; }

        public void GenCharacter()
        {
            var c = new Character();
            var stats = new SavingThrows();
        }

        public override string ToString()
        {
            string data = "Name: " + CharacterName + "\n" +
                "Level: " + Level + "\n" +
                "Exp: " + ExperiencePoints + "\n" +
                SavingThrows.ToString();
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
