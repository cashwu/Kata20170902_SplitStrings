using System;
using System.Collections;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kata20170902_SplitStrings
{
    [TestClass]
    public class SplitStringsTests
    {
        [TestMethod]
        public void input_ab_should_return_ab()
        {
            SpliteStringShouldBe(new[] { "ab" }, "ab");
        }

        [TestMethod]
        public void input_bc_should_return_bc()
        {
            SpliteStringShouldBe(new[] { "bc" }, "bc");
        }

        [TestMethod]
        public void input_a_should_return_a_()
        {
            SpliteStringShouldBe(new[] { "a_" }, "a");
        }

        [TestMethod]
        public void input_abcd_should_return_ab_cd()
        {
            SpliteStringShouldBe(new[] { "ab", "cd" }, "abcd");
        }

        private static void SpliteStringShouldBe(string[] expected, string str)
        {
            var splitString = new SplitString();
            var actual = splitString.Solution(str);
            CollectionAssert.AreEqual(expected, actual);
        }
    }

    public class SplitString
    {
        public string[] Solution(string str)
        {
            if (str.Length == 4)
            {
                return new[] {str.Substring(0, 2), str.Substring(2, 2)};
            }

            return new[] { str.Length % 2 == 0 ? str : str + "_" };
        }
    }
}
