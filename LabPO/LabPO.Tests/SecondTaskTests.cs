using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LabPO.Tests
{
    [TestClass]
    public class SecondTaskTests
    {
        [TestMethod]
        public void StringOfTwoElements()
        {
            // arrange
            string x = "bird    red"; 
            string expected = "red bird";

            // act
            SecondTask c = new SecondTask();
            var actual = c.Method(x);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StringOfThreeElements()
        {
            // arrange
            string x = "is    bird  red";
            string expected = "red bird is";

            // act
            SecondTask c = new SecondTask();
            var actual = c.Method(x);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StringOfFourElements()
        {
            // arrange
            string x = "angry    is bird    red";
            string expected = "red bird is angry";

            // act
            SecondTask c = new SecondTask();
            var actual = c.Method(x);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}
