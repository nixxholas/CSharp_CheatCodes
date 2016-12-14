using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q9
{
    class Program
    {
        static void Main(string[] args)
        {
            int credit = 0;
            int creditconv;
            double totalpts = 0.0;
            double TempStore = 0;
            double GPA;
            int count = 1;
            bool error = false;
            bool done = false;

            do
            {
                error = false;
                Console.WriteLine("Please enter score for module #{0}. Enter 0 to stop.", count);
                switch (Console.ReadLine())
                {
                    case "A":
                        TempStore = 4.0;
                        break;
                    case "B":
                        TempStore = 3.0;
                        break;
                    case "C":
                        TempStore = 2.0;
                        break;
                    case "D":
                        TempStore = 1.0;
                        break;
                    case "0":
                        done = true;
                        break;
                    default:
                        Console.WriteLine("Error. Please enter a value of A,B,C or D only.");
                        error = true;
                        break;
                }

                if (error != true && done != true)
                {
                    do
                    {
                        Console.WriteLine("Enter the number of credits for module #{0}", count);
                        error = int.TryParse(Console.ReadLine(), out creditconv);
                    } while (error == false || creditconv <= 0); //Note: Error false means there is an error here.
                    totalpts = totalpts + (TempStore * creditconv);
                    credit = credit + creditconv;
                    count++;
                }
            } while (done != true);

            GPA = totalpts / credit;

            Console.WriteLine("Your GPA is {0:f2}.", GPA);

            Console.ReadKey();
        }
    }
}
