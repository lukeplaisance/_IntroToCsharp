using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _1.Containers;

namespace CharacterCreator
{
    public partial class Form1 : Form
    {
        public Dictionary<string, Race> Races = new Dictionary<string, Race>();
        public Dictionary<string, Job> Jobs = new Dictionary<string, Job>();
        public List<Race> RaceList = new List<Race>()
        {
            new Human() {Name = "Human" },
            new Elf() {Name = "Elf" },
            new Ogre() {Name = "Ogre" },
            new Dwarf() {Name = "Dwarf" }
        };
        public List<Job> JobList = new List<Job>()
        {
            new Assassin() {Name = "Assassin" },
            new Knight() {Name = "Knight" },
            new Mage() {Name = "Mage" },
            new Healer() {Name = "Healer" },
            new SharpShooter() {Name = "Sharpshooter" }
        };
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void RaceBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            foreach(var race in RaceList)
            {
                RaceBox.Text = race.Name;
            }
        }

        private void JobBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(var job in JobList)
            {
                JobBox.Text = job.Name;
            }
        }

        private void GenCharacter_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            foreach(var item in RaceList)
            {
                Races.Add()
            }

        }
    }
}
