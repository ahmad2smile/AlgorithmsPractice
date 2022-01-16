using NUnit.Framework;

namespace AlgorithmsPractice.Test;

public class ZipRecursiveTest
{
    private ZipLinkedLists _zipLinkedLists;

    [SetUp]
    public void Setup()
    {
        _zipLinkedLists = new ZipLinkedLists();
    }

    [Test]
    public void ZipRecursive_EvenLists()
    {
        var listA = new MutableLinkedList<string>
        {
            Value = "A"
        };

        listA.Head.Add("B").Add("C").Add("D");

        var listB = new MutableLinkedList<string>
        {
            Value = "W"
        };

        listB.Head.Add("X").Add("Y").Add("Z");

        _zipLinkedLists.ZipRecursive(listA.Head, listB.Head);

        Assert.AreEqual("A", listA.Value);
        Assert.AreEqual("W", listA.Next?.Value);
        Assert.AreEqual("B", listA.Next?.Next?.Value);
        Assert.AreEqual("X", listA.Next?.Next?.Next?.Value);
        Assert.AreEqual("C", listA.Next?.Next?.Next?.Next?.Value);
        Assert.AreEqual("Y", listA.Next?.Next?.Next?.Next?.Next?.Value);
        Assert.AreEqual("D", listA.Next?.Next?.Next?.Next?.Next?.Next?.Value);
        Assert.AreEqual("Z", listA.Next?.Next?.Next?.Next?.Next?.Next?.Next?.Value);
    }


    [Test]
    public void ZipRecursive_UnEvenFirstLists()
    {
        var listA = new MutableLinkedList<string>
        {
            Value = "A"
        };

        listA.Head.Add("B");

        var listB = new MutableLinkedList<string>
        {
            Value = "W"
        };

        listB.Head.Add("X").Add("Y").Add("Z");

        var result = _zipLinkedLists.ZipRecursive(listA.Head, listB.Head);

        Assert.AreEqual("A", result?.Value);
        Assert.AreEqual("W", result?.Next?.Value);
        Assert.AreEqual("B", result?.Next?.Next?.Value);
        Assert.AreEqual("X", result?.Next?.Next?.Next?.Value);
        Assert.AreEqual("Y", result?.Next?.Next?.Next?.Next?.Value);
        Assert.AreEqual("Z", result?.Next?.Next?.Next?.Next?.Next?.Value);
    }

    [Test]
    public void ZipRecursive_UnEvenLastLists()
    {
        var listA = new MutableLinkedList<string>
        {
            Value = "A"
        };

        listA.Head.Add("B").Add("C").Add("D");

        var listB = new MutableLinkedList<string>
        {
            Value = "W"
        };

        listB.Head.Add("X");

        _zipLinkedLists.ZipRecursive(listA.Head, listB.Head);

        Assert.AreEqual("A", listA.Value);
        Assert.AreEqual("W", listA.Next?.Value);
        Assert.AreEqual("B", listA.Next?.Next?.Value);
        Assert.AreEqual("X", listA.Next?.Next?.Next?.Value);
        Assert.AreEqual("C", listA.Next?.Next?.Next?.Next?.Value);
        Assert.AreEqual("D", listA.Next?.Next?.Next?.Next?.Next?.Value);
    }
}