using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCount
{
    public class WordCounter
    {
        public WordCounter()
        {
        }

        public int CountWords(string text)
        {
            if (String.IsNullOrEmpty(text)) { return 0; }
            
            var words = text.Replace("\r\n", " ").Split(' ');
            int count = words.ToList().Where(x => !String.IsNullOrEmpty(x)).Count();

            // count the words separated by ', for example it's => it is
            count += text.Split('\'').Length - 1;

            return count;
        }

        public int CountCharacters(string text)
        {
            if (String.IsNullOrEmpty(text)) { return 0; }

            return text.Replace("\r\n", "").Length;
        }

        public int CountLines(string text)
        {
            if (String.IsNullOrEmpty(text)) { return 0; }

            return text.Split('\n').Length;
        }
    }

    class Program
    {
       
        static void Main(string[] args)
        {
            string path = @"../../lear.txt";
            string text = System.IO.File.ReadAllText(path);

            WordCounter wc = new WordCounter();

            Console.WriteLine(text);
            Console.WriteLine("Lines = " + wc.CountLines(text));
            Console.WriteLine("Words = " + wc.CountWords(text));
            Console.WriteLine("Chars = " + wc.CountCharacters(text));

            Console.ReadKey();
        }
    }
}
