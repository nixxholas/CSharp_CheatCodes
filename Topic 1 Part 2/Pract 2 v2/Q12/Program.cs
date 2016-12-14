using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q12
{
    class Program
    {
        static void Main(string[] args)
        {
            int seconds;
            int hours;
            int minutes;

            do
            {
                Console.WriteLine("Please enter the number of seconds.");
            } while (int.TryParse(Console.ReadLine(), out seconds) == false);

            hours = seconds / 3600;
            seconds = seconds - (hours * 3600);
            minutes = seconds / 60;
            seconds = seconds - (minutes * 60);

            Console.WriteLine("{0} Hours", hours);
            Console.WriteLine("{0} Minutes", minutes);
            Console.WriteLine("{0} Seconds", seconds);

            Console.ReadKey();
        }
    }
}
