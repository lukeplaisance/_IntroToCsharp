using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_Creator
{
    public interface ISavingThrow
    {
        Stat Strength { get; set; }
        Stat Intelligence { get; set; }
        Stat Wisdom { get; set; }
        Stat Charisma { get; set; }
        Stat Constitution { get; set; }
        Stat Dexterity { get; set; }
        string ToString();
    }

    public class SavingThrow : ISavingThrow
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
