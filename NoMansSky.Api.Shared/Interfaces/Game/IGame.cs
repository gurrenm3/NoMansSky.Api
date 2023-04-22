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
        /// Pointer to GcApplication.
        /// </summary>
        public long GcApplicationPtr { get; set; }

        /// <summary>
        /// Called when GcGameState is acquired.
        /// </summary>
        public IModEvent OnGcApplicationAcquired { get; set; }

        /// <summary>
        /// Called when the main menu is reached.
        /// </summary>
        public IModEvent OnMainMenu { get; set; }

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
        /// A manager for all of the currently loaded MBIN files.
        /// </summary>
        public IMBinManager MBinManager { get; set; }        


        /// <summary>
        /// Reflects whether or not the "Warning Mods Installed" message will be shown while starting
        /// the game.
        /// <br/><br/>This feature was discovered by RaYRoD TV#7679 and wouldn't exist without his efforts.
        /// </summary>
        public IModWarning ModsWarning { get; }

        /// <summary>
        /// Represents the TextChat box in game.
        /// </summary>
        public ITextChat TextChat { get; }
    }
}
