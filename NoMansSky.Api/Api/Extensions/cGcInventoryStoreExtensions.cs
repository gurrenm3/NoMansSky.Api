namespace NoMansSky.Api;

/// <summary>
/// Extension methods for <see cref="cGcInventoryStore"/>.
/// </summary>
public static unsafe class cGcInventoryStoreExtensions
{
    /// <summary>
    /// Returns the element stored at the provied X and Y position.
    /// </summary>
    /// <param name="store"></param>
    /// <param name="x"></param>
    /// <param name="y"></param>
    /// <returns></returns>
    public static cGcInventoryElement* GetElement(this cGcInventoryStore store, int x, int y)
    {
        if (x >= store.width)
            throw new ArgumentOutOfRangeException("x");

        if (y >= store.height)
            throw new ArgumentOutOfRangeException("y");

        cGcInventoryIndex index = new cGcInventoryIndex();
        index.x = x;
        index.y = y;


        using var indexPtr = new UnmanagedStructPtr<cGcInventoryIndex>(index);
        return store.GetElement((cGcInventoryIndex*)indexPtr.Instance);
    }
}
