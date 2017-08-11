using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kata20170811_CountingDuplicates
{
    [TestClass]
    public class CountingDuplicatesTests
    {
        [TestMethod]
        public void input_abc_should_return_0()
        {
            var kata = new Kata();
            var actual = kata.DuplicateCount("abc");
            Assert.AreEqual(0, actual);
        }
    }

    public class Kata
    {
        public int DuplicateCount(string str)
        {
            return 0;
        }
    }
}
