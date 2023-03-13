using Reloaded.ModHelper;

namespace NoMansSky.Api
{
    /// <summary>
    /// Represents the Vehicle global mbin file.
    /// <br/>The exact mbin type is GcVehicleGlobals.
    /// </summary>
    internal class VehicleGlobalFile : IVehicleGlobalFile
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
