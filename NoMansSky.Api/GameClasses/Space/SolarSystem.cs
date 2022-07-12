using libMBIN;
using libMBIN.NMS.GameComponents;
using Reloaded.ModHelper;
using System.Collections.Generic;

namespace NoMansSky.Api
{
    /// <summary>
    /// Represents the solar system that the player is currently in.
    /// </summary>
    internal class SolarSystem : ISolarSystem
    {
        private static MemoryManager memory = new MemoryManager();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public long SystemDataAddress { get; set; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public string Name
        {
            get => SystemDataAddress <= 0 ? null! : memory.GetValue<string>(SystemDataAddress + nameOffset);
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IModEvent OnSystemLoaded { get; set; } = new SharedModEvent();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IModEvent<IPlanet> OnPlanetLoaded { get; set; } = new SharedModEvent<IPlanet>();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public List<IPlanet> Planets { get; set; } = new List<IPlanet>();

        private readonly int nameOffset;


        /// <summary>
        /// Creates an instance of this class.
        /// </summary>
        public SolarSystem()
        {
            nameOffset = NMSTemplate.OffsetOf(nameof(GcSolarSystemData), nameof(GcSolarSystemData.Name));
            OnPlanetLoaded += Planets.Add;
            IGame.Instance.OnWarpStarted += () => Planets.Clear();
        }
    }
}
