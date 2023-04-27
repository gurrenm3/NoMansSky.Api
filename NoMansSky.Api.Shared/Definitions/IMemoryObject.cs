using Reloaded.ModHelper;

namespace NoMansSky.Api.Definitions;

/// <summary>
/// Represents an object in memory.
/// </summary>
public interface IMemoryObject
{
    /// <summary>
    /// The original memory location/address of this object.
    /// </summary>
    public long Pointer { get; }

    /// <summary>
    /// Called when the pointer for this object has been acquired.
    /// </summary>
    public IModEvent<long> OnPointerAcquired { get; set; }
}
