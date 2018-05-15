using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.Containers;
using Newtonsoft.Json;

namespace CharacterCreator
{
    public class Race : Character
    {
        public string Name { get; set; }
    }
    public class Human : Race
    {
    }
    public class Elf : Race
    {

    }
    public class Ogre : Race
    {

    }
    public class Dwarf : Race
    {

    }
    public class Job
    {
        public string Name { get; set; }
    }
    public class Assassin : Job
    {

    }
    public class Knight : Job
    {

    }
    public class Mage : Job
    {

    }
    public class Healer : Job
    {

    }
    public class SharpShooter : Job
    {

    }
}
