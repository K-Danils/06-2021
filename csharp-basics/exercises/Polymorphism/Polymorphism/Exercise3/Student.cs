using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons
{
    class Student : Person
    {
        double _gpa;

        public Student(double gpa, string firstName, string lastName, string address, int id) : base(firstName,  lastName,  address,  id)
        {
            Gpa = gpa;
        }

        public double Gpa { get => _gpa; set => _gpa = value; }

        public override void Display()
        {
            Console.WriteLine("Name: {0} \nLast name: {1} \nAddress: {2} \nid: {3} \nGPA: {4}\n", FirstName, LastName, Address, Id, Gpa);
        }
    }
}
