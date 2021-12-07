using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7
{
    class Dog
    {
        public string Name;
        public string Sex;
        private string _father;
        private string _mother;

        public Dog(string name, string sex, string mother, string father)
        {
            Name = name;
            Sex = sex;
            _father = father;
            _mother = mother;
        }

        public Dog(string name, string sex)
        {
            Name = name;
            Sex = sex;
        }

        public string FathersName()
        {
            if (_father == null)
            {
                return "Unknown";
            }

            return _father;
        }

        public bool HasSameMotherAs(Dog otherDog)
        {
            return _mother == otherDog._mother;
        }
    }
}
