using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7
{
    class Dog
    {
        private string _name;
        private string _sex;
        private string _father;
        private string _mother;

        public Dog(string name, string sex, string mother, string father)
        {
            _name = name;
            _sex = sex;
            _father = father;
            _mother = mother;
        }

        public Dog(string name, string sex)
        {
            _name = name;
            _sex = sex;
        }

        public string FathersName()
        {
            return _father == null? "Unknown" : _father;
        }

        public bool HasSameMotherAs(Dog otherDog)
        {
            return _mother == otherDog._mother;
        }
    }
}
