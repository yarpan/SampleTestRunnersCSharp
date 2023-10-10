using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace MSTestRunner
{
    [TestClass]
    public class SimpleTest
    {

        [TestInitialize]
        public void BeforeTestSingle()
        {
            Console.WriteLine("BeforeTest");
        }


        [TestMethod]
        public void TestSingle()
        {
            Console.WriteLine("Test1");
        }


        [TestCleanup]
        public void AfterTestSingle()
        {
            Console.WriteLine("AfterTest");
        }

    }
}

