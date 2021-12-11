using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchy
{
    public abstract class Food
    {
        private int _quanity;

        public Food(int quantity)
        {
            _quanity = quantity;
        }

        public int Quantity { get => _quanity; }
    }
}
