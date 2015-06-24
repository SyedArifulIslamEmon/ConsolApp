using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_2._2_App
{
    class Program
    {
        static void Main(string[] args)
        {
           

            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }

            }
            Console.ReadKey();
        }
    }
}
