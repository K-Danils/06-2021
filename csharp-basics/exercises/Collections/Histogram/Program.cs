using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Histogram
{
    class Program
    {
        private const string Path = @"E:/codelex/CODELEX_UZDEVUMI/06-2021/csharp-basics/exercises/Collections/Histogram/midtermscores.txt";

        private static void Main(string[] args)
        {
            var readText = File.ReadAllText(Path);
            var scores = new List<int>();
            var histogram = new string[11];
            var stringScores = readText.Split(' ').ToList();

            stringScores.ForEach(score => scores.Add(int.Parse(score)));
            
            scores.Sort();

            foreach (var s in scores)
            {
                if (s <= 9) { histogram[0] += "*"; continue; }

                for (int i = 1; i < 10; i++)
                {
                    int min = i * 10;
                    int max = min + 9;
                    if (s >= min && s <= max) { histogram[i] += "*"; break; }
                }

                if (s >= 100) { histogram[histogram.Length - 1] += "*";}
            }

            Console.WriteLine("00-09: " + histogram[0]);

            for (int i = 1; i < 10; i++)
            {
                int min = i * 10;
                int max = min + 9;
                Console.WriteLine("{0}-{1}: {2}", min, max, histogram[i]);
            }

            Console.WriteLine("  100: " + histogram[histogram.Length - 1]);

            Console.ReadLine();
        }
    }
}
