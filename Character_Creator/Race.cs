using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_Creator
{
    public class Race
    {
        public string Name { get; set; }
        public Race(string name)
        {
            Name = name;
        }
        public override string ToString()
        {
            var data = Name + "\n";
            return data;
        }
    }
    public class Human : Race
    {
        public Human(string name) : base(name)
        {
            Name = name;
        }

        public string Name { get; set; }
    }
    public class Elf : Race
    {
        public Elf(string name) : base(name)
        {
            Name = name;
        }

        public string Name { get; set; }
    }
    public class Ogre : Race
    {
        public Ogre(string name) : base(name)
        {
            Name = name;
        }

        public string Name { get; set; }
    }
    public class Dwarf : Race
    {
        public Dwarf(string name) : base(name)
        {
            Name = name;
        }

        public string Name { get; set; }
    }
}
