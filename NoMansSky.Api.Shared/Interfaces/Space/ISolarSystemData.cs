using System;
using System.Collections.Generic;

namespace NoMansSky.Api
{
    /// <summary>
    /// Represents data about a solar system.
    /// </summary>
    public interface ISolarSystemData
    {
        /// <summary>
        /// Contains the base addresses of the planets in this system.
        /// </summary>
        public List<long> PlanetAddresses { get; set; }
    }
}
