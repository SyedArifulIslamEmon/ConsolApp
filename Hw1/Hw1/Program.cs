using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw1
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            //    int r = Convert.ToInt32(Console.ReadLine());
            //    double  a = 3.14159265359 * r * r;
            //    double  p = 2 * 3.14159265359 * r;
            //    Console.WriteLine("Area: " + a);
            //    Console.WriteLine("Perimeter: " + p);
            //    Console.ReadKey();
            //}



            //    int r = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine(GetArea(r));
            //    Console.WriteLine(GetPerimeter(r));
            //    Console.ReadKey();
            //}

            //static double GetArea(double r)
            //{
            //    double a = 3.14159265359 * r * r;
            //    return a;
            //}

            //static double GetPerimeter(double r)
            //{
            //    double p = 2 * 3.14159265359 * r;  
            //    return p;
            //}

            Console.Write("Radius: ");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Perimeter: " + CalculatePerimeter(r));
            Console.WriteLine("Area: " + CalculateArea(r));
            Console.ReadKey();
        }

        private static double CalculatePerimeter(double r)
        {
            return 2*Math.PI*r;
        }

        private static double CalculateArea(double r)
        {
            return Math.PI * r * r;
        }
    }
}

