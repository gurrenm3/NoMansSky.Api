using Reloaded.ModHelper;

namespace NoMansSky.Api
{
    /// <summary>
    /// Represents an Unlockable Trees mbin.
    /// <br/>The exact mbin type is GcUnlockableTrees.
    /// </summary>
    internal class UnlockableItemsFile : IUnlockableItemsFile
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
