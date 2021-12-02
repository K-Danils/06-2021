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
            Random ran = new Random();
            int[] arr1 = new int[10];
            
            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = ran.Next(0,100) + 1;
            }

            int[] arr2 = new int[arr1.Length];

            for (int i = 0; i < arr1.Length; i++)
            {
                // in case if arr2 is shorter than arr1
                if (i >= arr2.Length) { break; }

                arr2[i] = arr1[i];
            }

            arr1[arr1.Length - 1] = -7;

            Console.WriteLine("Array 1: " + string.Join(" ", arr1));
            Console.WriteLine("Array 2: " + string.Join(" ", arr2));

            Console.Read();
        }
    }
}
