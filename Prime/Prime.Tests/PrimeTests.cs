using NUnit.Framework;

namespace Tests
{
    public class PrimeTests
    {
        [TestCase(2, true)]
        [TestCase(23, true)]
        [TestCase(42, false)]
        public void Test1(int value, bool expectedIsPrime)
        {
            var isPrime = Calc.isPrime(value);
            Assert.AreEqual(expectedIsPrime, isPrime);
        }
    }
}