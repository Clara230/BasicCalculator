using System;

namespace Subtraction
{
    public class SubtractionTest
{
    [TestClass()]
    public class SubtractionTests
    {
        private readonly int a = 15;
        private readonly int b = 5;
        // private readonly double c = 2.5;
        // private readonly double d = 5.5;
        [TestMethod()]
        public void SubtractTest()
        {
            Assert.AreEqual(10, Subtraction.Subtract(a, b));

        }

        [TestMethod()]
        public void SubtractTest1()
        {
            Assert.AreEqual(10, Subtraction.Subtract(a, b));
        }
    }
}

    }
}
