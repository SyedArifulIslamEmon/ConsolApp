using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableIntroApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable aHashtable = new Hashtable();

            aHashtable.Add(101,101001);
            aHashtable.Add("Key","Value");
            aHashtable.Add(110,"Hello");
            aHashtable.Add("BITM",201);

            Console.WriteLine(aHashtable.ContainsValue("Value"));
            Console.WriteLine(aHashtable.ContainsKey(111));
            Console.WriteLine(aHashtable.Contains(110));

            Console.WriteLine(aHashtable[110]);
           


            Console.ReadKey();
        }
    }
}
