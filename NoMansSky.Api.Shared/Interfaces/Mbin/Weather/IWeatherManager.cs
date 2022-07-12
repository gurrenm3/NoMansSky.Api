using Reloaded.ModHelper;
using System.Collections.Generic;

namespace NoMansSky.Api
{
    /// <summary>
    /// A container for all Weather mbin files in NMS.
    /// </summary>
    public interface IWeatherManager
    {
        /// <summary>
        /// Called whenever a WeatherFile is loaded.
        /// Passes the WeatherFile file that was loaded as an argument.
        /// </summary>
        public IModEvent<IWeatherFile> OnWeatherFileLoaded { get; set; }

        /// <summary>
        /// Called when a WeatherEffect file is loaded.
        /// </summary>
        public IModEvent<IWeatherEffect> OnWeatherEffectLoaded { get; set; }

        /// <summary>
        /// A list of all the Weather Files in this class.
        /// <br/>Provided for convenience.
        /// <br/>Note, this only contains the variables with the type <see cref="IWeatherFile"/>.
        /// </summary>
        public List<IWeatherFile> AllWeatherFiles { get; set; }

        /// <summary>
        /// Represents the WeatherList mbin file.
        /// <br/>The exact mbin type is GcWeatherTable.
        /// <br/><br/>This mbin file is located in GAMEDATA\PCBANKS\METADATA\SIMULATION\SOLARSYSTEM\WEATHER
        /// </summary>
        public IWeatherListFile WeatherList { get; }

        /// <summary>
        /// Represents the WeatherEffects mbin file.
        /// <br/>The exact mbin type is GcWeatherEffectTable.
        /// <br/><br/>This mbin file is located in METADATA\SIMULATION\SOLARSYSTEM\WEATHER
        /// </summary>
        public IWeatherEffect WeatherEffects { get; }

        /// <summary>
        /// Represents the WeatherHazards mbin file.
        /// <br/>The exact mbin type is GcWeatherEffectTable.
        /// <br/><br/>This mbin file is located in METADATA\SIMULATION\SOLARSYSTEM\WEATHER
        /// </summary>
        public IWeatherEffect WeatherHazards { get; }


        /// <summary>
        /// Represents the ClearWeather mbin file.
        /// <br/>The exact mbin type is GcWeatherProperties.
        /// <br/><br/>This mbin file is located in METADATA\SIMULATION\SOLARSYSTEM\WEATHER
        /// </summary>
        public IWeatherFile ClearWeather { get; }

        /// <summary>
        /// Represents the DustWeather mbin file.
        /// <br/>The exact mbin type is GcWeatherProperties.
        /// <br/><br/>This mbin file is located in METADATA\SIMULATION\SOLARSYSTEM\WEATHER
        /// </summary>
        public IWeatherFile DustWeather  { get; }

        /// <summary>
        /// Represents the HumidWeather mbin file.
        /// <br/>The exact mbin type is GcWeatherProperties.
        /// <br/><br/>This mbin file is located in METADATA\SIMULATION\SOLARSYSTEM\WEATHER
        /// </summary>
        public IWeatherFile HumidWeather  { get; }

        /// <summary>
        /// Represents the SnowWeather mbin file.
        /// <br/>The exact mbin type is GcWeatherProperties.
        /// <br/><br/>This mbin file is located in METADATA\SIMULATION\SOLARSYSTEM\WEATHER
        /// </summary>
        public IWeatherFile SnowWeather  { get; }

        /// <summary>
        /// Represents the Toxic mbin file.
        /// <br/>The exact mbin type is GcWeatherProperties.
        /// <br/><br/>This mbin file is located in METADATA\SIMULATION\SOLARSYSTEM\WEATHER
        /// </summary>
        public IWeatherFile Toxic  { get; }

        /// <summary>
        /// Represents the Scorched mbin file.
        /// <br/>The exact mbin type is GcWeatherProperties.
        /// <br/><br/>This mbin file is located in METADATA\SIMULATION\SOLARSYSTEM\WEATHER
        /// </summary>
        public IWeatherFile Scorched  { get; }

        /// <summary>
        /// Represents the Radioactive mbin file.
        /// <br/>The exact mbin type is GcWeatherProperties.
        /// <br/><br/>This mbin file is located in METADATA\SIMULATION\SOLARSYSTEM\WEATHER
        /// </summary>
        public IWeatherFile Radioactive  { get; }

        /// <summary>
        /// Represents the RedWeather mbin file.
        /// <br/>The exact mbin type is GcWeatherProperties.
        /// <br/><br/>This mbin file is located in METADATA\SIMULATION\SOLARSYSTEM\WEATHER
        /// </summary>
        public IWeatherFile RedWeather  { get; }

        /// <summary>
        /// Represents the GreenWeather mbin file.
        /// <br/>The exact mbin type is GcWeatherProperties.
        /// <br/><br/>This mbin file is located in METADATA\SIMULATION\SOLARSYSTEM\WEATHER
        /// </summary>
        public IWeatherFile GreenWeather  { get; }

        /// <summary>
        /// Represents the BlueWeather mbin file.
        /// <br/>The exact mbin type is GcWeatherProperties.
        /// <br/><br/>This mbin file is located in METADATA\SIMULATION\SOLARSYSTEM\WEATHER
        /// </summary>
        public IWeatherFile BlueWeather  { get; }

        /// <summary>
        /// Represents the SwampWeather mbin file.
        /// <br/>The exact mbin type is GcWeatherProperties.
        /// <br/><br/>This mbin file is located in METADATA\SIMULATION\SOLARSYSTEM\WEATHER
        /// </summary>
        public IWeatherFile SwampWeather  { get; }

        /// <summary>
        /// Represents the LavaWeather mbin file.
        /// <br/>The exact mbin type is GcWeatherProperties.
        /// <br/><br/>This mbin file is located in METADATA\SIMULATION\SOLARSYSTEM\WEATHER
        /// </summary>
        public IWeatherFile LavaWeather  { get; }

        /// <summary>
        /// Represents the BubbleWeather mbin file.
        /// <br/>The exact mbin type is GcWeatherProperties.
        /// <br/><br/>This mbin file is located in METADATA\SIMULATION\SOLARSYSTEM\WEATHER
        /// </summary>
        public IWeatherFile BubbleWeather  { get; }

        /// <summary>
        /// Represents the GravityStormWeather mbin file.
        /// <br/>The exact mbin type is GcWeatherProperties.
        /// <br/><br/>This mbin file is located in METADATA\SIMULATION\SOLARSYSTEM\WEATHER
        /// </summary>
        public IWeatherFile GravityStormWeather  { get; }

        /// <summary>
        /// Represents the FireStormWeather mbin file.
        /// <br/>The exact mbin type is GcWeatherProperties.
        /// <br/><br/>This mbin file is located in METADATA\SIMULATION\SOLARSYSTEM\WEATHER
        /// </summary>
        public IWeatherFile FireStormWeather  { get; }

        /// <summary>
        /// Represents the ClearCold mbin file.
        /// <br/>The exact mbin type is GcWeatherProperties.
        /// <br/><br/>This mbin file is located in METADATA\SIMULATION\SOLARSYSTEM\WEATHER
        /// </summary>
        public IWeatherFile ClearCold  { get; }
    }
}
