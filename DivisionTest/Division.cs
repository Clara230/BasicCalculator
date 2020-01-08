using System;

namespace DivisionTest
{
    public class Division
    {
        private readonly int a = 10;
        private readonly int b = 2;
        private readonly double c = 50.5;
        private readonly double d = 2.5;
        [TestMethod()]
        public void DivideTest()
        {
            Assert.AreEqual(5, Division.Divide(a, b));
        }

        [TestMethod()]
        public void DivideDoubleTest()
        {
            Assert.AreEqual(20.2, Division.Divide(c, d));
        }
    }
}

    }
}
