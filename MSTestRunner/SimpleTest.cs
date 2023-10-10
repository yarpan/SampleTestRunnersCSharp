using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace MSTestRunner
{
    [TestClass]
    public class SimpleTest
    {

        [TestInitialize]
        public void BeforeTest()
        {
            Console.WriteLine("BeforeTest");
        }


        [TestMethod]
        public void Test1()
        {
            Console.WriteLine("Test1");
        }


        [TestCleanup]
        public void AfterTest()
        {
            Console.WriteLine("AfterTest");
        }

    }
}

