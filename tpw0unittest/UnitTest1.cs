using Microsoft.VisualStudio.TestTools.UnitTesting;
using tpw_0;


namespace TPWTests
{
    [TestClass]
    public class SampleClassTest
    {
        [TestMethod]
        public void addTest()
        {
            string x = "hello";
            string y = "world";
            string result1 = SampleClass.hello_world(x, y);
            string result2 = SampleClass.hello_world(y, x);
            Assert.AreEqual("hello world", result1);
            Assert.AreEqual("world hello", result2);
        }
    }
}