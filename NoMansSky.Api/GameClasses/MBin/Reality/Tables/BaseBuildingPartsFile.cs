using Reloaded.ModHelper;

namespace NoMansSky.Api
{
    /// <summary>
    /// Represents a Base Building Parts mbin.
    /// <br/>The exact mbin type is GcBaseBuildingPartsTable.
    /// </summary>
    internal class BaseBuildingPartsFile : IBaseBuildingPartsFile
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
