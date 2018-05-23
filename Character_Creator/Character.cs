using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_Creator
{
    public class Character
    {
        public string Name { get; set; }
        public Job m_job;
        public Race m_race;
        List<ISavingThrow> SavingThrows = new List<ISavingThrow>();

        Character(string name, Job job, Race race)
        {
            Name = name;
            m_job = job;
            m_race = race;
        }
    }
}
