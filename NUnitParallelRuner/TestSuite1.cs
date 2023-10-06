namespace NUnitParallelRuner
{
    [TestFixture]
    [Parallelizable(ParallelScope.Self)]
    //[Parallelizable(ParallelScope.All)]
    //[Parallelizable(ParallelScope.Children)]
    //[Parallelizable(ParallelScope.None)]

    public class TestSuite1
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