
namespace NUnitRunner
{
    internal class ParametrizedTest
    {
        [TestFixture]
        public class Class1
        {

            [TestCase("", true, TestName = "Test for empty")]
            [TestCase("a", true, TestName = "Test with one char")]
            [TestCase("aa", true, TestName = "Test with 2 same chars")]
            [TestCase("AB", false, TestName = "Test with 2 different chars")]
            [TestCase("ABA", true, TestName = "Test ABA")]
            [TestCase(" ABA", true, TestName = "Test with space in begin")]
            [TestCase("ABA ", true)]
            [TestCase("A BA", true)]


            [Test]
            public void dataProviderTest(string testString, bool isPalindrome)
            {
                Assert.AreEqual(isPalindrome, IsDataPalindrom(testString));
            }



            public bool IsDataPalindrom(string sourceStr)
            {
                sourceStr = string.Join("", sourceStr.Split(' '));
                int sourceStrLen = sourceStr.Length;

                for (int i = 0; i < sourceStrLen; i++)
                {
                    if (sourceStr[i] != sourceStr[sourceStrLen - i - 1])
                        return false;
                }
                return true;
            }

        }

    }

}
