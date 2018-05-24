using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_Creator
{
    public class Character
    {
        //Private variable for the Name property
        private string _name;
        //Property of the name for the character class
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        //Member variable from the Job to use in the Character constructor
        public Job m_job;
        //Member variable from the Job to use in the Character constructor
        public Race m_race;

        //Prototype : public Character(string name, Job job, Race race)
        //Argument : (string name, Job job, Race race)
        //Description : constructor for the Character class
        //Precondition : an instance of the Character class
        //Postcondition : constructs and instance of the Character class
        //Protection Level : Public
        public Character(string name, Job job, Race race)
        {
            Name = name;
            m_job = job;
            m_race = race;
        }

        //Prototype : public override string ToString()
        //Argument : none
        //Description : overrides the ToString() operator to set the name
        //Precondition : an instance of the Character class
        //Postcondition : overrides the ToString() operator to set the name
        //Protection Level : Public
        public override string ToString()
        {
            var data = "Name: " + Name +
                "\nJob: " + m_job.ToString() +"\nRace: " + m_race.ToString();
            return data;
        }
    }
}
