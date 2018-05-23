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

        public Job CurrentJob { get; set; }
        public override string ToString()
        {
            var data = Name + "\n";
            return data;
        }
    }
    public class Human : Race
    {
        public string Name { get; set; }
    }
    public class Elf : Race
    {
        public string Name { get; set; }
    }
    public class Ogre : Race
    {
        public string Name { get; set; }
    }
    public class Dwarf : Race
    {
        public string Name { get; set; }
    }
}
