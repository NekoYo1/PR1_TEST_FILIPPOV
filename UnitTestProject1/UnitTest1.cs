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
    }
}
