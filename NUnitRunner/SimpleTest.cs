using NUnit.Framework;


namespace NUnitRunner
{
    public class SimpleTest
    {

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


        [TearDown]
        public void TearDown()
        {
            Console.WriteLine("TearDown");
        }


    }
}