using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_Creator
{
    public class Race
    {
        //property to name an instance of the Race class
        public string Name { get; set; }

        //Prototype : public Race(string name)
        //Argument : (string name)
        //Description : constructor for the Race class
        //Precondition : an instance of the Race class
        //Postcondition : constructs and instance of the Race class
        //Protection Level : Public
        public Race(string name)
        {
            Name = name;
        }

        //Prototype : public override string ToString()
        //Argument : none
        //Description : overrides the ToString() operator to set the name
        //Precondition : an instance of the Race class
        //Postcondition : overrides the ToString() operator to set the name
        //Protection Level : Public
        public override string ToString()
        {
            var data = Name + "\n";
            return data;
        }
    }
    public class Human : Race
    {
        //Prototype : public Human(string name)
        //Argument : (string name)
        //Description : constructor for the Hunan class
        //Precondition : an instance of the Human class
        //Postcondition : constructs and instance of the Human class
        //Protection Level : Public
        public Human(string name) : base(name)
        {
            Name = name;
        }

        //property to name an instance of the Human class
        public string Name { get; set; }
    }
    public class Elf : Race
    {
        //Prototype : public Elf(string name)
        //Argument : (string name)
        //Description : constructor for the Elf class
        //Precondition : an instance of the Elf class
        //Postcondition : constructs and instance of the Elf class
        //Protection Level : Public
        public Elf(string name) : base(name)
        {
            Name = name;
        }

        //property to name an instance of the Elf class
        public string Name { get; set; }
    }
    public class Ogre : Race
    {
        //Prototype : public Ogre(string name)
        //Argument : (string name)
        //Description : constructor for the Ogre class
        //Precondition : an instance of the Ogre class
        //Postcondition : constructs and instance of the Ogre class
        //Protection Level : Public
        public Ogre(string name) : base(name)
        {
            Name = name;
        }
        //property to name an instance of the Ogre class
        public string Name { get; set; }
    }
    public class Dwarf : Race
    {
        //Prototype : public Dwarf(string name)
        //Argument : (string name)
        //Description : constructor for the Dwarf class
        //Precondition : an instance of the Dwarf class
        //Postcondition : constructs and instance of the Dwarf class
        //Protection Level : Public
        public Dwarf(string name) : base(name)
        {
            Name = name;
        }
        //property to name an instance of the Dwarf class
        public string Name { get; set; }
    }
}
