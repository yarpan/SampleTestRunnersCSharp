namespace NUnitRunner
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            Console.WriteLine("This is Test Initialization");
        }

        [Test]
        public void Test1()
        {
            Console.WriteLine("Simple Test");
            Assert.Pass();
        }

        [TearDown]
        public void TearDown()
        {
            Console.WriteLine("This is Test TearDown");
        }
    }
}