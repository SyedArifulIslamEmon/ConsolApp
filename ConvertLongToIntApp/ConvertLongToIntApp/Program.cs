using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertLongToIntApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a long number: ");
           long value = Convert.ToInt64(Console.ReadLine());
            int convertValue=Convert.ToInt32(value);
            Console.WriteLine(convertValue);
            Console.ReadKey();


        }
    }
}
