using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace MSTestRunner
{
    [TestClass]
    public class DataDrivenTest
    {

        [TestInitialize]
        public void BeforeTest()
        {
            Console.WriteLine("BeforeTest");
        }


        [DataTestMethod]
        [DataRow("", true)]
        [DataRow("a", true)]
        [DataRow("aa", true)]
        [DataRow("AB", false)]
        [DataRow("ABA", true)]
        [DataRow(" ABA", true)]
        [DataRow("ABA ", true)]
        [DataRow("A BA", true)]

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



        [TestCleanup]
        public void AfterTest()
        {
            Console.WriteLine("AfterTest");
        }

    }
}

