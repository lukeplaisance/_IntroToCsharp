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
        Random r = new Random();
        public List<Race> RaceList = new List<Race>();
        public List<Job> JobList = new List<Job>();
        public Form1()
        {
            InitializeComponent();
            RaceList = new List<Race>()
            {
                new Human() {SavingThrows = new SavingThrows() { Charisma = new Stat("Charisma: ", r.Next(1, 11)),
                    Constitution = new Stat("Constitution: ", r.Next(1, 11)), Intelligence = new Stat("Intelligence: ", r.Next(1, 11)),
                    Strength = new Stat("Strength: ", r.Next(1,11)), Dexterity = new Stat("Dexterity: ", r.Next(1, 11)),
                    Wisdom = new Stat("Wisdom: ", r.Next(1, 11))}, CharacterName = "Human" , Level = 0, ExperiencePoints = 0},

                new Elf() {SavingThrows = new SavingThrows() { Charisma = new Stat("Charisma: ", r.Next(1, 11)),
                    Constitution = new Stat("Constitution: ", r.Next(1, 11)), Intelligence = new Stat("Intelligence: ", r.Next(1, 11)),
                    Strength = new Stat("Strength: ", r.Next(1,11)), Dexterity = new Stat("Dexterity: ", r.Next(1, 11)),
                    Wisdom = new Stat("Wisdom: ", r.Next(1, 11))}, CharacterName = "Elf" , Level = 0, ExperiencePoints = 0},

                new Ogre() {SavingThrows = new SavingThrows() { Charisma = new Stat("Charisma: ", r.Next(1, 11)),
                    Constitution = new Stat("Constitution: ", r.Next(1, 11)), Intelligence = new Stat("Intelligence: ", r.Next(1, 11)),
                    Strength = new Stat("Strength: ", r.Next(1,11)), Dexterity = new Stat("Dexterity: ", r.Next(1, 11)),
                    Wisdom = new Stat("Wisdom: ", r.Next(1, 11))}, CharacterName = "Ogre" , Level = 0, ExperiencePoints = 0},

                new Dwarf() {SavingThrows = new SavingThrows() { Charisma = new Stat("Charisma: ", r.Next(1, 11)),
                    Constitution = new Stat("Constitution: ", r.Next(1, 11)), Intelligence = new Stat("Intelligence: ", r.Next(1, 11)),
                    Strength = new Stat("Strength: ", r.Next(1,11)), Dexterity = new Stat("Dexterity: ", r.Next(1, 11)),
                    Wisdom = new Stat("Wisdom: ", r.Next(1, 11))}, CharacterName = "Dwarf" , Level = 0, ExperiencePoints = 0}
            };
            JobList = new List<Job>()
            {
                new Assassin() {Name = "Assassin"},
                new Knight() {Name = "Knight" },
                new Mage() {Name = "Mage" },
                new Healer() {Name = "Healer" },
                new SharpShooter() {Name = "Sharpshooter" }
            };
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
                    label6.Text = item.ToString();
                }
                if(item.Name == "Assassin")
                {
                    item.SavingThrows.Strength.Value += r.Next(0, 5);
                    item.SavingThrows.Intelligence.Value += r.Next(0, 5);
                    item.SavingThrows.Wisdom.Value += r.Next(0, 5);
                    item.SavingThrows.Charisma.Value += r.Next(0, 5);
                    item.SavingThrows.Constitution.Value += r.Next(0, 5);
                    item.SavingThrows.Dexterity.Value += r.Next(0, 5);
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
