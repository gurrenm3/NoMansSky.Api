using Reloaded.ModHelper;

namespace NoMansSky.Api
{
    public sealed class Game
    {
        /// <summary>
        /// Instance of this class.
        /// </summary>
        public static Game Instance { get; private set; }

        /// <summary>
        /// Instance of the Game Loop
        /// </summary>
        public IGameLoop GameLoop { get; set; }

        /// <summary>
        /// Instance of the player
        /// </summary>
        public GcPlayerStateData Player { get; set; } = new GcPlayerStateData();

        /// <summary>
        /// Called when the main menu is first reached.
        /// </summary>
        public ISharedModEvent OnMainMenu { get; set; }

        /// <summary>
        /// Called when a profile is selected by the user.
        /// </summary>
        public ISharedModEvent OnProfileSelected { get; set; }

        public Game()
        {
            if (Instance == null)
                Instance = this;
        }
    }
}
