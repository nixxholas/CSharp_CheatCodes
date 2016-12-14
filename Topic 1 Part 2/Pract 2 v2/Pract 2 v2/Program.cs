using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract_2_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question 8

            String character;
            int size;
            int nolines;
            int countNewLine;
            int noOfChar = 0;
            int countCharsDone;
            bool noerror = false;

            Console.WriteLine("Enter the character you wish to use for the triangle.");
            character = Console.ReadLine();

            do
            {
                Console.WriteLine("Enter the size of the triangle you want (1-10)");
                noerror = int.TryParse(Console.ReadLine(), out size);
            } while (noerror == false || size <= 0);

            if (size > 10) {
                size = 3;
            }

            //nolines = (2 * size) - 1;

            for (countNewLine = 1; countNewLine < size; countNewLine++)
            {
                Console.WriteLine("{0}", character);
                noOfChar++;
                for (countCharsDone = 0; countCharsDone < noOfChar; countCharsDone++)
                {
                    Console.Write("{0}", character);
                }
            }

            //Console.Write("{0}", character);

            //count = size;
            noOfChar = size -1;

            for (countNewLine = size -1; countNewLine > 0; countNewLine--) {
                Console.WriteLine("{0}", character);
                noOfChar--;
                for (countCharsDone = 0; countCharsDone < noOfChar; countCharsDone++)
                {
                    Console.Write("{0}", character);
                }
            }
            Console.WriteLine("{0}", character);
            Console.ReadKey();
        }
        
        }
    }
