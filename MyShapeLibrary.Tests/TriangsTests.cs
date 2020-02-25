using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyShapeLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShapeLibrary.Tests
{
    [TestClass()]
    public class TriangsTests
    {
        [TestMethod()]
        public void Square_12_12_13_65returned()
        {
            Shape triang = new Shape();
            double a = 12;
            double b = 12;
            double c = 13;
            double expected = 65;
            double actual = (int)triang.Square(a, b, c);//обнуляем дробную часть
            Assert.AreEqual(expected, actual);
            
        }
    }
}