using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 97;
            double secondNumber = firstNumber;
            int thirdNumber = (int)secondNumber;
            char firstChar = Convert.ToChar(firstNumber);
            Console.WriteLine(firstChar);
            Console.ReadKey();
        }
    }
}
