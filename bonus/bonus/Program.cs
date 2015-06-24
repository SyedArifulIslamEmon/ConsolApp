using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bonus
{
    class Program
    {
        static void Main(string[] args)
        {

            double bonuss;
            
           // double totalSalaryAsNum;
            Console.Write("Salary: ");
            int salary = Convert.ToInt32(Console.ReadLine());
            
            if (salary > 10000)
                bonuss =salary* 0.05;
            else if (salary >= 8000 && salary <= 10000)
                bonuss = salary*0.06;
            else
                bonuss = salary*0.07;
            
           // totalSalaryAsNum = salary + bonuss;;
            Console.WriteLine("bonus: " + bonuss);
            Console.ReadKey();
        }
    }
}
