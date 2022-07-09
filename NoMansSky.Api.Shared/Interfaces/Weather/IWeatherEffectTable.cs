using Reloaded.ModHelper;

namespace NoMansSky.Api
{
    /// <summary>
    /// Represents a GcWeatherEffectTable.
    /// </summary>
    public interface IWeatherEffectTable
    {
        /// <summary>
        /// Called whenever this WeatherEffectTable file gets loaded.
        /// </summary>
        public IModEvent OnLoaded { get; set; }

        /// <summary>
        /// The MBin File associated with this object
        /// </summary>
        public IMBin MBin { get; set; }
    }
}
