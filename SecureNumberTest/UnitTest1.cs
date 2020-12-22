using Microsoft.VisualStudio.TestTools.UnitTesting;
using SecureNumber.Types;
using System.Collections.Generic;

namespace SecureNumberTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Int32_s test = 5;
            test = test + 3;
            test *= 2;
            Assert.AreEqual(test.ToPrimitive(), 16);
        }
    }
}
