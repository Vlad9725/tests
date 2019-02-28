using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LabTesting.Tests
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void GetArray()
        {
            int[] actual1 = {1229, 2207, 3889, 4391, 5521, 6983, 7459, 8563, 9397, 9613 };
            int[] expected1 = {4391, 5521, 6983, 8563, 9397, 9613 };
            CollectionAssert.AreEqual(ArrayHandler.GetArray(actual1, '>').array, expected1);

            int[] actual2 = { 1229, 2207, 3889, 4391, 5521, 6983, 7459, 8563, 9397, 9613 };
            int[] expected2 = { 1229, 2207, 3889, 7459 };
            CollectionAssert.AreEqual(ArrayHandler.GetArray(actual2, '<').array, expected2);

            int[] actual3 = { 1111, 2222, 3333, 4444, 5555, 6666, 7777, 8888, 9999, 1000 };
            CollectionAssert.AreEqual(ArrayHandler.GetArray(actual3, '>').array, null);
        }

        [TestMethod]
        public void IsPrime()
        {
            Assert.AreEqual(ArrayHandler.IsPrime(3221), true);
            Assert.AreEqual(ArrayHandler.IsPrime(6666), false);
        }

        [TestMethod]
        public void GetFirstDigit()
        {
            Assert.AreEqual(ArrayHandler.GetFirstDigit(3221), 3);
            Assert.AreEqual(ArrayHandler.GetFirstDigit(5221), 5);
            Assert.AreEqual(ArrayHandler.GetFirstDigit(9509), 9);
            Assert.AreEqual(ArrayHandler.GetFirstDigit(3055), 3);
            Assert.AreEqual(ArrayHandler.GetFirstDigit(7755), 7);
        }

        [TestMethod]
        public void GetLastDigit()
        {
            Assert.AreEqual(ArrayHandler.GetLastDigit(3221), 1);
            Assert.AreEqual(ArrayHandler.GetLastDigit(5221), 1);
            Assert.AreEqual(ArrayHandler.GetLastDigit(9509), 9);
            Assert.AreEqual(ArrayHandler.GetLastDigit(3055), 5);
            Assert.AreEqual(ArrayHandler.GetLastDigit(7755), 5);
        }

        [TestMethod]
        public void Compare()
        {
            Assert.AreEqual(ArrayHandler.Compare('>', 9, 1), true);
            Assert.AreEqual(ArrayHandler.Compare('<', 9, 1), false);
            Assert.AreEqual(ArrayHandler.Compare('>', 0, 8), false);
            Assert.AreEqual(ArrayHandler.Compare('<', 0, 8), true);
            Assert.AreEqual(ArrayHandler.Compare('>', 5, 5), false);
        }
    }
}
