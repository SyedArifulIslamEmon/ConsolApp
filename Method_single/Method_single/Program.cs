using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_single
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetValue(45));
            Console.ReadKey();
        }
        static int GetValue(int firstNumber)
        {
            return firstNumber;
        }
    }
}
