using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise6
{
    public class RandomArrays
    {
        Random ran = new Random();
        private int[] _arr1 = new int[10];
        private int[] _arr2;

        public int[] Arr1 { get => _arr1; }
        public int[] Arr2 { get => _arr2; }

        public RandomArrays()
        {
        }

        public int[] GenerateRandomArray()
        {
            int[] arr = new int[10];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = ran.Next(0, 100) + 1;
            }
            return arr;
        }

        public void FillFirstArray()
        {
            _arr1 = GenerateRandomArray();
        }

        public void FillSecondArray()
        {
            _arr2 = new int[_arr1.Length];
            for (int i = 0; i < _arr1.Length; i++)
            {
                _arr2[i] = _arr1[i];
            }
        }

        public void FirstArrSwitchLastToNegativeSeven()
        {
            _arr1[_arr1.Length - 1] = -7;
        }

        public string PrintArray(int[] arr)
        {
            return string.Join(" ", arr);
        }

    }
}
