using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(5, 2);
            Point p2 = new Point(-3, 6);

            SwapPoints(ref p1, ref p2);
            Console.WriteLine("(" + p1.X + ", " + p1.Y + ")");
            Console.WriteLine("(" + p2.X + ", " + p2.Y + ")");
            Console.ReadKey();
        }
        
        static void SwapPoints(ref Point p1, ref Point p2)
        {
            Point temp = new Point(p1.X, p1.Y);

            p1.X = p2.X;
            p1.Y = p2.Y;

            p2.X = temp.X;
            p2.Y = temp.Y;
            
        }
    }
}
