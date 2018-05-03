using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using helper; 

namespace helperTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("Test with Jenkins", Program.createMessage());
        }
    }
}
