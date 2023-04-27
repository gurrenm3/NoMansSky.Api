namespace NoMansSky.Api;

internal class TkMemoryManager : ITkMemoryManager
{
    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public long Pointer { get; private set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public IModEvent<long> OnPointerAcquired { get; set; } = new SharedModEvent<long>();

    public TkMemoryManager()
    {
        OnPointerAcquired.AddRunner(ptr =>
        {
            if (Pointer == 0)
                Pointer = ptr;
        });
    }
}
