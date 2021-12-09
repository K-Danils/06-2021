using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Path.GetFullPath("../../lear.txt");
            string text = System.IO.File.ReadAllText(path);
            var lines = System.IO.File.ReadAllLines(path);
            string[] words = text.Replace("\r\n", " ").Split(' ');
            string[] words2 = text.Replace("\r\n", " ").Split('\'');
            string characters = text.Replace("\r\n","");

            Console.WriteLine("Lines = " + lines.Length);
            Console.WriteLine("Words = " + (words.Length - 1 + words2.Length - 1));

            Console.WriteLine("Chars = " + characters.Length);
            Console.ReadKey();
        }
    }
}
