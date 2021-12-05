namespace AlgorithmsPractice
{
    public class PathFinder
    {
        private readonly Dictionary<string, ulong> _cache = new();

        // How many different ways to travel to n,n point (bottom right)
        // Can't go: Up, Left
        // Only can go: Right, Down
        // 0 0 0
        // 0 0 0
        // 0 0 0

        // Down: row - 1
        // Right: col - 1

        //                      3,3
        //            3,2                 2,3
        //             2,2,        1,3
        //               2,1 1,2      0,3 1,2
        //                2,0  1,1    2,0  1,1        0,1 1,1

        public ulong Rescursive(int col, int row)
        {
            if (col == 1 && row == 1) return 1;
            if (col == 0 || row == 0) return 0;

            var identifer = $"{col}-{row}";

            if (_cache.TryGetValue(identifer, out ulong cachedVal))
            {
                return cachedVal;
            }

            return _cache[identifer] = Rescursive(col, row - 1) + Rescursive(col - 1, row);
        }
    }
}
