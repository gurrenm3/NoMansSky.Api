using Reloaded.ModHelper;
using System.Collections.Generic;
using System.Linq;

namespace NoMansSky.Api
{
    /// <summary>
    /// A container for all Weather mbin files in NMS.
    /// </summary>
    internal class WeatherManager : IWeatherManager
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IModEvent<IWeatherEffect> OnWeatherEffectLoaded { get; set; } = new SharedModEvent<IWeatherEffect>();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IModEvent<IWeatherFile> OnWeatherFileLoaded { get; set; } = new SharedModEvent<IWeatherFile>();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public List<IWeatherFile> AllWeatherFiles { get; set; } = new List<IWeatherFile>();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IWeatherListFile WeatherList { get; } = new WeatherListFile();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IWeatherEffect WeatherEffects { get; } = new WeatherEffect();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IWeatherEffect WeatherHazards { get; } = new WeatherEffect();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IWeatherFile ClearWeather { get; } = new WeatherFile();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IWeatherFile DustWeather { get; } = new WeatherFile();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IWeatherFile HumidWeather { get; } = new WeatherFile();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IWeatherFile SnowWeather { get; } = new WeatherFile();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IWeatherFile Toxic { get; } = new WeatherFile();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IWeatherFile Scorched { get; } = new WeatherFile();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IWeatherFile Radioactive { get; } = new WeatherFile();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IWeatherFile RedWeather { get; } = new WeatherFile();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IWeatherFile GreenWeather { get; } = new WeatherFile();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IWeatherFile BlueWeather { get; } = new WeatherFile();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IWeatherFile SwampWeather { get; } = new WeatherFile();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IWeatherFile LavaWeather { get; } = new WeatherFile();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IWeatherFile BubbleWeather { get; } = new WeatherFile();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IWeatherFile GravityStormWeather { get; } = new WeatherFile();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IWeatherFile FireStormWeather { get; } = new WeatherFile();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IWeatherFile ClearCold { get; } = new WeatherFile();


        private Dictionary<string, IWeatherFile> weatherFiles = new Dictionary<string, IWeatherFile>();

        /// <summary>
        /// Initializes this object.
        /// </summary>
        public WeatherManager()
        {
            var properties = GetType().GetProperties();
            foreach (var property in properties)
            {
                if (!property.PropertyType.IsAssignableTo(typeof(IWeatherFile)))
                    continue;

                var actualProperty = (IWeatherFile)property.GetValue(this);
                weatherFiles.Add(property.Name, actualProperty);
            }


            IGame.Instance.MBinManager.OnMBinLoaded.AddListener(mbin =>
            {
                if (!mbin.FullName.ToLower().Contains("metadata/simulation/solarsystem/weather/")) // it's a weather file if it has this
                    return;

                if (mbin.FullName.ToLower().Contains("skysettings")) // we don't want the colors
                    return;

                string mbinName = mbin.Name.ToLower();
                var result = weatherFiles.FirstOrDefault(weather => mbinName.Contains(weather.Key.ToLower()));
                if (result.Value != null)
                {
                    var weatherFile = result.Value;

                    AllWeatherFiles.Add(weatherFile);
                    weatherFile.MBin = mbin;
                    weatherFile.OnLoaded.Invoke();
                    OnWeatherFileLoaded.Invoke(weatherFile);
                }
                else if (mbinName == "weathereffects")
                {
                    WeatherEffects.MBin = mbin;
                    WeatherEffects.OnLoaded.Invoke();
                    OnWeatherEffectLoaded.Invoke(WeatherEffects);
                }
                else if (mbinName == "weatherhazards")
                {
                    WeatherHazards.MBin = mbin;
                    WeatherHazards.OnLoaded.Invoke();
                    OnWeatherEffectLoaded.Invoke(WeatherHazards);
                }
                else if (mbinName == "weatherlist")
                {
                    WeatherList.MBin = mbin;
                    WeatherList.OnLoaded.Invoke();
                }
                else
                {
                    ConsoleUtil.LogError($"Critical Error! Failed to load the {mbin.Name} weather MBin!!");
                }
            });
        }
    }
}
