using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_multi
{
    class Program
    {
        static void Main(string[] args)
        {

            
            Console.WriteLine(GetValueAdd(45, 15));
            Console.WriteLine(GetValueSub(45, 15));
            Console.WriteLine(GetValueDiv(45, 15));
            Console.WriteLine(GetValueMul(45, 15));
            Console.ReadKey();
        }

        

        static int GetValue(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;

        }

        static int GetValueAdd(int a, int b)
        {
            return a+b;

        }

        static int GetValueSub(int a, int b)
        {
            return a - b;

        }

        static int GetValueDiv(int a, int b)
        {
            return a / b;

        }

        static int GetValueMul(int a, int b)
        {
            return a *   b;

        }

        

        }
    }

