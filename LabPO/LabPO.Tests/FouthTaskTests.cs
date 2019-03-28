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
            var spis = new List<int>()
                        {
                            1,
                            9,
                            4,
                            3,
                            6,
                            7,
                            2,
                            5,
                            8,
                            0
                        };
            var numCent = new List<int>()
                        {
                            5
                        };
            var expected = new List<int>()
            {
                1,
                4,
                3,
                2,
                0,
                5,
                9,
                6,
                7,
                8
            };
            FouthTask c = new FouthTask();
            var actual = c.Method(spis, numCent);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Sort1943672580_1by_1094367258returned()
        {
            var spis = new List<int>()
                        {
                            1,
                            9,
                            4,
                            3,
                            6,
                            7,
                            2,
                            5,
                            8,
                            0
                        };
            var numCent = new List<int>()
                        {
                            1
                        };
            var expected = new List<int>()
            {
                0,
                1,
                9,
                4,
                3,
                6,
                7,
                2,
                5,
                8
            };
            FouthTask c = new FouthTask();
            var actual = c.Method(spis, numCent);
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
