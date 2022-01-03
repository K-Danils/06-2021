using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateArea
{
    public class Geometry
    {
        public static double AreaOfCircle(decimal radius)
        {
            return Math.PI * Math.Pow((double)radius, 2);
        }

        public static double AreaOfRectangle(decimal length, decimal width)
        {
            if (length <= 0 || width <= 0) { throw new Exception("Negative or empty values used"); }
            else
            {
                return (double)(length * width);
            }
        }

        public static double AreaOfTriangle(decimal ground, decimal h)
        {
            if (ground <= 0 || h <= 0) { throw new Exception("Negative or empty values used"); }
            else
            {
                return (double)(ground / 2 * h);
            }
        }
    }
}
