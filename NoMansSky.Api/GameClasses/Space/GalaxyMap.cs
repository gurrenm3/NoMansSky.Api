using NoMansSky.Api.Hooks.GalaxyMap;
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
        public IModEvent OnOpened { get; set; } = new SharedModEvent();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IModEvent OnClosed { get; set; } = new SharedModEvent();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public bool IsOpened { get; internal set; } // managed in GalaxyMap.Update hook


        /// <summary>
        /// Creates an instance of this class.
        /// </summary>
        public GalaxyMap()
        {
            
        }
    }
}
