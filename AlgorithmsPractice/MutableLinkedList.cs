namespace AlgorithmsPractice;

public class MutableLinkedList<T>
{
    public MutableLinkedList()
    {
        Head = this;
    }

    public MutableLinkedList<T>? Next { get; set; }
    public MutableLinkedList<T> Head { get; }
    public T? Value { get; set; }

    public MutableLinkedList<T> Add(T value)
    {
        Next = new MutableLinkedList<T>
        {
            Value = value
        };

        return Next;
    }
}