using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverviewApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int>aStack= new Stack<int>();
            aStack.Push(101);
            aStack.Push(251);
            aStack.Push(320);
            Console.WriteLine(aStack.Peek());//show the top value of the stack

            aStack.Pop();

            Console.WriteLine(aStack.Peek());

            Console.ReadKey();

        }
    }
}
