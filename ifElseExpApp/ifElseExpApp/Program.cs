using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElseExpApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int aNumber = 13;
            if (aNumber != 30 && aNumber==34)
            {
                Console.WriteLine("Less Than 30");
            }
            else if (aNumber<20 || aNumber>10)
            {
                Console.WriteLine("Less than 20");
            }
            else
            {
                Console.WriteLine("A Number");
            }
            Console.ReadKey();
        }
    }
}
