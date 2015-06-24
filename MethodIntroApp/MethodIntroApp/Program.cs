using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodIntroApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = GetData("Hello", "World!");
            Console.WriteLine(value);
            Console.ReadKey();
        }

        static string GetData(string firstString, string secondString)
        {
            return firstString + " " + secondString;
        }
    }
}
