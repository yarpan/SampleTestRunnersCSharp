

namespace NUnitRunner
{
    [TestFixture]
    internal class DataDrivenTest
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
        public void DataProviderTest(string testString, bool isPalindrome)
        {
            bool actualResult = IsDataPalindrom(testString);
            Assert.AreEqual(isPalindrome, actualResult);
            Console.WriteLine("String:'" + testString + "', [EXPECTED]:" + isPalindrome + ", [ACTUAL]:" + actualResult);
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
