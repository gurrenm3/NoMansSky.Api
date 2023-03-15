using Reloaded.ModHelper;
using System;
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
        /// The base address for GcApplication.
        /// </summary>
        public long GcApplicationAddress { get; }

        /// <summary>
        /// Called when the address for GcApplication is acquired.
        /// </summary>
        public IModEvent<long> OnGcApplicationAcquired { get; set; }

        /// <summary>
        /// This is for testing. Remove laster
        /// </summary>
        public Dictionary<string, Type> MbinNamesAndTypes { get; set; }

        /// <summary>
        /// The main directory for No Mans Sky.
        /// <br/>Ex: steamapps\common\No Man's Sky
        /// </summary>
        public string NMSDirectory { get; }

        /// <summary>
        /// The location of the "Binaries" folder for No Mans Sky.
        /// </summary>
        public string BinariesDirectory { get; }

        /// <summary>
        /// The location of the "GAMEDATA" folder for No Mans Sky.
        /// </summary>
        public string GameDataDirectory { get; }

        /// <summary>
        /// The location of the "Mods" folder used by all mods made with this API.
        /// <br/>Note: this is not the same mods folder that traditional MBIN mods use.
        /// </summary>
        public string ModsDirectory { get; }


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
        /// Game.OnMainMenu.AddRunner(() =>
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
        /// Game.OnProfileSelected.AddRunner(() =>
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
        /// Game.OnGameJoined.AddRunner(() =>
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
        /// Game.OnWarpStarted.AddRunner(() =>
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
        /// Game.OnWarpFinished.AddRunner(() =>
        /// {
        ///     // your code here
        /// });
        /// </code>
        /// </example>
        /// </summary>
        public IModEvent OnWarpFinished { get; set; }


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
