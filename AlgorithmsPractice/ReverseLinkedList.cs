namespace AlgorithmsPractice;

public class ReverseLinkedList
{
    public MutableLinkedList<int>? SwapNodesRecursive(
        MutableLinkedList<int> current,
        MutableLinkedList<int>? prev = null
    )
    {
        var nexNode = current.Next;
        current.Next = prev;

        return nexNode is null ? current : SwapNodesRecursive(nexNode, current);
    }

    public MutableLinkedList<int>? SwapNodes(MutableLinkedList<int> list)
    {
        MutableLinkedList<int>? prevNode = null;
        var currentNode = list.Head;

        // null 1 -    2 -    3      4
        //      prev   c    next

        while (currentNode is not null)
        {
            var nextNode = currentNode.Next;

            // NOTE: Adjust pointer of current node to point to prev node
            currentNode.Next = prevNode;
            prevNode = currentNode;
            currentNode = nextNode;
        }

        return prevNode;
    }

    public LinkedList<int> SwapValues(LinkedList<int> list)
    {
        if (list.First is null || list.Last is null)
        {
            return list;
        }

        SwapValues(list.First, 0, GetListLength(list));

        return list;
    }

    private int GetListLength(LinkedList<int> list)
    {
        var length = 0;
        var currentNode = list.First;

        while (currentNode is not null)
        {
            length++;
            currentNode = currentNode.Next;
        }

        return length;
    }

    private LinkedListNode<int>? GetNodeAtLastIndex(
        LinkedListNode<int> node,
        int startingIndex,
        int index,
        int listLength
    )
    {
        var currentIndex = startingIndex;
        var indexToFind = listLength - 1 - startingIndex;

        var currentNode = node;

        while (currentIndex != indexToFind && currentNode is not null)
        {
            currentNode = currentNode.Next;
            currentIndex++;
        }

        return currentNode;
    }

    // 2, 3, 4, 5, 1

    private void SwapValues(LinkedListNode<int> node, int currentIndex, int listLength)
    {
        // NOTE: Last node get is 1 index based as -0 is not recognized to get last index
        var lastNode = GetNodeAtLastIndex(node, currentIndex, currentIndex, listLength);

        if (lastNode is null || currentIndex >= listLength / 2)
        {
            return;
        }

        (node.Value, lastNode.Value) = (lastNode.Value, node.Value);

        if (node.Next is null)
        {
            return;
        }

        SwapValues(node.Next, currentIndex + 1, listLength);
    }
}