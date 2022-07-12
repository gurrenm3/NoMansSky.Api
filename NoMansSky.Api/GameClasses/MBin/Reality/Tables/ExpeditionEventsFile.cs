using Reloaded.ModHelper;

namespace NoMansSky.Api
{
    /// <summary>
    /// Represents a Expedition Event Table mbin.
    /// <br/>The exact mbin type is GcExpeditionEventTable.
    /// </summary>
    internal class ExpeditionEventsFile : IExpeditionEventsFile
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
