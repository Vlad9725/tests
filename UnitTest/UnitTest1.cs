using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LabTesting.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ConvertStringToArray()
        {
            int[] expected1 = { 1111, 2222, 3333, 4444, 5555, 6666, 7777, 8888, 9999, 1000 };
            CollectionAssert.AreEqual(InputOutputHandler.ConvertStringToArray("1111 2222 3333 4444 5555 6666 7777 8888 9999 1000", 10), expected1);

            int[] expected2 = { 1111, 2222, 3333};
            CollectionAssert.AreEqual(InputOutputHandler.ConvertStringToArray("1111 2222 3333", 3), expected2);
        }

        [TestMethod]
        public void ConvertArrayToString()
        {
            int[] actual1 = { 1111, 2222, 3333, 4444, 5555, 6666, 7777, 8888, 9999, 1000 };
            Assert.AreEqual(InputOutputHandler.ConvertArrayToString(ref actual1), "1111 2222 3333 4444 5555 6666 7777 8888 9999 1000 ");

            int[] actual2 = { 1111, 2222, 3333};
            Assert.AreEqual(InputOutputHandler.ConvertArrayToString(ref actual2), "1111 2222 3333 ");
        }
    }
}
