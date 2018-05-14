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
        public Dictionary<string, Race> Races = new Dictionary<string, Race>();
        public void GenRaces()
        {
            Races.Add("Human", new Human());
            Races.Add("Elf", new Elf());
            Races.Add("Ogre", new Ogre());
            Races.Add("Dwarf", new Dwarf());
        }
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
        public Dictionary<string, Job> Jobs = new Dictionary<string, Job>();
        public void GenJobs()
        {
            Jobs.Add("Assassin", new Assassin());
            Jobs.Add("Knight", new Knight());
            Jobs.Add("Mage", new Mage());
            Jobs.Add("Healer", new Healer());
            Jobs.Add("Sharpshooter", new SharpShooter());
        }
        public override string ToString()
        {
            string data = Name + "\n";
            foreach (var job in Jobs)
            {
                data += job.Key;
            }
            return data;
        }
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
