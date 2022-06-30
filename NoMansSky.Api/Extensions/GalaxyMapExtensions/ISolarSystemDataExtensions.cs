using libMBIN.NMS;
using libMBIN.NMS.GameComponents;
using Reloaded.ModHelper;
using System.Collections.Generic;

namespace NoMansSky.Api
{
    /// <summary>
    /// Extension Methods for <see cref="ISolarSystemData"/>.
    /// </summary>
    public static class ISolarSystemDataExtensions
    {
        private static MemoryManager memoryMgr = new MemoryManager();

        /// <summary>
        /// Returns the Planet Data for all of the planets in this system.
        /// </summary>
        /// <param name="instance"></param>
        /// <returns></returns>
        public static List<GcPlanetData> GetPlanets(this ISolarSystemData instance)
        {
            List<GcPlanetData> planets = new List<GcPlanetData>();
            foreach (var planetAddress in instance.PlanetAddresses)
            {
                /*var planetName = memoryMgr.GetValue<NMSString0x80>(planetAddress);
                planets.Add(planetName);*/

                var planet = memoryMgr.GetValue<GcPlanetData>(planetAddress);
                planets.Add(planet);
            }
            return planets;
        }
    }
}
