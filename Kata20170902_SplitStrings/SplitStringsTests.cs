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

        [TestMethod]
        public void input_abc_should_return_ab_c_()
        {
            SpliteStringShouldBe(new[] { "ab", "c_" }, "abc");
        }

        [TestMethod]
        public void input_abcdef_should_return_ab_cd_ef()
        {
            SpliteStringShouldBe(new[] { "ab", "cd", "ef" }, "abcdef");
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
            str = str.Length % 2 == 0 ? str : str + "_"; 
            return Enumerable.Range(0, str.Length / 2)
                .Select(idx => str.Substring(idx * 2, 2)).ToArray();
        }
    }
}
