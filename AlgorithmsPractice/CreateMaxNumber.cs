namespace AlgorithmsPractice;

public class CreateMaxNumber
{
    public int Iterative(int number, int adder)
    {
        var isNegative = number < 0;

        var numberStr = number.ToString();

        if (isNegative)
        {
            numberStr = numberStr[1..];
        }

        for (var i = 0; i < numberStr.Length; i++)
        {
            var currentDigit = int.Parse(numberStr[i].ToString());

            if (isNegative ? currentDigit < adder : currentDigit > adder)
            {
                continue;
            }

            return (isNegative ? -1 : 1) * int.Parse(numberStr[..i] + adder + numberStr[i..]);
        }

        return number;
    }
}