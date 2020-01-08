using Microsoft.VisualStudio.TestTools.UnitTesting;
using Operations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Operations.Tests
{
    [TestClass()]
    public class MultiplicationTests
    {
        private readonly int a = 15;
        private readonly int b = 5;
       // private readonly double c = 2.5;
       // private readonly double d = 5.5;
        [TestMethod()]
        public void MultiplyTest()
        {
            Assert.AreEqual(75, Multiplication.Multiply(a, b));
        }

        [TestMethod()]
        public void MultiplyTest1()
        {
            Assert.AreEqual(75, Multiplication.Multiply(a ,b));
        }
    }
}