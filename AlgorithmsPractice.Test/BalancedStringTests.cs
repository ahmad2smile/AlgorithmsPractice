using NUnit.Framework;

namespace AlgorithmsPractice.Test;

public class BalancedStringTests
{
    private BalancedString _balancedString;

    [SetUp]
    public void Setup()
    {
        _balancedString = new BalancedString();
    }


    [Test]
    public void BalancedString_Return_BalancedStr()
    {
        Assert.AreEqual(_balancedString.Iterative("aBAbz"), "aBAb");
        Assert.AreEqual(_balancedString.Iterative("azABaabza"), "ABaab");
        Assert.AreEqual(_balancedString.Iterative("AcZCbaBz"), "AcZCbaBz");
        Assert.AreEqual(_balancedString.Iterative("TacoCat"), "");
    }
}