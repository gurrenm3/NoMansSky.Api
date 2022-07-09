using Reloaded.ModHelper;

namespace NoMansSky.Api
{
    /// <summary>
    /// Deals with all general weather data for NMS.
    /// </summary>
    public class WeatherData : IWeatherData
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IModEvent<IWeatherEffectTable> OnEffectTableLoaded { get; set; } = new ModEvent<IWeatherEffectTable>();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IWeatherEffectTable WeatherEffects { get; } = new WeatherEffectTable();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IWeatherEffectTable WeatherHazards { get; } = new WeatherEffectTable();

        public WeatherData()
        {
            IGame.Instance.MBinManager.OnMBinLoaded.AddListener(mbin =>
            {
                if (mbin.MBinName == "WEATHEREFFECTS")
                {
                    WeatherEffects.MBin = mbin;
                    WeatherEffects.OnLoaded.Invoke();
                    OnEffectTableLoaded.Invoke(WeatherEffects);
                }
                else if (mbin.MBinName == "WEATHERHAZARDS")
                {
                    WeatherHazards.MBin = mbin;
                    WeatherHazards.OnLoaded.Invoke();
                    OnEffectTableLoaded.Invoke(WeatherHazards);
                }
            });
        }
    }
}
