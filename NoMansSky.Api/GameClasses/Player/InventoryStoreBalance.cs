using Reloaded.ModHelper;

namespace NoMansSky.Api
{
    /// <summary>
    /// Represents an object from the GcInventoryBalance class
    /// </summary>
    public class InventoryStoreBalance : IInventoryStoreBalance
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public long Address { get; private set; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IModEvent OnLoaded { get; set; } = new SharedModEvent();

        /// <summary>
        /// Sets the address for this object.
        /// </summary>
        /// <param name="address"></param>
        public void SetAddress(long address)
        {
            Address = address;
            OnLoaded.Invoke();
        }
    }
}
