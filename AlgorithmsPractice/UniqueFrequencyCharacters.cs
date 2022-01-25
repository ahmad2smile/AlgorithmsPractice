namespace AlgorithmsPractice;

public class UniqueFrequencyCharacters
{
    // 1. Find out if it's invalid string
    // input: abab => frequencies: a: 2, b: 2 => input[0].freq == input.any(c => freq[c] == freqA)
    // 2. Remove some characters of current char if in frequencies has it's freq
    // Decrease the frequency of char with conflict and keep going until there is no conflicting freq in freqList
    public int Iterative(string input)
    {
        var freqMap = new Dictionary<char, int>();

        foreach (var currentChar in input)
        {
            freqMap.TryGetValue(currentChar, out var currentFreq);

            freqMap[currentChar] = currentFreq + 1;
        }

        var frequencies = freqMap.Values.ToArray();
        Array.Sort(frequencies, (a, b) => a - b);

        var frequencySet = new HashSet<int>();

        var removals = 0;

        foreach (var f in frequencies)
        {
            var currentFreq = f;
            if (frequencySet.Contains(currentFreq))
            {
                while (true)
                {
                    removals++;
                    currentFreq -= 1;

                    if (currentFreq == 0 || !frequencySet.Contains(currentFreq))
                    {
                        break;
                    }
                }
            }
            else
            {
                frequencySet.Add(currentFreq);
            }
        }

        return removals;
    }
}