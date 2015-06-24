using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertCharToASCIIApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a character: ");
            char val = Convert.ToChar(Console.ReadLine());
            int convertValue = Convert.ToInt32(val);
            Console.WriteLine(convertValue);
            Console.ReadKey();

        }
    }
}
