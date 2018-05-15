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
        public List<Race> RaceList = new List<Race>();
        public List<Job> JobList = new List<Job>();
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
            for(int i = 0; i < RaceList.Count; i++)
            {
                if(RaceBox.Text == RaceList[i].CharacterName)
                {
                    richTextBox1.Text = RaceList[i].ToString();
                }
            }
        }

        private void JobBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            for(int i = 0; i < JobList.Count; i++)
            {
                if(JobBox.Text == JobList[i].Name)
                {
                    richTextBox1.Text = JobList[i].ToString();
                }
            }
        }

        private void GenCharacter_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            Race newRace = new Race()
            {
                CharacterName = textBox1.Text,
                Level = 0,
                ExperiencePoints = 0
            };
            Job newJob = new Job();
            RaceList.Add(newRace);
            newRace.GenRaces();
            RaceBox.Items.Add(newRace.CharacterName);
            JobList.Add(newJob);
            newJob.GenJobs();
            JobBox.Items.Add(newJob.Name);

        }
    }
}
