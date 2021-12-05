using NUnit.Framework;

namespace AlgorithmsPractice.Test
{
    public class PathFinderTest
    {
        private PathFinder _pathFinder;

        [SetUp]
        public void Setup()
        {
            _pathFinder = new PathFinder();
        }

        [Test]
        [TestCase(0, 0, 0)]
        [TestCase(1, 0, 0)]
        [TestCase(0, 1, 0)]
        [TestCase(1, 1, 1)]
        public void PathFinder_Rescursive_Default(int col, int row, int expectedWays)
        {
            Assert.AreEqual(_pathFinder.Rescursive(col, row), expectedWays);
        }

        [Test]
        [TestCase(2UL, 3UL, 3UL)]
        [TestCase(3UL, 2UL, 3UL)]
        [TestCase(3UL, 3UL, 6UL)]
        [TestCase(18UL, 18UL, 2333606220UL)]
        public void PathFinder_Rescursive_Way(ulong col, ulong row, ulong expectedWays)
        {
            Assert.AreEqual(_pathFinder.Rescursive((int)col, (int)row), expectedWays);
        }
    }
}
