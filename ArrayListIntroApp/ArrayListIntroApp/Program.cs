using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListIntroApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList myArrayList = new ArrayList();

            myArrayList.Add(10);
            myArrayList.Add(20);
            myArrayList.Add(94);

            //myArrayList.Sort();
            myArrayList.Reverse();

            for (int i = 0; i < myArrayList.Count; i++)
            {
                Console.WriteLine(myArrayList[i]);
            }

            

            Console.ReadKey();
        }
    }
}
