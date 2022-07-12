using Reloaded.ModHelper;

namespace NoMansSky.Api
{
    /// <summary>
    /// Represents a Maintenance Groups Table mbin.
    /// <br/>The exact mbin type is GcMaintenanceGroupsTable.
    /// </summary>
    internal class MaintenanceGroupsFile : IMaintenanceGroupsFile
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
