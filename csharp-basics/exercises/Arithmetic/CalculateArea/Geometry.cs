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
            if (radius < 0) { Console.WriteLine("Negative values used"); return 0.0; }
            else
            {
                return Math.PI * Math.Pow((double)radius, 2);
            }
            throw new NotImplementedException();
        }

        public static double AreaOfRectangle(decimal length, decimal width)
        {
            if (length < 0 || width < 0) { Console.WriteLine("Negative values used"); return 0.0; }
            else
            {
                return (double)(length * width);
            }
            throw new NotImplementedException();
        }

        public static double AreaOfTriangle(decimal ground, decimal h)
        {
            if (ground < 0 || h < 0) { Console.WriteLine("Negative values used"); return 0.0; }
            else
            {
                return (double)(ground / 2 * h);
            }
            throw new NotImplementedException();
        }
    }
}
