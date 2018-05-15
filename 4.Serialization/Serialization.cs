using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.Containers;
using Newtonsoft.Json;

namespace _4.Serialization
{
    public class Stats
    {
        public List<Stat> statList = new List<Stat>()
        {
            new Stat("Strength", 100),
            new Stat("Speed", 45),
            new Stat("Intelligence", 50),
            new Stat("Charisma", 30)
        };
    }

    class Program
    {
        static void Main(string[] args)
        {
            #region
            //var path = System.IO.Path.Combine(Environment.CurrentDirectory, "stats.txt");
            //var stats = new Stats();
            //var stat_string = JsonConvert.SerializeObject(stats);
            //System.IO.File.WriteAllText(path, stat_string);
            #endregion
            var path = System.IO.Path.Combine(Environment.CurrentDirectory, "Sample.json");
            var newTree = new DialogueTree();
            newTree.Dialogue();
            var dialogue_root = JsonConvert.SerializeObject(newTree);
            System.IO.File.WriteAllText(path, dialogue_root);
        }
    }
}
