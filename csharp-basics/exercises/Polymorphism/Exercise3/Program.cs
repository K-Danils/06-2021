using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * - Create an instant of class Student and an instant of class Employee with proper values for the attributes.
             * - Display the content of each class using Display() method.
             */

            Student student1 = new Student(10.0, "Danils", "Kubiskins", "Birzgale", 1);
            Employee employee1 = new Employee("Programmer", "Totally not Danils", "Totally not Kubiskins", "Totally not Birzgale", 2);

            student1.Display();
            employee1.Display();

            Console.Read();
        }
    }
}
