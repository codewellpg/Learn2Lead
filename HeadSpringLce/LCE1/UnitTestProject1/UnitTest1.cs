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
        public void TestMethod1()
        {
            ILCE lce = new LCEClassLibrary1.Fakes.StubILCE()
            {
                PrintNumbersRangeIDictionaryOfInt32String = (range,replaceMatrix) => { return "ONE"; }
            };

            var underTest = new Excecise(lce);

            string actualValue = underTest.PrintNumbersSeries();

            Assert.AreEqual("ONE", actualValue);
        }

        [TestMethod]
        public void TestMethod2()
        {
            LCE lce = new LCE();

            string expected = "1\n2\n3\n4\n";

            string actual = lce.PrintNumbers(new Range(1, 4), new Dictionary<int, string> { });

            Assert.AreEqual(expected, actual);
        }

    }
}
