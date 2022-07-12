using Reloaded.ModHelper;
using System.Collections.Generic;

namespace NoMansSky.Api
{
    /// <summary>
    /// A container for all color mbin files in the game.
    /// </summary>
    public interface IColorsManager
    {
        /// <summary>
        /// Called whenever a Colors Mbin file is loaded.
        /// Passes the ColorFile that was loaded as an argument.
        /// </summary>
        public IModEvent<IColorsFile> OnColorLoaded { get; set; }

        /// <summary>
        /// A list of all the color files in this class.
        /// <br/>Provided for convenience.
        /// </summary>
        public List<IColorsFile> AllColors { get; }

        /// <summary>
        /// Represents the LegacyBaseColors mbin file.
        /// <br/>The exact mbin type is GcPaletteList.
        /// <br/><br/>This mbin file is located in METADATA\SIMULATION\SOLARSYSTEM\WEATHER\SKYSETTINGS
        /// </summary>
        public IPaletteColorsFile LegacyBaseColors { get; }

        /// <summary>
        /// Represents the BaseColors mbin file.
        /// <br/>The exact mbin type is GcPaletteList.
        /// <br/><br/>This mbin file is located in METADATA\SIMULATION\SOLARSYSTEM\WEATHER\SKYSETTINGS
        /// </summary>
        public IPaletteColorsFile BaseColors { get; }

        /// <summary>
        /// Represents the WaterColors mbin file.
        /// <br/>The exact mbin type is GcWaterColourSettingList.
        /// <br/><br/>This mbin file is located in GAMEDATA\PCBANKS\METADATA\SIMULATION\SOLARSYSTEM\WEATHER\SKYSETTINGS
        /// </summary>
        public IWaterColorsFile WaterColors { get; }

        /// <summary>
        /// Represents the DaySkyColors mbin file.
        /// <br/>The exact mbin type is GcWeatherColourSettings.
        /// <br/><br/>This mbin file is located in METADATA\SIMULATION\SOLARSYSTEM\WEATHER\SKYSETTINGS
        /// </summary>
        public IWeatherColorsFile DaySkyColors { get; }

        /// <summary>
        /// Represents the DuskSkyColors mbin file.
        /// <br/>The exact mbin type is GcWeatherColourSettings.
        /// <br/><br/>This mbin file is located in METADATA\SIMULATION\SOLARSYSTEM\WEATHER\SKYSETTINGS
        /// </summary>
        public IWeatherColorsFile DuskSkyColors { get; }

        /// <summary>
        /// Represents the NightSkyColors mbin file.
        /// <br/>The exact mbin type is GcWeatherColourSettings.
        /// <br/><br/>This mbin file is located in METADATA\SIMULATION\SOLARSYSTEM\WEATHER\SKYSETTINGS
        /// </summary>
        public IWeatherColorsFile NightSkyColors { get; }

        /// <summary>
        /// Represents the SpaceSkyColors mbin file.
        /// <br/>The exact mbin type is GcSpaceSkyColourSettingList.
        /// <br/><br/>This mbin file is located in METADATA\SIMULATION\SOLARSYSTEM\WEATHER\SKYSETTINGS
        /// </summary>
        public ISpaceColorsFile SpaceSkyColors { get; }

        /// <summary>
        /// Represents the RareSpaceSkyColors mbin file.
        /// <br/>The exact mbin type is GcSpaceSkyColourSettingList.
        /// <br/><br/>This mbin file is located in METADATA\SIMULATION\SOLARSYSTEM\WEATHER\SKYSETTINGS
        /// </summary>
        public ISpaceColorsFile RareSpaceSkyColors { get; }
    }
}
