using Reloaded.ModHelper;

namespace NoMansSky.Api
{
    /// <summary>
    /// Represents a Base Building Parts Data Table mbin.
    /// <br/>The exact mbin type is GcBaseBuildingPartsDataTable.
    /// </summary>
    internal class BaseBuildingPartsDataFile : IBaseBuildingPartsDataFile
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
