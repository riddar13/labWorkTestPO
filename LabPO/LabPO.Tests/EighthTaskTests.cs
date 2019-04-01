using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace LabPO.Tests
{
    [TestClass]
    public class EighthTaskTests
    {
        [TestMethod]
        public void FirstTest()
        {
            int[,] x = { 
                { -5, 1}, 
                { -2, 9} };
            int[,] expected = { 
                {-5, -6, 1}, 
                {-2, -11, 9} };
            EighthTask c = new EighthTask();
            var actual = c.Method(x);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void SecondTest()
        {
            int[,] x = {
                { -5, 9},
                { -2, 1} };
            int[,] expected = {
                {-5, -14, 9},
                {-2, -3, 1} };
            EighthTask c = new EighthTask();
            var actual = c.Method(x);
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
