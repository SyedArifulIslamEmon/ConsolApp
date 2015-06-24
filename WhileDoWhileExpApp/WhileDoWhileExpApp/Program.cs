using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileDoWhileExpApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int aNumber = 20;
            //while (aNumber==30)
            //{
            //    Console.WriteLine("Less than 30");
            //    aNumber++;
            //}

            do
            {
                Console.WriteLine("less than 30");
                aNumber++;
            } while (aNumber<22);
           
            Console.ReadKey();
        }
    }
}
