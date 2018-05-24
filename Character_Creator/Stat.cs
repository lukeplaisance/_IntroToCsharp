using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_Creator
{
    public interface IStat
    {
        //property to name an instance of the IStat interface
        string Name { get; set; }
        //property to set a value for  an instance of the IStat interface
        int Value { get; set; }
        //property to put a description for an instance of the IStat interface
        string Description { get; set; }
        //overrides ToString()
        string ToString();
    }
    public class Stat : IStat
    {
        //property to name an instance of the Stat class
        public string Name { get; set; }
        //property to set a value for  an instance of the Stat class
        public int Value { get; set; }
        //property to put a description for an instance of the Stat class
        public string Description { get; set; }

        public Stat(string name, int value)
        {
            Name = name;
            Value = value;
        }
        //Prototype : public override string ToString()
        //Argument : none
        //Description : overrides the ToString() operator to set the name
        //Precondition : an instance of the Stat class
        //Postcondition : overrides the ToString() operator to set the name
        //Protection Level : Public
        public override string ToString()
        {
            string data = Name + ":" + Value + "\n" + Description + "\n";
            return data;
        }
    }
}