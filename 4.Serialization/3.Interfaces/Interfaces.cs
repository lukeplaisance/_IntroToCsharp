using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Interfaces
{
    public interface ILoggable
    {
        void Log();
        string Name { get; set; }
    }

    public class Animal : ILoggable
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public void Log()
        {
            Console.WriteLine(name);
        }
    }

    public class Vehicle : ILoggable
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public void Log()
        {
            Console.WriteLine(name);
        }
    }
    class Program
    {
        static public void Test(List<ILoggable> loggables)
        {
            foreach (var loggable in loggables)
            {
                loggable.Log();
            }
        }
        static void Main(string[] args)
        {
            #region
            //Test(new List<ILoggable>()
            //{
            //    (new Animal() {Name = "dog" }),
            //    (new Animal() { Name = "cat" }),
            //    (new Animal() { Name = "horse" }),
            //    (new Animal() { Name = "cow" }),
            //    (new Animal() { Name = "lizard" }),
            //    (new Vehicle() { Name = "subaru" }),
            //    (new Vehicle() { Name = "ford" }),
            //    (new Vehicle() { Name = "nissan" }),
            //});
            //Console.ReadLine();
            #endregion
        }
    }
}
