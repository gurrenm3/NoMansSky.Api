using Reloaded.ModHelper;

namespace NoMansSky.Api
{
    /// <summary>
    /// Represents a Procedural Technology Table mbin.
    /// <br/>The exact mbin type is GcProceduralTechnologyTable.
    /// </summary>
    internal class ProceduralTechnologiesFile : IProceduralTechnologiesFile
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
