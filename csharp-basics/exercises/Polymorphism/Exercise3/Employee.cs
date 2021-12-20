using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons
{
    class Employee : Person
    {
        private string _jobTitle;

        public Employee(string jobTitle, string firstName, string lastName, string address, int id) : base(firstName, lastName, address, id)
        {
            JobTitle = jobTitle;
        }

        public string JobTitle { get => _jobTitle; set => _jobTitle = value; }

        public override void Display()
        {
            Console.WriteLine("Name: {0} \nLast name: {1} \nAddress: {2} \nid: {3} \nJob title: {4}\n", FirstName, LastName, Address, Id, JobTitle);
        }
    }
}
