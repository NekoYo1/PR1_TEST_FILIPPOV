using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        private const string Expected = "Hello World";

        [TestMethod]
        public void TestMethod1()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                PR1_TEST_FILIPPOV.Program.Main();

                var result = sw.ToString().Trim();
                Assert.AreEqual(Expected, result);
            }
        }

        private const string Expected2 = "Goodbye World";
        [TestMethod]
        public void TestMethod2()
        {
            using (var sw2 = new StringWriter())
            {
                Console.SetOut(sw2);
                PR1_TEST_FILIPPOV.Program.SayGoodBye();

                var result2 = sw2.ToString().Trim();
                Assert.AreEqual(Expected2, result2);
            }
        }
    }
}
