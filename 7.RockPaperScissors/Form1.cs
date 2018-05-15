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

namespace RockPaperScissors
{
    public partial class Form1 : Form
    {
        RPS game = new RPS
        {
            VictoryConiditions = new List<string>()
                {
                    "Rock>Scissors",
                    "Paper>Rock",
                    "Scissors>Paper"
                }
        };
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void RockButton_Click(object sender, EventArgs e)
        {
            game.SelectComputerChoice();
            PlayRound("Rock");
        }

        private void PaperButton_Click(object sender, EventArgs e)
        {
            game.SelectComputerChoice();
            PlayRound("Paper");
        }

        private void ScissorsButton_Click(object sender, EventArgs e)
        {
            game.SelectComputerChoice();
            PlayRound("Scissors");
        }
        public void PlayRound(string choice)
        {
            game.SelectPlayerChoice(choice);
            textBox3.Text = game.PlayerChoice + "\n";
            textBox2.Text = game.ComputerChoice + "\n";
            textBox1.Text = game.ToString();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            var path = System.IO.Path.Combine(Environment.CurrentDirectory, "RPS.json");
            var rps_root = JsonConvert.SerializeObject(game);
            System.IO.File.WriteAllText(path, rps_root);
        }
    }
}
