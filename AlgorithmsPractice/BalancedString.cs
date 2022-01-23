namespace AlgorithmsPractice;

public class BalancedString
{
    // 1. Check all uppercase letters have lowercase variants
    // 2. If not, return a substr that does
    public string Iterative(string input)
    {
        var isBalancedStr = true;
        var balancedSubStr = "";
        var listOfSubStrings = new List<string>();

        for (var i = 0; i < input.Length; i++)
        {
            var currentChar = input[i];

            if (!input.Contains(currentChar.ToString().ToUpper()))
            {
                isBalancedStr = false;

                listOfSubStrings.Add(balancedSubStr);

                balancedSubStr = "";
            }
            else
            {
                balancedSubStr += currentChar;
            }
        }

        if (isBalancedStr)
        {
            return input;
        }

        var result = listOfSubStrings.Aggregate((a, b) => a.Length > b.Length ? a : b);

        return result.Length < 2 ? "" : result;
    }
}