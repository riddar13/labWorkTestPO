using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace LabPO.Tests
{
    [TestClass]
    public class FifthTaskTests
    {
        [TestMethod]
        public void TestOne()
        {
            // arrange
            var x = new List<int>()
            {
                1,
                2,
                3,
                6,
                7,
                8
            };
            var expected = new List<int>()
            {
                1,
                2,
                3,
                8,
                6,
                7,
                8,
                8
            };

            // act
            FifthTask c = new FifthTask();
            var actual = c.Method(x);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}
