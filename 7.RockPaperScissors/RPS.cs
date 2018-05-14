using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class RPS
    {
        public string PlayerChoice { get; set; }
        public string ComputerChoice { get; set; }
        public List<string> VictoryConiditions;
        public void SelectPlayerChoice(string choice)
        {
            PlayerChoice = choice;
        }
        public void SelectComputerChoice()
        {
            Random r = new Random();
            var value = r.Next(1, 4);
            switch (value)
            {
                case 1:
                    ComputerChoice = "Rock";
                    break;
                case 2:
                    ComputerChoice = "Paper";
                    break;
                case 3:
                    ComputerChoice = "Scissors";
                    break;
                case 4:
                    ComputerChoice =" same as " + PlayerChoice;
                    break;
            }
            CheckForVictory();
        }
        public bool CheckForVictory()
        {
            string check = PlayerChoice + ">" + ComputerChoice;
            if (VictoryConiditions.Contains(check))
            {
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            string result = "";
            if (CheckForVictory())
            {
                result = "Player Wins!";
            }
            else if (PlayerChoice == ComputerChoice)
                result = "Draw";
            else
                result = "Computer Wins!";
            return result;

        }
    }
}
