using System.Collections.Generic;

public class Tree<T>
{
    public Tree(T parent, T item)
    {
        Parent = parent;
        Item = item;
    }

    public T Parent { get; private set; }
    public T Item { get; private set; }
    public List<T> Children { get; private set; }

    public void AddChild(T child)
    {
        Children.Add(child);
    }
}