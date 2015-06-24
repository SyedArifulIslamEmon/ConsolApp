using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodIntroductionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //string userName = Console.ReadLine();
            //string message = GetValue();
            //Console.WriteLine(message+userName);
            ////Console.ReadKey();

         int r = Convert.ToInt32(Console.ReadLine());
            CirclePerimeter(r);
            CircleArea(r);
          
            //int b = Convert.ToInt32(Console.ReadLine()); 
           
            //Console.WriteLine(CalculateValue(a,b));
            
            //Console.WriteLine(CalculateValue2(a,b));
         
            //Console.WriteLine(CalculateValue3(a,b));
          
            //Console.WriteLine(CalculateValue4(a,b));
            Console.ReadKey();
        }

        static string GetValue()
        {
            string userName = Console.ReadLine();
            return "Hello World ";
        }

      static int CalculateValue(int firstNumber, int secondNumber)
      {
          int result = firstNumber + secondNumber;
          return result;
      }
      static int CalculateValue2(int firstNumber, int secondNumber)
      {
          int result = firstNumber - secondNumber;
          return result;
      }
      static int CalculateValue3(int firstNumber, int secondNumber)
      {
          int result = firstNumber * secondNumber;
          return result;
      }
      static int CalculateValue4(int firstNumber, int secondNumber)
      {
          int result = firstNumber / secondNumber;
          return result;
      }

        static int CirclePerimeter(int radius)
        {
            //double pie = 3.1416;
            double result = 2*Math.PI*radius;
            Console.WriteLine("Perimeter: " + result);
            Console.ReadLine();
            return 0;
        }
        static int CircleArea(int radius)
        {
            //double pie = 3.1416;
            double result = Math.PI* radius * radius;
            Console.WriteLine("Area: " + result);
            Console.ReadLine();
            return 0;
        }
    }
}
