using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LabTesting.Tests.IntegrationTests
{
    [TestClass]
    public class IntegrationTest
    {
        [TestMethod]
        public void IntegrTest1Greater()
        {
            string input = "1229 2207 3889 4391 5521 6983 7459 8563 9397 9613";
            string expectedOutput = "4391 5521 6983 8563 9397 9613 ";
            int[] inputArray = InputOutputHandler.ConvertStringToArray(input, 10);
            int[] resultArray = ArrayHandler.GetArray(inputArray, '>').array;
            string output = InputOutputHandler.ConvertArrayToString(ref resultArray);
            Assert.AreEqual(output, expectedOutput);
        }

        [TestMethod]
        public void IntegrTest2Smaller()
        {
            string input = "1229 2207 3889 4391 5521 6983 7459 8563 9397 9613";
            string expectedOutput = "1229 2207 3889 7459 ";
            int[] inputArray = InputOutputHandler.ConvertStringToArray(input, 10);
            int[] resultArray = ArrayHandler.GetArray(inputArray, '<').array;
            string output = InputOutputHandler.ConvertArrayToString(ref resultArray);
            Assert.AreEqual(output, expectedOutput);
        }

        [TestMethod]
        public void IntegrTest3Null()
        {
            string input = "1111 2222 3333 4444 5555 6666 7777 8888 9999 1000";
            string expectedOutput = "";
            int[] inputArray = InputOutputHandler.ConvertStringToArray(input, 10);
            int[] resultArray = ArrayHandler.GetArray(inputArray, '<').array;
            string output = InputOutputHandler.ConvertArrayToString(ref resultArray);
            Assert.AreEqual(output, expectedOutput);
        }
    }
}
