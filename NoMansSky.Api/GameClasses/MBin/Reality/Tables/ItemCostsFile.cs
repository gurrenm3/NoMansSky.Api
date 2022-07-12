using Reloaded.ModHelper;

namespace NoMansSky.Api
{
    /// <summary>
    /// Represents an Item Costs Table mbin.
    /// <br/>The exact mbin type is GcItemCostTable.
    /// </summary>
    internal class ItemCostsFile : IItemCostsFile
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
