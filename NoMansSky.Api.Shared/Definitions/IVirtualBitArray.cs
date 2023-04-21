namespace NoMansSky.Api.Definitions;

/// <summary>
/// Represents a BitArray in memory.
/// </summary>
/// <typeparam name="T"></typeparam>
public interface IVirtualBitArray<T> : IMemoryObject where T : struct
{
    /// <summary>
    /// The number of rows in this array.
    /// </summary>
    public int Height { get; }

    /// <summary>
    /// The number of elements in each row.
    /// </summary>
    public int Width { get; }

    /// <summary>
    /// The total number of elements in this array.
    /// </summary>
    public int Count { get; }


    /// <summary>
    /// Returns the value of a specific element.
    /// </summary>
    /// <param name="index">The position of this element in <see cref="Count"/>.</param>
    /// <returns></returns>
    public bool GetElement(int index);

    /// <summary>
    /// Set the value of an element at the specified index.
    /// </summary>
    /// <param name="index">The position of this element in <see cref="Count"/>.</param>
    /// <param name="value">New value for the element.</param>
    public void SetElement(int index, bool value);
    
    /// <summary>
    /// Returns the total number of elements with a value of "true".
    /// </summary>
    /// <returns></returns>
    public int GetNumTrue();

    /// <summary>
    /// Sets the value of the first N number of bits to true.
    /// </summary>
    /// <param name="amount">Number of bits to set to true.</param>
    public void SetFirstNBitsTrue(int amount);

    /// <summary>
    /// Sets the value of every element in the array.
    /// </summary>
    /// <param name="value">PointerValue to set.</param>
    void SetAllElements(bool value);
}
