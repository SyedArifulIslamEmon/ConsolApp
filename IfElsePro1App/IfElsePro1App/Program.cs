using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElsePro1App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int aNumber = Convert.ToInt32(Console.ReadLine());
            if (aNumber <= 100 && aNumber >= 80)
            {
                Console.WriteLine("Grade is A+");
            }
            else if (aNumber <=79 && aNumber >=70)
            {
                Console.WriteLine("Grade is A");
            }
            else if (aNumber <= 69 && aNumber >= 60)
            {
                Console.WriteLine("Grade is B");

            }
            else if (aNumber <= 59 && aNumber >= 50)
            {
                Console.WriteLine("Grade is C");

            }
            else if (aNumber <= 49 && aNumber >= 40)
            {
                Console.WriteLine("Grade is D");

            }
            else if (aNumber <= 39 && aNumber >= 0)
            {
                Console.WriteLine("Grade is F");

            }
            else
            {
                Console.WriteLine("Out of Range");
                
            }
            Console.ReadKey();
        }
    }
}
