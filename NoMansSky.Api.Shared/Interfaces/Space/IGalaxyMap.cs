using Reloaded.ModHelper;

namespace NoMansSky.Api
{
    /// <summary>
    /// Represents the GalaxyMap
    /// </summary>
    public interface IGalaxyMap
    {
        /// <summary>
        /// Called whenever a solar system is highlighted.
        /// <br/>Passes along the data about the system that was highlighted.
        /// </summary>
        public IModEvent<ISolarSystemData> OnSystemHighlighted { get; set; }
    }
}
