using Reloaded.ModHelper;

namespace NoMansSky.Api
{
    /// <summary>
    /// Represents one Weather definition file. Ex: WEATHER/TOXIC.MXML
    /// <br/>The exact mbin type is GcWeatherProperties.
    /// </summary>
    internal class WeatherFile : IWeatherFile
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
