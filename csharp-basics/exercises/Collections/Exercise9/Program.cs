using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            var hashSet = new HashSet<string>();
            hashSet.Add("word1");
            hashSet.Add("word2");
            hashSet.Add("word3");
            hashSet.Add("word4");
            hashSet.Add("word5");

            foreach (string word in hashSet)
            {
                Console.WriteLine(word);
            }

            hashSet.Clear();

            hashSet.Add("not possible");
            hashSet.Add("not possible");

            foreach (string word in hashSet)
            {
                Console.WriteLine(word);
            }

            Console.ReadKey();
        }
    }
}
