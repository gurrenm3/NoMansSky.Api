using Reloaded.ModHelper;

namespace NoMansSky.Api
{
    /// <summary>
    /// Represents a Frigate Flyby Table mbin.
    /// <br/>The exact mbin type is GcFrigateFlybyTable.
    /// </summary>
    internal class FrigateFlybyFile : IFrigateFlybyFile
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
