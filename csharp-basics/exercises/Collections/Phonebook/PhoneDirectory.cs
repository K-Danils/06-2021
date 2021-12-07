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
            if (_data.ContainsKey(name)) 
            {
                return _data[name];
            } 
            else 
            {
                return null;
            }
        }

        public void PutNumber(string name, string number) 
        {
            if (name == null || number == null) 
            {
                throw new Exception("name and number cannot be null");
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