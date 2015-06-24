using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutputTracingTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //int number = 0;

            //while (number < 10)
            //{
            //    if (number % 2 == 0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //    number = number + 1;
            //}
            //Console.ReadLine();

            string s1 = "ALL MEN ARE CREATED EQUAL";
            string s2;
            s2 = s1.Substring(12, 3);
            Console.WriteLine(s2);

            //int aNumber = 10;
            //int doubleOfaNumber = GetDouble(aNumber);
            //Console.WriteLine(doubleOfaNumber);
            Console.ReadKey();

        }

        //private int GetDouble(int aNumber)
        //{
        //    return aNumber * 2;
        //}

    }
}
