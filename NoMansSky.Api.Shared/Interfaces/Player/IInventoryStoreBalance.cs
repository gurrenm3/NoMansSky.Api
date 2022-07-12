using Reloaded.ModHelper;

namespace NoMansSky.Api
{
    /// <summary>
    /// Represents an object from the GcInventoryBalance class
    /// </summary>
    public interface IInventoryStoreBalance
    {
        /// <summary>
        /// Runs when the address for this object has been acquired.
        /// </summary>
        public IModEvent OnLoaded { get; set; }

        /// <summary>
        /// The MBin file associated with this object.
        /// </summary>
        public IMBin MBin { get; }
    }
}
