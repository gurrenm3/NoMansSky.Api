using NoMansSky.Api.Hooks.GalaxyMapHooks;
using Reloaded.ModHelper;

namespace NoMansSky.Api
{
    /// <summary>
    /// Represents the Galaxy Map.
    /// </summary>
    public class GalaxyMap : IGalaxyMap
    {
        /// <summary>
        /// TODO
        /// <br/><br/><inheritdoc/>
        /// </summary>
        public IModEvent<ISolarSystemData> OnSystemHighlighted { get; set; } 
            = new SharedModEvent<ISolarSystemData>();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public bool IsOpened { get; internal set; } // managed in GalaxyMap.Update hook

        public GalaxyMap()
        {
            OnSystemHighlighted = new SharedModEvent<ISolarSystemData>();
        }
    }
}
