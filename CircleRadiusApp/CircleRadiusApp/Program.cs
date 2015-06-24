using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleRadiusApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Radius: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Perimeter: " + CalculatePerimeter(radius));
            Console.WriteLine("Area: " + CalculateArea(radius));
            Console.ReadKey();
        }

        static double CalculatePerimeter(double radius)
        {
            return 2 * Math.PI * radius;
        }

        static double CalculateArea(double radius)
        {
            return Math.PI * radius * radius;
        }
    }
}
