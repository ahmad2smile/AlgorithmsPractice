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
    }
}
