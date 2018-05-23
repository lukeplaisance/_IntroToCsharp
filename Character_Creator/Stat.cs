using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_Creator
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
}