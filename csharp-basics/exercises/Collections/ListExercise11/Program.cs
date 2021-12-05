using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExercise11
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = new List<String>
            {
                "money",
                "ice cream",
                "book",
                "computer",
                "notes",
                "monitor",
                "phone",
                "tree",
                "apple",
                "chocolate"
            };

            words.Insert(4, "dog");
            words[words.Count - 1] = "keyboard";
            words.Sort();

            bool containsFoobar = words.Contains("Foobar");

            words.ForEach(x => Console.WriteLine(x));

            Console.ReadKey();
        }
    }
}
