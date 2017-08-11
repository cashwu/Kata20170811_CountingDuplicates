using System;
using System.Collections.Generic;
using System.Linq;
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

        [TestMethod]
        public void input_abca_should_return_1()
        {
            var kata = new Kata();
            var actual = kata.DuplicateCount("abca");
            Assert.AreEqual(1, actual);
        }
    }

    public class Kata
    {
        public int DuplicateCount(string str)
        {
            var result = 0;
            var oldChar = new List<char>();
            for (int i = 0; i < str.Length; i++)
            {
                if (str.Count(a => a == str[i]) > 1 
                    && !oldChar.Contains(str[i]))
                {
                    oldChar.Add(str[i]);
                    result++;
                }
            }
            return result;
        }
    }
}
