

namespace NUnitRunner
{
    internal class SimpleSuite
    {
        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            Console.WriteLine("OneTimeSetUp");
        }

        [SetUp]
        public void Setup()
        {
            Console.WriteLine("SetUp");
        }



        [Test]
        public void Test1()
        {
            Console.WriteLine("Test1");
            Assert.Pass();
        }

        [Test]
        public void Test2()
        {
            Console.WriteLine("Test2");
            Assert.Pass();
        }

        [TestCase(TestName = "Test with custom testname")]
        //[Test, TestName = "Test with custom testname"]
        //[Test(null, TestName = "Test Case #1, Category: First, Category: Second")]
        public void Test3()
        {
            Console.WriteLine("Test3");
            Assert.Pass();
        }



        [TearDown]
        public void TearDown()
        {
            Console.WriteLine("TearDown");
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            Console.WriteLine("OneTimeTearDown");
        }

    }

}
