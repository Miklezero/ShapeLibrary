using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyShapeLibrary.Tests
{
    [TestClass]
    public class MyCircleTests
    {
        [TestMethod]
        public void Square_10_314returned()
        {
            //arrange
            double r = 10;
            double expected = 314;

            //act
            Shape circle = new Shape();
            double actual = (int)circle.Square(10);//временно приводим actual к целому, поскольку expected указан примерно

            //assept
            Assert.AreEqual(expected, actual);
        }
    }
}
