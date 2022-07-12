using Reloaded.ModHelper;

namespace NoMansSky.Api
{
    /// <summary>
    ///  Represents a Inventory Table mbin.
    /// <br/>The exact mbin type is GcInventoryTable.
    /// </summary>
    internal class InventoriesFile : IInventoriesFile
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IModEvent OnLoaded { get; set; } = new SharedModEvent();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IMBin MBin { get; set; }
    }
}
