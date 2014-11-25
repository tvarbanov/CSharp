using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumberInArray;

namespace _04.NumberInArrayTests
{
    [TestClass]
    public class NumberInArrayTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            int num = 2;
            int[] arrayNums = { 1, 6, 4, 8, 2, 1, 6, 7, 8, 9, 2, 1 };
            int test = NumberInArray.NumberInArray.CheckNum(num,arrayNums);
            Assert.AreEqual(2, test);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int num = 1;
            int[] arrayNums = { 1, 6, 4, 8, 2, 1, 6, 7, 8, 9, 2, 1 };
            int test = NumberInArray.NumberInArray.CheckNum(num, arrayNums);
            Assert.AreEqual(3, test);
        }
    }
}
