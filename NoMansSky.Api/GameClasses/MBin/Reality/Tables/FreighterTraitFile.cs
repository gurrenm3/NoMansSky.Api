using Reloaded.ModHelper;

namespace NoMansSky.Api
{
    /// <summary>
    /// Represents a Freighter Trait Table mbin.
    /// <br/>The exact mbin type is GcFrigateTraitTable.
    /// </summary>
    internal class FreighterTraitFile : IFreighterTraitFile
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
