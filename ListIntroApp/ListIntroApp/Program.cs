using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListIntroApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> myList = new List<string>();

            myList.Add("SEIP Project");
            myList.Add("BITM");
            myList.Add("Nerd Castle");
            

            //myList.Sort();

            Console.WriteLine(myList.IndexOf("SEIP Project"));

            foreach (string s in myList)
            {
                Console.WriteLine(s);
            }

            Console.ReadKey();
        }
    }
}
