using Reloaded.ModHelper;

namespace NoMansSky.Api
{
    /// <summary>
    /// Represents a Base Building Table mbin.
    /// <br/>The exact mbin type is GcBaseBuildingTable.
    /// </summary>
    internal class BaseBuildingFile : IBaseBuildingFile
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
