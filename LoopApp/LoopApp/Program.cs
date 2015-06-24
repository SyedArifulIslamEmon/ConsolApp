using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 22;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            //do
            //{
            //   Console.WriteLine("Less than 25");
            //    number += 1;
            //} while (number>25);
            //while (number<25)
            //{
            //    Console.WriteLine("Greater than 20");
            //    number =number+ 1;
            //}


            //if (number < 30 || number>25)
            //{
            //    Console.WriteLine("Greater than 25");
            //}
            //else if (number != 20 || number==21)
            //{
            //    Console.WriteLine("Not Equal to 20");
            //}
            //else
            //{
            //    Console.WriteLine("Less than 30");
            //}


            Console.ReadKey();
        }
    }
}
