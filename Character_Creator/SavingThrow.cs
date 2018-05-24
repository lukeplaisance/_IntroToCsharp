using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_Creator
{
    public interface ISavingThrow
    {
        //property for the strength stat
        Stat Strength { get; set; }
        //property for the Intelligence stat
        Stat Intelligence { get; set; }
        //property for the Wisdom stat
        Stat Wisdom { get; set; }
        //Property for the Charisma stat
        Stat Charisma { get; set; }
        //property for the Constitution stat
        Stat Constitution { get; set; }
        //property for the Dexterity stat
        Stat Dexterity { get; set; }
        //overrides ToString()
        string ToString();
    }

    public class SavingThrow : ISavingThrow
    {
        //Backing field for the Strength stat
        Stat _Strength;
        //Backing field for the Intelligence sta
        Stat _Intelligence;
        //Backing field for the Wisdom stat
        Stat _Wisdom;
        //Backing field for the Charisma stat
        Stat _Charisma;
        //Backing field for the Constitution stat
        Stat _Constitution;
        //Backing field for the Dexterity stat
        Stat _Dexterity;
        //property for Strength from the Stat class
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

        //property for Intelligence from the Stat class
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

        //property for Wisdom from the Stat class
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

        //property for Charisma from the Stat class
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

        //property for Constitution from the Stat class
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

        //property for Dexterity from the Stat class
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

        //Prototype : public override string ToString()
        //Argument : none
        //Description : overrides the ToString() operator to set the name
        //Precondition : an instance of the SavingThrow class
        //Postcondition : overrides the ToString() operator to set the name
        //Protection Level : Public
        public override string ToString()
        {
            string data = Strength.Name + " : " + Strength.Value + "\n" +
                Intelligence.Name + " : " + Intelligence.Value + "\n" +
                Wisdom.Name + " : " + Wisdom.Value + "\n" +
                Charisma.Name + " : " + Charisma.Value + "\n" +
                Constitution.Name + " : " + Constitution.Value + "\n" +
                Dexterity.Name + " : " + Dexterity.Value;
            return data;
        }
    }
}
