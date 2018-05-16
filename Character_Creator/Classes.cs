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
        public override string ToString()
        {
            var data = "\n" + Name + "\n";
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

    public class CharacterData
    {
        public static Dictionary<string, Race> Races = new Dictionary<string, Race>();
        public static Dictionary<string, Job> Jobs = new Dictionary<string, Job>();

        public static void AddRace(Race race)
        {
            Races.Add(race.Name, race);
        }
        public static void AddJob(Job job)
        {
            Jobs.Add(job.Name, job);
        }
    }
}
