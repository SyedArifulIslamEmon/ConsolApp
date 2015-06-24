using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str = new string[2] { "Hello", "World" };
            //Console.WriteLine(str[1]);
            Console.WriteLine(Array.IndexOf(str,"World"));

            Console.ReadKey();
            int[] numbers = new int[5];

            numbers[0] = 1;
            numbers[1] = 14;
            numbers[2] = 84;
            numbers[3] = 55;
            numbers[4] = 24;
            //Array.Sort(numbers);
            //Array.Reverse(numbers);
            //Console.WriteLine("Length: " + numbers.Length);
            //for (int i=0; i<5; i++)
            //{

            //    //numbers[i] = Convert.ToInt16(Console.ReadLine());
            //    Console.WriteLine(numbers[i]);

            //}
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }
            Console.ReadKey();

        }
    }
}
