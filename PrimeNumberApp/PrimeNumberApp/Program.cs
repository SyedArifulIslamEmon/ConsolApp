using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrimeNumberApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, c = 2;//n=number,c=divisor

            Console.WriteLine("Enter a number to check if it is prime\n");
            n=Convert.ToInt16(Console.ReadLine());

            for (c = 2; c <= n - 1; c++)
            {
                if (n % c == 0)
                {
                    Console.WriteLine(n+" is not prime.\n");
                    break;
                }
            }
            if (c == n)
            {
                Console.WriteLine(n+" is prime.\n");
            }

            Console.ReadKey();
        }
    }
}
