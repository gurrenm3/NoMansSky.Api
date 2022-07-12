using Reloaded.ModHelper;

namespace NoMansSky.Api
{
    /// <summary>
    /// Represents a GcWeatherEffectTable mbin.
    /// <br/>The exact mbin type is GcWeatherEffectTable.
    /// </summary>
    internal class WeatherEffect : IWeatherEffect
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
