using NUnit.Framework;

namespace AlgorithmsPractice.Test;

public class UniqueFrequencyCharactersTests
{
    private UniqueFrequencyCharacters _uniqueFrequencyCharacters;


    [SetUp]
    public void Setup()
    {
        _uniqueFrequencyCharacters = new UniqueFrequencyCharacters();
    }

    [Test]
    public void Iterative_Returns_UniqueFreq()
    {
        Assert.AreEqual(0, _uniqueFrequencyCharacters.Iterative("abbccc"));
        Assert.AreEqual(2, _uniqueFrequencyCharacters.Iterative("aaabbccc"));
        Assert.AreEqual(2, _uniqueFrequencyCharacters.Iterative("ceabaacb"));
    }
}