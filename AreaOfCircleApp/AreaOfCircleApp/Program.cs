using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfCircleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the radius:");
            int r = Convert.ToInt32(Console.ReadLine());
           
            CircleArea(r);

        }
        static int CircleArea(int radius)
        {
          
            double result = Math.PI * radius * radius;
            Console.WriteLine("Area: " + result);
            Console.ReadKey();
            return 0;
        }
    }
}
