using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter radius: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Area: " + CalculateArea(radius));
            Console.WriteLine("Perimeter: " + CalculatePerimeter(radius));
            Console.ReadKey();
        }

        static double CalculateArea(double radius)
        {
            return Math.PI * radius * radius;
        }
        static double CalculatePerimeter(double radius)
        {
            return 2 * Math.PI * radius;
        }
    }
}
