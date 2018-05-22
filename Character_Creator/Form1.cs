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
using Newtonsoft.Json;

namespace CharacterCreator
{
    public enum StatNames
    {
        Charisma,
        Constitution,
        Intelligence,
        Strength,
        Dexterity,
        Wisdom,
    }
    public partial class Form1 : Form
    {

        public List<Race> RaceList = new List<Race>();
        public List<Job> JobList = new List<Job>();

        public Form1()
        {
            Random r = new Random();
            InitializeComponent();
            RaceList = new List<Race>()
            {
                #region
                new Human()
                {
                    CharacterName = "Human" ,
                    Level = 0,
                    ExperiencePoints = 0,
                    SavingThrows = new SavingThrows()
                    {
                        Charisma = new Stat("Charisma", r.Next(1, 11)),
                        Constitution = new Stat("Constitution", r.Next(1, 11)),
                        Intelligence = new Stat("Intelligence", r.Next(1, 11)),
                        Strength = new Stat("Strength", r.Next(1,11)),
                        Dexterity = new Stat("Dexterity", r.Next(1, 11)),
                        Wisdom = new Stat("Wisdom", r.Next(1, 11))
                    }
                },
                new Elf()
                {
                    CharacterName = "Elf" ,
                    Level = 0,
                    ExperiencePoints = 0,
                    SavingThrows = new SavingThrows()
                    {
                        Charisma = new Stat("Charisma", r.Next(1, 11)),
                        Constitution = new Stat("Constitution", r.Next(1, 11)),
                        Intelligence = new Stat("Intelligence", r.Next(1, 11)),
                        Strength = new Stat("Strength", r.Next(1,11)),
                        Dexterity = new Stat("Dexterity", r.Next(1, 11)),
                        Wisdom = new Stat("Wisdom", r.Next(1, 11))
                    }
                },
                new Ogre()
                {
                    CharacterName = "Ogre" ,
                    Level = 0,
                    ExperiencePoints = 0,
                    SavingThrows = new SavingThrows()
                    {
                        Charisma = new Stat("Charisma", r.Next(1, 11)),
                        Constitution = new Stat("Constitution", r.Next(1, 11)),
                        Intelligence = new Stat("Intelligence", r.Next(1, 11)),
                        Strength = new Stat("Strength", r.Next(1,11)),
                        Dexterity = new Stat("Dexterity", r.Next(1, 11)),
                        Wisdom = new Stat("Wisdom", r.Next(1, 11))
                    }
                },
                new Dwarf()
                {
                    CharacterName = "Dwarf" ,
                    Level = 0,
                    ExperiencePoints = 0,
                    SavingThrows = new SavingThrows()
                    {
                        Charisma = new Stat("Charisma", r.Next(1, 11)),
                        Constitution = new Stat("Constitution", r.Next(1, 11)),
                        Intelligence = new Stat("Intelligence", r.Next(1, 11)),
                        Strength = new Stat("Strength", r.Next(1,11)),
                        Dexterity = new Stat("Dexterity", r.Next(1, 11)),
                        Wisdom = new Stat("Wisdom", r.Next(1, 11))
                    }
                }
            };
            #endregion
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
            foreach (var item in RaceList)
            {
                if (item.CharacterName == RaceBox.Text)
                {
                    richTextBox1.Text = item.ToString();
                    pictureBox1.Image = Image.FromFile(Environment.CurrentDirectory + @"\Race Pictures\" + item.CharacterName + ".png");
                }
                item.JobStat();
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

        private void SaveButton_Click(object sender, EventArgs e)
        {
            var path = System.IO.Path.Combine(Environment.CurrentDirectory, "Race_List.json");
            var characterPath = System.IO.Path.Combine(Environment.CurrentDirectory, "Selected_Character.json");
            var Race_root = JsonConvert.SerializeObject(RaceList);
            //var Char_root = JsonConvert.SerializeObject(richTextBox1.);
            System.IO.File.WriteAllText(path, Race_root);
            System.IO.File.WriteAllText(characterPath, Char_root);
        }
    }
}
