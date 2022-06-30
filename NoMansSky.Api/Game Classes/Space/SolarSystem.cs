using Reloaded.ModHelper;
using System.Collections.Generic;

namespace NoMansSky.Api
{
    /// <summary>
    /// Represents the solar system that the player is currently in.
    /// </summary>
    public class SolarSystem : ISolarSystem
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IModEvent<long> OnSystemLoaded { get; set; } = new SharedModEvent<long>();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public long SystemAddress { get; set; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IModEvent<long> OnPlanetLoaded { get; set; } = new SharedModEvent<long>();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public List<long> PlanetAddresses { get; set; } = new List<long>();


        /// <summary>
        /// Creates an instance of this class.
        /// </summary>
        public SolarSystem()
        {
            
        }
    }
}
