public class NaryNode<T>
{
    public T Value { get; private set; }
    public List<NaryNode<T>> Children { get; private set; }

    public NaryNode(T t)
    {
        Value = t;
        Children = new List<NaryNode<T>>();
    }

    public void AddChild(NaryNode<T> child)
    {
        Children.Add(child);
    }

    public override string ToString()
    {
        return $"{Value}: {Children.Aggregate("", (current, child) => $"{current} {child.Value?.ToString()}")}";
    }
}
