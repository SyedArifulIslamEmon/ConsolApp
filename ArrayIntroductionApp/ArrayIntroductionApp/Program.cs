using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayIntroductionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] numbers = new int[5] { 5, 28, 72, 8, 36 };
            //Array.Sort(numbers);
            //Console.WriteLine(numbers[1]);
            ArrayList array = new ArrayList();
            array.Add(1);
            array.Add("Hello");
            array.Add(1.5);
            Console.WriteLine(array[0]);
            //foreach (var a in array)
            //{
            //    Console.WriteLine(a);
            //}
            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}
            //string[] arrayOfString = new string[3];
            //arrayOfString[0] = "Hello";
            //arrayOfString[1] = "SEIP";
            //arrayOfString[2] = "Index 2";
            //foreach (string str in arrayOfString)
            //{
            //    Console.WriteLine(str);
            //}
            //Console.WriteLine(arrayOfString[3]);
            Console.ReadKey();
        }
    }
}
