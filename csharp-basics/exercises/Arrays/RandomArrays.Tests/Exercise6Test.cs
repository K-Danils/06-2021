using System;
using exercise6;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RandomArraysTest.Test
{
    [TestClass]
    public class Exercise6Test
    {
        private RandomArrays _target;

        [TestMethod]
        public void FillArray1_RandomNumbers_ShouldNotBeFilledWithDefaultValues()
        {
            _target = new RandomArrays();
            _target.FillFirstArray();

            foreach (var number in _target.Arr1)
            {
                Assert.AreNotEqual(0, number);
            }
        }

        [TestMethod]
        public void FillArray2_RandomNumbers_ShouldNotBeFilledWithDefaultValues()
        {
            _target = new RandomArrays();
            _target.FillFirstArray();
            _target.FillSecondArray();

            foreach (var number in _target.Arr2)
            {
                Assert.AreNotEqual(0, number);
            }
        }

        [TestMethod]
        public void FillArrays_Random_ArraysShouldNotBeEqual ()
        {
            _target = new RandomArrays();

            _target.FillFirstArray();

            var testArr = _target.GenerateRandomArray();

            _target.FillFirstArray();

            CollectionAssert.AreNotEqual(testArr, _target.Arr1);
        }

        [TestMethod]
        public void FillArrays_FilledCorrectly_ShouldBeEqual()
        {
            _target = new RandomArrays();

            _target.FillFirstArray();
            _target.FillSecondArray();

            CollectionAssert.AreEqual(_target.Arr1, _target.Arr2);
        }

        [TestMethod]
        public void SwitchLastDigit_7_Negative_LastDigitFirstArrayShouldBeNegative7()
        {
            _target = new RandomArrays();

            _target.FillFirstArray();
            _target.FillSecondArray();
            _target.FirstArrSwitchLastToNegativeSeven();

            Assert.AreEqual(-7, _target.Arr1[_target.Arr1.Length - 1]);
        }

        [TestMethod]
        public void PrintArray_ArrayValues123_ShouldReturnString123()
        {
            _target = new RandomArrays();

            Assert.AreEqual(_target.PrintArray(new int[]{1,2,3}),"1 2 3");
        }
    }
}
