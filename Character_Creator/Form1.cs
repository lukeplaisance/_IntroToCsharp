using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Character_Creator
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
        public Character rt_Character;
        public Race ActiveRace;
        public Job ActiveJob;
        public string characterPath = System.IO.Path.Combine(Environment.CurrentDirectory, "Selected_Character.json");

        public Form1()
        {
            InitializeComponent();
            RaceList.Add(new Race(Strings.HUMAN));
            RaceList.Add(new Race(Strings.ELF));
            RaceList.Add(new Race(Strings.OGRE));
            RaceList.Add(new Race(Strings.DWARF));
                                 
            JobList.Add(new Job(Strings.ASSSASSIN));
            JobList.Add(new Job(Strings.KNIGHT));
            JobList.Add(new Job(Strings.HEALER));
            JobList.Add(new Job(Strings.MAGE));
            JobList.Add(new Job(Strings.SHARPSHOOTER));
           
            foreach (var item in RaceList)
            {
                RaceBox.Items.Add(item.Name);
            }
            foreach (var item in JobList)
            {
                JobBox.Items.Add(item.Name);
            }

            var char_data = System.IO.File.ReadAllText(characterPath);
            rt_Character = JsonConvert.DeserializeObject<Character>(char_data);
            richTextBox1.Text = rt_Character.ToString();
            textBox1.Text = rt_Character.Name;
            RaceBox.Text = rt_Character.m_race.Name;
            JobBox.Text = rt_Character.m_job.Name;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void RaceBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var item in RaceList)
            {
                if (item.Name == RaceBox.Text)
                {
                    pictureBox1.Image = Image.FromFile(Environment.CurrentDirectory + @"\Race Pictures\" + item.Name + ".png");
                    ActiveRace = item;
                }
            }
        }

        private void JobBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void GenCharacter_Click(object sender, EventArgs e)
        {
            foreach(var item in JobList)
            {
                if(item.Name == JobBox.Text)
                {
                    label5.Text = textBox1.Text;
                    ActiveJob = item;
                    rt_Character = new Character(textBox1.Text, ActiveJob , ActiveRace);
                    richTextBox1.Text = rt_Character.ToString();
                }

            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            var characterPath = System.IO.Path.Combine(Environment.CurrentDirectory, "Selected_Character.json");            
            var Char_root = JsonConvert.SerializeObject(rt_Character);
            System.IO.File.WriteAllText(characterPath, Char_root);
        }
    }
}
