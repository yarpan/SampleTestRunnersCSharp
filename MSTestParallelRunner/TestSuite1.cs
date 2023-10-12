using Microsoft.VisualStudio.TestTools.UnitTesting;
//[assembly: Parallelize(Workers = 3, Scope = ExecutionScope.ClassLevel)]
[assembly: Parallelize(Workers = 0, Scope = ExecutionScope.MethodLevel)]



namespace MSTestParallelRunner
{
    [TestClass]
    public class TestSuite1
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
        [DoNotParallelize]
        public void Test1()
        {
            Thread.Sleep(2000);
            Console.WriteLine("Test1");
        }

        [TestMethod]
        [DoNotParallelize]
        public void Test2()

        {
            Thread.Sleep(2000);
            Console.WriteLine("Test1");
        }

        [TestMethod]
        [DoNotParallelize]
        public void Test3()
        {
            Thread.Sleep(2000);
            Console.WriteLine("Test1");
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