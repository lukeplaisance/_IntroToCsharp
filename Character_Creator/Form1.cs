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

        public Form1()
        {
            InitializeComponent();
            RaceList.Add(new Race { Name = "Human" });
            RaceList.Add(new Race { Name = "Elf" });
            RaceList.Add(new Race { Name = "Ogre" });
            RaceList.Add(new Race { Name = "Dwarf" });

            JobList.Add(new Job { Name = Strings.ASSSASSIN });
            JobList.Add(new Job { Name = Strings.KNIGHT });
            JobList.Add(new Job { Name = Strings.MAGE });
            JobList.Add(new Job { Name = Strings.HEALER });
            JobList.Add(new Job { Name = Strings.SHARPSHOOTER });
            foreach (var item in RaceList)
            {
                RaceBox.Items.Add(item.Name);
                label5.Text = textBox1.Text;
            }
            foreach (var item in JobList)
            {
                JobBox.Items.Add(item.Name);
            }
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
                    item.GenStats();
                    richTextBox1.Text = item.ToString();
                }

            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            var path = System.IO.Path.Combine(Environment.CurrentDirectory, "Race_List.json");
            var Race_root = JsonConvert.SerializeObject(RaceList);
            System.IO.File.WriteAllText(path, Race_root);
            //var characterPath = System.IO.Path.Combine(Environment.CurrentDirectory, "Selected_Character.json");
            //var Char_root = JsonConvert.SerializeObject();
            //System.IO.File.WriteAllText(characterPath, Char_root);
        }
    }
}
