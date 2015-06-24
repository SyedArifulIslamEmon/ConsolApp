using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypeConversionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = 10.123;
            long secondNumber = Convert.ToInt64(firstNumber);
            int value = 97;
            char aChar = (char) value;

            Console.WriteLine(aChar);
            Console.ReadKey();
        }
    }
}
