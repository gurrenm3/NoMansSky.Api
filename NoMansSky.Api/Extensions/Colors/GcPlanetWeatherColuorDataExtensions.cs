using libMBIN.NMS;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace NoMansSky.Api
{
    /// <summary>
    /// Extension methods for <see cref="GcPlanetWeatherColourData"/>
    /// </summary>
    public static class GcPlanetWeatherColuorDataExtensions
    {
        /// <summary>
        /// Returns a dictionary of all the Name and Colour object for each color in this GcPlanetWeatherColourData.
        /// </summary>
        /// <param name="instance"></param>
        /// <returns></returns>
        public static Dictionary<string, Colour> GetAllColours(this GcPlanetWeatherColourData instance)
        {
            Dictionary<string, Colour> colours = new Dictionary<string, Colour>();
            colours.Add(nameof(instance.CloudColour1), instance.CloudColour1);
            colours.Add(nameof(instance.CloudColour2), instance.CloudColour2);
            colours.Add(nameof(instance.FogColour), instance.FogColour);
            colours.Add(nameof(instance.HeightFogColour), instance.HeightFogColour);
            colours.Add(nameof(instance.HorizonColour), instance.HorizonColour);
            colours.Add(nameof(instance.LightColour), instance.LightColour);
            colours.Add(nameof(instance.SkyColour), instance.SkyColour);
            colours.Add(nameof(instance.SkySolarColour), instance.SkySolarColour);
            colours.Add(nameof(instance.SkyUpperColour), instance.SkyUpperColour);
            colours.Add(nameof(instance.SunColour), instance.SunColour);

            return colours;
        }
    }
}
