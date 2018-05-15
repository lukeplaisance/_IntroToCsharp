using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vector_Library
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector2 a = new Vector2(2, 4);
            Vector2 b = new Vector2(3, 4);
            Vector2 c = new Vector2(2, 4);
            Vector2 add = a + b;
            float result = a.Magnitude();
            Vector2 result_2 = a.Normalize();
            Console.WriteLine(result_2);
            Console.ReadLine();

        }
    }
}
