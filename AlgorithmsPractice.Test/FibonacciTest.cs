using NUnit.Framework;

namespace AlgorithmsPractice.Test
{
    public class FibonacciTest
    {
        private Fibonacci _fibonacci;

        [SetUp]
        public void Setup()
        {
            _fibonacci = new Fibonacci();
        }

        [Test]
        [TestCase(0UL, 0UL)]
        [TestCase(1UL, 1UL)]
        public void Fib_Rescursive_Default(ulong nth, ulong expected)
        {
            Assert.AreEqual(_fibonacci.Recursive(nth), expected);
        }

        [Test]
        [TestCase(2UL, 1UL)]
        [TestCase(3UL, 2UL)]
        [TestCase(8UL, 21UL)]
        [TestCase(9UL, 34UL)]
        [TestCase(50UL, 12586269025UL)]
        public void Fib_Rescursive_Of_Nath(ulong nth, ulong expected)
        {
            Assert.AreEqual(_fibonacci.Recursive(nth), expected);
        }
    }
}
