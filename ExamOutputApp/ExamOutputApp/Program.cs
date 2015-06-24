using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamOutputApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //int count = 0;
            //bool isGood = false;
            //while (true)
            //{
            //    count++;
            //    if (count >= 3)
            //    {
            //        isGood = true;
            //    }
            //    if (count >= 5 && isGood == true)
            //    {
            //        break;
            //    }
            //}
            //Console.WriteLine(count);



            //string s1 = "ALL MEN ARE CREATED EQUAL";
            //string s2;
            //s2 = s1.Substring(12, 3);
            //Console.WriteLine(s2);

            int aNumber = 10;
            int doubleOfaNumber = GetDouble(aNumber);
            Console.WriteLine(doubleOfaNumber);
            Console.ReadKey();


            Console.ReadKey();
        }
        
        private int GetDouble(int aNumber)
        {
            return aNumber * 2;
        }

        }
    }

