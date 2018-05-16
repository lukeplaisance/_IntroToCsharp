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
        public List<Race> RaceList = new List<Race>()
        {
            new Human() {CharacterName = "Human" , Level = 0, ExperiencePoints = 0},
            new Elf() {CharacterName = "Elf" , Level = 0, ExperiencePoints = 0},
            new Ogre() {CharacterName = "Ogre" , Level = 0, ExperiencePoints = 0},
            new Dwarf() {CharacterName = "Dwarf" , Level = 0, ExperiencePoints = 0}
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
            foreach(var item in RaceList)
            {
                if(item.CharacterName == RaceBox.Text)
                {
                    richTextBox1.Text = item.ToString();
                }
            }
        }

        private void JobBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var item in JobList)
            {
                if (item.Name == JobBox.Text)
                {
                    richTextBox1.Text = item.ToString();
                }
            }
        }

        private void GenCharacter_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            foreach (var item in RaceList)
            {
                RaceBox.Items.Add(item.CharacterName);
                item.GenCharacter();
                label5.Text = textBox1.Text;
            }
            foreach (var item in JobList)
            {
                JobBox.Items.Add(item.Name);
            }

        }
    }
}
