using System;
using PaulSherlock_S00189970;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PaulSherlock_S00189970.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            double expected_result = 240;

            Phone P1 = new Phone(200);

            P1.IncreasePrice(0.20);

            Assert.AreEqual(expected_result, P1.Price);
        }
    }
}
