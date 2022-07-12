using Reloaded.ModHelper;

namespace NoMansSky.Api
{
    /// <summary>
    /// Represents a Dialog Clearance Table mbin.
    /// <br/>The exact mbin type is GcDialogClearanceTable.
    /// </summary>
    internal class DialogClearanceFile : IDialogClearanceFile
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
