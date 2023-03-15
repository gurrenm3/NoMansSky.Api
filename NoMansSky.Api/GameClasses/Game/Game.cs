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
    internal sealed class Game : ReloadedGame, IGame
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public static Game? Instance { get; set; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [FindOffset("4C 8B FA 4C 8B F1 48 8D 0D ? ? ? ? E8 ? ? ? ? 48 8D 95 ? ? ? ? ", 9)]
        public long GcApplicationAddress { get; private set; }

        public Dictionary<string, Type> MbinNamesAndTypes { get; set; } = new Dictionary<string, Type>();


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
        public bool IsOnMainMenu { get; private set; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public bool IsInGame { get; private set; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public bool IsInventoryOpen { get; private set; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public bool IsInitialized { get; private set; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public bool IsLoadingIntoGame { get; internal set; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public bool IsProfileSelected { get; private set; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IModWarning ModsWarning => _modWarning;
        private IModWarning _modWarning;


        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IModEvent<long> OnGcApplicationAcquired { get; set; } = new SharedModEvent<long>();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IModEvent OnInitialized { get; set; } = new SharedModEvent();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IModEvent OnMainMenu { get; set; } = new SharedModEvent();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IModEvent OnProfileSelected { get; set; } = new SharedModEvent();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IModEvent OnWarpStarted { get; set; } = new SharedModEvent();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IModEvent OnWarpFinished { get; set; } = new SharedModEvent();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public bool IsWarping { get; internal set; }


        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IModEvent OnGameJoined { get; set; } = new SharedModEvent();


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

            GcApplicationAddress = GetGameBaseAddress();
            OnGcApplicationAcquired.Run(GcApplicationAddress);
            logger.WriteLine($"Discovered GameBaseAddress at {GcApplicationAddress.ToHex()}");

            BinariesDirectory = Environment.CurrentDirectory;
            NMSDirectory = Directory.GetParent(BinariesDirectory).FullName;
            GameDataDirectory = $"{NMSDirectory}\\GAMEDATA";
            ModsDirectory = $"{GameDataDirectory}\\MODS";

            
            logger.WriteLine("Hooked game loop temporarily disabled...");

            //GameLoop = new HookedGameLoop();
            GameLoop = PseudoGameLoop.CreateNew(true);
            GameLoop.Initialize();
            

            InitModEvents();

            Player = new Player(logger);
            (Player as Player)?.Init();

            _modWarning = new ModWarning(logger);

            OnInitialized.Run();
            IsInitialized = true;
        }

        private long GetGameBaseAddress()
        {
            var propInfo = GetType().GetProperty(nameof(GcApplicationAddress));
            var offsetAttribute = propInfo.GetCustomAttribute<FindOffsetAttribute>();
            long nextInstructionAddr = offsetAttribute.PatternAddress + offsetAttribute.numBytesToOffset - 5; // subtracting 5 because it's a lea instruction and thats how that works.
            return nextInstructionAddr + offsetAttribute.DiscoveredOffset;
        }

        private void InitModEvents()
        {
            // profile selected events
            OnProfileSelected += () =>
            {
                IsOnMainMenu = false;
                IsProfileSelected = true;
                IsLoadingIntoGame = true;
            };

            OnWarpFinished += () => IsWarping = false;

            // main menu events
            OnMainMenu += () =>
            {
                IsProfileSelected = false;
                IsInGame = false;
                IsOnMainMenu = true;
            };
        }
    }
}
