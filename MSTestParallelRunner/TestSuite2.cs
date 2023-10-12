using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace MSTestParallelRunner
{
    [TestClass]
    public class TestSuite2
    {

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
            Thread.Sleep(2000); 
            Console.WriteLine("Test1");
        }

        [TestMethod]
        public void Test2()

        {
            Thread.Sleep(2000); 
            Console.WriteLine("Test2");
        }

        [TestMethod]
        public void Test3()
        {
            Thread.Sleep(2000); 
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