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

namespace _2.CombatForms
{
    public partial class Form1 : Form
    {
        public List<Character> Characters = new List<Character>();
        public Form1()
        {
            InitializeComponent();
        }

        private void GenPlayer_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            Console.WriteLine("button click");
            Random r = new Random();
            //Stat a = (Stat) 1;
            Character newChar = new Character()
            {
                CharacterName = textBox1.Text,
                Level = r.Next(1, 11),
                ExperiencePoints = r.Next(1, 11)
            };
            Characters.Add(newChar);
            newChar.GenCharacter();
            comboBox1.Items.Add(newChar.CharacterName);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            for (int i = 0; i < Characters.Count; i++)
            {
                if (comboBox1.Text == Characters[i].CharacterName)
                {
                    richTextBox1.Text = Characters[i].ToString();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
