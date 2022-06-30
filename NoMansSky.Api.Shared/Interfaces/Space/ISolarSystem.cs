using Reloaded.ModHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoMansSky.Api
{
    /// <summary>
    /// Represents a solar system.
    /// </summary>
    public interface ISolarSystem
    {
        /// <summary>
        /// Called when you're loading into a system and the SolarSystemData is acquired.
        /// </summary>
        public IModEvent<long> OnSystemLoaded { get; set; }

        /// <summary>
        /// The address of SolarSystemData for the current system.
        /// </summary>
        public long SystemAddress { get; set; }

        /// <summary>
        /// Called when a planet's GcPlanetData is acquired when loading into the system.
        /// </summary>
        public IModEvent<long> OnPlanetLoaded { get; set; }

        /// <summary>
        /// Holds the addresses of all the planets in this system.
        /// </summary>
        public List<long> PlanetAddresses { get; set; }
    }
}
