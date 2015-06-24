using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            int aNumber = 30;
            int bNumber = 25;

            if (aNumber == bNumber)
            {
                Console.WriteLine("Equal");
                Console.ReadKey();

            }
            else
            {
                Console.WriteLine("Not Equal");
                Console.ReadKey();
                
            }
            //if (aNumber < 20)
            //{
            //    Console.WriteLine("Less than 20");
            //    Console.ReadKey();
            //}
            //else if (aNumber < 30)
            //{
            //    Console.WriteLine("Less than 30");
            //    Console.ReadKey();
            //}
            //else
            //{
            //    Console.WriteLine("Greater than 20");
            //    Console.ReadKey();
            //}
        }
    }
}
