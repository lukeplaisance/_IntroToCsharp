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
        //created to make sure stat names are all the same
        Charisma,
        Constitution,
        Intelligence,
        Strength,
        Dexterity,
        Wisdom,
    }
    public partial class Form1 : Form
    {
        //List that stores all the races to use in the application
        public List<Race> RaceList = new List<Race>();
        //List that stores all the jobs to use in the application
        public List<Job> JobList = new List<Job>();
        //Member variable to represent the selected character
        public Character rt_Character;
        //Member variable to represent the current Race
        public Race ActiveRace;
        //Member variable to represent the current Job
        public Job ActiveJob;
        //Path to the .json file that contains the current character data when you load back up
        public string characterPath = System.IO.Path.Combine(Environment.CurrentDirectory, "Selected_Character.json");

        //Prototype : Form1()
        //Argument : none
        //Description : initializes the Race and Job list to new them up
        //Precondition : an instance of the Form1 class
        //Postcondition : initializes the Race and Job list to new them up
        //Protection Level : Public
        public Form1()
        {
            InitializeComponent();
            RaceList.Add(new Race(Strings.HUMAN));
            RaceList.Add(new Race(Strings.ELF));
            RaceList.Add(new Race(Strings.OGRE));
            RaceList.Add(new Race(Strings.DWARF));
                                 
            JobList.Add(new Job(Strings.ASSASSIN));
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

        //Prototype : Form1()
        //Argument : none
        //Description : loads up Form1()
        //Precondition : an instance of the Form1 class
        //Postcondition : loads up Form1()
        //Protection Level : Private
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Prototype : private void RaceBox_SelectedIndexChanged(object sender, EventArgs e)
        //Argument : (object sender, EventArgs e)
	    //Description : method for when you select a race in the combo box
        //Precondition : an instance of the Form1 class
        //Postcondition : writes the name and stats of the Race and draws the picture along with it
        //Protection Level : private
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

        //Prototype : private void JobBox_SelectedIndexChanged(object sender, EventArgs e)
        //Argument : (object sender, EventArgs e)
	    //Description : method for when you select a job in the combo box
        //Precondition : an instance of the Form1 class
        //Postcondition : writes the name of the  job in the textbox
        //Protection Level : private
        private void JobBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        //Prototype : private void GenCharacter(object sender, EventArgs e)
        //Argument : (object sender, EventArgs e)
	    //Description : method to add the name of the race in the combobox and generates the character
        //Precondition : an instance of the Form1 class
        //Postcondition : adds the name of the race in the combobox and generates the character
        //Protection Level : private
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

        //Prototype : private void SaveButton(object sender, EventArgs e)
        //Argument : (object sender, EventArgs e)
	    //Description : method to serialize the character stats and put them into a.json file
        //Precondition : an instance of the Form1 class
        //Postcondition : serializes the character stats and put them into a.json file
        //Protection Level : private
        private void SaveButton_Click(object sender, EventArgs e)
        {
            var characterPath = System.IO.Path.Combine(Environment.CurrentDirectory, "Selected_Character.json");            
            var Char_root = JsonConvert.SerializeObject(rt_Character);
            System.IO.File.WriteAllText(characterPath, Char_root);
        }
    }
}
