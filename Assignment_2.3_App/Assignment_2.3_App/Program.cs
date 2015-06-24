using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_2._3_App
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 1; i <= 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    Console.Write(i+" ");
                    sum = sum + i; 
                   
                }

            }
            Console.WriteLine("\nThe sum of all the multiples of 3 or 5 below 1000 is "+ sum);
            Console.ReadKey();
        }
    }
}
