using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise5
{
    class Program
    {
        static void WriteBorder(int dashes)
        {
            Console.Write("+");
            for (int i = 0; i < dashes; i++) { Console.Write("-"); }
            Console.WriteLine("+");
        }

        static void Main(string[] args)
        {
            string[] englishClass = {"1", "English III", "Ms. Lapan"};
            string[] precalculusClass = { "2", "Precalculus", "Mrs. Gideon" };
            string[] musicTheoryClass = { "3", "Music Theory", "Mr. Davis" };
            string[] BCIS = { "4", "Business Computer Infomation Systems", "Mr. James" };

            WriteBorder(58);
            Console.WriteLine(String.Format("| {0,-2}|{1,38}|{2,15}|", englishClass[0], englishClass[1], englishClass[2]));
            Console.WriteLine(String.Format("| {0,-2}|{1,38}|{2,15}|", precalculusClass[0], precalculusClass[1], precalculusClass[2]));
            Console.WriteLine(String.Format("| {0,-2}|{1,38}|{2,15}|", musicTheoryClass[0], musicTheoryClass[1], musicTheoryClass[2]));
            Console.WriteLine(String.Format("| {0,-2}|{1,38}|{2,15}|", BCIS[0], BCIS[1], BCIS[2]));
            WriteBorder(58);

            Console.ReadLine();
        }
    }
}
