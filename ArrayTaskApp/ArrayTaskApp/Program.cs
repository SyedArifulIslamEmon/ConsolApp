using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayTaskApp
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] numbers=new string[5];
            Console.WriteLine("Enter five numbers: ");
            int sum = 0;
            for (int i = 0; i < 5; i++)
            {
                numbers[i] = Console.ReadLine();
                sum += Convert.ToInt16(numbers[i]);


            }
            Console.WriteLine("Sum is "+sum);
            Console.ReadKey();
        }
    }
}
