using Reloaded.ModHelper;
using System.Collections.Generic;

namespace NoMansSky.Api
{
    /// <summary>
    /// A parent class for interacting with and getting all information from No Mans Sky.
    /// </summary>
    public interface IGame : IReloadedGame
    {
        /// <summary>
        /// Instance of the Game class that has been initialized and is currently managing the actual NMS Game.
        /// </summary>
        public static IGame Instance { get; set; }

        /// <summary>
        /// The instance of the Player class that has been initialized and is currently managing the actual NMS Player.
        /// </summary>
        public IPlayer Player { get; }

        /// <summary>
        /// Called when this object, <see cref="Instance"/>, has finished initializing.
        /// <br/>This is mainly used by the API to initialize and load it's features after everything else has started. 
        /// <br/>By the time your mod executes this will have already been called, therefore it can to ignore it.
        /// </summary>
        public IModEvent OnInitialized { get; set; }

        /// <summary>
        /// Called whenever the main menu is reached.
        /// </summary>
        public IModEvent OnMainMenu { get; set; }

        /// <summary>
        /// Called when a profile is selected by the user.
        /// <br/>A profile is one of the save files that are shown on the load screen.
        /// </summary>
        public IModEvent OnProfileSelected { get; set; }

        /// <summary>
        /// Called whenever the player first joins the game after selecting a profile.
        /// </summary>
        public IModEvent OnGameJoined { get; set; }

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
        /// A manager for all of the currently loaded MBIN files.
        /// </summary>
        public IMBinManager MBinManager { get; set; }

        /// <summary>
        /// Reflects whether or not the player has loaded into the game.
        /// </summary>
        public bool IsInGame { get; }

        /// <summary>
        /// Reflects whether or not the player's personal inventory screen is currently showing.
        /// <br/>This is the screen that lets them view the inventories for their ship, freigher, multi-tool, etc.
        /// </summary>
        public bool IsInventoryOpen { get; }

        /// <summary>
        /// Reflects whether or not this object has finished initializing.
        /// </summary>
        public bool IsInitialized { get; }
    }
}
