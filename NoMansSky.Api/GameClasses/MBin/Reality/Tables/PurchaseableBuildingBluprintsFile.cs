using Reloaded.ModHelper;

namespace NoMansSky.Api
{
    /// <summary>
    /// Represents a Purchaseable Building Blueprints Table mbin.
    /// <br/>The exact mbin type is GcPurchaseableBuildingBlueprints.
    /// </summary>
    internal class PurchaseableBuildingBluprintsFile : IPurchaseableBuildingBluprintsFile
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
