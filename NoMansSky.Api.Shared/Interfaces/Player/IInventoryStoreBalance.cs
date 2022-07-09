using Reloaded.ModHelper;

namespace NoMansSky.Api
{
    /// <summary>
    /// Represents an object from the GcInventoryBalance class
    /// </summary>
    public interface IInventoryStoreBalance
    {
        /// <summary>
        /// The address of this object in memory.
        /// </summary>
        public long Address { get; }

        /// <summary>
        /// Runs when the address for this object has been acquired.
        /// </summary>
        public IModEvent OnLoaded { get; set; }
    }
}
