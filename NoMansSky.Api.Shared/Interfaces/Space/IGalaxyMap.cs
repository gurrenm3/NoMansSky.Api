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

        /// <summary>
        /// Reflects whether or not the Galaxy Map is currently opened.
        /// </summary>
        public bool IsOpened { get; }
    }
}
