using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculateBonusApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your salary here");
            int salary = Convert.ToInt16(Console.ReadLine());
            int bonus = 0;
            if (salary < 0)
            {
                Console.WriteLine("Please enter real number.");
            }
            else if (salary > 10000)
            {
                bonus = (salary * 5) / 100;
                Console.WriteLine("Your bonus is " + bonus + " tk");

            }
            else if ((salary < 10000 || salary==10000) && (salary>8000 || salary==8000))
            {
                bonus = (salary * 6) / 100;
                Console.WriteLine("Your bonus is " + bonus + " tk");

            }
            else
            {
                bonus = (salary * 7) / 100;
                Console.WriteLine("Your bonus is " + bonus + " tk");

            }

            Console.ReadKey();  

        }
    }
}
