using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace LabPO.Tests
{
    [TestClass]
    public class NinthTaksTests
    {
        [TestMethod]
        public void FirstTest()
        {
            int[,] x = {
                { -5, 1},
                { -2, 9} };
            int[,] expected = {
                {1, -5},
                {9, -2} };
            NinthTask c = new NinthTask();
            var actual = c.Method(x);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void SecondTest()
        {
            int[,] x = {
                { -5, 1, 9},
                { -2, 6, 7} };
            int[,] expected = {
                {9, 1, -5},
                {7, 6, -2} };
            NinthTask c = new NinthTask();
            var actual = c.Method(x);
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
