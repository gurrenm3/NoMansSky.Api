using Reloaded.ModHelper;
using System.Collections.Generic;

namespace NoMansSky.Api
{
    /// <summary>
    /// Represents a solar system.
    /// </summary>
    public interface ISolarSystem
    {
        /// <summary>
        /// The name of this solar system.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// The address of SolarSystemData for the current system.
        /// </summary>
        public long SystemDataAddress { get; set; }

        /// <summary>
        /// Called when you're loading into a system and the SolarSystemData is acquired.
        /// </summary>
        public IModEvent OnSystemLoaded { get; set; }

        /// <summary>
        /// Called when a planet's GcPlanetData is acquired when loading into the system.
        /// </summary>
        public IModEvent<IPlanet> OnPlanetLoaded { get; set; }

        /// <summary>
        /// Holds all of the planets in this system.
        /// </summary>
        public List<IPlanet> Planets { get; set; }
    }
}
