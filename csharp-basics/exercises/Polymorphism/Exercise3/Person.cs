using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons
{
    abstract class Person
    {
        private string _firstName;
        private string _lastName;
        private string _address;
        private int _id;

        public Person() { }
        
        public Person(string firstName, string lastName, string address, int id)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            Id = id;
        }

        public string FirstName { get => _firstName; set => _firstName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
        public string Address { get => _address; set => _address = value; }
        public int Id { get => _id; set => _id = value; }

        public virtual void Display()
        {
            Console.WriteLine("Name: {0} \nLast name: {1} \nAddress: {2} \nid: {3} \n", FirstName, LastName, Address, Id);
        }
    }
}
