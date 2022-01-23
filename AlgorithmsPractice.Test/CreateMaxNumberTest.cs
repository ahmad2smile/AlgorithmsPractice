using NUnit.Framework;

namespace AlgorithmsPractice.Test;

public class CreateMaxNumberTest
{
    private CreateMaxNumber _createMaxNumber;

    [SetUp]
    public void Setup()
    {
        _createMaxNumber = new CreateMaxNumber();
    }

    [Test]
    public void CanReturn_LargeNumber()
    {
        Assert.AreEqual(51234, _createMaxNumber.Iterative(1234, 5));
        Assert.AreEqual(76543, _createMaxNumber.Iterative(7643, 5));
        Assert.AreEqual(50, _createMaxNumber.Iterative(0, 5));
        Assert.AreEqual(-5661, _createMaxNumber.Iterative(-661, 5));
    }
}