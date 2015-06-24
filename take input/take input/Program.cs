using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace take_input
{
    class Program
    {
        static void Main(string[] args)
        {
            string UserName = Console.ReadLine();
            Console.WriteLine(ReturnString(UserName));
            Console.ReadKey();
        }

        
        static string ReturnString(string firstStraing)
        {
            return "Hello " + firstStraing;
        }

        }
    }

