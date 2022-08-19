public class BinaryNode<T>
{
    public T Value { get; private set; }
    public BinaryNode<T>? LeftChild { get; set; }
    public BinaryNode<T>? RightChild { get; set; }

    public BinaryNode(T t)
    {
        Value = t;
        LeftChild = null;
        RightChild = null;
    }

    public void AddLeft(BinaryNode<T>? child)
    {
        LeftChild = child;
    }

    public void AddRight(BinaryNode<T>? child)
    {
        RightChild = child;
    }

    public override string ToString()
    {
        var leftChildValue = LeftChild != null ? LeftChild.Value?.ToString() : "null";
        var rightChildValue = RightChild != null ? RightChild.Value?.ToString() : "null";

        return $"{Value}: {leftChildValue} {rightChildValue}";
    }
}
