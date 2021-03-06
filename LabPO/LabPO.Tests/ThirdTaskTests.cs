﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace LabPO.Tests
{
    [TestClass]
    public class ThirdTaskTests
    {
        [TestMethod]
        public void OrderBy122233_1222returned()
        {
            var list = new List<int>()
            {
                1,
                2,
                2,
                2,
                3,
                3
            };
            var expected = new List<int>()
            {
                1,
                2,
                2,
                2
            };
            ThirdTask c = new ThirdTask();
            var actual = c.Procedure(list);

            CollectionAssert.AreEqual(expected, actual);
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
