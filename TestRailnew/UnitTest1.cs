using NUnit.Framework;

namespace TestRailnew
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            System.Console.WriteLine("Setup");
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
            System.Console.WriteLine("Passed");
        }
    }
}