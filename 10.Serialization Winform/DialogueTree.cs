using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace _4.Serialization
{
    class DialogueTree
    {
        List<DialogueRoot> DialogRoots = new List<DialogueRoot>();


        public void Serialize()
        {
            var path = System.IO.Path.Combine(Environment.CurrentDirectory, "Dialogue.json");
            var newTree = new DialogueTree();
            var dialogue_string = JsonConvert.SerializeObject(newTree);
            System.IO.File.WriteAllText(path, dialogue_string);
            DialogueTree dialogue_tree = JsonConvert.DeserializeObject<DialogueTree>(dialogue_string);
        }
    }
}
