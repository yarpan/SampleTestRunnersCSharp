namespace NUnitParallelRuner
{
    [TestFixture]
    [Parallelizable(ParallelScope.Self)]
    //[Parallelizable(ParallelScope.Children)]
    //[Parallelizable(ParallelScope.All)]
    //[Parallelizable(ParallelScope.None)]

    internal class TestSuite2
    {

        [Test]
        public void Test1()
        {
            Thread.Sleep(2000);
            Console.WriteLine("Test1");

        }

        [Test]
        public void Test2()
        {
            Thread.Sleep(2000);
            Console.WriteLine("Test2");
        }

        [Test]
        public void Test3()
        {
            Thread.Sleep(2000);
            Console.WriteLine("Test3");
        }

    }
}
