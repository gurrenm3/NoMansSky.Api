namespace NoMansSky.Api.Definitions;

/// <summary>
/// Represents a KeyValue pair in memory.
/// </summary>
/// <typeparam name="TKey"></typeparam>
/// <typeparam name="TValue"></typeparam>
public unsafe interface IVirtualPair<TKey, TValue> : IMemoryObject
{
    /// <summary>
    /// The Key for this pair.
    /// </summary>
    public TKey Key { get; }

    /// <summary>
    /// The value of this pair.
    /// </summary>
    public TValue Value { get; }
}
