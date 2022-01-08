using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            RandomArrays ranArr = new RandomArrays();

            ranArr.FillFirstArray();
            ranArr.FillSecondArray();
            ranArr.FirstArrSwitchLastToNegativeSeven();

            Console.WriteLine(ranArr.PrintArray(ranArr.Arr1));
            Console.WriteLine(ranArr.PrintArray(ranArr.Arr2));
            Console.ReadLine();
        }
    }
}
