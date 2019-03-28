using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace LabPO.Tests
{
    [TestClass]
    public class SixthTaskTests
    {
        [TestMethod]
        public void TestOne()
        {
            var x = new List<int>()
            {
                1,2,2,2,2,4,5,6,4,5
            };
            var expected = new List<int>()
            {
                1,4,5,6,4,5
            };
            SixthTask c = new SixthTask();
            var actual = c.Method(x);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestTwo()
        {
            var x = new List<int>()
            {
                1,2,2,0,0,0,4,5
            };
            var expected = new List<int>()
            {
                1,2,2,4,5
            };
            SixthTask c = new SixthTask();
            var actual = c.Method(x);
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
