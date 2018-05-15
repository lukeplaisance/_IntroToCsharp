using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace _4.Serialization
{
    public class DialogueTree
    {
        public List<DialogueRoot> DialogueRoots = new List<DialogueRoot>();

        public void Dialogue()
        {
            var path = System.IO.Path.Combine(Environment.CurrentDirectory, "Dialogue.json");
            var derSerialize = JsonConvert.DeserializeObject<DialogueTree>
                (System.IO.File.ReadAllText(path));
            DialogueRoots.AddRange(derSerialize.DialogueRoots);
        }

        public void AddDialogue(DialogueRoot root)
        {
            DialogueRoots.Add(root);
        }
    }
}
