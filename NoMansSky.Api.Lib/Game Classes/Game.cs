using Reloaded.ModHelper;

namespace NoMansSky.Api
{
    /// <summary>
    /// Parent class for interacting with and getting information from No Mans Sky.
    /// </summary>
    public sealed class Game
    {
        /// <summary>
        /// Instance of this class.
        /// </summary>
        public static Game Instance { get; private set; }

        /// <summary>
        /// Instance of the player
        /// </summary>
        public Player Player { get; set; }

        /// <summary>
        /// Reflects whether or not the player has loaded into the game.
        /// </summary>
        public bool IsInGame { get; private set; }

        /// <summary>
        /// Reflects whether or not the player's personal inventory screen is currently showing.
        /// <br/>This is the screen that lets them view the inventories for their ship, freigher, multi-tool, etc.
        /// </summary>
        public bool IsInventoryOpen { get; private set; }

        /// <summary>
        /// Called when the main menu is first reached.
        /// </summary>
        public IModEvent OnMainMenu { get; set; }

        /// <summary>
        /// Called when the player first enters the game.
        /// </summary>
        public IModEvent OnGameJoined { get; set; }

        /// <summary>
        /// Called when a profile is selected by the user.
        /// </summary>
        public IModEvent OnProfileSelected { get; set; }

        /// <summary>
        /// Called when the player opens the Inventories screen.
        /// <br/>This is the screen that lets them view the inventories for their ship, freigher, multi-tool, etc.
        /// </summary>
        public IModEvent OnInventoriesOpened { get; set; }

        /// <summary>
        /// Called when the player closes the Inventories screen.
        /// <br/>This is the screen that lets them view the inventories for their ship, freigher, multi-tool, etc.
        /// </summary>
        public IModEvent OnInventoriesClosed { get; set; }

        /// <summary>
        /// Called once every frame.
        /// <br/>The parameter is the amount of time that has passed since the last frame.
        /// </summary>
        public IModEventHook OnUpdate { get; set; }

        /// <summary>
        /// Contains info about the passage of time throughout the game.
        /// </summary>
        public ITime Time { get; set; }

        private bool isInitialized = false;

        public Game()
        {
            if (Instance == null)
                Instance = this;
        }

        /// <summary>
        /// Used to initialize some of the game info.
        /// </summary>
        /// <returns></returns>
        public bool Initialize()
        {
            if (isInitialized)
                return false;

            OnGameJoined += () => IsInGame = true;
            OnInventoriesOpened += () => IsInventoryOpen = true;
            OnInventoriesClosed += () => IsInventoryOpen = false;

            return isInitialized = true;
        }
    }
}
