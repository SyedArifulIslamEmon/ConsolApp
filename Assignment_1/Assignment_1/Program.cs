using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_1
{
    class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Please enter your number: ");
            double grd = Convert.ToDouble(Console.ReadLine());
            aGrade(grd);
            String message = aGrade(grd);
            Console.WriteLine(message);
            Console.ReadKey();
        }

        static string aGrade(double g)
            {
                if (g <= 100 && g >= 80)
                {
                   return "Your grade is A+";
                }
                else if (g <= 79 && g >= 70)
                {
                    return "Your grade is A";
                }
                else if (g <= 69 && g >= 60)
                {
                  return "Your grade is A-";
                }
                else if (g <= 59 && g >= 50)
                {
                    return "Your grade is B+";
                }
                else if (g <= 49 && g >= 40)
                {
                    return "Your grade is B-";
                }
                else if (g <= 39 && g >= 0)
                {
                    return "Your grade is F";
                }
                else
                {
                   return "Please enter number between 0 to 100";
                } 
                
                
            }
        }
    }
