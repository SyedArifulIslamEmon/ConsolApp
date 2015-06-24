using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintGreetingToUserApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name ");
            string userName = Console.ReadLine();

            Console.WriteLine("Hi "+userName+", have a nice day.");

            Console.ReadKey();
        }
    }
}
