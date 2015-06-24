using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_2._1_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your Lower limit: ");
            int low = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Upper limit: ");
            int up = Convert.ToInt16(Console.ReadLine());

            for (int i = low; i <= up; i++)
            {
                Console.WriteLine(i);
                
            }
            Console.ReadKey();
        }
    }
}
