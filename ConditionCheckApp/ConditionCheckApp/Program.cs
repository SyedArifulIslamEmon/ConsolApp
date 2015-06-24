using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionCheckApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int aNumber = 25;
            int bNumber = 30;
            if (aNumber == bNumber)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }
            //if (aNumber < 20)
            //{
            //    Console.WriteLine("Less than 20");
            //}
            //else if(aNumber<30)
            //{
            //    Console.WriteLine("Less than 30");
            //}
            //else
            //{
            //    Console.WriteLine("Greater than 30");
            //}
            Console.ReadLine();
        }
    }
}
