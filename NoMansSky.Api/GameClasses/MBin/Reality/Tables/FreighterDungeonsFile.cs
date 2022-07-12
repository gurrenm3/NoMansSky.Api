using Reloaded.ModHelper;

namespace NoMansSky.Api
{
    /// <summary>
    /// Represents a Freighter Dungeons Table mbin.
    /// <br/>The exact mbin type is GcFreighterDungeonsTable.
    /// </summary>
    internal class FreighterDungeonsFile : IFreighterDungeonsFile
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
