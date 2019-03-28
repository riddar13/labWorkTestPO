using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace LabPO.Tests
{
    [TestClass]
    public class SeventhTaskTests
    {
        [TestMethod]
        public void TestOne()
        {
            int[] x = { 1, 1, 2, 3, 3, 9, 9 };
            string expected = "2 1 2 0 0 0 0 0 2";
            SeventhTask c = new SeventhTask();
            var actual = c.Method(x);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestTwo()
        {
            int[] x = { 1, 1, 1, 1, 1, 1, 1 };
            string expected = "7 0 0 0 0 0 0 0 0";
            SeventhTask c = new SeventhTask();
            var actual = c.Method(x);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestThree()
        {
            int[] x = { 2, 2, 2, 2, 2, 2, 2 };
            string expected = "0 7 0 0 0 0 0 0 0";
            SeventhTask c = new SeventhTask();
            var actual = c.Method(x);
            Assert.AreEqual(expected, actual);
        }
    }
}
