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
using _4.Serialization;
using Newtonsoft.Json;

namespace _5.Winforms_Quiz
{
    public partial class Form1 : Form
    {
        Character player = new Character()
        {
            CharacterName = "Luke",
            Level = 0,
            ExperiencePoints = 0
        };
        public int LevelUp = 1000;

        public Form1()
        {
            InitializeComponent();
            progressBar1.Maximum = 1000;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            var path = System.IO.Path.Combine(Environment.CurrentDirectory, "player.json");
            var newPlayer = new Character();
            var player_string = JsonConvert.SerializeObject(newPlayer);
            System.IO.File.WriteAllText(path, player_string);
        }

        private void gainExp_Click(object sender, EventArgs e)
        {
            player.ExperiencePoints += 100;
            textBox1.Text = player.ToString();

            for (int i = 0; i < 1000; i++)
            {
                progressBar1.Value = player.ExperiencePoints;
                //progressBar1.PerformStep();
            }
            LevelUpCheck();
        }

        public void LevelUpCheck()
        {
            if (player.ExperiencePoints == LevelUp)
            {
                player.ExperiencePoints = 0;
                player.Level += 1;
            }
        }

        private void expBar_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
