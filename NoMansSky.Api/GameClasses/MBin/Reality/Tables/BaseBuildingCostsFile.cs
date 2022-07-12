using Reloaded.ModHelper;

namespace NoMansSky.Api
{
    /// <summary>
    /// Represents a Base Building Costs mbin.
    /// <br/>The exact mbin type is GcBaseBuildingCostsTable.
    /// </summary>
    internal class BaseBuildingCostsFile : IBaseBuildingCostsFile
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
