
namespace xUnitRunner
{
    public class ParametrizedTest : IDisposable
    {
        private readonly ITestOutputHelper _testOutputHelper;
        public ParametrizedTest(ITestOutputHelper testOutputHelper) //Constructor as test initialize
        {
            // Called before every test method.
            _testOutputHelper = testOutputHelper;
            _testOutputHelper.WriteLine("Before Test");
        }

        public void Dispose()
        {
            // Called after every test method.
            _testOutputHelper.WriteLine("After Test");
        }



        [Theory(DisplayName = "Paramerized Test Name")]
        [InlineData("", true)]
        [InlineData("a", true)]
        [InlineData("aa", true)]
        [InlineData("AB", false)]
        [InlineData("ABA", true)]
        [InlineData(" ABA", true)]
        [InlineData("ABA ", true)]
        [InlineData("A BA", true)]
        public void DataProviderTest(string testString, bool isPalindrome)
        {
            bool actualResult = IsDataPalindrom(testString);
            Assert.Equal(isPalindrome, actualResult);
            _testOutputHelper.WriteLine("String:'" + testString + "', [EXPECTED]:" + isPalindrome + ", [ACTUAL]:" + actualResult);
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

