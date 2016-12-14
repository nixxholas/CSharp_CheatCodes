using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q13
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;

            int[] numberArray = new int[100];

            for (i = 0; i < numberArray.Length; i++) {
                numberArray[i] = 1;
                i++;
                numberArray[i] = 2;
            }

            for(i = 0; i < numberArray.Length; i++) {
                Console.WriteLine("numberArray[{0}] -> {1}", i, numberArray[i]);
            }

            Console.ReadKey();
        }
    }
}
