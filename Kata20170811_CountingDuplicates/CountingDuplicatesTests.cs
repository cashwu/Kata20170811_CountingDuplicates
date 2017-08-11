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

        [TestMethod]
        public void input_empty_should_return_0()
        {
            DuplicateCountShouldBe(0, "");
        }

        [TestMethod]
        public void input_aabbcde_should_return_2()
        {
            DuplicateCountShouldBe(2, "aabbcde");
        }

        [TestMethod]
        public void input_Indivisibility_should_return_1()
        {
            DuplicateCountShouldBe(1, "Indivisibility");
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
            return str.ToLower().GroupBy(a => a).Count(a => a.Count() > 1);
        }
    }
}
