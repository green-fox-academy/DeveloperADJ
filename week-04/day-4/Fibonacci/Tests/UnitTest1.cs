using NUnit.Framework;
using Fibonacci;

namespace Tests
{
    [TestFixture]
    public class UnitTest1
    {
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        [TestCase(2, 1)]
        [TestCase(3, 2)]
        [TestCase(4, 3)]
        [TestCase(5, 5)]
        [TestCase(6, 8)]
        [TestCase(7, 13)]
        [TestCase(29, 514229)]
        public void FibonacciIndexChecker(int index, int fibonacciNumber)
        {
            var Fibonacci = new FibonacciGenerator();

            Assert.AreEqual(fibonacciNumber, Fibonacci.FibonacciIndexChecker(index));
        }
    }
}
