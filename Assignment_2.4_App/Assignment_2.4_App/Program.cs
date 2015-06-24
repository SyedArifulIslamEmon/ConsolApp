using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_2._4_App
{
    class Program
    {
        static void Main(string[] args)
        {
            int SumOfSqr = 0;
            int SqrOfSum = 0;
            for (int i = 1; i <= 100; i++)
            {

                SumOfSqr = SumOfSqr+( i*i) ;
                SqrOfSum = SqrOfSum + i;

                

            }
            int result = (SqrOfSum * SqrOfSum) - SumOfSqr;
            int rslt = (SqrOfSum*SqrOfSum);
            Console.WriteLine("The sum of the squares is " + SumOfSqr);
            Console.WriteLine("The square of the sum is " + rslt);
            Console.WriteLine("The difference between the sum of the squares of the first one hundred natural numbers and the square of the sum is " + result);
            Console.ReadKey();
        }
    }
}
