using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloMethodName;
namespace TestHelloMethod
{
    [TestClass]
    public class TestHelloMethod
    {
        [TestMethod]
        public void TestHelloMethodName()
        {
            string name = "Ivan";
            string test = HelloMethod.Hello(name);
            Assert.AreEqual("Hello, Ivan!", test);
        }
    }
}
