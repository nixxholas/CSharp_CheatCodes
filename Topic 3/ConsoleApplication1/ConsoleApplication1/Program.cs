using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string string1 = "LOL";
            string string2 = "LOl";

            int i = 50;

            string f = i.ToString("P");

            Console.Write(f);
            Console.ReadKey();
        }
    }
}
