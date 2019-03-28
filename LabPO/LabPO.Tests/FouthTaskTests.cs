using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace LabPO.Tests
{
    [TestClass]
    public class FouthTaskTests
    {
        [TestMethod]
        public void Sort1943672580_5by_1432059678returned()
        {
            int[] arr = new[] { 1, 9, 4, 3, 6, 7, 2, 5, 8, 0 };
            var expected = new List<int>()
            {
                1,
                2,
                2,
                2
            };
            FouthTask c = new FouthTask();
          //  var actual = c.Procedure(list);

          //  CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void OrderBy4223300_22returned()
        {
            var list = new List<int>()
            {
                4,
                2,
                2,
                3,
                3
            };
            var expected = new List<int>()
            {
                2,
                2
            };
            ThirdTask c = new ThirdTask();
            var actual = c.Procedure(list);

            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void OrderBy123_12returned()
        {
            var list = new List<int>()
            {
                1,
                2,
                3
            };
            var expected = new List<int>()
            {
                1,
                2
            };
            ThirdTask c = new ThirdTask();
            var actual = c.Procedure(list);

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
