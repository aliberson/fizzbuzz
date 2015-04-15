using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

using ClassLibrary1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void testMultipleOfThreeOnlyWritesFizz()
        {
            Dictionary<int, string> modulusDict = new Dictionary<int, string>();
            modulusDict.Add(3, "fizz");
            modulusDict.Add(5, "buzz");
            modulusDict.Add(10, "snap");

            Assert.AreEqual("fizz", Class1.getAnalysis(39, modulusDict));
        }

        [TestMethod]
        public void testMultipleOfFiveOnlyWritesBuzz()
        {
            Dictionary<int, string> modulusDict = new Dictionary<int, string>();
            modulusDict.Add(3, "fizz");
            modulusDict.Add(5, "buzz");
            modulusDict.Add(10, "snap");

            Assert.AreEqual("buzz", Class1.getAnalysis(5, modulusDict));
        }

        [TestMethod]
        public void testMultipleOfSevenOnlyWritesEmpty()
        {
            Dictionary<int, string> modulusDict = new Dictionary<int, string>();
            modulusDict.Add(3, "fizz");
            modulusDict.Add(5, "buzz");
            modulusDict.Add(10, "snap");

            Assert.AreEqual("", Class1.getAnalysis(7, modulusDict));
        }

        [TestMethod]
        public void testMultipleOfTwoThreeFourWritesBuzzFizzSnap()
        {
            Dictionary<int, string> modulusDict = new Dictionary<int, string>();
            modulusDict.Add(2, "fizz");
            modulusDict.Add(3, "buzz");
            modulusDict.Add(4, "snap");

            List<string> testList = new List<string>();
            testList.Add("1 dummy val");
            testList.Add("2 dummy val");
            testList.Add("3 dummy val");
            testList.Add("4 dummy val");
            testList.Add("5 dummy val");
            testList.Add("6 dummy val");
            testList.Add("7 dummy val");
            testList.Add("8 dummy val");
            testList.Add("9 dummy val");
            testList.Add("10 dummy val");
            testList.Add("11 dummy val");
            testList.Add("12 fizzbuzzsnap");

            List<string> actualList = new List<string>();
            actualList = Class1.AnalyzeNumbers(1, 15, modulusDict);

            string FifteenFromTestList = testList[11];
            string FifteenFromActualList = actualList[11];
            Assert.AreEqual(FifteenFromTestList.ToString(), FifteenFromActualList.ToString());
        }

        [TestMethod]
        public void testNonExistantMultipleOnlyWritesEmptyResult()
        {
            Dictionary<int, string> modulusDict = new Dictionary<int, string>();
            modulusDict.Add(3, "fizz");
            modulusDict.Add(5, "buzz");
            modulusDict.Add(10, "snap");

            Assert.AreEqual("", Class1.getAnalysis(2, modulusDict));
        }

        [TestMethod]
        public void testOutputOfProgramNotNullorEmpty()
        {
            Dictionary<int, string> modulusDict = new Dictionary<int, string>();
            modulusDict.Add(2, "fizz");
            modulusDict.Add(3, "buzz");
            modulusDict.Add(4, "snap");

            List<string> actualList = new List<string>();
            actualList = Class1.AnalyzeNumbers(1, 15, modulusDict);

            Assert.IsNotNull(actualList);
            Assert.AreNotSame(0, actualList.Count);
        }
    }
}
