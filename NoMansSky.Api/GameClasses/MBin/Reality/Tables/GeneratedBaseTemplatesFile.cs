using Reloaded.ModHelper;

namespace NoMansSky.Api
{
    /// <summary>
    /// Represents a Generated Base Templates Table mbin.
    /// <br/>The exact mbin type is GcGeneratedBaseTemplatesTable.
    /// </summary>
    internal class GeneratedBaseTemplatesFile : IGeneratedBaseTemplatesFile
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
