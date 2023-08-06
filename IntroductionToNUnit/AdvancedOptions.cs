namespace Tests
{
    internal class AdvancedOptions
    {
        [Test]
        public void UsingWarnings()
        {
            var isProcessed = false;
            Warn.Unless(isProcessed, Is.EqualTo(true)
                .After(30).Seconds.PollEvery(5).Seconds);
            Console.WriteLine("Still going!");
        }

        [Test]
        public void AssertPassThrowsException()
        {
            Assert.That(Assert.Pass, Throws.Exception);
        }
        [Test]
        public void Assumptions()
        {
            Assume.That("a value", Is.EqualTo("another value"));
        }
        [Test]
        public void AssumeThenAssert()
        {
            var someSettingEnabled = false;
            Assume.That(someSettingEnabled, Is.True);
            Assert.That("Actual", Is.EqualTo("Expected"));
        }
        [Test]
        public void MultipleAssertions()
        {
            Assert.Multiple(() =>
            {
                Assert.AreEqual(1, 2);
                Assert.AreEqual(3, 3);
            });
            var someSettingEnabled = false;
            Assume.That(someSettingEnabled, Is.True);
            Assert.That("Actual", Is.EqualTo("Expected"));
        }
        [Test]
        public void AssertionWithFluentAssertions()
        {
            true.Should().Be(true);
        }
    }
}
