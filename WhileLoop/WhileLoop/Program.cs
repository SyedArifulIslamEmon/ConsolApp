using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //int num = 20;
            //while (num < 25)
            //{
            //    Console.WriteLine("Less than 25");
            //    num += 1;
            //}
            //Console.ReadKey();
            //do
            //  {
            //    Console.WriteLine("Less than 25");
            //    num += 1;
            //}
            //while (num < 25);
            int Sum=0;
            for (int i = 1; i <=10 ; i++)
            {
                Console.WriteLine(i);
          
                Sum +=i;
            }
            Console.WriteLine(Sum);
            Console.ReadKey();
        }
    }
}
