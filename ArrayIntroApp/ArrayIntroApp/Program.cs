using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayIntroApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5] { 15, 20, 47, 15, 91 };

            //Console.WriteLine(Array.IndexOf(numbers, 20));

            //Console.WriteLine(numbers);

            //Array.Reverse(numbers);
            Array.Sort(numbers);
            Array.Reverse(numbers);

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}



            Console.ReadKey();
            //numbers[0] = 15;
            //numbers[1] = 20;
            //numbers[2] = 47;
            //numbers[3] = 15;
            //numbers[4] = 91;
        }
    }
}
