using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q14
{
    class Program
    {
        static void Main(string[] args)
        {
            int highestval = 0;
                int i = 0;

            int[] intArray = new int[5] { 11, 0, 10, 2, 2 };

            for (i = 0; i < intArray.Length; i++) {
                if (intArray[i] > highestval) {
                    highestval = intArray[i];
                }
            }

            for (i = 0; i < intArray.Length; i++)
            {
                if (intArray[i] > highestval)
                {
                    Console.Write(intArray[i]);
                }
            }
    }
}
