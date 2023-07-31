using NUnit.Framework;

namespace Tests
{
    internal class MyNewTestFixture
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1t()
        {
            Assert.Pass();
        }
    }
}