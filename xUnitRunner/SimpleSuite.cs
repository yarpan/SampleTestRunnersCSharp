
namespace xUnitRunner
{
    public class SimpleSuite : IDisposable
    {
        private readonly ITestOutputHelper _testOutputHelper;
        public SimpleSuite(ITestOutputHelper testOutputHelper) //Constructor as test initialize
        {
            // Called before every test method.
            _testOutputHelper = testOutputHelper;
            _testOutputHelper.WriteLine("Before Test");
        }

        public void Dispose()
        {
            // Called after every test method.
            _testOutputHelper.WriteLine("After Test");
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
