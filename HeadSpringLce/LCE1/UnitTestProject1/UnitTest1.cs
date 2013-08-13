using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LCEClassLibrary1;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {    
        [TestMethod]
        public void TestReplaceWithParamWithZeroLength()
        {
            LCE lce = new LCE();

            string expected = "1\n2\n3\n4\n";

            string actual = lce.PrintNumbers(new Range(1, 4), new Dictionary<int, string> { });

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestReplaceWithParamWithNonExistentNumber()
        {
            LCE lce = new LCE();

            string expected = "1\n2\n3\n4\n";

            string actual = lce.PrintNumbers(new Range(1, 4), new Dictionary<int, string> { {5,"FIVE"} });

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestReplaceWithParamWithNullString()
        {
            LCE lce = new LCE();

            string expected = "1\n2\n3\n4\n";

            string actual = lce.PrintNumbers(new Range(1, 4), new Dictionary<int, string> { { 4, null } });

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestReplaceWithReverseRange()
        {
            LCE lce = new LCE();

            string expected = "1\n2\n3\nFOUR\n";

            string actual = lce.PrintNumbers(new Range(4,1), new Dictionary<int, string> { { 4, "FOUR" } });

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestAllZerosParams()
        {
            LCE lce = new LCE();

            string expected = "Zero\n";

            string actual = lce.PrintNumbers(new Range(0,0), new Dictionary<int, string> { { 0, "Zero" } });

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestNoParams()
        {
            LCE lce = new LCE();

            try
            {
                string actual = lce.PrintNumbers();
            }
            catch
            {
                Assert.Fail("No parameters case should be handled with default behvior");
            }
        }
    }
}
