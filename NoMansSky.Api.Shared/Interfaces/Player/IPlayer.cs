using Reloaded.ModHelper;

namespace NoMansSky.Api
{
    /// <summary>
    /// Represents the Local Player.
    /// </summary>
    public interface IPlayer
    {
        /// <summary>
        /// The base address of the actual player instance within the game.
        /// </summary>
        public long Pointer { get; }

        /// <summary>
        /// Called when the pointer to the actual Player Instance has been aquired.
        /// </summary>
        public IModEvent<long> OnPointerAquired { get; set; }
    }
}
