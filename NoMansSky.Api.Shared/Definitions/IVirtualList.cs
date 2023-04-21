namespace NoMansSky.Api.Definitions;

public unsafe interface IVirtualList<T> : IMemoryObject where T : struct
{
    /// <summary>
    /// The total number of items in this list.
    /// </summary>
    public int Count { get; }

    public T* this[int index]
    {
        get => GetElement(index);
        set => SetElement(index, value);
    }


    /// <summary>
    /// Add an element to this list.
    /// </summary>
    /// <param name="value"></param>
    public void Add(T value);

    /// <summary>
    /// Add an element to this list.
    /// </summary>
    /// <param name="value"></param>
    public void Add(T* value);

    /// <summary>
    /// Remove an existing element from this list.
    /// </summary>
    /// <param name="index"></param>
    public void RemoveAt(int index);

    /// <summary>
    /// Set the value of an element at the specified index.
    /// </summary>
    /// <param name="index"></param>
    /// <param name="value"></param>
    public void SetElement(int index, T value);

    /// <summary>
    /// Set the value of an element at the specified index.
    /// </summary>
    /// <param name="index"></param>
    /// <param name="value"></param>
    public void SetElement(int index, T* value);

    /// <summary>
    /// Returns the element stored at a particular index.
    /// </summary>
    /// <param name="index"></param>
    /// <returns></returns>
    public T* GetElement(int index);
}
