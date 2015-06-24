using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListIntroductionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int>myList =new List<int>();
            myList.Add(4);
            myList.Add(9);
            myList.Add(24);
            Console.WriteLine("Index number: "+myList.IndexOf(24));
            int sum = 0;
            foreach (int i in myList)
            {
                Console.WriteLine(i);
               
                sum += i;

            }
            Console.WriteLine("Sum = "+ sum);
            List<string> secondList= new List<string>();
            secondList.Add("BITM");
            secondList.Add("Nerd Castle");
            foreach (string s in secondList)
            {
                Console.WriteLine(s);

            }
            Console.ReadKey();
        }
    }
}
