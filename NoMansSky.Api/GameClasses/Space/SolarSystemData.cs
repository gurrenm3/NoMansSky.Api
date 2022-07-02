using System;
using System.Collections.Generic;

namespace NoMansSky.Api
{
    /// <summary>
    /// Contains info about a solar system.
    /// </summary>
    public class SolarSystemData : ISolarSystemData
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public List<long> PlanetAddresses { get; set; } = new List<long>();
    }
}
