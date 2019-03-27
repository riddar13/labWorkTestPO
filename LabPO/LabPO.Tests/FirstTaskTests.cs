using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LabPO.Tests
{
    [TestClass]
    public class FirstTaskTests
    {
        [TestMethod]
        public void Factorial_5_240returned()
        {
            // arrange
            int x = 5;
            int expected = 240;

            // act
            FirstTask c = new FirstTask();
            int actual = c.Method(x);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}
