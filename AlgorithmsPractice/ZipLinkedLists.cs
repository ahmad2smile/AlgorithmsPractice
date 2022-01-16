namespace AlgorithmsPractice;

public class ZipLinkedLists
{
    public MutableLinkedList<string>? ZipRecursive(
        MutableLinkedList<string>? headA,
        MutableLinkedList<string>? headB
    )
    {
        if (headB is null && headA is null)
        {
            return null;
        }

        if (headA is null)
        {
            return headB;
        }

        if (headB is null)
        {
            return headA;
        }

        var nextA = headA.Next;
        var nextB = headB.Next;

        // a b c
        // x y z
        // a.next = x
        // a.next.next => x = b
        // a x b y c
        headA.Next = headB;
        headB.Next = ZipRecursive(nextA, nextB);

        return headA;
    }
}