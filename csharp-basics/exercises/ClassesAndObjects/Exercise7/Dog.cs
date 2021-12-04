using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7
{
    class Dog
    {
        string name;
        string sex;
        string father;
        string mother;

        public Dog(string name, string sex, string mother, string father)
        {
            this.name = name;
            this.sex = sex;
            this.father = father;
            this.mother = mother;
        }

        public Dog(string name, string sex)
        {
            this.name = name;
            this.sex = sex;
        }

        public string FathersName()
        {
            if (this.father == null)
            {
                return "Unknown";
            }

            return this.father;
        }

        public bool HasSameMotherAs(Dog otherDog)
        {
            return this.mother == otherDog.mother;
        }
    }
}
