namespace AlgorithmsPractice
{
    public class Fibonacci
    {
        private readonly Dictionary<ulong, ulong> _cache = new();

        public ulong Recursive(ulong nth)
        {
            if (_cache.TryGetValue(nth, out ulong result))
            {
                return result;
            }

            if(nth < 2) return nth;

            return _cache[nth] = Recursive(nth - 1) + Recursive(nth - 2);
        }

        public double Tabulated(ulong nth)
        {
            if (nth < 2) return nth;

            var result = 0UL;
            // NOTE: With Tabulated method you usually save results in a list
            // but since we are only tracking last 2 results, we can just keep those
            var prev1 = 0UL;
            var prev2 = 1UL;

            for (var i = 2UL; i < nth + 1; i++)
            {
                result = prev1 + prev2;

                prev1 = prev2;
                prev2 = result;
            }

            return result;
        }
    }
}
