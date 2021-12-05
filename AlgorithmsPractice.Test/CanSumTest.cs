using NUnit.Framework;
using System.Collections.Generic;

namespace AlgorithmsPractice.Test
{
    public class CanSumTest
    {
        private CanSum _canSum;

        [SetUp]
        public void Setup()
        {
            _canSum = new CanSum();
        }

        [Test]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(5)]
        [TestCase(6)]
        [TestCase(9)]
        public void CanSum_Recursive_True(int targetSum)
        {
            var numbers = new List<int> { 1, 2, 3 };

            Assert.IsTrue(_canSum.Rescursive(targetSum, numbers));
        }

        [Test]
        [TestCase(300)]
        [TestCase(900)]
        public void CanSum_Resursive_False(int targetSum)
        {
            var numbers = new List<int> { 7, 14 };

            Assert.IsFalse(_canSum.Rescursive(targetSum, numbers));
        }
    }
}
