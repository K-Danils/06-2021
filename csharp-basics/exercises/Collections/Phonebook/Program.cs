using PhoneBook;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            PhoneDirectory phone = new PhoneDirectory();

            phone.PutNumber("Danils", "+371 26142014");
            phone.PutNumber("Janis", "+371 12345678");

            Console.WriteLine(phone.GetNumber("Danils"));

            Console.ReadLine();
        }
    }
}
