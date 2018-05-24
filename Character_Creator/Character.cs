using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_Creator
{
    public class Character
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public Job m_job;
        public Race m_race;


        public Character(string name, Job job, Race race)
        {
            Name = name;
            m_job = job;
            m_race = race;
        }
        public override string ToString()
        {
            var data = "Name: " + Name +
                "\nJob: " + m_job.ToString() +"\nRace: " + m_race.ToString();
            return data;
        }
    }
}
