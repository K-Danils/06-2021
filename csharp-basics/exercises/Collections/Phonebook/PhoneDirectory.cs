using System;
using System.Collections.Generic;
namespace PhoneBook
{
    public class PhoneDirectory
    {
        private SortedDictionary<string, string> _data;

        public PhoneDirectory() {
            _data = new SortedDictionary<string, string>();
        }

        public string GetNumber(string name) 
        {
            if (String.IsNullOrEmpty(name)) { throw new ArgumentNullException(); }

            return _data.ContainsKey(name) ? _data[name] : throw new Exception("Name is non existing.");
        }

        public void PutNumber(string name, string number) 
        {
            if (String.IsNullOrEmpty(name) || String.IsNullOrEmpty(number)) 
            {
                throw new Exception("Name or number cannot be null or empty.");
            }

            if (_data.ContainsKey(name)) 
            {
                _data[name] = number;
            }
            else 
            {
                var newEntry = new PhoneEntry {Name = name, Number = number}; // Create a new pair.
                _data.Add(name, number);   // Add the new pair to the array.
            }
        }
    }
}