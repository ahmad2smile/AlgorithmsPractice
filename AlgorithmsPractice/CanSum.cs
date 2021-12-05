
namespace AlgorithmsPractice
{
    public class CanSum
    {
        private readonly Dictionary<int, bool> _cacheCanSum = new();

        // Can we find a sum from given numbers equal to targetSum

        // Can DO: Add Numbers multiple times
        // Can't DO: ---
        // Conditon: All Numbers are non-negative

        // Another way to say: Subtract numbers from targetSum so remainder == 0

        // 1. a,b,c  => targetSum -a -b -c == 0
        // 2. targetSum -a -a -a = 0
        // 2. targetSum -a -b -b = 0
        // 2. targetSum -a -b -b = 0
        // 2. targetSum -b -b -b = 0

        // List: {1,2,3}
        //                      6
        //       5              4                   3
        //  4    3   2   |  3   2   1   |   2        1        0
        // 321  210  100 | 210  100 000 | 100       000      000
        public bool Rescursive(int targetSum, List<int> numbers)
        {
            if (targetSum == 0)
            {
                return true;
            }

            if (targetSum < 0)
            {
                return false;
            }

            if (_cacheCanSum.TryGetValue(targetSum, out bool result))
            {
                return result;
            }

            foreach (var item in numbers)
            {
                result = Rescursive(targetSum - item, numbers);

                if (result || item == 0)
                {
                    break;
                }
            }

            return _cacheCanSum[targetSum] = result;
        }
    }
}
