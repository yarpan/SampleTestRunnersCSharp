using Xunit.Abstractions;


namespace xUnitRunner
{
    public abstract class TestsBase : IDisposable
    {
        protected TestsBase() //Constructor as test initialize
        {
            // Do "global" initialization here;
            // Called before every test method.
        }

        public void Dispose()
        {
            // Do "global" teardown here;
            // Called after every test method.
        }
    }




    public class SimpleSuite : TestsBase
    {
        private readonly ITestOutputHelper _testOutputHelper;
        public SimpleSuite(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
        }


        [Fact]
        public void Test1()
        {
            _testOutputHelper.WriteLine("Test1");
        }

        [Fact]
        public void Test2()
        {
            _testOutputHelper.WriteLine("Test2");
        }

        [Fact]
        public void Test3()
        {
            _testOutputHelper.WriteLine("Test3");
        }

    }







}