using Reloaded.ModHelper;
using System.Collections.Generic;

namespace NoMansSky.Api
{
    /// <summary>
    /// The parent class for interacting with and getting all information from No Mans Sky.
    /// </summary>
    public interface IGame : IReloadedGame
    {
        /// <summary>
        /// Instance of the Game class that has been initialized and is currently managing the actual NMS Game.
        /// </summary>
        public static IGame Instance { get; set; }

        /// <summary>
        /// Represents the Galaxy Map.
        /// </summary>
        public IGalaxyMap GalaxyMap { get; }

        /// <summary>
        /// Handles the colors for all of space in NMS.
        /// </summary>
        public ISpaceColors SpaceColors { get; }

        /// <summary>
        /// Handles the weather in the game.
        /// </summary>
        public IWeatherData WeatherData { get; }

        /// <summary>
        /// Represents the solar system that the player is currently in.
        /// </summary>
        public ISolarSystem CurrentSystem { get; }

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
        /// <br/><br/>Example:
        /// <example>
        /// <code>
        /// Game.OnMainMenu.AddListener(() =>
        /// {
        ///     // your code here
        /// });
        /// </code>
        /// </example>
        /// </summary>
        public IModEvent OnMainMenu { get; set; }

        /// <summary>
        /// Called when a profile is selected by the user.
        /// <br/>A profile is one of the save files that are shown on the load screen.
        /// <br/><br/>Example:
        /// <example>
        /// <code>
        /// Game.OnProfileSelected.AddListener(() =>
        /// {
        ///     // your code here
        /// });
        /// </code>
        /// </example>
        /// </summary>
        public IModEvent OnProfileSelected { get; set; }

        /// <summary>
        /// Called whenever the player first joins the game after selecting a profile.
        /// <br/><br/>Example:
        /// <example>
        /// <code>
        /// Game.OnGameJoined.AddListener(() =>
        /// {
        ///     // your code here
        /// });
        /// </code>
        /// </example>
        /// </summary>
        public IModEvent OnGameJoined { get; set; }

        /// <summary>
        /// Called when the player first starts warping to a new system.
        /// <br/><br/>Example:
        /// <example>
        /// <code>
        /// Game.OnWarpStarted.AddListener(() =>
        /// {
        ///     // your code here
        /// });
        /// </code>
        /// </example>
        /// </summary>
        public IModEvent OnWarpStarted { get; set; }

        /// <summary>
        /// Called once the player has finished warping into a new system.
        /// <br/><br/>Example:
        /// <example>
        /// <code>
        /// Game.OnWarpFinished.AddListener(() =>
        /// {
        ///     // your code here
        /// });
        /// </code>
        /// </example>
        /// </summary>
        public IModEvent OnWarpFinished { get; set; }

        /// <summary>
        /// Will execute for each EnvironmentObject when it's loaded by the game.
        /// Since the game reloads the Biome Files each time the player warps to a new system,
        /// this will be called for each object each time you load into a system.
        /// </summary>
        public IModEvent<IEnvironmentObject> OnEnvironmentObjectLoaded { get; set; }


        /// <summary>
        /// Called when the player opens the Inventories screen.
        /// <br/>This is the screen that lets them view the inventories for their ship, freigher, multi-tool, etc.
        /// <br/><br/>Example:
        /// <example>
        /// <code>
        /// Game.OnInventoriesOpened.AddListener(() =>
        /// {
        ///     // your code here
        /// });
        /// </code>
        /// </example>
        /// </summary>
        public IModEvent OnInventoriesOpened { get; set; }

        /// <summary>
        /// Called when the player closes the Inventories screen.
        /// <br/>This is the screen that lets them view the inventories for their ship, freigher, multi-tool, etc.
        /// <br/><br/>Example:
        /// <example>
        /// <code>
        /// Game.OnInventoriesClosed.AddListener(() =>
        /// {
        ///     // your code here
        /// });
        /// </code>
        /// </example>
        /// </summary>
        public IModEvent OnInventoriesClosed { get; set; }

        /// <summary>
        /// Contains all of the environment object files used by the game to generate biomes.
        /// </summary>
        public List<IEnvironmentObject> EnvironmentObjects { get; }

        /// <summary>
        /// A manager for all of the currently loaded MBIN files.
        /// </summary>
        public IMBinManager MBinManager { get; set; }

        /// <summary>
        /// Reflects whether or not the player is still on the main menu.
        /// <br/><br/>Example:
        /// <example>
        /// <code>
        /// if (Game.IsOnMainMenu)
        /// {
        ///     // your code here
        /// }
        /// </code>
        /// </example>
        /// </summary>
        public bool IsOnMainMenu { get; }

        /// <summary>
        /// Reflects whether or not the player has selected a profile to play on.
        /// <br/><br/>Example:
        /// <example>
        /// <code>
        /// if (Game.IsProfileSelected)
        /// {
        ///     // your code here
        /// }
        /// </code>
        /// </example>
        /// </summary>
        public bool IsProfileSelected { get; }

        /// <summary>
        /// Reflects whether or not the player is currently loading into 
        /// the game world after selecting a save file.
        /// <br/><br/>Example:
        /// <example>
        /// <code>
        /// if (Game.IsLoadingIntoGame)
        /// {
        ///     // your code here
        /// }
        /// </code>
        /// </example>
        /// </summary>
        public bool IsLoadingIntoGame { get; }


        /// <summary>
        /// Reflects whether or not the player has loaded into the game.
        /// <br/><br/>Example:
        /// <example>
        /// <code>
        /// if (Game.IsInGame)
        /// {
        ///     // your code here
        /// }
        /// </code>
        /// </example>
        /// </summary>
        public bool IsInGame { get; }

        /// <summary>
        /// Reflects whether or not the player's personal inventory screen is currently showing.
        /// <br/>This is the screen that lets them view the inventories for their ship, freigher, multi-tool, etc.
        /// <br/><br/>Example:
        /// <example>
        /// <code>
        /// if (Game.IsInventoryOpen)
        /// {
        ///     // your code here
        /// }
        /// </code>
        /// </example>
        /// </summary>
        public bool IsInventoryOpen { get; }

        /// <summary>
        /// Reflects whether or not this object has finished initializing.
        /// <br/><br/>Example:
        /// <example>
        /// <code>
        /// if (Game.IsInitialized)
        /// {
        ///     // your code here
        /// }
        /// </code>
        /// </example>
        /// </summary>
        public bool IsInitialized { get; }

        /// <summary>
        /// Reflects whether or not the player is currently warping to a new system.
        /// <br/><br/>Example:
        /// <example>
        /// <code>
        /// if (Game.IsWarping)
        /// {
        ///     // your code here
        /// }
        /// </code>
        /// </example>
        /// </summary>
        public bool IsWarping { get; }

        


        /// <summary>
        /// Reflects whether or not the "Warning Mods Installed" message will be shown while starting
        /// the game.
        /// <br/><br/>This feature was discovered by RaYRoD TV#7679 and wouldn't exist without his efforts.
        /// </summary>
        public IModWarning ModsWarning { get; }


    }
}
