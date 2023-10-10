using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace MSTestRunner
{
    [TestClass]
    public class SimpleSuite
    {
        private TestContext testContextInstance;

        public TestContext TestContext
        {
            get { return testContextInstance; }
            set { testContextInstance = value; }
        }

        [ClassInitialize]
        public static void BeforeClass(TestContext a)
        {
            Console.WriteLine("BeforeClass");
        }

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

        [TestMethod]
        public void Test2()

        {
            Console.WriteLine("Test2");
        }

        [TestMethod]
        public void Test3()
        {
            Console.WriteLine("Test3");
        }



        [TestCleanup]
        public void AfterTest()
        {
            Console.WriteLine("AfterTest");
        }

        [ClassCleanup]
        public static void AfterClass()
        {
            Console.WriteLine("AfterClass");
        }

    }
}

