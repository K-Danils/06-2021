using AdApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddApp
{
    class Poster : Advert
    {
        private double _width;
        private double _height;
        private int _numberOfCopies;
        private double _pricePerCopy;

        public Poster(int fee, double width, double height, int numberOfCopies, double pricePerCopy) : base(fee)
        {
            _width = width;
            _height = height;
            _numberOfCopies = numberOfCopies;
            _pricePerCopy = pricePerCopy;
        }

        public new int Cost()
        {
            return base.Cost();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
