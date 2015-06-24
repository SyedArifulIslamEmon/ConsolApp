using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_type_convertion
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = 12.5;
            int secondNumber = Convert.ToInt32(firstNumber);//also can use--->(int)firstNumber;//for converting double to int
            Console.WriteLine(secondNumber);
            //Console.ReadKey();//wait for pressing any key

            double firstNumber1 = 12.5;
            int secondNumber1 = (int)firstNumber1; //also can use--->Convert.ToInt32(firstNumber);//for converting double to int
            Console.WriteLine(secondNumber1);
            //Console.ReadKey();//wait for pressing any key

            int firstnumber2 = 12;
            double secondnumber2 = firstnumber2;
            Console.WriteLine(secondnumber2);
            Console.ReadKey();
            
        }
    }
}
