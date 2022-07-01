using Reloaded.ModHelper;

namespace NoMansSky.Api
{
    /// <summary>
    /// Represents the GalaxyMap
    /// </summary>
    public interface IGalaxyMap
    {
        /// <summary>
        /// Called whenever the GalaxyMap is first opened. Not called while it's opened.
        /// </summary>
        public IModEvent OnOpened { get; set; }

        /// <summary>
        /// Called when GalaxyMap is closed. This could be by exiting it or by initiating warp.
        /// </summary>
        public IModEvent OnClosed { get; set; }

        /// <summary>
        /// Called whenever a solar system is highlighted.
        /// <br/>Passes along the data about the system that was highlighted.
        /// </summary>
        //public IModEvent<ISolarSystem> OnSystemHighlighted { get; set; }

        /// <summary>
        /// Reflects whether or not the Galaxy Map is currently opened.
        /// </summary>
        public bool IsOpened { get; }
    }
}
