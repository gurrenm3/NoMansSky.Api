using Reloaded.ModHelper;

namespace NoMansSky.Api
{
    /// <summary>
    /// Deals with all general weather data for NMS.
    /// </summary>
    public interface IWeatherData
    {
        /// <summary>
        /// Contains general weather effects.
        /// <br/>Equivalent to WEATHEREFFECTS.MBIN.
        /// </summary>
        public IWeatherEffectTable WeatherEffects { get; }

        /// <summary>
        /// Contains all possible weather hazards. 
        /// <br/>Equivalent to WEATHERHAZARDS.MBIN.
        /// </summary>
        public IWeatherEffectTable WeatherHazards { get; }

        /// <summary>
        /// Called whenever a WeatherEffectTable gets loaded by the game.
        /// <br/>Passes the loaded effect table as an argument.
        /// </summary>
        public IModEvent<IWeatherEffectTable> OnEffectTableLoaded { get; set; }
    }
}
