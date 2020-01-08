using Microsoft.VisualStudio.TestTools.UnitTesting;
using BasicCalculator;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCalculator.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        private readonly int a = 15;
        private readonly int b = 5;
        // private readonly double c = 2.5;
        // private readonly double d = 5.5;
        [TestMethod()]
        public void SubtractTest()
        {
            Assert.AreEqual(10, Operations.Subtraction.Subtract(a, b));

        }

        [TestMethod()]
        public void DivideTest()
        {
            Assert.AreEqual(3, Operations.Division.Divide(a, b));

        }
    }
}