using NoMansSky.Api.Definitions;
using NoMansSky.Api.Definitions;
using Reloaded.ModHelper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace NoMansSky.Api
{
    /// <summary>
    /// The parent class for interacting with and getting all information from No Mans Sky.
    /// </summary>
    internal sealed unsafe class Game : ReloadedGame, IGame
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public static Game? Instance { get; set; }

        public Dictionary<string, Type> MbinNamesAndTypes { get; set; } = new();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IModEvent OnGcApplicationAcquired { get; set; } = new SharedModEvent();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IModEvent OnMainMenu { get; set; } = new SharedModEvent();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IPlayer Player { get; set; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IMBinManager MBinManager { get; set; } = new MBinManager();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public string NMSDirectory { get; private set; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public string BinariesDirectory { get; private set; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public string GameDataDirectory { get; private set; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public string ModsDirectory { get; private set; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public long GcApplicationPtr { get; set; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IModWarning ModsWarning { get; private set; }

        public cGcApplication* gcApplication;

        private IModLogger logger;

        /// <summary>
        /// Creates a new instance of this class.
        /// </summary>
        public Game(IModLogger apiLogger)
        {
            if (Instance != null)
                return;

            logger = apiLogger;
            Initialize();
        }

        /// <summary>
        /// Used by the API to initialize some of the game info.
        /// </summary>
        /// <returns></returns>
        private void Initialize()
        {
            Instance = this;
            IGame.Instance = this;

            BinariesDirectory = Environment.CurrentDirectory;
            NMSDirectory = Directory.GetParent(BinariesDirectory).FullName;
            GameDataDirectory = $"{NMSDirectory}\\GAMEDATA";
            ModsDirectory = $"{GameDataDirectory}\\MODS";

            //GameLoop = PseudoGameLoop.CreateNew(true);
            GameLoop = new HookedGameLoop();
            GameLoop.Initialize();

            Player = new Player(logger);
            (Player as Player)?.Init();
            
            
            ModsWarning = new ModWarning(logger);
        }
    }
}
