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
            Console.WriteLine("(" + p1.x + ", " + p1.y + ")");
            Console.WriteLine("(" + p2.x + ", " + p2.y + ")");
            Console.ReadKey();
        }
        
        static void SwapPoints(ref Point p1, ref Point p2)
        {
            Point temp = new Point(p1.x, p1.y);

            p1.x = p2.x;
            p1.y = p2.y;

            p2.x = temp.x;
            p2.y = temp.y;
            
        }
    }
}
