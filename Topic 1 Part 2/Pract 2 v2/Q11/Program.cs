using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q11
{
    class Program
    {
        static void Main(string[] args)
        {
            double height;
            double width;
            double area;
            double perimeter;

            do
            {
                Console.WriteLine("Please enter the height of the rectangle.");
            } while (double.TryParse(Console.ReadLine(), out height) == false);
            do
            {
                Console.WriteLine("Please enter the width of the rectangle.");
            } while (double.TryParse(Console.ReadLine(), out width) == false);

            area = Area(height, width);
            perimeter = Perimeter(height, width);
            display(height, width, area,perimeter);

            Console.ReadKey();
        }

        static double Area(double height, double width) {
            double Area;
            Area = height * width;
            return Area;
        }

        static double Perimeter(double height, double width) {
            double perimeter;
            perimeter = (2 * height) + (2 * width);
            return perimeter;
        }

        static void display(double height, double width, double area, double perimeter) {
            Console.WriteLine("Height: \t{0}", height);
            Console.WriteLine("Width: \t{0}", width);
            Console.WriteLine("Area: \t{0}", area);
            Console.WriteLine("Perimeter: \t{0}", perimeter);
        }
    }
}
