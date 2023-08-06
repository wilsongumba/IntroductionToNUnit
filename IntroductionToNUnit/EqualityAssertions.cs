namespace IntroductionToNUnit
{
    [TestFixture]
    public class EqualityAssertions
    {

        [Test]
        public void ThatIsEqualTo()
        {
            //constraint example
            Assert.That("actual", Is.EqualTo("expected "));
        }

        [Test]
        public void AreEqual()
        {
            Assert.AreEqual("expected ", "actual");
        }

        [Test]
        public void AreEqualWithDescription()
        {
            Assert.AreEqual("expected ", "actual", "what does this mean?");
        }

        [Test]
        public void AreEqualWithDynamicDescription()
        {
            Assert.AreEqual("expected", "actual", "what does {0} mean to {1}?", "testing", "you");
        }

        [Test]
        public void AreEqualNumbers()
        {
            Assert.AreEqual(1, 2);
        }

        [Test]
        public void AreEqualNumbersWithADifferentType()
        {
            Assert.AreEqual(2, 2d);
        }

        [Test]
        public void AreEqualNumbersWithinTolerance()
        {
            Assert.AreEqual(2, 1.4, .5);
        }

        [Test]
        public void AreEqualArrays()
        {
            var expected = new int[] { 1, 2, 3 };
            var actual = new int[] { 3, 2, 1 };
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void IsStringEmpty()
        {
            var myString = "";
            Assert.IsEmpty(myString);
        }

        [Test]
        public void ComparingRelativeValues()
        {
            Assert.GreaterOrEqual(2, 3);
        }
    }
}
