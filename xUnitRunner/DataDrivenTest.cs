using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using Xunit.Abstractions;
using Assert = Xunit.Assert;

namespace xUnitRunner
{
    public abstract class DataDrivenTest : IDisposable
    {
        private readonly ITestOutputHelper _testOutputHelper;
        protected DataDrivenTest(ITestOutputHelper testOutputHelper)
        {
            // Do "global" initialization here; Called before every test method.
            _testOutputHelper = testOutputHelper;
            _testOutputHelper.WriteLine("Initialization");
        }

        public void Dispose()
        {
            // Do "global" teardown here; Called after every test method.
            _testOutputHelper.WriteLine("Dispose");
        }


        [Theory]
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

        [Theory]
        [InlineData("test@test.com", "test.com")]
        [InlineData("milan@milanjovanovic.tech", "milanjovanovic.tech")]
        public void EmailParser_Should_Return_Domain(string email, string expectedDomain)
        {
            // Arrange


            // Act
            _testOutputHelper.WriteLine("TestDD");

            // Assert

        }



    }

}