using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Serialization
{
    public class DialogueRoot
    {
        public List<DialogueNode> DialogueNodes = new List<DialogueNode>
        {
            new DialogueNode()
            {
                ConversationID = "C0N01-001A",
                ParticipantName = "Enpi Seeki",
                EmoteType = "Reg",
                Side = "Right",
                Line = "Welcome",
                SpecialtyAnimation = "none",
                SpecialtyCamera = "None",
                Participants = "3",
                ConvesationSummary = "this is the initial"
            }
        };
    }
}
