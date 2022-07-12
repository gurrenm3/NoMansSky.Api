using Reloaded.ModHelper;

namespace NoMansSky.Api
{
    /// <summary>
    /// Represents a Purchaseable Specials Table mbin.
    /// <br/>The exact mbin type is GcPurchaseableSpecials.
    /// </summary>
    internal class PurchaseableSpecialsFile : IPurchaseableSpecialsFile
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
