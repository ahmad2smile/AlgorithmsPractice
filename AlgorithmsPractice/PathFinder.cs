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

        public ulong Tabulated(int _col, int _row)
        {
            if (_col == 1 && _row == 1) return 1;
            if (_col == 0 || _row == 0) return 0;

            var col = _col + 1;
            var row = _row + 1;

            var table = new List<int>(new int[row]).Select(r => new List<ulong>(new ulong[col])).ToList();

            table[1][1] = 1UL;

            for (int r = 0; r < row; r++)
            {
                for (int c = 0; c < col; c++)
                {
                    var current = table[r][c];

                    if (r + 1 < row) table[r + 1][c] += current;
                    if (c + 1 < col) table[r][c + 1] += current;
                }
            }

            return table[_row][_col];
        }
    }
}
