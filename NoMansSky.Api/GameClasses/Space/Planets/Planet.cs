using libMBIN;
using libMBIN.NMS.GameComponents;
using Reloaded.ModHelper;

namespace NoMansSky.Api
{
    /// <summary>
    /// Represents a planet
    /// </summary>
    public class Planet : IPlanet
    {
        private static MemoryManager memory = new MemoryManager();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public long PlanetDataAddress { get; set; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public string Name
        {
            get => PlanetDataAddress <= 0 ? null! : memory.GetValue<string>(PlanetDataAddress + nameOffset);
        }

        private readonly int nameOffset;

        public Planet()
        {
            nameOffset = NMSTemplate.OffsetOf(nameof(GcPlanetData), nameof(GcPlanetData.Name));
        }
    }
}
