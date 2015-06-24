using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryIntroApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,string> aDictionary = new Dictionary<int, string>();

            aDictionary.Add(101,"CSE101");
            aDictionary.Add(102, "CSE201");
            aDictionary.Add(401, "EEE222");

            foreach (KeyValuePair<int,string> keyValuePair in aDictionary)
            {
                Console.WriteLine(keyValuePair.Key+" "+keyValuePair.Value);
                
            }

            aDictionary.Remove(401);

            Console.WriteLine(aDictionary.ContainsValue("EEE222"));
            Console.ReadKey();
        }
    }
}
