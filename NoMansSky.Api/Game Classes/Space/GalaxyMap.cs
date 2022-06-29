using Reloaded.ModHelper;

namespace NoMansSky.Api
{
    /// <summary>
    /// Represents the Galaxy Map.
    /// </summary>
    public class GalaxyMap : IGalaxyMap
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IModEvent<ISolarSystemData> OnSystemHighlighted { get; set; }

        public GalaxyMap()
        {
            OnSystemHighlighted = new SharedModEvent<ISolarSystemData>();
        }
    }
}
