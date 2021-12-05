using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Execise3
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string>();
            string input = "";

            while (true)
            {
                Console.Write("Enter name: ");
                input = Console.ReadLine();

                if (input == " " || input == "") { break;  }

                names.Add(input);
            }

            Console.Write("Unique name list contains: ");
            Console.WriteLine(String.Join(" ", names.Distinct()));

            Console.ReadKey();
        }
    }
}
