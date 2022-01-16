using System.Collections.Generic;
using NUnit.Framework;

namespace AlgorithmsPractice.Test;

public class ReverseLinkedListTest
{
    private ReverseLinkedList _reeLinkedList;

    [SetUp]
    public void Setup()
    {
        _reeLinkedList = new ReverseLinkedList();
    }

    [Test]
    public void Reverses_LinkedList()
    {
        var list = new LinkedList<int>();
        list.AddLast(new LinkedListNode<int>(1));
        list.AddLast(new LinkedListNode<int>(2));
        list.AddLast(new LinkedListNode<int>(3));
        list.AddLast(new LinkedListNode<int>(4));
        list.AddLast(new LinkedListNode<int>(5));

        var result = _reeLinkedList.SwapValues(list);

        Assert.AreEqual(5, result.First?.Value);
        Assert.AreEqual(4, result.First?.Next?.Value);
        Assert.AreEqual(3, result.First?.Next?.Next?.Value);
        Assert.AreEqual(2, result.First?.Next?.Next?.Next?.Value);
        Assert.AreEqual(1, result.First?.Next?.Next?.Next?.Next?.Value);
    }

    [Test]
    public void Reverses_LinkedList_With_SwapNodes()
    {
        var list = new MutableLinkedList<int>
        {
            Value = 1
        };

        list.Head.Add(2).Add(3).Add(4).Add(5);

        var result = _reeLinkedList.SwapNodes(list);

        Assert.AreEqual(5, result?.Value);
        Assert.AreEqual(4, result?.Next?.Value);
        Assert.AreEqual(3, result?.Next?.Next?.Value);
        Assert.AreEqual(2, result?.Next?.Next?.Next?.Value);
        Assert.AreEqual(1, result?.Next?.Next?.Next?.Next?.Value);
    }

    [Test]
    public void Reverses_LinkedList_With_SwapNodes_Recursive()
    {
        var list = new MutableLinkedList<int>
        {
            Value = 1
        };

        list.Head.Add(2).Add(3).Add(4).Add(5);

        var result = _reeLinkedList.SwapNodesRecursive(list.Head);

        Assert.AreEqual(5, result?.Value);
        Assert.AreEqual(4, result?.Next?.Value);
        Assert.AreEqual(3, result?.Next?.Next?.Value);
        Assert.AreEqual(2, result?.Next?.Next?.Next?.Value);
        Assert.AreEqual(1, result?.Next?.Next?.Next?.Next?.Value);
    }
}