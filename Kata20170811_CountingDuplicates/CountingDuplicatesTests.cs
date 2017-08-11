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
            DuplicateCountShouldBe(0, "abc");
        }

        [TestMethod]
        public void input_abca_should_return_1()
        {
            DuplicateCountShouldBe(1, "abca");
        }


        [TestMethod]
        public void input_abcA_should_return_1()
        {
            DuplicateCountShouldBe(1, "abcA");
        }

        private static void DuplicateCountShouldBe(int expected, string str)
        {
            var kata = new Kata();
            var actual = kata.DuplicateCount(str);
            Assert.AreEqual(expected, actual);
        }
    }

    public class Kata
    {
        public int DuplicateCount(string str)
        {
            var result = 0;

            for (var i = str.Length - 1; i >= 0; i--)
            {
                var lowerChar = char.ToLower(str[i]);
                if (str.Count(a => char.ToLower(a) == lowerChar) > 1)
                {
                    str = str.Replace(str[i].ToString(), "");
                    i = str.Length;
                    result++;
                }
            }

            return result;
        }
    }
}
