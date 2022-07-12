using Reloaded.ModHelper;
using System.Collections.Generic;
using System.Linq;

namespace NoMansSky.Api
{
    /// <summary>
    /// A container for all color mbin files in the game.
    /// </summary>
    internal class ColorsManager : IColorsManager
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IModEvent<IColorsFile> OnColorLoaded { get; set; } = new SharedModEvent<IColorsFile>();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public List<IColorsFile> AllColors { get; private set; } = new List<IColorsFile>();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IPaletteColorsFile LegacyBaseColors { get; private set; } = new PaletteColorsFile();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IPaletteColorsFile BaseColors  { get; private set; } = new PaletteColorsFile();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IWaterColorsFile WaterColors  { get; private set; } = new WaterColorsFile();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IWeatherColorsFile DaySkyColors  { get; private set; } = new WeatherColorsFile();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IWeatherColorsFile DuskSkyColors  { get; private set; } = new WeatherColorsFile();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IWeatherColorsFile NightSkyColors  { get; private set; } = new WeatherColorsFile();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public ISpaceColorsFile SpaceSkyColors  { get; private set; } = new SpaceColorsFile();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public ISpaceColorsFile RareSpaceSkyColors  { get; private set; } = new SpaceColorsFile();


        /// <summary>
        /// Creates an instance of this object.
        /// </summary>
        public ColorsManager()
        {
            IGame.Instance.MBinManager.OnMBinLoaded.AddListener(mbin =>
            {
                IColorsFile colorFile = null!;

                switch (mbin.Name)
                {
                    case "DAYSKYCOLOURS":
                        colorFile = DaySkyColors;
                        break;
                    case "DUSKSKYCOLOURS":
                        colorFile = DuskSkyColors;
                        break;
                    case "NIGHTSKYCOLOURS":
                        colorFile = NightSkyColors;
                        break;
                    case "WATERCOLOURS":
                        colorFile = WaterColors;
                        break;
                    case "SPACESKYCOLOURS":
                        colorFile = SpaceSkyColors;
                        break;
                    case "SPACERARESKYCOLOURS":
                        colorFile = RareSpaceSkyColors;
                        break;
                    case "LEGACYBASECOLOURPALETTES":
                        colorFile = LegacyBaseColors;
                        break;
                    case "BaseColourPalettes":
                        colorFile = BaseColors;
                        break;
                    default:
                        break;
                }

                if (colorFile == null)
                    return;

                AllColors.Add(colorFile);
                colorFile.MBin = mbin;
                colorFile.OnLoaded.Invoke();
                OnColorLoaded.Invoke(colorFile);
            });
        }
    }
}
