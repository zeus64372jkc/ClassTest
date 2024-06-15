using CalculatorProject;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class CalculatorTest
    {
        Calculator calculator;
        [TestInitialize]
        public void init()
        {
            calculator = new Calculator();
        }

        [TestMethod]
        public void testAdd()
        {            
            Assert.AreEqual(5, calculator.add(3, 2));
        }

        [TestMethod]
        public void testSubtract()
        {            
            Assert.AreEqual(1, calculator.subtract(3, 2));            
        }
        [TestMethod]
        public void testmultiply()
        {
            Assert.AreEqual(6, calculator.multiply(3, 2));
        }
    }
}
