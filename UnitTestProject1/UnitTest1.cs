using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Library;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Class1 lib = new Class1();
            Assert.AreEqual(lib.sum(1, 5), 6);
            Assert.AreEqual(lib.subtract(1, 5), -4);
            Assert.AreEqual(lib.multiplicat(1, 5), 5);
            Assert.AreEqual(lib.div(1, 5), 0.2);
        }
    }
}
