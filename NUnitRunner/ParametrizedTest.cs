
namespace NUnitRunner
{
    internal class ParametrizedTest
    {
        [TestFixture]
        public class Class1
        {

            [TestCase("", true)]
            [TestCase("a", true)]
            [TestCase("aa", true)]
            [TestCase("AB", false)]
            [TestCase("ABA", true)]
            [TestCase(" ABA", true)]
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
